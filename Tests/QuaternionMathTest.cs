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
    public class QuaternionMathTest : Test
    {
        public override IEnumerable<TestModel> TestModels => new List<TestModel>
        {
            //
            // Quaternion Math Tests
            //

            // F32
            new TestModel
            {
                TestCodePath = "quaternionmath/src/f32.c",
                PatternRootPath = "QuaternionMaths/QuaternionMathsF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_com1", "Input1_f32.txt"),
                    new PatternModel("uint32_t", "in_com2", "Input2_f32.txt"),
                    new PatternModel("uint32_t", "in_rot", "Input7_f32.txt"),
                    new PatternModel("uint32_t", "ref_norm", "Reference1_f32.txt"),
                    new PatternModel("uint32_t", "ref_inv", "Reference2_f32.txt"),
                    new PatternModel("uint32_t", "ref_conj", "Reference3_f32.txt"),
                    new PatternModel("uint32_t", "ref_normalize", "Reference4_f32.txt"),
                    new PatternModel("uint32_t", "ref_mult", "Reference5_f32.txt"),
                    new PatternModel("uint32_t", "ref_quat2rot", "Reference6_f32.txt"),
                    new PatternModel("uint32_t", "ref_rot2quat", "Reference7_f32.txt")
                }
            }
        };
    }
}
