namespace Lakopark_inform
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
            this.panelEpuletek = new System.Windows.Forms.Panel();
            this.pictureBoxNevado = new System.Windows.Forms.PictureBox();
            this.buttonJobbnyil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNevado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEpuletek
            // 
            this.panelEpuletek.Location = new System.Drawing.Point(157, 78);
            this.panelEpuletek.Name = "panelEpuletek";
            this.panelEpuletek.Size = new System.Drawing.Size(200, 100);
            this.panelEpuletek.TabIndex = 0;
            // 
            // pictureBoxNevado
            // 
            this.pictureBoxNevado.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxNevado.Name = "pictureBoxNevado";
            this.pictureBoxNevado.Size = new System.Drawing.Size(100, 166);
            this.pictureBoxNevado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNevado.TabIndex = 1;
            this.pictureBoxNevado.TabStop = false;
            // 
            // buttonJobbnyil
            // 
            this.buttonJobbnyil.BackgroundImage = global::Lakopark_inform.Properties.Resources.jobbnyil;
            this.buttonJobbnyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonJobbnyil.Location = new System.Drawing.Point(674, 359);
            this.buttonJobbnyil.Name = "buttonJobbnyil";
            this.buttonJobbnyil.Size = new System.Drawing.Size(90, 55);
            this.buttonJobbnyil.TabIndex = 2;
            this.buttonJobbnyil.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Lakopark_inform.Properties.Resources.balnyil;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(66, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 55);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonJobbnyil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBoxNevado);
            this.Controls.Add(this.panelEpuletek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNevado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEpuletek;
        private System.Windows.Forms.PictureBox pictureBoxNevado;
        private System.Windows.Forms.Button buttonJobbnyil;
        private System.Windows.Forms.Button button2;
    }
}

