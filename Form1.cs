using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardCrypto
{
    public partial class Form1 : Form
    {
        #region basic definitions and other things that need to be collapsed for this code to be legible
        public bool isEncrypt;
        public bool isDecrypt;
        public void EncryptShifterFunction(string input)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "1") { builder.Append("2"); }
                if (input[i].ToString() == "2") { builder.Append("3"); }
                if (input[i].ToString() == "3") { builder.Append("4"); }
                if (input[i].ToString() == "4") { builder.Append("5"); }
                if (input[i].ToString() == "5") { builder.Append("6"); }
                if (input[i].ToString() == "6") { builder.Append("7"); }
                if (input[i].ToString() == "7") { builder.Append("8"); }
                if (input[i].ToString() == "8") { builder.Append("9"); }
                if (input[i].ToString() == "9") { builder.Append("0"); }
                if (input[i].ToString() == "0") { builder.Append("1"); }
                if (input[i].ToString() == "q") { builder.Append("w"); }
                if (input[i].ToString() == "w") { builder.Append("e"); }
                if (input[i].ToString() == "e") { builder.Append("r"); }
                if (input[i].ToString() == "r") { builder.Append("t"); }
                if (input[i].ToString() == "t") { builder.Append("y"); }
                if (input[i].ToString() == "y") { builder.Append("u"); }
                if (input[i].ToString() == "u") { builder.Append("i"); }
                if (input[i].ToString() == "i") { builder.Append("o"); }
                if (input[i].ToString() == "o") { builder.Append("p"); }
                if (input[i].ToString() == "p") { builder.Append("q"); }
                if (input[i].ToString() == "a") { builder.Append("s"); }
                if (input[i].ToString() == "s") { builder.Append("d"); }
                if (input[i].ToString() == "d") { builder.Append("f"); }
                if (input[i].ToString() == "f") { builder.Append("g"); }
                if (input[i].ToString() == "g") { builder.Append("h"); }
                if (input[i].ToString() == "h") { builder.Append("j"); }
                if (input[i].ToString() == "j") { builder.Append("k"); }
                if (input[i].ToString() == "k") { builder.Append("l"); }
                if (input[i].ToString() == "l") { builder.Append("a"); }
                if (input[i].ToString() == "z") { builder.Append("x"); }
                if (input[i].ToString() == "x") { builder.Append("c"); }
                if (input[i].ToString() == "c") { builder.Append("v"); }
                if (input[i].ToString() == "v") { builder.Append("b"); }
                if (input[i].ToString() == "b") { builder.Append("n"); }
                if (input[i].ToString() == "n") { builder.Append("m"); }
                if (input[i].ToString() == "m") { builder.Append("z"); }
                if (input[i].ToString() == " ") { builder.Append(" "); }
                else
                {
                    //donothing
                }
            }
            outputTextBox.Text = builder.ToString();
        }
        public void DecryptShifterFunction(string input)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "1") { builder.Append("0"); }
                if (input[i].ToString() == "2") { builder.Append("1"); }
                if (input[i].ToString() == "3") { builder.Append("2"); }
                if (input[i].ToString() == "4") { builder.Append("3"); }
                if (input[i].ToString() == "5") { builder.Append("4"); }
                if (input[i].ToString() == "6") { builder.Append("5"); }
                if (input[i].ToString() == "7") { builder.Append("6"); }
                if (input[i].ToString() == "8") { builder.Append("7"); }
                if (input[i].ToString() == "9") { builder.Append("8"); }
                if (input[i].ToString() == "0") { builder.Append("9"); }
                if (input[i].ToString() == "q") { builder.Append("p"); }
                if (input[i].ToString() == "w") { builder.Append("q"); }
                if (input[i].ToString() == "e") { builder.Append("w"); }
                if (input[i].ToString() == "r") { builder.Append("e"); }
                if (input[i].ToString() == "t") { builder.Append("r"); }
                if (input[i].ToString() == "y") { builder.Append("t"); }
                if (input[i].ToString() == "u") { builder.Append("y"); }
                if (input[i].ToString() == "i") { builder.Append("u"); }
                if (input[i].ToString() == "o") { builder.Append("i"); }
                if (input[i].ToString() == "p") { builder.Append("o"); }
                if (input[i].ToString() == "a") { builder.Append("l"); }
                if (input[i].ToString() == "s") { builder.Append("a"); }
                if (input[i].ToString() == "d") { builder.Append("s"); }
                if (input[i].ToString() == "f") { builder.Append("d"); }
                if (input[i].ToString() == "g") { builder.Append("f"); }
                if (input[i].ToString() == "h") { builder.Append("g"); }
                if (input[i].ToString() == "j") { builder.Append("h"); }
                if (input[i].ToString() == "k") { builder.Append("j"); }
                if (input[i].ToString() == "l") { builder.Append("k"); }
                if (input[i].ToString() == "z") { builder.Append("m"); }
                if (input[i].ToString() == "x") { builder.Append("z"); }
                if (input[i].ToString() == "c") { builder.Append("x"); }
                if (input[i].ToString() == "v") { builder.Append("c"); }
                if (input[i].ToString() == "b") { builder.Append("v"); }
                if (input[i].ToString() == "n") { builder.Append("b"); }
                if (input[i].ToString() == "m") { builder.Append("n"); }
                if (input[i].ToString() == " ") { builder.Append(" "); }
                else
                { 
                    //donothing
                }
            }
            outputTextBox.Text = builder.ToString();
        }



        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isEncrypt = true;
            isDecrypt = false;
            encryptButton.BackColor = Color.Blue;
            encryptButton.ForeColor = Color.White;
            decryptButton.BackColor = Color.White;
            decryptButton.ForeColor = Color.Black;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            isEncrypt = true;
            isDecrypt = false;
            encryptButton.BackColor = Color.Blue;
            encryptButton.ForeColor = Color.White;
            decryptButton.BackColor = Color.White;
            decryptButton.ForeColor = Color.Black;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            isEncrypt = false;
            isDecrypt = true;
            decryptButton.BackColor = Color.Blue;
            decryptButton.ForeColor = Color.White;
            encryptButton.BackColor = Color.White;
            encryptButton.ForeColor = Color.Black;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (isEncrypt == true)
            {
                EncryptShifterFunction(inputTextBox.Text);
            }
            else
            {
                DecryptShifterFunction(inputTextBox.Text);
            }
        }
    }
}
