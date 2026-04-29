using System.Data.Common;
using System.Reflection.PortableExecutable;

Console.WriteLine("Digite a coordenada inicial x:");

int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a coordenada inicial Y:");
int Y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a direcao inicial do robo:");
char direcao = Convert.ToChar(Console.ReadLine());

Console.ReadLine();

Console.WriteLine("Digite os comandos para o robo: E, D ou M:");

string? Comando = Console.ReadLine();

char[] instrucoes = Comando.ToCharArray();

for (int i = 0; i < instrucoes.Length; i++)
{

    //Virador pra esquerda
    if (instrucoes[i] == 'E')
    {
        if (direcao == 'N')
        {
            direcao = 'O';
        }
        else if (direcao == 'O')
        {
            direcao = 'S';
        }
        else if (direcao == 'S')
        {
            direcao = 'L';
        }
        else
        {
            direcao = 'N';
        }
    }
    //Virador pra direita
    else if (instrucoes[i] == 'D')
    {
        if (direcao == 'N')
        {
            direcao = 'L';
        }
        else if (direcao == 'L')
        {
            direcao = 'S';
        }
        else if (direcao == 'S')
        {
            direcao = 'O';
        }
        else
        {
            direcao = 'N';
        }
    }

    //Andador
    else if (instrucoes[i] == 'M')
    {
        if (direcao == 'N')
        {
            Y++;
        }
        else if (direcao == 'L')
        {
            X++;
        }
        else if (direcao == 'S')
        {
            Y--;
        }
        else
        {
            X--;
        }
    }

    else
    {
        Console.WriteLine("A  instrucao" + instrucoes[i] + "Nao eh uma instrucao valida e foi ignorada");
    }

}

Console.WriteLine("A posicao final do robo eh: " + X + " " + Y + " e ele esta apontado para a direcao " + direcao);