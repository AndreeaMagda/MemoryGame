using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class ScoreWindow : Form

        
    {
        SinglePlayerWindow sgw ;
        public ScoreWindow()
        {
            InitializeComponent();
        }

        private void ScoreWindow_Load(object sender, EventArgs e)
        {
            string wordscore ;
            wordscore = Score.Pc.ToString() ;
            labelScore.Text = wordscore;


            string wordname ;
            wordname = Score.name.ToString();
            labelN.Text = wordname;
        }

       

        private void button2_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            sgw = new SinglePlayerWindow();
            sgw.Show();
        }
    }
}
