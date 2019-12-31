using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using TestPatternConverter.Models;

namespace TestPatternConverter.Converters
{
    public class PatternConverter
    {
        /// <summary>
        /// Test
        /// </summary>
        public TestModel Test { get; }

        /// <summary>
        /// Base path to the CMSIS-DSP test patterns
        /// (in the CMSIS-DSP repository)
        /// </summary>
        public string PatternBasePath { get; }

        /// <summary>
        /// Display verbose status messages
        /// </summary>
        public bool Verbose { get; }

        public PatternConverter(TestModel test, string patternBasePath, bool verbose = false)
        {
            Test = test;
            PatternBasePath = patternBasePath;
            Verbose = verbose;
        }

        public void Convert(TextWriter writer, PatternModel pattern)
        {
            //
            // Open input file.
            //

            string patternFilePath = Path.Combine(
                PatternBasePath, Test.PatternRootPath, pattern.PatternFileName);

            StreamReader inputFile = File.OpenText(patternFilePath);

            if (Verbose)
            {
                Console.WriteLine($"    Input Pattern File Path = {patternFilePath}");
            }

            //
            // Read input array header.
            //

            string inputArrayType = inputFile.ReadLine();
            int inputArrayLength = int.Parse(inputFile.ReadLine());
            string[] inputArrayData = new string[inputArrayLength];

            //
            // Read input array data.
            //

            for (int index = 0; index < inputArrayLength;)
            {
                // Read line.
                string line = inputFile.ReadLine().Trim();

                // Ignore comment.
                if (!line.StartsWith("//"))
                {
                    inputArrayData[index++] = line;
                }
            }

            //
            // Generate array header.
            //

            // Constraints
            writer.Write("static const ");

            // Type
            writer.Write(pattern.VariableType);
            writer.Write(" ");

            // Name
            writer.Write(pattern.VariableName);

            // Array Size
            writer.Write("[{0}]", inputArrayLength);

            // Array Initialiser Begin
            writer.Write(" = {");
            writer.WriteLine();

            //
            // Generate array data.
            //

            writer.Write("    ");

            for (int index = 0; index < inputArrayLength; index++)
            {
                writer.Write(inputArrayData[index]);

                /* Add separator if not last */
                if (index != (inputArrayLength - 1))
                {
                    writer.Write(", ");

                    /* Set line change criteria */
                    int lineChangeAlignment;

                    switch (inputArrayType)
                    {
                        case "B":
                            lineChangeAlignment = 8;
                            break;
                        case "H":
                            lineChangeAlignment = 8;
                            break;
                        case "W":
                            lineChangeAlignment = 4;
                            break;
                        case "D":
                            lineChangeAlignment = 2;
                            break;
                        default:
                            throw new Exception("Invalid input array type");
                    }

                    /* Change line at the specified criteria */
                    if (((index + 1) % lineChangeAlignment) == 0)
                    {
                        writer.WriteLine();
                        writer.Write("    ");
                    }
                }
                else
                {
                    writer.Write(" ");
                }
            }

            //
            // Generate array footer.
            //

            writer.WriteLine();
            writer.Write("    };");
        }
    }
}
