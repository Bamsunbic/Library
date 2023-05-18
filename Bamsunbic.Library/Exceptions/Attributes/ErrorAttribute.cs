using System;
using System.Net;

namespace Bamsunbic.Library.Exceptions.Attributes;


[AttributeUsage(AttributeTargets.Field)]
public sealed class ErrorAttribute : Attribute
{
    public ErrorAttribute(HttpStatusCode status, int code, string message)
    {
        Status = status;
        Code = code;
        Message = message;
    }

    public HttpStatusCode Status { get; }

    public int Code { get; }

    public string Message { get; }
}