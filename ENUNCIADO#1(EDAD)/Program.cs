int edad;

Console.WriteLine("Ingresa tu edad: ");
edad = int.Parse(Console.ReadLine());
if (edad < 12) {
    Console.WriteLine("Eres un niño");
}
else if (edad >= 12 && edad <= 17) {
    Console.WriteLine("Eres un adolescente");
}
else if (edad >= 18 && edad <= 59) {
    Console.WriteLine("Eres un adulto");
}
else {
    Console.WriteLine("Eres un adulto mayor");
}