int numero;

Console.WriteLine("Digite un numero por favor:");
numero = int.Parse(Console.ReadLine());

if (numero == 1){
    Console.WriteLine("Dia lunes");
}else if (numero == 2){
    Console.WriteLine("Dia martes");
}
else if (numero == 3){
    Console.WriteLine("Dia miercoles");
}
else if (numero == 4){
    Console.WriteLine("Dia jueves");
}
else if (numero == 5){
    Console.WriteLine("Dia viernes");
}
else if (numero == 6){
    Console.WriteLine("Dia sabado");
}
else if (numero == 7){
    Console.WriteLine("Dia domingo");
}
else{
    Console.WriteLine("Numero no valido");
}