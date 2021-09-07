using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese que continente quiere visitar: ");
            string continente = Console.ReadLine();
            Console.WriteLine("-------------------------------");

           
            switch (continente)
            {
                case "america":
                                         

               int ValorDeDias = 100;
               Console.WriteLine("Ingrese la cantidad de dias que se quiere quedar en el lugar: ");
               int dias = int.Parse(Console.ReadLine());                           
               int CantidadDeDias = dias * ValorDeDias;                 
               Console.WriteLine("El Precio por la cantidad de dias que usted quiere es " + CantidadDeDias+ " $");
               int Descuento = CantidadDeDias / 2;
               Console.WriteLine("Con el Descuento de 50% usted abona " + Descuento+ " $");
                    double Descuento2 = CantidadDeDias * 0.60;
                    double descuentototal = CantidadDeDias - Descuento2;
               Console.WriteLine("Y si paga con debito tiene otro 10% mas de descuento con lo cual abona : "+ descuentototal+" $");

                    break;

                case "africa":
                    int ValorDeDiasAfrica = 100;
                    Console.WriteLine("Ingrese la cantidad de dias que se quiere quedar en el lugar: ");
                    int diasAfrica = int.Parse(Console.ReadLine());
                    int CantidadDeDiasAfrica = diasAfrica * ValorDeDiasAfrica;;
                    Console.WriteLine("El Precio por la cantidad de dias que usted quiere es " + CantidadDeDiasAfrica + " $");
                    double DescuentoAfrica = CantidadDeDiasAfrica * 0.60;
                    double descuentoEfectivo = CantidadDeDiasAfrica - DescuentoAfrica;
                    Console.WriteLine("Con el Descuento de 60% usted abona " + descuentoEfectivo + " $");
                    Console.WriteLine("-----------------------------: ");
                    double DescuentoAfrica2 = CantidadDeDiasAfrica * 0.75;       
                    double descuentoMercadoPago = CantidadDeDiasAfrica - DescuentoAfrica2;                    
                    Console.WriteLine("Y si paga con Mercado Pago el descuento es del 75% con lo cual abona " + descuentoMercadoPago + " $");
                   
                    break;
                case "europa":
                    int ValorDeDiasEuropa = 100;
                    Console.WriteLine("Ingrese la cantidad de dias que se quiere quedar en el lugar: ");
                    int diasEuropa = int.Parse(Console.ReadLine());
                    int CantidadDeDiasEuropa = diasEuropa * ValorDeDiasEuropa; ;
                    Console.WriteLine("El Precio por la cantidad de dias que usted quiere es " + CantidadDeDiasEuropa + " $");
                    double DescuentoEuropa = CantidadDeDiasEuropa * 0.20;
                    double descuentoEfectivoEuropa = CantidadDeDiasEuropa - DescuentoEuropa;
                    Console.WriteLine("Con el Descuento de 20% usted abona " + descuentoEfectivoEuropa + " $");
                    Console.WriteLine("-----------------------------: ");
                    double DescuentoEuropa2 = CantidadDeDiasEuropa * 0.35;
                    double descuentoDebito = CantidadDeDiasEuropa - DescuentoEuropa2;
                    Console.WriteLine("Y si paga con debito tiene otro 15% mas de descuento con lo cual abona " + descuentoDebito + " $");
                    Console.WriteLine("-----------------------------: ");
                    double DescuentoEuropa3 = CantidadDeDiasEuropa * 0.30;
                    double DescuentoDebito = CantidadDeDiasEuropa - DescuentoEuropa3;
                    Console.WriteLine("Si lo quiere hacer por MercadoPago es un 10% mas de descuento con lo cual abona " + DescuentoDebito + " $");
                    Console.WriteLine("-----------------------------");
                    double DescuentoEuropa4 = CantidadDeDiasEuropa * 0.05;
                    double DescuentoOtroMedio = CantidadDeDiasEuropa - DescuentoEuropa4;
                    Console.WriteLine("Y el descuento por cualquier otro medio es de 5% por lo cual abonaria: "+DescuentoOtroMedio+ " $");


                    break;

                case "asia":
                    int ValorDeDiasAsia = 100;
                    Console.WriteLine("Ingrese la cantidad de dias que se quiere quedar en el lugar: ");
                    int diasAsia = int.Parse(Console.ReadLine());
                    int CantidadDeDiasAsia = diasAsia * ValorDeDiasAsia;
                    Console.WriteLine("El Precio por la cantidad de dias que usted quiere es " + CantidadDeDiasAsia + " $");
                    double incrementoAsia = CantidadDeDiasAsia * 20;
                    double incremento =  incrementoAsia / 100 ;
                    double recargo = incremento + CantidadDeDiasAsia;
                    Console.WriteLine("Con el Recargo de 20% usted abona " + recargo + " $");
                    break;

                case "oceania":
                    int ValorDeDiasOceania = 100;
                    Console.WriteLine("Ingrese la cantidad de dias que se quiere quedar en el lugar: ");
                    int diasOceania = int.Parse(Console.ReadLine());
                    int CantidadDeDiasOceania = diasOceania * ValorDeDiasOceania;
                    Console.WriteLine("El Precio por la cantidad de dias que usted quiere es " + CantidadDeDiasOceania + " $");
                    double incrementoOceania = CantidadDeDiasOceania * 20;
                    double incrementoOceania2 = incrementoOceania / 100;
                    double recargoOceania = incrementoOceania2 + CantidadDeDiasOceania;
                    Console.WriteLine("Con el Recargo de 20% usted abona " + recargoOceania + " $");
                    break;
                    



            }
            
        }
    }
}
