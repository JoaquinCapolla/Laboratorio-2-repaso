
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2_repaso
{
    class DatosAlquiler
    {
        string placa;
        string marca;
        string modelo;
        string nit;
        string nombre;
        string direccion;
        float kmrecorridos;
        float tarifa;
        DateTime fechaalquiler;
        DateTime fechadevolucion;

        public string Nit { get => nit; set => nit = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public float Kmrecorridos { get => kmrecorridos; set => kmrecorridos = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public float Tarifa { get => tarifa; set => tarifa = value; }
        public DateTime Fechaalquiler { get => fechaalquiler; set => fechaalquiler = value; }
        public DateTime Fechadevolucion { get => fechadevolucion; set => fechadevolucion = value; }
    }
}
