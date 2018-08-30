using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_11_orientacao_a_objetos_construtores
{
    class Program
    {
        static void Main(string[] args)
        {


            // atributos de instância
            var cliente = new Cliente(); 
            cliente.Nome = "Testeeee";
            cliente.Telefone = "00000";
            cliente.CPF = "2323232332323232";
            cliente.Gravar();


            //Cliente c = new Cliente("Nicoooo","3432434432324432","43432432432432");


            var clientes = Cliente.LerClientes();
            foreach (Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);
                Console.WriteLine(c.Telefone);
                Console.WriteLine(c.CPF);
            }
            Console.Read();
        }
    }
}
