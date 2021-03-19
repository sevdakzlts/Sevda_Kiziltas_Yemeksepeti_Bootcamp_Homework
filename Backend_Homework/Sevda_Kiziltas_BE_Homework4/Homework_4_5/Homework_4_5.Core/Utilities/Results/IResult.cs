using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4_5.Core.Utilities.Result
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
