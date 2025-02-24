namespace GestorTicketsBBDD
{
    partial class GestorTicketsBBDD
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnIniSesion = new MaterialSkin.Controls.MaterialButton();
            this.BtnCrearCuenta = new MaterialSkin.Controls.MaterialButton();
            this.LabelPrincipal = new MaterialSkin.Controls.MaterialLabel();
            this.picTicketLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTicketLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIniSesion
            // 
            this.BtnIniSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnIniSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnIniSesion.Depth = 0;
            this.BtnIniSesion.HighEmphasis = true;
            this.BtnIniSesion.Icon = null;
            this.BtnIniSesion.Location = new System.Drawing.Point(119, 226);
            this.BtnIniSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnIniSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnIniSesion.Name = "BtnIniSesion";
            this.BtnIniSesion.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnIniSesion.Size = new System.Drawing.Size(128, 36);
            this.BtnIniSesion.TabIndex = 0;
            this.BtnIniSesion.Text = "Iniciar Sesión";
            this.BtnIniSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnIniSesion.UseAccentColor = false;
            this.BtnIniSesion.UseVisualStyleBackColor = true;
            this.BtnIniSesion.Click += new System.EventHandler(this.BtnIniSesion_Click);
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCrearCuenta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnCrearCuenta.Depth = 0;
            this.BtnCrearCuenta.HighEmphasis = true;
            this.BtnCrearCuenta.Icon = null;
            this.BtnCrearCuenta.Location = new System.Drawing.Point(119, 322);
            this.BtnCrearCuenta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCrearCuenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnCrearCuenta.Size = new System.Drawing.Size(128, 36);
            this.BtnCrearCuenta.TabIndex = 1;
            this.BtnCrearCuenta.Text = "Crear Cuenta";
            this.BtnCrearCuenta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnCrearCuenta.UseAccentColor = false;
            this.BtnCrearCuenta.UseVisualStyleBackColor = true;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.BtnCrearCuenta_Click);
            // 
            // LabelPrincipal
            // 
            this.LabelPrincipal.AutoSize = true;
            this.LabelPrincipal.Depth = 0;
            this.LabelPrincipal.Font = new System.Drawing.Font("Gentium Basic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrincipal.Location = new System.Drawing.Point(122, 73);
            this.LabelPrincipal.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelPrincipal.Name = "LabelPrincipal";
            this.LabelPrincipal.Size = new System.Drawing.Size(116, 19);
            this.LabelPrincipal.TabIndex = 2;
            this.LabelPrincipal.Text = "Ticket Company";
            this.LabelPrincipal.Click += new System.EventHandler(this.LabelPrincipal_Click);
            // 
            // picTicketLogo
            // 
            this.picTicketLogo.Image = global::GestorTicketsBBDD.Properties.Resources.IconoTicket;
            this.picTicketLogo.Location = new System.Drawing.Point(329, 408);
            this.picTicketLogo.Name = "picTicketLogo";
            this.picTicketLogo.Size = new System.Drawing.Size(40, 36);
            this.picTicketLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTicketLogo.TabIndex = 3;
            this.picTicketLogo.TabStop = false;
            // 
            // GestorTicketsBBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.picTicketLogo);
            this.Controls.Add(this.LabelPrincipal);
            this.Controls.Add(this.BtnCrearCuenta);
            this.Controls.Add(this.BtnIniSesion);
            this.Name = "GestorTicketsBBDD";
            this.Text = "Gestor Tickets";
            this.Load += new System.EventHandler(this.GestorTicketsBBDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTicketLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton BtnIniSesion;
        private MaterialSkin.Controls.MaterialButton BtnCrearCuenta;
        private MaterialSkin.Controls.MaterialLabel LabelPrincipal;
        private System.Windows.Forms.PictureBox picTicketLogo;
    }
}

