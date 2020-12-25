namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonRepeat = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStatusBar = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonDeviation = new System.Windows.Forms.Button();
            this.buttonMedian = new System.Windows.Forms.Button();
            this.buttonFactorial = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonRt = new System.Windows.Forms.Button();
            this.buttonPow = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonSubtraction = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.Values = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.buttonExport);
            this.panel1.Controls.Add(this.buttonRepeat);
            this.panel1.Controls.Add(this.buttonUndo);
            this.panel1.Controls.Add(this.Box2);
            this.panel1.Controls.Add(this.Box1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonStatusBar);
            this.panel1.Controls.Add(this.buttonImport);
            this.panel1.Controls.Add(this.buttonDeviation);
            this.panel1.Controls.Add(this.buttonMedian);
            this.panel1.Controls.Add(this.buttonFactorial);
            this.panel1.Controls.Add(this.buttonLog);
            this.panel1.Controls.Add(this.buttonRt);
            this.panel1.Controls.Add(this.buttonPow);
            this.panel1.Controls.Add(this.buttonDivision);
            this.panel1.Controls.Add(this.buttonMultiplication);
            this.panel1.Controls.Add(this.buttonSubtraction);
            this.panel1.Controls.Add(this.buttonSum);
            this.panel1.Controls.Add(this.Number);
            this.panel1.Controls.Add(this.Values);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 325);
            this.panel1.TabIndex = 0;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.Black;
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonExport.ForeColor = System.Drawing.Color.White;
            this.buttonExport.Location = new System.Drawing.Point(337, 213);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(157, 46);
            this.buttonExport.TabIndex = 23;
            this.buttonExport.Text = "export";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.BackColor = System.Drawing.Color.Black;
            this.buttonRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRepeat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRepeat.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonRepeat.ForeColor = System.Drawing.Color.White;
            this.buttonRepeat.Location = new System.Drawing.Point(175, 213);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(157, 46);
            this.buttonRepeat.TabIndex = 22;
            this.buttonRepeat.Text = "repeat";
            this.buttonRepeat.UseVisualStyleBackColor = false;
            this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.BackColor = System.Drawing.Color.Black;
            this.buttonUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUndo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUndo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonUndo.ForeColor = System.Drawing.Color.White;
            this.buttonUndo.Location = new System.Drawing.Point(12, 213);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(157, 46);
            this.buttonUndo.TabIndex = 21;
            this.buttonUndo.Text = "undo";
            this.buttonUndo.UseVisualStyleBackColor = false;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // Box2
            // 
            this.Box2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box2.Location = new System.Drawing.Point(400, 274);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(94, 39);
            this.Box2.TabIndex = 20;
            this.Box2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Box1
            // 
            this.Box1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box1.Location = new System.Drawing.Point(256, 274);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(95, 39);
            this.Box1.TabIndex = 19;
            this.Box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(357, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "of";
            // 
            // buttonStatusBar
            // 
            this.buttonStatusBar.BackColor = System.Drawing.Color.Black;
            this.buttonStatusBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStatusBar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStatusBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatusBar.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonStatusBar.ForeColor = System.Drawing.Color.White;
            this.buttonStatusBar.Location = new System.Drawing.Point(12, 269);
            this.buttonStatusBar.Name = "buttonStatusBar";
            this.buttonStatusBar.Size = new System.Drawing.Size(238, 46);
            this.buttonStatusBar.TabIndex = 16;
            this.buttonStatusBar.Text = "StatusBar";
            this.buttonStatusBar.UseVisualStyleBackColor = false;
            this.buttonStatusBar.Click += new System.EventHandler(this.buttonStatusBar_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.Black;
            this.buttonImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonImport.ForeColor = System.Drawing.Color.White;
            this.buttonImport.Location = new System.Drawing.Point(337, 161);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(157, 46);
            this.buttonImport.TabIndex = 15;
            this.buttonImport.Text = "import";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonDeviation
            // 
            this.buttonDeviation.BackColor = System.Drawing.Color.Black;
            this.buttonDeviation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeviation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDeviation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeviation.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonDeviation.ForeColor = System.Drawing.Color.White;
            this.buttonDeviation.Location = new System.Drawing.Point(175, 161);
            this.buttonDeviation.Name = "buttonDeviation";
            this.buttonDeviation.Size = new System.Drawing.Size(157, 46);
            this.buttonDeviation.TabIndex = 14;
            this.buttonDeviation.Text = "deviation";
            this.buttonDeviation.UseVisualStyleBackColor = false;
            this.buttonDeviation.Click += new System.EventHandler(this.buttonDeviation_Click);
            // 
            // buttonMedian
            // 
            this.buttonMedian.BackColor = System.Drawing.Color.Black;
            this.buttonMedian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMedian.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMedian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedian.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonMedian.ForeColor = System.Drawing.Color.White;
            this.buttonMedian.Location = new System.Drawing.Point(12, 161);
            this.buttonMedian.Name = "buttonMedian";
            this.buttonMedian.Size = new System.Drawing.Size(157, 46);
            this.buttonMedian.TabIndex = 13;
            this.buttonMedian.Text = "median";
            this.buttonMedian.UseVisualStyleBackColor = false;
            this.buttonMedian.Click += new System.EventHandler(this.buttonMedian_Click);
            // 
            // buttonFactorial
            // 
            this.buttonFactorial.BackColor = System.Drawing.Color.Black;
            this.buttonFactorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFactorial.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFactorial.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonFactorial.ForeColor = System.Drawing.Color.White;
            this.buttonFactorial.Location = new System.Drawing.Point(378, 109);
            this.buttonFactorial.Name = "buttonFactorial";
            this.buttonFactorial.Size = new System.Drawing.Size(116, 46);
            this.buttonFactorial.TabIndex = 12;
            this.buttonFactorial.Text = "!";
            this.buttonFactorial.UseVisualStyleBackColor = false;
            this.buttonFactorial.Click += new System.EventHandler(this.buttonFactorial_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.Black;
            this.buttonLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLog.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonLog.ForeColor = System.Drawing.Color.White;
            this.buttonLog.Location = new System.Drawing.Point(256, 109);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(116, 46);
            this.buttonLog.TabIndex = 11;
            this.buttonLog.Text = "log";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonRt
            // 
            this.buttonRt.BackColor = System.Drawing.Color.Black;
            this.buttonRt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRt.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonRt.ForeColor = System.Drawing.Color.White;
            this.buttonRt.Location = new System.Drawing.Point(134, 109);
            this.buttonRt.Name = "buttonRt";
            this.buttonRt.Size = new System.Drawing.Size(116, 46);
            this.buttonRt.TabIndex = 10;
            this.buttonRt.Text = "√";
            this.buttonRt.UseVisualStyleBackColor = false;
            this.buttonRt.Click += new System.EventHandler(this.buttonRt_Click);
            // 
            // buttonPow
            // 
            this.buttonPow.BackColor = System.Drawing.Color.Black;
            this.buttonPow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPow.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonPow.ForeColor = System.Drawing.Color.White;
            this.buttonPow.Location = new System.Drawing.Point(12, 109);
            this.buttonPow.Name = "buttonPow";
            this.buttonPow.Size = new System.Drawing.Size(116, 46);
            this.buttonPow.TabIndex = 9;
            this.buttonPow.Text = "pow";
            this.buttonPow.UseVisualStyleBackColor = false;
            this.buttonPow.Click += new System.EventHandler(this.buttonPow_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.Color.Black;
            this.buttonDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDivision.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivision.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonDivision.ForeColor = System.Drawing.Color.White;
            this.buttonDivision.Location = new System.Drawing.Point(378, 57);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(116, 46);
            this.buttonDivision.TabIndex = 8;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.Color.Black;
            this.buttonMultiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMultiplication.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplication.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonMultiplication.ForeColor = System.Drawing.Color.White;
            this.buttonMultiplication.Location = new System.Drawing.Point(256, 57);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(116, 46);
            this.buttonMultiplication.TabIndex = 7;
            this.buttonMultiplication.Text = "×";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonSubtraction
            // 
            this.buttonSubtraction.BackColor = System.Drawing.Color.Black;
            this.buttonSubtraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubtraction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtraction.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonSubtraction.ForeColor = System.Drawing.Color.White;
            this.buttonSubtraction.Location = new System.Drawing.Point(134, 57);
            this.buttonSubtraction.Name = "buttonSubtraction";
            this.buttonSubtraction.Size = new System.Drawing.Size(116, 46);
            this.buttonSubtraction.TabIndex = 6;
            this.buttonSubtraction.Text = "–";
            this.buttonSubtraction.UseVisualStyleBackColor = false;
            this.buttonSubtraction.Click += new System.EventHandler(this.buttonSubtraction_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.BackColor = System.Drawing.Color.Black;
            this.buttonSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSum.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSum.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.buttonSum.ForeColor = System.Drawing.Color.White;
            this.buttonSum.Location = new System.Drawing.Point(12, 57);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(116, 46);
            this.buttonSum.TabIndex = 5;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = false;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(439, 12);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(55, 39);
            this.Number.TabIndex = 4;
            this.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Values
            // 
            this.Values.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Values.Location = new System.Drawing.Point(12, 12);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(421, 39);
            this.Values.TabIndex = 3;
            this.Values.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "E:\\dep\\5 семестр\\ТП\\проект\\Calculator";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.InitialDirectory = "E:\\dep\\5 семестр\\ТП\\проект\\Calculator";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 325);
            this.Controls.Add(this.panel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Values;
        private System.Windows.Forms.Button buttonStatusBar;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonDeviation;
        private System.Windows.Forms.Button buttonMedian;
        private System.Windows.Forms.Button buttonFactorial;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonRt;
        private System.Windows.Forms.Button buttonPow;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonSubtraction;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonRepeat;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}