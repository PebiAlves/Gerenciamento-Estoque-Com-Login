namespace Controle_de_pneu_com_login;

class Program
{
    static void Main(string[] args)
    {
        Tela tel = new Tela();
        FuncoesL funL = new FuncoesL();
        FuncoesG funG = new FuncoesG();

        tel.EscrP("____ SOFTWARE DE CONTROLE DE ESTOQUE ____");
        bool exe1 = true;
        while (exe1 == true)
        {
            tel.MenuLogin();
            tel.EscrM("Digite: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                tel.EscrM("Usuario: ");
                string nameUser = Console.ReadLine();
                tel.EscrM("Senha: ");
                string passUser = Console.ReadLine();
                bool LoginEfetuado = funL.CheckPass(nameUser, passUser);
                while (LoginEfetuado == true)
                {
                    tel.MenuLogado();

                    tel.EscrM("Digite: ");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 0)
                    {
                        tel.EscrP("Saindo...");
                        LoginEfetuado = false;
                        opcao = -1;
                    }
                    else if (opcao == 1)
                    {
                        Pneus pneus = new Pneus();
                        tel.EscrM("Informe a marca: ");
                        pneus.Marca = Console.ReadLine();
                        tel.EscrM("Informe se é NACIONAL ou IMPORTADO: ");
                        pneus.NacImp = Console.ReadLine();
                        tel.EscrM("Informe o tipo da borracha [BORRACHUDO ou LISO]: ");
                        pneus.Borracha = Console.ReadLine();
                        tel.EscrM("Informe a especificação [275/80 r22.5, 295/80 r22.5 ou 315/80 r22.5]: ");
                        pneus.Especif = Console.ReadLine();
                        pneus.Estoque = 0;
                        tel.EscrM("Informe o preço do pneu: ");
                        pneus.Preco = Convert.ToDouble(Console.ReadLine());
                        funG.Novo(pneus);
                        tel.EscrP("\n\nADICIONADO!");
                    }
                    else if (opcao == 2)
                    {
                        funG.Lista();
                    }
                    else if (opcao == 3)
                    {
                        tel.EscrM("Irforme o numero do pneu a ser removido do estoque: ");
                        int r = Convert.ToInt32(Console.ReadLine()) - 1;
                        funG.Remover(r);
                        tel.EscrP("REMOVIDO!");
                    }
                    else if (opcao == 4)
                    {
                        tel.EscrM("Irforme o numero do pneu a para adicionar a quantidade no estoque: ");
                        int p = Convert.ToInt32(Console.ReadLine()) - 1;
                        tel.EscrM("Irforme quantidade de pneus: ");
                        int q = Convert.ToInt32(Console.ReadLine());
                        funG.EEst(p, q);
                    }
                    else if (opcao == 5)
                    {
                        tel.EscrM("Irforme o numero do pneu a para retirar a quantidade no estoque: ");
                        int p = Convert.ToInt32(Console.ReadLine()) - 1;
                        tel.EscrM("Irforme quantidade de pneus: ");
                        int q = Convert.ToInt32(Console.ReadLine());
                        funG.SEst(p, q);
                    }
                    else
                    {
                        tel.EscrP("Opção invalida...");
                    }
                }
            }
            if (opcao == 2)
            {
                Login login = new Login();
                tel.EscrM("Nome do cadastro: ");
                login.NameUser = Console.ReadLine();
                tel.EscrM("Cadastre uma senha: ");
                login.PassUser = Console.ReadLine();
                funL.NovoLogin(login);
                tel.EscrP("Usuario cadastrado...");
            }
            if (opcao == 3)
            {
                tel.EscrP("Saindo...");
                exe1 = false;
            }
            if (opcao == 4)
            {
                funL.Lista();
            }
            if (opcao == 0)
            {
                tel.EscrM("Informe o ID do usuario que desaja excluir: ");
                int d = Convert.ToInt32(Console.ReadLine()) - 1;
                funL.Excluir(d);
                tel.EscrP("Usuario excluido!");
            }
        }
    }
}
