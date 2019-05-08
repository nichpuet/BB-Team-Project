namespace BrickBreaker
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.playLabel = new System.Windows.Forms.Label();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.brickWallPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.brickWallPic)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleLabel.Location = new System.Drawing.Point(228, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(380, 73);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "MAINMENU";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playLabel
            // 
            this.playLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.playLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playLabel.Location = new System.Drawing.Point(325, 162);
            this.playLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(183, 71);
            this.playLabel.TabIndex = 1;
            this.playLabel.Text = "PLAY";
            this.playLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playLabel.Click += new System.EventHandler(this.playButton_Click);
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.highscoreLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highscoreLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.highscoreLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.highscoreLabel.Location = new System.Drawing.Point(981, 79);
            this.highscoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(897, 1081);
            this.highscoreLabel.TabIndex = 2;
            this.highscoreLabel.Text = "High Score For Testing Purposes";
            this.highscoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitLabel
            // 
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.exitLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitLabel.Location = new System.Drawing.Point(295, 359);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(213, 89);
            this.exitLabel.TabIndex = 3;
            this.exitLabel.Text = "Exit";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // brickWallPic
            // 
            this.brickWallPic.Image = global::BrickBreaker.Properties.Resources.brickWall;
            this.brickWallPic.Location = new System.Drawing.Point(12, 0);
            this.brickWallPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brickWallPic.Name = "brickWallPic";
            this.brickWallPic.Size = new System.Drawing.Size(17, 518);
            this.brickWallPic.TabIndex = 4;
            this.brickWallPic.TabStop = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.brickWallPic);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(800, 520);
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brickWallPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label playLabel;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.PictureBox brickWallPic;
    }
}
