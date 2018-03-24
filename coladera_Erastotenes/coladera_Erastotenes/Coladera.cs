using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coladera_Erastotenes
{
    class Coladera
    {
        static string b;







        static void realizar()



        {



            int a = 1001;



            bool[] marcados = new bool[a + 1];

            StringBuilder builder = new StringBuilder();

            for (int i = 2; i <= Math.Sqrt(a); i++)

            {

                if (!marcados[i]) //desigancion numeros no primos

                    for (int j = i * 2; j <= a; j += i)

                        marcados[j] = true;

            }



            for (int i = 2; i < marcados.Length; i++)

                if (marcados[i] == false)

                    builder.Append(i + ", ");

            builder.Length -= 2;

            b = builder.ToString();

        }

        public void comenzar()

        {

            realizar();

        }

        public override string ToString()

        {

            return b;

        }
    }
}
