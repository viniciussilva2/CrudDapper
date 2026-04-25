using CrudDapper.Models;

namespace CrudDapper.Repository
{
    public interface IUsuarioRepository
    {
        Task<ResponseModel<List<UsuarioListarDTO>>> BuscarUsuarios();
    }
}
