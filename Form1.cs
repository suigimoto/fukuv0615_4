using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0615_4
{
    public partial class Form1 : Form
    {
        int ans = rand.Next(0, 101);
        static Random rand = new Random();
        int count = 0;
        int guess;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            MessageBox.Show($"{count}回目の挑戦");

            guess = int.Parse($"{textBox1.Text}");
            if (ans == guess)
            {
                MessageBox.Show("Bingo!!");
                count = 0;
                ans = rand.Next(0, 5);

            }
            else if (ans > guess)
            {
                MessageBox.Show("Greater");
            }
            else
            {
                MessageBox.Show("Less");
            }
        }
    }
}
