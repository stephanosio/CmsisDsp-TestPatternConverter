using System;
using System.Collections.Generic;

using TestPatternConverter.Models;

namespace TestPatternConverter.Tests
{
    public class FastMathTest : Test
    {
        public override IEnumerable<TestModel> Tests { get; } = new List<TestModel>
        {
            //
            // Fast Math Tests
            //

            // Q15
            new TestModel
            {
                TestCodePath = "fastmath/src/q15.c",
                PatternRootPath = "FastMath/FastMathQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_angles", "Angles1_q15.txt"),
                    new PatternModel("q15_t", "in_sqrt", "SqrtInput1_q15.txt"),
                    new PatternModel("q15_t", "ref_cos", "Cos1_q15.txt"),
                    new PatternModel("q15_t", "ref_sin", "Sin1_q15.txt"),
                    new PatternModel("q15_t", "ref_sqrt", "Sqrt1_q15.txt")
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "fastmath/src/q31.c",
                PatternRootPath = "FastMath/FastMathQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_angles", "Angles1_q31.txt"),
                    new PatternModel("q31_t", "in_sqrt", "SqrtInput1_q31.txt"),
                    new PatternModel("q31_t", "ref_cos", "Cos1_q31.txt"),
                    new PatternModel("q31_t", "ref_sin", "Sin1_q31.txt"),
                    new PatternModel("q31_t", "ref_sqrt", "Sqrt1_q31.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "fastmath/src/f32.c",
                PatternRootPath = "FastMath/FastMathF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_angles", "Angles1_f32.txt"),
                    new PatternModel("uint32_t", "in_sqrt", "SqrtInput1_f32.txt"),
                    new PatternModel("uint32_t", "in_log", "LogInput1_f32.txt"),
                    new PatternModel("uint32_t", "in_exp", "ExpInput1_f32.txt"),
                    new PatternModel("uint32_t", "ref_cos", "Cos1_f32.txt"),
                    new PatternModel("uint32_t", "ref_sin", "Sin1_f32.txt"),
                    new PatternModel("uint32_t", "ref_sqrt", "Sqrt1_f32.txt"),
                    new PatternModel("uint32_t", "ref_log", "Log1_f32.txt"),
                    new PatternModel("uint32_t", "ref_exp", "Exp1_f32.txt")
                }
            }
        };
    }
}
