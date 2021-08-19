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
    public class DistanceTest : Test
    {
        public override IEnumerable<TestModel> TestModels { get; protected set; } = new List<TestModel>
        {
            //
            // Distance Tests
            //

            // U32
            new TestModel
            {
                TestCodePath = "distance/src/u32.c",
                PatternRootPath = "Distance/DistanceU32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_com1", "InputA1_u32.txt"),
                    new PatternModel("uint32_t", "in_com2", "InputB1_u32.txt"),
                    new PatternModel("uint16_t", "in_dims", "Dims1_s16.txt"),
                    new PatternModel("uint32_t", "ref_dice", "Ref1_f32.txt"),
                    new PatternModel("uint32_t", "ref_hamming", "Ref2_f32.txt"),
                    new PatternModel("uint32_t", "ref_jaccard", "Ref3_f32.txt"),
                    new PatternModel("uint32_t", "ref_kulsinski", "Ref4_f32.txt"),
                    new PatternModel("uint32_t", "ref_rogerstanimoto", "Ref5_f32.txt"),
                    new PatternModel("uint32_t", "ref_russellrao", "Ref6_f32.txt"),
                    new PatternModel("uint32_t", "ref_sokalmichener", "Ref7_f32.txt"),
                    new PatternModel("uint32_t", "ref_sokalsneath", "Ref8_f32.txt"),
                    new PatternModel("uint32_t", "ref_yule", "Ref9_f32.txt")
                }
            },

            // F16
            new TestModel
            {
                TestCodePath = "distance/src/f16.c",
                PatternRootPath = "Distance/DistanceF16",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint16_t", "in_com1", "InputA1_f16.txt"),
                    new PatternModel("uint16_t", "in_com2", "InputB1_f16.txt"),
                    new PatternModel("uint16_t", "in_jen1", "InputA8_f16.txt"),
                    new PatternModel("uint16_t", "in_jen2", "InputB8_f16.txt"),
                    new PatternModel("uint16_t", "in_dims", "Dims1_s16.txt"),
                    new PatternModel("uint16_t", "in_dims_minkowski", "Dims9_s16.txt"),
                    new PatternModel("uint16_t", "ref_braycurtis", "Ref1_f16.txt"),
                    new PatternModel("uint16_t", "ref_canberra", "Ref2_f16.txt"),
                    new PatternModel("uint16_t", "ref_chebyshev", "Ref3_f16.txt"),
                    new PatternModel("uint16_t", "ref_cityblock", "Ref4_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlation", "Ref5_f16.txt"),
                    new PatternModel("uint16_t", "ref_cosine", "Ref6_f16.txt"),
                    new PatternModel("uint16_t", "ref_euclidean", "Ref7_f16.txt"),
                    new PatternModel("uint16_t", "ref_jensenshannon", "Ref8_f16.txt"),
                    new PatternModel("uint16_t", "ref_minkowski", "Ref9_f16.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "distance/src/f32.c",
                PatternRootPath = "Distance/DistanceF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_com1", "InputA1_f32.txt"),
                    new PatternModel("uint32_t", "in_com2", "InputB1_f32.txt"),
                    new PatternModel("uint32_t", "in_jen1", "InputA8_f32.txt"),
                    new PatternModel("uint32_t", "in_jen2", "InputB8_f32.txt"),
                    new PatternModel("uint16_t", "in_dims", "Dims1_s16.txt"),
                    new PatternModel("uint16_t", "in_dims_minkowski", "Dims9_s16.txt"),
                    new PatternModel("uint32_t", "ref_braycurtis", "Ref1_f32.txt"),
                    new PatternModel("uint32_t", "ref_canberra", "Ref2_f32.txt"),
                    new PatternModel("uint32_t", "ref_chebyshev", "Ref3_f32.txt"),
                    new PatternModel("uint32_t", "ref_cityblock", "Ref4_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlation", "Ref5_f32.txt"),
                    new PatternModel("uint32_t", "ref_cosine", "Ref6_f32.txt"),
                    new PatternModel("uint32_t", "ref_euclidean", "Ref7_f32.txt"),
                    new PatternModel("uint32_t", "ref_jensenshannon", "Ref8_f32.txt"),
                    new PatternModel("uint32_t", "ref_minkowski", "Ref9_f32.txt")
                }
            }
        };
    }
}
