using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoE_Agenda.Infra.Arquivo
{
    internal interface ISerializator<T> where T : class
    {
        List<T> Load();
        void Save(List<T> t);
    }
}
