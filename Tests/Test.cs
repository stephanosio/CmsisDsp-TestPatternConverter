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
            return TestModels.Single(t => t.TestCodePath == testCodePath);
        }

        public static Test operator +(Test a, Test b) =>
            new Test { TestModels = Enumerable.Concat(a.TestModels, b.TestModels) };
    }
}
 