using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternConverter.Models
{
    public class PatternModel
    {
        /// <summary>
        /// Name of the pattern variable in the Zephyr test source code
        /// </summary>
        public string VariableName { get; set; }

        /// <summary>
        /// Type of the pattern variable in the Zephyr test source code
        /// </summary>
        public string VariableType { get; set; }

        /// <summary>
        /// Name of the file containing the test pattern
        /// (in the CMSIS-DSP repository pattern root path)
        /// </summary>
        public string PatternFileName { get; set; }

        public PatternModel(string variableType, string variableName, string patternFileName)
        {
            VariableType = variableType;
            VariableName = variableName;
            PatternFileName = patternFileName;
        }
    }
}
