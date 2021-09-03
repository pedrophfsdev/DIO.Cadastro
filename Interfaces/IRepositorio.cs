using System.Collections.Generic;
namespace DIO.Cadastro.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int d);
         void Insere (T entidade);
         void Exclui (int id);
         void Atualiza (int id, T entidade);
         int ProximoId ();

    }
}