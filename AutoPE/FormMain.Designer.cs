
namespace AutoPE
{
    partial class FormMain
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
            this.bGo = new System.Windows.Forms.Button();
            this.peControl1 = new AutoPE.UI.PEControl();
            this.fileControl1 = new AutoPE.UI.FileControl();
            this.volumeControl1 = new AutoPE.UI.VolumeControl();
            this.nicControl1 = new AutoPE.UI.NICControl();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGo
            // 
            this.bGo.Location = new System.Drawing.Point(774, 575);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(75, 23);
            this.bGo.TabIndex = 15;
            this.bGo.Text = "Go";
            this.bGo.UseVisualStyleBackColor = true;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // peControl1
            // 
            this.peControl1.Location = new System.Drawing.Point(12, 285);
            this.peControl1.Name = "peControl1";
            this.peControl1.Size = new System.Drawing.Size(391, 313);
            this.peControl1.TabIndex = 16;
            // 
            // fileControl1
            // 
            this.fileControl1.Location = new System.Drawing.Point(409, 139);
            this.fileControl1.Name = "fileControl1";
            this.fileControl1.Size = new System.Drawing.Size(447, 332);
            this.fileControl1.TabIndex = 13;
            // 
            // volumeControl1
            // 
            this.volumeControl1.Location = new System.Drawing.Point(312, 25);
            this.volumeControl1.Name = "volumeControl1";
            this.volumeControl1.Size = new System.Drawing.Size(487, 108);
            this.volumeControl1.TabIndex = 12;
            // 
            // nicControl1
            // 
            this.nicControl1.Location = new System.Drawing.Point(12, 25);
            this.nicControl1.Name = "nicControl1";
            this.nicControl1.Size = new System.Drawing.Size(294, 254);
            this.nicControl1.TabIndex = 11;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(693, 575);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 17;
            this.bSave.Text = "保存";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 642);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.peControl1);
            this.Controls.Add(this.bGo);
            this.Controls.Add(this.fileControl1);
            this.Controls.Add(this.volumeControl1);
            this.Controls.Add(this.nicControl1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UI.NICControl nicControl1;
        private UI.VolumeControl volumeControl1;
        private UI.FileControl fileControl1;
        private System.Windows.Forms.Button bGo;
        private UI.PEControl peControl1;
        private System.Windows.Forms.Button bSave;
    }
}