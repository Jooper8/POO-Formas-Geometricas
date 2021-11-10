//Frederico Guilherme Camilli Proença RA:200925

using System;
using System.Collections.Generic;
using System.Globalization;

namespace POO_Formas_Geometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da variável char ch.
            char ch;
            //Declaração da lista baseada na classe abstrata Forma.
            List<Forma> list = new();
            //Interação com o usuário, requerindo o número de formas.
            Console.WriteLine("Entre com o número de formas: ");
            //Inserção do usuário sobre o número de formas a serem inseridas na lista.
            int n = int.Parse(Console.ReadLine());

            //Repetição "for" utilizada para adicionar formas à lista.
            for (int i = 1; i <= n; i++)
            {
                //Interação com o usuário, noticiando-o sobre o número da forma e requerindo se tal é Retângulo ou Círculo.
                Console.WriteLine($"Forma#{i}:");
                Console.Write("Retângulo ou Circulo (R para retângulo, qualquer outra letra para círculo)?");
                //Inserção do usuário para inserir um retângulo ou círculo na lista de formas.
                ch = char.Parse(Console.ReadLine());
                ch = char.ToUpper(ch); //Transformação da variável inserida em maiúscula, para que o programa consiga prosseguir mesmo caso o usuário utilize letras minúsculas.
                //Interação com o usuário, requerindo a cor da forma entre as três disponíveis.
                Console.Write("Cor: (Preto/Azul/Vermelho): ");
                //Inserção do usuário sobre a cor da forma.
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                //Condição a ser seguida caso o usuário digitar "R", que representa um retângulo.
                if (ch == 'R')
                {
                    //Declaração das variáveis double largura e altura.
                    double largura, altura;
                    //Interação com o usuário, requerindo a largura do retângulo.
                    Console.Write("Largura: ");
                    //Inserção do usuário sobre a largura do retângulo.
                    largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Interação com o usuário, requerindo a largura do retângulo.
                    Console.Write("Altura: ");
                    //Inserção do usuário sobre a largura do retângulo.
                    altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Inserção do retângulo preenchido pelo usuário à lista.
                    list.Add(new Retangulo(largura, altura, cor));
                }
                //Condição caso o usuário digite qualquer outra letra além de "R", indicando um círculo.
                else
                {
                    //Interação com o usuário, requerindo o raio do círculo.
                    Console.WriteLine("Raio: ");
                    //Inserção do usuário sobre o raio do círculo.
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    //Inserção da círculo preenchido pelo usuário à lista.
                    list.Add(new Circulo(raio, cor));
                }
            }
            //Preparação para exibir as áreas das formas, em sequência.
            Console.WriteLine("\nÁrea de cada forma: ");
            //Utilização da repetição foreach, para exibir as formas inseridas na lista.
            foreach (Forma forma in list)
            {
                //Exibição das áreas de todas as formas inseridas pelo usuário, em ordem, com no máximo dois caracteres.
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
