namespace Tasca;

public class Tauro : Animal_Mari
{
    public Tauro(int x, int y,Sexes? Sexe) : base(x, y,Sexe)
    {
    }
    private int Rondes;

    protected override void Moviment()
    {
        base.Moviment();
        
        Rondes++;
        
        if (Rondes >= 75)
        {
            Mata();
        }
    }

    public override void HeTrobat(Animal_Mari altre)
    {
        if (altre is Tortuga) // En cas de que el tauró toqui una tortuga canvia de direcció.
        {
            Direccio();
        }
        else if (altre is Peix || altre is Pop)
        {
            altre.Mata();
        }
        else if (altre is Tauro && altre.Sexe == Sexe)
        {
            Mata();
            altre.Mata();
        }
    }
    
}