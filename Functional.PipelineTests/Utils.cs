using System;
using System.Collections.Generic;
using System.Text;

namespace Functional.PipelineTests
{
    public static class Utils
    {
        public static T Id<T>(T value) => value;
    }
}
