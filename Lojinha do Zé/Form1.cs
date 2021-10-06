using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha_do_Zé
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dao dao = new Dao();

        private void Form1_Load(object sender, EventArgs e)
        {
            dao.conecte("LojinhaDoZe", "Produtos");
            dao.PreencherTabela(dataGridView1);
            LimparCampos();
        }

        void LimparCampos()
        {
            txtNome.Clear();
            txtDesc.Clear();
            txtPreco.Clear();
            txtQuant.Clear();
            CodNum.Text = dao.NumRegistro().ToString("00");
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            dao.Inserir(txtNome.Text, txtDesc.Text, decimal.Parse(txtPreco.Text), int.Parse(txtQuant.Text));
            dao.PreencherTabela(dataGridView1);
            LimparCampos();
            MessageBox.Show("Item Adicionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "")
            {
                dao.Consulta(txtNome.Text);
                if (dao.testeConsulta)
                {
                    buttonInserir.Enabled = false;
                    CodNum.Text = dao.campos.id.ToString("00");
                    txtNome.Text = dao.campos.nome;
                    txtDesc.Text = dao.campos.desc;
                    txtPreco.Text = dao.campos.precoUni.ToString("00.0#");
                    txtQuant.Text = dao.campos.contEstoque.ToString("00");
                }
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            buttonInserir.Enabled = true;
            LimparCampos();
        }
    }
}
