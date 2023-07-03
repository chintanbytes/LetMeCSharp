using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.CSharp
{
    public class Pair<TFirst, TSecond>
    {
        public TFirst First;
        public TSecond Second;

        public Pair(TFirst first, TSecond second)
        => (First, Second) = (first, second);
    }

    public class TryPair
    {
        private Pair<int, string> _pair = new (1, "Chintan");

    }

    [Flags]
    public enum Months
    {
        None = 0,
        January = 1,
        February = 2,
        March = 4,
        April = 8,
        May = 16,
        June = 32,
        July = 64,
        August = 128,
        September = 256,
        October = 512,
        November = 1024,
        December = 2048,
        Q1 = January | February | March,
        Q2 = April | May | June,
        Q3 = July | August | September,
        Q4 = October | November | December,
        H1 = Q1 | Q2,
        H2 = Q3 | Q4
    } 
}