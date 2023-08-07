using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaProduto
{

    public partial class Cadastro : Form
    {

        List<Produto> produtos = new List<Produto>();
        public Cadastro()
        {
            InitializeComponent();
            lb_valorvenda.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
                Produto p = new Produto();

                p.Codigo = tx_codigo.Text;
                p.Descricao = tx_descricao.Text;
                double preco = p.PrecoAquisicao = Convert.ToDouble(tx_precoAquisicao.Text);
                double lucro = p.Lucro = Convert.ToDouble(tx_lucro.Text);

                double porcentagem = ((lucro * preco) / 100) + preco;
                p.ValorVenda = porcentagem;
                tb_venda.Text = porcentagem.ToString();
                produtos.Add(p);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = produtos;
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            tx_codigo.Clear();
            tx_descricao.Clear();
            tx_precoAquisicao.Clear();
            tx_lucro.Clear();
            lb_valorvenda.Text = "";
        }

        private void tb_venda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
