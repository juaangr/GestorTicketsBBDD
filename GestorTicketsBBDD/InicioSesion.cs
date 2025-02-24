﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace GestorTicketsBBDD
{
    public partial class InicioSesion : MaterialForm
    {
        public InicioSesion()
        {
            InitializeComponent();
            
            // configuración del materialSkin - copiado
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
    }
}
