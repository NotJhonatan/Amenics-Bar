using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Autenticacao
{
    class Usuario
    {
        public static class UsuarioLogado
        {
            public static int ID { get; set; }
            public static int IDUsuario { get; set; }
            public static string Nome { get; set; }
            public static string RG { get; set; }
            public static string CPF { get; set; }
            public static string Telefone { get; set; }
            public static string Celular { get; set; }
            public static string Email { get; set; }
            public static string Endereco { get; set; }
            public static string cep { get; set; }
            public static string cidade { get; set; }
            public static string UF { get; set; }
            public static string Complemento { get; set; }
            public static string NumeroCasa{ get; set; }
            public static string Cargo { get; set; }
            public static decimal Salario { get; set; }
            public static DateTime DataContratacao { get; set; }
            public static byte[] Foto { get; set; }
            public static string NivelAcesso { get; set; }
        }
    }
}
