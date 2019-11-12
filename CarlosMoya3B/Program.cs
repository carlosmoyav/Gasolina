using System;
using CarlosMoya3B.clases;

namespace CarlosMoya3B
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente cliente = new cliente();
            gasolina gasolina = new gasolina();
            ingresardatos(cliente, gasolina);
            factura(cliente, gasolina);

        }
        public static void ingresardatos(cliente cliente, gasolina gasolina)
        {
            int opcion, galones;
            Console.WriteLine("********** Tercer  Nivel  Cía.  Ltda **********");
            Console.WriteLine("          VENTA DE GALONES DE GASOLINA         ");
            Console.WriteLine("Precios \nEXTRA:$1,50\nSUPER:$2,00");
            Console.WriteLine("Ingrese los APELLIDOS del cliente");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese los NOMBRES del cliente");
            cliente.Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de CEDULA del cliente");
            cliente.Cedula = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la DIRECCION del cliente");
            cliente.Direccion = Console.ReadLine();

            Console.WriteLine("Presione 1 para comprar Extra o Presione 2 para comprar Super");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case (1):
                    gasolina.Tipo = "Extra";
                    gasolina.Prventa = 1.50;
                    break;

                case (2):
                    gasolina.Tipo = "Super";
                    gasolina.Prventa = 2;
                    break;
            }

            Console.WriteLine("Ingrese la cantidad de GALONES que \ndesea poner");
            galones = int.Parse(Console.ReadLine());
            gasolina.Cantidadgalones = galones;
        }
        public static void factura(cliente cliente, gasolina gasolina)
        {
            double iva = (gasolina.Prventa * gasolina.Cantidadgalones)*12/100;
            double subtotal = gasolina.Prventa * gasolina.Cantidadgalones;
            double total = subtotal + iva;
            Console.WriteLine("FACTURA \nDatos del cliente");
            Console.WriteLine("Apellidos:"+ cliente.Apellidos);
            Console.WriteLine("Nombres:"+ cliente.Nombres);
            Console.WriteLine("Numero de cedula:"+cliente.Cedula);
            Console.WriteLine("Dirección:"+cliente.Direccion);
            Console.WriteLine(" ");
            Console.WriteLine("Datos de la gasolina");
            Console.WriteLine("Tipo de Gasolina:" + gasolina.Tipo);
            Console.WriteLine("Cantidad de Galones:"+gasolina.Cantidadgalones);
            Console.WriteLine("Precio por galon:"+gasolina.Prventa);
            Console.WriteLine(" ");
            Console.WriteLine("Valor a Cancelar");
            Console.WriteLine("Subtotal="+subtotal);
            Console.WriteLine("IVA="+iva);
            Console.WriteLine("Total="+total);
        }
    }
}
