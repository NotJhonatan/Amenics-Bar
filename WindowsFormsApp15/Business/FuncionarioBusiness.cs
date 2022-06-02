using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class FuncionarioBusiness
    {

        Database.FuncionarioDatabase db = new Database.FuncionarioDatabase();

        public void CadastrarFuncionario(Model.tb_funcionario funcionario)
        {
            //*Dados Pessoais*

            if (funcionario.nm_funcionario == string.Empty)
            {
                throw new Exception("Nome do Funcionário é obrigatório");
            }

            int idade = DateTime.Now.Year - funcionario.dt_nascimento.Year;

            if (idade < 14)
            {
                throw new Exception("idade inválida");
            }
            if (idade > 100)
            {
                throw new Exception("idade inválida");
            }
            if (funcionario.ds_rg == string.Empty)
            {
                throw new Exception("Rg do funcionário é obrigatório");
            }
            if (funcionario.ds_email == string.Empty)
            {
                throw new Exception("E-mail do funcionário é obrigatório");
            }
            if (funcionario.dt_contratacao == null)
            {
                throw new Exception("A data de contrataçao é obrigatória");
            }

            if (funcionario.dt_contratacao.Year > DateTime.Now.Year)
            {
                throw new Exception("Data de contratação inválida");
            }
            if (funcionario.ds_genero == string.Empty)
            {
                throw new Exception("Genero é obrigatório");
            }
            if (funcionario.ds_cargo == string.Empty)
            {
                throw new Exception("O Cargo é obrigatório");
            }
            if (funcionario.ds_celular == string.Empty)
            {
                throw new Exception("Numero de celular é obrigatório");
            }
            if (funcionario.ds_telefone == string.Empty)
            {
                throw new Exception("Numero de celular é obrigatório");
            }
            if (funcionario.vl_salarioPorHora == 0)
            {
                throw new Exception("Salário é obrigatório");
            }

            //*Endereço*

            if (funcionario.ds_endereco == string.Empty)
            {
                throw new Exception("Endereço é obrigatório");
            }
            if (funcionario.ds_cep == string.Empty)
            {
                throw new Exception("CEP é obrigatório");
            }
            if (funcionario.ds_cidade == string.Empty)
            {
                throw new Exception("Cidade é obrigatório");
            }
            if (funcionario.ds_UF == string.Empty)
            {
                throw new Exception("Estado é obrigatório");
            }
            if (funcionario.ds_UF == string.Empty)
            {
                throw new Exception("NumeroEnder é obrigatório");
            }

            db.CadastrarFuncionario(funcionario);
        }
        public List<Model.tb_funcionario> ConsultarFuncionarioNome(string nome)
        {
            List<Model.tb_funcionario> lista = db.ConsultarFuncionarioNome(nome);

            return lista;
        }
        public List<Model.tb_funcionario> ConsultarFuncionarioRg(string Rg)
        {
            List<Model.tb_funcionario> lista = db.ConsultarFuncionarioRg(Rg);

            return lista;
        }
        public List<Model.tb_funcionario> ConsultarFuncionarioCpf(string cpf)
        {
            List<Model.tb_funcionario> lista = db.ConsultarFuncionarioCpf(cpf);

            return lista;
        }
        public List<Model.tb_funcionario> ConsultarFuncionarioCargo(string cargo)
        {
            List<Model.tb_funcionario> lista = db.ConsultarFuncionarioCargo(cargo);

            return lista;
        }
        public List<Model.tb_funcionario> ConsultarFuncionarioContratacao(DateTime contrat)
        {
            List<Model.tb_funcionario> lista = db.ConsultarFuncionarioContracao(contrat);

            return lista;
        }
        public Model.tb_funcionario Listar(int id)
        {
            Model.tb_funcionario modelo = db.Listar(id);

            return modelo;
        }

        public void AlterarFuncionario(Model.tb_funcionario funcionario)
        {
            
            //*Dados Pessoais*

            if (funcionario.nm_funcionario == string.Empty)
            {
                throw new Exception("Nome do Funcionário é obrigatório");
            }

            int idade = DateTime.Now.Year - funcionario.dt_nascimento.Year;

            if (idade < 14)
            {
                throw new Exception("idade inválida");
            }
            if (idade > 100)
            {
                throw new Exception("idade inválida");
            }
            if (funcionario.ds_rg == string.Empty)
            {
                throw new Exception("Rg do funcionário é obrigatório");
            }
            if (funcionario.ds_email == string.Empty)
            {
                throw new Exception("E-mail do funcionário é obrigatório");
            }
            if (funcionario.dt_contratacao == null)
            {
                throw new Exception("A data de contrataçao é obrigatória");
            }

            if (funcionario.dt_contratacao.Year > DateTime.Now.Year)
            {
                throw new Exception("Data de contratação inválida");
            }
            if (funcionario.ds_genero == string.Empty)
            {
                throw new Exception("Genero é obrigatório");
            }
            if (funcionario.ds_cargo == string.Empty)
            {
                throw new Exception("O Cargo é obrigatório");
            }
            if (funcionario.ds_celular == string.Empty)
            {
                throw new Exception("Numero de celular é obrigatório");
            }
            if (funcionario.ds_telefone == string.Empty)
            {
                throw new Exception("Numero de celular é obrigatório");
            }
            if (funcionario.vl_salarioPorHora == 0)
            {
                throw new Exception("Salário é obrigatório");
            }

            //*Endereço*

            if (funcionario.ds_endereco == string.Empty)
            {
                throw new Exception("Endereço é obrigatório");
            }
            if (funcionario.ds_cep == string.Empty)
            {
                throw new Exception("CEP é obrigatório");
            }
            if (funcionario.ds_cidade == string.Empty)
            {
                throw new Exception("Cidade é obrigatório");
            }
            if (funcionario.ds_UF == string.Empty)
            {
                throw new Exception("Estado é obrigatório");
            }
            if (funcionario.ds_UF == string.Empty)
            {
                throw new Exception("NumeroEnder é obrigatório");
            }

            db.AlterarFuncionario(funcionario);
        }
        public List<tb_funcionario> ConsultarFuncionario()
        {
            List<tb_funcionario> lista = db.ConsultarFuncionario();

            return lista;
        }
        public void RemoverFuncionario(int id)
        {
            if(id == 0)
            {
                throw new ArgumentException("Funcionario não encontrado");
            }

            db.RemoverFuncionario(id);
        }

        public tb_funcionario ModeloEmail(string email)
        {
            tb_funcionario funcioarnio = db.ConfirmarEmail(email);

            return funcioarnio;
        }

        public bool ConfirmarEmail(string email)
        {
            tb_funcionario funcioarnio = db.ConfirmarEmail(email);

            if (funcioarnio == null)
            {
                throw new ArgumentException("Email Inválido");
            }

            if (funcioarnio != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
