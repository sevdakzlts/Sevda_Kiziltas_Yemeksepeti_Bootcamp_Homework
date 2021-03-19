using Homework_4_5.Core.Utilities.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4_5.Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message): this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
