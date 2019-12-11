using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vellonera
{
    class LinkedList
    {
        public nodo inicio;
        public int posicion = 2;
        public int comparador = 0;
        public int anotador = 0;


        public LinkedList()
        {
            inicio = null;
        }
        public void InsertarF(string item)
        {
            comparador++;
            nodo auxiliar = new nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }

        }

        public void EliminarF(int eliminador)
        {

            if (inicio == null)
            {
                Console.WriteLine("Lista vacia, no se puede eliminar elemento");
            }
            else
            {
                if (eliminador == 1)
                {
                    inicio = inicio.siguiente;
                }
                else
                {
                    nodo punteroant, punteropost;
                    punteroant = inicio;
                    punteropost = inicio;
                    for (int i = 1; i < eliminador; i++)
                    {
                        punteroant = punteropost;
                        punteropost = punteropost.siguiente;
                    }

                    punteroant.siguiente = punteropost.siguiente;
                    
                    if (eliminador == comparador)
                    {
                        posicion--;
                    }
                    
                    comparador--;
                    
                }

            }


        }

        public void mostraractual()
        {

            if (inicio == null)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                if (posicion == 1)
                {
                    Console.Write( puntero.dato);
                }
                else
                {
                    for (int i = 1; i < posicion - 1; i++)
                    {
                        puntero = puntero.siguiente;
                    }
                    Console.Write( puntero.dato);
                }
            }
        }
        public void mostrarsiguiente()
        {
            if(posicion <= 1) { posicion = 2; }
            if (anotador == 1)
            {
                if (posicion > comparador)
                {
                    posicion = 2;
                }
                else { posicion++; }
            }
            else
            {
                if (posicion <= comparador) { posicion++; }
            }
            Console.Write(posicion);
            Console.Write(comparador);
            if (inicio == null)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                
                for (int i = 1; i < posicion - 1 ; i++)
                {
                    puntero = puntero.siguiente;
                }
                Console.WriteLine("Avanzando a la Proxima Cancion....");
                Console.Write(puntero.dato);
                
            }
        }
        public void mostraranterior()
        {
            if (posicion > 1) { posicion--; }

            if (inicio == null)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                if (posicion <= 1)
                {
                    Console.Write(puntero.dato);
                }
                else
                {
                    for (int i = 1; i < posicion - 1; i++)
                    {
                        puntero = puntero.siguiente;
                    }
                    Console.Write(puntero.dato);
                }
            }
        }
        public void mostrar()
        {
            int contador = 1;
            if (inicio == null)
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                nodo puntero;
                puntero = inicio;
                Console.Write(contador + ")");
                Console.WriteLine(puntero.dato);
                while (puntero.siguiente != null)
                {
                    contador++;
                    puntero = puntero.siguiente;
                    Console.Write(contador + ")");
                    Console.WriteLine(puntero.dato);

                }
            }
            Console.WriteLine();
        }
        public void repeticion()
        {
            if (anotador != 1)
            {
                anotador = 1;
                Console.Write("Repeticion activada");
            }
            else
            {
                anotador = 0;
                Console.Write("Repeticion desativada");
            }

        }
    }
}
