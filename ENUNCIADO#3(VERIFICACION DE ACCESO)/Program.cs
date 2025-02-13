string usuario="castillo12";
string password="UMG";

Console.WriteLine("Ingrese su usuario por favor");
string usuarioIngresado=Console.ReadLine();
Console.WriteLine("Ingrese su contraseña por favor");
string passwordIngresado=Console.ReadLine();

if(usuarioIngresado==usuario && passwordIngresado==password){
    Console.WriteLine("Acceso concedido");
} if (usuarioIngresado==usuario && passwordIngresado!=password){
    Console.WriteLine("Contraseña incorrecta");
} if (usuarioIngresado!=usuario){
    Console.WriteLine("El usuario no esta registrado");
}