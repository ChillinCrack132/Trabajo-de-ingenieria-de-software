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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //public static int total = 0;
        int orden = 0;
        public int TotalArticulos = 0;
        public int hosomakis = 0;
        public int gunkans = 0;
        public int uramaki = 0;
        public int maki = 0;
        public int pescado = 0;
        public int verduras = 0;
        public int maitake = 0;
        public int tonkotsu = 0;
        public int miso = 0;
        public  int shoyu = 0;
        public int shio = 0;
        public int clasico = 0;
        public int asado = 0;
        public int limonada = 0;
        public int matcha = 0;
        public int agua = 0;
        public int sodas = 0;
        public static double totalTicket = 0.00;
        public int nigiris = 0;
        public bool c;

        private void button1_Click(object sender, EventArgs e)
        {
            generarTiket();
            orden++;
        }

        private void ActualizarTicket(bool c, double precio)
        {
            if (c == true)
            {
                totalTicket += precio;
            }
            else
            {
                totalTicket -= precio;
            }

        }

        public void generarTiket()
        {

            StringBuilder sb = new StringBuilder();

            foreach (string item in listBox1.Items)
            {
                sb.Append(item+ Environment.NewLine);
            }
            string hora = DateTime.Now.ToShortTimeString();
            string fecha = DateTime.Now.ToShortDateString();
            MessageBox.Show(
                "Restaurante JAPAN"+
                "\nNUMERO DE ORDEN: #" + orden+
                "\n" + fecha+
                "\n" + hora +
                "\n" + sb.ToString() +
                "\nTOTAL: $" + totalTicket + " MXN" +
                "\nGracias por su compra",
                "TICKET DE COMPRA",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            TotalArticulos = nigiris = hosomakis = gunkans = uramaki = maki = pescado = verduras = maitake = tonkotsu = miso = shoyu = shio = clasico = asado = limonada = matcha = agua = sodas = 0;
            totalTicket = 0;
            listBox1.Items.Clear();
            sb.Append("PRODUCTOS DE LA ORDEN:");
        }
        public bool Bool(bool x) 
        {
            if (x==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
        public void Anotar(bool c, int producto, string texto)
        {
            if (c == true && producto >= 1)
            {
                TotalArticulos++;
                listBox1.Items.Add(texto);
            }
            else
            {
                TotalArticulos--;
                listBox1.Items.Remove(texto);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                return;
            }   
            else
            {
                Form1 frmAcceso = new Form1();
                this.Hide();
                frmAcceso.Show();
            }
             
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioNigiri = 100.00;

            if (e.Button == MouseButtons.Left)
            {
                nigiris++;
                Anotar(true, nigiris, lbl1.Text);
                ActualizarTicket(c=true, PrecioNigiri);
            }
            else if (e.Button == MouseButtons.Right)
            {
                nigiris--;
                Anotar(false, nigiris, lbl1.Text);
                ActualizarTicket(c = false, PrecioNigiri);
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioHosomaki = 120.00;
            if (e.Button == MouseButtons.Left)
            {
                hosomakis++;
                Anotar(true, hosomakis, lbl2.Text);
                ActualizarTicket(c= true, PrecioHosomaki);
            }
            else if (e.Button == MouseButtons.Right)
            {
                hosomakis--;
                Anotar(false, hosomakis, lbl2.Text);
                ActualizarTicket(c = false, PrecioHosomaki);
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioGunkans = 120.00;
            if (e.Button == MouseButtons.Left)
            {
                gunkans++;
                Anotar(true, gunkans, lbl3.Text);
                ActualizarTicket(c = true, PrecioGunkans);
            }
            else if (e.Button == MouseButtons.Right)
            {
                gunkans--;
                Anotar(false, gunkans, lbl3.Text);
                ActualizarTicket(c = false, PrecioGunkans);
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioUramaki = 150.00;
            if (e.Button == MouseButtons.Left)
            {
                uramaki++;
                Anotar(true, uramaki,label2.Text);
                ActualizarTicket(c = true, PrecioUramaki);
            }
            else if (e.Button == MouseButtons.Right)
            {
                uramaki--;
                Anotar(false, uramaki, label2.Text);
                ActualizarTicket(c = false, PrecioUramaki);
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioMaki = 140.00;
            if (e.Button == MouseButtons.Left)
            {
                maki++;
                Anotar(true, gunkans, label3.Text);
                ActualizarTicket(c = true, PrecioMaki);
            }
            else if (e.Button == MouseButtons.Right)
            {
                maki--;
                Anotar(false, gunkans, label3.Text);
                ActualizarTicket(c = false, PrecioMaki);
            }
        }


        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioPescado = 140.00;
            if (e.Button == MouseButtons.Left)
            {
                pescado++;
                Anotar(true, pescado, label6.Text);
                ActualizarTicket(c = true, PrecioPescado);
            }
            else if (e.Button == MouseButtons.Right)
            {
                pescado--;
                Anotar(false, pescado, label6.Text);
                ActualizarTicket(c = false, PrecioPescado);
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioVerduras = 140.00;
            if (e.Button == MouseButtons.Left)
            {
                verduras++;
                Anotar(true, verduras, label5.Text);
                ActualizarTicket(c = true, PrecioVerduras);
            }
            else if (e.Button == MouseButtons.Right)
            {
                verduras--;
                Anotar(false, verduras, label5.Text);
                ActualizarTicket(c = false, PrecioVerduras);
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioMaitake = 60.00;
            if (e.Button == MouseButtons.Left)
            {
                maitake++;
                Anotar(true, maitake, label4.Text);
                ActualizarTicket(c = true, PrecioMaitake);
            }
            else if (e.Button == MouseButtons.Right)
            {
                maitake--;
                Anotar(false, maitake, label4.Text);
                ActualizarTicket(c = false, PrecioMaitake);
            }
        }

        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            double Preciotonkotsu = 160.00;
            if (e.Button == MouseButtons.Left)
            {
                tonkotsu++;
                Anotar(true, tonkotsu, rlbl1.Text);
                ActualizarTicket(c = true, Preciotonkotsu);
            }
            else if (e.Button == MouseButtons.Right)
            {
                tonkotsu--;
                Anotar(false, tonkotsu, rlbl1.Text);
                ActualizarTicket(c = false, Preciotonkotsu);
            }
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioMiso = 110.00;
            if (e.Button == MouseButtons.Left)
            {
                miso++;
                Anotar(true, miso, rlbl2.Text);
                ActualizarTicket(c = true, PrecioMiso);
            }
            else if (e.Button == MouseButtons.Right)
            {
                miso--;
                Anotar(false, miso, rlbl2.Text);
                ActualizarTicket(c = false, PrecioMiso);
            }
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioShoyu = 100.00;
            if (e.Button == MouseButtons.Left)
            {
                shoyu++;
                Anotar(true, shoyu, rlbl3.Text);
                ActualizarTicket(c = true, PrecioShoyu);
            }
            else if (e.Button == MouseButtons.Right)
            {
                shoyu--;
                Anotar(false, shoyu, rlbl3.Text);
                ActualizarTicket(c = false, PrecioShoyu);
            }
        }

        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioShio = 130.00;
            if (e.Button == MouseButtons.Left)
            {
                shio++;
                Anotar(true, shio, rlbl4.Text);
                ActualizarTicket(c = true, PrecioShio);
            }
            else if (e.Button == MouseButtons.Right)
            {
                shio--;
                Anotar(false, shio, rlbl4.Text);
                ActualizarTicket(c = false, PrecioShio);
            }
        }

        private void button16_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioClasico = 40.00;
            if (e.Button == MouseButtons.Left)
            {
                clasico++;
                Anotar(true, clasico, olbl1.Text);
                ActualizarTicket(c = true, PrecioClasico);
            }
            else if (e.Button == MouseButtons.Right)
            {
                clasico--;
                Anotar(false, clasico, olbl1.Text);
                ActualizarTicket(c = false, PrecioClasico);
            }
        }

        private void button15_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioAsado = 65.00;
            if (e.Button == MouseButtons.Left)
            {
                asado++;
                Anotar(true, clasico, olbl2.Text);
                ActualizarTicket(c = true, PrecioAsado);
            }
            else if (e.Button == MouseButtons.Right)
            {
                asado--;
                Anotar(false, clasico, olbl2.Text);
                ActualizarTicket(c = false, PrecioAsado);
            }
        }

        private void button20_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioLimonada = 30.00;
            if (e.Button == MouseButtons.Left)
            {
                limonada++;
                Anotar(true, limonada, BLBL1.Text);
                ActualizarTicket(c = true, PrecioLimonada);
            }
            else if (e.Button == MouseButtons.Right)
            {
                limonada--;
                Anotar(false, limonada, BLBL1.Text);
                ActualizarTicket(c = false, PrecioLimonada);
            }
        }

        private void button18_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioMatcha = 50.00;
            if (e.Button == MouseButtons.Left)
            {
                matcha++;
                Anotar(true, matcha, BLBL2.Text);
                ActualizarTicket(c = true, PrecioMatcha);
            }
            else if (e.Button == MouseButtons.Right)
            {
                matcha--;
                Anotar(false, matcha, BLBL2.Text);
                ActualizarTicket(c = false, PrecioMatcha);
            }
        }

        private void button19_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioAgua = 30.00;
            if (e.Button == MouseButtons.Left)
            {
                agua++;
                Anotar(true, agua, BLBL3.Text);
                ActualizarTicket(c = true, PrecioAgua);
            }
            else if (e.Button == MouseButtons.Right)
            {
                agua--;
                Anotar(false, agua, BLBL3.Text);
                ActualizarTicket(c = false, PrecioAgua);
            }
        }

        private void button17_MouseDown(object sender, MouseEventArgs e)
        {
            double PrecioSodas = 30.00;
            if (e.Button == MouseButtons.Left)
            {
                sodas++;
                Anotar(true, sodas, BLBL4.Text);
                ActualizarTicket(c = true, PrecioSodas);
            }
            else if (e.Button == MouseButtons.Right)
            {
                sodas--;
                Anotar(false, sodas, BLBL4.Text);
                ActualizarTicket(c = false, PrecioSodas);
            }
        }
    }
}
