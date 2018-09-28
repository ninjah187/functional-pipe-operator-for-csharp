using System;
using Xunit;
using static Functional.Pipeline.Operator;
using static Functional.PipelineTests.Utils;

namespace Functional.PipelineTests
{
    public class OperatorTests
    {
        [Fact]
        public void Success()
        {
            var result = Pipe("x",
                x => $"{x} {x}",
                x => $"{x} x");
            Assert.Equal("x x x", result);
        }

        [Fact]
        public void NullTest()
        {
            string value = null;
            var result = Pipe(value, Id);
            Assert.Null(result);
        }
    }
}
