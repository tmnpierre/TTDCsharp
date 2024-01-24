namespace Demo01.Bibliotheque
{
    public class Calcul //Ctrl + r + r = renommer la classe et le fichier
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }

        public double Division(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }
    }
}
