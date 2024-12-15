namespace Winforms_with_Sqlite
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvDados = new DataGridView();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			button7 = new Button();
			button8 = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			panel1 = new Panel();
			panel2 = new Panel();
			((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// dgvDados
			// 
			dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDados.Dock = DockStyle.Fill;
			dgvDados.Location = new Point(0, 0);
			dgvDados.Name = "dgvDados";
			dgvDados.Size = new Size(565, 449);
			dgvDados.TabIndex = 0;
			dgvDados.CellDoubleClick += dgvDados_CellDoubleClick;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button1.AutoSize = true;
			button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			button1.Location = new Point(15, 132);
			button1.Name = "button1";
			button1.Size = new Size(121, 25);
			button1.TabIndex = 1;
			button1.Text = "Criar Base de Dados";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button2.AutoSize = true;
			button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			button2.Location = new Point(307, 192);
			button2.Name = "button2";
			button2.Size = new Size(99, 25);
			button2.TabIndex = 2;
			button2.Text = "Localizar Dados";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button3.AutoSize = true;
			button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			button3.Location = new Point(161, 192);
			button3.Name = "button3";
			button3.Size = new Size(96, 25);
			button3.TabIndex = 3;
			button3.Text = "Eliminar Dados";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button4.AutoSize = true;
			button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			button4.Location = new Point(15, 192);
			button4.Name = "button4";
			button4.Size = new Size(105, 25);
			button4.TabIndex = 4;
			button4.Text = "Actualizar Dados";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button5.AutoSize = true;
			button5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			button5.Location = new Point(307, 132);
			button5.Name = "button5";
			button5.Size = new Size(94, 25);
			button5.TabIndex = 5;
			button5.Text = "Mostrar Dados";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// button6
			// 
			button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button6.AutoSize = true;
			button6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			button6.Location = new Point(161, 132);
			button6.Name = "button6";
			button6.Size = new Size(78, 25);
			button6.TabIndex = 6;
			button6.Text = "Criar Tabela";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// textBox1
			// 
			textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox1.Location = new Point(75, 82);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(397, 23);
			textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox2.Location = new Point(75, 5);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(75, 23);
			textBox2.TabIndex = 8;
			// 
			// textBox3
			// 
			textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			textBox3.Location = new Point(75, 44);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(397, 23);
			textBox3.TabIndex = 9;
			// 
			// button7
			// 
			button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button7.AutoSize = true;
			button7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			button7.Location = new Point(453, 132);
			button7.Name = "button7";
			button7.Size = new Size(104, 25);
			button7.TabIndex = 11;
			button7.Text = "Adicionar Dados";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button8
			// 
			button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			button8.AutoSize = true;
			button8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			button8.Location = new Point(453, 186);
			button8.Name = "button8";
			button8.Size = new Size(107, 25);
			button8.TabIndex = 10;
			button8.Text = "Fechar Programa";
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Location = new Point(15, 5);
			label1.Name = "label1";
			label1.Size = new Size(21, 15);
			label1.TabIndex = 12;
			label1.Text = "ID:";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Location = new Point(15, 44);
			label2.Name = "label2";
			label2.Size = new Size(43, 15);
			label2.TabIndex = 13;
			label2.Text = "Nome:";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Location = new Point(15, 82);
			label3.Name = "label3";
			label3.Size = new Size(39, 15);
			label3.TabIndex = 14;
			label3.Text = "Email:";
			// 
			// panel1
			// 
			panel1.Controls.Add(dgvDados);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(565, 449);
			panel1.TabIndex = 15;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.ButtonHighlight;
			panel2.Controls.Add(label1);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(button1);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(button2);
			panel2.Controls.Add(button3);
			panel2.Controls.Add(button7);
			panel2.Controls.Add(button4);
			panel2.Controls.Add(button8);
			panel2.Controls.Add(button5);
			panel2.Controls.Add(textBox3);
			panel2.Controls.Add(button6);
			panel2.Controls.Add(textBox2);
			panel2.Controls.Add(textBox1);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(0, 226);
			panel2.Name = "panel2";
			panel2.Size = new Size(565, 223);
			panel2.TabIndex = 16;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(565, 449);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvDados;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Button button7;
		private Button button8;
		private Label label1;
		private Label label2;
		private Label label3;
		private Panel panel1;
		private Panel panel2;
	}
}
