using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3A
{
    static class Rot13
    {
        public static string Cypher(string value)
        {
            char[] array = value.ToCharArray();
            for(int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];
                if(number >= 'a' && number <= 'z')
                {
                    if(number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if(number >= 'A' && number <= 'Z')
                {
                    if(number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }
    }
}
