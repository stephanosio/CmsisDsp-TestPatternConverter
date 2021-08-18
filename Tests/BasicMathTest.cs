/*
 * Copyright (c) 2021 Stephanos Ioannidis <root@stephanos.io>
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System;
using System.Collections.Generic;

using TestPatternConverter.Models;

namespace TestPatternConverter.Tests
{
    public class BasicMathTest : Test
    {
        public override IEnumerable<TestModel> TestModels { get; protected set; } = new List<TestModel>
        {
            //
            // Basic Math Tests
            //

            // Q7
            new TestModel
            {
                TestCodePath = "basicmath/src/q7.c",
                PatternRootPath = "BasicMaths/BasicMathsQ7",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q7_t", "in_com1", "Input1_q7.txt"),
                    new PatternModel("q7_t", "in_com2", "Input2_q7.txt"),
                    new PatternModel("q7_t", "in_bitwise1", "BitwiseInput24_s8.txt"),
                    new PatternModel("q7_t", "in_bitwise2", "BitwiseInput25_s8.txt"),
                    new PatternModel("q7_t", "in_rand", "Input12_q7.txt"),
                    new PatternModel("q7_t", "in_maxpos", "MaxPosInput12_s8.txt"),
                    new PatternModel("q7_t", "in_maxneg", "MaxNegInput12_s8.txt"),
                    new PatternModel("q7_t", "in_maxneg2", "MaxNeg2Input12_s8.txt"),
                    new PatternModel("q7_t", "in_clip", "Input28_q7.txt"),
                    new PatternModel("q7_t", "ref_add", "Reference1_q7.txt"),
                    new PatternModel("q7_t", "ref_add_possat", "PosSat12_q7.txt"),
                    new PatternModel("q7_t", "ref_add_negsat", "NegSat13_q7.txt"),
                    new PatternModel("q7_t", "ref_sub", "Reference2_q7.txt"),
                    new PatternModel("q7_t", "ref_sub_possat", "PosSat14_q7.txt"),
                    new PatternModel("q7_t", "ref_sub_negsat", "NegSat15_q7.txt"),
                    new PatternModel("q7_t", "ref_mult", "Reference3_q7.txt"),
                    new PatternModel("q7_t", "ref_mult_possat", "PosSat16_q7.txt"),
                    new PatternModel("q7_t", "ref_negate", "Reference4_q7.txt"),
                    new PatternModel("q7_t", "ref_negate_possat", "PosSat17_q7.txt"),
                    new PatternModel("q7_t", "ref_offset", "Reference5_q7.txt"),
                    new PatternModel("q7_t", "ref_offset_possat", "PosSat18_q7.txt"),
                    new PatternModel("q7_t", "ref_offset_negsat", "NegSat19_q7.txt"),
                    new PatternModel("q7_t", "ref_scale", "Reference6_q7.txt"),
                    new PatternModel("q7_t", "ref_scale_possat", "PosSat20_q7.txt"),
                    new PatternModel("q31_t", "ref_dot_prod_3", "Reference7_q31.txt"),
                    new PatternModel("q31_t", "ref_dot_prod_4", "Reference8_q31.txt"),
                    new PatternModel("q31_t", "ref_dot_prod_4n1", "Reference9_q31.txt"),
                    new PatternModel("q31_t", "ref_dot_prod_long", "Reference11_q31.txt"),
                    new PatternModel("q7_t", "ref_abs", "Reference10_q7.txt"),
                    new PatternModel("q7_t", "ref_shift", "Shift21_q7.txt"),
                    new PatternModel("q7_t", "ref_shift_possat", "Shift22_q7.txt"),
                    new PatternModel("q7_t", "ref_shift_negsat", "Shift23_q7.txt"),
                    new PatternModel("uint8_t", "ref_and", "And24_s8.txt"),
                    new PatternModel("uint8_t", "ref_or", "Or25_s8.txt"),
                    new PatternModel("uint8_t", "ref_not", "Not26_s8.txt"),
                    new PatternModel("uint8_t", "ref_xor", "Xor27_s8.txt"),
                    new PatternModel("q7_t", "ref_clip1", "Reference28_q7.txt"),
                    new PatternModel("q7_t", "ref_clip2", "Reference29_q7.txt"),
                    new PatternModel("q7_t", "ref_clip3", "Reference30_q7.txt")
                }
            },

            // Q15
            new TestModel
            {
                TestCodePath = "basicmath/src/q15.c",
                PatternRootPath = "BasicMaths/BasicMathsQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_com1", "Input1_q15.txt"),
                    new PatternModel("q15_t", "in_com2", "Input2_q15.txt"),
                    new PatternModel("q15_t", "in_bitwise1", "BitwiseInput24_s16.txt"),
                    new PatternModel("q15_t", "in_bitwise2", "BitwiseInput25_s16.txt"),
                    new PatternModel("q15_t", "in_rand", "Input12_q15.txt"),
                    new PatternModel("q15_t", "in_maxpos", "MaxPosInput12_s16.txt"),
                    new PatternModel("q15_t", "in_maxneg", "MaxNegInput12_s16.txt"),
                    new PatternModel("q15_t", "in_maxneg2", "MaxNeg2Input12_s16.txt"),
                    new PatternModel("q15_t", "in_clip", "Input28_q15.txt"),
                    new PatternModel("q15_t", "ref_add", "Reference1_q15.txt"),
                    new PatternModel("q15_t", "ref_add_possat", "PosSat12_q15.txt"),
                    new PatternModel("q15_t", "ref_add_negsat", "NegSat13_q15.txt"),
                    new PatternModel("q15_t", "ref_sub", "Reference2_q15.txt"),
                    new PatternModel("q15_t", "ref_sub_possat", "PosSat14_q15.txt"),
                    new PatternModel("q15_t", "ref_sub_negsat", "NegSat15_q15.txt"),
                    new PatternModel("q15_t", "ref_mult", "Reference3_q15.txt"),
                    new PatternModel("q15_t", "ref_mult_possat", "PosSat16_q15.txt"),
                    new PatternModel("q15_t", "ref_negate", "Reference4_q15.txt"),
                    new PatternModel("q15_t", "ref_negate_possat", "PosSat17_q15.txt"),
                    new PatternModel("q15_t", "ref_offset", "Reference5_q15.txt"),
                    new PatternModel("q15_t", "ref_offset_possat", "PosSat18_q15.txt"),
                    new PatternModel("q15_t", "ref_offset_negsat", "NegSat19_q15.txt"),
                    new PatternModel("q15_t", "ref_scale", "Reference6_q15.txt"),
                    new PatternModel("q15_t", "ref_scale_possat", "PosSat20_q15.txt"),
                    new PatternModel("q63_t", "ref_dot_prod_3", "Reference7_q63.txt"),
                    new PatternModel("q63_t", "ref_dot_prod_4", "Reference8_q63.txt"),
                    new PatternModel("q63_t", "ref_dot_prod_4n1", "Reference9_q63.txt"),
                    new PatternModel("q63_t", "ref_dot_prod_long", "Reference11_q63.txt"),
                    new PatternModel("q15_t", "ref_abs", "Reference10_q15.txt"),
                    new PatternModel("q15_t", "ref_shift", "Shift21_q15.txt"),
                    new PatternModel("q15_t", "ref_shift_possat", "Shift22_q15.txt"),
                    new PatternModel("q15_t", "ref_shift_negsat", "Shift23_q15.txt"),
                    new PatternModel("uint16_t", "ref_and", "And24_s16.txt"),
                    new PatternModel("uint16_t", "ref_or", "Or25_s16.txt"),
                    new PatternModel("uint16_t", "ref_not", "Not26_s16.txt"),
                    new PatternModel("uint16_t", "ref_xor", "Xor27_s16.txt"),
                    new PatternModel("q15_t", "ref_clip1", "Reference28_q15.txt"),
                    new PatternModel("q15_t", "ref_clip2", "Reference29_q15.txt"),
                    new PatternModel("q15_t", "ref_clip3", "Reference30_q15.txt")
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "basicmath/src/q31.c",
                PatternRootPath = "BasicMaths/BasicMathsQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_com1", "Input1_q31.txt"),
                    new PatternModel("q31_t", "in_com2", "Input2_q31.txt"),
                    new PatternModel("q31_t", "in_bitwise1", "BitwiseInput24_s32.txt"),
                    new PatternModel("q31_t", "in_bitwise2", "BitwiseInput25_s32.txt"),
                    new PatternModel("q31_t", "in_rand", "Input12_q31.txt"),
                    new PatternModel("q31_t", "in_maxpos", "MaxPosInput12_s32.txt"),
                    new PatternModel("q31_t", "in_maxneg", "MaxNegInput12_s32.txt"),
                    new PatternModel("q31_t", "in_maxneg2", "MaxNeg2Input12_s32.txt"),
                    new PatternModel("q31_t", "in_clip", "Input28_q31.txt"),
                    new PatternModel("q31_t", "ref_add", "Reference1_q31.txt"),
                    new PatternModel("q31_t", "ref_add_possat", "PosSat12_q31.txt"),
                    new PatternModel("q31_t", "ref_add_negsat", "NegSat13_q31.txt"),
                    new PatternModel("q31_t", "ref_sub", "Reference2_q31.txt"),
                    new PatternModel("q31_t", "ref_sub_possat", "PosSat14_q31.txt"),
                    new PatternModel("q31_t", "ref_sub_negsat", "NegSat15_q31.txt"),
                    new PatternModel("q31_t", "ref_mult", "Reference3_q31.txt"),
                    new PatternModel("q31_t", "ref_mult_possat", "PosSat16_q31.txt"),
                    new PatternModel("q31_t", "ref_negate", "Reference4_q31.txt"),
                    new PatternModel("q31_t", "ref_negate_possat", "PosSat17_q31.txt"),
                    new PatternModel("q31_t", "ref_offset", "Reference5_q31.txt"),
                    new PatternModel("q31_t", "ref_offset_possat", "PosSat18_q31.txt"),
                    new PatternModel("q31_t", "ref_offset_negsat", "NegSat19_q31.txt"),
                    new PatternModel("q31_t", "ref_scale", "Reference6_q31.txt"),
                    new PatternModel("q31_t", "ref_scale_possat", "PosSat20_q31.txt"),
                    new PatternModel("q63_t", "ref_dot_prod_3", "Reference7_q63.txt"),
                    new PatternModel("q63_t", "ref_dot_prod_4", "Reference8_q63.txt"),
                    new PatternModel("q63_t", "ref_dot_prod_4n1", "Reference9_q63.txt"),
                    new PatternModel("q63_t", "ref_dot_prod_long", "Reference11_q63.txt"),
                    new PatternModel("q31_t", "ref_abs", "Reference10_q31.txt"),
                    new PatternModel("q31_t", "ref_shift", "Shift21_q31.txt"),
                    new PatternModel("q31_t", "ref_shift_possat", "Shift22_q31.txt"),
                    new PatternModel("q31_t", "ref_shift_negsat", "Shift23_q31.txt"),
                    new PatternModel("uint32_t", "ref_and", "And24_s32.txt"),
                    new PatternModel("uint32_t", "ref_or", "Or25_s32.txt"),
                    new PatternModel("uint32_t", "ref_not", "Not26_s32.txt"),
                    new PatternModel("uint32_t", "ref_xor", "Xor27_s32.txt"),
                    new PatternModel("q31_t", "ref_clip1", "Reference28_q31.txt"),
                    new PatternModel("q31_t", "ref_clip2", "Reference29_q31.txt"),
                    new PatternModel("q31_t", "ref_clip3", "Reference30_q31.txt")
                }
            },

            // F16
            new TestModel
            {
                TestCodePath = "basicmath/src/f16.c",
                PatternRootPath = "BasicMaths/BasicMathsF16",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint16_t", "in_com1", "Input1_f16.txt"),
                    new PatternModel("uint16_t", "in_com2", "Input2_f16.txt"),
                    new PatternModel("uint16_t", "in_clip", "Input12_f16.txt"),
                    new PatternModel("uint16_t", "ref_add", "Reference1_f16.txt"),
                    new PatternModel("uint16_t", "ref_sub", "Reference2_f16.txt"),
                    new PatternModel("uint16_t", "ref_mult", "Reference3_f16.txt"),
                    new PatternModel("uint16_t", "ref_negate", "Reference4_f16.txt"),
                    new PatternModel("uint16_t", "ref_offset", "Reference5_f16.txt"),
                    new PatternModel("uint16_t", "ref_scale", "Reference6_f16.txt"),
                    new PatternModel("uint16_t", "ref_dot_prod_3", "Reference7_f16.txt"),
                    new PatternModel("uint16_t", "ref_dot_prod_4", "Reference8_f16.txt"),
                    new PatternModel("uint16_t", "ref_dot_prod_4n1", "Reference9_f16.txt"),
                    new PatternModel("uint16_t", "ref_dot_prod_long", "Reference11_f16.txt"),
                    new PatternModel("uint16_t", "ref_abs", "Reference10_f16.txt"),
                    new PatternModel("uint16_t", "ref_clip1", "Reference12_f16.txt"),
                    new PatternModel("uint16_t", "ref_clip2", "Reference13_f16.txt"),
                    new PatternModel("uint16_t", "ref_clip3", "Reference14_f16.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "basicmath/src/f32.c",
                PatternRootPath = "BasicMaths/BasicMathsF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_com1", "Input1_f32.txt"),
                    new PatternModel("uint32_t", "in_com2", "Input2_f32.txt"),
                    new PatternModel("uint32_t", "in_clip", "Input12_f32.txt"),
                    new PatternModel("uint32_t", "ref_add", "Reference1_f32.txt"),
                    new PatternModel("uint32_t", "ref_sub", "Reference2_f32.txt"),
                    new PatternModel("uint32_t", "ref_mult", "Reference3_f32.txt"),
                    new PatternModel("uint32_t", "ref_negate", "Reference4_f32.txt"),
                    new PatternModel("uint32_t", "ref_offset", "Reference5_f32.txt"),
                    new PatternModel("uint32_t", "ref_scale", "Reference6_f32.txt"),
                    new PatternModel("uint32_t", "ref_dot_prod_3", "Reference7_f32.txt"),
                    new PatternModel("uint32_t", "ref_dot_prod_4", "Reference8_f32.txt"),
                    new PatternModel("uint32_t", "ref_dot_prod_4n1", "Reference9_f32.txt"),
                    new PatternModel("uint32_t", "ref_dot_prod_long", "Reference11_f32.txt"),
                    new PatternModel("uint32_t", "ref_abs", "Reference10_f32.txt"),
                    new PatternModel("uint32_t", "ref_clip1", "Reference12_f32.txt"),
                    new PatternModel("uint32_t", "ref_clip2", "Reference13_f32.txt"),
                    new PatternModel("uint32_t", "ref_clip3", "Reference14_f32.txt")
                }
            }
        };
    }
}
