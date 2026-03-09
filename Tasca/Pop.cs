namespace Tasca;

public class Pop : Animal_Mari
{
    public Pop(int x, int y,Sexes? Sexe = Sexes.Sense) : base(x, y,Sexe)
    {

    }
    protected override void Moviment()
    {
        // Com el pop es mou de diferent manera que els altres haurem d'implementar la seguent estructura de moviment
        if (X >= 20 && Y == 1)
        {
            DireccioX = 0; 
            DireccioY = 1;
        }
        else if (X == 20 && Y >= 20)
        {
            DireccioX = -1; 
            DireccioY = 0; 
        }
        else if (X <= 1 && Y == 20)
        {
            DireccioX = 0; 
            DireccioY = -1; 
        }
        else if (X == 1 && Y <= 1)
        {
            DireccioX = 1; 
            DireccioY = 0; 
        }
        X += DireccioX; 
        Y += DireccioY;
    }
    
    public override void HeTrobat(Animal_Mari altre)
    {
        if (altre is Pop)
        {
            // Canvi de direcció
            DireccioX *= -1;
            DireccioY *= -1;
        }
    }
}