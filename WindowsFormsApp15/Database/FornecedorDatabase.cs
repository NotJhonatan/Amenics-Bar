using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Database
{
    class FornecedorDatabase
    {
        Model.ecostorEntities db = new ecostorEntities();

        public void CadastarFornecedor(tb_fornecedor modelo)
        {
            db.tb_fornecedor.Add(modelo);

            db.SaveChanges();
        }
        public List<tb_fornecedor> ConsultarFornecedorNomeEmpresa(string NomeEmpresa)
        {
            List<tb_fornecedor> lista = db.tb_fornecedor.Where(x => x.nm_empresa.Contains(NomeEmpresa)).ToList();

            return lista;
        
        }
        public List<tb_fornecedor> ConsultarFornecedorNome(string Nome)
        {
            List<tb_fornecedor> lista = db.tb_fornecedor.Where(x => x.nm_fornecedor.Contains(Nome)).ToList();

            return lista;
        }
        public List<tb_fornecedor> ConsultarFornecedor()
        {
            List<tb_fornecedor> lista = db.tb_fornecedor.ToList();

            return lista;
        }
        public tb_fornecedor Listar(int id)
        {
            tb_fornecedor modelo = db.tb_fornecedor.FirstOrDefault(x => x.id_fornecedor == id);

            return modelo;
        }
        public void AlterarFornecedor (tb_fornecedor modelo)
        {
            tb_fornecedor alterar = db.tb_fornecedor.FirstOrDefault(x => x.nm_empresa == x.nm_empresa);

            alterar.nm_empresa = modelo.nm_empresa;
            alterar.ds_celular = modelo.ds_celular;
            alterar.ds_cnpj = modelo.ds_cnpj;
            alterar.ds_endereco = modelo.ds_endereco;
            alterar.ds_telefone = modelo.ds_telefone;
            alterar.nm_fornecedor = modelo.nm_fornecedor;

            db.SaveChanges();
        }
        public void RemoverFornecedor(int id)
        {
            tb_fornecedor deletar = db.tb_fornecedor.FirstOrDefault(x => x.id_fornecedor == id);

            db.tb_fornecedor.Remove(deletar);

            db.SaveChanges();
        }
    }
}
