using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mkr2
{
    public partial class Form1 : Form
    {
        private int player;
        public Form1()
        {
            
            InitializeComponent();
            this.Height = 600;
            this.Width = 900;
            player = 1;
            label1.Text = "Хід гравець 1";
        }
        public string s;
        public string p;
        bool a = false;
        private void button1_Click(object sender, EventArgs e)
        {
                if(comboBox1.Text == "x")
                {
                p = "o";
                }
                else
                {
                p = "x";
                }
                switch (player)
                {
                    case 1:
                        sender.GetType().GetProperty("Text").SetValue(sender, comboBox1.Text);
                        player = 0;
                        label1.Text = "Хід гравець 1";
                        s = "Переміг гравець 1";
                        break;
                    case 0:
                        sender.GetType().GetProperty("Text").SetValue(sender, p);
                        player = 1;
                        label1.Text = "Хід гравець 2";
                        s = "Переміг гравець 2";

                        break;
                }
                sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                Ifwin();
                draw();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void Ifwin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text) 
            {
                if (button1.Text != "")
                { 
                    MessageBox.Show(s);
                    end_game();
                    a = true;
                }
                
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                {
                    MessageBox.Show(s);
                    end_game();
                    a = true;
                }
                
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                {
                    MessageBox.Show(s);
                    end_game();
                    a = true;
                }
               
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                {
                    MessageBox.Show(s);
                    end_game();
                    a = true;
                }
               
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                {
                    MessageBox.Show(s);
                    end_game();
                    a = true;
                }
               
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                {
                    MessageBox.Show(s);
                    end_game();
                    a = true;
                }
                
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                {
                    MessageBox.Show(s);
                    end_game();
                    a = true;
                }
                
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                {
                    MessageBox.Show(s);
                    end_game();
                    a = true;
                }
               
            }

        }

        
        
        private void new_game()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            player = 1;
            a = false;
        }
        
        private void end_game()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void draw()
        {
            if (a == false)
            {
                if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" &&
                    button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" &&
                    button9.Text != "")

                {
                    MessageBox.Show("Нічия");
                }
            }
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void новаГраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_game();
        }
    }
}
