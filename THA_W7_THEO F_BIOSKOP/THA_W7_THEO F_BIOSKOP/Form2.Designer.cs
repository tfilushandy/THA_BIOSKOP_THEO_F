namespace THA_W7_THEO_F_BIOSKOP
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.daftarposterlist = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneltime = new System.Windows.Forms.Panel();
            this.panelseat = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // daftarposterlist
            // 
            this.daftarposterlist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("daftarposterlist.ImageStream")));
            this.daftarposterlist.TransparentColor = System.Drawing.Color.Transparent;
            this.daftarposterlist.Images.SetKeyName(0, "ANT MAN");
            this.daftarposterlist.Images.SetKeyName(1, "CEK TOKO SEBELAH");
            this.daftarposterlist.Images.SetKeyName(2, "22 MENIT");
            this.daftarposterlist.Images.SetKeyName(3, "HARRY POTTER");
            this.daftarposterlist.Images.SetKeyName(4, "JUST MOM");
            this.daftarposterlist.Images.SetKeyName(5, "KELUARGA CEMARA");
            this.daftarposterlist.Images.SetKeyName(6, "MENCURI RADEN SALEH");
            this.daftarposterlist.Images.SetKeyName(7, "PULAU PLASTIK");
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(36, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 304);
            this.panel1.TabIndex = 1;
            // 
            // paneltime
            // 
            this.paneltime.Location = new System.Drawing.Point(36, 382);
            this.paneltime.Name = "paneltime";
            this.paneltime.Size = new System.Drawing.Size(1280, 284);
            this.paneltime.TabIndex = 2;
            this.paneltime.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltime_Paint);
            // 
            // panelseat
            // 
            this.panelseat.Location = new System.Drawing.Point(36, 60);
            this.panelseat.Name = "panelseat";
            this.panelseat.Size = new System.Drawing.Size(1280, 677);
            this.panelseat.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1345, 772);
            this.Controls.Add(this.panelseat);
            this.Controls.Add(this.paneltime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList daftarposterlist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel paneltime;
        private System.Windows.Forms.Panel panelseat;
    }
}