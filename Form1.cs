using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeLogica;

namespace CapaDePresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListarClientes();
        }

        public ClientesLogica Cliente = new ClientesLogica();
        
        public void ListarClientes()
        {
            dataGridViewClientes.DataSource = Cliente.ListarClientes();
        }

        private void buttonInsertarCliente_Click(object sender, EventArgs e)
        {
            var identificacion = textBoxIdentificacion.Text;
            var nombres = textBoxNombre.Text;
            var apellidos = textBoxApellidos.Text;
            var direccion = textBoxDireccion.Text;
            var telefono = textBoxTelefono.Text;
            var fecha = dateTimePickerFecha.Value;

            var mensaje = Cliente.InsertarCliente(identificacion, nombres, apellidos, direccion, telefono, fecha);

            MessageBox.Show(mensaje);
            ListarClientes();
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            var identifacion = textBoxIdentificacion.Text;

            var mensaje = Cliente.EliminarCliente(identifacion);

            MessageBox.Show(mensaje);
            ListarClientes();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
