using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class UsuarioBusiness
    {
        Database.UsuarioDatabase db = new Database.UsuarioDatabase();

        public tb_usuario ModeloUsuario(string nome, string senha)
        {
            tb_usuario usuario = db.usuario(nome, senha);

            return usuario;
        }

        public tb_usuario UsuarioPorFuncionario(int funcionario)
        {
            tb_usuario usuario = db.UsuarioPorFuncionario(funcionario);

            return usuario;
        }

        public tb_usuario ConsultarPorID(int id)
        {
            tb_usuario usuario = db.ConsultarPorID(id);

            return usuario;
        }

        public List<tb_usuario> ListaDeUsuariosNome(string nome)
        {
            List<tb_usuario> lista = db.ListaDeUsuariosNome(nome);

            return lista;
        }

        public List<tb_usuario> ListaDeUsuariosFuncionario(string funcionario)
        {
            List<tb_usuario> lista = db.ListaDeUsuariosFuncionario(funcionario);

            return lista;
        }

        public bool Usuario(string nome, string senha)
        {
            tb_usuario usuario = db.usuario(nome, senha);

            if (usuario == null)
            {
                throw new ArgumentException("Credenciais incorretos");
            }

            if (usuario != null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public void inserirUsuario(tb_usuario usuario, string confiSenha)
        {
            List<tb_usuario> lista = db.ListaDeUsuarios();

            bool nomeExiste = lista.Exists(x => x.nm_usuario == usuario.nm_usuario);

            if (nomeExiste == true)
            {
                throw new ArgumentException("Usúario já existe");
            }

            if (usuario.ds_senha == string.Empty)
            {
                throw new ArgumentException("Insira uma senha válida");
            }

            if (confiSenha == string.Empty)
            {
                throw new ArgumentException("Confirme a sua senha");
            }

            if (usuario.nm_usuario == string.Empty)
            {
                throw new ArgumentException("Informe o seu nome de usúario");
            }

            if (usuario.ds_senha != confiSenha)
            {
                throw new ArgumentException("Senhas não compatíveis");
            }

            if (usuario.ds_senha.Length < 8)
            {
                throw new ArgumentException("Senha deve ter pelo menos 8 caractéres");
            }

            if (confiSenha.Length < 8)
            {
                throw new ArgumentException("Senha deve ter pelo menos 8 caractéres");
            }

            db.inserirUsuario(usuario);
        }
        public void alterarusuario(tb_usuario usuario)
        {
            List<tb_usuario> lista = db.ListaDeUsuarios();

            tb_usuario usuarioFunc = db.UsuarioPorFuncionario(usuario.id_funcionario);

            bool nomeExiste = lista.Exists(x => x.nm_usuario == usuario.nm_usuario && x.nm_usuario != usuarioFunc.nm_usuario);
            bool funcionarioExiste = lista.Exists(x => x.id_funcionario == usuario.id_funcionario && x.id_funcionario != usuarioFunc.id_funcionario);

            if (nomeExiste == true)
            {
                throw new ArgumentException("Usúario já existe");
            }

            if(funcionarioExiste == true)
            {
                throw new ArgumentException("Usúario já existe para este funcionário");
            }

            if (usuario.nm_usuario == string.Empty)
            {
                throw new ArgumentException("Informe o seu nome de usúario");
            }

            db.alterarusuario(usuario);
        }
        public void RemoverUsuario(int id)
        {
            if(id == 0)
            {
                throw new ArgumentException("Usuario Inválido");
            }
            db.RemoverUsuario(id);
        }

        public void alterarSenha(tb_usuario usuario, string confiSenha)
        {
            if (usuario.ds_senha == string.Empty)
            {
                throw new ArgumentException("Insira uma senha válida");
            }

            if (confiSenha == string.Empty)
            {
                throw new ArgumentException("Confirme a sua senha");
            }

            if (usuario.ds_senha != confiSenha)
            {
                throw new ArgumentException("Senhas não compatíveis");
            }

            if (usuario.ds_senha.Length < 8)
            {
                throw new ArgumentException("Senha deve ter pelo menos 8 caractéres");
            }

            if (confiSenha.Length < 8)
            {
                throw new ArgumentException("Senha deve ter pelo menos 8 caractéres");
            }

            db.alterarSenha(usuario);
        }

    }
}
