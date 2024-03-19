// See https://aka.ms/new-console-template for more information
public class kontener
{
    private double masa_ladunku;
    private int wysokosc;
    private int waga_wlasna_kontenera;
    private int glebokosc;

    public kontener(int masaLadunku, int wysokosc, int wagaWlasnaKontenera, int glebokosc)
    {
        masa_ladunku = masaLadunku;
        this.wysokosc = wysokosc;
        waga_wlasna_kontenera = wagaWlasnaKontenera;
        this.glebokosc = glebokosc;
    }
}