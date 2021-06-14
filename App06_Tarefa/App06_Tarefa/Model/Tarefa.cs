using System;

namespace App06_Tarefa.Model
{
    public class Tarefa
    {
        public string Nome { get; set; }
        public DateTime? Finalizacao { get; set; }
        public byte Prioridade { get; set; }
    }
}