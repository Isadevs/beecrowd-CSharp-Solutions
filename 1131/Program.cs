// See https://aka.ms/new-console-template for more information
/*A Federação Gaúcha de Futebol contratou você para escrever um 
programa para fazer uma estatística do resultado de vários GRENAIS. 
Escreva um programa para ler o número de gols marcados pelo Inter e 
pelo Grêmio em um GRENAL. Logo após escrever a mensagem 
"Novo grenal (1-sim 2-nao)" e solicitar uma resposta. Se a resposta for 1, 
o algoritmo deve ser executado novamente solicitando 
o número de gols marcados pelos times em uma nova partida, 
caso contrário deve ser encerrado imprimindo:

- Quantos GRENAIS fizeram parte da estatística.
- O número de vitórias do Inter.
- O número de vitórias do Grêmio.
- O número de Empates.
- Uma mensagem indicando qual o time que venceu o maior número de 
GRENAIS (ou "Nao houve vencedor", caso termine empatado).

Entrada
O arquivo de entrada contém 2 valores inteiros, correspondentes aos 
gols marcados pelo Inter e pelo Grêmio respectivamente. 
Em seguida háverá um inteiro (1 ou 2), correspondente à 
repetição do programa.

Saída
Após cada leitura dos gols, deve ser impressa a mensagem 
"Novo grenal (1-sim 2-nao)". Quando o algoritmo for 
encerrado devem ser mostradas as estatísticas conforme a 
descrição apresentada acima. Obs: a palavra "Gremio" deve 
ser impressa sem acento, conforme o exemplo abaixo.

O que é GRENAL?
Grenal é: disputa de times do futebol brasileiro


*/


string[] num_gols;


int grenais = 1;
int numGols_Inter = 0;
int numGols_Gremio = 0;
int placar_inter = 0;
int placar_gremio = 0;
int empates = 0;

num_gols = Console.ReadLine().Split(' ');

Console.WriteLine("Novo grenal (1-sim 2-nao)");
int op = Convert.ToInt32(Console.ReadLine());


while (op == 1)
{
   
    numGols_Inter = Convert.ToInt32(num_gols[0]);
    numGols_Gremio = Convert.ToInt32(num_gols[1]);

    if (numGols_Inter > numGols_Gremio)
    {
        placar_inter = placar_inter + 1;
    }
    else if (numGols_Inter == numGols_Gremio)
    {
        empates = empates + 1 ;
    }
    else
    {
        placar_gremio = placar_gremio + 1;
    }
    
    num_gols = Console.ReadLine().Split(' ');
    Console.WriteLine("Novo grenal (1-sim 2-nao)");
    op = Convert.ToInt32(Console.ReadLine());

    grenais++;

}

Console.WriteLine($"{grenais} grenais");
Console.WriteLine($" Inter:{placar_inter}");
Console.WriteLine($" Gremio:{placar_gremio}");
Console.WriteLine($" Empates:{placar_gremio}");

if (placar_inter > placar_gremio)
{
    Console.WriteLine("Inter venceu mais");
}
else
{
    Console.WriteLine("Gremio venceu mais");
}


