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
    public class InterpolationTest : Test
    {
        public override IEnumerable<TestModel> TestModels => new List<TestModel>
        {
            //
            // Interpolation Tests
            //

            // Q7
            new TestModel
            {
                TestCodePath = "interpolation/src/q7.c",
                PatternRootPath = "Interpolation/InterpolationQ7",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_linear_x", "Input1_q31.txt"),
                    new PatternModel("q7_t", "in_linear_y", "YVals1_q7.txt"),
                    new PatternModel("q7_t", "ref_linear", "Reference1_q7.txt"),
                    new PatternModel("q31_t", "in_bilinear_x", "Input2_q31.txt"),
                    new PatternModel("q7_t", "in_bilinear_y", "YVals2_q7.txt"),
                    new PatternModel("uint16_t", "in_bilinear_config", "Config2_s16.txt"),
                    new PatternModel("q7_t", "ref_bilinear", "Reference2_q7.txt")
                }
            },

            // Q15
            new TestModel
            {
                TestCodePath = "interpolation/src/q15.c",
                PatternRootPath = "Interpolation/InterpolationQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_linear_x", "Input1_q31.txt"),
                    new PatternModel("q15_t", "in_linear_y", "YVals1_q15.txt"),
                    new PatternModel("q15_t", "ref_linear", "Reference1_q15.txt"),
                    new PatternModel("q31_t", "in_bilinear_x", "Input2_q31.txt"),
                    new PatternModel("q15_t", "in_bilinear_y", "YVals2_q15.txt"),
                    new PatternModel("uint16_t", "in_bilinear_config", "Config2_s16.txt"),
                    new PatternModel("q15_t", "ref_bilinear", "Reference2_q15.txt")
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "interpolation/src/q31.c",
                PatternRootPath = "Interpolation/InterpolationQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_linear_x", "Input1_q31.txt"),
                    new PatternModel("q31_t", "in_linear_y", "YVals1_q31.txt"),
                    new PatternModel("q31_t", "ref_linear", "Reference1_q31.txt"),
                    new PatternModel("q31_t", "in_bilinear_x", "Input2_q31.txt"),
                    new PatternModel("q31_t", "in_bilinear_y", "YVals2_q31.txt"),
                    new PatternModel("uint16_t", "in_bilinear_config", "Config2_s16.txt"),
                    new PatternModel("q31_t", "ref_bilinear", "Reference2_q31.txt")
                }
            },

            // F16
            new TestModel
            {
                TestCodePath = "interpolation/src/f16.c",
                PatternRootPath = "Interpolation/InterpolationF16",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint16_t", "in_linear_x", "Input1_f16.txt"),
                    new PatternModel("uint16_t", "in_linear_y", "YVals1_f16.txt"),
                    new PatternModel("uint16_t", "ref_linear", "Reference1_f16.txt"),
                    new PatternModel("uint16_t", "in_bilinear_x", "Input2_f16.txt"),
                    new PatternModel("uint16_t", "in_bilinear_y", "YVals2_f16.txt"),
                    new PatternModel("uint16_t", "in_bilinear_config", "Config2_s16.txt"),
                    new PatternModel("uint16_t", "ref_bilinear", "Reference2_f16.txt"),
                    // new PatternModel("uint16_t", "in_spline_squ_x", "InputX3_f16.txt"),
                    // new PatternModel("uint16_t", "in_spline_squ_y", "InputY3_f16.txt"),
                    // new PatternModel("uint16_t", "in_spline_squ_xq", "OutputX3_f16.txt"),
                    // new PatternModel("uint16_t", "in_spline_sin_x", "InputX4_f16.txt"),
                    // new PatternModel("uint16_t", "in_spline_sin_y", "InputY4_f16.txt"),
                    // new PatternModel("uint16_t", "in_spline_sin_xq", "OutputX4_f16.txt"),
                    // new PatternModel("uint16_t", "in_spline_ram_x", "InputX5_f16.txt"),
                    // new PatternModel("uint16_t", "in_spline_ram_y", "InputY5_f16.txt"),
                    // new PatternModel("uint16_t", "in_spline_ram_xq", "OutputX5_f16.txt"),
                    // new PatternModel("uint16_t", "ref_spline_squ", "Reference3_f16.txt"),
                    // new PatternModel("uint16_t", "ref_spline_sin", "Reference4_f16.txt"),
                    // new PatternModel("uint16_t", "ref_spline_ram", "Reference5_f16.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "interpolation/src/f32.c",
                PatternRootPath = "Interpolation/InterpolationF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_linear_x", "Input1_f32.txt"),
                    new PatternModel("uint32_t", "in_linear_y", "YVals1_f32.txt"),
                    new PatternModel("uint32_t", "ref_linear", "Reference1_f32.txt"),
                    new PatternModel("uint32_t", "in_bilinear_x", "Input2_f32.txt"),
                    new PatternModel("uint32_t", "in_bilinear_y", "YVals2_f32.txt"),
                    new PatternModel("uint16_t", "in_bilinear_config", "Config2_s16.txt"),
                    new PatternModel("uint32_t", "ref_bilinear", "Reference2_f32.txt"),
                    new PatternModel("uint32_t", "in_spline_squ_x", "InputX3_f32.txt"),
                    new PatternModel("uint32_t", "in_spline_squ_y", "InputY3_f32.txt"),
                    new PatternModel("uint32_t", "in_spline_squ_xq", "OutputX3_f32.txt"),
                    new PatternModel("uint32_t", "in_spline_sin_x", "InputX4_f32.txt"),
                    new PatternModel("uint32_t", "in_spline_sin_y", "InputY4_f32.txt"),
                    new PatternModel("uint32_t", "in_spline_sin_xq", "OutputX4_f32.txt"),
                    new PatternModel("uint32_t", "in_spline_ram_x", "InputX5_f32.txt"),
                    new PatternModel("uint32_t", "in_spline_ram_y", "InputY5_f32.txt"),
                    new PatternModel("uint32_t", "in_spline_ram_xq", "OutputX5_f32.txt"),
                    new PatternModel("uint32_t", "ref_spline_squ", "Reference3_f32.txt"),
                    new PatternModel("uint32_t", "ref_spline_sin", "Reference4_f32.txt"),
                    new PatternModel("uint32_t", "ref_spline_ram", "Reference5_f32.txt")
                }
            }
        };
    }
}
