using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string Encode(string no)
        {
            string head = "101";
            string mid = "01010";
            string[,] set = new string[,]{
            {"0001101","0100111","1110010"},
            {"0011001","0110011","1100110"},
            {"0010011","0011011","1101100"},
            {"0111101","0100001","1000010"},
            {"0100011","0011101","1011100"},
            {"0110001","0111001","1001110"},
            {"0101111","0000101","1010000"},
            {"0111011","0010001","1000100"},
            {"0110111","0001001","1001000"},
            {"0001011","0010111","1110100"}};
            int[,] select = new int[,]{
            {0,0,0,0,0,0},
            {0,0,1,0,1,1},
            {0,0,1,1,0,1},
            {0,0,1,1,1,0},
            {0,1,0,0,1,1},
            {0,1,1,0,0,1},
            {0,1,1,1,0,0},
            {0,1,0,1,0,1},
            {0,1,0,1,1,0},
            {0,1,1,0,1,0},};
            string code = "";
            char[] num = no.ToCharArray();

            code = code + head;
            int selectnum = Convert.ToInt32(num[0] - '0');
            for (int i = 1; i < 6; i++)
            {
                code = code + set[Convert.ToInt32(num[i] - '0'), select[selectnum, i]];
            }
            code = code + mid;
            for (int i = 6; i < 13; i++)
            {
                code = code + set[Convert.ToInt32(num[i] - '0'), 2];
            }
            code = code + head;

            return code;
        }

        public void Draw(string code)
        {
            PaintEventArgs pe = new PaintEventArgs(tiaomaycx.CreateGraphics(), tiaomaycx.ClientRectangle);
            Graphics g = pe.Graphics;

            Pen pb = new Pen(Color.Black, 2);
            Pen pw = new Pen(Color.White, 2);
            int x = 20, y1 = 10, y2 = 90;

            foreach (char c in code)
            {
                if (c == '1')
                {
                    g.DrawLine(pb, new Point(x, y1), new Point(x, y2));
                    x += 2;
                }
                else if (c == '0')
                {
                    g.DrawLine(pw, new Point(x, y1), new Point(x, y2));
                    x += 2;
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {         
            string str = tiaomalkx.Text;
            string code = Encode(str);
            Draw(Encode(str));
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
