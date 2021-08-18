/*
 * Copyright (c) 2021 Stephanos Ioannidis <root@stephanos.io>
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternConverter.Models
{
    public class TestModel
    {
        /// <summary>
        /// Relative path to the converted Zephyr test
        /// (in the Zephyr repository)
        /// </summary>
        public string TestCodePath { get; set; }

        /// <summary>
        /// Relative path to the directory containing the patterns
        /// (in the CMSIS-DSP repository)
        /// </summary>
        public string PatternRootPath { get; set; }

        /// <summary>
        /// Patterns
        /// </summary>
        public IList<PatternModel> Patterns { get; set; }
    }
}
