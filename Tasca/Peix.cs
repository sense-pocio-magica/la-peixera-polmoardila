namespace Pescalao;

public class Peix : Animal_Mari
{
    public Peix(int x, int y,Sexes? Sexe) : base(x, y,Sexe)
    {

    }
    private int x = 0;
    private int y = 0;
    
    public override void Moviment()
    {
        X += x;
        Y += y;
    }

    public override void HeTrobat(Animal_Mari animal_mari)
    {
        if (animal_mari is Peix && animal_mari.Sexe == Sexe)
        {
            Mata();
        }
    }
}