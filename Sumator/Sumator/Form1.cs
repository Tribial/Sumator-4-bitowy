using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumator
{
    public partial class Form1 : Form
    {
        private char a, b, c, y;
        private string output = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output = "";
            c = '0';
            for (int i = 3; i >= 0; i--)
            {
                a = in1.Text[i];
                b = in2.Text[i];
                SUM(a, b, c);
                output += y;
            }
            output += c;
            output = reverse(output);
            output = test(output);
            out1.Text = output;
        }

        private string reverse(string tekst)
        {
            string rTekst = "";
            for (int i = tekst.Length - 1; i >= 0; i--)
            {
                rTekst += tekst[i];
            }
            return rTekst;
        }

        private string test(string t1)
        {
            bool x = false;
            string t2 = "";
            foreach (var a in t1)
            {
                if (x)
                {
                    t2 += a;
                }
                else
                {
                    if (a == '1')
                    {
                        t2 += a;
                        x = true;
                    }
                }
            }
            return t2;
        }

        private char AND(char x, char y)
        {
            if (x == '1' && y == '1')
                return '1';
            return '0';
        }

        private char OR(char x, char y)
        {
            if (x == '1' || y == '1')
                return '1';
            return '0';
        }

        private char AND(char x, char y, char z)
        {
            return AND(AND(x,y),z);
        }

        private char OR(char x, char y, char z, char k)
        {
            return OR(OR(x, y), OR(z,k));
        }
        private char OR(char x, char y, char z)
        {
            return OR(OR(x, y), z);
        }

        private char NOT(char x)
        {
            if (x == '1')
                return '0';
            return '1';
        }

        private void SUM(char A, char B, char C)
        {
            y = OR(AND(NOT(C), NOT(A), B), AND(NOT(C), A, NOT(B)), AND(C, A, B), AND(C, NOT(A), NOT(B)));
            c = OR(AND(C, A), AND(C, B), AND(A, B));
        }

        private void TextChanged(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(TB.Text, "[^0-9]"))
            {
                TB.Text = TB.Text.Remove(TB.Text.Length - 1);
            }
        }
    }
}
