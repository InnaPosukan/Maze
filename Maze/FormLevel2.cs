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
    public partial class FormLevel2 : Form
    {
        int count = 3;
        int Count_money = 0;
        public FormLevel2()
        {
            InitializeComponent();
        }
        private void Start_game()
        {
            Point point;
            point = label3.Location;
            Cursor.Position = PointToScreen(point);
            point.Offset(label3.Width / 2, label3.Height / 2);

        }
        private void Finish_game()
        {
            DialogResult dr = MessageBox.Show("Бажаєте перейти на наступні рівні?", "Повідомлення",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Start_game();

            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }

        private void Game_over()
        {
            DialogResult dr = MessageBox.Show("Кінець гри. Бажаєте повторити?", "Повідомлення",
                MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Start_game();

            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
        }

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            Finish_game();
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

        }

        private void Label_door_MouseEnter(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
                Game_over();
            else
               
            label_door.Visible = false;
            Sound.play_fai();

        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Visible = false;
            Sound.play_fail();
            Count_money++;
            Show_Money();

        }
    
        private void Show_Money()
        {
            label1.Text = "Ви зібрали" +" " +  Count_money.ToString() +" "+"з" + " " +count.ToString(); ;

        }


        private void Button5_MouseEnter(object sender, EventArgs e)
        {
            Game_over();
        }

    }
}


