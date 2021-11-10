using System;

namespace POO_Formas_Geometricas
{
    class Circulo : Forma
    {
        public double Raio { get; set; }
        //Declaração do construtor Circulo, que utiliza as raio e cor, da classe Cor.
        public Circulo(double raio, Color color) : base(color)
        {
            //Associação das variáveis do construtor com o da classe.
            Raio = raio;
        }
        //Método para sobrescrever a definição de área encontrada em Forma.
        public override double Area()
        {
            //Cálculo matemático da área de um círculo.
            return Math.PI * Raio * Raio;
        }
    }
}
