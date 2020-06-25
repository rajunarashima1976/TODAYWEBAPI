using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBA.Training.Talmate.Api.LoggerService
{
    public interface ILoggerService
    {
        Task<bool> WriteErrorToFile(string text);
        Task<bool> WriteActionExecutionToFile(string text);
    }
}
