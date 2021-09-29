using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha_Do_Ze
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
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
