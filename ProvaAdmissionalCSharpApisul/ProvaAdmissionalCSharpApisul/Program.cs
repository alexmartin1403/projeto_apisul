using System;

namespace ProvaAdmissionalCSharpApisul
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia a classe Calculo
            Calculo cal = new Calculo();

            //Grava o retorno do metodo na variável
            var andarMenosUtil = cal.andarMenosUtilizado();

            //Exibe a lista de andar(es) meno(s) utilizado(s)
            Console.Write("O(s) andar(es) menos utilizado(s) pelos usuários é(são) o(s) andar(es): ");            
            Console.WriteLine(string.Join(" e ", andarMenosUtil));
            Console.WriteLine("");

            //Grava o retorno do metodo na variável
            var elevadorMaisUtil = cal.elevadorMaisFrequentado();

            //Grava o retorno do metodo na variável
            var elevadorPeriodo = cal.periodoMaiorFluxoElevadorMaisFrequentado();
            
            Console.Write("O(s) elevador(es) mais frequentado(s) pelos usuários é(são) o(s) elevador(es) ");
            elevadorMaisUtil.ForEach(Console.Write);
            Console.Write(" e o(s) periodo(s) que se encontra(m) maior fluxo é(são) o: ");            
            Console.WriteLine(string.Join(" e ", elevadorPeriodo));
            Console.WriteLine("");

            //Grava o retorno do metodo na variável
            var elevadorMenosUtil = cal.elevadorMenosFrequentado();

            Console.Write("O(s) elevador(es) menos frequentado(s) pelos usuários é(são) o(s) elevador(es) ");            
            Console.Write(string.Join(" e ", elevadorMenosUtil));            

            //Grava o retorno do metodo na variável
            var elevadorPeriodoMenor = cal.periodoMenorFluxoElevadorMenosFrequentado();

            Console.Write(" e o(s) periodo(s) que se encontra(m) menor fluxo é(são) o: ");
            Console.WriteLine(string.Join(" e ", elevadorPeriodoMenor));
            Console.WriteLine("");

            //Grava o retorno do metodo na variável
            var periodoMaiorElevadores = cal.periodoMaiorUtilizacaoConjuntoElevadores();

            Console.Write("O(s) periodo(s) de maior utilização do conjunto de elevadores é(são) o(s): ");
            Console.WriteLine(string.Join(" e ", periodoMaiorElevadores));
            Console.WriteLine("");

            //Grava o retorno do metodo na variável
            var porcentagemA = cal.percentualDeUsoElevadorA();

            Console.Write("O percentual de uso do elevador A em relação a todos os serviços prestados é de: ");
            Console.Write(porcentagemA.ToString("N2"));
            Console.WriteLine(" %");
            Console.WriteLine("");

            //Grava o retorno do metodo na variável
            var porcentagemB = cal.percentualDeUsoElevadorB();

            Console.Write("O percentual de uso do elevador B em relação a todos os serviços prestados é de: ");
            Console.Write(porcentagemB.ToString("N2"));
            Console.WriteLine(" %");
            Console.WriteLine("");

            //Grava o retorno do metodo na variável
            var porcentagemC = cal.percentualDeUsoElevadorC();

            Console.Write("O percentual de uso do elevador C em relação a todos os serviços prestados é de: ");
            Console.Write(porcentagemC.ToString("N2"));
            Console.WriteLine(" %");
            Console.WriteLine("");

            //Grava o retorno do metodo na variável
            var porcentagemD = cal.percentualDeUsoElevadorD();

            Console.Write("O percentual de uso do elevador D em relação a todos os serviços prestados é de: ");
            Console.Write(porcentagemD.ToString("N2"));
            Console.WriteLine(" %");
            Console.WriteLine("");

            //Grava o retorno do metodo na variável
            var porcentagemE = cal.percentualDeUsoElevadorE();

            Console.Write("O percentual de uso do elevador E em relação a todos os serviços prestados é de: ");
            Console.Write(porcentagemE.ToString("N2"));
            Console.WriteLine(" %");
        }
    }
}
