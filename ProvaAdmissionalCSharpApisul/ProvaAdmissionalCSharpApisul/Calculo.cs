using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ProvaAdmissionalCSharpApisul
{
    class Calculo
    {

        //Cria lista de elevador com a sua frequência
        List<int> elevadorFrequentado = new List<int>();

        public List<int> andarMenosUtilizado()
        {
            //Chama metodo lerArquivoJson
            var predio99 = lerArquivoJson(AppDomain.CurrentDomain.BaseDirectory + @"\input.json");

            //Cria lista de andar com número de utilizações
            List<int> andarUtilizado = new List<int>();

            //Cria lista de andar(es) menos utilizado(s)
            List<int> andarMenosUtil = new List<int>();

            int i = 0;

            //Zera o valor de utilização dos andares
            for (i = 0; i < 16; i++)
            {
                andarUtilizado.Add(0);
            }


            //Declaração de variáveis
            int menor = 0;

            //Preenche o número de utilização dos andares
            for (i = 0; i < predio99.Count; i++)
            {

                switch (predio99[i].andar)
                {
                    case 0:
                        andarUtilizado[0]++;
                        break;
                    case 1:
                        andarUtilizado[1]++;
                        break;
                    case 2:
                        andarUtilizado[2]++;
                        break;
                    case 3:
                        andarUtilizado[3]++;
                        break;
                    case 4:
                        andarUtilizado[4]++;
                        break;
                    case 5:
                        andarUtilizado[5]++;
                        break;
                    case 6:
                        andarUtilizado[6]++;
                        break;
                    case 7:
                        andarUtilizado[7]++;
                        break;
                    case 8:
                        andarUtilizado[8]++;
                        break;
                    case 9:
                        andarUtilizado[9]++;
                        break;
                    case 10:
                        andarUtilizado[10]++;
                        break;
                    case 11:
                        andarUtilizado[11]++;
                        break;
                    case 12:
                        andarUtilizado[12]++;
                        break;
                    case 13:
                        andarUtilizado[13]++;
                        break;
                    case 14:
                        andarUtilizado[14]++;
                        break;
                    case 15:
                        andarUtilizado[15]++;
                        break;

                }


            }

            //Encontra o andar menos utilizado
            for (i = 0; i < 16; i++)
            {
                if (i == 0)
                {
                    menor = andarUtilizado[i];
                }
                else if (andarUtilizado[i] < menor)
                {
                    menor = andarUtilizado[i];
                    andarMenosUtil.Add(i);
                }

            }

            //Verificar se existe outro andar com a mesma utilização
            for (i = 0; i < 16; i++)
            {

                if ((andarUtilizado[i] == menor) && (andarUtilizado[i] == andarUtilizado[0]))
                {
                    andarMenosUtil.Add(i);
                }

            }
            return andarMenosUtil;

        }

        public List<char> elevadorMaisFrequentado()
        {
            //Chama metodo lerArquivoJson
            var predio99 = lerArquivoJson(AppDomain.CurrentDomain.BaseDirectory + @"\input.json");

            //Cria lista de elevador(es) mais utilizado(s)
            List<int> elevadorMaisUtil = new List<int>();

            //Cria lista com letra do(s) elevador(es) mais utilizado(s)
            List<char> elevadorMaisUtilLetra = new List<char>();

            int i = 0;

            //Zera o valor de frequência dos elevadores
            for (i = 0; i < 5; i++)
            {
                elevadorFrequentado.Add(0);
            }


            //Declaração de variáveis
            int maior = 0;

            //Preenche o número de utilização dos elevadores
            for (i = 0; i < predio99.Count; i++)
            {

                switch (predio99[i].elevador)
                {
                    case 'A':
                        elevadorFrequentado[0]++;
                        break;
                    case 'B':
                        elevadorFrequentado[1]++;
                        break;
                    case 'C':
                        elevadorFrequentado[2]++;
                        break;
                    case 'D':
                        elevadorFrequentado[3]++;
                        break;
                    case 'E':
                        elevadorFrequentado[4]++;
                        break;

                }


            }

            //Encontra o maior valor de frquência
            for (i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    maior = elevadorFrequentado[i];
                }
                else if (elevadorFrequentado[i] > maior)
                {
                    maior = elevadorFrequentado[i];

                }

            }

            //Verificar qual elevador com o maior frequência e se existe mais de um
            for (i = 0; i < 5; i++)
            {

                if (elevadorFrequentado[i] == maior)
                {
                    elevadorMaisUtil.Add(i);
                }

            }

            //Modifica resultado numérico por letra do elevador
            for (i = 0; i < elevadorMaisUtil.Count; i++)
            {

                switch (elevadorMaisUtil[i])
                {
                    case 0:
                        elevadorMaisUtilLetra.Add('A');
                        break;
                    case 1:
                        elevadorMaisUtilLetra.Add('B');
                        break;
                    case 2:
                        elevadorMaisUtilLetra.Add('C');
                        break;
                    case 3:
                        elevadorMaisUtilLetra.Add('D');
                        break;
                    case 4:
                        elevadorMaisUtilLetra.Add('E');
                        break;

                }


            }
            return elevadorMaisUtilLetra;

        }

        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            //Chama metodo lerArquivoJson
            var predio99 = lerArquivoJson(AppDomain.CurrentDomain.BaseDirectory + @"\input.json");

            //Chama metodo com o elevador menos frequentado
            var elevadorMaisFreq = elevadorMaisFrequentado();

            //Cria lista fluxo do elevador 
            int[,] elevadorFluxo = new int[3, elevadorMaisFrequentado().Count];

            //Cria lista de periodo de maior fluxo
            List<int> periodoMaiorFluxo = new List<int>();

            //Cria lista de periodo de maior fluxo letra
            List<char> periodoMaiorFluxoLetra = new List<char>();


            int i = 0;
            int j = 0;


            //Zera o valor do fluxo do elevador
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < elevadorMaisFreq.Count; j++)
                {
                    elevadorFluxo[i, j] = 0;
                }
            }


            //Declaração de variáveis
            int maior = 0;


            //Preenche o número de utilização do elevador em cada periodo
            for (i = 0; i < elevadorMaisFreq.Count; i++)
            {
                for (j = 0; j < predio99.Count; j++)

                    if (Convert.ToChar(elevadorMaisFreq[i]) == predio99[j].elevador)
                    {

                        switch (predio99[j].turno)
                        {

                            case 'M':
                                elevadorFluxo[0, i]++;
                                break;
                            case 'V':
                                elevadorFluxo[1, i]++;
                                break;
                            case 'N':
                                elevadorFluxo[2, i]++;
                                break;

                        }
                    }
            }




            //Encontra o maior fluxo
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < elevadorMaisFreq.Count; j++)
                {
                    if (i == 0)
                    {
                        maior = elevadorFluxo[i, j];
                    }
                    else if (elevadorFluxo[i, j] > maior)
                    {
                        maior = elevadorFluxo[i, j];
                    }

                }
            }


            //Verificar qual o maior periodo e se existe mais de um
            for (j = 0; j < elevadorMaisFreq.Count; j++)
                for (i = 0; i < 3; i++)
                {
                    {

                        if (elevadorFluxo[i, j] == maior)
                        {
                            periodoMaiorFluxo.Add(i);
                        }

                    }
                }

            //Modifica resultado numérico por letra do periodo
            for (i = 0; i < periodoMaiorFluxo.Count; i++)
            {

                switch (periodoMaiorFluxo[i])
                {
                    case 0:
                        periodoMaiorFluxoLetra.Add('M');
                        break;
                    case 1:
                        periodoMaiorFluxoLetra.Add('V');
                        break;
                    case 2:
                        periodoMaiorFluxoLetra.Add('N');
                        break;

                }


            }
            return periodoMaiorFluxoLetra;

        }

        public List<char> elevadorMenosFrequentado()
        {
            //Chama metodo lerArquivoJson
            var predio99 = lerArquivoJson(AppDomain.CurrentDomain.BaseDirectory + @"\input.json");

            //Cria lista de elevador(es) menos utilizado(s)
            List<int> elevadorMenosUtil = new List<int>();

            //Cria lista com letra do(s) elevador(es) mais utilizado(s)
            List<char> elevadorMenosUtilLetra = new List<char>();

            int i = 0;


            //Declaração de variáveis
            int menor = 0;

            //Zera o valor de frequência dos elevadores
            for (i = 0; i < 5; i++)
            {
                elevadorFrequentado.Add(0);
            }

            //Preenche o número de utilização dos elevadores
            for (i = 0; i < predio99.Count; i++)
            {

                switch (predio99[i].elevador)
                {
                    case 'A':
                        elevadorFrequentado[0]++;
                        break;
                    case 'B':
                        elevadorFrequentado[1]++;
                        break;
                    case 'C':
                        elevadorFrequentado[2]++;
                        break;
                    case 'D':
                        elevadorFrequentado[3]++;
                        break;
                    case 'E':
                        elevadorFrequentado[4]++;
                        break;

                }
            }

            //Encontra a menor frequência
            for (i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    menor = elevadorFrequentado[i];
                }
                else if (elevadorFrequentado[i] <= menor)
                {
                    menor = elevadorFrequentado[i];
                }

            }


            //Verificar qual o elevador com menor frequência e se existe mais de um
            for (i = 0; i < 5; i++)
            {

                if (elevadorFrequentado[i] == menor)
                {
                    elevadorMenosUtil.Add(i);
                }

            }

            //Modifica resultado numérico por letra do elevador
            for (i = 0; i < elevadorMenosUtil.Count; i++)
            {

                switch (elevadorMenosUtil[i])
                {
                    case 0:
                        elevadorMenosUtilLetra.Add('A');
                        break;
                    case 1:
                        elevadorMenosUtilLetra.Add('B');
                        break;
                    case 2:
                        elevadorMenosUtilLetra.Add('C');
                        break;
                    case 3:
                        elevadorMenosUtilLetra.Add('D');
                        break;
                    case 4:
                        elevadorMenosUtilLetra.Add('E');
                        break;

                }


            }
            return elevadorMenosUtilLetra;

        }

        public List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            //Chama metodo lerArquivoJson
            var predio99 = lerArquivoJson(AppDomain.CurrentDomain.BaseDirectory + @"\input.json");

            //Chama metodo com o elevador menos frequentado
            var elevadorMenosFreq = elevadorMenosFrequentado();

            //Cria lista fluxo do elevador 
            int[,] elevadorFluxo = new int[3, elevadorMenosFrequentado().Count];

            //Cria lista de periodo de maior fluxo
            List<int> periodoMenorFluxo = new List<int>();

            //Cria lista de periodo de maior fluxo letra
            List<char> periodoMenorFluxoLetra = new List<char>();


            int i = 0;
            int j = 0;


            //Zera o valor do fluxo do elevador
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < elevadorMenosFreq.Count; j++)
                {
                    elevadorFluxo[i, j] = 0;
                }
            }


            //Declaração de variáveis
            int menor = 0;


            //Preenche o número de utilização do elevador em cada periodo
            for (i = 0; i < elevadorMenosFreq.Count; i++)
            {
                for (j = 0; j < predio99.Count; j++)

                    if (Convert.ToChar(elevadorMenosFreq[i]) == predio99[j].elevador)
                    {

                        switch (predio99[j].turno)
                        {

                            case 'M':
                                elevadorFluxo[0, i]++;
                                break;
                            case 'V':
                                elevadorFluxo[1, i]++;
                                break;
                            case 'N':
                                elevadorFluxo[2, i]++;
                                break;

                        }
                    }
            }




            //Encontra o menor fluxo
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < elevadorMenosFreq.Count; j++)
                {
                    if (i == 0)
                    {
                        menor = elevadorFluxo[i, j];
                    }
                    else if (elevadorFluxo[i, j] < menor)
                    {
                        menor = elevadorFluxo[i, j];
                    }

                }
            }


            //Verificar qual o menor periodo e se existe mais de um
            for (j = 0; j < elevadorMenosFreq.Count; j++)
                for (i = 0; i < 3; i++)
                {
                    {

                        if (elevadorFluxo[i,j] == menor)
                        {
                            periodoMenorFluxo.Add(i);
                        }

                    }
                }
            
                        //Modifica resultado numérico por letra do periodo
                        for (i = 0; i < periodoMenorFluxo.Count; i++)
                        {

                            switch (periodoMenorFluxo[i])
                            {
                                case 0:
                                    periodoMenorFluxoLetra.Add('M');
                                    break;
                                case 1:
                                    periodoMenorFluxoLetra.Add('V');
                                    break;
                                case 2:
                                    periodoMenorFluxoLetra.Add('N');
                                    break;

                            }


                        }
            return periodoMenorFluxoLetra;

        }

        public List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            //Chama metodo lerArquivoJson
            var predio99 = lerArquivoJson(AppDomain.CurrentDomain.BaseDirectory + @"\input.json");

            //Cria lista fluxo do elevador 
            List<int> elevadorFluxo = new List<int>();           

            //Cria lista de periodo de maior fluxo
            List<int> periodoMaiorFluxo = new List<int>();

            //Cria lista de periodo de maior fluxo letra
            List<char> periodoMaiorFluxoLetra = new List<char>();


            int i = 0;           

            //Zera o valor do fluxo do elevador
            for (i = 0; i < 3; i++)
            {
                elevadorFluxo.Add(0);
            }


            //Declaração de variáveis
            int maior = 0;

            //Preenche o número de utilização do elevador em cada periodo
            for (i = 0; i < predio99.Count; i++)
            {
               
                        switch (predio99[i].turno)
                        {

                            case 'M':
                                elevadorFluxo[0]++;
                                break;
                            case 'V':
                                elevadorFluxo[1]++;
                                break;
                            case 'N':
                                elevadorFluxo[2]++;
                                break;

                        }
                    
            }


            //Encontra o maior fluxo
            for (i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    maior = elevadorFluxo[i];
                }
                else if (elevadorFluxo[i] > maior)
                {
                    maior = elevadorFluxo[i];
                }

            }

            //Verificar qual o maior periodo e se existe mais de um
            for (i = 0; i < 3; i++)
            {

                if (elevadorFluxo[i] == maior)
                {
                    periodoMaiorFluxo.Add(i);
                }

            }

            //Modifica resultado numérico por letra do elevador
            for (i = 0; i < periodoMaiorFluxo.Count; i++)
            {

                switch (periodoMaiorFluxo[i])
                {
                    case 0:
                        periodoMaiorFluxoLetra.Add('M');
                        break;
                    case 1:
                        periodoMaiorFluxoLetra.Add('V');
                        break;
                    case 2:
                        periodoMaiorFluxoLetra.Add('N');
                        break;

                }


            }
            return periodoMaiorFluxoLetra;

        }

        public float percentualDeUsoElevadorA()
        {
            //Chama metodo lerArquivoJson
            var predio99 = lerArquivoJson(AppDomain.CurrentDomain.BaseDirectory + @"\input.json");

            //Cria lista de elevador com a sua frequência
            List<float> elevadorFrequentadoPor = new List<float>();

            int i = 0;

            //Zera o valor de frequência dos elevadores
            for (i = 0; i < 2; i++)
            {
                elevadorFrequentadoPor.Add(0);
            }



            //Preenche o número de utilização dos elevadores
            for (i = 0; i < predio99.Count; i++)
            {

                switch (predio99[i].elevador)
                {
                    case 'A':
                        elevadorFrequentadoPor[0]++;
                        break;
                    case 'B':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'C':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'D':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'E':
                        elevadorFrequentadoPor[1]++;
                        break;

                }


            }
  

            float retorno = elevadorFrequentadoPor[0] / (elevadorFrequentadoPor[0] + elevadorFrequentadoPor[1]);

            return retorno * 100  ;

        }

        public float percentualDeUsoElevadorB()
        {
            //Chama metodo lerArquivoJson
            var predio99 = lerArquivoJson(AppDomain.CurrentDomain.BaseDirectory + @"\input.json");

            //Cria lista de elevador com a sua frequência
            List<float> elevadorFrequentadoPor = new List<float>();

            int i = 0;

            //Zera o valor de frequência dos elevadores
            for (i = 0; i < 2; i++)
            {
                elevadorFrequentadoPor.Add(0);
            }



            //Preenche o número de utilização dos elevadores
            for (i = 0; i < predio99.Count; i++)
            {

                switch (predio99[i].elevador)
                {
                    case 'B':
                        elevadorFrequentadoPor[0]++;
                        break;
                    case 'A':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'C':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'D':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'E':
                        elevadorFrequentadoPor[1]++;
                        break;

                }


            }


            float retorno = elevadorFrequentadoPor[0] / (elevadorFrequentadoPor[0] + elevadorFrequentadoPor[1]);

            return retorno * 100;

        }

        public float percentualDeUsoElevadorC()
        {
            //Chama metodo lerArquivoJson
            var predio99 = lerArquivoJson(AppDomain.CurrentDomain.BaseDirectory + @"\input.json");

            //Cria lista de elevador com a sua frequência
            List<float> elevadorFrequentadoPor = new List<float>();

            int i = 0;

            //Zera o valor de frequência dos elevadores
            for (i = 0; i < 2; i++)
            {
                elevadorFrequentadoPor.Add(0);
            }



            //Preenche o número de utilização dos elevadores
            for (i = 0; i < predio99.Count; i++)
            {

                switch (predio99[i].elevador)
                {
                    case 'C':
                        elevadorFrequentadoPor[0]++;
                        break;
                    case 'A':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'B':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'D':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'E':
                        elevadorFrequentadoPor[1]++;
                        break;

                }


            }


            float retorno = elevadorFrequentadoPor[0] / (elevadorFrequentadoPor[0] + elevadorFrequentadoPor[1]);

            return retorno * 100;

        }

        public float percentualDeUsoElevadorD()
        {
            //Chama metodo lerArquivoJson
            var predio99 = lerArquivoJson(AppDomain.CurrentDomain.BaseDirectory + @"\input.json");

            //Cria lista de elevador com a sua frequência
            List<float> elevadorFrequentadoPor = new List<float>();

            int i = 0;

            //Zera o valor de frequência dos elevadores
            for (i = 0; i < 2; i++)
            {
                elevadorFrequentadoPor.Add(0);
            }



            //Preenche o número de utilização dos elevadores
            for (i = 0; i < predio99.Count; i++)
            {

                switch (predio99[i].elevador)
                {
                    case 'D':
                        elevadorFrequentadoPor[0]++;
                        break;
                    case 'A':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'B':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'C':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'E':
                        elevadorFrequentadoPor[1]++;
                        break;

                }


            }


            float retorno = elevadorFrequentadoPor[0] / (elevadorFrequentadoPor[0] + elevadorFrequentadoPor[1]);

            return retorno * 100;

        }

        public float percentualDeUsoElevadorE()
        {
            //Chama metodo lerArquivoJson
            var predio99 = lerArquivoJson(AppDomain.CurrentDomain.BaseDirectory + @"\input.json");

            //Cria lista de elevador com a sua frequência
            List<float> elevadorFrequentadoPor = new List<float>();

            int i = 0;

            //Zera o valor de frequência dos elevadores
            for (i = 0; i < 2; i++)
            {
                elevadorFrequentadoPor.Add(0);
            }



            //Preenche o número de utilização dos elevadores
            for (i = 0; i < predio99.Count; i++)
            {

                switch (predio99[i].elevador)
                {
                    case 'E':
                        elevadorFrequentadoPor[0]++;
                        break;
                    case 'A':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'B':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'C':
                        elevadorFrequentadoPor[1]++;
                        break;
                    case 'D':
                        elevadorFrequentadoPor[1]++;
                        break;

                }


            }


            float retorno = elevadorFrequentadoPor[0] / (elevadorFrequentadoPor[0] + elevadorFrequentadoPor[1]);

            return retorno * 100;

        }

        public List<ProvaAdmissionalCSharpApisul.Predio99> lerArquivoJson(string jsonArquivo)
        {
            //Carrega os dados do arquivo json na memória.

            var json = File.ReadAllText(jsonArquivo);

            var js = new DataContractJsonSerializer(typeof(List<Predio99>));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));

            return (List<Predio99>)js.ReadObject(ms);

        }
    }
}

