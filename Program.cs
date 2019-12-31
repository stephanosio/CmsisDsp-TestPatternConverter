using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using CommandLine;

using TestPatternConverter.Converters;
using TestPatternConverter.Models;
using TestPatternConverter.Tests;

namespace TestPatternConverter
{
    enum ReturnCode
    {
        Success = 0,
        TestCodeBasePathDoesNotExist = 10,
        PatternBasePathDoesNotExist = 11,
        InvalidTestName = 20
    }

    partial class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args).WithParsed(opts => OnRun(opts));
        }

        static int OnRun(Options options)
        {
            IList<TestModel> tests;

            if (options.Tests.Count() == 0)
            {
                //
                // If no specific test is designated, convert all.
                //

                tests = new List<TestModel>(Tests.TestModels);
            }
            else
            {
                //
                // Convert test patterns for all selected tests.
                //

                try
                {
                    tests = options.Tests.Select(t => Tests.Find(t)).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid test name: {ex.Message}");
                    return (int)ReturnCode.InvalidTestName;
                }
            }

            //
            // Validate base paths.
            //

            if (Directory.Exists(options.TestCodeBasePath) == false)
            {
                Console.WriteLine("Test code base path does not exist.");
                return (int)ReturnCode.TestCodeBasePathDoesNotExist;
            }
            else if (Directory.Exists(options.PatternBasePath) == false)
            {
                Console.WriteLine("Pattern base path does not exist.");
                return (int)ReturnCode.PatternBasePathDoesNotExist;
            }

            //
            // Create test converter.
            //

            TestConverter tc = new TestConverter(
                options.TestCodeBasePath, options.PatternBasePath, options.Verbose);

            foreach (TestModel test in tests)
            {
                Console.WriteLine($"Converting {test.TestCodePath} ...");
                tc.Convert(test);
            }

            return (int)ReturnCode.Success;
        }
    }
}
