using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullNameSplit
{
    public static class SplitFullName
    {
        /// <summary>
        /// Get Irregular FullName and Surname number, return Regular Fullname, Fistname, Surname and Middle name.
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="surnameLegth"></param>
        /// <returns>Dynamic Data</returns>
        public static dynamic FullNameSplitter(string fullName, int surnameNumber)
        {
            string normalizeFullName = "";
            string middleNames = "";
            string firstName = "";
            string surName = "";

            var splitNameList = fullName.Split(' ').ToList().Where(t => t != "").ToList();

            splitNameList.ForEach(t => normalizeFullName += t + (splitNameList[splitNameList.Count - 1].Equals(t) ? "" : " "));

            var normalizeSplitName = normalizeFullName.Split(' ');

            var middleNameList = normalizeSplitName.Skip(1).Take(normalizeSplitName.Length - (surnameNumber + 1)).ToList();

            middleNameList.ForEach(t => middleNames += t + (middleNameList[middleNameList.Count - 1].Equals(t) ? "" : " "));

            var surNameList = normalizeSplitName.Reverse().Take(surnameNumber).Reverse().ToList();

            surNameList.ForEach(t => surName += t + (surNameList[surNameList.Count - 1].Equals(t) ? "" : " "));

            firstName = normalizeSplitName[0];

            return new { NormalizeFullName = normalizeFullName, Firsname = firstName, SurName = surName, MiddleNames = middleNames };
        }
    }
}
