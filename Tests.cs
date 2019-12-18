using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestPatternConverter.Tests;

namespace TestPatternConverter
{
    partial class Program
    {
        public static BasicMathTest BasicMathTest { get; } = new BasicMathTest();
        public static ComplexMathTest ComplexMathTest { get; } = new ComplexMathTest();
        public static FastMathTest FastMathTest { get; } = new FastMathTest();
        public static SupportTest SupportTest { get; } = new SupportTest();
        public static StatisticsTest StatisticsTest { get; } = new StatisticsTest();
    }
}
