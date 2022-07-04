using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace My_first_form
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        public Form1()
        {
           
            InitializeComponent();
            UpdateLevel(1);
        }

        //updating levels
        

        //future feature comming soon

        public void UpdateLevel(int levelID)
        {
            if (levelID == 1)
            {
                //game code
                bool unlocked = false;
                bool userStarted = false;
                string password = "Un7Kgk5VUcphJLMVPxNeeZAKceyc42MuayDPrY2UsBmY7md5qS";
                while (unlocked == false)
                {
                    if (textBox1.Text.Length > 0)
                    {
                        userStarted = true;
                    }
                    label3.Text = "loopaccessed";
                    if (textBox1.Text == password)
                    {
                        MessageBox.Show("Unlocked!");
                        unlocked = true;

                    }
                    if (textBox1.Text == password.Substring(0, textBox1.Text.Length) && userStarted == true)
                    {
                        MessageBox.Show("Password Incorrect!");
                        /*SoundPlayer splayer = new SoundPlayer(@"");
                        splayer.Play();*/
                    }
                }
               
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
        }
    }
}
