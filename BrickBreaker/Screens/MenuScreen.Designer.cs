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
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleLabel.Location = new System.Drawing.Point(264, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(535, 110);
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
            this.playLabel.Location = new System.Drawing.Point(433, 199);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(244, 87);
            this.playLabel.TabIndex = 1;
            this.playLabel.Text = "PLAY";
            this.playLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playLabel.Click += new System.EventHandler(this.playButton_Click);
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highscoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.highscoreLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.highscoreLabel.Location = new System.Drawing.Point(329, 310);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(404, 110);
            this.highscoreLabel.TabIndex = 2;
            this.highscoreLabel.Text = "Highscore";
            this.highscoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitLabel
            // 
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.exitLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitLabel.Location = new System.Drawing.Point(393, 442);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(284, 110);
            this.exitLabel.TabIndex = 3;
            this.exitLabel.Text = "Exit";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // brickWallPic
            // 
            this.brickWallPic.Image = global::BrickBreaker.Properties.Resources.brickWall;
            this.brickWallPic.Location = new System.Drawing.Point(16, 0);
            this.brickWallPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brickWallPic.Name = "brickWallPic";
            this.brickWallPic.Size = new System.Drawing.Size(23, 638);
            this.brickWallPic.TabIndex = 4;
            this.brickWallPic.TabStop = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.brickWallPic);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1067, 640);
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brickWallPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label playLabel;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.PictureBox brickWallPic;

    }
}
