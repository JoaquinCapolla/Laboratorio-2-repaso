using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_2_repaso
{
    public partial class Form1 : Form
    {
        List<DatosAutos> datosAutos = new List<DatosAutos>();
        List<DatosAlquiler> datosAlquiler = new List<DatosAlquiler>();
        public Form1()
        {
            InitializeComponent();
            String appPath = Path.GetDirectoryName(Application.ExecutablePath);
            StreamWriter writer1 = new StreamWriter(appPath + "\\DatosAutos.txt", true);
            writer1.Close();
            Leer();
            Mostrar();
        }
        private void Guardar()
        {
            File.Delete("DatosAutos.txt");
            String appPath = Path.GetDirectoryName(Application.ExecutablePath);
            StreamWriter writer1 = new StreamWriter(appPath + "\\DatosAutos.txt", true);

            for (int i = 0; i < datosAutos.Count; i++)
            {
                writer1.WriteLine(datosAutos[i].Placa);
                writer1.WriteLine(datosAutos[i].Marca);
                writer1.WriteLine(datosAutos[i].Modelo);
                writer1.WriteLine(datosAutos[i].Color);
                writer1.WriteLine(datosAutos[i].Precio);
            }
            writer1.Close();
        }
        private void Leer()
        {
            datosAutos.Clear();
            String appPath = Path.GetDirectoryName(Application.ExecutablePath);
            StreamReader reader1 = new StreamReader(appPath + "\\DatosAutos.txt");
            while (reader1.Peek() > -1)
            {
                DatosAutos datosautosTemp = new DatosAutos();

                datosautosTemp.Placa = reader1.ReadLine();
                datosautosTemp.Marca = reader1.ReadLine();
                datosautosTemp.Modelo = reader1.ReadLine();
                datosautosTemp.Color = reader1.ReadLine();
                datosautosTemp.Precio = Convert.ToInt32(reader1.ReadLine());
                datosAutos.Add(datosautosTemp);
            }
            reader1.Close();
        }
        private void Leer1()
        {
            datosAlquiler.Clear();
            String appPath = Path.GetDirectoryName(Application.ExecutablePath);
            StreamReader reader1 = new StreamReader(appPath + "\\DatosAlquileres.txt");
            while (reader1.Peek() > -1)
            {
                DatosAlquiler datosAlquilerTemp = new DatosAlquiler();

                datosAlquilerTemp.Placa = reader1.ReadLine();
                datosAlquilerTemp.Marca = reader1.ReadLine();
                datosAlquilerTemp.Modelo = reader1.ReadLine();
                datosAlquilerTemp.Nit = reader1.ReadLine();
                datosAlquilerTemp.Nombre = reader1.ReadLine();
                datosAlquilerTemp.Direccion = reader1.ReadLine();
                datosAlquilerTemp.Kmrecorridos = float.Parse(reader1.ReadLine());
                datosAlquilerTemp.Tarifa = float.Parse(reader1.ReadLine());
                datosAlquilerTemp.Fechaalquiler = Convert.ToDateTime(reader1.ReadLine());
                datosAlquilerTemp.Fechadevolucion = Convert.ToDateTime(reader1.ReadLine());
                datosAlquiler.Add(datosAlquilerTemp);
            }
            reader1.Close();
        }
        private void Mostrar()
        {
            dataGridView_vehiculos.DataSource = null;
            dataGridView_vehiculos.DataSource = datosAutos;
            dataGridView_vehiculos.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_marca1_Click(object sender, EventArgs e)
        {

        }

        private void btn_alquilar_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            frm.Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                DatosAutos datosAutostemp = new DatosAutos();
                datosAutostemp.Placa = txt_placa.Text;
                datosAutostemp.Marca = txt_marca.Text;
                datosAutostemp.Modelo = txt_modelo.Text;
                datosAutostemp.Color = txt_color.Text;
                datosAutostemp.Precio = Convert.ToInt32(txt_tarifa.Text);
                txt_placa.Text = "";
                txt_marca.Text = "";
                txt_modelo.Text = "";
                txt_color.Text = "";
                txt_tarifa.Text = "";
                datosAutos.Add(datosAutostemp);
                Guardar();
                Leer();
                Mostrar();
            }
            catch
            {
                MessageBox.Show("No se ingresaron correctamente los datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Leer1();
            string tempa = "";
            string tempb = "";
            int a = 0;
            int b = 0;
            for (int i = 0; i < datosAlquiler.Count-1; i++)
            {
                a = Convert.ToInt32(datosAlquiler[i].Kmrecorridos);
                b = 0;
                if (a > Convert.ToInt32(datosAlquiler[i + 1].Kmrecorridos))
                {
                    b = a;
                }
                else
                {
                    b = Convert.ToInt32(datosAlquiler[i + 1].Kmrecorridos);
                }
            }
            for (int i = 0; i < datosAlquiler.Count; i++)
            {
                if (Convert.ToInt32(datosAlquiler[i].Kmrecorridos) == b)
                {
                    lbl_marca.Text = datosAlquiler[i].Marca;
                    lbl_km.Text = datosAlquiler[i].Kmrecorridos.ToString();
                    break;
                }
            }
        }
    }
}
