using System.Net;
using Bamsunbic.Library.Exceptions.Attributes;

namespace Bamsunbic.Library.Exceptions.Enums;

public enum ApiErrorType
{
    /// <remarks>
    ///		<para>에러명 : 유효성 검사 실패</para>
    ///		<para>에러 코드 : 400001</para>
    ///		<para>에러 메세지 : 해당 필드가 존재하지 않습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.BadRequest, 400001, "필수 입력 값이 비어 있습니다.")]
    EmptyParameter,

    /// <remarks>
    ///		<para>에러명 : 유효성 검사 실패</para>
    ///		<para>에러 코드 : 400002</para>
    ///		<para>에러 메세지 : 유효성 검사를 실패하였습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.BadRequest, 400002, "유효성 검사를 실패하였습니다.")]
    ValueRegexMismatch,

    /// <remarks>
    ///		<para>에러명 : 잘못된 요청</para>
    ///		<para>에러 코드 : 400003</para>
    ///		<para>에러 메세지 : 요청과 함께 일반 오류가 발생하였습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.BadRequest, 400003, "요청과 함께 일반 오류가 발생하였습니다.")]
    BadRequest,

    /// <remarks>
    ///		<para>에러명 : 등록 실패</para>
    ///		<para>에러 코드 : 400004</para>
    ///		<para>에러 메세지 : 등록을 실패하였습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.BadRequest, 400004, "등록을 실패하였습니다.")]
    RegistraionFailed,

    /// <remarks>
    ///		<para>에러명 : 수정 실패</para>
    ///		<para>에러 코드 : 400005</para>
    ///		<para>에러 메세지 : 수정을 실패하였습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.BadRequest, 400005, "수정을 실패하였습니다.")]
    ChangeFailed,

    /// <remarks>
    ///		<para>에러명 : 삭제 실패</para>
    ///		<para>에러 코드 : 400006</para>
    ///		<para>에러 메세지 : 삭제를 실패하였습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.BadRequest, 400006, "삭제를 실패하였습니다.")]
    DeleteFailed,

    /// <remarks>
    ///		<para>에러명 : 권한 없음</para>
    ///		<para>에러 코드 : 401001</para>
    ///		<para>에러 메세지 : 권한이 없습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.Unauthorized, 401001, "권한이 없습니다.")]
    Unauthorized,

    /// <remarks>
    ///		<para>에러명 : 토큰 만료</para>
    ///		<para>에러 코드 : 401002</para>
    ///		<para>에러 메세지 : 제공된 토큰이 만료되었습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.Unauthorized, 401002, "제공된 토큰이 만료되었습니다.")]
    AccessTokenExpired,

    /// <remarks>
    ///		<para>에러명 : 토큰 해지</para>
    ///		<para>에러 코드 : 401003</para>
    ///		<para>에러 메세지 : 제공된 토큰이 해지되었습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.Unauthorized, 401003, "제공된 토큰이 해지되었습니다.")]
    AccessTokenRevoked,

    /// <remarks>
    ///		<para>에러명 : 접근 권한 없음</para>
    ///		<para>에러 코드 : 403001</para>
    ///		<para>에러 메세지 : 엑세스 권한이 없습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.Unauthorized, 403001, "접근 권한이 없습니다.")]
    Forbidden,

    /// <remarks>
    ///		<para>에러명 : 찾을 수 없음</para>
    ///		<para>에러 코드 : 404001</para>
    ///		<para>에러 메세지 : 요청하신 리소스를 찾을 수 없습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.NotFound, 404001, "요청하신 리소스를 찾을 수 없습니다.")]
    ResourceNotFound,

    /// <remarks>
    ///		<para>에러명 : 찾을 수 없음</para>
    ///		<para>에러 코드 : 404002</para>
    ///		<para>에러 메세지 : 이미지 경로가 존재하지 않습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.NotFound, 404002, "이미지 경로가 존재하지 않습니다.")]
    EmptyImagePath,

    /// <remarks>
    ///		<para>에러명 : 서버 에러</para>
    ///		<para>에러 코드 : 500001</para>
    ///		<para>에러 메세지 : 서버에서 에러가 발생하였습니다.</para>
    /// </remarks>
    [Error(HttpStatusCode.InternalServerError, 500001, "서버에서 에러가 발생하였습니다.")]
    InternalServerError
}