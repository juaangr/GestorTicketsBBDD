﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GestorTicketsBBDD
{
    public partial class GestorTicketsBBDD : MaterialForm
    {
        // public event EventHandler EventoLogin;


        public GestorTicketsBBDD()
        {
            InitializeComponent();

            // configuración del materialSkin
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT; // ponemos el tema en oscuro por predet
            skinManager.ColorScheme = new ColorScheme(
                Primary.Purple800,
                Primary.Purple900,
                Primary.Red50,
                Accent.DeepPurple200,
                TextShade.WHITE);

        }

        private void BtnIniSesion_Click(object sender, EventArgs e)
        {
            InicioSesion inicioSesionForm = new InicioSesion();
            inicioSesionForm.ShowDialog();
        }

        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            CrearCuenta crearCuentaForm = new CrearCuenta();
            crearCuentaForm.ShowDialog();
        }

        private void GestorTicketsBBDD_Load(object sender, EventArgs e)
        {

        }

        private void LabelPrincipal_Click(object sender, EventArgs e)
        {

        }
    }
}
