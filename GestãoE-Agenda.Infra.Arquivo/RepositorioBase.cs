using GestãoTarefas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoE_Agenda.Infra.Arquivo
{
    public class RepositorioBase<T> where T : EntidadeBase
    {
        protected readonly List<T> registros;

        private readonly JsonSerialization<T> registrosJSon;

        protected int contadorId;

        public RepositorioBase(string arquivo)
        {
            registrosJSon = new JsonSerialization<T>(arquivo);
            registros = registrosJSon.Load();
        }

        public RepositorioBase()
        {
            registros = new List<T>();
        }

        public virtual string Inserir(T entidade)
        {
            entidade.id = ++contadorId;
            registros.Add(entidade);
            registrosJSon.Save(registros);
            return "REGISTRO_VALIDO";   
        }

        public bool Editar(T novaEntidade)
        {
            foreach (T entidade in registros)
            {
                if (novaEntidade.id == entidade.id)
                {
                    novaEntidade.id = entidade.id;
        
                    int posicaoParaEditar = registros.IndexOf(entidade);
                    registros[posicaoParaEditar] = novaEntidade;
                    registrosJSon.Save(registros);
                    return true;
                }
            }
            return false;
        }

        public bool Excluir(T novaEntidade)
        {
            registros.Remove(novaEntidade);
            registrosJSon.Save(registros);
            return true;
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        public List<T> Filtrar(Predicate<T> condicao)
        {
            List<T> registrosFiltrados = new List<T>();

            foreach (T registro in registros)
                if (condicao(registro))
                    registrosFiltrados.Add(registro);

            return registrosFiltrados;
        }

    }
}
