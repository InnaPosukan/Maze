using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{

    public partial class Form1 : Form
    {
        private void Button_start_Click(object sender, EventArgs e)
        {
            Start_level1();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_level1()
        {
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Start_level2();
            }

        }
        private void Start_level2()
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Start_level3();
            }

        }


        private void Start_level3()
        {
            FormLevel3 level3 = new FormLevel3();
            DialogResult dr = level3.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Win();
            }
        }
        private void Win()
        {
            Sound.play_fail();
            MessageBox.Show("Ви пройшли усі лабіринти. Вітаємо!");

        }
    }
}

   