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
    public class SupportTest : Test
    {
        public override IEnumerable<TestModel> TestModels { get; protected set; } = new List<TestModel>
        {
            //
            // Support Tests
            //

            // Q7
            new TestModel
            {
                TestCodePath = "support/src/q7.c",
                PatternRootPath = "Support/SupportQ7",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q7_t", "in_q7", "Samples5_q7.txt"),
                    new PatternModel("uint32_t", "ref_f32", "Samples1_f32.txt"),
                    new PatternModel("q31_t", "ref_q31", "Samples4_q31.txt"),
                    new PatternModel("q15_t", "ref_q15", "Samples3_q15.txt")
                }
            },

            // Q15
            new TestModel
            {
                TestCodePath = "support/src/q15.c",
                PatternRootPath = "Support/SupportQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_q15", "Samples3_q15.txt"),
                    new PatternModel("uint32_t", "ref_f32", "Samples1_f32.txt"),
                    new PatternModel("q31_t", "ref_q31", "Samples4_q31.txt"),
                    new PatternModel("q7_t", "ref_q7", "Samples5_q7.txt")
                }
            },
                
            // Q31
            new TestModel
            {
                TestCodePath = "support/src/q31.c",
                PatternRootPath = "Support/SupportQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_q31", "Samples4_q31.txt"),
                    new PatternModel("uint32_t", "ref_f32", "Samples1_f32.txt"),
                    new PatternModel("q15_t", "ref_q15", "Samples3_q15.txt"),
                    new PatternModel("q7_t", "ref_q7", "Samples5_q7.txt")
                }
            },

            // F16
            new TestModel
            {
                TestCodePath = "support/src/f16.c",
                PatternRootPath = "Support/SupportF16",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint16_t", "in_weighted_sum_val", "Inputs6_f16.txt"),
                    new PatternModel("uint16_t", "in_weighted_sum_coeff", "Weights6_f16.txt"),
                    new PatternModel("uint32_t", "ref_f32", "Samples1_f32.txt"),
                    new PatternModel("q15_t", "ref_q15", "Samples3_q15.txt"),
                    new PatternModel("uint16_t", "ref_f16", "Samples11_f16.txt"),
                    new PatternModel("uint16_t", "ref_weighted_sum", "Ref6_f16.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "support/src/f32.c",
                PatternRootPath = "Support/SupportF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_f32", "Samples1_f32.txt"),
                    new PatternModel("uint32_t", "in_weighted_sum_val", "Inputs6_f32.txt"),
                    new PatternModel("uint32_t", "in_weighted_sum_coeff", "Weights6_f32.txt"),
                    new PatternModel("uint32_t", "in_sort", "Input7_f32.txt"),
                    new PatternModel("uint32_t", "in_sort_bitonic_16", "Input8_f32.txt"),
                    new PatternModel("uint32_t", "in_sort_bitonic_32", "Input9_f32.txt"),
                    new PatternModel("uint32_t", "in_sort_const", "Input10_f32.txt"),
                    new PatternModel("q31_t", "ref_q31", "Samples4_q31.txt"),
                    new PatternModel("q15_t", "ref_q15", "Samples3_q15.txt"),
                    new PatternModel("q7_t", "ref_q7", "Samples5_q7.txt"),
                    new PatternModel("uint32_t", "ref_weighted_sum", "Ref6_f32.txt"),
                    new PatternModel("uint32_t", "ref_sort", "Reference7_f32.txt"),
                    new PatternModel("uint32_t", "ref_sort_bitonic_16", "Reference8_f32.txt"),
                    new PatternModel("uint32_t", "ref_sort_bitonic_32", "Reference9_f32.txt"),
                    new PatternModel("uint32_t", "ref_sort_const", "Reference10_f32.txt")
                }
            },

            // F16 Barycenter
            new TestModel
            {
                TestCodePath = "support/src/barycenter_f16.c",
                PatternRootPath = "SupportBarF16",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint16_t", "in_barycenter_val", "Inputs1_f16.txt"),
                    new PatternModel("uint16_t", "in_barycenter_coeff", "Weights1_f16.txt"),
                    new PatternModel("uint16_t", "in_barycenter_dims", "Dims1_s16.txt"),
                    new PatternModel("uint16_t", "ref_barycenter", "Ref1_f16.txt")
                }
            },

            // F32 Barycenter
            new TestModel
            {
                TestCodePath = "support/src/barycenter_f32.c",
                PatternRootPath = "SupportBarF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_barycenter_val", "Inputs1_f32.txt"),
                    new PatternModel("uint32_t", "in_barycenter_coeff", "Weights1_f32.txt"),
                    new PatternModel("uint16_t", "in_barycenter_dims", "Dims1_s16.txt"),
                    new PatternModel("uint32_t", "ref_barycenter", "Ref1_f32.txt")
                }
            }
        };
    }
}
