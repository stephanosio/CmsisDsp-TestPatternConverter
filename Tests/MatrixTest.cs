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

            // Q15
            new TestModel
            {
                TestCodePath = "matrix/src/unary_q15.c",
                PatternRootPath = "Matrix/Unary/UnaryQ15",
                Patterns = new List<PatternModel>
                {
                    new PatternModel("q15_t", "in_com1", "InputA1_q15.txt"),
                    new PatternModel("q15_t", "in_com2", "InputB1_q15.txt"),
                    new PatternModel("uint16_t", "in_dims", "DimsUnary1_s16.txt"),
                    new PatternModel("q15_t", "ref_add", "RefAdd1_q15.txt"),
                    new PatternModel("q15_t", "ref_sub", "RefSub1_q15.txt"),
                    new PatternModel("q15_t", "ref_scale", "RefScale1_q15.txt"),
                    new PatternModel("q15_t", "ref_trans", "RefTranspose1_q15.txt")
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
                    new PatternModel("uint16_t", "in_dims", "DimsUnary1_s16.txt"),
                    new PatternModel("q31_t", "ref_add", "RefAdd1_q31.txt"),
                    new PatternModel("q31_t", "ref_sub", "RefSub1_q31.txt"),
                    new PatternModel("q31_t", "ref_scale", "RefScale1_q31.txt"),
                    new PatternModel("q31_t", "ref_trans", "RefTranspose1_q31.txt")
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
                    new PatternModel("uint16_t", "in_dims", "DimsUnary1_s16.txt"),
                    new PatternModel("uint16_t", "in_inv_dims", "DimsInvert1_s16.txt"),
                    new PatternModel("uint32_t", "ref_add", "RefAdd1_f32.txt"),
                    new PatternModel("uint32_t", "ref_sub", "RefSub1_f32.txt"),
                    new PatternModel("uint32_t", "ref_scale", "RefScale1_f32.txt"),
                    new PatternModel("uint32_t", "ref_trans", "RefTranspose1_f32.txt"),
                    new PatternModel("uint32_t", "ref_inv", "RefInvert1_f32.txt")
                }
            },

            // F64
            new TestModel
            {
                TestCodePath = "matrix/src/unary_f64.c",
                PatternRootPath = "Matrix/Unary/UnaryF64",
                Patterns = new List<PatternModel>
                {
                    //new PatternModel("uint64_t", "in_com1", "InputA1_f64.txt"),
                    //new PatternModel("uint64_t", "in_com2", "InputB1_f64.txt"),
                    new PatternModel("uint64_t", "in_inv", "InputInvert1_f64.txt"),
                    //new PatternModel("uint16_t", "in_dims", "DimsUnary1_s16.txt"),
                    new PatternModel("uint16_t", "in_inv_dims", "DimsInvert1_s16.txt"),
                    //new PatternModel("uint64_t", "ref_add", "RefAdd1_f64.txt"),
                    //new PatternModel("uint64_t", "ref_sub", "RefSub1_f64.txt"),
                    //new PatternModel("uint64_t", "ref_scale", "RefScale1_f64.txt"),
                    //new PatternModel("uint64_t", "ref_trans", "RefTranspose1_f64.txt"),
                    new PatternModel("uint64_t", "ref_inv", "RefInvert1_f64.txt")
                }
            },

            //
            // Matrix Binary Tests
            //

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
            }
        };
    }
}
