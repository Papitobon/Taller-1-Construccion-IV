/* TALLER 1 - CONSTRUCCION DE SOFTWARE I
SAMUEL TOBON CARTAGENA
NICOLAS RESTREPO MUÑOZ
CAROLINA RESTREPO URREGO*/

//PUNTO 1

/*Console.WriteLine("Ingrese el valor obtenido en el trimestre: \n");
int value = Int32.Parse(Console.ReadLine());
value = value*4;
int tax = 0;
int percent = 0;

if(value < 10000) percent=5;
if (value >= 10000 & value <= 20000) percent=10;
if (value > 20000 & value <= 35000) percent=15;
if (value > 35000 & value <= 45000) percent=20;
if(value > 45000) percent=30;

tax = (percent*value)/100;

Console.WriteLine("Su renta anual es: \n" + value + "\nEl total de renta a pagar: \n" + tax + "\nEl porcentaje de impuesto es del "+ percent);*/

//PUNTO 2

/*Console.WriteLine("Ingrese su nombre completo: ");
string name = Console.ReadLine();

Console.WriteLine("Ingrese su edad: ");
int age = Int32.Parse(Console.ReadLine());

int price = 15000;
int percent = 0;
int aux= 0;

if(age < 4){
Console.WriteLine("Su entrada es GRATIS!!!");
Environment.Exit(0);} 

if(age >=4 & age <= 18)percent = 5;
if( age > 18)percent = 3;

percent = (percent*15000)/100;
price = price - percent;

Console.WriteLine("Su nombre es: " + name + "\nEl valor de su entrada: \n" + price + "\nSu descuento es de: " + percent);*/

// PUNTO 3

/*Console.WriteLine("Pizzas disponibles: \n- Vegetariana \n- No vegetariana \nIngrese el tipo de pizza:\n");
string pizza = Console.ReadLine();
int add = 0;
string ingredient= "";

if(pizza.Equals("vegetariana", StringComparison.CurrentCultureIgnoreCase)){
    Console.WriteLine("Digite un ingrediente para agregar a su pizza\n- Pulse 1 para Pimiento\n- Pulse 2 para Champiñones");
    add = Int32.Parse(Console.ReadLine());
    if(add ==  1)ingredient ="Pimiento";
    if(add ==  2)ingredient ="Champiñones";
}
if(pizza.Equals("no vegetariana", StringComparison.CurrentCultureIgnoreCase)){
    Console.WriteLine("Digite un ingrediente para agregar a su pizza\n- Pulse 1 para Pepperoni\n- Pulse 2 para Salami");
    add = Int32.Parse(Console.ReadLine());
    if(add ==  1)ingredient ="Pepperoni";
    if(add ==  2)ingredient ="salami";
}

Console.WriteLine("Su pizza es: " + pizza + "\nIngredientes:\n- Mozzarella\n- Tomate \n- " + ingredient);*/

// PUNTO 4

/*Console.WriteLine("Ingrese la puntuacion del empleado: ");
float points = float.Parse(Console.ReadLine());
float total = 0;

if(points == 0.0){ Console.WriteLine("No tiene bonificacion");
    Environment.Exit(0);}

if(points == 4){
    total=20000;
}
if(points == 6){
    total=30000;
}

Console.WriteLine("Su bonificacion es de: " + total + " y su puntaje de: 0." + points);*/