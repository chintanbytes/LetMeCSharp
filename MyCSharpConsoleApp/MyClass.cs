using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MyCSharpConsoleApp;

public class MyClass
{
    private int _myInt;
    private readonly ILogger<MyClass> _logger;

    public MyClass(int myInt, ILogger<MyClass> logger)
    {
        _myInt = myInt;
        _logger = logger;
    }
}