using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tokb1
{
    class Class1
    {
        public static string Key;
        public static string Pas;
        public static int PopytkaNum = 2;
        public static bool Flag = false;
        const string File = "\\qwerty.txt";

        char[] characters = new char[] { 'A', 'B', 'C', 'D', 'I', 'F', 'G', 'H', 'I', 'J','K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
                                         'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        public string GenKey()
        {
            Random rand = new Random();
            string Key = "";
            for (int i = 0; i < 5; i++)
                Key += characters[rand.Next(0, 36)];
            return Key;
        }

        public string Encode(string input, string key)
        {
            input = input.ToUpper();
            key = key.ToUpper();
            string EncodeWord = "";
            int keyIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int c = (Array.IndexOf(characters, input[i]) + Array.IndexOf(characters, key[keyIndex])) % characters.Length;
                EncodeWord = EncodeWord + characters[c];
                keyIndex++;
                if ((keyIndex + 1) == key.Length)
                    keyIndex = 0;
            }
            return EncodeWord;
        }

        public void WriteInFile(string EncodePas)
        {
            FileStream file = new FileStream(File, FileMode.Create);
            StreamWriter Writer = new StreamWriter(file);
            Writer.WriteLine("{0}", EncodePas);
            Writer.Close();
        }

        public string ReadFromFile()
        {
            String[] temp;
            FileStream file = new FileStream(File, FileMode.Open);
            StreamReader Reader = new StreamReader(file);
            temp = Reader.ReadLine().Split(' ');
            Reader.Close();
            return temp[0];
        }
    }
}
