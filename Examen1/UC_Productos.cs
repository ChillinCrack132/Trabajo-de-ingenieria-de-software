using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class UC_Productos : UserControl
    {
        public event EventHandler onSelect = null;
        public UC_Productos()
        {
            InitializeComponent();
        }

        public int id { get; set; }
        public int PrecioProducto { get; set; }

        public string CategoríaProducto { get; set; }

        public string NombreProducto
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public Image ImagenProducto
        {
            get { return NombreImagen.Image; }
            set { NombreImagen.Image = value; }
        }

        private void NombreImagen_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, EventArgs.Empty);
        }
    }
}
