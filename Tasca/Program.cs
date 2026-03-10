using System;

namespace Tasca;

class Program
{
    static void Main(string[] args)
    {
        Peixera lPeixera = new Peixera();
        lPeixera.CrearAnimals();

        for (int ronda = 1; ronda <= 100; ronda++)
        {
            // 1. Moviment
             foreach (var animal in lPeixera.animals_marins)
                {
                    animal.Moviment(); 
                }

            // 2. Colisions
            foreach (var a1 in lPeixera.animals_marins)
            {
                foreach (var a2 in lPeixera.animals_marins)
                {
                    if (a1 != a2 && a1.ObtenirPosicio() == a2.ObtenirPosicio())
                        {
                            a1.HeTrobat(a2);
                        }
                }
            }

            // 3. Naixements
            lPeixera.Neix();

            // 4. Eliminar els morts
            for (int i = lPeixera.animals_marins.Count - 1; i >= 0; i--)
            {
                if (lPeixera.animals_marins[i].viu == false)
                {
                    lPeixera.animals_marins.RemoveAt(i); } 
            }
        }
        // Console WriteLines dels resultats finals
        int peixos = 0, taurons = 0, pops = 0, tortugues = 0;
        
        foreach (var animal in lPeixera.animals_marins)
        {
            if (animal is Peix)
            {
                peixos++;
            }
            else if (animal is Tauro)
            {
                taurons++;
            }
            else if (animal is Pop)
            {
                pops++;
            }
            else if (animal is Tortuga)
            {
                tortugues++;
            }
        }

        Console.WriteLine("Final. Han quedat:");
        Console.WriteLine("Peixos: " + peixos);
        Console.WriteLine("Tauróns: " + taurons);
        Console.WriteLine("Pops: " + pops);
        Console.WriteLine("Tortugues: " + tortugues);
    }
}