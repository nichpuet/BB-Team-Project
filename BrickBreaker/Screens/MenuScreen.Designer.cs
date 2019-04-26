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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.brickWallPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.brickWallPic)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Tandysoft", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.titleLabel.Location = new System.Drawing.Point(297, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(601, 137);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "MAIN MENU";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tandysoft", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(487, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 109);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.Font = new System.Drawing.Font("Tandysoft", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.highscoreLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.highscoreLabel.Location = new System.Drawing.Point(370, 387);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(455, 137);
            this.highscoreLabel.TabIndex = 2;
            this.highscoreLabel.Text = "Highscore";
            this.highscoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitLabel
            // 
            this.exitLabel.Font = new System.Drawing.Font("Tandysoft", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.exitLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitLabel.Location = new System.Drawing.Point(442, 552);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(319, 137);
            this.exitLabel.TabIndex = 3;
            this.exitLabel.Text = "Exit";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuTimer
            // 
            this.menuTimer.Enabled = true;
            this.menuTimer.Interval = 16;
            this.menuTimer.Tick += new System.EventHandler(this.menuTimer_Tick);
            // 
            // brickWallPic
            // 
            this.brickWallPic.Image = global::BrickBreaker.Properties.Resources.brickWall;
            this.brickWallPic.Location = new System.Drawing.Point(18, 0);
            this.brickWallPic.Name = "brickWallPic";
            this.brickWallPic.Size = new System.Drawing.Size(25, 843);
            this.brickWallPic.TabIndex = 4;
            this.brickWallPic.TabStop = false;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.brickWallPic);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1200, 800);
            ((System.ComponentModel.ISupportInitialize)(this.brickWallPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Timer menuTimer;
        private System.Windows.Forms.PictureBox brickWallPic;
    }
}
