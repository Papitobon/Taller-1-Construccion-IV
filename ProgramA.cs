/* TALLER 1 - CONSTRUCCION DE SOFTWARE I
SAMUEL TOBON CARTAGENA
NICOLAS RESTREPO MUÑOZ
CAROLINA RESTREPO URREGO*/

//PUNTO 1

/*Console.WriteLine("Ingrese el valor obtenido en el trimestre: \n");
int value = Int32.Parse(Console.ReadLine());                                              // Pide valor al cliente
value = value*4;
int tax = 0;                                                                              // Definir variables de impuesto y porcentaje
int percent = 0;
if(value < 10000) percent=5;
if (value >= 10000 & value <= 20000) percent=10;
if (value > 20000 & value <= 35000) percent=15;                                           // If para definir el porcentaje
if (value > 35000 & value <= 45000) percent=20;
if(value > 45000) percent=30;
tax = (percent*value)/100;                                                              //Operacion para definir el impuesto
Console.WriteLine("Su renta anual es: \n" + value + "\nEl total de renta a pagar: \n" + tax + "\nEl porcentaje de impuesto es del "+ percent);*/
// La linea de arriba es la salida de los datos pedidos

//PUNTO 2

/*Console.WriteLine("Ingrese su nombre completo: ");
string name = Console.ReadLine();
Console.WriteLine("Ingrese su edad: ");                                                  //Pide los datos de nombre y edad
int age = Int32.Parse(Console.ReadLine());
int price = 15000;                                                                              //Define variables de precio y porcentaje
int percent = 0;

if(age < 4){
Console.WriteLine("Su entrada es GRATIS!!!");
Environment.Exit(0);} 
if(age >=4 & age <= 18)percent = 5;                                                           //If para definir porcentaje de descuento
if( age > 18)percent = 3;
percent = (percent*15000)/100;                                                                // Operacion para definir el total a pagar
price = price - percent;
Console.WriteLine("Su nombre es: " + name + "\nEl valor de su entrada: \n" + price + "\nSu descuento es de: " + percent);*/
//La linea de arriba es la salida con los valores pedidos

// PUNTO 3

/*Console.WriteLine("Pizzas disponibles: \n- Vegetariana \n- No vegetariana \nIngrese el tipo de pizza:\n");
string pizza = Console.ReadLine();                                                               //Pide la variable del tipo de pizza
int add = 0;
string ingredient= "";                                                                           //Se define una variable para guardar el ingrediente elegido
if(pizza.Equals("vegetariana", StringComparison.CurrentCultureIgnoreCase)){                      //If para identificar tipo de pizza sea como la escriba el usuario
    Console.WriteLine("Digite un ingrediente para agregar a su pizza\n- Pulse 1 para Pimiento\n- Pulse 2 para Champiñones");
    add = Int32.Parse(Console.ReadLine());                                                        // Pide ingrediente
    if(add ==  1)ingredient ="Pimiento";                                                          //If para identificar ingrediente
    if(add ==  2)ingredient ="Champiñones";
}
if(pizza.Equals("no vegetariana", StringComparison.CurrentCultureIgnoreCase)){
    Console.WriteLine("Digite un ingrediente para agregar a su pizza\n- Pulse 1 para Pepperoni\n- Pulse 2 para Salami");
    add = Int32.Parse(Console.ReadLine());
    if(add ==  1)ingredient ="Pepperoni";                                                           //Este if funciona igual que el anterior pero con el otro tipo de pizza
    if(add ==  2)ingredient ="salami";
}
Console.WriteLine("Su pizza es: " + pizza + "\nIngredientes:\n- Mozzarella\n- Tomate \n- " + ingredient);*/
//La linea de arriba imprime las salidas pedidas

 //PUNTO 4

/*Console.WriteLine("Ingrese la puntuacion del empleado: ");
float points = float.Parse(Console.ReadLine());                                                      // Pide la puntuacion del empleado
float total = 0;
if(points == 0.0){ Console.WriteLine("No tiene bonificacion");
    Environment.Exit(0);}
if(points == 4){
    total=20000;                                                                                       // If para definir la bonificacion segun la puntuacion
}
if(points == 6){
    total=30000;
}
Console.WriteLine("Su bonificacion es de: " + total + " y su puntaje de: 0." + points);*/
// La linea de arriba imprime la salida con los datos pedidos
