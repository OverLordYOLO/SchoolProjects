namespace timer
{
	partial class Form1
	{
		/// <summary>
		/// Vyžaduje se proměnná návrháře.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Uvolněte všechny používané prostředky.
		/// </summary>
		/// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kód generovaný Návrhářem Windows Form

		/// <summary>
		/// Metoda vyžadovaná pro podporu Návrháře - neupravovat
		/// obsah této metody v editoru kódu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.startButton = new System.Windows.Forms.Button();
			this.lapButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.lapListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.startButton.Location = new System.Drawing.Point(42, 147);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(159, 37);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// lapButton
			// 
			this.lapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lapButton.Location = new System.Drawing.Point(42, 190);
			this.lapButton.Name = "lapButton";
			this.lapButton.Size = new System.Drawing.Size(159, 37);
			this.lapButton.TabIndex = 1;
			this.lapButton.Text = "Lap";
			this.lapButton.UseVisualStyleBackColor = true;
			this.lapButton.Click += new System.EventHandler(this.lapButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.resetButton.Location = new System.Drawing.Point(42, 231);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(159, 37);
			this.resetButton.TabIndex = 2;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// lapListBox
			// 
			this.lapListBox.FormattingEnabled = true;
			this.lapListBox.Location = new System.Drawing.Point(337, 147);
			this.lapListBox.Name = "lapListBox";
			this.lapListBox.Size = new System.Drawing.Size(361, 264);
			this.lapListBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(627, 91);
			this.label1.TabIndex = 4;
			this.label1.Text = "00 : 00 : 00 : 000";
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lapListBox);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.lapButton);
			this.Controls.Add(this.startButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button lapButton;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.ListBox lapListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
	}
}

