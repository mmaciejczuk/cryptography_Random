using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zjazd2
{
    class Zadanie_3
    {
        public string encipher(string key, string plainText)
        {
            char[] encipher = new char[plainText.Length];
            int keyLength = 0;
            int k = 0;                                       //licznik do tablicy encipher
            int m = 0;

            for (int i = 0; i < plainText.Length; i++)       //przejdź po tekście
            {
                for (int j = 0; j < 26; j++)                 //j - przesunięcie
                {
                    if (plainText[i] == (char)(j + 65))      //jeżeli litera w tekście = literze alfabetu (wykorzystaj j)
                    {
                        if (keyLength < key.Length)          //(i + 1) aby nie było 0 na pierwszej pozycji
                        {
                            if (((int)(key[(keyLength++)] + j) <= (int)('Z')))
                            {
                                encipher[k++] = (char)((int)(key[i - m] + j));
                                j = 26;
                            }
                            else                            //wyzerować alfabet
                            {
                                encipher[k++] = (char)((int)(key[i - m] + j) - 26);
                                j = 26;
                            }
                        }
                        else                                //wyzerować key i zacząć od początku
                        {
                            keyLength -= key.Length;
                            m += key.Length;
                            j--;
                        }                        
                    }
                }
            }
            string wynik = new string(encipher);
            return wynik;
        }

        public string decipher(string key, string encipher)
        {
            char[] decipher = new char[encipher.Length];
            int temp = 0;
            int k = 0;                                      //licznik po tablicy decipher                                     
            int m = 0;
            int keyLength = 0;

            for (int i = 0; i < encipher.Length; i++)   //przejdź po tekście
            {
                for (int j = 0; j < 26; j++)            //j - opóźnienie (która litera alfabetu)
                {
                    if (encipher[i] == (char)(j + 65))  //jeżeli litera występuje w tekście... 
                    {
                        if (keyLength < key.Length)
                        {
                            if ((int)encipher[i] - key[keyLength++] >= 0)    //jeśli zabraknie alfabetu, odejmuj od A
                            {
                                decipher[k++] = (char)((int)'A' + ((int)encipher[i] - key[i - m]));
                                j = 26;
                            }
                            else
                            {
                                temp = (int)(key[i - m] - 1 - encipher[i]);
                                decipher[k++] = (char)('Z' - temp);
                                j = 26;
                            }
                        }
                        else
                        {
                            keyLength -= key.Length;
                            m += key.Length;
                            j--;
                        }
                    }
                }
            }
            string wynik = new string(decipher);
            return wynik;
        }
    }
}
