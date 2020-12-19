using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadixS
{

    public partial class RadixS : Form
    {
        
        public RadixS()
        {
            InitializeComponent();
            Random aleatorio;
            aleatorio = new Random();
        }
        int[] v;
        int valor = 0;
        int i = 0;      
      
      
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            try
            {
                v = new int[(int.Parse(txtTamaño.Text))];
                ltbDesordenado.Items.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("inserte un numero");
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                valor = int.Parse(txtValor.Text);
                v[i++] = valor;
                ltbDesordenado.Items.Add(v[i - 1]);
                txtValor.Clear();
                txtValor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo se aceptan numeros", "Error");
            }
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            ltbDesordenado.Items.Clear();
            Random rdm = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rdm.Next(100000);
                ltbDesordenado.Items.Add(v[i]);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            RadixCS.Radix(v);
            for (int i = 0; i < v.Length; i++)
            {
                ltbOrdenados.Items.Add(v[i]);
            }
        }
    }
}
