using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trafficLight
{
    public partial class LightDisplayForm : Form
    {
        public LightDisplayForm()
        {
            InitializeComponent();
        }
        public void RegisterOnFormDispose(EventHandler handle)
        {
            this.Disposed += handle;
        }
        public void SetStopImage(Bitmap img)
        {
            this.stopPictureBox.Image = img;
        }
        public void SetAttentionImage(Bitmap img)
        {
            this.attentionPictureBox.Image = img;
        }
        public void SetGoImage(Bitmap img)
        {
            this.goPictureBox.Image = img;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void LightDisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void stopPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
