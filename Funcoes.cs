using System.Globalization;

class FuncoesL
{
    Tela tel = new Tela();
    Login[] login = new Login[0];

    public void NovoLogin(Login novoLogin)
    {
        Login[] newArray = new Login[login.Length + 1];
        for (int p = 0; p < login.Length; p++)
        {
            newArray[p] = login[p];
        }
        newArray[newArray.Length - 1] = novoLogin;
        login = newArray;
    }
    public void Lista()
    {
        tel.EscrP("____ Lista de ID e usuarios ____");
        for (int p = 0; p < login.Length; p++)
        {
            Login user = login[p];
            tel.EscrP($"ID: {p + 1} - {user.NameUser}");
        }
    }
    public void Excluir(int pExc)
    {
        Login[] newArry = new Login[login.Length - 1];
        for (int p = 0; p < newArry.Length; p++)
        {
            if (p >= pExc)
            {
                newArry[p] = login[p + 1];
            }
            else
            {
                newArry[p] = login[p];
            }
        }
        login = newArry;
    }
    public bool CheckPass(string nameUser, string passUser)
    {
        bool LoginEfetuado = false;
        foreach (var user in login)
        {

            if (user.NameUser.Equals(nameUser) && user.PassUser.Equals(passUser))
            {
                tel.EscrP("LOGIN EFETUADO...");
                LoginEfetuado = true;
                break;
            }
            else
            {
                tel.EscrP("Usuario ou senha incorretos, tente novamente");
            }
        }
        return LoginEfetuado;
    }
}
class FuncoesG
{
    Pneus[] pneus = new Pneus[0];
    Tela tel = new Tela();

    public void Novo(Pneus newPneus)
    {
        Pneus[] newArry = new Pneus[pneus.Length + 1];
        for (int p = 0; p < pneus.Length; p++)
        {
            newArry[p] = pneus[p];
        }
        newArry[newArry.Length - 1] = newPneus;
        pneus = newArry;
    }
    public void Lista()
    {
        tel.EscrP("\n*****Lista de produtos em estoque*****");
        for (int p = 0; p < pneus.Length; p++)
        {
            Pneus prod = pneus[p];
            tel.EscrP($"[{p + 1}] {prod.Marca} - {prod.NacImp} {prod.Borracha}, {prod.Especif} |PREÇO R${prod.Preco}| Disponivel {prod.Estoque} no estoque.");
        }
    }
    public void Remover(int pRemov)
    {
        Pneus[] newArry = new Pneus[pneus.Length - 1];
        for (int p = 0; p < newArry.Length; p++)
        {
            if (p >= pRemov)
            {
                newArry[p] = pneus[p + 1];
            }
            else
            {
                newArry[p] = pneus[p];
            }
        }
        pneus = newArry;
    }
    public void EEst(int p, int qtd)
    {
        pneus[p].Estoque += qtd;
    }
    public void SEst(int p, int qtd)
    {
        pneus[p].Estoque -= qtd;
    }
}