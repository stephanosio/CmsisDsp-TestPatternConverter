/*
 * Copyright (c) 2019 Stephanos Ioannidis <root@stephanos.io>
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System;
using System.Collections.Generic;

using TestPatternConverter.Models;

namespace TestPatternConverter.Tests
{
    public class TransformTest : Test
    {
        public override IEnumerable<TestModel> TestModels { get; protected set; } = new List<TestModel>
        {
            //
            // Transform Tests
            //

            // Q15
            new TestModel
            {
                TestCodePath = "transform/src/q15.c",
                PatternRootPath = "Transform/TransformQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_cfft_noisy_16", "ComplexInputSamples_Noisy_16_1_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_noisy_16", "ComplexInputIFFTSamples_Noisy_16_1_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_noisy_16", "ComplexFFTSamples_Noisy_16_1_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_noisy_32", "ComplexInputSamples_Noisy_32_2_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_noisy_32", "ComplexInputIFFTSamples_Noisy_32_2_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_noisy_32", "ComplexFFTSamples_Noisy_32_2_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_noisy_64", "ComplexInputSamples_Noisy_64_3_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_noisy_64", "ComplexInputIFFTSamples_Noisy_64_3_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_noisy_64", "ComplexFFTSamples_Noisy_64_3_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_noisy_128", "ComplexInputSamples_Noisy_128_4_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_noisy_128", "ComplexInputIFFTSamples_Noisy_128_4_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_noisy_128", "ComplexFFTSamples_Noisy_128_4_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_noisy_256", "ComplexInputSamples_Noisy_256_5_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_noisy_256", "ComplexInputIFFTSamples_Noisy_256_5_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_noisy_256", "ComplexFFTSamples_Noisy_256_5_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_noisy_512", "ComplexInputSamples_Noisy_512_6_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_noisy_512", "ComplexInputIFFTSamples_Noisy_512_6_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_noisy_512", "ComplexFFTSamples_Noisy_512_6_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_noisy_1024", "ComplexInputSamples_Noisy_1024_7_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_noisy_1024", "ComplexInputIFFTSamples_Noisy_1024_7_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_noisy_1024", "ComplexFFTSamples_Noisy_1024_7_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_noisy_2048", "ComplexInputSamples_Noisy_2048_8_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_noisy_2048", "ComplexInputIFFTSamples_Noisy_2048_8_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_noisy_2048", "ComplexFFTSamples_Noisy_2048_8_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_noisy_4096", "ComplexInputSamples_Noisy_4096_9_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_noisy_4096", "ComplexInputIFFTSamples_Noisy_4096_9_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_noisy_4096", "ComplexFFTSamples_Noisy_4096_9_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_step_16", "ComplexInputSamples_Step_16_10_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_step_16", "ComplexInputIFFTSamples_Step_16_10_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_step_16", "ComplexFFTSamples_Step_16_10_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_step_32", "ComplexInputSamples_Step_32_11_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_step_32", "ComplexInputIFFTSamples_Step_32_11_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_step_32", "ComplexFFTSamples_Step_32_11_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_step_64", "ComplexInputSamples_Step_64_12_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_step_64", "ComplexInputIFFTSamples_Step_64_12_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_step_64", "ComplexFFTSamples_Step_64_12_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_step_128", "ComplexInputSamples_Step_128_13_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_step_128", "ComplexInputIFFTSamples_Step_128_13_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_step_128", "ComplexFFTSamples_Step_128_13_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_step_256", "ComplexInputSamples_Step_256_14_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_step_256", "ComplexInputIFFTSamples_Step_256_14_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_step_256", "ComplexFFTSamples_Step_256_14_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_step_512", "ComplexInputSamples_Step_512_15_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_step_512", "ComplexInputIFFTSamples_Step_512_15_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_step_512", "ComplexFFTSamples_Step_512_15_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_step_1024", "ComplexInputSamples_Step_1024_16_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_step_1024", "ComplexInputIFFTSamples_Step_1024_16_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_step_1024", "ComplexFFTSamples_Step_1024_16_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_step_2048", "ComplexInputSamples_Step_2048_17_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_step_2048", "ComplexInputIFFTSamples_Step_2048_17_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_step_2048", "ComplexFFTSamples_Step_2048_17_q15.txt"),

                    new PatternModel("q15_t", "in_cfft_step_4096", "ComplexInputSamples_Step_4096_18_q15.txt"),
                    new PatternModel("q15_t", "in_cifft_step_4096", "ComplexInputIFFTSamples_Step_4096_18_q15.txt"),
                    new PatternModel("q15_t", "ref_cfft_step_4096", "ComplexFFTSamples_Step_4096_18_q15.txt")
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "transform/src/q31.c",
                PatternRootPath = "Transform/TransformQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_cfft_noisy_16", "ComplexInputSamples_Noisy_16_1_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_noisy_16", "ComplexInputIFFTSamples_Noisy_16_1_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_noisy_16", "ComplexFFTSamples_Noisy_16_1_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_noisy_32", "ComplexInputSamples_Noisy_32_2_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_noisy_32", "ComplexInputIFFTSamples_Noisy_32_2_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_noisy_32", "ComplexFFTSamples_Noisy_32_2_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_noisy_64", "ComplexInputSamples_Noisy_64_3_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_noisy_64", "ComplexInputIFFTSamples_Noisy_64_3_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_noisy_64", "ComplexFFTSamples_Noisy_64_3_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_noisy_128", "ComplexInputSamples_Noisy_128_4_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_noisy_128", "ComplexInputIFFTSamples_Noisy_128_4_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_noisy_128", "ComplexFFTSamples_Noisy_128_4_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_noisy_256", "ComplexInputSamples_Noisy_256_5_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_noisy_256", "ComplexInputIFFTSamples_Noisy_256_5_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_noisy_256", "ComplexFFTSamples_Noisy_256_5_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_noisy_512", "ComplexInputSamples_Noisy_512_6_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_noisy_512", "ComplexInputIFFTSamples_Noisy_512_6_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_noisy_512", "ComplexFFTSamples_Noisy_512_6_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_noisy_1024", "ComplexInputSamples_Noisy_1024_7_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_noisy_1024", "ComplexInputIFFTSamples_Noisy_1024_7_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_noisy_1024", "ComplexFFTSamples_Noisy_1024_7_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_noisy_2048", "ComplexInputSamples_Noisy_2048_8_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_noisy_2048", "ComplexInputIFFTSamples_Noisy_2048_8_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_noisy_2048", "ComplexFFTSamples_Noisy_2048_8_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_noisy_4096", "ComplexInputSamples_Noisy_4096_9_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_noisy_4096", "ComplexInputIFFTSamples_Noisy_4096_9_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_noisy_4096", "ComplexFFTSamples_Noisy_4096_9_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_step_16", "ComplexInputSamples_Step_16_10_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_step_16", "ComplexInputIFFTSamples_Step_16_10_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_step_16", "ComplexFFTSamples_Step_16_10_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_step_32", "ComplexInputSamples_Step_32_11_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_step_32", "ComplexInputIFFTSamples_Step_32_11_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_step_32", "ComplexFFTSamples_Step_32_11_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_step_64", "ComplexInputSamples_Step_64_12_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_step_64", "ComplexInputIFFTSamples_Step_64_12_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_step_64", "ComplexFFTSamples_Step_64_12_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_step_128", "ComplexInputSamples_Step_128_13_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_step_128", "ComplexInputIFFTSamples_Step_128_13_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_step_128", "ComplexFFTSamples_Step_128_13_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_step_256", "ComplexInputSamples_Step_256_14_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_step_256", "ComplexInputIFFTSamples_Step_256_14_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_step_256", "ComplexFFTSamples_Step_256_14_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_step_512", "ComplexInputSamples_Step_512_15_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_step_512", "ComplexInputIFFTSamples_Step_512_15_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_step_512", "ComplexFFTSamples_Step_512_15_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_step_1024", "ComplexInputSamples_Step_1024_16_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_step_1024", "ComplexInputIFFTSamples_Step_1024_16_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_step_1024", "ComplexFFTSamples_Step_1024_16_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_step_2048", "ComplexInputSamples_Step_2048_17_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_step_2048", "ComplexInputIFFTSamples_Step_2048_17_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_step_2048", "ComplexFFTSamples_Step_2048_17_q31.txt"),

                    new PatternModel("q31_t", "in_cfft_step_4096", "ComplexInputSamples_Step_4096_18_q31.txt"),
                    new PatternModel("q31_t", "in_cifft_step_4096", "ComplexInputIFFTSamples_Step_4096_18_q31.txt"),
                    new PatternModel("q31_t", "ref_cfft_step_4096", "ComplexFFTSamples_Step_4096_18_q31.txt")
                }
            },

            // CF32
            new TestModel
            {
                TestCodePath = "transform/src/cf32.c",
                PatternRootPath = "Transform/TransformF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_cfft_noisy_16", "ComplexInputSamples_Noisy_16_1_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_noisy_16", "ComplexInputIFFTSamples_Noisy_16_1_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_noisy_16", "ComplexFFTSamples_Noisy_16_1_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_noisy_32", "ComplexInputSamples_Noisy_32_2_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_noisy_32", "ComplexInputIFFTSamples_Noisy_32_2_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_noisy_32", "ComplexFFTSamples_Noisy_32_2_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_noisy_64", "ComplexInputSamples_Noisy_64_3_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_noisy_64", "ComplexInputIFFTSamples_Noisy_64_3_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_noisy_64", "ComplexFFTSamples_Noisy_64_3_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_noisy_128", "ComplexInputSamples_Noisy_128_4_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_noisy_128", "ComplexInputIFFTSamples_Noisy_128_4_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_noisy_128", "ComplexFFTSamples_Noisy_128_4_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_noisy_256", "ComplexInputSamples_Noisy_256_5_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_noisy_256", "ComplexInputIFFTSamples_Noisy_256_5_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_noisy_256", "ComplexFFTSamples_Noisy_256_5_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_noisy_512", "ComplexInputSamples_Noisy_512_6_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_noisy_512", "ComplexInputIFFTSamples_Noisy_512_6_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_noisy_512", "ComplexFFTSamples_Noisy_512_6_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_noisy_1024", "ComplexInputSamples_Noisy_1024_7_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_noisy_1024", "ComplexInputIFFTSamples_Noisy_1024_7_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_noisy_1024", "ComplexFFTSamples_Noisy_1024_7_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_noisy_2048", "ComplexInputSamples_Noisy_2048_8_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_noisy_2048", "ComplexInputIFFTSamples_Noisy_2048_8_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_noisy_2048", "ComplexFFTSamples_Noisy_2048_8_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_noisy_4096", "ComplexInputSamples_Noisy_4096_9_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_noisy_4096", "ComplexInputIFFTSamples_Noisy_4096_9_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_noisy_4096", "ComplexFFTSamples_Noisy_4096_9_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_step_16", "ComplexInputSamples_Step_16_10_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_step_16", "ComplexInputIFFTSamples_Step_16_10_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_step_16", "ComplexFFTSamples_Step_16_10_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_step_32", "ComplexInputSamples_Step_32_11_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_step_32", "ComplexInputIFFTSamples_Step_32_11_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_step_32", "ComplexFFTSamples_Step_32_11_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_step_64", "ComplexInputSamples_Step_64_12_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_step_64", "ComplexInputIFFTSamples_Step_64_12_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_step_64", "ComplexFFTSamples_Step_64_12_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_step_128", "ComplexInputSamples_Step_128_13_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_step_128", "ComplexInputIFFTSamples_Step_128_13_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_step_128", "ComplexFFTSamples_Step_128_13_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_step_256", "ComplexInputSamples_Step_256_14_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_step_256", "ComplexInputIFFTSamples_Step_256_14_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_step_256", "ComplexFFTSamples_Step_256_14_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_step_512", "ComplexInputSamples_Step_512_15_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_step_512", "ComplexInputIFFTSamples_Step_512_15_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_step_512", "ComplexFFTSamples_Step_512_15_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_step_1024", "ComplexInputSamples_Step_1024_16_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_step_1024", "ComplexInputIFFTSamples_Step_1024_16_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_step_1024", "ComplexFFTSamples_Step_1024_16_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_step_2048", "ComplexInputSamples_Step_2048_17_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_step_2048", "ComplexInputIFFTSamples_Step_2048_17_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_step_2048", "ComplexFFTSamples_Step_2048_17_f32.txt"),

                    new PatternModel("uint32_t", "in_cfft_step_4096", "ComplexInputSamples_Step_4096_18_f32.txt"),
                    new PatternModel("uint32_t", "in_cifft_step_4096", "ComplexInputIFFTSamples_Step_4096_18_f32.txt"),
                    new PatternModel("uint32_t", "ref_cfft_step_4096", "ComplexFFTSamples_Step_4096_18_f32.txt")
                }
            },

            // RF32
            new TestModel
            {
                TestCodePath = "transform/src/rf32.c",
                PatternRootPath = "Transform/TransformF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_rfft_noisy_32", "RealInputSamples_Noisy_32_2_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_noisy_32", "RealInputIFFTSamples_Noisy_32_2_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_noisy_32", "RealFFTSamples_Noisy_32_2_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_noisy_64", "RealInputSamples_Noisy_64_3_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_noisy_64", "RealInputIFFTSamples_Noisy_64_3_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_noisy_64", "RealFFTSamples_Noisy_64_3_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_noisy_128", "RealInputSamples_Noisy_128_4_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_noisy_128", "RealInputIFFTSamples_Noisy_128_4_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_noisy_128", "RealFFTSamples_Noisy_128_4_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_noisy_256", "RealInputSamples_Noisy_256_5_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_noisy_256", "RealInputIFFTSamples_Noisy_256_5_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_noisy_256", "RealFFTSamples_Noisy_256_5_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_noisy_512", "RealInputSamples_Noisy_512_6_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_noisy_512", "RealInputIFFTSamples_Noisy_512_6_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_noisy_512", "RealFFTSamples_Noisy_512_6_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_noisy_1024", "RealInputSamples_Noisy_1024_7_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_noisy_1024", "RealInputIFFTSamples_Noisy_1024_7_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_noisy_1024", "RealFFTSamples_Noisy_1024_7_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_noisy_2048", "RealInputSamples_Noisy_2048_8_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_noisy_2048", "RealInputIFFTSamples_Noisy_2048_8_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_noisy_2048", "RealFFTSamples_Noisy_2048_8_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_noisy_4096", "RealInputSamples_Noisy_4096_9_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_noisy_4096", "RealInputIFFTSamples_Noisy_4096_9_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_noisy_4096", "RealFFTSamples_Noisy_4096_9_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_step_32", "RealInputSamples_Step_32_11_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_step_32", "RealInputIFFTSamples_Step_32_11_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_step_32", "RealFFTSamples_Step_32_11_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_step_64", "RealInputSamples_Step_64_12_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_step_64", "RealInputIFFTSamples_Step_64_12_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_step_64", "RealFFTSamples_Step_64_12_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_step_128", "RealInputSamples_Step_128_13_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_step_128", "RealInputIFFTSamples_Step_128_13_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_step_128", "RealFFTSamples_Step_128_13_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_step_256", "RealInputSamples_Step_256_14_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_step_256", "RealInputIFFTSamples_Step_256_14_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_step_256", "RealFFTSamples_Step_256_14_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_step_512", "RealInputSamples_Step_512_15_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_step_512", "RealInputIFFTSamples_Step_512_15_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_step_512", "RealFFTSamples_Step_512_15_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_step_1024", "RealInputSamples_Step_1024_16_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_step_1024", "RealInputIFFTSamples_Step_1024_16_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_step_1024", "RealFFTSamples_Step_1024_16_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_step_2048", "RealInputSamples_Step_2048_17_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_step_2048", "RealInputIFFTSamples_Step_2048_17_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_step_2048", "RealFFTSamples_Step_2048_17_f32.txt"),

                    new PatternModel("uint32_t", "in_rfft_step_4096", "RealInputSamples_Step_4096_18_f32.txt"),
                    new PatternModel("uint32_t", "in_rifft_step_4096", "RealInputIFFTSamples_Step_4096_18_f32.txt"),
                    new PatternModel("uint32_t", "ref_rfft_step_4096", "RealFFTSamples_Step_4096_18_f32.txt")
                }
            },

            // CF64
            new TestModel
            {
                TestCodePath = "transform/src/cf64.c",
                PatternRootPath = "Transform/TransformF64",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint64_t", "in_cfft_noisy_16", "ComplexInputSamples_Noisy_16_1_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_noisy_16", "ComplexInputIFFTSamples_Noisy_16_1_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_noisy_16", "ComplexFFTSamples_Noisy_16_1_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_noisy_32", "ComplexInputSamples_Noisy_32_2_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_noisy_32", "ComplexInputIFFTSamples_Noisy_32_2_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_noisy_32", "ComplexFFTSamples_Noisy_32_2_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_noisy_64", "ComplexInputSamples_Noisy_64_3_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_noisy_64", "ComplexInputIFFTSamples_Noisy_64_3_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_noisy_64", "ComplexFFTSamples_Noisy_64_3_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_noisy_128", "ComplexInputSamples_Noisy_128_4_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_noisy_128", "ComplexInputIFFTSamples_Noisy_128_4_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_noisy_128", "ComplexFFTSamples_Noisy_128_4_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_noisy_256", "ComplexInputSamples_Noisy_256_5_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_noisy_256", "ComplexInputIFFTSamples_Noisy_256_5_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_noisy_256", "ComplexFFTSamples_Noisy_256_5_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_noisy_512", "ComplexInputSamples_Noisy_512_6_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_noisy_512", "ComplexInputIFFTSamples_Noisy_512_6_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_noisy_512", "ComplexFFTSamples_Noisy_512_6_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_noisy_1024", "ComplexInputSamples_Noisy_1024_7_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_noisy_1024", "ComplexInputIFFTSamples_Noisy_1024_7_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_noisy_1024", "ComplexFFTSamples_Noisy_1024_7_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_noisy_2048", "ComplexInputSamples_Noisy_2048_8_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_noisy_2048", "ComplexInputIFFTSamples_Noisy_2048_8_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_noisy_2048", "ComplexFFTSamples_Noisy_2048_8_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_noisy_4096", "ComplexInputSamples_Noisy_4096_9_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_noisy_4096", "ComplexInputIFFTSamples_Noisy_4096_9_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_noisy_4096", "ComplexFFTSamples_Noisy_4096_9_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_step_16", "ComplexInputSamples_Step_16_10_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_step_16", "ComplexInputIFFTSamples_Step_16_10_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_step_16", "ComplexFFTSamples_Step_16_10_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_step_32", "ComplexInputSamples_Step_32_11_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_step_32", "ComplexInputIFFTSamples_Step_32_11_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_step_32", "ComplexFFTSamples_Step_32_11_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_step_64", "ComplexInputSamples_Step_64_12_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_step_64", "ComplexInputIFFTSamples_Step_64_12_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_step_64", "ComplexFFTSamples_Step_64_12_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_step_128", "ComplexInputSamples_Step_128_13_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_step_128", "ComplexInputIFFTSamples_Step_128_13_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_step_128", "ComplexFFTSamples_Step_128_13_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_step_256", "ComplexInputSamples_Step_256_14_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_step_256", "ComplexInputIFFTSamples_Step_256_14_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_step_256", "ComplexFFTSamples_Step_256_14_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_step_512", "ComplexInputSamples_Step_512_15_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_step_512", "ComplexInputIFFTSamples_Step_512_15_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_step_512", "ComplexFFTSamples_Step_512_15_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_step_1024", "ComplexInputSamples_Step_1024_16_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_step_1024", "ComplexInputIFFTSamples_Step_1024_16_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_step_1024", "ComplexFFTSamples_Step_1024_16_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_step_2048", "ComplexInputSamples_Step_2048_17_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_step_2048", "ComplexInputIFFTSamples_Step_2048_17_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_step_2048", "ComplexFFTSamples_Step_2048_17_f64.txt"),

                    new PatternModel("uint64_t", "in_cfft_step_4096", "ComplexInputSamples_Step_4096_18_f64.txt"),
                    new PatternModel("uint64_t", "in_cifft_step_4096", "ComplexInputIFFTSamples_Step_4096_18_f64.txt"),
                    new PatternModel("uint64_t", "ref_cfft_step_4096", "ComplexFFTSamples_Step_4096_18_f64.txt")
                }
            },

            // RF64
            new TestModel
            {
                TestCodePath = "transform/src/rf64.c",
                PatternRootPath = "Transform/TransformF64",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint64_t", "in_rfft_noisy_32", "RealInputSamples_Noisy_32_2_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_noisy_32", "RealInputIFFTSamples_Noisy_32_2_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_noisy_32", "RealFFTSamples_Noisy_32_2_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_noisy_64", "RealInputSamples_Noisy_64_3_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_noisy_64", "RealInputIFFTSamples_Noisy_64_3_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_noisy_64", "RealFFTSamples_Noisy_64_3_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_noisy_128", "RealInputSamples_Noisy_128_4_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_noisy_128", "RealInputIFFTSamples_Noisy_128_4_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_noisy_128", "RealFFTSamples_Noisy_128_4_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_noisy_256", "RealInputSamples_Noisy_256_5_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_noisy_256", "RealInputIFFTSamples_Noisy_256_5_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_noisy_256", "RealFFTSamples_Noisy_256_5_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_noisy_512", "RealInputSamples_Noisy_512_6_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_noisy_512", "RealInputIFFTSamples_Noisy_512_6_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_noisy_512", "RealFFTSamples_Noisy_512_6_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_noisy_1024", "RealInputSamples_Noisy_1024_7_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_noisy_1024", "RealInputIFFTSamples_Noisy_1024_7_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_noisy_1024", "RealFFTSamples_Noisy_1024_7_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_noisy_2048", "RealInputSamples_Noisy_2048_8_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_noisy_2048", "RealInputIFFTSamples_Noisy_2048_8_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_noisy_2048", "RealFFTSamples_Noisy_2048_8_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_noisy_4096", "RealInputSamples_Noisy_4096_9_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_noisy_4096", "RealInputIFFTSamples_Noisy_4096_9_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_noisy_4096", "RealFFTSamples_Noisy_4096_9_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_step_32", "RealInputSamples_Step_32_11_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_step_32", "RealInputIFFTSamples_Step_32_11_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_step_32", "RealFFTSamples_Step_32_11_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_step_64", "RealInputSamples_Step_64_12_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_step_64", "RealInputIFFTSamples_Step_64_12_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_step_64", "RealFFTSamples_Step_64_12_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_step_128", "RealInputSamples_Step_128_13_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_step_128", "RealInputIFFTSamples_Step_128_13_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_step_128", "RealFFTSamples_Step_128_13_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_step_256", "RealInputSamples_Step_256_14_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_step_256", "RealInputIFFTSamples_Step_256_14_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_step_256", "RealFFTSamples_Step_256_14_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_step_512", "RealInputSamples_Step_512_15_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_step_512", "RealInputIFFTSamples_Step_512_15_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_step_512", "RealFFTSamples_Step_512_15_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_step_1024", "RealInputSamples_Step_1024_16_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_step_1024", "RealInputIFFTSamples_Step_1024_16_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_step_1024", "RealFFTSamples_Step_1024_16_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_step_2048", "RealInputSamples_Step_2048_17_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_step_2048", "RealInputIFFTSamples_Step_2048_17_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_step_2048", "RealFFTSamples_Step_2048_17_f64.txt"),

                    new PatternModel("uint64_t", "in_rfft_step_4096", "RealInputSamples_Step_4096_18_f64.txt"),
                    new PatternModel("uint64_t", "in_rifft_step_4096", "RealInputIFFTSamples_Step_4096_18_f64.txt"),
                    new PatternModel("uint64_t", "ref_rfft_step_4096", "RealFFTSamples_Step_4096_18_f64.txt")
                }
            }
        };
    }
}
