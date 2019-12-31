using System;
using System.Collections.Generic;

using TestPatternConverter.Models;

namespace TestPatternConverter.Tests
{
    public class ComplexMathTest : Test
    {
        public override IEnumerable<TestModel> TestModels { get; protected set; } = new List<TestModel>
        {
            //
            // Complex Math Tests
            //

            // Q15
            new TestModel
            {
                TestCodePath = "complexmath/src/q15.c",
                PatternRootPath = "ComplexMaths/ComplexMathsQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_com1", "Input1_q15.txt"),
                    new PatternModel("q15_t", "in_com2", "Input2_q15.txt"),
                    new PatternModel("q15_t", "in_com3", "Input3_q15.txt"),
                    new PatternModel("q15_t", "ref_conj", "Reference1_q15.txt"),
                    new PatternModel("q31_t", "ref_dot_prod_3", "Reference2_q31.txt"),
                    new PatternModel("q31_t", "ref_dot_prod_4n", "Reference3_q31.txt"),
                    new PatternModel("q31_t", "ref_dot_prod_4n1", "Reference4_q31.txt"),
                    new PatternModel("q15_t", "ref_mag", "Reference5_q15.txt"),
                    new PatternModel("q15_t", "ref_mag_squared", "Reference6_q15.txt"),
                    new PatternModel("q15_t", "ref_mult_cmplx", "Reference7_q15.txt"),
                    new PatternModel("q15_t", "ref_mult_real", "Reference8_q15.txt")
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "complexmath/src/q31.c",
                PatternRootPath = "ComplexMaths/ComplexMathsQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_com1", "Input1_q31.txt"),
                    new PatternModel("q31_t", "in_com2", "Input2_q31.txt"),
                    new PatternModel("q31_t", "in_com3", "Input3_q31.txt"),
                    new PatternModel("q31_t", "ref_conj", "Reference1_q31.txt"),
                    new PatternModel("q63_t", "ref_dot_prod_3", "Reference2_q63.txt"),
                    new PatternModel("q63_t", "ref_dot_prod_4n", "Reference3_q63.txt"),
                    new PatternModel("q63_t", "ref_dot_prod_4n1", "Reference4_q63.txt"),
                    new PatternModel("q31_t", "ref_mag", "Reference5_q31.txt"),
                    new PatternModel("q31_t", "ref_mag_squared", "Reference6_q31.txt"),
                    new PatternModel("q31_t", "ref_mult_cmplx", "Reference7_q31.txt"),
                    new PatternModel("q31_t", "ref_mult_real", "Reference8_q31.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "complexmath/src/f32.c",
                PatternRootPath = "ComplexMaths/ComplexMathsF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_com1", "Input1_f32.txt"),
                    new PatternModel("uint32_t", "in_com2", "Input2_f32.txt"),
                    new PatternModel("uint32_t", "in_com3", "Input3_f32.txt"),
                    new PatternModel("uint32_t", "ref_conj", "Reference1_f32.txt"),
                    new PatternModel("uint32_t", "ref_dot_prod_3", "Reference2_f32.txt"),
                    new PatternModel("uint32_t", "ref_dot_prod_4n", "Reference3_f32.txt"),
                    new PatternModel("uint32_t", "ref_dot_prod_4n1", "Reference4_f32.txt"),
                    new PatternModel("uint32_t", "ref_mag", "Reference5_f32.txt"),
                    new PatternModel("uint32_t", "ref_mag_squared", "Reference6_f32.txt"),
                    new PatternModel("uint32_t", "ref_mult_cmplx", "Reference7_f32.txt"),
                    new PatternModel("uint32_t", "ref_mult_real", "Reference8_f32.txt")
                }
            }
        };
    }
}
