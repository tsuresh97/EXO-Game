using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace xo
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By Suresh","EXO Game");
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else 
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkformwinner();
        }
        private void disablebutton()
        {
            try
            {
                
                foreach (Control c  in Controls)
                {
                    
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }

        }
        private void checkformwinner()
        {
            bool winner = false;
            
            //hori
                if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
                {
                    winner = true;
                }
               
                 else   if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                {
                    winner = true;
                }

                    else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                {
                    winner = true;
                }
                //verti
                else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                {
                    winner = true;
                }
                else
                    if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                    {
                        winner = true;
                    }

                    else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                    {
                        winner = true;
                    }
                        //diag
                    else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                    {
                        winner = true;
                    }

                    else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                    {
                        winner = true;
                    }
                if (winner)
                {
                    disablebutton();
                    string won = "";
                    if (turn)
                    {
                        won = "O";
                    }
                    else
                    {
                        won = "X";
                    }
                    MessageBox.Show(won + "Wins", "Result");
                }
                else
                {
                    if (turn_count == 9)
                    {
                        MessageBox.Show( "Draws", "Result");
                     }
                }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
