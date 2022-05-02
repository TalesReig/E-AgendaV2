using GestãoTarefas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoE_Agenda.Infra.Arquivo
{
    public class RepositorioBase<T> : IRepositorio<T> where T : EntidadeBase
    {
        protected readonly List<T> registros;

        protected int contadorId;

        public RepositorioBase()
        {
            registros = new List<T>();
        }

        public virtual string Inserir(T entidade)
        {
            // string resultadoValidacao = entidade.Validar();
            // 
            // if (resultadoValidacao != "REGISTRO_VALIDO")
            //     return resultadoValidacao;
            // 
            entidade.id = ++contadorId;
            registros.Add(entidade);
            return "REGISTRO_VALIDO";
        }

        public bool Editar(T novaEntidade)
        {
        //    string resultadoValidacao = novaEntidade.Validar();
        //
        //    if (resultadoValidacao != "REGISTRO_VALIDO")
        //        return false;
        //
            foreach (T entidade in registros)
            {
                if (novaEntidade.id == entidade.id)
                {
                    novaEntidade.id = entidade.id;
        
                    int posicaoParaEditar = registros.IndexOf(entidade);
                    registros[posicaoParaEditar] = novaEntidade;
        
                    return true;
                }
            }
            return false;
        }

        public bool Excluir(T novaEntidade)
        {
            registros.Remove(novaEntidade);
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
