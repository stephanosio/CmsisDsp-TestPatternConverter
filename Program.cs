using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        const string inputPath = @"Z:\CMSIS_5\CMSIS\DSP\Testing\Patterns\DSP\BasicMaths\BasicMathsQ7\Input1_q7.txt";

        static void Main(string[] args)
        {
            /* Open input file */
            StreamReader inputFile = File.OpenText(inputPath);

            /* Read input array header */
            string inputArrayType = inputFile.ReadLine();
            int inputArrayLength = int.Parse(inputFile.ReadLine());
            string[] inputArrayData = new string[inputArrayLength];

            /* Read input array data */
            for (int index = 0; index < inputArrayLength;)
            {
                /* Read line */
                string line = inputFile.ReadLine().Trim();

                /* Ignore comment */
                if (!line.StartsWith("//"))
                {
                    inputArrayData[index++] = line;
                }
            }

            /* Create output array builder */
            StringBuilder outputArrayBuilder = new StringBuilder();

            /* Generate array header */
            switch (inputArrayType)
            {
                case "B":
                    outputArrayBuilder.Append("uint8_t");
                    break;
                case "H":
                    outputArrayBuilder.Append("uint16_t");
                    break;
                case "W":
                    outputArrayBuilder.Append("uint32_t");
                    break;
                default:
                    throw new Exception("Invalid input array type");
            }

            outputArrayBuilder.AppendFormat(" pattern[{0:D}] = {{ ", inputArrayLength);
            outputArrayBuilder.AppendLine();
            outputArrayBuilder.Append("    ");

            /* Generate array data */
            for (int index = 0; index < inputArrayLength; index++)
            {
                outputArrayBuilder.Append(inputArrayData[index]);

                /* Add separator if not last */
                if (index != (inputArrayLength - 1))
                {
                    outputArrayBuilder.Append(", ");

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
                        default:
                            throw new Exception("Invalid input array type");
                    }

                    /* Change line at the specified criteria */
                    if (((index + 1) % lineChangeAlignment) == 0)
                    {
                        outputArrayBuilder.AppendLine();
                        outputArrayBuilder.Append("    ");
                    }
                }
                else
                {
                    outputArrayBuilder.Append(" ");
                }
            }

            /* Generate array footer */
            outputArrayBuilder.AppendLine();
            outputArrayBuilder.Append("    };");

            /* Print out result */
            Console.WriteLine(outputArrayBuilder.ToString());
        }
    }
}
