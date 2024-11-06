namespace MatrizAdyasencia
{
    using System;

    class Grafo
    {
        private int[,] matrizAdyacencia;
        private int numVertices;

        // Constructor
        public Grafo(int vertices)
        {
            numVertices = vertices;
            matrizAdyacencia = new int[vertices, vertices];
        }

        // Método para agregar una arista
        public void AgregarArista(int origen, int destino)
        {
            
            matrizAdyacencia[origen, destino] = 1; // Para un grafo dirigido
            
        }

        // Método para mostrar la matriz de adyacencia
        public void MostrarMatriz()
        {
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    Console.Write(matrizAdyacencia[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear un grafo con los nxn vértices que queramos implementar en el programa 
            Grafo grafo = new Grafo(10);

            // Agregar aristas
            grafo.AgregarArista(0,1);
            grafo.AgregarArista(0,1);
            grafo.AgregarArista(1,1);
            grafo.AgregarArista(1,3);
            grafo.AgregarArista(1,7);
            grafo.AgregarArista(2,3);
            grafo.AgregarArista(8,1);

            //aqui cabe mencionar que el primer numero es la posicion de la colunma en la que se va a prensentar el 1, y el segundo numero representa 
            //    el lugar en la fila en la que el "1" estara posicionado 

            
            grafo.MostrarMatriz();
        }
    }
}
