using System;
using System.Collections.Generic;

namespace Tasca;

public class Peixera
{
    private List<Animal_Mari> animals_marins = [];
    private Random rnd  = new Random();

    public void CrearAnimals()
    {
        for(int i = 1; i <= 50;i++)
        {
            animals_marins.Add(new Peix(rnd.Next(1,21), rnd.Next(1,21),Sexes.Masculi));
        }
        for(int i = 1; i <= 50;i++)
        {
            animals_marins.Add(new Peix(rnd.Next(1,21), rnd.Next(1,21),Sexes.Femeni));
        }
        for(int i = 1; i <= 10;i++)
        {
            animals_marins.Add(new Tauro(rnd.Next(1,21), rnd.Next(1,21),Sexes.Masculi));
        }
        for(int i = 1; i <= 10;i++)
        {
            animals_marins.Add(new Tauro(rnd.Next(1,21), rnd.Next(1,21),Sexes.Femeni));
        }
        for(int i = 1; i <= 15;i++)
        {
            animals_marins.Add(new Pop(rnd.Next(1,21), rnd.Next(1,21),Sexes.Sense));
        }
        for(int i = 1; i <= 3;i++)
        {
            animals_marins.Add(new Tortuga(rnd.Next(1,21), rnd.Next(1,21),Sexes.Masculi));
        }
        for(int i = 1; i <= 3;i++)
        {
            animals_marins.Add(new Tortuga(rnd.Next(1,21), rnd.Next(1,21),Sexes.Femeni));
        }
        
    }
    
    public virtual bool TrobatDosPeixos()
    {
        foreach (var animalMari in animals_marins)
        {
            foreach (var altre in animals_marins)
            {
                if (altre.ObtenirPosicio() == animalMari.ObtenirPosicio())
                {
                
            
                }
            }
        }

    } 
}

