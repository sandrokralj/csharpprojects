using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate string StringManipulationHandler(String s);
        public StringManipulationHandler stringManipulator;

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (radioButton1.Checked == true)
            {
                stringManipulator += new StringManipulationHandler(this.changeToCapital);
                this.textBox2.Text = stringManipulator(this.textBox1.Text);
            }
            if(radioButton2.Checked == true)
            {
                stringManipulator += new StringManipulationHandler(this.changeToNextCharacter);
                this.textBox2.Text = stringManipulator(this.textBox1.Text);
            }
            if(radioButton3.Checked == true)
            {
                stringManipulator += new StringManipulationHandler(this.changeToPreviousCharacter);
                this.textBox2.Text = stringManipulator(this.textBox1.Text);
            }
        }

        private String changeToNextCharacter(String s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s

            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];

                if ((ch >= 'a' && ch < 'z') || (ch >= 'A' && ch < 'Z'))

                {

                    chars[i]++;

                }
                else

                {
                    if (ch == 'z') { chars[i] = 'a'; }

                    if (ch == 'Z') { chars[i] = 'A'; }

                }

            }
            //now add the characters in the array chars one by one to the answer-string
            String answer = "";
            foreach (char ch in chars) { answer += ch; }

            return answer;

        }

        private String changeToPreviousCharacter(String s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s

            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];

                if ((ch >= 'a' && ch < 'z') || (ch >= 'A' && ch < 'Z'))

                {

                    chars[i]--;

                }
                else

                {
                    if (ch == 'z') { chars[i] = 'y'; }

                    if (ch == 'Z') { chars[i] = 'Y'; }

                    if (ch == 'a') { chars[i] = 'z'; }

                    if (ch == 'A') { chars[i] = 'Z'; }

                }

            }
            //now add the characters in the array chars one by one to the answer-string
            String answer = "";
            foreach (char ch in chars) { answer += ch; }

            return answer;

        }

        private String changeToCapital(String s)
        {
            char[] chars = s.ToCharArray(); //now chars is an array containing all the characters of string s

            for (int i = 0; i < chars.Length; i++)
            {
                char ch = chars[i];

                if ((ch >= 'a' && ch < 'z') || (ch >= 'A' && ch < 'Z'))

                {

                    chars[i] = ch ;

                }
                else

                {
                    if (ch == 'z') { chars[i] = 'a'; }

                    if (ch == 'Z') { chars[i] = 'A'; }


                }

            }
            //now add the characters in the array chars one by one to the answer-string
            String answer = "";
            foreach (char ch in chars) { answer += ch; }

            return answer.ToUpper();

        }
    }
}
