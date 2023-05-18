namespace Bamsunbic.Library.Models.Exception;

public class ErrorResponse
{
    /// <summary>
    /// 응답 상태 코드
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// 오류 코드
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// 오류 메세지
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// 디버깅을 위한 예외 내용
    /// </summary>
    public string Exception { get; set; }
    
    /// <summary>
    /// 디버깅을 위한 예외 상세 내용
    /// </summary>
    public string InnerException { get; set; }

    /// <summary>
    /// 오류가 발생한 파라미터명
    /// </summary>
    public string Parameter { get; set; }
}