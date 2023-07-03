using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MyCSharpConsoleApp
{
    public record MyRecord(int X, int Y);


    public class RecordTest
    {
        private readonly ILogger<RecordTest> _logger;

        public RecordTest(ILogger<RecordTest> logger)
        {
            _logger = logger;
            MyRecord mr = new(10, 20);
            Console.WriteLine(mr.ToString());
            _logger.LogInformation(mr.ToString());
        }

        public void Run()
        {
            _logger.LogDebug("Running application");
        }
    }
}
