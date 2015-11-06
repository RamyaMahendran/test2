using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lights
{
    public partial class Form1 : Form
    {
        int turn=0;
        int p;
        Button[] btns;
        int []Stage1;
        int []Stage2;
        int []Stage3;
        int []Stage4;
        int []Stage5;
        int []Stage6;
        public Form1()
        {
            InitializeComponent();
            btns = new Button[] { btnn1, btnn2, btnn3, btne1, btne2, btne3, btns1, btns2, btns3, btnw1, btnw2, btnw3 };
            Stage1 = new int[] { 0, 0, 1, 0, 0, 1, 0, 0, 1, 1, 1, 1 };
            Stage2 = new int[] { 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1, 1 };
            Stage3 = new int[] { 0, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 };
            Stage4 = new int[] { 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1 };
            Stage5 = new int[] { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
            Stage6 = new int[] { 0, 1, 1, 0, 0, 1, 0, 1, 1, 0, 0, 1 };
           // turnLights();
        }

        void LightGlow(int[] arr)
        {
            for (int i = 0; i < 12; i++)
            {
                if (arr[i] == 1)
                    btns[i].BackColor = Color.Green;
                else
                    btns[i].BackColor = Color.Red;
            }
        }

        private void btnw3_Click(object sender, EventArgs e)
        {

        }

        private void btnw2_Click(object sender, EventArgs e)
        {

        }
        
        private void btnstage_Click(object sender, EventArgs e)
        {
            //turnLights();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnn1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            turn = turn + 1;
            p = (turn % 6) + 1;
            btnstage.Text = p.ToString();
        }

        private void btnstage_TextChanged(object sender, EventArgs e)
        {
            switch (p)
            {
                case 1: LightGlow(Stage1); break;
                case 2: LightGlow(Stage2); break;
                case 3: LightGlow(Stage3); break;
                case 4: LightGlow(Stage4); break;
                case 5: LightGlow(Stage5); break;
                case 6: LightGlow(Stage6); break;
                default: break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
