class Lahev
{
    public double Kapacita { get; private set; } 
    private double objem; 
    public bool JeOtevrena { get; private set; } = true;

    public double Objem
    {
        get { return objem; }
        set
        {
            if (JeOtevrena)
            {
                objem = Math.Min(value, Kapacita);
            }
        }
    }

    public Lahev(double kapacita)
    {
        Kapacita = kapacita;
        Objem = 0;
    }

    public void Vyprazdnit()
    {
        if (JeOtevrena)
        {
            Objem = 0;
        }
    }

    public void NastavitObjemML(double mililitry)
    {
        if (JeOtevrena)
        {
            Objem = mililitry / 1000.0;
        }
    }

    public double ZiskatObjemML()
    {
        return Objem * 1000.0;
    }

    public void Otevrit()
    {
        JeOtevrena = true;
    }

    public void Zavrit()
    {
        JeOtevrena = false;
    }
}
