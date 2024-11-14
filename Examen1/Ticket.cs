using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Examen1
{
    public partial class FormTicket : Form
    {
        public FormTicket(ListBox listBox1, double total)
        {
            InitializeComponent();
            DisplayTicket(listBox1, total);
        }

        private void DisplayTicket(ListBox listBox1, double total)
        {
            listBoxTicket.Items.Clear();
            foreach (var item in listBox1.Items)
            {
                listBoxTicket.Items.Add(item);
            }

            double ivaRate = 0.16;

            double subtotal = total / (1 + ivaRate);

            double iva = total - subtotal;

            label3.Text = ("$" + subtotal.ToString("F2"));
            label4.Text = ("$"+iva.ToString("F2"));
            label6.Text = ("$" + total.ToString("F2"));

            AdjustFormHeight(listBox1.Items.Count);
        }


        private void AdjustFormHeight(int itemCount)
        {
            /*int MinFormHeight = 2000; // Altura mínima del formulario
            int ItemHeight = 20;     // Altura estimada de cada ítem en el ListBox
            int PaddingHeight = 80;  // Espacio adicional

            int newHeight = MinFormHeight;

            if (itemCount > 0)
            {
                newHeight = itemCount * ItemHeight + PaddingHeight;
            }

            this.Height = newHeight;*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
