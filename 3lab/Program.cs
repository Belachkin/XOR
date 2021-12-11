
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _3lab
{
    class Program
    {

        public static byte[] XOR(byte[] msg, string key)
        {
            byte[] result = new byte[msg.Length];
            char[] keyArr = key.ToCharArray();
            for (int i = 0; i < msg.Length; i++)
            {
                result[i] = (byte)(msg[i] ^ keyArr[i % keyArr.Length]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            for(; ; )
            {
                try
                {
                    WriteLine("Введите полный путь к файлу с сообщением");
                    String inputPath = ReadLine();

                    WriteLine("Введите ключ");
                    String key = ReadLine();

                    WriteLine("Введите полный путь куда сохранить фаил (D:\\Result.txt)");
                    String outputPath = ReadLine();

                    byte[] msg = File.ReadAllBytes(inputPath);
                    byte[] result = XOR(msg, key);
                    File.WriteAllBytes(outputPath, result);

                    WriteLine("Успешно {0}! \nДанные вписаны в {1}", inputPath, outputPath);

                    WriteLine("\n\n\n\n\nНажмите любую кнопку..");
                    ReadKey();

                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
            }            
        }
    }
}
