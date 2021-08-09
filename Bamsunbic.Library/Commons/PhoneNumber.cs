using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bamsunbic.Library.Commons
{
    /// <summary>
    /// 전화번호 정적 클래스
    /// </summary>
	public static class PhoneNumber
	{
        private static readonly string[] _telePhoneNumbers = new string[] { "02", "031", "032", "033", "041", "042", "043", "044", "051", "052", "053", "054", "055", "061", "062", "063", "064", "070" };
        private static readonly string[] _cellPhoneNumbers = new string[] { "010", "011", "016", "017", "019" };

        /// <summary>
        /// 일반전화 앞자리 전체를 가져옴
        /// </summary>
        public static string[] TelePhones
        {
            get { return _telePhoneNumbers; }
        }

        /// <summary>
        /// 휴대전화 앞자리 전체를 가져옴
        /// </summary>
        public static string[] CellPhones
        {
            get { return _cellPhoneNumbers; }
        }
    }
}
