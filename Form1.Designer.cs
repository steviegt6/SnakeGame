namespace Snake
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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.versionNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updates = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.OliveDrab;
            this.pbCanvas.Location = new System.Drawing.Point(12, 12);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(748, 778);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Click += new System.EventHandler(this.PbCanvas_Click);
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1230, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1354, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(88, 37);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "temp";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(12, 12);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(102, 37);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label2";
            this.lblGameOver.Visible = false;
            this.lblGameOver.Click += new System.EventHandler(this.LblGameOver_Click);
            // 
            // versionNumber
            // 
            this.versionNumber.AutoSize = true;
            this.versionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionNumber.Location = new System.Drawing.Point(766, 9);
            this.versionNumber.Name = "versionNumber";
            this.versionNumber.Size = new System.Drawing.Size(71, 25);
            this.versionNumber.TabIndex = 4;
            this.versionNumber.Text = "v1.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(766, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Changelog:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // updates
            // 
            this.updates.AutoSize = true;
            this.updates.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updates.Location = new System.Drawing.Point(768, 71);
            this.updates.Name = "updates";
            this.updates.Size = new System.Drawing.Size(425, 75);
            this.updates.TabIndex = 6;
            this.updates.Text = "Nothing special.\r\nSimply followed a C# snake tutorial.\r\nExpect frequent updates f" +
    "rom random stuff!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1454, 802);
            this.Controls.Add(this.updates);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versionNumber);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label versionNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label updates;
    }
}

