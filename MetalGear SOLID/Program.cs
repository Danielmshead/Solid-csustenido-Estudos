namespace MetalGearSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraSalario cs = new CalculadoraSalario();
            Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000);
            double resultado;

            resultado = cs.Calcula(funcionario);

            Console.WriteLine(" O salário de um desenvolvedor que ganha 2000 bruto é :" + resultado);
            Console.ReadKey();
        }
    }
}
