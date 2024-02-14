using static Imc.Pages.Home;

namespace Imc.Shared
{
    public class RegistroIMC
    {
        public string Mensagem { get; set; }
        public string Resultado { get; set; }
        public DateTime Data { get; set; }
        public CalculoIMC Calculo { get; set; }

        public RegistroIMC(CalculoIMC calculo, string resultado, string mensagem)
        {
            Mensagem = mensagem;
            Resultado = resultado;
            Data = DateTime.Now;
            Calculo = calculo;
        }


    }
}