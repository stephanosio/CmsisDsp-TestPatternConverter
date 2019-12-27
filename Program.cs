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
        const string TestCodeBasePath = @"TBD";
        const string PatternBasePath = @"Z:\CMSIS_5\CMSIS\DSP\Testing\Patterns\DSP";

        static void Main(string[] args)
        {
            StringWriter writer = new StringWriter();
            TestConverter tc = new TestConverter(TestCodeBasePath, PatternBasePath);

            tc.Convert(writer, SvmTest.Find("svm/src/f32.c"));

            Console.WriteLine(writer.ToString());
        }
    }
}
