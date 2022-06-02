using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp15.Model;

namespace WindowsFormsApp15.Telas
{
    public partial class frmFluxoCaixa : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmFluxoCaixa()
        {
            InitializeComponent();
        }

        Business.EstoqueBusiness    estoqueBusiness =   new Business.EstoqueBusiness();
        Business.ProdutoBusiness    produtoBusiness =   new Business.ProdutoBusiness();
        Business.VendaBusiness      vendaBusiness =     new Business.VendaBusiness();
        Business.ClienteBusiness    clienteBusiness =   new Business.ClienteBusiness();

        private void label15_Click(object sender, EventArgs e)
        {
            try
            {
                Model.tb_produto produto = listProdutos.SelectedItem as Model.tb_produto;

                List<Model.tb_estoque> estoque = estoqueBusiness.ConsultarEstoqueId(produto.id_produto);

                if (estoque.Count != 0)
                {
                    List<Model.tb_estoque> itens = dgvProdutos.DataSource as List<Model.tb_estoque>;

                    if (itens == null)
                    {
                        itens = new List<Model.tb_estoque>();
                    }

                    int quantidade = Convert.ToInt32(nudQuantidade.Value);

                    for (int i = 0; i < quantidade; i++)
                    {
                        tb_estoque estoqueModelo = estoqueBusiness.ListarAlterarNaoVendidos(produto.id_produto);
                    
                        itens.Add(estoqueModelo);

                        dgvProdutos.AutoGenerateColumns = false;
                        dgvProdutos.DataSource = null;
                        dgvProdutos.DataSource = itens;

                        decimal total = itens.Sum(x => x.vl_valor);

                        lblTotal.Text = total.ToString();
                        lblRestante.Text = total.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Produto Indisponivel");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmFluxoCaixa_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsuario.Text = Autenticacao.Usuario.UsuarioLogado.Nome;

                List<tb_produto> lista = produtoBusiness.ConsultarTodosProdutos();

                listProdutos.DisplayMember = nameof(tb_produto.nm_produto);
                listProdutos.DataSource = lista;

                Utils.ConverterImagem imageConverter = new Utils.ConverterImagem();

                Image imagem = imageConverter.byteArrayToImage(Autenticacao.Usuario.UsuarioLogado.Foto);

                imgUsuario.Image = imagem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Model.tb_estoque> itens = dgvProdutos.DataSource as List<Model.tb_estoque>;

                Model.tb_venda venda = new Model.tb_venda();

                tb_cliente cliente = new tb_cliente();

                if (txtCPFCliente.Visible == true)
                {
                    cliente = clienteBusiness.ListarClienteCpf(txtCPFCliente.Text);
                    venda.id_cliente = cliente.id_cliente;
                }
                else
                {
                    venda.id_cliente = null;
                }

                venda.id_usuario = Autenticacao.Usuario.UsuarioLogado.IDUsuario;
                venda.dt_saida = DateTime.Now;

                
                if(cliente.qtd_frequenciaMensal == 100)
                {
                    venda.vl_valorTotal = Convert.ToDecimal(lblTotal.Text) / 2;
                }
                else
                {
                    venda.vl_valorTotal = Convert.ToDecimal(lblTotal.Text);
                }

                vendaBusiness.InserirVenda(venda);

                Model.tb_venda_item vendaItem = new Model.tb_venda_item();

                if (lblRestante.Text == "0,00")
                {
                    foreach (var item in itens)
                    {
                        vendaItem.id_venda = venda.id_venda;
                        vendaItem.id_estoque = item.id_estoque;

                        vendaBusiness.InserirVendaItem(vendaItem);
                    }

                    MessageBox.Show("Pedido finalizado com sucesso");

                    cliente.qtd_frequenciaMensal = cliente.qtd_frequenciaMensal + 1;

                    clienteBusiness.AlterarCliente(cliente);

                    dgvProdutos.DataSource = null;

                    lblTotal.Text = "0,00";
                    lblTroco.Text = "0,00";
                    lblRestante.Text = "0,00";
                    nudPago.Value = 0;
                    txtCPFCliente.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Valor não foi liquidado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(txtCPFCliente.Visible == true)
            {
                txtCPFCliente.Visible = false;
            }

            else
            {
                txtCPFCliente.Visible = true;
            }
        }

        public static void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal total = Convert.ToDecimal(lblTotal.Text);
                decimal pago = nudPago.Value;
                decimal restante = Convert.ToDecimal(lblRestante.Text);

                lblRestante.Text = (total - pago).ToString();

                if (pago > total)
                {
                    lblRestante.Text = "0,00";
                    lblTroco.Text = (pago - total).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                try
                {
                    tb_estoque estoque = dgvProdutos.CurrentRow.DataBoundItem as tb_estoque;

                    List<Model.tb_estoque> itens = dgvProdutos.DataSource as List<Model.tb_estoque>;

                    itens.Remove(estoque);

                    dgvProdutos.AutoGenerateColumns = false;
                    dgvProdutos.DataSource = null;
                    dgvProdutos.DataSource = itens;

                    estoqueBusiness.AlterarEstoqueNaoVendido(estoque.id_produto);

                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Telas.Cliente.frmCadastrarCliente tela = new Cliente.frmCadastrarCliente();
            tela.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Telas.Cliente.frmCadastrarCliente tela = new Cliente.frmCadastrarCliente();
            tela.Show();
        }
    }
}
