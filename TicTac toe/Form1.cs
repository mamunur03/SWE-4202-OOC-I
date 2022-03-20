using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool player_1 = true;
        bool player = true;
        int score_1 = 0;
        int score_2 = 0;
        bool WinState()
        {
            if (Cell_1x1.Text != "" && Cell_1x2.Text == Cell_1x2.Text && Cell_1x2.Text == Cell_1x3.Text)
                return true;
            else if (Cell_2x1.Text != "" && Cell_2x1.Text == Cell_2x2.Text && Cell_2x2.Text == Cell_2x3.Text)
                return true;
            else if (Cell_3x1.Text != "" && Cell_3x1.Text == Cell_3x2.Text && Cell_3x2.Text == Cell_3x3.Text)
                return true;
            else if (Cell_1x1.Text != "" && Cell_1x1.Text == Cell_2x1.Text && Cell_2x1.Text == Cell_3x1.Text)
                return true;
            else if (Cell_1x2.Text != "" && Cell_1x2.Text == Cell_2x2.Text && Cell_2x2.Text == Cell_3x2.Text)
                return true;
            else if (Cell_1x3.Text != "" && Cell_1x3.Text == Cell_2x3.Text && Cell_2x3.Text == Cell_3x3.Text)
                return true;
            else if (Cell_1x1.Text != "" && Cell_1x1.Text == Cell_2x2.Text && Cell_2x2.Text == Cell_3x3.Text)
                return true;
            else if (Cell_3x1.Text != "" && Cell_3x1.Text == Cell_2x2.Text && Cell_2x2.Text == Cell_1x3.Text)
                return true;
            else return false;
        }
        bool DrawState()
        {
            if (Cell_1x1.Text != "" && Cell_1x2.Text != "" && Cell_1x3.Text != "" && Cell_2x1.Text != "" && Cell_2x2.Text != "" && Cell_2x3.Text != "" && Cell_3x1.Text != "" && Cell_3x2.Text != "" && Cell_3x3.Text != "" && WinState() == false)
                return true;
            else return false;
        }
        void clear()
        {
            Cell_1x1.Text = "";
            Cell_2x1.Text = "";
            Cell_3x1.Text = "";
            Cell_1x2.Text = "";
            Cell_2x2.Text = "";
            Cell_3x2.Text = "";
            Cell_1x3.Text = "";
            Cell_2x3.Text = "";
            Cell_3x3.Text = "";
            player = !player;
            
        }
       
    
        private void Yes_Click(object sender, EventArgs e)
        {

        }

        private void No_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                if (Cell_1x1.Text == "")
                { Cell_1x1.Text = "O"; player = !player; break; }
                if (Cell_1x3.Text == "")
                { Cell_1x3.Text = "O"; player = !player; break; }
                if (Cell_2x1.Text == "")
                { Cell_2x1.Text = "O"; player = !player; break; }
                if (Cell_2x2.Text == "")
                { Cell_2x2.Text = "O"; player = !player; break; }
                if (Cell_1x2.Text == "")
                { Cell_1x2.Text = "O"; player = !player; break; }
                if (Cell_3x1.Text == "")
                { Cell_3x1.Text = "O"; player = !player; break; }
                if (Cell_3x2.Text == "")
                { Cell_3x2.Text = "O"; player = !player; break; }
                if (Cell_3x3.Text == "")
                { Cell_3x3.Text = "O"; player = !player; break; }

            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            player_1 = true;

        }

        private void O_Click(object sender, EventArgs e)
        {
            player_1 = false;

        }

        private void Cell_1x3_Click(object sender, EventArgs e)
        {
            if (Cell_1x3.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_1x3.Text = "X"; player = !player;
                    player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "O"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "O"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "O"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "O"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "O"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "O"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "O"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "O"; player = !player; break; }
                    }



                }
                else
                {
                    Cell_1x3.Text = "O"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "X"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "X"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "X"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "X"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "X"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "X"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "X"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "X"; player = !player; break; }
                    }
                }

            }
            if (WinState() == true)
            {
                if (player == false && player_1==true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Computer wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
        }

        private void Cell_1x1_Click(object sender, EventArgs e)
        {
            if (Cell_1x1.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_1x1.Text = "X"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "O"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "O"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "O"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "O"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "O"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "O"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "O"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "O"; player = !player; break; }
                    }



                }
                else
                {
                    Cell_1x1.Text = "O"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "X"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "X"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "X"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "X"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "X"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "X"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "X"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "X"; player = !player; break; }
                    }
                }

            }
            if (WinState() == true)
            {
                if (player== false && player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Computer wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }

        }

        private void Cell_1x2_Click(object sender, EventArgs e)
        {
            if (Cell_1x2.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_1x2.Text = "X"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "O"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "O"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "O"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "O"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "O"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "O"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "O"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "O"; player = !player; break; }
                    }



                }
                else
                {
                    Cell_1x2.Text = "O"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "X"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "X"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "X"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "X"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "X"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "X"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "X"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "X"; player = !player; break; }
                    }
                }

            }
            if (WinState() == true)
            {
                if (player == false && player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Computer wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }

        }

        private void Cell_2x1_Click(object sender, EventArgs e)
        {
            if (Cell_2x1.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_2x1.Text = "X"; player = !player;
                    player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "O"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "O"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "O"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "O"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "O"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "O"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "O"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "O"; player = !player; break; }
                    }



                }
                else
                {
                    Cell_2x1.Text = "O"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "X"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "X"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "X"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "X"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "X"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "X"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "X"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "X"; player = !player; break; }
                    }
                }

            }
            if (WinState() == true)
            {
                if (player == false && player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Computer wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }

        }

        private void Cell_2x2_Click(object sender, EventArgs e)
        {
            if (Cell_2x2.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_2x2.Text = "X"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "O"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "O"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "O"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "O"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "O"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "O"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "O"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "O"; player = !player; break; }
                    }



                }
                else
                {
                    Cell_2x2.Text = "O"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "X"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "X"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "X"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "X"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "X"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "X"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "X"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "X"; player = !player; break; }
                    }
                }

            }
            if (WinState() == true)
            {
                if (player == false && player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Computer wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_1.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
        }

        private void Cell_2x3_Click(object sender, EventArgs e)
        {
            if (Cell_2x3.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_2x3.Text = "X"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "O"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "O"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "O"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "O"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "O"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "O"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "O"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "O"; player = !player; break; }
                    }



                }
                else
                {
                    Cell_2x3.Text = "O"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "X"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "X"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "X"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "X"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "X"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "X"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "X"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "X"; player = !player; break; }
                    }
                }

            }
            if (WinState() == true)
            {
                if (player == false && player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Computer wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
        }

        private void Cell_3x1_Click(object sender, EventArgs e)
        {
            if (Cell_3x1.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_3x1.Text = "X"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "O"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "O"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "O"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "O"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "O"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "O"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "O"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "O"; player = !player; break; }
                    }



                }
                else
                {
                    Cell_3x1.Text = "O"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "X"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "X"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "X"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "X"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "X"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "X"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "X"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "X"; player = !player; break; }
                    }
                }

            }
            if (WinState() == true)
            {
                if (player == false && player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Computer wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
        }

        private void Cell_3x2_Click(object sender, EventArgs e)
        {
            if (Cell_3x2.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_3x2.Text = "X"; player = !player;
                    player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "O"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "O"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "O"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "O"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "O"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "O"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "O"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "O"; player = !player; break; }
                    }



                }
                else
                {
                    Cell_3x2.Text = "O"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "X"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "X"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "X"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "X"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "X"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "X"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "X"; player = !player; break; }
                        if (Cell_3x3.Text == "")
                        { Cell_3x3.Text = "X"; player = !player; break; }
                    }
                }

            }
            if (WinState() == true)
            {
                if (player == false && player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Computer wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
        }

        private void Cell_3x3_Click(object sender, EventArgs e)
        {
            if (Cell_3x3.Text != "")
            {
                MessageBox.Show("Already filled");
            }
            else
            {
                if (player_1 == true)
                {
                    Cell_3x3.Text = "X"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "O"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "O"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "O"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "O"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "O"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "O"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "O"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "O"; player = !player; break; }
                    }



                }
                else
                {
                    Cell_3x3.Text = "O"; player = !player;
                    for (int i = 0; i < 9; i++)
                    {
                        if (Cell_1x1.Text == "")
                        { Cell_1x1.Text = "X"; player = !player; break; }
                        if (Cell_1x3.Text == "")
                        { Cell_1x3.Text = "X"; player = !player; break; }
                        if (Cell_2x1.Text == "")
                        { Cell_2x1.Text = "X"; player = !player; break; }
                        if (Cell_2x2.Text == "")
                        { Cell_2x2.Text = "X"; player = !player; break; }
                        if (Cell_2x3.Text == "")
                        { Cell_2x3.Text = "X"; player = !player; break; }
                        if (Cell_3x1.Text == "")
                        { Cell_3x1.Text = "X"; player = !player; break; }
                        if (Cell_3x2.Text == "")
                        { Cell_3x2.Text = "X"; player = !player; break; }
                        if (Cell_1x2.Text == "")
                        { Cell_1x2.Text = "X"; player = !player; break; }
                    }
                }

            }
            if (WinState() == true)
            {
                if (player_1 == false && player_1 == true)
                {
                    string result = "Player 1 wins";
                    MessageBox.Show(result);
                    score_1++;
                    Score_1.Text = Convert.ToString(score_1);
                }
                else
                {
                    string result = "Computer wins";
                    MessageBox.Show(result);
                    score_2++;
                    Score_2.Text = Convert.ToString(score_2);
                }
                clear();
            }
            if (DrawState() == true)
            {
                MessageBox.Show("It is a draw");
                clear();
            }
        }
    }
}
