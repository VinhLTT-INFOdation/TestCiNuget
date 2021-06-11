using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MaxV.Helper
{
    public static class ParserHelper
    {
        /// <summary>
        /// Parse string data json to a object data
        /// </summary>
        /// <returns></returns>
        public static void TryParse<T>(this string data, out T result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(data);
            }
            catch
            {
                result = default(T);
            }
        }
        /// <summary>
        /// Parse string data json to a object data
        /// </summary>
        /// <returns></returns>
        public static T Parse<T>(this string data)
        {
            return JsonSerializer.Deserialize<T>(data);
        }
        /// <summary>
        /// Parse a object to string of json structure
        /// </summary>
        public static string TryParseToString<T>(this T data)
        {
            string result = string.Empty;
            try
            {
                result = JsonSerializer.Serialize(data);
                return result;
            }
            catch
            {
                return result;
            }
        }
        /// <summary>
        /// Parse a object to string of json structure
        /// </summary>
        public static string TryParseToBase64<T>(this T data)
        {
            string result = string.Empty;
            try
            {
                result = TryParseToString(data);
                Base64Encode(result);
                return result;
            }
            catch
            {
                return null;
            }
        }
        public static string Base64Encode(this string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Base64Decode
        /// </summary>
        /// <param name="base64EncodedData"></param>
        /// <returns></returns>
        public static string Base64Decode(this string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
