using Blogs.Application.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Components
{
    public class Result
    {
        protected Result(bool success, string error)
        {
            if (success && Guard.Ensure.IsNotNullOrEmptyOrWhiteSpace(error))
            {
                throw new InvalidOperationException("Succes operations should not be accompanied by error messages");
            }


            if (!success && Guard.Ensure.IsNullOrEmptyOrWhiteSpace(error))
            {
                throw new InvalidOperationException("Unsucces operations should not be accompanied by error messages");
            }

            Success = success;
            Error = error;
        }


        public bool Success { get; }

        public bool Failure => !Success;

        public string Error { get; }

        public static Result Ok()
        {
            return new Result(true, string.Empty);
        }

        public static Result Fail(string errorMessage)
        {
            return new Result(false, errorMessage);
        }



        public static Result<T> Ok<T>(T value)
        {
            return new Result<T>(true, string.Empty, value);
        }

        public static Result<T> Fail<T>(string errorMessage)
        {
            return new Result<T>(false, errorMessage, default(T));
        }
    }

    public class Result<T> : Result
    {
        protected internal Result(bool succes, string error, T value) : base(succes, error)
        {

            Value = value;
        }

        public T Value { get; }
    }
}
