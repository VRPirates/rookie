using System;

namespace Backend
{
    /// <summary>
    /// Operation result.
    /// </summary>
    /// <typeparam name="T">Type of return value.</typeparam>
    public sealed class Result<T> : Result
    {
        /// <summary>
        /// Result of the operation.
        /// </summary>
        public T ResultObject { get; }

        public Result(ResultEnum status, T resultObject) : base(status)
        {
            ResultObject = resultObject;
        }

        public Result(
            ResultEnum status,
            string statusMessage,
            T resultObject
            ) : base(status, statusMessage)
        {
            ResultObject = resultObject;
        }

        public Result(
            ResultEnum status,
            Exception exception,
            T resultObject
            ) : base(status, exception)
        {
            ResultObject = resultObject;
        }
    }

    /// <summary>
    /// Operation result.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Operation status.
        /// </summary>
        public ResultEnum Status { get; }

        /// <summary>
        /// Operation result message.
        /// </summary>
        public string Message { get; }

        public Result(ResultEnum status)
        {
            Status = status;
            Message = null; 
        }

        public Result(
            ResultEnum status,
            string statusMessage
            )
        {
            Status = status;
            Message = statusMessage;
        }

        public Result(
            ResultEnum status,
            Exception exception
            )
        {
            Status = status;
            Message = exception.ToString();
        }

        /// <summary>
        /// Is operation successful.
        /// </summary>
        public bool IsSuccess => Status == ResultEnum.Success;
    }

    public enum ResultEnum
    {
        Success,
        GeneralFailure,
        NotEnoughSpace
    }
}
