string senhaCorreta = "1234abcd"; 
string senha;

Console.Write("Olá usuário, digite sua senha: ");
senha = Console.ReadLine()!;


if(senha == senhaCorreta)
{
    Console.WriteLine("Acesso Permitido");
}
else
{
    Console.WriteLine("Acesso Negado");
}