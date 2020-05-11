namespace CodingChallenge.Data.AbstractClasses
{
    public abstract class FormaGeometrica
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public string NameOf()
        {
            return this.GetType().Name.ToString();
        }
    }
}
