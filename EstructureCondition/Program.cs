// See https://aka.ms/new-console-template for more information

/*int cantidadProductosVendidos;
int cantidadProdutosDeposito = 50;
int stock;

Console.WriteLine("Ingrese la cantidad de productos vendidos");

cantidadProductosVendidos = Convert.ToInt32(Console.ReadLine());

stock = cantidadProdutosDeposito - cantidadProductosVendidos;

if (stock == 0)
{
    Console.WriteLine("Reponer stock de productos");
    // cantidadProdutosDeposito = cantidadProdutosDeposito + 10;
    cantidadProdutosDeposito += 10;
    Console.WriteLine("Productos cargados en el deposito");
} else
{
    if (stock <= 5)
    {
        Console.WriteLine("Stock minimo, reponer stock del producto");
        cantidadProdutosDeposito += 5;
        Console.WriteLine("Productos cargados en el deposito");
     //   Console.WriteLine($"Informar a ventas {stock} productos sin vender");
    }
    Console.WriteLine($"Informar a ventas {stock} productos sin vender");
    //Console.WriteLine("Informar a ventas {0} productos sin vender",stock);
}

Console.ReadKey();*/


// UNIVERSIDAD

//string comision = string.Empty;

//int nota = 0;
//Console.WriteLine("Ingrese la comision");
//comision = Console.ReadLine();

//switch (comision)
//{
//    case "A":
//        Console.WriteLine("Turno mañana");
//        break;
//    case "B":
//        Console.WriteLine("Turno tarde");
//        break;
//    case "C":
//        Console.WriteLine("Turno noche");
//        break;
//    default:
//        Console.WriteLine("Sin turno asignado");
//        break;
//}

//Console.WriteLine("Ingrese la nota");
//nota = int.Parse(Console.ReadLine());

//if (nota < 4)
//{
//    Console.WriteLine("Reprobo");
//}
//else
//{
//    if(nota <= 7)
//    {
//        Console.WriteLine("Aprobo la cursada");
//    }
//    else
//    {
//        Console.WriteLine("Promocionó");
//    }
//}

//Console.ReadKey();



//EJERCICIO

const int password = 12345678;
const string category = "A";
string descriptionCategory = string.Empty;
int getPassword;

Console.WriteLine("Bienvenido Usuario. ingrese sus datos");

getPassword = Convert.ToInt32(Console.ReadLine());

switch (category)
{
    case "A":
        descriptionCategory = "Administrador";
        break;
    case "B":
        descriptionCategory = "Write";
        break;
    default: 
        Console.WriteLine("No tiene categoria");
        break;
}

if (password == getPassword)
{
    Console.WriteLine("Bienvenido, usted tiene usuario tipo " + descriptionCategory);
}
else
{
    Console.WriteLine("La contraseña es incorrecta, vuelve a ingresarla");
    getPassword = Convert.ToInt32(Console.ReadLine());
    if(password == getPassword)
    {
        Console.WriteLine("Bienvenido, ingrese sus datos");
    }
    else
    {
        Console.WriteLine("Usted no esta registrado");
    }
}

Console.ReadKey();