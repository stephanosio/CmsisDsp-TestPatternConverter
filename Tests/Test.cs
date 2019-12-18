using System;
using System.Collections.Generic;
using System.Linq;

using TestPatternConverter.Models;

namespace TestPatternConverter.Tests
{
    public abstract class Test
    {
        public abstract IEnumerable<TestModel> Tests { get; }

        public virtual TestModel Find(string testCodePath)
        {
            return Tests.Single(t => t.TestCodePath == testCodePath);
        }
    }
}
 