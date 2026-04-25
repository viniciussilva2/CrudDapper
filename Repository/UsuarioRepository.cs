using CrudDapper.Models;

namespace CrudDapper.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Task<ResponseModel<List<UsuarioListarDTO>>> BuscarUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
