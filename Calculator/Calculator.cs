using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Presenter P;

        public Calculator()
        {
            InitializeComponent();

            P = new Presenter();

            Values.Text = "";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[5];

            arrStr = P.Basic(Values.Text, Number.Text, Box1.Text, Box2.Text, 1, 0);

            if (Convert.ToDouble(arrStr[4]) == 0) {
                Values.Text = arrStr[0];
                Number.Text = arrStr[1];
                Box1.Text = arrStr[2];
                Box2.Text = arrStr[3];
            }
            else MessageBox.Show("Недопустимое число!");
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[5];

            arrStr = P.Basic(Values.Text, Number.Text, Box1.Text, Box2.Text, 2, 0);

            if (Convert.ToDouble(arrStr[4]) == 0)
            {
                Values.Text = arrStr[0];
                Number.Text = arrStr[1];
                Box1.Text = arrStr[2];
                Box2.Text = arrStr[3];
            }
            else MessageBox.Show("Недопустимое число!");
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[5];

            arrStr = P.Basic(Values.Text, Number.Text, Box1.Text, Box2.Text, 3, 0);

            if (Convert.ToDouble(arrStr[4]) == 0)
            {
                Values.Text = arrStr[0];
                Number.Text = arrStr[1];
                Box1.Text = arrStr[2];
                Box2.Text = arrStr[3];
            }
            else MessageBox.Show("Недопустимое число!");
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[5];

            arrStr = P.Basic(Values.Text, Number.Text, Box1.Text, Box2.Text, 4, 0);

            if (Convert.ToDouble(arrStr[4]) == 0)
            {
                Values.Text = arrStr[0];
                Number.Text = arrStr[1];
                Box1.Text = arrStr[2];
                Box2.Text = arrStr[3];
            }
            else MessageBox.Show("Недопустимое число!");
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[5];

            arrStr = P.Basic(Values.Text, Number.Text, Box1.Text, Box2.Text, 5, 0);

            if (Convert.ToDouble(arrStr[4]) == 0)
            {
                Values.Text = arrStr[0];
                Number.Text = arrStr[1];
                Box1.Text = arrStr[2];
                Box2.Text = arrStr[3];
            }
            else MessageBox.Show("Недопустимое число!");
        }

        private void buttonRt_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[5];

            arrStr = P.Basic(Values.Text, Number.Text, Box1.Text, Box2.Text, 6, 0);

            if (Convert.ToDouble(arrStr[4]) == 0)
            {
                Values.Text = arrStr[0];
                Number.Text = arrStr[1];
                Box1.Text = arrStr[2];
                Box2.Text = arrStr[3];
            }
            else MessageBox.Show("Недопустимое число!");
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[5];

            arrStr = P.Basic(Values.Text, Number.Text, Box1.Text, Box2.Text, 7, 0);

            if (Convert.ToDouble(arrStr[4]) == 0)
            {
                Values.Text = arrStr[0];
                Number.Text = arrStr[1];
                Box1.Text = arrStr[2];
                Box2.Text = arrStr[3];
            }
            else MessageBox.Show("Недопустимое число!");
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[5];

            arrStr = P.Basic(Values.Text, Number.Text, Box1.Text, Box2.Text, 8, 0);

            if (Convert.ToDouble(arrStr[4]) == 0)
            {
                Values.Text = arrStr[0];
                Number.Text = arrStr[1];
                Box1.Text = arrStr[2];
                Box2.Text = arrStr[3];
            }
            else MessageBox.Show("Недопустимое число!");
        }

        private void buttonMedian_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[5];

            arrStr = P.Basic(Values.Text, Number.Text, Box1.Text, Box2.Text, 9, 0);

            if (Convert.ToDouble(arrStr[4]) == 0)
            {
                Values.Text = arrStr[0];
                Number.Text = arrStr[1];
                Box1.Text = arrStr[2];
                Box2.Text = arrStr[3];
            }
            else MessageBox.Show("Недопустимое число!");
        }

        private void buttonDeviation_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[5];

            arrStr = P.Basic(Values.Text, Number.Text, Box1.Text, Box2.Text, 10, 0);

            if (Convert.ToDouble(arrStr[4]) == 0)
            {
                Values.Text = arrStr[0];
                Number.Text = arrStr[1];
                Box1.Text = arrStr[2];
                Box2.Text = arrStr[3];
            }
            else MessageBox.Show("Недопустимое число!");
        }

        private void buttonRepeat_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[5];

            arrStr = P.Basic(Values.Text, Number.Text, Box1.Text, Box2.Text, 11, 0);

            if (Convert.ToDouble(arrStr[4]) == 0)
            {
                Values.Text = arrStr[0];
                Number.Text = arrStr[1];
                Box1.Text = arrStr[2];
                Box2.Text = arrStr[3];
            }
            else MessageBox.Show("Недопустимое число!");
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[3];

            arrStr = P.Undo(Values.Text, Number.Text, Box1.Text);

            Values.Text = arrStr[0];
            Number.Text = arrStr[1];
            Box1.Text = arrStr[2];
        }

        private void buttonStatusBar_Click(object sender, EventArgs e)
        {
            string[] arrStr = new string[2];

            arrStr = P.StatusBar(Values.Text, Number.Text, Box1.Text, Box2.Text);

            Values.Text = arrStr[0];
            Number.Text = arrStr[1];
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Values.Clear();

                string name = openFileDialog1.FileName;

                Values.Text = P.Import(name);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string valF = Values.Text;

                string name = saveFileDialog1.FileName;

                P.Export(name, valF);
            }
        }
    }
}