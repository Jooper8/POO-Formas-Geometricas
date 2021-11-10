namespace POO_Formas_Geometricas
{
    //Declaração da classe abstrata Forma, que será utilizada como base pelas classes Circulo de Ratangulo.
    abstract class Forma
    {
        //Declaração da variável Color, que é baseada no enum Color da classe Cor.
        public Color Color { get; set; }
        //Declaração do construtor Forma, junto com a utilização da variável color, que se baseia na classe Color.
        public Forma(Color color)
        {
            //Associação das variáveis do construtor com as variáveis da classe.
            Color = color;
        }
        //Declaração do método que sera á sobrescrito nas classes Retangulo e Circulo.
        public abstract double Area();
    }
}
