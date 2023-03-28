using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca_restar;
using biblioteca_sumar;
using nacho_division;
using Nacho_Multiplicacion;

namespace Integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean o = true;
            while (o)
            {
                Console.WriteLine("1)Sumar. / 2)Restar. / 3)Multiplicacion. / 4)Division. / 5)Salir");
                Console.WriteLine("Ingrese Opcion");
                string opc = Console.ReadLine();
                if (opc == "1")
                {
                    Console.WriteLine("Ingrese primer valor");
                    string V1 = Console.ReadLine();
                    int V = Convert.ToInt32(V1);
                    Console.WriteLine("Ingrese Segundo valor");
                    string V2 = Console.ReadLine();
                    int B = Convert.ToInt32(V2);
                    long rta;
                    rta = biblioteca_sumar.Class1.Suma(V, B);
                    Console.WriteLine(rta);
                    
                }
                if(opc == "2")
                {
                    Console.WriteLine("Ingrese primer valor");
                    string R1 = Console.ReadLine();
                    int r = Convert.ToInt32(R1);
                    Console.WriteLine("Ingrese Segundo valor");
                    string R2 = Console.ReadLine();
                    int r2 = Convert.ToInt32(R2);
                    long resta;
                    resta = biblioteca_restar.Class1.Restar(r, r2);
                    Console.WriteLine(resta);
                    
                }
                if (opc == "3")
                {
                    Console.WriteLine("Ingrese primer valor");
                    string M1 = Console.ReadLine();
                    int m = Convert.ToInt32(M1);
                    Console.WriteLine("Ingrese Segundo valor");
                    string M2 = Console.ReadLine();
                    int m2 = Convert.ToInt32(M2);
                    long Multiplicacion;
                    Multiplicacion = Nacho_Multiplicacion.Class1.Multiplicacion(m, m2);
                    Console.WriteLine(Multiplicacion);
                }
                if (opc == "4")
                {
                    Console.WriteLine("Ingrese primer valor");
                    string D1 = Console.ReadLine();
                    int d = Convert.ToInt32(D1);
                    Console.WriteLine("Ingrese Segundo valor");
                    string D2 = Console.ReadLine();
                    int d2 = Convert.ToInt32(D2);
                    long Division;
                    Division = nacho_division.Class1.division(d, d2);
                    Console.WriteLine(Division);
                }
                if(opc=="5")
                {
                    o = false;
                }
            }
        }
    }
}
