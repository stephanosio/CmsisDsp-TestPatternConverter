using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using TestPatternConverter.Converters;
using TestPatternConverter.Models;
using TestPatternConverter.Tests;

namespace TestPatternConverter
{
    partial class Program
    {
        const string TestCodeBasePath = @"Z:\zephyr-public\zephyr\tests\lib\cmsis_dsp";
        const string PatternBasePath = @"Z:\CMSIS_5\CMSIS\DSP\Testing\Patterns\DSP";

        static void Main(string[] args)
        {
            StringWriter writer = new StringWriter();
            TestConverter tc = new TestConverter(TestCodeBasePath, PatternBasePath);

#if false
            tc.Convert(Tests.Find("transform/src/q15.c"), writer);
            Console.WriteLine(writer.ToString());
#else
            tc.Convert(Tests.Find("transform/src/q15.c"));
#endif
        }
    }
}
