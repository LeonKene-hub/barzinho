﻿//entrada

//mostrar opcoes de bebidas
Console.WriteLine(@$"
                 Seja bem vindo!

----------------------------------------------------
|              Escolha a sua bebida:               |
|                                                  |
|  1 coca-cola     2 Fanta uva   3 Fanta laranja   |
|  4 nescau        5 Uisque      6 Monster         |
----------------------------------------------------
");

//opcao de bebida escolhida
int selecionada = int.Parse(Console.ReadLine());
string bebida = "nada";

//processo
switch (selecionada)
{
    case 1:
    Console.WriteLine($"Coca-cola escolhida");
    bebida = "Coca-cola";
    break;

    case 2:
    Console.WriteLine($"Fanta uva escolhida");
    bebida = "Fanta uva";
    break;

    case 3:
    Console.WriteLine($"Fanta laranja escolhida");
    bebida = "Fanta laranja";
    break;

    case 4:
    Console.WriteLine($"Nescau escolhida");
    bebida = "Nescau";
    break;

    case 5:
    Console.WriteLine($"Uisque escolhida");
    bebida = "Uisque";
    break;

    case 6:
    Console.WriteLine($"Monster escolhida");
    bebida = "Monster";
    break;

    case 666:
    Console.WriteLine($"VOCE ESCOLHEU CAFE COM CHUMBINHO, MONSTER E COCA-COLA, BATIZADO! PRA TE DEIXAR EM PE ATE O FIM DOS TEMPOS!!");
    bebida = "Emcapetada!";
    break;

    default:
    Console.WriteLine($"Ocorreu algum erro selecione novamente");
    break;
}

//com gelo ou sem
Console.WriteLine($"Dejesa gelo em sua bebida? digite sim ou nao:");
string gelo = Console.ReadLine().ToLower();
string comGelo = "";

if (gelo == "sim")
{
    comGelo = "com gelo";
}
else if (gelo == "nao")
{
    comGelo = "sem gelo";
}
else
{
    comGelo = "com gelo";
    Console.WriteLine($"Okey, ja que voce nao sabe decidir, eu vou colocar gelo ");
}

//saida
Console.WriteLine($"Aqui esta sua {bebida}, {comGelo}. Aproveite ");
Console.WriteLine(@$"
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓░░░░░░░░▓▓▓░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓░░░░░░░░▓▓▓░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓░▓▓▓▓▓▓▓░░░░░░░░░▒░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓░░░░░░░░░░░░▓ ▓▓░░░░░░░▒▒▒▒░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░▓▓▓▓░░░▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░▓░░▒▒░▓░░▓░░░░░░░░░░░░░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓░░▓░░░░░▓░░░░░░░░░▓░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓░░░░░░▓▓░░░░░░░▓▓▓░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░░░░░░░░░░░░░░░▓▓▓░░▓▓░░░░░░░░▓▓▓▓▓▓▓▓░░▓▓▓▓▓▓▓▓▓▓▓░▓▓▓▓▓▓▓▓▓▓░░░░░░░▓▓░░░░░░░▒░░░░░░░░
░░░░░░░░░░░░░░░░░░░▓▓▓░░░░░░░▓▓▓▓░░░░░░░░░░░░░░░▓▓▓░▓▓▓▓▓▓▓▓▓▓▓▓░░░▓▓▓▓▓▓░▓▓▓▓▓▓▓▓▓▓░░▓▓▓▓▓▓▓▓▓▓▓░░░░░░░▓░░░▒▒▒▒▒▒▒░░▒░░
░░░░░░░░░░░░░░░░░░░▓▓▓▓░░░░░░▓▓▓▓░░░░░░░░░░░░░░░▒▒░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▓▓▓▓░░▓▓░░░░▓░░▓░▒▒░▓▓▓▓▓░▒░▒░░
▓▓░░░░░░░░░░░░░░░░░▒▒▒░░░░░░░▓▓▓▓░░░░░░░░░░░░░░░▒▒░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▓▓▓▓░░░▓▓░░░▓░░░▓▒▒░▓▓▓▓▓░▒░▒░▒
▓▓░░░░░░░░░░░░░░░░▒▒▒▒▒░░░░░░░▒▒▒░░░░░░░░░░░░░░░▒▒░░▓░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░▓▓▓▓░░░░░▓░░░▓░░░▓▒▒░▓▓▓▓▓░▒░▒░▒
▓▓░░░░░░░░░░░░░░░▒▒▒▒▒▒▒░░░░░░▒▒▒░░░░░░░░░░░░░▒▒▒▒▒░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░▓▓▓▓░▓▓░░▓░░░▓░░░▓░▓▓▓▓▓▓▓▓▓░▒░▒
▒░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒░░░░░▒▒▒░░░░░░░░░░░░▒▒▒▒▒▒░▓▓░░▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░▓▓▓░▓▓▓░░▓░░░▓▓░░▓░▓▓▓▓▓▓▓▓▓░▒▒▒
▒▒▒▒▒▒░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓░▒▒▓▓▓▓▒▒░░░░░░░░░▒░▓▓▓▓▓▓▓▓░▒░░░▓▓▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░▓▓▓▓▓▓░░░▓▓░░▓▓░░ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓░▒▒▒░░░░░░░░░▓▓▓▓▓▓▓▓▓▓░▒▒▓▓▓▓▒▒▒░░░░░░░▒▓▓▓▓▓▓▓▓▓▓░▒░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓░░▓▓░▓▓░▓▓░░▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓░▒▒▒░░░▒░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░▒░░▓▓▓▓▓▓▓▓▓▓▓░░░▓▓▓░░░░░░░▒▒░▓▓▓▓░▓▓▓▓▓▓▓▓▓▓░░▓░▓░▓▓▓▓▓▓▓░░▓▓░░░▓░░░░░░░░░░░░░
▓▓▓▓▓░▒▒░░░▒░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░▒░░▓▓▓▓▓▓▓▓▓▓▓░▓░░▒▒▒▒░░░░░░░▓▓░░▓▓▓▓▓░░░▓▓▓▓░░▓▓░░▓▓▓▓▓▓▓▓░▓▓▓░░▓░░░░░░░░░░░░░
▓▓▓▓▓▓▓░░▒░░░▒░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▒░░░░▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▓▓▓░░░░░░░░░░░░░░░░░░░▓▓▓▓░░▓▓░▓▓░▓▓▓▓▓▓░▓▓▓░░▓░░░░░░░░░░░░░
▓▓▓▓▓▓▓░░░░▒░▒░▒▒▒▒▒▒▒▒▒▒░▓▓▓▓▓▓▓▓▓▓▓░░░░▒░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓▓▓░░░░░░░░░░░░░░░░░░░▓▓▓▓░░▓▓▓▓▓░▓▓▓▓▓▓░▓▓▓░░▓░░░░░░▓▓▓▓░░░
▓▓▓▓▓▓▓░░▒▒▒░▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▒░▒▒▒░░▒▒▒▒▒▒▒▒▒░▓▓▓▓░░░░░░▓▓░░░░░░░░░░░░░░░░▓▓▓▓░░▓▓▓▓░▓░▓▓▓▓▓▓▓▓▓░░▓░░░░░░▓▓▓▓░░░
▓▓▓▓▓▓▓░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░▓▓▓░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓░░▓▓▓▓▓░░▓ ▓▓▓▓▓▓▓░░▓░░░░░░▓▓▓▓░░░
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▒░░░░░░░░░░░░░░░░░░░▓░▓▓░░▓▓▓░▓░░▓ ▓▓▓▓▓▓▓░░▓░░░░░░▓▓▓▓░░░
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▓░▒░░░░░░░░░░░░░░░░░░▓░▓▓░░▓ ░▓▓░▓▓▓▓▓▓▓▓▓▓░░░▓░░░░░▓▓▓▓░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓░▒▒▒░░░░░░░░░░░░░░░▓░▓░░▓░▓░░░░▓▓░▓▓▓▓▓▓▓░░░▓░░░░░▓▓▓▓░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓ ▓▓▓▓▓▓▓░▒░░░░░░░░░░░▓▓░▓░▓░░▓▓░▓░░░▓▓░▓▓▓▓▓▓▓▓░░▓░░░░░░▒▒▒░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓░░▒░░░▒▒░▓▓▓░▓░▓▓░▓▓▓░▓░░░▓░▓▓▓▓▓▓▓▓░░▓░░░░▒▒▒▒▒▒▒░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓░▓▓░▓▓▓▓░░░▓▓▓▓▓░░░░▓ ▓░▓▓░▓▓▓▓▓▓▒░▓░▓▓▓▓▓▓▓▓▓░░▓░░▒▒▒▒▒▒▒▒▒
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓░▓▓░▓▓▓▓░░░░░░░░░░░░▓▓▓▓▓▓▓░░░░░▒▓░▓░▓▓▓▓▓▓▓▓▓░░▓░░▒▒▒▒▒▒▒▒▒
▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓░░░░▓▓▓░░▓▓▓░░░░░░░░▓▓▓░░░▓▓▓▓▓░░░░░░░▓▓░▓▓▓▓▓▓▓▓▓░░░▓░▒▒▒▒▒▒▒▒▒
▓▓░░░░░░░░░░░░▓▓░░░░░░░░░░░▓▓░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓░░░░▓▓▓░░▓▓▓▓▓░░░░░░▓▓▓░░░▓▓▓▓▓░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓░░░▓░░▓▓▓▓▓▓▓▓
▓▓░░░░░░░░░░░░▓▓░░░░░░░░░░░▓▓░░░░░░░░░░░▓▓░░░░░░░░░░▒▒▒░░░░░▓▓▓░░▓▓▓▓░▒▒░░░▓▓▓░░▓▓▓▓▓▓░░░▓▓▓▓▓▓░░▓▓▓▓▓▓░▓▓▓░░▓▓░▓▓▓▓▓▓▓▓
▓▓░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓░░▓▓░░▓▓░░▓░░▒▒▒░░░░░▓▓▓▓░░▓▓▓░▒▒░▓▓▓▓▓░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓▓▓▓▓░▓▓▓░░▓▓░▓▓▓▓▓▓▓▓
░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░▓▓░▓░░▓▓░░▓░░░▓░▓▓░░░░░░▓▓▓▓▓░░░▓▓▓▓▓░░▓▓▓▓▓░▒▒░░░░░░░░▒▒▒▒▒▒░▓░▓▓▓▓░▓▓▓░░▓▓░▓▓▓▓▓▓▓▓
▓▓▓▓░░░░░░░░▓▓░░▓▓░░░░░░░░░░░░░░░░░▓░░░░░░░░░░░░▓░░░░░▓░░░░▓▓▓░▓░░░▓▓░░░▓▓▓▓▓░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▓▓▓▓▓░▓▓▓▓░░▓ ▓▓▓▓▓▓▓▓
▓▓▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▒░░░░░░░░░░░▓▓▓▓░░▓░▒▒░▓▓░░▓░░░▓░░░▓▓▓▓░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▓▓░▓▓░▓▓▓▓░░▓▓▒▒▒▒▒▒▒▒
▓▓▓▓▓▓░░░░▓░▓░░▓░░░░▓░░░░░░░░░░░░░▓▓░▒░░░░░░░░░▓░░░░░░▓░▒▒▒▓░░░▓▓▓▓░▓▓▓░▒░░▓▓░░░░░░░░░░░░░░░░░░░░░▓▓░▓▓░▓▓▓▓▓░░▓░▒▒▒▒▒▒▒
▓▓▓▓▓▓░░░░▓░▓░░▓░▓▒░░▓░░░░░░░░░░░░▓▓░▒░▓▓▓▓▓▓▓▓░▓░░░░░▓░▒▒▒▒░▓▓▓▓░░░▒▒░░░░░▓▓▓░░░░░░░░░░░░▓▓▓░░░░░▓▓░▓▓░▓▓▓▓▓░░░░▒▒▒▒▒▒▒
▓▓▓▓▓▓░░▒░░▓▒░▓▓▒░▓▒░▓▓░░░░░░░░░░░░▓▓░░░▓░░░░░░▓▓▓▓▓▓░▓▓▓▓░░░░░░░░░░░░░░░░░░▓▓▓░░░░░░░░░░░░░░░░░░▓░░▓▓░▓▓▓▓ ▓▓░░▓▓▓▓▓▓▓▓
▓▓▓▓▓▓░░░░░▓▓▓░░░░░░▒░▓▓░░░░░░░░░░░░░▓░░░░░░░░▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓░░░░░░░░░░░░░░░▓░░▓▓░▓▓▓ ▓▓▓░░▓▓▓▓▓▓▓▓
▓▓▓▓▓▓░░▒░░▓▓▓▓ ▓░░░░░░░░░░▓▓▓░░▒▒░░░░▓░░░░░░▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░░▓▓▓░░░░░░░░░░░▓▓░▓▓▓░▓▓▓▓░░▓▓░▓░░░░░░░
▓▓▓▓▓▓░▒▒░░▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░▓░▓▓░▒▒▓░░░░░▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓░▓░░░░░░░░░░░▓▓▓░▓▓░▓▓▓▓░▓▓▓▓░░▓▓░▓░░░░░░░
▓▓▓▓▓░▒░░▒▒▓▓▓▓▓▓▓▓░▒▒░░▓▓▓▓▓░░░▓▓▓░░░▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓░░░░░░░▓▓▓░░░▓▓▓▓▓░░▓▓░▓▓▓▓░░░▓▓░▓▓░░░░░
▓▓▓▓▓░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▓▓▓▓▓▓▓▓▓▓▓▓▓░░░▓░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓▓▓▓▓░▓░░▓▓░▓▓▓▓░░░▓▓░▓▓░░░░░
▓▓▓▓▓░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▓░▓▓▓▓▓▓▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░▓▓▓░▓ ▓▓░░░░░▓▓▓░░░░░
▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓░░░░░░░▓░░░░░░░░▓▓▓░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓▓░░░▓▓▓░▓ ▓▓░░░░░▓▓▓░░░░░
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░▓░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓░░░░▓▓░▓░▓ ▓▓░░░░░▓▓▓░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓░░░░░░░░░░░░░░░░░▓░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓░░░░░▓▓░▓░▓▓▓▓░░░░░▓▓▓░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░░░░░░░░▓▓░░░▓░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓░░░░░▓░░░▓░▓░░  ░░░░▓░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓░░░░░░░▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓░░░░░░░░░░▓░▓░░▓▓░░░░▓░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓░░▓▓▓▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓▓░░░░░░░░░░░ ▓▓░░░▓░░▓▓░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓░░▓░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓░░░░░░░░░░░░▓░▓░░░▓▓▓▓░░░░░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓░░░░░░░░░░░░░▓▓░░░░░░░▓▓▓▓░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓░░░░░░░░░░░░░░▓▓░░░░░░▓▓▓▓░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓░░░░░░░░░░░░░░▓▓░░░░░░▓▓▓▓░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░▓▓░░▓░░░░░░░░░░░░░░░░░░░░░▒▒▒▒░░░░
░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒░▓▓░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓░░░▓░▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒░░░░
▒▒▒▒░▒░░░░░░▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒░░░░░▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒░▓░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓░▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒░░░░
▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒░▓░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░░▓▒▒▒░░░░░▒░░░▒░▒░░░▒▒▒▒▒▒░░░
");
