using System;
using System.Collections.Generic;
using System.Text;
using Homework_4_5.Core.Utilities.Result;

namespace Homework_4_5.Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
