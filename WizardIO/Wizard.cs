using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.IO;

namespace WizardIO
{
    public class Wizard
    {
        static string inputPath;
        static string outputPath;

        public static void SetInputPath(string input)
        {
            inputPath = input;
        }
        public static void SetOutputPath(string output)
        {
            outputPath = output;
        }
        // Функция считывает массив строк с файла
        public static string[] ReadStringArrayFromText()
        {
            string[] smth;
            //Чтение массива с файла
            return smth = File.ReadAllLines(inputPath);

        }
        // Фунция считывает массив целых чисел с файла, комментарии с предыдущей функции соответствуют и для этой
        public static int[] ReadIntArrayFromText()
        {
            string[] smth;
            smth = File.ReadAllLines(inputPath);
            int[] smthint = new int[smth.Length];
            // Преобразование из строки в целое число
            for (int i = 0; i < smth.Length; i++)
            {
                smthint[i] = Convert.ToInt32(smth[i]);
            }
            return smthint;
        }
        // Фунция считывает массив дробных чисел с файла, комментарии с преыдущей функции соответствуют и для этой
        public static float[] ReadFloatArrayFromText()
        {
            string[] smth;
            smth = File.ReadAllLines(inputPath);
            float[] smthfloat = new float[smth.Length];
            // Преобразование из строки в дробное число
            for (int i = 0; i < smth.Length; i++)
            {
                smthfloat[i] = Convert.ToSingle(smth[i]);
            }
            return smthfloat;
        }

        // Фунция считывает первую строку с файла в string, комментарии с прошлой функции соответствуют и для этой
        public static string ReadStringFromText()
        {
            string smth;
            //Чтение 1 строки под номером 0
            return smth = File.ReadAllLines(inputPath).Skip(0).First();
        }
        // Фунция считывает первую строку с файла в int, комментарии с прошлой функции соответствуют и для этой
        public static int ReadIntFromText()
        {
            int smth;
            return smth = Convert.ToInt32(File.ReadAllLines(inputPath).Skip(0).First());
        }
        // Фунция считывает первую строку с файла в float, комментарии с прошлой функции соответствуют и для этой
        public static float ReadFloatFromText()
        {
            float smth;
            return smth = Convert.ToSingle(File.ReadAllLines(inputPath).Skip(0).First());
        }

        // Фунция считывает n-ую строку с файла в string, комментарии с прошлой функции соответствуют и для этой
        public static string ReadStringFromText(int n)
        {
            string smth;
            return smth = File.ReadAllLines(inputPath).Skip(n).First();

        }
        // Фунция считывает n-ую строку с файла в int, комментарии с прошлой функции соответствуют и для этой
        public static int ReadIntFromText(int n)
        {
            int smth;
            return smth = Convert.ToInt32(File.ReadAllLines(inputPath).Skip(n).First());
        }
        // Фунция считывает n-ую строку с файла в float, комментарии с прошлой функции соответствуют и для этой
        public static float ReadFloatFromText(int n)
        {
            float smth;
            return smth = Convert.ToSingle(File.ReadAllLines(inputPath).Skip(n).First());
        }

        // Вывод в файл
        public static void WriteToText(string content)
        {
            // Если файл не существуе, что создаётся новый
            if (!File.Exists(outputPath))
            {
                File.WriteAllText(outputPath, content);
            }
            else
            {
                File.AppendAllText(outputPath, content);
            }
        }
        public static void WriteToText(int content)
        {
            if (!File.Exists(outputPath))
            {
                File.WriteAllText(outputPath, Convert.ToString(content));
            }
            else
            {
                File.AppendAllText(outputPath, Convert.ToString(content));
            }
        }
        public static void WriteToText(float content)
        {
            if (!File.Exists(outputPath))
            {
                File.WriteAllText(outputPath, Convert.ToString(content));
            }
            else
            {
                File.AppendAllText(outputPath, Convert.ToString(content));
            }
        }

        public static void CleanOutput()
        {
            File.WriteAllText(outputPath, String.Empty);
        }
    }
}