//-----------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="Telerik Academy">
//     Sample class library provided for exercise purposes
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;

namespace Telerik.ILS.Common
{
    /// <summary>
    /// Provides extension methods for operations on strings.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>Takes an input <see cref="string"/> and capitalizes its first character.</summary>
        /// <param name="input">A <see cref="string"/> to have its first letter capitalized.</param>
        /// <returns>A new copy of <paramref name="input"/> with a first letter transformed to uppercase if it is not null or empty, else <c>false</c>.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>Takes an input <see cref="string"/> and replaces any Cyrillic characters with their respective Latin counterparts.</summary>
        /// <param name="input">The <see cref="string"/> to be converted.</param>
        /// <returns>
        /// A new copy of <paramref name="input"/> with all Cyrillic characters replaced. If <paramref name="input"/>  <c>isNullOrEmpty</c> an empty <see cref="string"/> is returned.
        /// <para>Note that the characters are replaced with their Bulgarian substitutes, and that the transliteration provided by this method does not fully comply with the officially adopted <see href="https://en.wikipedia.org/wiki/Romanization_of_Bulgarian">Romanization of Bulgarian.</see></para>
        /// </returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>Takes an input <see cref="string"/> and replaces any Latin characters with their respective Cyrillic counterparts.</summary>
        /// <param name="input">The <see cref="string"/> to be converted.</param>
        /// <returns>
        /// A new copy of <paramref name="input"/> with all Latin characters replaced. If <paramref name="input"/>  <c>isNullOrEmpty</c> an empty <see cref="string"/> is returned.
        /// <para>Note that the characters are replaced with their Bulgarian substitutes, and that the transliteration provided by this method does not fully comply with the officially adopted <see href="https://en.wikipedia.org/wiki/Romanization_of_Bulgarian">Romanization of Bulgarian.</see></para>
        /// </returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>Extracts the file extension from a provided file name <see cref="string"/> literal.</summary>
        /// <param name="fileName">The <see cref="string"/> literal containing the file name.</param>
        /// <returns>
        /// A <see cref="string"/> containing the file extension. If <paramref name="fileName"/>  <c>isNullOrEmpty</c> an empty <see cref="string"/> is returned.
        /// </returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>Extracts the first <paramref name="charsCount"/> number of characters from a <see cref="string"/>.</summary>
        /// <param name="input">The <see cref="string"/> to extract from.</param>
        /// <param name="charsCount">The first <see cref="int"/> number of characters to be returned from the <see cref="string"/>.</param>
        /// <returns>
        /// A <see cref="string"/> containing the extracted characters. If the <paramref name="input"/> length is less than <paramref name="charsCount"/>, the entire <paramref name="input"/> is returned.
        /// </returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>Takes a <see cref="string"/> and extracts the part of it located between provided <paramref name="startString"/> and <paramref name="endString"/>.
        /// <para>Can optionally be provided with an <see cref="int"/>  <paramref name="startFrom"/> index to start matching after.</para></summary>
        /// <param name="input">The <see cref="string"/> to extract from.</param>
        /// <param name="startString">A <see cref="string"/> to match the start position of the result substring.</param>
        /// <param name="endString">A <see cref="string"/> to match the ending position of the result substring.</param>
        /// <param name="startFrom">An optional <see cref="int"/> index to start matching from.</param>
        /// <returns>
        /// A <see cref="string"/> containing the extracted substring. If any of the arguments is invalid or there was no match an empty <see cref="string"/> is returned.
        /// </returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>Converts a <see cref="string"/> to a <c>bool</c> value by comparing its contents against an internal <see cref="Array"/> of true-like values.</summary>
        /// <param name="input">The <see cref="string"/> to be evaluated for true-like values.</param>
        /// <returns>True if <paramref name="input"/> contains any of the true-like values on the list, else returns <c>false</c>.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>Creates a <see cref="byte"/>  <see cref="Array"/> copy of a <see cref="string"/>.</summary>
        /// <param name="input">A <see cref="string"/> to be copied.</param>
        /// <returns>Returns a <see cref="byte"/> <see cref="Array"/> copy of <paramref name="input"/>.</returns>
        public static byte[] ToByteArray(this string input)
        {
            // Calculate needed space and create empty Array
            var bytesArray = new byte[input.Length * sizeof(char)];
            // Copy the contents of input into the byte Array
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }

        /// <summary>Takes a file extension <see cref="string"/> literal and converts is to a content type <see cref="string"/>.</summary>
        /// <param name="fileExtension">The <see cref="string"/> literal containing a file extension type.</param>
        /// <returns>Content type <see cref="string"/> associated to the <paramref name="fileExtension"/> provided or a default content type if there are no matches.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };

            // Return the content type value matching the file extension key
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            // If no match, return a default value
            return "application/octet-stream";
        }

        /// <summary>Attempts to parse a <see cref="string"/> as a <see cref="DateTime"/> <c> struct</c>.</summary>
        /// <param name="input">The <see cref="string"/> to be converted.</param>
        /// <returns>A <see cref="DateTime"/> struct if operation successful, else returns the default <see cref="DateTime.MinValue"/>.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>Attempts to parse a <see cref="string"/> as an <see cref="int"/> (System.Int32) number.</summary>
        /// <param name="input">The <see cref="string"/> to be converted.</param>
        /// <returns>The <paramref name="input"/> parsed as an <see cref="int"/> number if operation successful, else returns <c>0</c>.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>Attempts to parse a <see cref="string"/> as a <see cref="long"/> (System.Int64) number.</summary>
        /// <param name="input">The <see cref="string"/> to be converted.</param>
        /// <returns>The <paramref name="input"/> parsed as a <see cref="long"/> number if the operation is successful, else returns <c>0</c>.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>Hashes a <see cref="string"/> using the <see cref="MD5"/> algorithm.</summary>
        /// <param name="input">The <see cref="string"/> to be hashed.</param>
        /// <returns>Returns a <see cref="MD5"/> hashed hexadecimal <see cref="string"/>. <see cref="System.Security.Cryptography.MD5"/>See: System.Security.Cryptography.MD5.</returns>
        /// <seealso href="https://en.wikipedia.org/wiki/MD5">See also: Wikipedia entry on MD5</seealso>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input <see cref="string"/> to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>Attempts to parse a <see cref="string"/> as a <see cref="short"/> (System.Int16) number.</summary>
        /// <param name="input">The <see cref="string"/> to be converted.</param>
        /// <returns>The <paramref name="input"/> parsed as a <see cref="short"/> number if operation successful, else returns <c>0</c>.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;

            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>Takes an user name <see cref="string"/> literal and returns a validated copy of it. 
        /// <para>Ensures conformity by converting any Cyrillic characters to Latin charset and removing characters not valid for user name creation.</para>
        /// <seealso cref="ConvertCyrillicToLatinLetters(string)"/></summary>
        /// <param name="input">The user name <see cref="string"/> literal to be converted.</param>
        /// <returns>Valid user name <see cref="string"/> generated from the <paramref name="input"/> or an empty <see cref="string"/>.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Takes an file name <see cref="string"/> literal and returns a validated copy of it.
        /// <para>Ensures conformity by converting any Cyrillic characters to Latin charset and removing characters not valid for file name creation.</para></summary>
        /// <param name="input">The file name <see cref="string"/> literal to be converted.</param>
        /// <returns>Valid file name <see cref="string"/> generated from the <paramref name="input"/> or an empty <see cref="string"/>.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }
    }
}