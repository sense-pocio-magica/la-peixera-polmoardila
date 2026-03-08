namespace Pescalao;

public class Peixera
{
    private List<Animal_Mari> animals_marins = [];
    private Random rnd  = new Random();

    public void CrearAnimals()
    {
        for(int i = 0; i <= 50;i++)
        {
            animals_marins.Add(new Peix(rnd.Next(1,21), rnd.Next(1,21),Sexes.Masculi));
        }
        for(int i = 0; i <= 50;i++)
        {
            animals_marins.Add(new Peix(rnd.Next(1,21), rnd.Next(1,21),Sexes.Femini));
        }
        for(int i = 0; i <= 10;i++)
        {
            animals_marins.Add(new Tauro(rnd.Next(1,21), rnd.Next(1,21),Sexes.Masculi));
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

