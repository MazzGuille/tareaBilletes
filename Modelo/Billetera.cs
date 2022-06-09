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
namespace tareaBilletes.Modelo
{
    class Billetera
    {
        public Billetera()
        {

        }
        public Billetera(int billetesDe10, int billetesDe20, int billetesDe50, int billetesDe100, int billetesDe200, int billetesDe500, int billetesDe1000)
        {
            BilletesDe10 = billetesDe10;
            BilletesDe20 = billetesDe20;
            BilletesDe50 = billetesDe50;
            BilletesDe100 = billetesDe100;
            BilletesDe200 = billetesDe200;
            BilletesDe500 = billetesDe500;
            BilletesDe1000 = billetesDe1000;
        }

        public decimal Combinar(Billetera x, Billetera y)
        {
            decimal billetera3 = x.SumaBilletera() + y.SumaBilletera();
            return billetera3;
        }

        public decimal Cero()
        {
            decimal X = SumaBilletera() - SumaBilletera();
            return X;
        }
        public void CantidadIndividual()
        {

            WriteLine($"Cantidad de billetes de 10: {BilletesDe10}");
            WriteLine($"Cantidad de billetes de 20: {BilletesDe20}");
            WriteLine($"Cantidad de billetes de 50: {BilletesDe50}");
            WriteLine($"Cantidad de billetes de 100: {BilletesDe100}");
            WriteLine($"Cantidad de billetes de 200: {BilletesDe200}");
            WriteLine($"Cantidad de billetes de 500: {BilletesDe500}");
            WriteLine($"Cantidad de billetes de 1000: {BilletesDe1000}");
        }

        public void SumaIndividual()
        {

            WriteLine($"Suma de los billetes de 10: {BilletesDe10 * 10}");
            WriteLine($"Suma de los billetes de 20: {BilletesDe20 * 20}");
            WriteLine($"Suma de los billetes de 50: {BilletesDe50 * 50}");
            WriteLine($"Suma de los billetes de 100: {BilletesDe100 * 100}");
            WriteLine($"Suma de los billetes de 200: {BilletesDe200 * 200}");
            WriteLine($"Suma de los billetes de 500: {BilletesDe500 * 500}");
            WriteLine($"Suma de los billetes de 1000: {BilletesDe1000 * 1000}");
        }

        public decimal SumaBilletera()
        {
            return (BilletesDe10 * 10) + (BilletesDe20 * 20) + (BilletesDe50 * 50) + (BilletesDe100 * 100) +
                   (BilletesDe200 * 200) + (BilletesDe500 * 500) + (BilletesDe1000 * 1000);
        }

        public int BilletesDe10 { get; set; }
        public int BilletesDe20 { get; set; }
        public int BilletesDe50 { get; set; }
        public int BilletesDe100 { get; set; }
        public int BilletesDe200 { get; set; }
        public int BilletesDe500 { get; set; }
        public int BilletesDe1000 { get; set; }






    }
}
