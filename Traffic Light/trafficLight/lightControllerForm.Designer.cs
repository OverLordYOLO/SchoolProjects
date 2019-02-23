namespace trafficLight
{
    partial class LightControllerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LightControllerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goButton = new System.Windows.Forms.Button();
            this.attentionButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.autoButton = new System.Windows.Forms.Button();
            this.nextStepButton = new System.Windows.Forms.Button();
            this.powerSaverButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.authorButton = new System.Windows.Forms.Button();
            this.shutdownButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.goButton);
            this.groupBox1.Controls.Add(this.attentionButton);
            this.groupBox1.Controls.Add(this.stopButton);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // goButton
            // 
            resources.ApplyResources(this.goButton, "goButton");
            this.goButton.Name = "goButton";
            this.goButton.UseVisualStyleBackColor = true;
            // 
            // attentionButton
            // 
            resources.ApplyResources(this.attentionButton, "attentionButton");
            this.attentionButton.Name = "attentionButton";
            this.attentionButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // autoButton
            // 
            resources.ApplyResources(this.autoButton, "autoButton");
            this.autoButton.Name = "autoButton";
            this.autoButton.UseVisualStyleBackColor = true;
            // 
            // nextStepButton
            // 
            resources.ApplyResources(this.nextStepButton, "nextStepButton");
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.UseVisualStyleBackColor = true;
            // 
            // powerSaverButton
            // 
            resources.ApplyResources(this.powerSaverButton, "powerSaverButton");
            this.powerSaverButton.Name = "powerSaverButton";
            this.powerSaverButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.shutdownButton);
            this.groupBox2.Controls.Add(this.autoButton);
            this.groupBox2.Controls.Add(this.powerSaverButton);
            this.groupBox2.Controls.Add(this.nextStepButton);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // authorButton
            // 
            this.authorButton.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.authorButton, "authorButton");
            this.authorButton.Name = "authorButton";
            this.authorButton.UseVisualStyleBackColor = false;
            this.authorButton.Click += new System.EventHandler(this.authorButton_Click);
            // 
            // shutdownButton
            // 
            resources.ApplyResources(this.shutdownButton, "shutdownButton");
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.UseVisualStyleBackColor = true;
            // 
            // LightControllerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.authorButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LightControllerForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button attentionButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.Button nextStepButton;
        private System.Windows.Forms.Button powerSaverButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button authorButton;
        private System.Windows.Forms.Button shutdownButton;
    }
}

