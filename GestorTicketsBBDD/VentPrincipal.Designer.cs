namespace GestorTicketsBBDD
{
    partial class VentPrincipal
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
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.BtnTickets = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLateral
            // 
            this.MenuLateral.Controls.Add(this.BtnTickets);
            this.MenuLateral.Controls.Add(this.materialButton2);
            this.MenuLateral.Controls.Add(this.pictureBox1);
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.Location = new System.Drawing.Point(3, 64);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(171, 470);
            this.MenuLateral.TabIndex = 0;
            // 
            // BtnTickets
            // 
            this.BtnTickets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnTickets.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnTickets.Depth = 0;
            this.BtnTickets.HighEmphasis = true;
            this.BtnTickets.Icon = null;
            this.BtnTickets.Location = new System.Drawing.Point(31, 199);
            this.BtnTickets.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnTickets.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnTickets.Name = "BtnTickets";
            this.BtnTickets.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnTickets.Size = new System.Drawing.Size(79, 36);
            this.BtnTickets.TabIndex = 3;
            this.BtnTickets.Text = "Tickets";
            this.BtnTickets.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnTickets.UseAccentColor = false;
            this.BtnTickets.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(31, 151);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(91, 36);
            this.materialButton2.TabIndex = 2;
            this.materialButton2.Text = "Usuarios";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GestorTicketsBBDD.Properties.Resources.LogoGestorTickets;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(174, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 470);
            this.panel1.TabIndex = 1;
            // 
            // VentPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuLateral);
            this.Name = "VentPrincipal";
            this.Text = "VentPrincipal";
            this.MenuLateral.ResumeLayout(false);
            this.MenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton BtnTickets;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.Panel panel1;
    }
}