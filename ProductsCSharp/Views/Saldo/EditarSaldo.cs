using Models;
using Controllers;


namespace Views
{
    public class EditarSaldo : Form
    {

        private Label lblIdProduto;
        private Label lblIdAlmoxarifado;
        private Label lblQuantidade;
        private TextBox txtIdProduto;
        private TextBox txtIdAlmoxarifado;
        private TextBox txtQuantidade;
        private Button btnEdit;
        public Models.Saldo saldo;


        public void btnEdit_Click(object sender, EventArgs e)
        {

            Models.Saldo saldo = this.saldo;
            saldo.IdProduto = Convert.ToInt32(txtIdProduto.Text);
            saldo.IdAlmoxarifado = Convert.ToInt32(txtIdAlmoxarifado.Text);
            saldo.Quantidade = Convert.ToInt32(txtQuantidade.Text);

            Controllers.Saldo.AtualizarSaldo(saldo);
            MessageBox.Show("O saldo foi alterado !");

            Views.ListarSaldo SaldoList = Application.OpenForms.OfType<Views.ListarSaldo>().FirstOrDefault();
            if (SaldoList != null)
            {
                SaldoList.RefreshList();
            }
            this.Close();
        }
        public EditarSaldo(Models.Saldo saldo)
        {

            this.saldo = saldo;

            this.Text = "Editar Saldo";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(350, 250);

            this.lblIdProduto = new Label();
            this.lblIdProduto.Text = "Id do produto:";
            this.lblIdProduto.Location = new System.Drawing.Point(10, 40);
            this.lblIdProduto.Size = new System.Drawing.Size(150, 20);

            this.txtIdProduto = new TextBox();
            this.txtIdProduto.Text = saldo.IdProduto.ToString();
            this.txtIdProduto.Location = new System.Drawing.Point(170, 40);
            this.txtIdProduto.Size = new System.Drawing.Size(150, 20);

            this.lblIdAlmoxarifado = new Label();
            this.lblIdAlmoxarifado.Text = "Id do almoxarifado:";
            this.lblIdAlmoxarifado.Location = new System.Drawing.Point(10, 70);
            this.lblIdAlmoxarifado.Size = new System.Drawing.Size(150, 20);

            this.txtIdAlmoxarifado = new TextBox();
            this.txtIdAlmoxarifado.Text = saldo.IdAlmoxarifado.ToString();
            this.txtIdAlmoxarifado.Location = new System.Drawing.Point(170, 70);
            this.txtIdAlmoxarifado.Size = new System.Drawing.Size(150, 20);

            this.lblQuantidade = new Label();
            this.lblQuantidade.Text = "Quantidade:";
            this.lblQuantidade.Location = new System.Drawing.Point(10, 100);
            this.lblQuantidade.Size = new System.Drawing.Size(150, 20);

            this.txtQuantidade = new TextBox();
            this.txtQuantidade.Text = saldo.Quantidade.ToString();
            this.txtQuantidade.Location = new System.Drawing.Point(170, 100);
            this.txtQuantidade.Size = new System.Drawing.Size(150, 20);

            this.btnEdit = new Button();
            button.BackColor = Color.Yellow;
            this.btnEdit.Text = "Alterar";
            this.btnEdit.Location = new System.Drawing.Point(170, 150);
            this.btnEdit.Size = new System.Drawing.Size(150, 35);
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);

            this.Controls.Add(this.lblIdProduto);
            this.Controls.Add(this.lblIdAlmoxarifado);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtIdAlmoxarifado);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnEdit);
        }
    }
}
