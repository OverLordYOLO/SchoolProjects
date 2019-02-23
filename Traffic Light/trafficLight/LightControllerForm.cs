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
    public partial class LightControllerForm : Form
    {
        public LightControllerForm()
        {
            InitializeComponent();
        }

        public void registerStopButtonClick(EventHandler handle)
        {
            this.stopButton.Click += handle;
        }
        public void registerAttentionButtonClick(EventHandler handle)
        {
            this.attentionButton.Click += handle;
        }
        public void registerGoButtonClick(EventHandler handle)
        {
            this.goButton.Click += handle;
        }
        
        public void registerAutoButtonClick(EventHandler handle)
        {
            this.autoButton.Click += handle;
        }
        public void registerPowerSaverButtonClick(EventHandler handle)
        {
            this.powerSaverButton.Click += handle;
        }
        public void registerNextStepButtonClick(EventHandler handle)
        {
            this.nextStepButton.Click += handle;
        }
        public void registershutdownButtonClick(EventHandler handle)
        {
            this.shutdownButton.Click += handle;
        }

        private void authorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Matěj Kohútek");
        }
    }
}
