using Functional.Pipeline;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static Functional.PipelineTests.Utils;

namespace Functional.PipelineTests
{
    public class ExtensionsTests
    {
        [Fact]
        public void Success()
        {
            var result = "x".Pipe(
                x => $"{x} {x}",
                x => $"{x} x");
            Assert.Equal("x x x", result);
        }

        [Fact]
        public void NullTest()
        {
            string value = null;
            var result = value.Pipe(Id);
            Assert.Null(result);
        }

        [Fact]
        public void NullCoalescenceOperatorTest()
        {
            string value = null;
            var result = value?.Pipe(Id) ?? "";
            Assert.Equal("", result);
        }
    }
}
