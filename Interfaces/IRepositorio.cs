using System.Collections.Generic;

namespace AppDeSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);        
        void Insere(T entidade);        
        void Exclui(int id);        
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
public interface IRepositorio2<T>
    {
        List<T> ListaFilme();
        T RetornaPorId2(int id2);        
        void InsereFilme(T entidade2);        
        void ExcluiFilme(int id2);        
        void AtualizaFilme(int id2, T entidade2);
        int ProximoId2();
    }
}
