using Scheduler.Model;
using System.Collections.Generic;

namespace Scheduler.CsvParser.Interface
{
    public interface ICSVParserService
    {
        IEnumerable<Mail> GetMessages();
    }
}
