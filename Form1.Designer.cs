namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_startpoc = new System.Windows.Forms.Button();
            this.btn_stoppoc = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.Label();
            this.txt_StatusOutput = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_startpoc
            // 
            this.btn_startpoc.Location = new System.Drawing.Point(268, 262);
            this.btn_startpoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_startpoc.Name = "btn_startpoc";
            this.btn_startpoc.Size = new System.Drawing.Size(198, 87);
            this.btn_startpoc.TabIndex = 0;
            this.btn_startpoc.Text = "&Start PoC";
            this.btn_startpoc.UseVisualStyleBackColor = true;
            this.btn_startpoc.Click += new System.EventHandler(this.btn_startpoc_Click);
            // 
            // btn_stoppoc
            // 
            this.btn_stoppoc.Location = new System.Drawing.Point(546, 262);
            this.btn_stoppoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_stoppoc.Name = "btn_stoppoc";
            this.btn_stoppoc.Size = new System.Drawing.Size(198, 87);
            this.btn_stoppoc.TabIndex = 1;
            this.btn_stoppoc.Text = "S&top PoC";
            this.btn_stoppoc.UseVisualStyleBackColor = true;
            this.btn_stoppoc.Click += new System.EventHandler(this.btn_stoppoc_Click);
            // 
            // txt_status
            // 
            this.txt_status.AutoSize = true;
            this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.Location = new System.Drawing.Point(260, 98);
            this.txt_status.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(117, 37);
            this.txt_status.TabIndex = 2;
            this.txt_status.Text = "Status:";
            // 
            // txt_StatusOutput
            // 
            this.txt_StatusOutput.AutoSize = true;
            this.txt_StatusOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StatusOutput.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_StatusOutput.Location = new System.Drawing.Point(414, 98);
            this.txt_StatusOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txt_StatusOutput.Name = "txt_StatusOutput";
            this.txt_StatusOutput.Size = new System.Drawing.Size(0, 37);
            this.txt_StatusOutput.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(648, 473);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 112);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(422, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(990, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_StatusOutput);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.btn_stoppoc);
            this.Controls.Add(this.btn_startpoc);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(1016, 579);
            this.MinimumSize = new System.Drawing.Size(1016, 579);
            this.Name = "Form1";
            this.Text = "Azure Estate Controller";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startpoc;
        private System.Windows.Forms.Button btn_stoppoc;
        private System.Windows.Forms.Label txt_status;
        private System.Windows.Forms.Label txt_StatusOutput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

