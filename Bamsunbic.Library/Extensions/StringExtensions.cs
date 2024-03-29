﻿
namespace Bamsunbic.Library.Extensions;

/// <summary>
/// 문자열 확장 클래스
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// 해당 문자열을 사업자 번호 형식으로 변환함
    /// </summary>
    public static string ParseBusinessNumber(this string businessNumber)
    {
        if (businessNumber.Length == 10)
        {
            return $"{businessNumber.Substring(0, 3)}-{businessNumber.Substring(3, 2)}-{businessNumber.Substring(5, 5)}";
        }

        return businessNumber;
    }

    /// <summary>
    /// 해당 문자열을 일반전화 또는 휴대전화 형식으로 변환함
    /// </summary>
    public static string ParsePhoneNumber(this string phoneNumber)
    {
        switch (phoneNumber.Length)
        {
            case 9:
                return $"{phoneNumber.Substring(0, 2)}-{phoneNumber.Substring(2, 3)}-{phoneNumber.Substring(5, 4)}";
            
            case 10:
                if (phoneNumber.Substring(0, 2) == "02")
                {
                    return $"{phoneNumber.Substring(0, 2)}-{phoneNumber.Substring(2, 4)}-{phoneNumber.Substring(6, 4)}";
                }

                return $"{phoneNumber.Substring(0, 3)}-{phoneNumber.Substring(3, 3)}-{phoneNumber.Substring(6, 4)}";

            case 11:
                return $"{phoneNumber.Substring(0, 3)}-{phoneNumber.Substring(3, 4)}-{phoneNumber.Substring(7, 4)}";
            
            default:
                return phoneNumber;
        }
    }

    /// <summary>
    /// 해당 문자열을 사업자 번호 형식의 문자열 배열을 반환함
    /// </summary>
    public static string[] SplitBusinessNumber(this string businessNumber)
    {
        var businessNumberSplit = new string[3];
        if (businessNumber.Length == 10)
        {
            businessNumberSplit[0] = businessNumber.Substring(0, 3);
            businessNumberSplit[1] = businessNumber.Substring(3, 2);
            businessNumberSplit[2] = businessNumber.Substring(5, 5);
        }

        return businessNumberSplit;
    }

    /// <summary>
    /// 해당 문자열을 일반전화 또는 휴대전화 형식의 문자열 배열을 반환함
    /// </summary>
    public static string[] SplitPhoneNumber(this string phoneNumber)
    {
        var phoneNumberSplit = new string[3];
        switch (phoneNumber.Length)
        {
            case 9:
                phoneNumberSplit[0] = phoneNumber.Substring(0, 2);
                phoneNumberSplit[1] = phoneNumber.Substring(2, 3);
                phoneNumberSplit[2] = phoneNumber.Substring(5, 4);
                break;
            
            case 10:
                if (phoneNumber.Substring(0, 2) == "02")
                {
                    phoneNumberSplit[0] = phoneNumber.Substring(0, 2);
                    phoneNumberSplit[1] = phoneNumber.Substring(2, 4);
                    phoneNumberSplit[2] = phoneNumber.Substring(6, 4);
                }
                else
                {
                    phoneNumberSplit[0] = phoneNumber.Substring(0, 3);
                    phoneNumberSplit[1] = phoneNumber.Substring(3, 3);
                    phoneNumberSplit[2] = phoneNumber.Substring(6, 4);
                }
                break;
            
            case 11:
                phoneNumberSplit[0] = phoneNumber.Substring(0, 3);
                phoneNumberSplit[1] = phoneNumber.Substring(3, 4);
                phoneNumberSplit[2] = phoneNumber.Substring(7, 4);
                break;
        }

        return phoneNumberSplit;
    }
}