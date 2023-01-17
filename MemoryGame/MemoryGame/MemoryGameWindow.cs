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
    public partial class MemoryGameWindow : Form
    {
        SinglePlayerWindow sgnew ;
        RulesWindow rules ;
        bool condition=false;
        


        public MemoryGameWindow()
        {
            InitializeComponent();
        }

        private void MemoryGameWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
           if(condition==true)
            {
                sgnew = new SinglePlayerWindow();
                sgnew.Show();
                string wordname ;
                wordname = Score.name ;
           }

            else

            {
                MessageBox.Show("Please enter your name.");
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

            //pentru introducerea numelui
           
             condition = true;
            
             Score.name =textBox.Text;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttn_info_Click(object sender, EventArgs e)
        {
            rules = new RulesWindow();
            rules.Show();
        }
    }
}
