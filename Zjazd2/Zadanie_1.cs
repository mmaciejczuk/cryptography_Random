using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Zjazd2
{
    class Zadanie_1
    {

        public string encipher(string key, string plainText)
        {
            char[] klucz = new char[26];
            char[] alfabet = new char[26];
            char[] encipher = new char[plainText.Length];
            bool repeat = false;
            int l = 0;

            for (int i = 0; i < 26; i++)    //wypełnij alfabet
            {
                alfabet[i] = (char)(i + 65);
            }

            for (int i = 0; i < 26; i++)    //wypełnij klucz do 26
            {
                if (i < key.Length)         //wypełnij key
                {
                    klucz[i] = key[i];
                }
            }
            for (int i = 0; i < 26; i++)                //czy po alfabecie na początku??????
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (alfabet[i] == key[j])
                    {
                        repeat = true;
                        j = key.Length;   //zakończ pętlę jeśli się powtórzy  
                    }
                    else
                    {
                        repeat = false;
                    }
                }
                if (!repeat && key.Length + l < klucz.Length)
                {
                    klucz[key.Length + l] = alfabet[i];
                    l++;
                }
            }
            

            for (int i = 0; i < plainText.Length; i++)
            {
                for (int j = 0; j < alfabet.Length; j++)
                {
                    if (plainText[i] == alfabet[j])
                    {
                        encipher[i] = klucz[j];
                    }
                }
            }
            string wynik = new string(encipher);
            return wynik;

        }

        public string decipher(string key, string encipherText)
        {
            char[] klucz = new char[26];
            char[] alfabet = new char[26];
            char[] decipher = new char[encipherText.Length];
            bool repeat = false;
            int l = 0;

            for (int i = 0; i < 26; i++)    //wypełnij alfabet
            {
                alfabet[i] = (char)(i + 65);
            }

            for (int i = 0; i < 26; i++)    //wypełnij klucz do 26
            {
                if (i < key.Length)         //wypełnij key
                {
                    klucz[i] = key[i];
                }
            }
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (alfabet[i] == key[j])
                    {
                        repeat = true;
                        j = key.Length;   //zakończ pętlę jeśli się powtórzy  
                    }
                    else
                    {
                        repeat = false;
                    }
                }
                if (!repeat && key.Length + l < klucz.Length)
                {
                    klucz[key.Length + l] = alfabet[i];
                    l++;
                }
            }

            for (int i = 0; i < encipherText.Length; i++)
            {
                for (int j = 0; j < klucz.Length; j++)
                {
                    if (encipherText[i] == klucz[j])
                        decipher[i] = alfabet[j]; 
                }
            }

            string wynik = new string(decipher);
            return wynik;
        }

    }
}
