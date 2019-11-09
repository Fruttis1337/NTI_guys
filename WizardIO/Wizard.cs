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

        public static void ReadFromText(ref string[] variable)
        {
            variable = File.ReadAllLines(inputPath);

        }
        public static void ReadFromText(ref int[] variable)
        {
            string[] smthstr;
            smthstr = File.ReadAllLines(inputPath);
            variable = new int[smthstr.Length];
            for (int i = 0; i < smthstr.Length; i++)
            {
                variable[i] = Convert.ToInt32(smthstr[i]);
            }
        }
        public static void ReadFromText(ref float[] variable)
        {
            string[] smth;
            smth = File.ReadAllLines(inputPath);
            variable = new float[smth.Length];
            for (int i = 0; i < smth.Length; i++)
            {
                variable[i] = Convert.ToSingle(smth[i]);
            }
        }

        public static void ReadFromText(ref string variable)
        {
             variable = File.ReadAllLines(inputPath).Skip(0).First();
        }
        public static void ReadFromText(ref int variable)
        {
             variable = Convert.ToInt32(File.ReadAllLines(inputPath).Skip(0).First());
        }
        public static void ReadFromText(ref float variable)
        {
             variable = Convert.ToSingle(File.ReadAllLines(inputPath).Skip(0).First());
        }

        public static void ReadFromText(ref string variable, int n)
        {
            variable = File.ReadAllLines(inputPath).Skip(n).First();
        }
        public static void ReadFromText(ref int variable, int n)
        {
            variable = Convert.ToInt32(File.ReadAllLines(inputPath).Skip(n).First());
        }
        public static void ReadFromText(ref float variable, int n)
        {
            variable = Convert.ToSingle(File.ReadAllLines(inputPath).Skip(n).First());
        }

        public static void WriteToText(string content)
        {

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