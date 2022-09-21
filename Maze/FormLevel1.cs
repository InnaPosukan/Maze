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
    public partial class FormLevel1 : Form
    {
        public FormLevel1()
        {
            InitializeComponent();
            Start_game();

        }
        private void Start_game()
        {
            Point point;
            point = label1.Location;
            Cursor.Position = PointToScreen(point);
            point.Offset(label1.Width / 2, label1.Height / 2);

        }
        private void Finish_game()
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
        private void FormLevel1_Shown(object sender, EventArgs e)
        {
            Start_game();
        }


        private void Button3_MouseEnter(object sender, EventArgs e)
        {
            Finish_game();
        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}


 