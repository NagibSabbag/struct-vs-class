namespace StructProject;

   public struct PontoStruct
   {
      public int X { get; }
      public int Y { get; }

       public PontoStruct(int x, int y)
       {
          X = x;
          Y = y;
       }

       public double Distancia(PontoStruct outro)
       {
          int deltaX = X - outro.X;
          int deltaY = Y - outro.Y;
          return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
       }
   }