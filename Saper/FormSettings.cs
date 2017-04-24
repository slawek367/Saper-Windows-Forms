using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    public partial class FormSettings : Form
    {
        Settings settings;
        Game game;
        PictureBox picture;

        public FormSettings(Settings set, Game game, PictureBox picture)
        {
            settings = set;
            InitializeComponent();

            this.game = game;
            this.picture = picture;

            hScrollBarX.Value = set.fieldXSize;
            hScrollBarY.Value = set.fieldYSize;

            setMaxBombs();
            hScrollBarBombs.Value = set.bombNumbers;

            labelX.Text = "X fields: " + hScrollBarX.Value.ToString();
            labelY.Text = "Y fields: " + hScrollBarY.Value.ToString();
            labelBomb.Text = "Bombs: " + hScrollBarBombs.Value.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            settings.fieldXSize = hScrollBarX.Value;
            settings.fieldYSize = hScrollBarY.Value;
            settings.bombNumbers = hScrollBarBombs.Value;
            this.Close();
        }

        private void hScrollBarX_Scroll(object sender, ScrollEventArgs e)
        {
            labelX.Text = "X fields: " + hScrollBarX.Value.ToString();
            settings.fieldXSize = hScrollBarX.Value;
            setMaxBombs();
        }
        private void hScrollBarY_Scroll(object sender, ScrollEventArgs e)
        {
            labelY.Text = "Y fields: " + hScrollBarY.Value.ToString();
            settings.fieldYSize = hScrollBarY.Value;
            setMaxBombs();
        }
        private void hScrollBarBombs_Scroll(object sender, ScrollEventArgs e)
        {
            labelBomb.Text = "Bombs: " + hScrollBarBombs.Value.ToString();
        }

        private void setMaxBombs()
        {
            int maxBombs =  (settings.fieldXSize * settings.fieldYSize) /2;
            hScrollBarBombs.Maximum = maxBombs;
            labelBomb.Text = "Bombs: " + hScrollBarBombs.Value.ToString();
        }

        private void FormSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            //game = new Game(picture, settings);
        }
    }
}
