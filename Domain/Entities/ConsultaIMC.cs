using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ConsultaIMC
    {
        public Guid ConsultaId { get; set; }
        public string NomePaciente { get; set; }
        public string EnderecoCompleto { get; set; }
        public float Altura { get; set; }
        public float Pesokg { get; set; }
        public float Resultado { get; set; }

        public void CalculaResultado()
        {
            Resultado = Pesokg / (Altura * Altura);
        }
    }
}
