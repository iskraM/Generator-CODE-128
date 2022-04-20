
namespace WindowsFormsApp1
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pbCodes = new System.Windows.Forms.PictureBox();
            this.rtbRawCodes = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerate.Location = new System.Drawing.Point(10, 544);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(759, 45);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generiraj";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pbCodes
            // 
            this.pbCodes.BackColor = System.Drawing.Color.White;
            this.pbCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCodes.Location = new System.Drawing.Point(0, 0);
            this.pbCodes.Name = "pbCodes";
            this.pbCodes.Size = new System.Drawing.Size(440, 534);
            this.pbCodes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCodes.TabIndex = 2;
            this.pbCodes.TabStop = false;
            // 
            // rtbRawCodes
            // 
            this.rtbRawCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRawCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbRawCodes.Location = new System.Drawing.Point(0, 0);
            this.rtbRawCodes.Name = "rtbRawCodes";
            this.rtbRawCodes.Size = new System.Drawing.Size(315, 534);
            this.rtbRawCodes.TabIndex = 3;
            this.rtbRawCodes.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtbRawCodes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.pbCodes);
            this.splitContainer1.Size = new System.Drawing.Size(759, 534);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 599);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Code 128 generator";
            ((System.ComponentModel.ISupportInitialize)(this.pbCodes)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox pbCodes;
        private System.Windows.Forms.RichTextBox rtbRawCodes;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

