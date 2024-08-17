using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Smartphone_CSharp_DIO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no Iphone");
        }
    }
}
