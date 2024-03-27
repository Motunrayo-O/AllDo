using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllDo.Domain;
using AllDo.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Http;

namespace AllDo.Infrastructure.Services
{
    public interface ICsvProcessor
    {
        List<BugDto> ExtractBugsFromFile(IFormFile csvFile);
    }
}