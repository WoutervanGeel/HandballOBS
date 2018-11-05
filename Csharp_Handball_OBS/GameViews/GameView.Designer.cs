namespace Csharp_Handball_OBS.GameViews
{
    partial class GameView
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
            this.playersHomeList = new System.Windows.Forms.FlowLayoutPanel();
            this.playersOutList = new System.Windows.Forms.FlowLayoutPanel();
            this.teamNameHomeLabel = new System.Windows.Forms.Label();
            this.teamNameOutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playersHomeList
            // 
            this.playersHomeList.AutoScroll = true;
            this.playersHomeList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playersHomeList.Location = new System.Drawing.Point(20, 45);
            this.playersHomeList.Name = "playersHomeList";
            this.playersHomeList.Size = new System.Drawing.Size(367, 675);
            this.playersHomeList.TabIndex = 0;
            // 
            // playersOutList
            // 
            this.playersOutList.AutoScroll = true;
            this.playersOutList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.playersOutList.Location = new System.Drawing.Point(418, 45);
            this.playersOutList.Name = "playersOutList";
            this.playersOutList.Size = new System.Drawing.Size(365, 675);
            this.playersOutList.TabIndex = 1;
            // 
            // teamNameHomeLabel
            // 
            this.teamNameHomeLabel.AutoSize = true;
            this.teamNameHomeLabel.Location = new System.Drawing.Point(20, 13);
            this.teamNameHomeLabel.Name = "teamNameHomeLabel";
            this.teamNameHomeLabel.Size = new System.Drawing.Size(86, 13);
            this.teamNameHomeLabel.TabIndex = 2;
            this.teamNameHomeLabel.Text = "teamNameHome";
            // 
            // teamNameOutLabel
            // 
            this.teamNameOutLabel.AutoSize = true;
            this.teamNameOutLabel.Location = new System.Drawing.Point(418, 12);
            this.teamNameOutLabel.Name = "teamNameOutLabel";
            this.teamNameOutLabel.Size = new System.Drawing.Size(75, 13);
            this.teamNameOutLabel.TabIndex = 3;
            this.teamNameOutLabel.Text = "teamNameOut";
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.teamNameOutLabel);
            this.Controls.Add(this.teamNameHomeLabel);
            this.Controls.Add(this.playersOutList);
            this.Controls.Add(this.playersHomeList);
            this.Name = "GameView";
            this.Size = new System.Drawing.Size(1037, 741);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel playersHomeList;
        private System.Windows.Forms.FlowLayoutPanel playersOutList;
        private System.Windows.Forms.Label teamNameHomeLabel;
        private System.Windows.Forms.Label teamNameOutLabel;
    }
}
