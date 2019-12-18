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

        public TestConverter(string testCodeBasePath, string patternBasePath)
        {
            TestCodeBasePath = testCodeBasePath;
            PatternBasePath = patternBasePath;
        }

        public void Convert(TextWriter writer, TestModel test)
        {
            //
            // Enumerate all patterns.
            //

            foreach (PatternModel pattern in test.Patterns)
            {
                //
                // Create pattern converter.
                //

                PatternConverter pc = new PatternConverter(test, PatternBasePath);

                //
                // Convert pattern.
                //

                pc.Convert(writer, pattern);

                //
                // Add a separation line.
                //

                writer.WriteLine();
                writer.WriteLine();
            }
        }

        /*
         * TODO: Consider implementing automatic test pattern update in the source code.
         */
    }
}
