using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CrudDapper.Models
{
    public class UsuarioListarDTO
    {

        public int IdUsuario { get; set; }

        public string? NomeCompleto { get; set; }

        public string? Email { get; set; }

        public string? Cargo { get; set; }

        public double Salario { get; set; }

        public bool Situacao { get; set; } // 1 para ativo, 0 para inativo 


    }
}
