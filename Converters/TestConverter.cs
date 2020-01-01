/*
 * Copyright (c) 2019 Stephanos Ioannidis <root@stephanos.io>
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using TestPatternConverter.Models;

namespace TestPatternConverter.Converters
{
    public class TestConverter
    {
        /// <summary>
        /// Base path to the test code
        /// (in the Zephyr repository)
        /// </summary>
        public string TestCodeBasePath { get; }

        /// <summary>
        /// Base path to the CMSIS-DSP test patterns
        /// (in the CMSIS-DSP repository)
        /// </summary>
        public string PatternBasePath { get; }

        /// <summary>
        /// Display verbose status messages
        /// </summary>
        public bool Verbose { get; }

        public TestConverter(string testCodeBasePath, string patternBasePath, bool verbose = false)
        {
            TestCodeBasePath = testCodeBasePath;
            PatternBasePath = patternBasePath;
            Verbose = verbose;
        }

        public void Convert(TestModel test, TextWriter writer)
        {
            //
            // Enumerate all patterns.
            //

            foreach (PatternModel pattern in test.Patterns)
            {
                //
                // Create pattern converter.
                //

                PatternConverter pc = new PatternConverter(test, PatternBasePath, Verbose);

                //
                // Convert pattern.
                //

                Console.WriteLine($"  Converting pattern {pattern.VariableName} ...");
                pc.Convert(writer, pattern);

                //
                // Add a separation line.
                //

                writer.WriteLine();
                writer.WriteLine();
            }
        }

        public void Convert(TestModel test)
        {
            //
            // Resolve pattern path.
            //

            string testCodeFilePath = Path.GetDirectoryName(test.TestCodePath);
            string testCodeFileName = Path.GetFileNameWithoutExtension(test.TestCodePath);

            string testCodePatternFileName = $"{testCodeFileName}.pat";
            string testCodePatternFilePath = Path.Combine(testCodeFilePath, testCodePatternFileName);
            string testCodePatternFileFullPath = Path.Combine(TestCodeBasePath, testCodePatternFilePath);

            if (Verbose)
            {
                Console.WriteLine($"  Output Test Code Pattern File Path = {testCodePatternFileFullPath}");
            }

            //
            // Open test code pattern file.
            //

            FileStream testCodePatternFile = File.Open(
                testCodePatternFileFullPath, FileMode.Create, FileAccess.Write, FileShare.None);

            StreamWriter testCodePatternWriter = new StreamWriter(testCodePatternFile);

            //
            // Convert test patterns.
            //

            Convert(test, testCodePatternWriter);

            //
            // Flush test code pattern file stream.
            //

            testCodePatternWriter.Flush();
        }
    }
}
