
namespace Tasca;

public class Peix : Animal_Mari
{
    public Peix(int x, int y,Sexes? Sexe) : base(x, y,Sexe){}

    public override void HeTrobat(Animal_Mari altre)
    {
        if (altre is Tauro)
        {
            Mata();
            return;
        }
        if (altre is Peix && altre.Sexe == Sexe)
        {
            Mata(); // Mor el peix
            altre.Mata(); // Mata al peix que s'ha trobat
        }
    }
}