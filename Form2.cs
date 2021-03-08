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
    public partial class Form2 : Form
    {
        List<DatosAlquiler> datosAlquiler = new List<DatosAlquiler>();
        List<DatosAutos> datosAutos = new List<DatosAutos>();
        public Form2()
        {
            InitializeComponent();
            String appPath = Path.GetDirectoryName(Application.ExecutablePath);
            StreamWriter writer1 = new StreamWriter(appPath + "\\DatosAlquileres.txt", true);
            writer1.Close();
            Leer();
            Leer1();
            Mostrar();
        }
        private void Guardar()
        {
            File.Delete("DatosAlquileres.txt");
            String appPath = Path.GetDirectoryName(Application.ExecutablePath);
            StreamWriter writer1 = new StreamWriter(appPath + "\\DatosAlquileres.txt", true);

            for (int i = 0; i < datosAlquiler.Count; i++)
            {
                writer1.WriteLine(datosAlquiler[i].Placa);
                writer1.WriteLine(datosAlquiler[i].Marca);
                writer1.WriteLine(datosAlquiler[i].Modelo);
                writer1.WriteLine(datosAlquiler[i].Nit);
                writer1.WriteLine(datosAlquiler[i].Nombre);
                writer1.WriteLine(datosAlquiler[i].Direccion);
                writer1.WriteLine(datosAlquiler[i].Kmrecorridos);
                writer1.WriteLine(datosAlquiler[i].Tarifa);
                writer1.WriteLine(datosAlquiler[i].Fechaalquiler);
                writer1.WriteLine(datosAlquiler[i].Fechadevolucion);
            }
            writer1.Close();
        }
        private void Leer()
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
        private void Leer1()
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
                comboBox1.Items.Add(datosautosTemp.Placa);
                datosAutos.Add(datosautosTemp);
            }
            reader1.Close();
        }
        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = datosAlquiler;
            dataGridView1.Refresh();
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            DatosAlquiler datosAlquilerTemp = new DatosAlquiler();

            string temp = comboBox1.SelectedItem.ToString();
            
            datosAlquilerTemp.Nit = txt_nit.Text;
            datosAlquilerTemp.Nombre = txt_nombre.Text;
            datosAlquilerTemp.Direccion = txt_direccion.Text;
            datosAlquilerTemp.Kmrecorridos = float.Parse(txt_recorridos.Text);
            datosAlquilerTemp.Fechaalquiler = mnt_alquiler.SelectionStart;
            datosAlquilerTemp.Fechadevolucion = mnt_devolucion.SelectionStart;
            for (int i = 0; i < datosAutos.Count; i++)
            {
                if (datosAutos[i].Placa == temp)
                {
                    datosAlquilerTemp.Placa = datosAutos[i].Placa;
                    datosAlquilerTemp.Marca = datosAutos[i].Marca;
                    datosAlquilerTemp.Modelo = datosAutos[i].Modelo;
                    datosAlquilerTemp.Tarifa = datosAutos[i].Precio * datosAlquilerTemp.Kmrecorridos;
                    break;
                }
            }
            datosAlquiler.Add(datosAlquilerTemp);
            Guardar();
            Leer();
            Mostrar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox1.SelectedItem.ToString();
            for(int i = 0; i < datosAutos.Count; i++)
            {
                if(datosAutos[i].Placa == temp)
                {
                    lbl_marca.Text = datosAutos[i].Marca;
                    lbl_modelo.Text = datosAutos[i].Modelo;
                    break;
                }
            }

        }
    }
}
