
namespace PictureBox
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.stsAddreesBar = new System.Windows.Forms.StatusStrip();
            this.tssPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.stsAddreesBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(0, 41);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(1303, 550);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(12, 12);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(102, 23);
            this.btOpen.TabIndex = 1;
            this.btOpen.Text = "Otwórz Zdjęcie";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(120, 12);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 2;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Visible = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // stsAddreesBar
            // 
            this.stsAddreesBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssPath});
            this.stsAddreesBar.Location = new System.Drawing.Point(0, 594);
            this.stsAddreesBar.Name = "stsAddreesBar";
            this.stsAddreesBar.Size = new System.Drawing.Size(1303, 22);
            this.stsAddreesBar.TabIndex = 3;
            this.stsAddreesBar.Text = "Test";
            // 
            // tssPath
            // 
            this.tssPath.Name = "tssPath";
            this.tssPath.Size = new System.Drawing.Size(49, 17);
            this.tssPath.Text = "Ścieżka: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 616);
            this.Controls.Add(this.stsAddreesBar);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.pbImage);
            this.Name = "Form1";
            this.Text = "PictureBox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.stsAddreesBar.ResumeLayout(false);
            this.stsAddreesBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.StatusStrip stsAddreesBar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel tssPath;
    }
}

