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
    public class SvmTest : Test
    {
        public override IEnumerable<TestModel> TestModels { get; protected set; } = new List<TestModel>
        {
            //
            // SVM Tests
            //

            // F32
            new TestModel
            {
                TestCodePath = "svm/src/f32.c",
                PatternRootPath = "SVM/SVMF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_linear_val", "Samples1_f32.txt"),
                    new PatternModel("uint32_t", "in_linear_param", "Params1_f32.txt"),
                    new PatternModel("uint16_t", "in_linear_dims", "Dims1_s16.txt"),
                    new PatternModel("uint32_t", "ref_linear", "Reference1_s32.txt"),

                    new PatternModel("uint32_t", "in_polynomial_val", "Samples2_f32.txt"),
                    new PatternModel("uint32_t", "in_polynomial_param", "Params2_f32.txt"),
                    new PatternModel("uint16_t", "in_polynomial_dims", "Dims2_s16.txt"),
                    new PatternModel("uint32_t", "ref_polynomial", "Reference2_s32.txt"),

                    new PatternModel("uint32_t", "in_rbf_val", "Samples3_f32.txt"),
                    new PatternModel("uint32_t", "in_rbf_param", "Params3_f32.txt"),
                    new PatternModel("uint16_t", "in_rbf_dims", "Dims3_s16.txt"),
                    new PatternModel("uint32_t", "ref_rbf", "Reference3_s32.txt"),

                    new PatternModel("uint32_t", "in_sigmoid_val", "Samples4_f32.txt"),
                    new PatternModel("uint32_t", "in_sigmoid_param", "Params4_f32.txt"),
                    new PatternModel("uint16_t", "in_sigmoid_dims", "Dims4_s16.txt"),
                    new PatternModel("uint32_t", "ref_sigmoid", "Reference4_s32.txt"),

                    new PatternModel("uint32_t", "in_oneclass_val", "Samples5_f32.txt"),
                    new PatternModel("uint32_t", "in_oneclass_param", "Params5_f32.txt"),
                    new PatternModel("uint16_t", "in_oneclass_dims", "Dims5_s16.txt"),
                    new PatternModel("uint32_t", "ref_oneclass", "Reference5_s32.txt")
                }
            }
        };
    }
}
