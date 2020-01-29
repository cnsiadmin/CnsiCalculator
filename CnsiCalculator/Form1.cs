using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using StackCalculate;
namespace CnsiCalculator
{
    public partial class Form1 : Form
    {
        /*
            string m_exceptionClassName = "~~ / ";
            try
            {
            }
            catch (Exception _ex)
            {
                Console.WriteLine(m_exceptionClassName + MethodBase.GetCurrentMethod().Name + _ex);
            }

         */
        string m_exceptionClassName = "Form1 / ";
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_numberInputView_KeyPress(object _sender, KeyPressEventArgs _e)
        {
            try
            {
                if (!char.IsDigit(_e.KeyChar))
                {
                    _e.Handled = true;
                }
            }
            catch(Exception _ex)
            {
                Console.WriteLine(m_exceptionClassName + MethodBase.GetCurrentMethod().Name + _ex);
            }
        }

        private void btn_numberInput1_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
                char getLastChar = ' ' ;
                if(txt_numberInputView.Text.Length > 0)
                {
                    getLastChar = txt_numberInputView.Text.ToArray()[txt_numberInputView.Text.Length - 1];
                }
                switch (btn.Name)
                {
                    case "btn_numberInput1":
                        if (getLastChar != ')')
                            txt_numberInputView.Text += 1;
                        break;
                    case "btn_numberInput2":
                        if (getLastChar != ')')
                            txt_numberInputView.Text += 2;
                        break;
                    case "btn_numberInput3":
                        if (getLastChar != ')')//qqr798
                            txt_numberInputView.Text += 3;
                        break;
                    case "btn_numberInput4":
                        if (getLastChar != ')')
                            txt_numberInputView.Text += 4;
                        break;
                    case "btn_numberInput5":
                        if (getLastChar != ')')
                            txt_numberInputView.Text += 5;
                        break;
                    case "btn_numberInput6":
                        if (getLastChar != ')')
                            txt_numberInputView.Text += 6;
                        break;
                    case "btn_numberInput7":
                        if (getLastChar != ')')
                            txt_numberInputView.Text += 7;
                        break;
                    case "btn_numberInput8":
                        if (getLastChar != ')')
                            txt_numberInputView.Text +=8;
                        break;
                    case "btn_numberInput9":
                        if (getLastChar != ')')
                            txt_numberInputView.Text += 9;
                        break;
                    case "btn_numberInput0":
                        if (getLastChar != ')')
                            txt_numberInputView.Text += 0;
                        break;
                    case "btn_multiplySignInput":
                       
                        if (char.IsDigit(getLastChar) || getLastChar == ')')
                        {
                            txt_numberInputView.Text += '*';
                        }
                        break;
                    case "btn_addSignInput":
                        if (char.IsDigit(getLastChar) || getLastChar == ')')
                        {
                            txt_numberInputView.Text += '+';
                        }
                        break;
                    case "btn_subtractSignInput":
                        if (char.IsDigit(getLastChar) || getLastChar == ')')
                        {
                            txt_numberInputView.Text += '-';
                        }
                        break;
                    case "btn_divisionSignInput":
                        if (char.IsDigit(getLastChar) || getLastChar == ')')
                        {
                            txt_numberInputView.Text += '/';
                        }
                        break;
                    case "btn_bracketLeftInput":
                        if(!char.IsDigit(getLastChar) && getLastChar != ')')
                            txt_numberInputView.Text += '(';
                        
                        break;
                    case "btn_bracketRigthInput":
                        if (!char.IsDigit(getLastChar) && getLastChar != ')')
                            return;
                        int leftSignCount = 0;
                        int rightSignCount = 0;
                        if(txt_numberInputView.Text.IndexOf("(") != -1)
                        {
                            char[] inputStringArray = txt_numberInputView.Text.ToArray();
                            getLastChar = inputStringArray[inputStringArray.Length - 1];
                            for (int index = 0;index < inputStringArray.Length; index++)
                            {
                                if (inputStringArray[index] == '(')
                                    leftSignCount++;
                                if (inputStringArray[index] == ')')
                                    rightSignCount++;
                            }
                            if((leftSignCount > rightSignCount) && (getLastChar != '+' || getLastChar != '-' || getLastChar != '/' || getLastChar != '*'))
                                txt_numberInputView.Text += ')';
                        }
                        break;

                }
            }
            catch(Exception _ex)
            {
                Console.WriteLine(m_exceptionClassName + MethodBase.GetCurrentMethod().Name + _ex);
            }
        }

        private void btn_numberInputBox_clear_Click(object sender, EventArgs e)
        {
            try
            {
                txt_numberInputView.Text = "";
            }
            catch (Exception _ex)
            {
                Console.WriteLine(m_exceptionClassName + MethodBase.GetCurrentMethod().Name + _ex);
            }

        }

        private void btn_equalSignInput_Click(object sender, EventArgs e)
        {
            try
            {
                CCalculate a = new CCalculate();
                a.convertPrefix(txt_numberInputView.Text);
            }
            catch (Exception _ex)
            {
                Console.WriteLine(m_exceptionClassName + MethodBase.GetCurrentMethod().Name + _ex);
            }
        }

        private void btn_deleteInputNumber_Click(object sender, EventArgs e)
        {
            try
            {
                txt_numberInputView.Text= txt_numberInputView.Text.Substring(0, txt_numberInputView.Text.Length - 1);
            }
            catch (Exception _ex)
            {
                Console.WriteLine(m_exceptionClassName + MethodBase.GetCurrentMethod().Name + _ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FUCK");
        }
    }
}
