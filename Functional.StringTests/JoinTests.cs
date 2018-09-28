using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static Functional.String;

namespace Functional.StringTests
{
    public class JoinTests
    {
        [Fact]
        public void Success()
        {
            var result = Join(new[] { "a", "b", "c" }, ", ");
            Assert.Equal("a, b, c", result);
        }

        [Fact]
        public void ValueIsNull()
        {
            Action act = () =>
            {
                Join(null, "");
            };
            Assert.Throws<ArgumentNullException>(act);
        }
    }
}
