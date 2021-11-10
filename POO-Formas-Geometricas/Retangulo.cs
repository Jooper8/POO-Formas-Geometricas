namespace POO_Formas_Geometricas
{
    class Retangulo : Forma
    {
        //Declaração das variáveis double Largura e Altura, junto com a utilização de automatic properties.
        public double Largura { get; set; }
        public double Altura { get; set; }
        //Declaração do construtor Retangulo, que utiliza as variáveis largura, altura e cor, da classe Cor.
        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            //Associação das variáveis do construtor com as variáveis da classe.
            Largura = largura;
            Altura = altura;
        }
        //Método para sobrescrever a definição de área encontrada em Forma.
        public override double Area()
        {
            //Cálculo matemático da área de um retângulo.
            return Largura * Altura;
        }
    }
}
