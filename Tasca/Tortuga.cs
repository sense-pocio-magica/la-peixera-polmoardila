namespace Tasca;

public class Tortuga : Animal_Mari
{
    public Tortuga(int x, int y, Sexes? Sexe) : base(x, y, Sexe)
    {
    }

    public override void HeTrobat(Animal_Mari altre)
    {
        if (altre is Tortuga)
        {
            if (altre.Sexe == Sexe)
            {
                Mata();
                altre.Mata();
            }
        }
    }
}    