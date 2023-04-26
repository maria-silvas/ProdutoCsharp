using Controllers;
using Models;

namespace Views
{
    public class CriarSaldo : Form
    {
        public Label lblIdProduto;
        public TextBox txtIdProduto;
        public Label lblIdAlmoxarifado;
        public TextBox txtIdAlmoxarifado;
        public Label lblQuantidade;
        public TextBox txtQuantidade;
        public Button btnRegister;

        public void btnRegister_Click(object sender, EventArgs e)
        {
            Models.Saldo saldo = new Models.Saldo(
                Convert.ToInt32(txtIdProduto.Text),
                Convert.ToInt32(txtIdAlmoxarifado.Text),
                Convert.ToInt32(txtQuantidade.Text)
            );

            Controllers.Saldo.CriarSaldo(saldo);
            MessageBox.Show("Saldo foi registrado com sucesso!");

            ClearForm();

            ListarSaldo SaldoList = Application.OpenForms.OfType<ListarSaldo>().FirstOrDefault();
            if (SaldoList != null)
            {
                SaldoList.RefreshList();
            }

            this.Close();
        }

        private void ClearForm(){
            txtIdProduto.Clear();
            txtIdAlmoxarifado.Clear();
            txtQuantidade.Clear();
        }

        public CriarSaldo()
        {
            this.Text = "Registar Saldo";
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
            this.txtIdProduto.Location = new System.Drawing.Point(170, 40);
            this.txtIdProduto.Size = new System.Drawing.Size(150, 20);

            this.lblIdAlmoxarifado = new Label();
            this.lblIdAlmoxarifado.Text = "Id do almoxarifado:";
            this.lblIdAlmoxarifado.Location = new System.Drawing.Point(10, 70);
            this.lblIdAlmoxarifado.Size = new System.Drawing.Size(150, 20);

            this.txtIdAlmoxarifado = new TextBox();
            this.txtIdAlmoxarifado.Location = new System.Drawing.Point(170, 70);
            this.txtIdAlmoxarifado.Size = new System.Drawing.Size(150, 20);

            this.lblQuantidade = new Label();
            this.lblQuantidade.Text = "Quantidade:";
            this.lblQuantidade.Location = new System.Drawing.Point(10, 100);
            this.lblQuantidade.Size = new System.Drawing.Size(150, 20);

            this.txtQuantidade = new TextBox();
            this.txtQuantidade.Location = new System.Drawing.Point(170, 100);
            this.txtQuantidade.Size = new System.Drawing.Size(150, 20);

            this.btnRegister = new Button();
            this.btnRegister.Text = "Registrar";
            this.btnRegister.Location = new System.Drawing.Point(170, 150);
            this.btnRegister.Size = new System.Drawing.Size(150, 35);
            this.btnRegister.Click += new EventHandler(btnRegister_Click);

            this.Controls.Add(this.lblIdProduto);
            this.Controls.Add(this.lblIdAlmoxarifado);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtIdAlmoxarifado);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.btnRegister);

        }
    }

}