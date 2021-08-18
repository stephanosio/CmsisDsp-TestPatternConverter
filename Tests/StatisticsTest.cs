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
    public class StatisticsTest : Test
    {
        public override IEnumerable<TestModel> TestModels { get; protected set; } = new List<TestModel>
        {
            //
            // Statistics Tests
            //

            // Q7
            new TestModel
            {
                TestCodePath = "statistics/src/q7.c",
                PatternRootPath = "Stats/StatsQ7",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q7_t", "in_com1", "Input1_q7.txt"),
                    new PatternModel("q7_t", "in_com2", "Input2_q7.txt"),
                    new PatternModel("q7_t", "in_max_maxidx", "InputMaxIndexMax1_q7.txt"),
                    new PatternModel("q7_t", "in_min_maxidx", "InputMinIndexMax3_q7.txt"),
                    new PatternModel("q7_t", "ref_max_val", "MaxVals1_q7.txt"),
                    new PatternModel("q15_t", "ref_max_idx", "MaxIndexes1_s16.txt"),
                    new PatternModel("q7_t", "ref_min_val", "MinVals3_q7.txt"),
                    new PatternModel("q15_t", "ref_min_idx", "MinIndexes3_s16.txt"),
                    new PatternModel("q7_t", "ref_mean", "MeanVals2_q7.txt"),
                    new PatternModel("q31_t", "ref_power", "PowerVals4_q31.txt")
                }
            },

            // Q15
            new TestModel
            {
                TestCodePath = "statistics/src/q15.c",
                PatternRootPath = "Stats/StatsQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_com1", "Input1_q15.txt"),
                    new PatternModel("q15_t", "in_com2", "Input2_q15.txt"),
                    new PatternModel("q15_t", "ref_max_val", "MaxVals1_q15.txt"),
                    new PatternModel("q15_t", "ref_max_idx", "MaxIndexes1_s16.txt"),
                    new PatternModel("q15_t", "ref_min_val", "MinVals3_q15.txt"),
                    new PatternModel("q15_t", "ref_min_idx", "MinIndexes3_s16.txt"),
                    new PatternModel("q15_t", "ref_mean", "MeanVals2_q15.txt"),
                    new PatternModel("q63_t", "ref_power", "PowerVals4_q63.txt"),
                    new PatternModel("q15_t", "ref_rms", "RmsVals5_q15.txt"),
                    new PatternModel("q15_t", "ref_std", "StdVals6_q15.txt"),
                    new PatternModel("q15_t", "ref_var", "VarVals7_q15.txt")
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "statistics/src/q31.c",
                PatternRootPath = "Stats/StatsQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_com1", "Input1_q31.txt"),
                    new PatternModel("q31_t", "in_com2", "Input2_q31.txt"),
                    new PatternModel("q31_t", "ref_max_val", "MaxVals1_q31.txt"),
                    new PatternModel("q15_t", "ref_max_idx", "MaxIndexes1_s16.txt"),
                    new PatternModel("q31_t", "ref_min_val", "MinVals3_q31.txt"),
                    new PatternModel("q15_t", "ref_min_idx", "MinIndexes3_s16.txt"),
                    new PatternModel("q31_t", "ref_mean", "MeanVals2_q31.txt"),
                    new PatternModel("q63_t", "ref_power", "PowerVals4_q63.txt"),
                    new PatternModel("q31_t", "ref_rms", "RmsVals5_q31.txt"),
                    new PatternModel("q31_t", "ref_std", "StdVals6_q31.txt"),
                    new PatternModel("q31_t", "ref_var", "VarVals7_q31.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "statistics/src/f32.c",
                PatternRootPath = "Stats/StatsF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_com1", "Input1_f32.txt"),
                    new PatternModel("uint32_t", "in_com2", "Input2_f32.txt"),
                    new PatternModel("uint32_t", "in_entropy", "Input22_f32.txt"),
                    new PatternModel("q15_t", "in_entropy_dim", "Dims22_s16.txt"),
                    new PatternModel("uint32_t", "in_logsumexp", "Input23_f32.txt"),
                    new PatternModel("q15_t", "in_logsumexp_dim", "Dims23_s16.txt"),
                    new PatternModel("uint32_t", "in_kl1", "InputA24_f32.txt"),
                    new PatternModel("uint32_t", "in_kl2", "InputB24_f32.txt"),
                    new PatternModel("q15_t", "in_kl_dim", "Dims24_s16.txt"),
                    new PatternModel("uint32_t", "in_logsumexp_dp1", "InputA25_f32.txt"),
                    new PatternModel("uint32_t", "in_logsumexp_dp2", "InputB25_f32.txt"),
                    new PatternModel("q15_t", "in_logsumexp_dp_dim", "Dims25_s16.txt"),
                    new PatternModel("uint32_t", "ref_max_val", "MaxVals1_f32.txt"),
                    new PatternModel("q15_t", "ref_max_idx", "MaxIndexes1_s16.txt"),
                    new PatternModel("uint32_t", "ref_min_val", "MinVals3_f32.txt"),
                    new PatternModel("q15_t", "ref_min_idx", "MinIndexes3_s16.txt"),
                    new PatternModel("uint32_t", "ref_mean", "MeanVals2_f32.txt"),
                    new PatternModel("uint32_t", "ref_power", "PowerVals4_f32.txt"),
                    new PatternModel("uint32_t", "ref_rms", "RmsVals5_f32.txt"),
                    new PatternModel("uint32_t", "ref_std", "StdVals6_f32.txt"),
                    new PatternModel("uint32_t", "ref_var", "VarVals7_f32.txt"),
                    new PatternModel("uint32_t", "ref_entropy", "RefEntropy22_f32.txt"),
                    new PatternModel("uint32_t", "ref_logsumexp", "RefLogSumExp23_f32.txt"),
                    new PatternModel("uint32_t", "ref_kl", "RefKL24_f32.txt"),
                    new PatternModel("uint32_t", "ref_logsumexp_dp", "RefLogSumExpDot25_f32.txt")
                }
            },

            // F64
            new TestModel
            {
                TestCodePath = "statistics/src/f64.c",
                PatternRootPath = "Stats/StatsF64",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint64_t", "in_entropy", "Input22_f64.txt"),
                    new PatternModel("q15_t", "in_entropy_dim", "Dims22_s16.txt"),
                    new PatternModel("uint64_t", "in_kl1", "InputA24_f64.txt"),
                    new PatternModel("uint64_t", "in_kl2", "InputB24_f64.txt"),
                    new PatternModel("q15_t", "in_kl_dim", "Dims24_s16.txt"),
                    new PatternModel("uint64_t", "ref_entropy", "RefEntropy22_f64.txt"),
                    new PatternModel("uint64_t", "ref_kl", "RefKL24_f64.txt")
                }
            }
        };
    }
}
