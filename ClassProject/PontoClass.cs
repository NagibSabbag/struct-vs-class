namespace ClassProject;

public class PontoClass
{
    public int X { get; }
    public int Y { get; }

    public PontoClass(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double Distancia(PontoClass outro)
    {
        int deltaX = X - outro.X;
        int deltaY = Y - outro.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }
}