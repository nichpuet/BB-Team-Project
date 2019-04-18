namespace BrickBreaker
{
    partial class GameScreen
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreOutput = new System.Windows.Forms.Label();
            this.scoresLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreOutput
            // 
            this.scoreOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreOutput.Location = new System.Drawing.Point(2219, 1462);
            this.scoreOutput.Name = "scoreOutput";
            this.scoreOutput.Size = new System.Drawing.Size(273, 46);
            this.scoreOutput.TabIndex = 0;
            this.scoreOutput.Text = "scoreOutputTest";
            // 
            // scoresLabel
            // 
            this.scoresLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.scoresLabel.Location = new System.Drawing.Point(2173, 64);
            this.scoresLabel.Name = "scoresLabel";
            this.scoresLabel.Size = new System.Drawing.Size(298, 422);
            this.scoresLabel.TabIndex = 1;
            this.scoresLabel.Text = "Scores ";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.scoresLabel);
            this.Controls.Add(this.scoreOutput);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(2533, 1565);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreOutput;
        private System.Windows.Forms.Label scoresLabel;
    }
}
