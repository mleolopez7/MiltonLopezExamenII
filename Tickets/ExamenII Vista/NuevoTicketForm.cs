using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace ExamenII_Vista
{
    public partial class NuevoTicketForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public NuevoTicketForm()
        {
            InitializeComponent();
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            FechaTimePicker.Enabled = true;
            UsuarioTextBox.Enabled = true;
            ClienteTextBox.Enabled = true;
            SoporteComboBox.Enabled = true;
            SolicitudTextBox.Enabled = true;
            RespuestaTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            ImpuestoTextBox.Enabled = true;
            DescuentoTextBox.Enabled = true;
            TotalTextBox.Enabled = true;
            CalcularButton.Enabled = true;
            SalirButton.Enabled = true;
            CancelarButton.Enabled = true;
        }

        private void DeshabilitarControles()
        {
            FechaTimePicker.Enabled = false;
            UsuarioTextBox.Enabled = false;
            ClienteTextBox.Enabled = false;
            SoporteComboBox.Enabled = false;
            SolicitudTextBox.Enabled = false;
            RespuestaTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ImpuestoTextBox.Enabled = false;
            DescuentoTextBox.Enabled = false;
            TotalTextBox.Enabled = false;
            CalcularButton.Enabled = false;
            SalirButton.Enabled = false;
            AgregarButton.Enabled = false;
            CancelarButton.Enabled = false;
        }

        private void LimpiarControles()
        {
            FechaTimePicker.Enabled = false;
            UsuarioTextBox.Clear();
            ClienteTextBox.Clear();
            SoporteComboBox.Text = "";
            SolicitudTextBox.Clear();
            RespuestaTextBox.Clear();
            PrecioTextBox.Clear();
            ImpuestoTextBox.Clear();
            DescuentoTextBox.Clear();
            TotalTextBox.Clear();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsuarioTextBox.Text))
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese un usuario");
                UsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(ClienteTextBox.Text))
            {
                errorProvider1.SetError(ClienteTextBox, "Ingrese un cliente");
                ClienteTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(SoporteComboBox.Text))
            {
                errorProvider1.SetError(SoporteComboBox, "Seleccione un tipo de soporte");
                SoporteComboBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(SolicitudTextBox.Text))
            {
                errorProvider1.SetError(SolicitudTextBox, "Describa la solicitud");
                SolicitudTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(RespuestaTextBox.Text))
            {
                errorProvider1.SetError(RespuestaTextBox, "Describa la respuesta");
                RespuestaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            Ticket ticket= new Ticket();

            //ticket.FechaCreacion;
            ticket.Usuario= UsuarioTextBox.Text;
            ticket.Cliente= ClienteTextBox.Text;
            ticket.TipoSoporte = SoporteComboBox.Text;
            ticket.DescripcionSolicitud= SolicitudTextBox.Text;
            ticket.DescripcionRespuesta= RespuestaTextBox.Text;
            ticket.Precio= Convert.ToDecimal(PrecioTextBox.Text);
            ticket.Impuesto = Convert.ToDecimal(ImpuestoTextBox.Text);
            ticket.Descuento = Convert.ToDecimal(DescuentoTextBox.Text);
            ticket.Total = Convert.ToDecimal(TotalTextBox.Text);

            //Insertar a la BD





        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            AgregarButton.Enabled = true;

            if (string.IsNullOrEmpty(PrecioTextBox.Text))
            {
                errorProvider1.SetError(PrecioTextBox, "Ingrese el precio de la solicitud");
                PrecioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (!string.IsNullOrWhiteSpace(PrecioTextBox.Text))
            {
                decimal precio = decimal.Parse(PrecioTextBox.Text);
                decimal impuesto = precio * 0.15m;
                ImpuestoTextBox.Text = impuesto.ToString();

                //decimal descuento = 0;
                //if (SoporteComboBox.SelectedValue.ToString() == "Celulares")
                //{
                //    descuento = precio * 0.05m;
                //DescuentoTextBox.Text = descuento.ToString();
                //}
                //else if (SoporteComboBox.SelectedValue.ToString() == "Equipo de Computo")
                //{
                //    descuento = precio * 0.07m;
                //DescuentoTextBox.Text = descuento.ToString();
                //}

                decimal total = precio + impuesto; //- descuento;
                TotalTextBox.Text = total.ToString();
            }
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
