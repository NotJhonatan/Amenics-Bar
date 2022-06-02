using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Business
{
    class FornecedorBusiness
    {
        Database.FornecedorDatabase db = new Database.FornecedorDatabase();
        tb_fornecedor model = new tb_fornecedor();

        public void CadastrarFornecedor(Model.tb_fornecedor modelo)
        {
            if(modelo.nm_empresa == string.Empty)
            {
                throw new ArgumentException("Nome da empresa inválido");
            }
            if (modelo.nm_fornecedor == string.Empty)
            {
                throw new ArgumentException("Nome do fornecedor inválido");
            }
            if (modelo.ds_celular.Length < 14)
            {
                throw new ArgumentException("Nº de celular inválido");
            }
            if (modelo.ds_cep.Length < 8)
            {
                throw new ArgumentException("CEP inválido");
            }
            if (modelo.ds_cidade == string.Empty)
            {
                throw new ArgumentException("Cidade inválida");
            }
            if (modelo.ds_cnpj.Length < 18)
            {
                throw new ArgumentException("CNPJ inválido");
            }
            if (modelo.ds_endereco == string.Empty)
            {
                throw new ArgumentException("Endereço inválido");
            }
            if (modelo.ds_telefone.Length < 14)
            {
                throw new ArgumentException("Nº de telefone inválido");
            }
            if (modelo.ds_UF == string.Empty)
            {
                throw new ArgumentException("UF inválido");
            }
          
            db.CadastarFornecedor(modelo);
        }

        public List<Model.tb_fornecedor> ConsultarFornecedorNome(string Nome)
        {
            List<Model.tb_fornecedor> lista = db.ConsultarFornecedorNome(Nome);

            return lista;
        }
        public List<Model.tb_fornecedor> ConsultarFornecedorNomeEmpresa(string NomeEmpresa)
        {
            List<Model.tb_fornecedor> lista = db.ConsultarFornecedorNomeEmpresa(NomeEmpresa);

            return lista;
        }
        public Model.tb_fornecedor Listar(int id)
        {
            Model.tb_fornecedor modelo = db.Listar(id);

            return modelo;
        }

        public void AlterarFornecedor(Model.tb_fornecedor modelo)
        {

            if (modelo.nm_empresa == string.Empty)
            {
                throw new ArgumentException("Nome da empresa inválido");
            }
            if (modelo.nm_fornecedor == string.Empty)
            {
                throw new ArgumentException("Nome do fornecedor inválido");
            }
            if (modelo.ds_celular == string.Empty)
            {
                throw new ArgumentException("Nº de celular inválido");
            }
            if (modelo.ds_cep == string.Empty)
            {
                throw new ArgumentException("CEP inválido");
            }
            if (modelo.ds_cidade == string.Empty)
            {
                throw new ArgumentException("Cidade inválida");
            }
            if (modelo.ds_cnpj == string.Empty)
            {
                throw new ArgumentException("CNPJ inválido");
            }
            if (modelo.ds_endereco == string.Empty)
            {
                throw new ArgumentException("Endereço inválido");
            }
            if (modelo.ds_telefone == string.Empty)
            {
                throw new ArgumentException("Nº de telefone inválido");
            }
            if (modelo.ds_UF == string.Empty)
            {
                throw new ArgumentException("UF inválido");
            }

            db.AlterarFornecedor(modelo);
        }

        public void RemoverForncedor(int id)
        {
            db.RemoverFornecedor(id);
        }
        public List<tb_fornecedor> ConsultarFornecedor()
        {
            List<tb_fornecedor> lista = db.ConsultarFornecedor();

            return lista;
        }
    }
}
