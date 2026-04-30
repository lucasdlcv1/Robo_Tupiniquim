
Console.WriteLine("Digite a coordenada inicial x:");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a coordenada inicial Y:");
int Y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a direcao inicial do robo:");
char direcao = Convert.ToChar(Console.ReadLine().ToUpper());

while (true)
{
    Console.WriteLine("Digite os comandos para o robo: E, D ou M:");

    string? Comando = Console.ReadLine().ToUpper();

    if (string.IsNullOrWhiteSpace(Comando))
    {
        Console.WriteLine("Comando Vazio");
        continue;
    }

    char[] instrucoes = Comando.ToCharArray();

    for (int i = 0; i < instrucoes.Length; i++)
    {
        switch (instrucoes[i])
        {
            case 'E':
                VirarEsquerda();
                break;

            case 'D':
                VirarDireita();
                break;

            case 'M':
                {
                    Mover();
                    break;
                }

            default:
                {
                    Console.WriteLine("A  instrucao" + instrucoes[i] + "Nao eh uma instrucao valida e foi ignorada");
                    break;
                }

        }
    }
    Console.WriteLine("A posicao final do robo é: x=" + X + " e y=" + Y + " e ele esta apontado para a direcao " + direcao);

    Console.WriteLine("Deseja mover o robô novamente? s/n");
    char? continuar = Convert.ToChar(Console.ReadLine());

    if (continuar == 'n' || continuar == 'N')
    {
        break;
    }

}

void Mover()
{
    switch (direcao)
    {
        case 'N': Y++; break;
        case 'S': Y--; break;
        case 'L': X++; break;
        case 'O': X--; break;
    }
}
void VirarDireita()
{
    switch (direcao)
    {
        case 'N':
            direcao = 'L';
            break;

        case 'O':
            direcao = 'N';
            break;

        case 'S':
            direcao = 'O';
            break;

        case 'L':
            direcao = 'S';
            break;
    }
}
void VirarEsquerda()
{
    switch (direcao)
    {
        case 'N':
            direcao = 'O';
            break;

        case 'O':
            direcao = 'S';
            break;

        case 'S':
            direcao = 'L';
            break;

        case 'L':
            direcao = 'N';
            break;
    }
}