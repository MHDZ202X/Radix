using System;
using System.Collections.Generic;
using System.Text;

namespace RadixS
{
    class RadixCS
    {
        //metodo radix que tiene un arreglo de enteros llamadao vector
        public static void Radix(int[] vector)
        {
            //arreglo auxiliar   se le da memoria mediante el vector y cuenta lo que esta dentro del vector le cuentas la longitud
            int[] aux = new int[vector.Length];

            //se declaran esats bariables
            int r = 2;
            int b = 32;

            // se cuenta el arreglo y se le da memoria , se desplasa el numero 
            int[] count = new int[1 << r];
            int[] pref = new int[1 << r];

            //bariable groups. debuelve valores enteros menores al que ya se asigno . despues se divide entre r
            int groups = (int)Math.Ceiling((double)b / (double)r);

            //se hace un desplasamiento  de 1 hacia la izquierda y luego se resta 1
            int mask = (1 << r) - 1;

            
            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                for (int j = 0; j < count.Length; j++)
                {
                    count[j] = 0;
                }
                for (int i = 0; i < vector.Length; i++)
                {
                    count[(vector[i] >> shift) & mask]++;
                }
                pref[0] = 0;
                for (int i = 1; i < count.Length; i++)
                {
                    pref[i] = pref[i - 1] + count[i - 1];
                }
                for (int i = 0; i < vector.Length; i++)
                {
                    aux[pref[(vector[i] >> shift) & mask]++] = vector[i];
                }
                aux.CopyTo(vector, 0);
            }
        }

    }
}
