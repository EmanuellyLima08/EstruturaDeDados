internal class Program
{
    private static void Main(string[] args)
    {
        //TRABALHANDO COM LISTA (LIST)
        //Criando uma lista
        List<string> frutas = new List<string>();

        //Adicionar itens na lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        //Imprimir os itens da lista
        frutas.ForEach(Console.WriteLine); //Resolução correta

        //Impressão da lista em uma única linhas
        //Como estávamos fazendo:
        //Console.WriteLine("Minha lista de frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}

        //Minha resolução 1:
        //foreach (var arg in args)
        //{
        //    Console.WriteLine("Minha lista de frutas:\n" + string.Join("\n", frutas));

        //Minha resolução 2:
        //void ImprimirLista(List<string> frutas)
        //{
        //    Console.WriteLine("Minha lista de frutas:\n" + string.Join("\n", frutas));
        //}

        //Resolução correta
        //frutas.ForEach(Console.WriteLine);

        Console.WriteLine(); //Pular a linha

        //Imprimir elemento na posição específica
        Console.WriteLine("Fruta no índice 2: " + frutas[2]);

        //Inserir um elemento no índice específico
        frutas.Insert(1, "Maracujá");

        Console.WriteLine(); //Pular a linha

        ////Imprimindo a lista novamente
        frutas.ForEach(Console.WriteLine); //Resolução correta

        //Alterar um elemento no índice específico
        frutas[4] = "Pêra";

        Console.WriteLine(); //Pular a linha

        //Imprimindo a lista novamente
        frutas.ForEach(Console.WriteLine); //Resolução correta

        //Removendo elemento da lista no índice específico
        frutas.RemoveAt(3);

        //Remover elementos pelo valor do conteúdo
        frutas.Remove("Morango");

        Console.WriteLine(); //Pular a linha

        //Imprimindo a lista novamente
        frutas.ForEach(Console.WriteLine); //Resolução correta

        //Apagar todos os elementos da lista
        frutas.Clear();

        //Imprimindo a lista novamente
        frutas.ForEach(Console.WriteLine); //Resolução correta

        Console.WriteLine(); //Pular a linha
        Console.WriteLine("========================================");
        Console.WriteLine(); //Pular a linha


        //TRABALHANDO COM DICIONÁRIO (DICTIONARY)
        //Criando um dicionário de dados
        Dictionary<int, string> carros = new Dictionary<int, string>();

        //Adicionar dados a um dicionário
        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        Console.WriteLine("Meu dicionário de carros: ");
        //Imprimir um dicionário de dados
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }
        Console.WriteLine(); //Pular a linha
        Console.WriteLine("========================================");
        Console.WriteLine(); //Pular a linha


        //TRABALHANDO COM FILA
        //Criar uma fila (queue)
        Queue<string> filaBanco = new Queue<string>();

        //Adicionar elementos em uma fila
        filaBanco.Enqueue("André"); //enqueue = enfileirar
        filaBanco.Enqueue("João");
        filaBanco.Enqueue("Maria");
        filaBanco.Enqueue("Bia");

        foreach (var pessoa in filaBanco) //foreach = imprimir na ordem pelo laço
        {
            Console.WriteLine(pessoa);
        }

        Console.WriteLine(); //Pular a linha
        Console.WriteLine("========================================");
        Console.WriteLine(); //Pular a linha

        //Retirar o primeiro elemento de uma fila
        filaBanco.Dequeue();

        foreach (var pessoa in filaBanco) //foreach = imprimir na ordem pelo laço
        {
            Console.WriteLine(pessoa);
        }

        //Verificar se existe um elemento na fila
        bool achou = filaBanco.Contains("Bia");

        if (achou) //'achou' dentro no if => achou == true
        {
            Console.WriteLine("A pessoa está na fila!");
        }
        else
        {
            Console.WriteLine("A pessoa não está na fila!");
        }

        Console.WriteLine(); //Pular a linha
        Console.WriteLine("========================================");
        Console.WriteLine(); //Pular a linha


        //TRABALHANDO COM PILHA (STACK)
        //Criando uma pilha
        Stack<string> livros = new Stack<string>();

        //Adicionar elementos em uma pilha
        livros.Push("Chapeuzinho Vermelho");
        livros.Push("Branca de Neve");
        livros.Push("Princesa e o Sapo");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine(); //Pular a linha
        Console.WriteLine("========================================");
        Console.WriteLine(); //Pular a linha

        //Remove o primeiro elemento da pilha (debaixo)
        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

    }
}