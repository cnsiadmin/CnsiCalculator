namespace CnsiCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_numberInputView = new System.Windows.Forms.TextBox();
            this.btn_numberInput1 = new System.Windows.Forms.Button();
            this.btn_numberInput2 = new System.Windows.Forms.Button();
            this.btn_numberInput3 = new System.Windows.Forms.Button();
            this.btn_numberInput4 = new System.Windows.Forms.Button();
            this.btn_numberInput5 = new System.Windows.Forms.Button();
            this.btn_numberInput6 = new System.Windows.Forms.Button();
            this.btn_numberInput7 = new System.Windows.Forms.Button();
            this.btn_numberInput8 = new System.Windows.Forms.Button();
            this.btn_numberInput9 = new System.Windows.Forms.Button();
            this.btn_bracketLeftInput = new System.Windows.Forms.Button();
            this.btn_numberInput0 = new System.Windows.Forms.Button();
            this.btn_bracketRigthInput = new System.Windows.Forms.Button();
            this.btn_addSignInput = new System.Windows.Forms.Button();
            this.btn_subtractSignInput = new System.Windows.Forms.Button();
            this.btn_multiplySignInput = new System.Windows.Forms.Button();
            this.btn_numberInputBox_clear = new System.Windows.Forms.Button();
            this.btn_divisionSignInput = new System.Windows.Forms.Button();
            this.btn_deleteInputNumber = new System.Windows.Forms.Button();
            this.btn_resultMemorySave = new System.Windows.Forms.Button();
            this.btn_equalSignInput = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_numberInputView
            // 
            this.txt_numberInputView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_numberInputView.Location = new System.Drawing.Point(12, 12);
            this.txt_numberInputView.Name = "txt_numberInputView";
            this.txt_numberInputView.Size = new System.Drawing.Size(202, 21);
            this.txt_numberInputView.TabIndex = 0;
            this.txt_numberInputView.Text = "7+8*(4*5+9)+(8*9)/(7+9)";
            this.txt_numberInputView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_numberInputView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numberInputView_KeyPress);
            // 
            // btn_numberInput1
            // 
            this.btn_numberInput1.Location = new System.Drawing.Point(12, 102);
            this.btn_numberInput1.Name = "btn_numberInput1";
            this.btn_numberInput1.Size = new System.Drawing.Size(46, 43);
            this.btn_numberInput1.TabIndex = 1;
            this.btn_numberInput1.Text = "1";
            this.btn_numberInput1.UseVisualStyleBackColor = true;
            this.btn_numberInput1.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_numberInput2
            // 
            this.btn_numberInput2.Location = new System.Drawing.Point(64, 102);
            this.btn_numberInput2.Name = "btn_numberInput2";
            this.btn_numberInput2.Size = new System.Drawing.Size(46, 43);
            this.btn_numberInput2.TabIndex = 2;
            this.btn_numberInput2.Text = "2";
            this.btn_numberInput2.UseVisualStyleBackColor = true;
            this.btn_numberInput2.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_numberInput3
            // 
            this.btn_numberInput3.Location = new System.Drawing.Point(116, 102);
            this.btn_numberInput3.Name = "btn_numberInput3";
            this.btn_numberInput3.Size = new System.Drawing.Size(46, 43);
            this.btn_numberInput3.TabIndex = 3;
            this.btn_numberInput3.Text = "3";
            this.btn_numberInput3.UseVisualStyleBackColor = true;
            this.btn_numberInput3.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_numberInput4
            // 
            this.btn_numberInput4.Location = new System.Drawing.Point(12, 151);
            this.btn_numberInput4.Name = "btn_numberInput4";
            this.btn_numberInput4.Size = new System.Drawing.Size(46, 43);
            this.btn_numberInput4.TabIndex = 4;
            this.btn_numberInput4.Text = "4";
            this.btn_numberInput4.UseVisualStyleBackColor = true;
            this.btn_numberInput4.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_numberInput5
            // 
            this.btn_numberInput5.Location = new System.Drawing.Point(64, 151);
            this.btn_numberInput5.Name = "btn_numberInput5";
            this.btn_numberInput5.Size = new System.Drawing.Size(46, 43);
            this.btn_numberInput5.TabIndex = 5;
            this.btn_numberInput5.Text = "5";
            this.btn_numberInput5.UseVisualStyleBackColor = true;
            this.btn_numberInput5.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_numberInput6
            // 
            this.btn_numberInput6.Location = new System.Drawing.Point(116, 151);
            this.btn_numberInput6.Name = "btn_numberInput6";
            this.btn_numberInput6.Size = new System.Drawing.Size(46, 43);
            this.btn_numberInput6.TabIndex = 6;
            this.btn_numberInput6.Text = "6";
            this.btn_numberInput6.UseVisualStyleBackColor = true;
            this.btn_numberInput6.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_numberInput7
            // 
            this.btn_numberInput7.Location = new System.Drawing.Point(12, 200);
            this.btn_numberInput7.Name = "btn_numberInput7";
            this.btn_numberInput7.Size = new System.Drawing.Size(46, 43);
            this.btn_numberInput7.TabIndex = 7;
            this.btn_numberInput7.Text = "7";
            this.btn_numberInput7.UseVisualStyleBackColor = true;
            this.btn_numberInput7.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_numberInput8
            // 
            this.btn_numberInput8.Location = new System.Drawing.Point(64, 200);
            this.btn_numberInput8.Name = "btn_numberInput8";
            this.btn_numberInput8.Size = new System.Drawing.Size(46, 43);
            this.btn_numberInput8.TabIndex = 8;
            this.btn_numberInput8.Text = "8";
            this.btn_numberInput8.UseVisualStyleBackColor = true;
            this.btn_numberInput8.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_numberInput9
            // 
            this.btn_numberInput9.Location = new System.Drawing.Point(116, 200);
            this.btn_numberInput9.Name = "btn_numberInput9";
            this.btn_numberInput9.Size = new System.Drawing.Size(46, 43);
            this.btn_numberInput9.TabIndex = 9;
            this.btn_numberInput9.Text = "9";
            this.btn_numberInput9.UseVisualStyleBackColor = true;
            this.btn_numberInput9.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_bracketLeftInput
            // 
            this.btn_bracketLeftInput.Location = new System.Drawing.Point(64, 249);
            this.btn_bracketLeftInput.Name = "btn_bracketLeftInput";
            this.btn_bracketLeftInput.Size = new System.Drawing.Size(46, 43);
            this.btn_bracketLeftInput.TabIndex = 10;
            this.btn_bracketLeftInput.Text = "(";
            this.btn_bracketLeftInput.UseVisualStyleBackColor = true;
            this.btn_bracketLeftInput.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_numberInput0
            // 
            this.btn_numberInput0.Location = new System.Drawing.Point(12, 249);
            this.btn_numberInput0.Name = "btn_numberInput0";
            this.btn_numberInput0.Size = new System.Drawing.Size(46, 43);
            this.btn_numberInput0.TabIndex = 11;
            this.btn_numberInput0.Text = "0";
            this.btn_numberInput0.UseVisualStyleBackColor = true;
            this.btn_numberInput0.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_bracketRigthInput
            // 
            this.btn_bracketRigthInput.Location = new System.Drawing.Point(116, 249);
            this.btn_bracketRigthInput.Name = "btn_bracketRigthInput";
            this.btn_bracketRigthInput.Size = new System.Drawing.Size(46, 43);
            this.btn_bracketRigthInput.TabIndex = 12;
            this.btn_bracketRigthInput.Text = ")";
            this.btn_bracketRigthInput.UseVisualStyleBackColor = true;
            this.btn_bracketRigthInput.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_addSignInput
            // 
            this.btn_addSignInput.Location = new System.Drawing.Point(169, 53);
            this.btn_addSignInput.Name = "btn_addSignInput";
            this.btn_addSignInput.Size = new System.Drawing.Size(46, 43);
            this.btn_addSignInput.TabIndex = 13;
            this.btn_addSignInput.Text = "+";
            this.btn_addSignInput.UseVisualStyleBackColor = true;
            this.btn_addSignInput.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_subtractSignInput
            // 
            this.btn_subtractSignInput.Location = new System.Drawing.Point(168, 102);
            this.btn_subtractSignInput.Name = "btn_subtractSignInput";
            this.btn_subtractSignInput.Size = new System.Drawing.Size(46, 43);
            this.btn_subtractSignInput.TabIndex = 14;
            this.btn_subtractSignInput.Text = "-";
            this.btn_subtractSignInput.UseVisualStyleBackColor = true;
            this.btn_subtractSignInput.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_multiplySignInput
            // 
            this.btn_multiplySignInput.Location = new System.Drawing.Point(168, 151);
            this.btn_multiplySignInput.Name = "btn_multiplySignInput";
            this.btn_multiplySignInput.Size = new System.Drawing.Size(46, 43);
            this.btn_multiplySignInput.TabIndex = 15;
            this.btn_multiplySignInput.Text = "*";
            this.btn_multiplySignInput.UseVisualStyleBackColor = true;
            this.btn_multiplySignInput.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_numberInputBox_clear
            // 
            this.btn_numberInputBox_clear.Location = new System.Drawing.Point(64, 53);
            this.btn_numberInputBox_clear.Name = "btn_numberInputBox_clear";
            this.btn_numberInputBox_clear.Size = new System.Drawing.Size(46, 43);
            this.btn_numberInputBox_clear.TabIndex = 16;
            this.btn_numberInputBox_clear.Text = "clear";
            this.btn_numberInputBox_clear.UseVisualStyleBackColor = true;
            this.btn_numberInputBox_clear.Click += new System.EventHandler(this.btn_numberInputBox_clear_Click);
            // 
            // btn_divisionSignInput
            // 
            this.btn_divisionSignInput.Location = new System.Drawing.Point(169, 200);
            this.btn_divisionSignInput.Name = "btn_divisionSignInput";
            this.btn_divisionSignInput.Size = new System.Drawing.Size(46, 43);
            this.btn_divisionSignInput.TabIndex = 17;
            this.btn_divisionSignInput.Text = "/";
            this.btn_divisionSignInput.UseVisualStyleBackColor = true;
            this.btn_divisionSignInput.Click += new System.EventHandler(this.btn_numberInput1_Click);
            // 
            // btn_deleteInputNumber
            // 
            this.btn_deleteInputNumber.Location = new System.Drawing.Point(12, 53);
            this.btn_deleteInputNumber.Name = "btn_deleteInputNumber";
            this.btn_deleteInputNumber.Size = new System.Drawing.Size(46, 43);
            this.btn_deleteInputNumber.TabIndex = 18;
            this.btn_deleteInputNumber.Text = "del";
            this.btn_deleteInputNumber.UseVisualStyleBackColor = true;
            this.btn_deleteInputNumber.Click += new System.EventHandler(this.btn_deleteInputNumber_Click);
            // 
            // btn_resultMemorySave
            // 
            this.btn_resultMemorySave.Location = new System.Drawing.Point(116, 53);
            this.btn_resultMemorySave.Name = "btn_resultMemorySave";
            this.btn_resultMemorySave.Size = new System.Drawing.Size(46, 43);
            this.btn_resultMemorySave.TabIndex = 19;
            this.btn_resultMemorySave.Text = "mem";
            this.btn_resultMemorySave.UseVisualStyleBackColor = true;
            // 
            // btn_equalSignInput
            // 
            this.btn_equalSignInput.Location = new System.Drawing.Point(168, 249);
            this.btn_equalSignInput.Name = "btn_equalSignInput";
            this.btn_equalSignInput.Size = new System.Drawing.Size(46, 43);
            this.btn_equalSignInput.TabIndex = 20;
            this.btn_equalSignInput.Text = "=";
            this.btn_equalSignInput.UseVisualStyleBackColor = true;
            this.btn_equalSignInput.Click += new System.EventHandler(this.btn_equalSignInput_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(221, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 280);
            this.listBox1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_equalSignInput);
            this.Controls.Add(this.btn_resultMemorySave);
            this.Controls.Add(this.btn_deleteInputNumber);
            this.Controls.Add(this.btn_divisionSignInput);
            this.Controls.Add(this.btn_numberInputBox_clear);
            this.Controls.Add(this.btn_multiplySignInput);
            this.Controls.Add(this.btn_subtractSignInput);
            this.Controls.Add(this.btn_addSignInput);
            this.Controls.Add(this.btn_bracketRigthInput);
            this.Controls.Add(this.btn_numberInput0);
            this.Controls.Add(this.btn_bracketLeftInput);
            this.Controls.Add(this.btn_numberInput9);
            this.Controls.Add(this.btn_numberInput8);
            this.Controls.Add(this.btn_numberInput7);
            this.Controls.Add(this.btn_numberInput6);
            this.Controls.Add(this.btn_numberInput5);
            this.Controls.Add(this.btn_numberInput4);
            this.Controls.Add(this.btn_numberInput3);
            this.Controls.Add(this.btn_numberInput2);
            this.Controls.Add(this.btn_numberInput1);
            this.Controls.Add(this.txt_numberInputView);
            this.MaximumSize = new System.Drawing.Size(411, 340);
            this.MinimumSize = new System.Drawing.Size(411, 340);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numberInputView;
        private System.Windows.Forms.Button btn_numberInput1;
        private System.Windows.Forms.Button btn_numberInput2;
        private System.Windows.Forms.Button btn_numberInput3;
        private System.Windows.Forms.Button btn_numberInput4;
        private System.Windows.Forms.Button btn_numberInput5;
        private System.Windows.Forms.Button btn_numberInput6;
        private System.Windows.Forms.Button btn_numberInput7;
        private System.Windows.Forms.Button btn_numberInput8;
        private System.Windows.Forms.Button btn_numberInput9;
        private System.Windows.Forms.Button btn_bracketLeftInput;
        private System.Windows.Forms.Button btn_numberInput0;
        private System.Windows.Forms.Button btn_bracketRigthInput;
        private System.Windows.Forms.Button btn_addSignInput;
        private System.Windows.Forms.Button btn_subtractSignInput;
        private System.Windows.Forms.Button btn_multiplySignInput;
        private System.Windows.Forms.Button btn_numberInputBox_clear;
        private System.Windows.Forms.Button btn_divisionSignInput;
        private System.Windows.Forms.Button btn_deleteInputNumber;
        private System.Windows.Forms.Button btn_resultMemorySave;
        private System.Windows.Forms.Button btn_equalSignInput;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

