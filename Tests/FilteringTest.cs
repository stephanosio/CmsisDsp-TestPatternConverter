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
    public class FilteringTest : Test
    {
        public override IEnumerable<TestModel> TestModels { get; protected set; } = new List<TestModel>
        {
            //
            // Filtering BIQUAD Tests
            //

            // Q15
            new TestModel
            {
                TestCodePath = "filtering/src/biquad_q15.c",
                PatternRootPath = "Filtering/BIQUAD/BIQUADQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_default_val", "BiquadInput1_q15.txt"),
                    new PatternModel("q15_t", "in_default_coeff", "BiquadCoefs1_q15.txt"),
                    new PatternModel("q15_t", "ref_default", "BiquadOutput1_q15.txt")
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "filtering/src/biquad_q31.c",
                PatternRootPath = "Filtering/BIQUAD/BIQUADQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_default_val", "BiquadInput1_q31.txt"),
                    new PatternModel("q31_t", "in_default_coeff", "BiquadCoefs1_q31.txt"),
                    new PatternModel("q31_t", "ref_default", "BiquadOutput1_q31.txt")
                }
            },

            // F16
            new TestModel
            {
                TestCodePath = "filtering/src/biquad_f16.c",
                PatternRootPath = "Filtering/BIQUAD/BIQUADF16",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint16_t", "in_default_val", "BiquadInput1_f16.txt"),
                    new PatternModel("uint16_t", "in_default_coeff", "BiquadCoefs1_f16.txt"),
                    new PatternModel("uint16_t", "ref_default", "BiquadOutput1_f16.txt"),

                    new PatternModel("uint16_t", "in_rand_coeff", "AllBiquadCoefs2_f16.txt"),
                    new PatternModel("uint16_t", "in_rand_config", "AllBiquadConfigs2_s16.txt"),

                    new PatternModel("uint16_t", "in_rand_mono_val", "AllBiquadInputs2_f16.txt"),
                    new PatternModel("uint16_t", "ref_rand_mono", "AllBiquadRefs2_f16.txt"),

                    new PatternModel("uint16_t", "in_rand_stereo_val", "AllBiquadStereoInputs2_f16.txt"),
                    new PatternModel("uint16_t", "ref_rand_stereo", "AllBiquadStereoRefs2_f16.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "filtering/src/biquad_f32.c",
                PatternRootPath = "Filtering/BIQUAD/BIQUADF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_default_val", "BiquadInput1_f32.txt"),
                    new PatternModel("uint32_t", "in_default_coeff", "BiquadCoefs1_f32.txt"),
                    new PatternModel("uint32_t", "ref_default", "BiquadOutput1_f32.txt"),

                    new PatternModel("uint32_t", "in_rand_coeff", "AllBiquadCoefs2_f32.txt"),
                    new PatternModel("uint16_t", "in_rand_config", "AllBiquadConfigs2_s16.txt"),

                    new PatternModel("uint32_t", "in_rand_mono_val", "AllBiquadInputs2_f32.txt"),
                    new PatternModel("uint32_t", "ref_rand_mono", "AllBiquadRefs2_f32.txt"),

                    new PatternModel("uint32_t", "in_rand_stereo_val", "AllBiquadStereoInputs2_f32.txt"),
                    new PatternModel("uint32_t", "ref_rand_stereo", "AllBiquadStereoRefs2_f32.txt")
                }
            },

            // F64
            new TestModel
            {
                TestCodePath = "filtering/src/biquad_f64.c",
                PatternRootPath = "Filtering/BIQUAD/BIQUADF64",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint64_t", "in_default_val", "BiquadInput1_f64.txt"),
                    new PatternModel("uint64_t", "in_default_coeff", "BiquadCoefs1_f64.txt"),
                    new PatternModel("uint64_t", "ref_default", "BiquadOutput1_f64.txt"),

                    new PatternModel("uint64_t", "in_rand_coeff", "AllBiquadCoefs2_f64.txt"),
                    new PatternModel("uint16_t", "in_rand_config", "AllBiquadConfigs2_s16.txt"),

                    new PatternModel("uint64_t", "in_rand_mono_val", "AllBiquadInputs2_f64.txt"),
                    new PatternModel("uint64_t", "ref_rand_mono", "AllBiquadRefs2_f64.txt")
                }
            },

            //
            // Filtering DECIM Tests
            //

            // Q15
            new TestModel
            {
                TestCodePath = "filtering/src/decim_q15.c",
                PatternRootPath = "Filtering/DECIM/DECIMQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_val_decim", "Input2_q15.txt"),
                    new PatternModel("q15_t", "in_coeff_decim", "Coefs2_q15.txt"),
                    new PatternModel("uint32_t", "in_config_decim", "Configs2_u32.txt"),
                    new PatternModel("q15_t", "in_val_interp", "Input3_q15.txt"),
                    new PatternModel("q15_t", "in_coeff_interp", "Coefs3_q15.txt"),
                    new PatternModel("uint32_t", "in_config_interp", "Configs3_u32.txt"),
                    new PatternModel("q15_t", "ref_decim", "Reference2_q15.txt"),
                    new PatternModel("q15_t", "ref_interp", "Reference3_q15.txt")
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "filtering/src/decim_q31.c",
                PatternRootPath = "Filtering/DECIM/DECIMQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_val_decim", "Input2_q31.txt"),
                    new PatternModel("q31_t", "in_coeff_decim", "Coefs2_q31.txt"),
                    new PatternModel("uint32_t", "in_config_decim", "Configs2_u32.txt"),
                    new PatternModel("q31_t", "in_val_interp", "Input3_q31.txt"),
                    new PatternModel("q31_t", "in_coeff_interp", "Coefs3_q31.txt"),
                    new PatternModel("uint32_t", "in_config_interp", "Configs3_u32.txt"),
                    new PatternModel("q31_t", "ref_decim", "Reference2_q31.txt"),
                    new PatternModel("q31_t", "ref_interp", "Reference3_q31.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "filtering/src/decim_f32.c",
                PatternRootPath = "Filtering/DECIM/DECIMF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_val_decim", "Input2_f32.txt"),
                    new PatternModel("uint32_t", "in_coeff_decim", "Coefs2_f32.txt"),
                    new PatternModel("uint32_t", "in_config_decim", "Configs2_u32.txt"),
                    new PatternModel("uint32_t", "in_val_interp", "Input3_f32.txt"),
                    new PatternModel("uint32_t", "in_coeff_interp", "Coefs3_f32.txt"),
                    new PatternModel("uint32_t", "in_config_interp", "Configs3_u32.txt"),
                    new PatternModel("uint32_t", "ref_decim", "Reference2_f32.txt"),
                    new PatternModel("uint32_t", "ref_interp", "Reference3_f32.txt")
                }
            },

            //
            // Filtering FIR Tests
            //

            // Q7
            new TestModel
            {
                TestCodePath = "filtering/src/fir_q7.c",
                PatternRootPath = "Filtering/FIR/FIRQ7",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q7_t", "in_val", "FirInput1_q7.txt"),
                    new PatternModel("q7_t", "in_coeff", "FirCoefs1_q7.txt"),
                    new PatternModel("uint16_t", "in_config", "FirConfigs1_s16.txt"),
                    new PatternModel("q7_t", "ref_val", "FirRefs1_q7.txt")
                }
            },

            // Q15
            new TestModel
            {
                TestCodePath = "filtering/src/fir_q15.c",
                PatternRootPath = "Filtering/FIR/FIRQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_val", "FirInput1_q15.txt"),
                    new PatternModel("q15_t", "in_coeff", "FirCoefs1_q15.txt"),
                    new PatternModel("uint16_t", "in_config", "FirConfigs1_s16.txt"),
                    new PatternModel("q15_t", "ref_val", "FirRefs1_q15.txt")
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "filtering/src/fir_q31.c",
                PatternRootPath = "Filtering/FIR/FIRQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_val", "FirInput1_q31.txt"),
                    new PatternModel("q31_t", "in_coeff", "FirCoefs1_q31.txt"),
                    new PatternModel("uint16_t", "in_config", "FirConfigs1_s16.txt"),
                    new PatternModel("q31_t", "ref_val", "FirRefs1_q31.txt")
                }
            },

            // F16
            new TestModel
            {
                TestCodePath = "filtering/src/fir_f16.c",
                PatternRootPath = "Filtering/FIR/FIRF16",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint16_t", "in_val", "FirInput1_f16.txt"),
                    new PatternModel("uint16_t", "in_coeff", "FirCoefs1_f16.txt"),
                    new PatternModel("uint16_t", "in_config", "FirConfigs1_s16.txt"),
                    new PatternModel("uint16_t", "ref_val", "FirRefs1_f16.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "filtering/src/fir_f32.c",
                PatternRootPath = "Filtering/FIR/FIRF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_val", "FirInput1_f32.txt"),
                    new PatternModel("uint32_t", "in_coeff", "FirCoefs1_f32.txt"),
                    new PatternModel("uint16_t", "in_config", "FirConfigs1_s16.txt"),
                    new PatternModel("uint32_t", "ref_val", "FirRefs1_f32.txt")
                }
            },

            //
            // Filtering MISC Tests
            //

            // Q7
            new TestModel
            {
                TestCodePath = "filtering/src/misc_q7.c",
                PatternRootPath = "Filtering/MISC/MISCQ7",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q7_t", "in_com1", "InputsA1_q7.txt"),
                    new PatternModel("q7_t", "in_com2", "InputsB1_q7.txt"),
                    new PatternModel("q7_t", "in_partial1", "InputsA2_q7.txt"),
                    new PatternModel("q7_t", "in_partial2", "InputsB2_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_30_31", "Reference1_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_30_32", "Reference2_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_30_33", "Reference3_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_30_34", "Reference4_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_30_49", "Reference5_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_31_31", "Reference6_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_31_32", "Reference7_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_31_33", "Reference8_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_31_34", "Reference9_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_31_49", "Reference10_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_32_31", "Reference11_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_32_32", "Reference12_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_32_33", "Reference13_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_32_34", "Reference14_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_32_49", "Reference15_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_33_31", "Reference16_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_33_32", "Reference17_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_33_33", "Reference18_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_33_34", "Reference19_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_33_49", "Reference20_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_48_31", "Reference21_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_48_32", "Reference22_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_48_33", "Reference23_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_48_34", "Reference24_q7.txt"),
                    new PatternModel("q7_t", "ref_correlate_48_49", "Reference25_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_30_31", "Reference26_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_30_32", "Reference27_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_30_33", "Reference28_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_30_34", "Reference29_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_30_49", "Reference30_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_31_31", "Reference31_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_31_32", "Reference32_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_31_33", "Reference33_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_31_34", "Reference34_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_31_49", "Reference35_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_32_31", "Reference36_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_32_32", "Reference37_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_32_33", "Reference38_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_32_34", "Reference39_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_32_49", "Reference40_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_33_31", "Reference41_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_33_32", "Reference42_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_33_33", "Reference43_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_33_34", "Reference44_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_33_49", "Reference45_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_48_31", "Reference46_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_48_32", "Reference47_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_48_33", "Reference48_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_48_34", "Reference49_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_48_49", "Reference50_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_partial_3_6_8", "Reference54_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_partial_9_6_8", "Reference55_q7.txt"),
                    new PatternModel("q7_t", "ref_conv_partial_7_6_8", "Reference56_q7.txt")
                }
            },

            // Q15
            new TestModel
            {
                TestCodePath = "filtering/src/misc_q15.c",
                PatternRootPath = "Filtering/MISC/MISCQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_com1", "InputsA1_q15.txt"),
                    new PatternModel("q15_t", "in_com2", "InputsB1_q15.txt"),
                    new PatternModel("q15_t", "in_partial1", "InputsA2_q15.txt"),
                    new PatternModel("q15_t", "in_partial2", "InputsB2_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_14_15", "Reference1_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_14_16", "Reference2_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_14_17", "Reference3_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_14_18", "Reference4_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_14_33", "Reference5_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_15_15", "Reference6_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_15_16", "Reference7_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_15_17", "Reference8_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_15_18", "Reference9_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_15_33", "Reference10_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_16_15", "Reference11_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_16_16", "Reference12_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_16_17", "Reference13_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_16_18", "Reference14_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_16_33", "Reference15_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_17_15", "Reference16_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_17_16", "Reference17_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_17_17", "Reference18_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_17_18", "Reference19_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_17_33", "Reference20_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_32_15", "Reference21_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_32_16", "Reference22_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_32_17", "Reference23_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_32_18", "Reference24_q15.txt"),
                    new PatternModel("q15_t", "ref_correlate_32_33", "Reference25_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_14_15", "Reference26_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_14_16", "Reference27_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_14_17", "Reference28_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_14_18", "Reference29_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_14_33", "Reference30_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_15_15", "Reference31_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_15_16", "Reference32_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_15_17", "Reference33_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_15_18", "Reference34_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_15_33", "Reference35_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_16_15", "Reference36_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_16_16", "Reference37_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_16_17", "Reference38_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_16_18", "Reference39_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_16_33", "Reference40_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_17_15", "Reference41_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_17_16", "Reference42_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_17_17", "Reference43_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_17_18", "Reference44_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_17_33", "Reference45_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_32_15", "Reference46_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_32_16", "Reference47_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_32_17", "Reference48_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_32_18", "Reference49_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_32_33", "Reference50_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_partial_3_6_8", "Reference54_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_partial_9_6_8", "Reference55_q15.txt"),
                    new PatternModel("q15_t", "ref_conv_partial_7_6_8", "Reference56_q15.txt")
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "filtering/src/misc_q31.c",
                PatternRootPath = "Filtering/MISC/MISCQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_com1", "InputsA1_q31.txt"),
                    new PatternModel("q31_t", "in_com2", "InputsB1_q31.txt"),
                    new PatternModel("q31_t", "in_partial1", "InputsA2_q31.txt"),
                    new PatternModel("q31_t", "in_partial2", "InputsB2_q31.txt"),
                    new PatternModel("q31_t", "in_levinson_durbin_3_0", "InputPhi81_q31.txt"),
                    new PatternModel("q31_t", "in_levinson_durbin_8_1", "InputPhi82_q31.txt"),
                    new PatternModel("q31_t", "in_levinson_durbin_11_2", "InputPhi83_q31.txt"),
                    new PatternModel("q31_t", "in_levinson_durbin_err", "LDErrors81_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_4_1", "Reference1_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_4_2", "Reference2_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_4_3", "Reference3_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_4_8", "Reference4_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_4_11", "Reference5_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_5_1", "Reference6_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_5_2", "Reference7_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_5_3", "Reference8_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_5_8", "Reference9_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_5_11", "Reference10_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_6_1", "Reference11_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_6_2", "Reference12_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_6_3", "Reference13_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_6_8", "Reference14_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_6_11", "Reference15_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_9_1", "Reference16_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_9_2", "Reference17_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_9_3", "Reference18_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_9_8", "Reference19_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_9_11", "Reference20_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_10_1", "Reference21_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_10_2", "Reference22_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_10_3", "Reference23_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_10_8", "Reference24_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_10_11", "Reference25_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_11_1", "Reference26_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_11_2", "Reference27_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_11_3", "Reference28_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_11_8", "Reference29_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_11_11", "Reference30_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_12_1", "Reference31_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_12_2", "Reference32_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_12_3", "Reference33_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_12_8", "Reference34_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_12_11", "Reference35_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_13_1", "Reference36_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_13_2", "Reference37_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_13_3", "Reference38_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_13_8", "Reference39_q31.txt"),
                    new PatternModel("q31_t", "ref_correlate_13_11", "Reference40_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_4_1", "Reference41_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_4_2", "Reference42_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_4_3", "Reference43_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_4_8", "Reference44_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_4_11", "Reference45_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_5_1", "Reference46_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_5_2", "Reference47_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_5_3", "Reference48_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_5_8", "Reference49_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_5_11", "Reference50_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_6_1", "Reference51_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_6_2", "Reference52_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_6_3", "Reference53_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_6_8", "Reference54_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_6_11", "Reference55_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_9_1", "Reference56_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_9_2", "Reference57_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_9_3", "Reference58_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_9_8", "Reference59_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_9_11", "Reference60_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_10_1", "Reference61_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_10_2", "Reference62_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_10_3", "Reference63_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_10_8", "Reference64_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_10_11", "Reference65_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_11_1", "Reference66_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_11_2", "Reference67_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_11_3", "Reference68_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_11_8", "Reference69_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_11_11", "Reference70_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_12_1", "Reference71_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_12_2", "Reference72_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_12_3", "Reference73_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_12_8", "Reference74_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_12_11", "Reference75_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_13_1", "Reference76_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_13_2", "Reference77_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_13_3", "Reference78_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_13_8", "Reference79_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_13_11", "Reference80_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_partial_3_6_8", "Reference84_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_partial_9_6_8", "Reference85_q31.txt"),
                    new PatternModel("q31_t", "ref_conv_partial_7_6_8", "Reference86_q31.txt"),
                    new PatternModel("q31_t", "ref_levinson_durbin_3_0", "Reference81_q31.txt"),
                    new PatternModel("q31_t", "ref_levinson_durbin_8_1", "Reference82_q31.txt"),
                    new PatternModel("q31_t", "ref_levinson_durbin_11_2", "Reference83_q31.txt")
                }
            },

            // F16
            new TestModel
            {
                TestCodePath = "filtering/src/misc_f16.c",
                PatternRootPath = "Filtering/MISC/MISCF16",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint16_t", "in_com1", "InputsA1_f16.txt"),
                    new PatternModel("uint16_t", "in_com2", "InputsB1_f16.txt"),
                    new PatternModel("uint16_t", "in_levinson_durbin_7_0", "InputPhi81_f16.txt"),
                    new PatternModel("uint16_t", "in_levinson_durbin_16_1", "InputPhi82_f16.txt"),
                    new PatternModel("uint16_t", "in_levinson_durbin_23_2", "InputPhi83_f16.txt"),
                    new PatternModel("uint16_t", "in_levinson_durbin_err", "LDErrors81_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_4_1", "Reference1_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_4_2", "Reference2_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_4_3", "Reference3_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_4_8", "Reference4_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_4_11", "Reference5_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_5_1", "Reference6_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_5_2", "Reference7_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_5_3", "Reference8_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_5_8", "Reference9_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_5_11", "Reference10_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_6_1", "Reference11_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_6_2", "Reference12_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_6_3", "Reference13_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_6_8", "Reference14_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_6_11", "Reference15_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_9_1", "Reference16_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_9_2", "Reference17_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_9_3", "Reference18_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_9_8", "Reference19_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_9_11", "Reference20_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_10_1", "Reference21_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_10_2", "Reference22_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_10_3", "Reference23_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_10_8", "Reference24_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_10_11", "Reference25_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_11_1", "Reference26_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_11_2", "Reference27_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_11_3", "Reference28_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_11_8", "Reference29_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_11_11", "Reference30_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_12_1", "Reference31_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_12_2", "Reference32_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_12_3", "Reference33_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_12_8", "Reference34_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_12_11", "Reference35_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_13_1", "Reference36_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_13_2", "Reference37_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_13_3", "Reference38_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_13_8", "Reference39_f16.txt"),
                    new PatternModel("uint16_t", "ref_correlate_13_11", "Reference40_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_4_1", "Reference41_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_4_2", "Reference42_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_4_3", "Reference43_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_4_8", "Reference44_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_4_11", "Reference45_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_5_1", "Reference46_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_5_2", "Reference47_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_5_3", "Reference48_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_5_8", "Reference49_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_5_11", "Reference50_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_6_1", "Reference51_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_6_2", "Reference52_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_6_3", "Reference53_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_6_8", "Reference54_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_6_11", "Reference55_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_9_1", "Reference56_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_9_2", "Reference57_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_9_3", "Reference58_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_9_8", "Reference59_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_9_11", "Reference60_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_10_1", "Reference61_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_10_2", "Reference62_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_10_3", "Reference63_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_10_8", "Reference64_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_10_11", "Reference65_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_11_1", "Reference66_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_11_2", "Reference67_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_11_3", "Reference68_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_11_8", "Reference69_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_11_11", "Reference70_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_12_1", "Reference71_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_12_2", "Reference72_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_12_3", "Reference73_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_12_8", "Reference74_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_12_11", "Reference75_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_13_1", "Reference76_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_13_2", "Reference77_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_13_3", "Reference78_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_13_8", "Reference79_f16.txt"),
                    new PatternModel("uint16_t", "ref_conv_13_11", "Reference80_f16.txt"),
                    new PatternModel("uint16_t", "ref_levinson_durbin_7_0", "Reference81_f16.txt"),
                    new PatternModel("uint16_t", "ref_levinson_durbin_16_1", "Reference82_f16.txt"),
                    new PatternModel("uint16_t", "ref_levinson_durbin_23_2", "Reference83_f16.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "filtering/src/misc_f32.c",
                PatternRootPath = "Filtering/MISC/MISCF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_com1", "InputsA1_f32.txt"),
                    new PatternModel("uint32_t", "in_com2", "InputsB1_f32.txt"),
                    new PatternModel("uint32_t", "in_partial1", "InputsA2_f32.txt"),
                    new PatternModel("uint32_t", "in_partial2", "InputsB2_f32.txt"),
                    new PatternModel("uint32_t", "in_levinson_durbin_3_0", "InputPhi81_f32.txt"),
                    new PatternModel("uint32_t", "in_levinson_durbin_8_1", "InputPhi82_f32.txt"),
                    new PatternModel("uint32_t", "in_levinson_durbin_11_2", "InputPhi83_f32.txt"),
                    new PatternModel("uint32_t", "in_levinson_durbin_err", "LDErrors81_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_4_1", "Reference1_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_4_2", "Reference2_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_4_3", "Reference3_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_4_8", "Reference4_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_4_11", "Reference5_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_5_1", "Reference6_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_5_2", "Reference7_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_5_3", "Reference8_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_5_8", "Reference9_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_5_11", "Reference10_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_6_1", "Reference11_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_6_2", "Reference12_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_6_3", "Reference13_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_6_8", "Reference14_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_6_11", "Reference15_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_9_1", "Reference16_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_9_2", "Reference17_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_9_3", "Reference18_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_9_8", "Reference19_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_9_11", "Reference20_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_10_1", "Reference21_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_10_2", "Reference22_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_10_3", "Reference23_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_10_8", "Reference24_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_10_11", "Reference25_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_11_1", "Reference26_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_11_2", "Reference27_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_11_3", "Reference28_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_11_8", "Reference29_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_11_11", "Reference30_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_12_1", "Reference31_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_12_2", "Reference32_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_12_3", "Reference33_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_12_8", "Reference34_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_12_11", "Reference35_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_13_1", "Reference36_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_13_2", "Reference37_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_13_3", "Reference38_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_13_8", "Reference39_f32.txt"),
                    new PatternModel("uint32_t", "ref_correlate_13_11", "Reference40_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_4_1", "Reference41_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_4_2", "Reference42_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_4_3", "Reference43_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_4_8", "Reference44_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_4_11", "Reference45_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_5_1", "Reference46_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_5_2", "Reference47_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_5_3", "Reference48_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_5_8", "Reference49_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_5_11", "Reference50_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_6_1", "Reference51_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_6_2", "Reference52_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_6_3", "Reference53_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_6_8", "Reference54_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_6_11", "Reference55_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_9_1", "Reference56_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_9_2", "Reference57_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_9_3", "Reference58_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_9_8", "Reference59_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_9_11", "Reference60_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_10_1", "Reference61_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_10_2", "Reference62_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_10_3", "Reference63_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_10_8", "Reference64_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_10_11", "Reference65_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_11_1", "Reference66_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_11_2", "Reference67_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_11_3", "Reference68_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_11_8", "Reference69_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_11_11", "Reference70_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_12_1", "Reference71_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_12_2", "Reference72_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_12_3", "Reference73_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_12_8", "Reference74_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_12_11", "Reference75_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_13_1", "Reference76_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_13_2", "Reference77_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_13_3", "Reference78_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_13_8", "Reference79_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_13_11", "Reference80_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_partial_3_6_8", "Reference84_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_partial_9_6_8", "Reference85_f32.txt"),
                    new PatternModel("uint32_t", "ref_conv_partial_7_6_8", "Reference86_f32.txt"),
                    new PatternModel("uint32_t", "ref_levinson_durbin_3_0", "Reference81_f32.txt"),
                    new PatternModel("uint32_t", "ref_levinson_durbin_8_1", "Reference82_f32.txt"),
                    new PatternModel("uint32_t", "ref_levinson_durbin_11_2", "Reference83_f32.txt")
                }
            }
        };
    }
}
