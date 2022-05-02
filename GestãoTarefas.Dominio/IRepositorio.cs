using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoTarefas.Dominio
{
    public interface IRepositorio<T> where T : EntidadeBase
    {
        string Inserir(T entidade);
        bool Editar(T entidade);
        bool Excluir(T entidade);
        List<T> SelecionarTodos();

        // bool Editar(Predicate<T> condicao, T novaEntidade);
        // bool Excluir(Predicate<T> condicao);
        // bool ExisteRegistro(Predicate<T> condicao);
        // T SelecionarRegistro(Predicate<T> condicao);
        // List<T> Filtrar(Predicate<T> condicao);
    }
}
