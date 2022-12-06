namespace posk2
{
    partial class Entry
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
            this.btnHear = new System.Windows.Forms.Button();
            this.btnVisn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHear
            // 
            this.btnHear.Location = new System.Drawing.Point(161, 189);
            this.btnHear.Name = "btnHear";
            this.btnHear.Size = new System.Drawing.Size(155, 50);
            this.btnHear.TabIndex = 0;
            this.btnHear.Text = "Słuch";
            this.btnHear.UseVisualStyleBackColor = true;
            this.btnHear.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnVisn
            // 
            this.btnVisn.Location = new System.Drawing.Point(483, 189);
            this.btnVisn.Name = "btnVisn";
            this.btnVisn.Size = new System.Drawing.Size(155, 50);
            this.btnVisn.TabIndex = 2;
            this.btnVisn.Text = "Wzrok";
            this.btnVisn.UseVisualStyleBackColor = true;
            this.btnVisn.Click += new System.EventHandler(this.btn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(233, 134);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(343, 33);
            this.title.TabIndex = 3;
            this.title.Text = "Wybierz kategorię testu";
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.title);
            this.Controls.Add(this.btnVisn);
            this.Controls.Add(this.btnHear);
            this.Name = "Entry";
            this.Text = "Test Sprawności Psychoruchowej";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHear;
        private System.Windows.Forms.Button btnVisn;
        private System.Windows.Forms.Label title;
    }
}

