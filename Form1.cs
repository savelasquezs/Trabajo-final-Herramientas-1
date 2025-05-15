using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_final_Herramientas_1
{
    public partial class Form1: Form
    {
        private Servicios Admin;
        private Tienda tienda;
        public Form1()
        {
            InitializeComponent();

            this.Admin = new Servicios();
            this.tienda = Admin.tienda;
            List<Libro> catalogo = tienda.Catalogo;
            foreach (Libro libro in catalogo)
            {
                listBox1.Items.Add(libro.Titulo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Transaccion> transacciones= new List<Transaccion>();
            Libro libro = new Libro(isbn.Text, titulo.Text, ((int)precio_compra.Value), ((int)precio_venta.Value), (int)cant_inicial.Value, transacciones);
            Admin.registrarLibro(libro);
            listBox1.Items.Add(libro.Titulo);
            MessageBox.Show("El libro fue guardado exitosamente");
            isbn.ResetText();
            titulo.ResetText();
            precio_compra.ResetText();
            precio_venta.ResetText();
            cant_inicial.ResetText();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void isbn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
