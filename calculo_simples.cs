using System; 

class URI {

    static void Main(string[] args) { 

        string[] dadosPeca1 = Console.ReadLine().Split();
        int codigoPeca1 = int.Parse(dadosPeca1[0]);
        int numeroPecas1 = int.Parse(dadosPeca1[1]);
        double valorUnitarioPeca1 = double.Parse(dadosPeca1[2]);

        string[] dadosPeca2 = Console.ReadLine().Split();
        int codigoPeca2 = int.Parse(dadosPeca2[0]);
        int numeroPecas2 = int.Parse(dadosPeca2[1]);
        double valorUnitarioPeca2 = double.Parse(dadosPeca2[2]);

        double totalPeca1 = numeroPecas1 * valorUnitarioPeca1;
        double totalPeca2 = numeroPecas2 * valorUnitarioPeca2;

        double totalPagar = totalPeca1 + totalPeca2;

        Console.WriteLine($"VALOR A PAGAR: R$ {totalPagar:F2}");

    }

}