using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class SinglePlayerWindow : Form
    {

        Distribution Distrib;
        Label firstClicked;
        Label secondClicked;
        public int contor=0;
        public  int count_playtime = 60;
        ScoreWindow scr;
        RulesWindow info;
        SinglePlayerWindow sgr;

       

        public SinglePlayerWindow()
        {
            Distrib = new Distribution();
            InitializeComponent();
           
            Distrib.DistributeItems();
        }
        

        private void SinglePlayerWindow_Load(object sender, EventArgs e)
        {
            labeln.Text = Score.name;

            for (int i = 0; i < 32; i++)
            {
                
                if (tableLayoutPanel1.Controls[i] is Label)
                    tableLayoutPanel1.Controls[i].Text = Distrib.Get(i);

            }
           foreach (Label labels in tableLayoutPanel1.Controls)
            {
                labels.Enabled = false;
           }
            
            timerTineCarti.Start();
            
        }

      
        private void SinglePlayerWindow_Click(object sender, EventArgs e)
        {
           
            timercd.Start();

            Label clickedLabel = sender as Label;
           

            if (firstClicked!=null && secondClicked!=null)
                return;
         
            if (clickedLabel == null)
                return;


            if (clickedLabel.ForeColor == Color.Black)
                return;
            
            if (firstClicked == null)
            {
                
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }
            if (secondClicked == null)
            {
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                
            }
            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                label_Count.Text = Convert.ToString(Convert.ToInt32(label_Count.Text) + 10);
                contor += 10;
            }
            else
            {
                timer1.Start();
                
            }

               SayCongratulation();
        }


        private void SayCongratulation()
        {
            Label label;
            scr = new ScoreWindow();
            for(int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;

            }

            MessageBox.Show("YOU WON!Congrats!:)");
            Close();

            contor= Score.Pc;
            scr.Show();
        }
        //tine cartile cteva secunde dupa decrementeaza
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
            label_Count.Text = Convert.ToString(Convert.ToInt32(label_Count.Text) - 5);
            contor -= 5;
        }

        //tine cartile la inceputul jocului
        private void timerTineCarti_Tick(object sender, EventArgs e)
        {


            timerTineCarti.Stop();
            foreach (Label labels in tableLayoutPanel1.Controls)
            {
                labels.Enabled = true;
            }

        }

        //countdown
        private void timercd_Tick(object sender, EventArgs e)
        {
            
            if (count_playtime == 0)
            {
                timercd.Stop();
                MessageBox.Show("Pf!You LOSE!:(");
                Close();
               
                Score.Pc = contor;
                scr.Show();

            }
            count_playtime--;
            labelDuration.Text = count_playtime.ToString();
        }

       

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            info = new RulesWindow();
            info.Show();

        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            sgr = new SinglePlayerWindow();
            sgr.Show();
        }
    }
}
