using System.Text;

namespace PersonApi.Services
{
    public class StringManipulationService
    {
        public string RemoveDuplicateChars(string str)
        {

            //return str.Distinct().ToArray();
            //str = str.ToLower();

            StringBuilder result = new StringBuilder();

            //iteratate through the string
            foreach (char c in str)
            {
                if (result.ToString().IndexOf(c, StringComparison.OrdinalIgnoreCase) == -1)
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        public Array RemoveDuplicateCharReturnArray(string str)
        {
            str = str.ToLower();

            return str.Distinct().ToArray();

        }

        public bool CheckAnagram(string strA, string strB)
        {
            //convert strings to character arrays
            var arrA = strA.ToLower().ToArray();

            var arrB = strB.ToLower().ToArray();

            //sort arrays
            Array.Sort(arrA);

            Array.Sort(arrB);

            //Compare arrays
            return arrA.SequenceEqual(arrB);

        }

        public string ReverseStringIterative(string str)
        {
            //create a stringbuilder to store the reversed string
            StringBuilder reversedString = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i++)
            {
                reversedString.Append(str[i]);
            }

            return reversedString.ToString();

        }

        public int CountWords(string str)
        {
            var count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsWhiteSpace(str[i]))
                {
                    count++;
                }
            }

            return count + 1;
        }


    }
}
