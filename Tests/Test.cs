/*
 * Copyright (c) 2021 Stephanos Ioannidis <root@stephanos.io>
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System;
using System.Collections.Generic;
using System.Linq;

using TestPatternConverter.Models;

namespace TestPatternConverter.Tests
{
    public class Test
    {
        public virtual IEnumerable<TestModel> TestModels { get; protected set; }

        public virtual TestModel Find(string testCodePath)
        {
            try
            {
                return TestModels.Single(t => t.TestCodePath == testCodePath);
            }
            catch (Exception ex)
            {
                throw new KeyNotFoundException(testCodePath, ex);
            }
        }

        public static Test operator +(Test a, Test b) =>
            new Test { TestModels = Enumerable.Concat(a.TestModels, b.TestModels) };
    }
}
 