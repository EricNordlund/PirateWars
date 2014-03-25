using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PirateWars
{
    public partial class Highscore : Form
    {
        string query = "SELECT * FROM highscore";
        int i = 0;
        List<string> highscorelist = new List<string>();
        Controller controller;
        public Highscore(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        
            if (controller.GetData(query).Read())
            {
                while (controller.GetData(query).Read() || i < 5)
                {
                    highscorelist.Add(controller.GetData(query)[i] as string);
                    i++;
                }
            }
            
            lblTop1.Text = highscorelist[0];
            lblTop2.Text = highscorelist[1];
            lblTop3.Text = highscorelist[2];
            lblTop4.Text = highscorelist[3];
            lblTop5.Text = highscorelist[4];
        }
    }

}

