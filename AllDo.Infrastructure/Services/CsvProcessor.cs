using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllDo.Domain;
using AllDo.Infrastructure.Data.Models;
using CsvHelper;
using Microsoft.AspNetCore.Http;

namespace AllDo.Infrastructure.Services
{
    public class CsvProcessor : ICsvProcessor
    {
        public List<BugDto> ExtractBugsFromFile(IFormFile csvFile)
        {
            var result = new List<BugDto>();

            using (var stream = csvFile.OpenReadStream())
            using (var reader = new StreamReader(stream))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
            {
                var bugs = csv.GetRecords<BugCsvRecord>();

                foreach (var bugRecord in bugs)
                {
                    result.Add(new BugDto(bugRecord.Title, bugRecord.Description, bugRecord.AffectedVersion, bugRecord.AffectedUsers, null, Enumerable.Empty<byte[]>(), Enum.Parse<Domain.Severity>(bugRecord.Severity, true))
                    {
                        CreatedDate = DateTimeOffset.UtcNow,

                        //TODO replace CreatedBy with logged in user
                        CreatedBy = new UserDto(String.Empty) { Id = Guid.Parse("644D7218-42F9-479C-8436-EBE5224AF97E") },
                        DueDate = DateTimeOffset.Parse(bugRecord.DueDate),
                    });
                }
            }

            return result;
        }
    }

    public record BugCsvRecord(string Title, string DueDate, string Description, string Severity, string AffectedVersion, int AffectedUsers, string Component, string Priority);

}