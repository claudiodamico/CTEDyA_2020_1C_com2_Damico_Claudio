using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral<int> arbol = new ArbolGeneral<int>(10);

            ArbolGeneral<int> hijo1 = new ArbolGeneral<int>(20);
            ArbolGeneral<int> hijo2 = new ArbolGeneral<int>(30);
            ArbolGeneral<int> hijo3 = new ArbolGeneral<int>(40);

            arbol.agregarHijo(hijo1);
            arbol.agregarHijo(hijo2);
            arbol.agregarHijo(hijo3);

            for (int i = 1; i < 3; i++)
            {
                hijo1.agregarHijo (new ArbolGeneral<int>(i + 20));
                hijo2.agregarHijo (new ArbolGeneral<int>(i + 30));
                hijo3.agregarHijo (new ArbolGeneral<int>(i + 40));

            }

            Console.WriteLine(arbol.Altura());
            arbol.Altura();
            Console.ReadKey(true);
            
        }	

	}

    
	

}
