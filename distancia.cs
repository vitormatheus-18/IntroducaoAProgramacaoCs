using System;
//VitorMatheus
// lendo a distância (em Km) e calculando quanto tempo leva (em minutos) para a moto Y tomar certa distância da moto X.
class Desafio {
    static void Main() {
        int quilometros = Int32.Parse(Console.ReadLine());
        int minutos = quilometros * 2; // Digite aqui o calculo dos minutos
        Console.WriteLine(minutos + " minutos");
    }
}