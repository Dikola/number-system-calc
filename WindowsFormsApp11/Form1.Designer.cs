namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainField = new System.Windows.Forms.TextBox();
            this.resultField = new System.Windows.Forms.TextBox();
            this.systemSelector1 = new System.Windows.Forms.ComboBox();
            this.systemSelector2 = new System.Windows.Forms.ComboBox();
            this.systemChanger = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.logTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveLog = new System.Windows.Forms.Button();
            this.logLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainField
            // 
            this.mainField.Location = new System.Drawing.Point(38, 30);
            this.mainField.Multiline = true;
            this.mainField.Name = "mainField";
            this.mainField.Size = new System.Drawing.Size(234, 60);
            this.mainField.TabIndex = 0;
            this.mainField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainField_KeyPress);
            // 
            // resultField
            // 
            this.resultField.Location = new System.Drawing.Point(38, 147);
            this.resultField.Multiline = true;
            this.resultField.Name = "resultField";
            this.resultField.ReadOnly = true;
            this.resultField.Size = new System.Drawing.Size(234, 60);
            this.resultField.TabIndex = 1;
            // 
            // systemSelector1
            // 
            this.systemSelector1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemSelector1.FormattingEnabled = true;
            this.systemSelector1.Location = new System.Drawing.Point(278, 48);
            this.systemSelector1.Name = "systemSelector1";
            this.systemSelector1.Size = new System.Drawing.Size(62, 24);
            this.systemSelector1.TabIndex = 2;
            // 
            // systemSelector2
            // 
            this.systemSelector2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemSelector2.FormattingEnabled = true;
            this.systemSelector2.Location = new System.Drawing.Point(278, 167);
            this.systemSelector2.Name = "systemSelector2";
            this.systemSelector2.Size = new System.Drawing.Size(62, 24);
            this.systemSelector2.TabIndex = 3;
            // 
            // systemChanger
            // 
            this.systemChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.systemChanger.Location = new System.Drawing.Point(278, 99);
            this.systemChanger.Name = "systemChanger";
            this.systemChanger.Size = new System.Drawing.Size(62, 41);
            this.systemChanger.TabIndex = 4;
            this.systemChanger.Text = "⇑⇓";
            this.systemChanger.UseVisualStyleBackColor = true;
            this.systemChanger.Click += new System.EventHandler(this.SystemChanger_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(38, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(98, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(158, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(38, 376);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(54, 41);
            this.button0.TabIndex = 8;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(38, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(98, 282);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 41);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(158, 282);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 41);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(38, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 41);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(98, 235);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 41);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(158, 235);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(54, 41);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // buttonA
            // 
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonA.Location = new System.Drawing.Point(98, 376);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(54, 41);
            this.buttonA.TabIndex = 15;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.ButtonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonB.Location = new System.Drawing.Point(158, 376);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(54, 41);
            this.buttonB.TabIndex = 16;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.ButtonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonC.Location = new System.Drawing.Point(218, 376);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(54, 41);
            this.buttonC.TabIndex = 17;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonD.Location = new System.Drawing.Point(218, 329);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(54, 41);
            this.buttonD.TabIndex = 18;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.ButtonD_Click);
            // 
            // buttonE
            // 
            this.buttonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonE.Location = new System.Drawing.Point(218, 282);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(54, 41);
            this.buttonE.TabIndex = 19;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.ButtonE_Click);
            // 
            // buttonF
            // 
            this.buttonF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonF.Location = new System.Drawing.Point(218, 235);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(54, 41);
            this.buttonF.TabIndex = 20;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.ButtonF_Click);
            // 
            // buttonX
            // 
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonX.Location = new System.Drawing.Point(278, 235);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(54, 41);
            this.buttonX.TabIndex = 21;
            this.buttonX.Text = "x";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.ButtonX_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(278, 282);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(54, 41);
            this.buttonDel.TabIndex = 22;
            this.buttonDel.Text = "<-";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDot.Location = new System.Drawing.Point(278, 329);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(54, 41);
            this.buttonDot.TabIndex = 23;
            this.buttonDot.Text = ",";
            this.buttonDot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(278, 376);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(54, 41);
            this.buttonResult.TabIndex = 24;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // logTable
            // 
            this.logTable.Location = new System.Drawing.Point(371, 59);
            this.logTable.Multiline = true;
            this.logTable.Name = "logTable";
            this.logTable.ReadOnly = true;
            this.logTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTable.Size = new System.Drawing.Size(417, 311);
            this.logTable.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(485, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "История вычислений";
            // 
            // saveLog
            // 
            this.saveLog.Location = new System.Drawing.Point(433, 376);
            this.saveLog.Name = "saveLog";
            this.saveLog.Size = new System.Drawing.Size(125, 48);
            this.saveLog.TabIndex = 27;
            this.saveLog.Text = "Сохранить данные";
            this.saveLog.UseVisualStyleBackColor = true;
            this.saveLog.Click += new System.EventHandler(this.SaveLog_Click);
            // 
            // logLoad
            // 
            this.logLoad.Location = new System.Drawing.Point(603, 378);
            this.logLoad.Name = "logLoad";
            this.logLoad.Size = new System.Drawing.Size(125, 48);
            this.logLoad.TabIndex = 28;
            this.logLoad.Text = "Загрузить данные";
            this.logLoad.UseVisualStyleBackColor = true;
            this.logLoad.Click += new System.EventHandler(this.LogLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.logLoad);
            this.Controls.Add(this.saveLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logTable);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.systemChanger);
            this.Controls.Add(this.systemSelector2);
            this.Controls.Add(this.systemSelector1);
            this.Controls.Add(this.resultField);
            this.Controls.Add(this.mainField);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainField;
        private System.Windows.Forms.TextBox resultField;
        private System.Windows.Forms.ComboBox systemSelector1;
        private System.Windows.Forms.ComboBox systemSelector2;
        private System.Windows.Forms.Button systemChanger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox logTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveLog;
        private System.Windows.Forms.Button logLoad;
    }
}

