namespace Pescalao;

public enum Sexes
{
    Masculi,
    Femini,
    Sense
}
public abstract class Animal_Mari
{
    
    protected int X = 0;
    protected int Y = 0;
    public Sexes Sexe { get; set;}
    protected static Random rnd = new Random();
    protected bool viu = true;
    private static int Id;
    public int _id;
    public Animal_Mari(int x, int y,Sexes? sexe, bool viu = true)
    {
        Id = _id;
        X = x;
        Y = y;
        if (sexe == null)
        {
            Sexe = (Sexes)rnd.Next(0, 1) ==  0 ? Sexes.Masculi : Sexes.Femini;
        }
    }
    
    
    public virtual void Moviment()
    {
        int n = rnd.Next(0, 4);
        int a = 0;
        int b = 0;
        switch (n)
        {
            case 0: X = -1; break;
            case 1: X = 1;  break;
            case 2: Y = -1; break; 
            case 3: Y = 1;  break; 
        }
        
        X = (X + a);
        Y = (Y + b);
        if (X < 1) X = 20;
        if (X > 20) X = 1;
        if (Y < 1) Y = 20;
        if (Y > 20) Y = 1;
    }
    public (int,int) ObtenirPosicio()
    {
        (int,int) posicio = (X,Y);
        return posicio;
    }
    
    public void Mata()
    {
        viu = false;
    }

    public virtual void HeTrobat(Animal_Mari animal_mari)
    {
    }
}