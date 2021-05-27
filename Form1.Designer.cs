
namespace day17_krustini_nullites
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.desasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sāktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilde = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.gaajiens = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bilde)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // desasToolStripMenuItem
            // 
            this.desasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sāktToolStripMenuItem});
            this.desasToolStripMenuItem.Name = "desasToolStripMenuItem";
            this.desasToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.desasToolStripMenuItem.Text = "Desas";
            // 
            // sāktToolStripMenuItem
            // 
            this.sāktToolStripMenuItem.Name = "sāktToolStripMenuItem";
            this.sāktToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.sāktToolStripMenuItem.Text = "Sākt !";
            this.sāktToolStripMenuItem.Click += new System.EventHandler(this.sāktToolStripMenuItem_Click);
            // 
            // bilde
            // 
            this.bilde.Image = global::day17_krustini_nullites.Properties.Resources.Tic_tac_toe;
            this.bilde.Location = new System.Drawing.Point(245, 44);
            this.bilde.Name = "bilde";
            this.bilde.Size = new System.Drawing.Size(604, 609);
            this.bilde.TabIndex = 1;
            this.bilde.TabStop = false;
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Location = new System.Drawing.Point(0, 743);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(1070, 22);
            this.status.TabIndex = 2;
            this.status.Text = "Gaajiens :";
            // 
            // gaajiens
            // 
            this.gaajiens.AutoSize = true;
            this.gaajiens.Location = new System.Drawing.Point(146, 9);
            this.gaajiens.Name = "gaajiens";
            this.gaajiens.Size = new System.Drawing.Size(72, 17);
            this.gaajiens.TabIndex = 3;
            this.gaajiens.Text = "Gaajiens :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1070, 765);
            this.Controls.Add(this.gaajiens);
            this.Controls.Add(this.status);
            this.Controls.Add(this.bilde);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bilde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sāktToolStripMenuItem;
        private System.Windows.Forms.PictureBox bilde;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.Label gaajiens;
        private System.Windows.Forms.Timer timer1;
    }
}

