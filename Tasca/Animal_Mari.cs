using System;

namespace Tasca;

public enum Sexes
{
    Masculi,
    Femeni,
    Sense
}

public abstract class Animal_Mari
{

    protected int X;
    protected int Y;
    protected int DireccioX;
    protected int DireccioY;

    public Sexes Sexe { get; set; }
    protected static Random rnd = new Random();
    protected bool viu = true;
    private int Id;
    public Animal_Mari(int x, int y, Sexes? sexe, bool viu = true)
    {
        Id = Id++;
        X = x;
        Y = y;
        if (sexe == null)
        {
            Sexe = (Sexes)rnd.Next(0, 2) == 0 ? Sexes.Masculi : Sexes.Femeni;
        }

        Direccio();
    }

    protected void Direccio()
    {
        int dir = rnd.Next(0, 4);
        DireccioX = 0;
        DireccioY = 0;
        switch (dir)
        {
            // Nort
            case 0:
                DireccioY = -1;
                break;
            // Sud
            case 1:
                DireccioY = 1;
                break;
            // Est
            case 2:
                DireccioX = 1;
                break;
            // Oest
            case 3:
                DireccioX = -1;
                break;
        }
    }

    protected virtual void Moviment()
    {
        // Moviment del anial mari
        X += DireccioX;
        Y += DireccioY;
        // En cas de que toquin un lateral sense tocar un peix tornarà al lloc contrari a la seva direcció
        if (X < 1)
        {
            X = 20;
        }


        if (X > 20)
        {
            X = 1;
        }

        if (Y < 1)
        {
            Y = 20;
        }

        if (Y > 20)
        {
            Y = 1;
        }
    }

    public (int, int) ObtenirPosicio()
    {
        (int, int) posicio = (X, Y);
        return posicio;
    }

    public void Mata()
    {
        viu = false;
    }

    public abstract void HeTrobat(Animal_Mari altre);
}

