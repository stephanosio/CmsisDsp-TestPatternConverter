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
    public class MatrixTest : Test
    {
        public override IEnumerable<TestModel> TestModels { get; protected set; } = new List<TestModel>
        {
            //
            // Matrix Unary Tests
            //

            // Q7
            new TestModel
            {
                TestCodePath = "matrix/src/unary_q7.c",
                PatternRootPath = "Matrix/Unary/UnaryQ7",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q7_t", "in_com1", "InputA1_q7.txt"),
                    new PatternModel("q7_t", "in_com2", "InputB1_q7.txt"),
                    new PatternModel("q7_t", "in_vec1", "InputVec1_q7.txt"),
                    //new PatternModel("q7_t", "in_cmplx1", "InputAC1_q7.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsUnary1_s16.txt"),
                    //new PatternModel("q7_t", "ref_add", "RefAdd1_q7.txt"),
                    //new PatternModel("q7_t", "ref_sub", "RefSub1_q7.txt"),
                    //new PatternModel("q7_t", "ref_scale", "RefScale1_q7.txt"),
                    new PatternModel("q7_t", "ref_trans", "RefTranspose1_q7.txt"),
                    new PatternModel("q7_t", "ref_vec_mult", "RefVecMul1_q7.txt"),
                    //new PatternModel("q7_t", "ref_cmplx_trans", "RefTransposeC1_q7.txt")
                }
            },

            // Q15
            new TestModel
            {
                TestCodePath = "matrix/src/unary_q15.c",
                PatternRootPath = "Matrix/Unary/UnaryQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_com1", "InputA1_q15.txt"),
                    new PatternModel("q15_t", "in_com2", "InputB1_q15.txt"),
                    new PatternModel("q15_t", "in_vec1", "InputVec1_q15.txt"),
                    new PatternModel("q15_t", "in_cmplx1", "InputAC1_q15.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsUnary1_s16.txt"),
                    new PatternModel("q15_t", "ref_add", "RefAdd1_q15.txt"),
                    new PatternModel("q15_t", "ref_sub", "RefSub1_q15.txt"),
                    new PatternModel("q15_t", "ref_scale", "RefScale1_q15.txt"),
                    new PatternModel("q15_t", "ref_trans", "RefTranspose1_q15.txt"),
                    new PatternModel("q15_t", "ref_vec_mult", "RefVecMul1_q15.txt"),
                    new PatternModel("q15_t", "ref_cmplx_trans", "RefTransposeC1_q15.txt")
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "matrix/src/unary_q31.c",
                PatternRootPath = "Matrix/Unary/UnaryQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_com1", "InputA1_q31.txt"),
                    new PatternModel("q31_t", "in_com2", "InputB1_q31.txt"),
                    new PatternModel("q31_t", "in_vec1", "InputVec1_q31.txt"),
                    new PatternModel("q31_t", "in_cmplx1", "InputAC1_q31.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsUnary1_s16.txt"),
                    new PatternModel("q31_t", "ref_add", "RefAdd1_q31.txt"),
                    new PatternModel("q31_t", "ref_sub", "RefSub1_q31.txt"),
                    new PatternModel("q31_t", "ref_scale", "RefScale1_q31.txt"),
                    new PatternModel("q31_t", "ref_trans", "RefTranspose1_q31.txt"),
                    new PatternModel("q31_t", "ref_vec_mult", "RefVecMul1_q31.txt"),
                    new PatternModel("q31_t", "ref_cmplx_trans", "RefTransposeC1_q31.txt")
                }
            },

            // F16
            new TestModel
            {
                TestCodePath = "matrix/src/unary_f16.c",
                PatternRootPath = "Matrix/Unary/UnaryF16",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint16_t", "in_com1", "InputA1_f16.txt"),
                    new PatternModel("uint16_t", "in_com2", "InputB1_f16.txt"),
                    new PatternModel("uint16_t", "in_inv", "InputInvert1_f16.txt"),
                    new PatternModel("uint16_t", "in_vec1", "InputVec1_f16.txt"),
                    new PatternModel("uint16_t", "in_cmplx1", "InputAC1_f16.txt"),
                    new PatternModel("uint16_t", "in_cholesky_dpo", "InputCholeskyDPO1_f16.txt"),
                    new PatternModel("uint16_t", "in_rnda_dpo", "InputRNDA1_f16.txt"),
                    new PatternModel("uint16_t", "in_uptriangular_dpo", "InputUTDPO1_f16.txt"),
                    new PatternModel("uint16_t", "in_lotriangular_dpo", "InputLTDPO1_f16.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsUnary1_s16.txt"),
                    new PatternModel("uint16_t", "in_inv_dims", "DimsInvert1_s16.txt"),
                    new PatternModel("uint16_t", "in_cholesky_dpo_dims", "DimsCholeskyDPO1_s16.txt"),
                    new PatternModel("uint16_t", "ref_add", "RefAdd1_f16.txt"),
                    new PatternModel("uint16_t", "ref_sub", "RefSub1_f16.txt"),
                    new PatternModel("uint16_t", "ref_scale", "RefScale1_f16.txt"),
                    new PatternModel("uint16_t", "ref_trans", "RefTranspose1_f16.txt"),
                    new PatternModel("uint16_t", "ref_inv", "RefInvert1_f16.txt"),
                    new PatternModel("uint16_t", "ref_vec_mult", "RefVecMul1_f16.txt"),
                    new PatternModel("uint16_t", "ref_cmplx_trans", "RefTransposeC1_f16.txt"),
                    new PatternModel("uint16_t", "ref_cholesky_dpo", "RefCholeskyDPO1_f16.txt"),
                    new PatternModel("uint16_t", "ref_uptriangular_dpo", "Ref_UTINV_DPO1_f16.txt"),
                    new PatternModel("uint16_t", "ref_lotriangular_dpo", "Ref_LTINV_DPO1_f16.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "matrix/src/unary_f32.c",
                PatternRootPath = "Matrix/Unary/UnaryF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_com1", "InputA1_f32.txt"),
                    new PatternModel("uint32_t", "in_com2", "InputB1_f32.txt"),
                    new PatternModel("uint32_t", "in_inv", "InputInvert1_f32.txt"),
                    new PatternModel("uint32_t", "in_vec1", "InputVec1_f32.txt"),
                    new PatternModel("uint32_t", "in_cmplx1", "InputAC1_f32.txt"),
                    new PatternModel("uint32_t", "in_cholesky_dpo", "InputCholeskyDPO1_f32.txt"),
                    new PatternModel("uint32_t", "in_rnda_dpo", "InputRNDA1_f32.txt"),
                    new PatternModel("uint32_t", "in_uptriangular_dpo", "InputUTDPO1_f32.txt"),
                    new PatternModel("uint32_t", "in_lotriangular_dpo", "InputLTDPO1_f32.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsUnary1_s16.txt"),
                    new PatternModel("uint16_t", "in_inv_dims", "DimsInvert1_s16.txt"),
                    new PatternModel("uint16_t", "in_cholesky_dpo_dims", "DimsCholeskyDPO1_s16.txt"),
                    new PatternModel("uint32_t", "ref_add", "RefAdd1_f32.txt"),
                    new PatternModel("uint32_t", "ref_sub", "RefSub1_f32.txt"),
                    new PatternModel("uint32_t", "ref_scale", "RefScale1_f32.txt"),
                    new PatternModel("uint32_t", "ref_trans", "RefTranspose1_f32.txt"),
                    new PatternModel("uint32_t", "ref_inv", "RefInvert1_f32.txt"),
                    new PatternModel("uint32_t", "ref_vec_mult", "RefVecMul1_f32.txt"),
                    new PatternModel("uint32_t", "ref_cmplx_trans", "RefTransposeC1_f32.txt"),
                    new PatternModel("uint32_t", "ref_cholesky_dpo", "RefCholeskyDPO1_f32.txt"),
                    new PatternModel("uint32_t", "ref_uptriangular_dpo", "Ref_UTINV_DPO1_f32.txt"),
                    new PatternModel("uint32_t", "ref_lotriangular_dpo", "Ref_LTINV_DPO1_f32.txt")
                }
            },

            // F64
            new TestModel
            {
                TestCodePath = "matrix/src/unary_f64.c",
                PatternRootPath = "Matrix/Unary/UnaryF64",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint64_t", "in_com1", "InputA1_f64.txt"),
                    new PatternModel("uint64_t", "in_com2", "InputB1_f64.txt"),
                    new PatternModel("uint64_t", "in_inv", "InputInvert1_f64.txt"),
                    new PatternModel("uint64_t", "in_cholesky_dpo", "InputCholeskyDPO1_f64.txt"),
                    new PatternModel("uint64_t", "in_rnda_dpo", "InputRNDA1_f64.txt"),
                    new PatternModel("uint64_t", "in_uptriangular_dpo", "InputUTDPO1_f64.txt"),
                    new PatternModel("uint64_t", "in_lotriangular_dpo", "InputLTDPO1_f64.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsUnary1_s16.txt"),
                    new PatternModel("uint16_t", "in_inv_dims", "DimsInvert1_s16.txt"),
                    new PatternModel("uint16_t", "in_cholesky_dpo_dims", "DimsCholeskyDPO1_s16.txt"),
                    //new PatternModel("uint64_t", "ref_add", "RefAdd1_f64.txt"),
                    new PatternModel("uint64_t", "ref_sub", "RefSub1_f64.txt"),
                    //new PatternModel("uint64_t", "ref_scale", "RefScale1_f64.txt"),
                    new PatternModel("uint64_t", "ref_trans", "RefTranspose1_f64.txt"),
                    new PatternModel("uint64_t", "ref_inv", "RefInvert1_f64.txt"),
                    new PatternModel("uint64_t", "ref_cholesky_dpo", "RefCholeskyDPO1_f64.txt"),
                    new PatternModel("uint64_t", "ref_uptriangular_dpo", "Ref_UTINV_DPO1_f64.txt"),
                    new PatternModel("uint64_t", "ref_lotriangular_dpo", "Ref_LTINV_DPO1_f64.txt")
                }
            },

            //
            // Matrix Binary Tests
            //

            // Q7
            new TestModel
            {
                TestCodePath = "matrix/src/binary_q7.c",
                PatternRootPath = "Matrix/Binary/BinaryQ7",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q7_t", "in_mult1", "InputA1_q7.txt"),
                    new PatternModel("q7_t", "in_mult2", "InputB1_q7.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsBinary1_s16.txt"),
                    new PatternModel("q7_t", "ref_mult", "RefMul1_q7.txt")
                }
            },

            // Q15
            new TestModel
            {
                TestCodePath = "matrix/src/binary_q15.c",
                PatternRootPath = "Matrix/Binary/BinaryQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_mult1", "InputA1_q15.txt"),
                    new PatternModel("q15_t", "in_mult2", "InputB1_q15.txt"),
                    new PatternModel("q15_t", "in_cmplx_mult1", "InputAC1_q15.txt"),
                    new PatternModel("q15_t", "in_cmplx_mult2", "InputBC1_q15.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsBinary1_s16.txt"),
                    new PatternModel("q15_t", "ref_mult", "RefMul1_q15.txt"),
                    new PatternModel("q15_t", "ref_cmplx_mult", "RefCmplxMul1_q15.txt"),
                }
            },

            // Q31
            new TestModel
            {
                TestCodePath = "matrix/src/binary_q31.c",
                PatternRootPath = "Matrix/Binary/BinaryQ31",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q31_t", "in_mult1", "InputA1_q31.txt"),
                    new PatternModel("q31_t", "in_mult2", "InputB1_q31.txt"),
                    new PatternModel("q31_t", "in_cmplx_mult1", "InputAC1_q31.txt"),
                    new PatternModel("q31_t", "in_cmplx_mult2", "InputBC1_q31.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsBinary1_s16.txt"),
                    new PatternModel("q31_t", "ref_mult", "RefMul1_q31.txt"),
                    new PatternModel("q31_t", "ref_cmplx_mult", "RefCmplxMul1_q31.txt"),
                }
            },

            // F16
            new TestModel
            {
                TestCodePath = "matrix/src/binary_f16.c",
                PatternRootPath = "Matrix/Binary/BinaryF16",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint16_t", "in_mult1", "InputA1_f16.txt"),
                    new PatternModel("uint16_t", "in_mult2", "InputB1_f16.txt"),
                    new PatternModel("uint16_t", "in_cmplx_mult1", "InputAC1_f16.txt"),
                    new PatternModel("uint16_t", "in_cmplx_mult2", "InputBC1_f16.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsBinary1_s16.txt"),
                    new PatternModel("uint16_t", "ref_mult", "RefMul1_f16.txt"),
                    new PatternModel("uint16_t", "ref_cmplx_mult", "RefCmplxMul1_f16.txt")
                }
            },

            // F32
            new TestModel
            {
                TestCodePath = "matrix/src/binary_f32.c",
                PatternRootPath = "Matrix/Binary/BinaryF32",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint32_t", "in_mult1", "InputA1_f32.txt"),
                    new PatternModel("uint32_t", "in_mult2", "InputB1_f32.txt"),
                    new PatternModel("uint32_t", "in_cmplx_mult1", "InputAC1_f32.txt"),
                    new PatternModel("uint32_t", "in_cmplx_mult2", "InputBC1_f32.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsBinary1_s16.txt"),
                    new PatternModel("uint32_t", "ref_mult", "RefMul1_f32.txt"),
                    new PatternModel("uint32_t", "ref_cmplx_mult", "RefCmplxMul1_f32.txt"),
                }
            },

            // F64
            new TestModel
            {
                TestCodePath = "matrix/src/binary_f64.c",
                PatternRootPath = "Matrix/Binary/BinaryF64",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("uint64_t", "in_mult1", "InputA1_f64.txt"),
                    new PatternModel("uint64_t", "in_mult2", "InputB1_f64.txt"),
                    new PatternModel("uint64_t", "in_cmplx_mult1", "InputAC1_f64.txt"),
                    new PatternModel("uint64_t", "in_cmplx_mult2", "InputBC1_f64.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsBinary1_s16.txt"),
                    new PatternModel("uint64_t", "ref_mult", "RefMul1_f64.txt"),
                    new PatternModel("uint64_t", "ref_cmplx_mult", "RefCmplxMul1_f64.txt")
                }
            }
        };
    }
}
