using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zjazd2
{
    class Zadanie_2
    {
        public string encipher(string key_1, string key_2, string plainText)
        {
            char[] encipher = new char[plainText.Length];
            int key1 = Convert.ToInt32(key_1);
            int key2 = Convert.ToInt32(key_2);
            int k = 0;

            for (int i = 0; i < plainText.Length; i++)
            {
                for (int j = 65; j < 91; j++)
                {
                    if (plainText[i] == (char)j)
                    {
                        //if ((char)j * key1 + key2 <= 'Z')
                        //{
                            encipher[k++] = (char)((j * key1 + key2) % 26);
                            j = 91;
                        //}
                        //else
                        //{
                        //    if ((j * key1 + key2) % 26 == 0)
                        //    {
                        //        encipher[k++] = (char)((int)'A' + (j * key1 + key2) - (int)'Z' - j);
                        //        j = 91;
                        //    }
                        //    else
                        //    {
                                
                        //    }
                        //}
                    }
                }
            }
            string wynik = new string(encipher);
            return wynik;
        }
    }
}
