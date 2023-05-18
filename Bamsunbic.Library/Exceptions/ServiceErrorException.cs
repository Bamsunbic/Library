using System;
using Bamsunbic.Library.Exceptions.Enums;

namespace Bamsunbic.Library.Exceptions;

public class ServiceErrorException : Exception
{
    /// <summary>
    /// 에러 종류
    /// </summary>
    public ApiErrorType ErrorType { get; set; }
    
    /// <summary>
    /// 에러 파라미터
    /// </summary>
    public string Parameter { get; set; }

    /// <summary>
    /// 에러 메세지 재작성 여부
    /// </summary>
    public bool IsRewriteMessage { get; set; }
    

    public ServiceErrorException(ApiErrorType errorType)
    {
        ErrorType = errorType;
    }
    
    public ServiceErrorException(string parameter)
    {
        ErrorType = ApiErrorType.EmptyParameter;
        Parameter = parameter;
    }

    public ServiceErrorException(ApiErrorType errorType, string message) : base(message)
    {
        ErrorType = errorType;
        IsRewriteMessage = true;
    }

    public ServiceErrorException(ApiErrorType errorType, string message, string parameter) : base(message)
    {
        ErrorType = errorType;
        IsRewriteMessage = true;
        Parameter = parameter;
    }
}