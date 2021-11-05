using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using berclean.Entities;
using berclean.GUILayer;
using berclean.GUILayer.ABMC_s;

namespace berclean
{
    public partial class frmPrincipal : Form
    {
        UsuarioE usuarioActual;
        private Form formHijoActual;
        public frmPrincipal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            habilitar(false);
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            pnlGestionDatos.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void habilitar(bool x)
        {
            btnGestionarDatos.Enabled = btnHome.Enabled = x;
        }
        private void btnMax_Click(object sender, EventArgs e)
        { 
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (formHijoActual != null)
            {
                formHijoActual.Close();
            }
            else
            {
                //
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            usuarioActual = fl.Usr;
            if (usuarioActual != null)
            {
                btnIniciarSesion.Text = usuarioActual.Nombre;
                btnIniciarSesion.Enabled = false;
                habilitar(true);

            }

            fl.Dispose();
        }

        private void pnlInicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGestionarDatos_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlGestionDatos);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new frmUsuario());
        }
        private void abrirFormHijo(Form formHijo)
        {
            if (formHijoActual != null)
            {
                //Para abrir un solo form
                formHijoActual.Close();
            }
            formHijoActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            formHijo.AutoSize = true;
            pnlInicio.Controls.Add(formHijo);
            pnlInicio.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
