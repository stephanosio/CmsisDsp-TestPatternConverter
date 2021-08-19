﻿/*
 * Copyright (c) 2021 Stephanos Ioannidis <root@stephanos.io>
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System;
using System.Collections.Generic;

using TestPatternConverter.Models;

namespace TestPatternConverter.Tests
{
    public class BayesTest : Test
    {
        public override IEnumerable<TestModel> TestModels { get; protected set; } = new List<TestModel>
        {
            //
            // Bayes Tests
            //

            // F16
            new TestModel
            {
                TestCodePath = "bayes/src/f16.c",
                PatternRootPath = "Bayes/BayesF16",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint16_t", "in_val", "Inputs1_f16.txt"),
                    new PatternModel("uint16_t", "in_dims", "Dims1_s16.txt"),
                    new PatternModel("uint16_t", "in_param", "Params1_f16.txt"),
                    new PatternModel("uint16_t", "ref_prob", "Probas1_f16.txt"),
                    new PatternModel("uint16_t", "ref_pred", "Predicts1_s16.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "bayes/src/f32.c",
                PatternRootPath = "Bayes/BayesF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_val", "Inputs1_f32.txt"),
                    new PatternModel("uint16_t", "in_dims", "Dims1_s16.txt"),
                    new PatternModel("uint32_t", "in_param", "Params1_f32.txt"),
                    new PatternModel("uint32_t", "ref_prob", "Probas1_f32.txt"),
                    new PatternModel("uint16_t", "ref_pred", "Predicts1_s16.txt")
                }
            }
        };
    }
}
