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
    public partial class FormLevel3 : Form

    {
        int count = 4;
        int count_money = 0;
        public FormLevel3()
        {

            InitializeComponent();

        }
        private void start_game()
        {
            Point point;
            point = label3.Location;
            Cursor.Position = PointToScreen(point);
            point.Offset(label3.Width / 2, label3.Height / 2);

        }
        private void finish_game()
        {
            DialogResult dr = MessageBox.Show("Кінець гри. Бажаєте повторити?", "Повідомлення",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                start_game();

            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }

        private void FormLevel3_Shown(object sender, EventArgs e)
        {
            start_game();

        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }


        private void label_door_MouseEnter(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                finish_game();
            }
            else
            {
                label_door.Visible = false;
                Sound.play_fai();
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }


        private void Show_Money()
        {
            label1.Text = "Ви зібрали" + " " + count_money.ToString() + " " + "з" + " " + count.ToString(); ;

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Visible = false;
            Sound.play_fail();
            count_money++;
            Show_Money();
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            Sound.play_faild();
            finish_game();
           
        }
    }

}
