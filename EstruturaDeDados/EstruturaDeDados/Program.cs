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

        //Console.WriteLine("Minha lista de frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}



        //Impressão da lista em uma única linhas
        //Minha resolução 1:
        //foreach (var arg in args)
        //{
        //    Console.WriteLine("Minha lista de frutas:\n" + string.Join("\n", frutas));
        //Minha resolução 2:
        //void ImprimirLista(List<string> frutas)
        //{
        //    Console.WriteLine("Minha lista de frutas:\n" + string.Join("\n", frutas));
        //}
        //frutas.ForEach(Console.WriteLine); //Resolução correta



        Console.WriteLine(); //Pular a linha

        //Imprimir elemento na posição específica
        Console.WriteLine("Fruta no índice 2: " + frutas[2]);

        //Inserir um elemento no índice específico
        frutas.Insert(1, "Maracujá");

        Console.WriteLine(); //Pular a linha

        ////Imprimindo a lista novamente
        frutas.ForEach(Console.WriteLine); //Resolução correta
        //Console.WriteLine("Minha lista de frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}

        //Alterar um elemento no índice específico
        frutas[4] = "Pêra";

        Console.WriteLine(); //Pular a linha

        //Imprimindo a lista novamente
        frutas.ForEach(Console.WriteLine); //Resolução correta
        //Console.WriteLine("Minha lista de frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}

        //Removendo elemento da lista no índice específico
        frutas.RemoveAt(3);

        //Remover elementos pelo valor do conteúdo
        frutas.Remove("Morango");

        Console.WriteLine(); //Pular a linha

        //Imprimindo a lista novamente
        frutas.ForEach(Console.WriteLine); //Resolução correta
        //Console.WriteLine("Minha lista de frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}

        //Apagar todos os elementos da lista
        frutas.Clear();

        //Imprimindo a lista novamente
        frutas.ForEach(Console.WriteLine); //Resolução correta

        Console.WriteLine(); //Pular a linha


        //Imprimindo a lista novamente
        //Console.WriteLine("Minha lista de frutas:");
        //foreach (string fruta in frutas)
        //{
        //    Console.WriteLine(fruta);
        //}
    }
}