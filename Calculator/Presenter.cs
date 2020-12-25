using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calculator
{
    public class Presenter
    {
        Model M;

        public Presenter()
        {
            M = new Model();
        }

        private string[] arrVal = new string[1];
        private string[] arrNum = new string[1];
        private int[] arrKey = new int[1];

        private void AdditionStory(string values, string number, int k)
        {
            Array.Resize(ref arrVal, arrVal.Length + 1);
            arrVal[arrVal.Length - 1] = values;

            Array.Resize(ref arrNum, arrNum.Length + 1);
            arrNum[arrNum.Length - 1] = number;

            Array.Resize(ref arrKey, arrKey.Length + 1);
            arrKey[arrKey.Length - 1] = k;
        }

        private void RedactionStory(int box1Doubl, int box2Doubl)
        {
            int i = 0;
            while (i < box2Doubl - box1Doubl)
            {
                Array.Resize(ref arrVal, arrVal.Length - 1);
                Array.Resize(ref arrNum, arrNum.Length - 1);
                Array.Resize(ref arrKey, arrKey.Length - 1);
                i++;
            }
        }

        private string CorrectString(string str)
        {
            if (str == "")
                str = "0";

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Contains("."))
                {
                    str = str.Replace(".", ",");
                    --i;
                    continue;
                }

                if ((str[i] == ' ') && (str[i + 1] == ' '))
                {
                    str = str.Remove(i, 1);
                    --i;
                    continue;
                }
            }

            while (str[0] == ' ')
            {
                str = str.Remove(0, 1);
            }

            return str;
        }

        public string[] Basic(string values, string number, string box1, string box2, int k, int t)
        {
            values = CorrectString(values);
            number = CorrectString(number);
            box1 = CorrectString(box1);
            box2 = CorrectString(box2);

            if (arrVal.Length == 1)
            {
                arrVal[arrVal.Length - 1] = values;
                arrNum[arrNum.Length - 1] = number;
                arrKey[arrKey.Length - 1] = k;
            }

            double numDoubl = Convert.ToDouble(number);
            double box1Doubl = Convert.ToDouble(box1);
            double box2Doubl = Convert.ToDouble(box2);

            string[] valStr = new string[1];

            valStr = values.Split(' ');

            double[] valDoubl = new double[valStr.Length];

            for (int i = 0; i < valStr.Length; i++)
            {
                valDoubl[i] = Convert.ToDouble(valStr[i]);
            }

            int story = 0;

            if (k == 11)
                k = arrKey[(int)box1Doubl];

            switch (k)
            {
                case 1:
                    valDoubl = M.Sum(valDoubl, numDoubl);
                    break;
                case 2:
                    valDoubl = M.Subtraction(valDoubl, numDoubl);
                    break;
                case 3:
                    valDoubl = M.Multiplication(valDoubl, numDoubl);
                    break;
                case 4:
                    if (numDoubl != 0.0)
                        valDoubl = M.Division(valDoubl, numDoubl);
                    else
                        story = 1;
                    break;
                case 5:
                    valDoubl = M.Pow(valDoubl, numDoubl);
                    break;
                case 6:
                    if (numDoubl != 0.0)
                        valDoubl = M.Rt(valDoubl, numDoubl);
                    else
                        story = 1;
                    break;
                case 7:
                    if ((numDoubl > 0.0) && (numDoubl != 1))
                        valDoubl = M.Log(valDoubl, numDoubl);
                    else
                        story = 1;
                    break;
                case 8:
                    valDoubl = M.Factorial(valDoubl);
                    break;
                case 9:
                    numDoubl = M.Median(valDoubl);
                    break;
                case 10:
                    numDoubl = M.Deviation(valDoubl);
                    break;
                default:
                    break;
            }

            for (int i = 0; i < valStr.Length; i++)
            {
                valStr[i] = Convert.ToString(valDoubl[i]);
            }

            values = String.Join(" ", valStr);
            number = Convert.ToString(numDoubl);

            if (story == 0)
            {
                RedactionStory((int)box1Doubl, (int)box2Doubl);
                AdditionStory(values, number, k);
                box2Doubl = ++box1Doubl;
            }
            else t = 1;

            string[] arrayStr = new string[5];

            arrayStr[0] = values;
            arrayStr[1] = number;
            arrayStr[2] = Convert.ToString(box1Doubl);
            arrayStr[3] = Convert.ToString(box2Doubl);
            arrayStr[4] = Convert.ToString(t);

            return arrayStr;
        }

        public string[] Undo(string values, string number, string box1)
        {
            values = CorrectString(values);
            number = CorrectString(number);
            box1 = CorrectString(box1);

            double box1Doubl = Convert.ToDouble(box1);

            if (box1Doubl != 0)
            {
                --box1Doubl;
                values = arrVal[(int)box1Doubl];
                number = arrNum[(int)box1Doubl];
            }

            string[] arrayStr = new string[3];

            arrayStr[0] = values;
            arrayStr[1] = number;
            arrayStr[2] = Convert.ToString(box1Doubl);

            return arrayStr;
        }

        public string[] StatusBar(string values, string number, string box1, string box2)
        {
            values = CorrectString(values);
            number = CorrectString(number);
            box1 = CorrectString(box1);
            box2 = CorrectString(box2);

            double box1Doubl = Convert.ToDouble(box1);
            double box2Doubl = Convert.ToDouble(box2);

            if (box1Doubl >= 0 && box1Doubl <= box2Doubl && box1Doubl == (int)box1Doubl)
            {
                values = arrVal[(int)box1Doubl];
                number = arrNum[(int)box1Doubl];
            }

            string[] arrayStr = new string[2];

            arrayStr[0] = values;
            arrayStr[1] = number;

            return arrayStr;
        }

        public string Import(string name)
        {
            string valF = File.ReadAllText(name);

            valF = CorrectString(valF);

            return valF;
        }

        public void Export(string name, string valF)
        {
            valF = CorrectString(valF);

            File.WriteAllText(name, valF);
        }
    }
}