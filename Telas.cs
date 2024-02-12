class Tela
{
    public void EscrM(string msg)
    {
        Console.Write(msg);
    }
    public void EscrP(string msg)
    {
        Console.WriteLine(msg);
    }
    public void MenuLogin()
    {
        EscrP("______________________________________");
        EscrP("||||  Escolha uma opção do MENU   ||||");
        EscrP("|||| [1] - Login  [2] - Cadastrar ||||");
        EscrP("|||| [3] - Sair   [4] - Lista     ||||");
        EscrP("|||| [0] - Excluir usuario        ||||");
        EscrP("--------------------------------------");
    }
    public void MenuLogado()
    {
        EscrP("\n          _-_-_-_-_-_-_-_Escolha uma opção do MENU_-_-_-_-_-_-_-_");
        EscrP("         |[1] Novo                         [4]Entrada de Estoque |");
        EscrP("         |[2] Listar Produtos              [5]Saída de Estoque   |");
        EscrP("         |[3] Remover Produtos             [0]Sair               |");
        EscrP("         ---------------------------------------------------------");
    }

}