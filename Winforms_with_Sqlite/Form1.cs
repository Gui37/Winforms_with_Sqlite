using System.Data;

namespace Winforms_with_Sqlite
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				DataHelper.CriarBancoSQLite();
				button1.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				DataHelper.CriarTabelaSQlite();
				button6.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			ExibirDados();
		}

		private void ExibirDados()
		{
			try
			{
				DataTable dt = new DataTable();
				dt = DataHelper.GetClientes();
				dgvDados.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (!Valida())
			{
				MessageBox.Show("Informe os dados cliente a incluir");
				return;
			}

			try
			{
				Cliente cli = new Cliente();
				cli.Id = Convert.ToInt32(textBox2.Text);
				cli.Nome = textBox3.Text;
				cli.Email = textBox1.Text;

				DataHelper.Add(cli);

				ExibirDados();
				LimpaDados();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (!Valida())
			{
				MessageBox.Show("Informe os dados cliente a atualizar");
				return;
			}

			try
			{
				Cliente cli = new Cliente();
				cli.Id = Convert.ToInt32(textBox2.Text);
				cli.Nome = textBox3.Text;
				cli.Email = textBox1.Text;

				DataHelper.Update(cli);
				ExibirDados();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Informe o ID do cliente a ser Excluído");
				return;
			}

			try
			{
				int codigo = Convert.ToInt32(textBox2.Text);
				DataHelper.Delete(codigo);
				ExibirDados();
				LimpaDados();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Informe o ID do cliente a ser Localizado");
				return;
			}
			try
			{
				DataTable dt = new DataTable();
				int codigo = Convert.ToInt32(textBox2.Text);

				dt = DataHelper.GetCliente(codigo);
				dgvDados.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro : " + ex.Message);
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			const string mensagem = "Deseja Encerrar ?";
			const string titulo = "Encerrar";
			var resultado = MessageBox.Show(mensagem, titulo,
										 MessageBoxButtons.YesNo,
										 MessageBoxIcon.Question);

			if (resultado == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private bool Valida()
		{
			if (string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text) && string.IsNullOrEmpty(textBox1.Text))
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		private void LimpaDados()
		{
			textBox2.Text = "";
			textBox1.Text = "";
			textBox3.Text = "";
		}

		private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dgvDados.Rows[e.RowIndex];
				textBox2.Text = row.Cells["Id"].Value.ToString();
				textBox3.Text = row.Cells["Nome"].Value.ToString();
				textBox1.Text = row.Cells["Email"].Value.ToString();
			}
		}
	}
}
