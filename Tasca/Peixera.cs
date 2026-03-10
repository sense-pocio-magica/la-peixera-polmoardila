using System;
using System.Collections.Generic;

namespace Tasca;

public class Peixera
{
    internal List<Animal_Mari> animals_marins = [];
    private Random rnd = new Random();

    public void CrearAnimals()
    {
        for (int i = 1; i <= 50; i++)
        {
            animals_marins.Add(new Peix(rnd.Next(1, 21), rnd.Next(1, 21), Sexes.Masculi));
        }

        for (int i = 1; i <= 50; i++)
        {
            animals_marins.Add(new Peix(rnd.Next(1, 21), rnd.Next(1, 21), Sexes.Femeni));
        }

        for (int i = 1; i <= 10; i++)
        {
            animals_marins.Add(new Tauro(rnd.Next(1, 21), rnd.Next(1, 21), Sexes.Masculi));
        }

        for (int i = 1; i <= 10; i++)
        {
            animals_marins.Add(new Tauro(rnd.Next(1, 21), rnd.Next(1, 21), Sexes.Femeni));
        }

        for (int i = 1; i <= 15; i++)
        {
            animals_marins.Add(new Pop(rnd.Next(1, 21), rnd.Next(1, 21), Sexes.Sense));
        }

        for (int i = 1; i <= 3; i++)
        {
            animals_marins.Add(new Tortuga(rnd.Next(1, 21), rnd.Next(1, 21), Sexes.Masculi));
        }

        for (int i = 1; i <= 3; i++)
        {
            animals_marins.Add(new Tortuga(rnd.Next(1, 21), rnd.Next(1, 21), Sexes.Femeni));
        }
    }
   public virtual void Neix()
{
    List<Animal_Mari> bebes = new List<Animal_Mari>();
    foreach (var animalMari in animals_marins)
    {
        foreach (var altre in animals_marins)
        {
            if (animalMari != altre && altre.ObtenirPosicio() == animalMari.ObtenirPosicio())
            {
                if (altre.Sexe != animalMari.Sexe && altre.GetType() == animalMari.GetType()) // El GetType serveix per veure si son de la mateixa especie es a dir que retorna el nom de la clase especificada.
                {
                    int sexerandom = rnd.Next(0, 2);
                    Sexes masculiofemeni = sexerandom == 0 ? Sexes.Masculi : Sexes.Femeni;
                   
                    var d = DireccioDiferentDe(altre.ObtenirDireccio(), animalMari.ObtenirDireccio());
                    Animal_Mari nou = null;
                    switch (altre)
                    {
                        case Tauro:
                            nou = new Tauro(altre.ObtenirPosicio().Item1, altre.ObtenirPosicio().Item2, masculiofemeni);
                            break;
                        case Peix:
                            nou = new Peix(altre.ObtenirPosicio().Item1, altre.ObtenirPosicio().Item2, masculiofemeni);
                            break;
                        case Tortuga:
                            nou = new Tortuga(altre.ObtenirPosicio().Item1, altre.ObtenirPosicio().Item2, masculiofemeni);
                            break;
                    }
                    if (nou != null)
                    {
                        nou.DireccioX = d.Item1;
                        nou.DireccioY = d.Item2;
                        bebes.Add(nou);
                    }
                }
            }
        }
    }
    foreach (var b in bebes)
    {
        animals_marins.Add(b);
    }
}
    private (int,int) DireccioDiferentDe((int, int) direccioPare, (int, int) direccioMare)
    {
        int DireccioX = 0;
        int DireccioY = 0;
        bool trobada = false;

        while (!trobada)
        {
            int direccio = rnd.Next(0, 4); 
        
            switch (direccio)
            {
                // Nort
                case 0:
                    DireccioY = -1;
                    DireccioX = 0;
                    break;
                // Sud
                case 1:
                    DireccioY = 1;
                    DireccioX = 0;
                    break;
                // Est
                case 2:
                    DireccioX = 1;
                    DireccioY = 0;
                    break;
                // Oest
                case 3:
                    DireccioX = -1;
                    DireccioY = 0;
                    break;
            }
            if ((DireccioX, DireccioY) != direccioPare && (DireccioX, DireccioY) != direccioMare)
            {
                trobada = true;
            }
        }
        return (DireccioX, DireccioY);
    }
}    

