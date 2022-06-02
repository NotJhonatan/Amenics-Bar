using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class FuncionarioDatabase
    {
        Model.ecostorEntities db = new ecostorEntities();

        public void CadastrarFuncionario(tb_funcionario funcionario)
        {
            db.tb_funcionario.Add(funcionario);
            db.SaveChanges(); 

        }
        public List<tb_funcionario> ConsultarFuncionarioNome(string Nome)
        {
            List<tb_funcionario> lista = db.tb_funcionario.Where(x => x.nm_funcionario.Contains(Nome)).ToList();

            return lista;
        }
        public List<tb_funcionario> ConsultarFuncionario()
        {
            List<tb_funcionario> lista = db.tb_funcionario.ToList();

            return lista;
        }
        public List<tb_funcionario> ConsultarFuncionarioRg(string Rg)
        {
            List<tb_funcionario> lista = db.tb_funcionario.Where(x => x.ds_rg.Contains(Rg)).ToList();

            return lista;
        }
        public List<tb_funcionario> ConsultarFuncionarioCpf(string cpf)
        {
            List<tb_funcionario> lista = db.tb_funcionario.Where(x => x.ds_cpf.Contains(cpf)).ToList();

            return lista;
        }
        public List<tb_funcionario> ConsultarFuncionarioCargo(string Cargo)
        {
            List<tb_funcionario> lista = db.tb_funcionario.Where(x => x.ds_cargo.Contains(Cargo)).ToList();

            return lista;
        }
        public List<tb_funcionario> ConsultarFuncionarioContracao(DateTime Contrat)
        {
            List<tb_funcionario> lista = db.tb_funcionario.Where(x => x.dt_contratacao == Contrat).ToList();

            return lista;
        }

        public tb_funcionario Listar(int id)
        {
            tb_funcionario modelo = db.tb_funcionario.FirstOrDefault(x => x.id_funcionario == id);

            return modelo;
        }

        public void AlterarFuncionario(tb_funcionario modelo)
        {
            tb_funcionario alterar = db.tb_funcionario.FirstOrDefault(x => x.id_funcionario == modelo.id_funcionario);

            alterar.id_funcionario = modelo.id_funcionario;
            alterar.nm_funcionario = modelo.nm_funcionario;
            alterar.vl_salarioPorHora = modelo.vl_salarioPorHora;
            alterar.ds_cargo = modelo.ds_cargo;
            alterar.ds_celular = modelo.ds_celular;
            alterar.ds_cep = modelo.ds_cep;
            alterar.ds_cidade = modelo.ds_cidade;
            alterar.ds_complemento = modelo.ds_complemento;
            alterar.ds_cpf = modelo.ds_cpf;
            alterar.ds_email = modelo.ds_email;
            alterar.ds_endereco = modelo.ds_endereco;
            alterar.ds_genero = modelo.ds_genero;
            alterar.ds_numeroCasa = modelo.ds_numeroCasa;
            alterar.ds_rg = modelo.ds_rg;
            alterar.ds_telefone = modelo.ds_telefone;
            alterar.ds_UF = modelo.ds_UF;
            alterar.dt_contratacao = modelo.dt_contratacao;
            alterar.dt_nascimento = modelo.dt_nascimento;
            alterar.img_foto = modelo.img_foto;

            db.SaveChanges();

        }

        public void RemoverFuncionario(int id)
        {
            tb_funcionario modelo = db.tb_funcionario.FirstOrDefault(x => x.id_funcionario == id);
            db.tb_funcionario.Remove(modelo);

            db.SaveChanges();
        }

        public tb_funcionario ConfirmarEmail(string email)
        {
            tb_funcionario funcionario = db.tb_funcionario.FirstOrDefault(x => x.ds_email == email);

            return funcionario;
        }
    }
}
