namespace Pokemon
{
    partial class BeginAdventure
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
            this.pbxCurrent = new System.Windows.Forms.PictureBox();
            this.pbxPrevious = new System.Windows.Forms.PictureBox();
            this.pbxNext = new System.Windows.Forms.PictureBox();
            this.btnCycleRight = new System.Windows.Forms.Button();
            this.btnCycleLeft = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnGoForward = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.lblCurrentRegion = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlProfessorTalk = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCurrent
            // 
            this.pbxCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCurrent.Location = new System.Drawing.Point(260, 101);
            this.pbxCurrent.Name = "pbxCurrent";
            this.pbxCurrent.Size = new System.Drawing.Size(328, 179);
            this.pbxCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCurrent.TabIndex = 0;
            this.pbxCurrent.TabStop = false;
            // 
            // pbxPrevious
            // 
            this.pbxPrevious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPrevious.Location = new System.Drawing.Point(71, 125);
            this.pbxPrevious.Name = "pbxPrevious";
            this.pbxPrevious.Size = new System.Drawing.Size(328, 179);
            this.pbxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPrevious.TabIndex = 1;
            this.pbxPrevious.TabStop = false;
            // 
            // pbxNext
            // 
            this.pbxNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxNext.Location = new System.Drawing.Point(449, 125);
            this.pbxNext.Name = "pbxNext";
            this.pbxNext.Size = new System.Drawing.Size(328, 179);
            this.pbxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNext.TabIndex = 2;
            this.pbxNext.TabStop = false;
            // 
            // btnCycleRight
            // 
            this.btnCycleRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCycleRight.Location = new System.Drawing.Point(780, 200);
            this.btnCycleRight.Name = "btnCycleRight";
            this.btnCycleRight.Size = new System.Drawing.Size(56, 48);
            this.btnCycleRight.TabIndex = 3;
            this.btnCycleRight.Text = "▶";
            this.btnCycleRight.UseVisualStyleBackColor = true;
            this.btnCycleRight.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // btnCycleLeft
            // 
            this.btnCycleLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCycleLeft.Location = new System.Drawing.Point(9, 200);
            this.btnCycleLeft.Name = "btnCycleLeft";
            this.btnCycleLeft.Size = new System.Drawing.Size(56, 48);
            this.btnCycleLeft.TabIndex = 4;
            this.btnCycleLeft.Text = "◀";
            this.btnCycleLeft.UseVisualStyleBackColor = true;
            this.btnCycleLeft.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(71, 399);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 5;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnGoForward
            // 
            this.btnGoForward.Location = new System.Drawing.Point(702, 399);
            this.btnGoForward.Name = "btnGoForward";
            this.btnGoForward.Size = new System.Drawing.Size(75, 23);
            this.btnGoForward.TabIndex = 6;
            this.btnGoForward.Text = "Go!";
            this.btnGoForward.UseVisualStyleBackColor = true;
            this.btnGoForward.Click += new System.EventHandler(this.btnGoForward_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(210, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(429, 37);
            this.lblPrompt.TabIndex = 7;
            this.lblPrompt.Text = "Choose your region of origin!";
            // 
            // lblCurrentRegion
            // 
            this.lblCurrentRegion.AutoSize = true;
            this.lblCurrentRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRegion.Location = new System.Drawing.Point(380, 325);
            this.lblCurrentRegion.Name = "lblCurrentRegion";
            this.lblCurrentRegion.Size = new System.Drawing.Size(125, 20);
            this.lblCurrentRegion.TabIndex = 8;
            this.lblCurrentRegion.Text = "[Current Region]";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Snow;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Location = new System.Drawing.Point(217, 359);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(422, 63);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "[Description text goes here]";
            // 
            // pnlProfessorTalk
            // 
            this.pnlProfessorTalk.Location = new System.Drawing.Point(9, 13);
            this.pnlProfessorTalk.Name = "pnlProfessorTalk";
            this.pnlProfessorTalk.Size = new System.Drawing.Size(827, 417);
            this.pnlProfessorTalk.TabIndex = 10;
            // 
            // BeginAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(848, 442);
            this.Controls.Add(this.pnlProfessorTalk);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCurrentRegion);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnGoForward);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnCycleLeft);
            this.Controls.Add(this.btnCycleRight);
            this.Controls.Add(this.pbxCurrent);
            this.Controls.Add(this.pbxNext);
            this.Controls.Add(this.pbxPrevious);
            this.Name = "BeginAdventure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Begin Your Adventure!";
            this.Load += new System.EventHandler(this.BeginAdventure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCurrent;
        private System.Windows.Forms.PictureBox pbxPrevious;
        private System.Windows.Forms.PictureBox pbxNext;
        private System.Windows.Forms.Button btnCycleRight;
        private System.Windows.Forms.Button btnCycleLeft;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnGoForward;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Label lblCurrentRegion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlProfessorTalk;

    }
}