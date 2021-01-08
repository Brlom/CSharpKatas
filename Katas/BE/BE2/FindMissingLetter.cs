using System;
using System.Collections.Generic;
using System.Text;

namespace Katas.BE.BE2
{
    public class FindMissingLetter
    {
        public string FindTheMissingLetter(List<char> charList)
        {
            int ascii = 0;
            bool isUpper = false;

            foreach (char listItem in charList)
            {
                int charAsAscii = (int)listItem;

                if (ascii == 0)
                {
                    ascii = (int)Char.ToLower(listItem);
                    isUpper = CheckIfUpper(charAsAscii);
                }
                else if (ascii != 0 && (int)Char.ToLower(listItem) == ascii + 1)
                {
                    ascii = (int)Char.ToLower(listItem);
                }
                else
                {
                    var missingAscii = Convert.ToChar(ascii + 1);
                    var upperMissing = Char.ToUpper(missingAscii);
                    return isUpper ? Char.ToString(upperMissing) : Char.ToString(missingAscii);
                }
            }

            return string.Empty;
        }

        public bool CheckIfUpper(int listItemVal)
        {
            if (listItemVal <= 90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
