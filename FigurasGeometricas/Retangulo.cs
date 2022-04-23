public class Retangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area { get => Base * Altura; }
    public double Perimetro { get => 2 * (Base + Altura); }

    public Retangulo(double Base, double altura)
    {
        this.Base = Base;
        this.Altura = altura;
    }
}