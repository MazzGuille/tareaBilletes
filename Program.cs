global using static System.Console;
using tareaBilletes.Modelo;
/*
* Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera 
teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una 
nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar 
en cero. (Sin billetes)
*/

Random num = new();

Billetera billetera1 = new(num.Next(1, 11), num.Next(1, 11), num.Next(1, 11), num.Next(1, 11), num.Next(1, 11), num.Next(1, 11), num.Next(1, 11));
//Billetera billetera1 = new(10, 14, 25, 5, 10, 3, 5);

WriteLine("BILLETERA 1:");
WriteLine("====================================================================");
billetera1.CantidadIndividual();
WriteLine("====================================================================");
billetera1.SumaIndividual();
WriteLine("====================================================================");
WriteLine($"Suma total en la billetera 1 es: {billetera1.SumaBilletera()}");

WriteLine();

Billetera billetera2 = new(num.Next(1, 11), num.Next(1, 11), num.Next(1, 11), num.Next(1, 11), num.Next(1, 11), num.Next(1, 11), num.Next(1, 11));
//Billetera billetera1 = new(10, 14, 25, 5, 10, 3, 5);

WriteLine("BILLETERA 2:");
WriteLine("====================================================================");
billetera2.CantidadIndividual();
WriteLine("====================================================================");
billetera2.SumaIndividual();
WriteLine("====================================================================");
WriteLine($"Suma total en la billetera 2 es: {billetera2.SumaBilletera()}");

WriteLine();

Billetera billetera3 = new();
WriteLine("BILLETERA 3:");
WriteLine("====================================================================");
WriteLine($"La suma de ambas billeteras es: {billetera3.Combinar(billetera1, billetera2)}");
WriteLine($"Cantidad restante en la Billetera 1: {billetera1.Cero()}");
WriteLine($"Cantidad restante en la Billetera 2: {billetera2.Cero()}");