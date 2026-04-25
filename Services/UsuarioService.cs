using CrudDapper.Models;
using CrudDapper.Repository;
using Dapper;
using System.Data.SqlClient;

namespace CrudDapper.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IConfiguration _configuration;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IConfiguration configuration, IUsuarioRepository usuarioRepository)
        {

            _configuration = configuration;
            _usuarioRepository = usuarioRepository;
        }

        public async Task<ResponseModel<List<UsuarioListarDTO>>> BuscarUsuarios()
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {

                var usuariosBanco = await connection.QueryAsync<Usuario>("SELECT * FROM Usuarios");

                if (usuariosBanco.Count() == 0)
                {
                    return new ResponseModel<List<UsuarioListarDTO>>()
                    {
                        Mensagem = "Nenhum usuário encontrado",
                        Status = false
                    };

                }
                else
                {
                    var usuariosListarDTO = usuariosBanco.Select(u => new UsuarioListarDTO
                    {
                        IdUsuario = u.IdUsuario,
                        NomeCompleto = u.NomeCompleto,
                        Email = u.Email,
                        Cargo = u.Cargo,
                        Salario = u.Salario,
                        Situacao = u.Situacao
                    }).ToList();
                    return new ResponseModel<List<UsuarioListarDTO>>()
                    {
                        Dados = usuariosListarDTO,
                        Mensagem = "Usuários encontrados com sucesso",
                        Status = true
                    };

                }
            }
        }

        public async Task<ResponseModel<UsuarioListarDTO>> BuscarUsuarioPorId(int idUsuario)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var usuarioBanco = await connection.QueryFirstOrDefaultAsync<Usuario>("SELECT * FROM Usuarios WHERE IdUsuario = @IdUsuario", new { IdUsuario = idUsuario });

                if (usuarioBanco == null)
                {
                    return new ResponseModel<UsuarioListarDTO>()
                    {
                        Mensagem = "Usuário não encontrado",
                        Status = false
                    };
                }
                else
                {
                    var usuarioListarDTO = new UsuarioListarDTO
                    {
                        IdUsuario = usuarioBanco.IdUsuario,
                        NomeCompleto = usuarioBanco.NomeCompleto,
                        Email = usuarioBanco.Email,
                        Cargo = usuarioBanco.Cargo,
                        Salario = usuarioBanco.Salario,
                        Situacao = usuarioBanco.Situacao
                    };
                    return new ResponseModel<UsuarioListarDTO>()
                    {
                        Dados = usuarioListarDTO,
                        Mensagem = "Usuário encontrado com sucesso",
                        Status = true
                    };
                }


            }
        }


    }
}