internal class Program
{

    public static void cadastraContato(Dictionary<string, string> contatos) {



        Console.Write("Digite o nome do contato: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o telefone: ");
        string telefone = Console.ReadLine();

        contatos.Add(telefone, nome);
        


        foreach(var contato in contatos) {
            Console.WriteLine(contato);
        }
    }

    public static void removerContato (Dictionary<string, string> contatos)
    {

        bool status = false;

        Console.WriteLine("Digite o telefone do contato que deseja remover");
        string TelefoneContatoRemover = Console.ReadLine();

       status =  contatos.Remove(TelefoneContatoRemover);

        if(status == true)
        {
            Console.WriteLine("Contato removido");
        }
        else
        {
            Console.WriteLine("Contato não existe");
        }
    }

    public static void alterarContato(Dictionary<string, string> contatos) {

       Console.Write("Digite o numero do contato que deseja alterar: ");
       String telefone = Console.ReadLine();


       Console.WriteLine (contatos.ContainsKey(telefone));

        contatos.set
    
    }

    private static void Main(string[] args)
    {
        
        Dictionary<string, string> contatos = new Dictionary<string, string>();

        cadastraContato(contatos);

        // removerContato(contatos);

        alterarContato(contatos) ;

    }
}