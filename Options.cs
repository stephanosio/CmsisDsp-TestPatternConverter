/*
 * Copyright (c) 2019 Stephanos Ioannidis <root@stephanos.io>
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommandLine;

namespace TestPatternConverter
{
    public class Options
    {
        [Option('v', "verbose", Required = false, HelpText = "Output verbose messages.")]
        public bool Verbose { get; set; }

        [Option('c', "testcodebasepath", Required = true, HelpText = "Path to the directory containing the Zephyr CMSIS-DSP test code")]
        public string TestCodeBasePath { get; set; }

        [Option('p', "patternbasepath", Required = true, HelpText = "Path to the directory containing the CMSIS-DSP test patterns")]
        public string PatternBasePath { get; set; }

        [Option('t', "test", Required = false, HelpText = "Name of the test pattern to be converted")]
        public IEnumerable<string> Tests { get; set; }
    }
}
