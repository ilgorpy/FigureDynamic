
namespace Figures
{
    partial class FiguresForm
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
            this.background = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPic)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(808, 476);
            this.background.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundPic
            // 
            this.backgroundPic.BackColor = System.Drawing.Color.SlateBlue;
            this.backgroundPic.Location = new System.Drawing.Point(0, 0);
            this.backgroundPic.Margin = new System.Windows.Forms.Padding(2);
            this.backgroundPic.Name = "backgroundPic";
            this.backgroundPic.Size = new System.Drawing.Size(808, 476);
            this.backgroundPic.TabIndex = 1;
            this.backgroundPic.TabStop = false;
            this.backgroundPic.Click += new System.EventHandler(this.backgroundPic_Click);
            // 
            // FiguresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 476);
            this.Controls.Add(this.backgroundPic);
            this.Controls.Add(this.background);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FiguresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Движение фигур";
            this.Load += new System.EventHandler(this.FiguresForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FiguresForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox backgroundPic;
    }
}