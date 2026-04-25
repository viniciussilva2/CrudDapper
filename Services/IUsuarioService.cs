using CrudDapper.Models;

namespace CrudDapper.Services
{
    public interface IUsuarioService
    {
        Task<ResponseModel<List<UsuarioListarDTO>>> BuscarUsuarios();
        Task<ResponseModel<UsuarioListarDTO>> BuscarUsuarioPorId(int idUsuario);
    }
}
