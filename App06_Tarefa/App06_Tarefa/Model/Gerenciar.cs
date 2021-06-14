using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace App06_Tarefa.Model
{
    public class Gerenciar
    {
        private List<Tarefa> list { get; set; }

        public void salvar(Tarefa t)
        {
            list = GetTarefas();
            list.Add(t);

            salvar(list);
        }

        public List<Tarefa> tarefas()
        {
            return GetTarefas();
        }

        public void finalizar(int i, Tarefa t)
        {
            list = GetTarefas();

            list.RemoveAt(i);

            t.Finalizacao = DateTime.Now;
            list.Add(t);

            salvar(list);
        }

        public void remover(int i)
        {
            list = GetTarefas();
            list.RemoveAt(i);
            salvar(list);
        }

        private void salvar(List<Tarefa> l)
        {
            if (App.Current.Properties.ContainsKey("lista"))
                App.Current.Properties.Remove("lista");

            string s = JsonConvert.SerializeObject(l);
            App.Current.Properties.Add("lista", s);
        }

        private List<Tarefa> GetTarefas()
        {
            try
            {
                if (App.Current.Properties.ContainsKey("lista"))
                {
                    string s = (String)App.Current.Properties["lista"];
                    list = JsonConvert.DeserializeObject<List<Tarefa>>(s);
                    return list;
                }
                return new List<Tarefa>();
            }
            catch
            {
                return new List<Tarefa>();
            }
        }
    }
}