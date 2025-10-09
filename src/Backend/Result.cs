using System;

namespace Backend
{
    public sealed class Result<T> : Result
    {
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

    public class Result
    {
        public ResultEnum Status { get; }

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

        public bool IsSuccess => Status == ResultEnum.Success;
    }

    public enum ResultEnum
    {
        Success,
        GeneralFailure,
        NotEnoughSpace
    }
}
