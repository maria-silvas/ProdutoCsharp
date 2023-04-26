using Models;
using Controllers;


namespace Views{
    public class EditarProduto : Form{

        public Label lblName;
        public TextBox txtName;
        public Label lblPrice;
        public TextBox txtPrice;
        public Button btnRegister;
        public Models.Produto produto;


        public void btnEdit_Click(object sender, EventArgs e){

            Models.Produto produto = this.produto;
            produto.Nome = txtName.Text;
            produto.Preco = Convert.ToDecimal(txtPrice.Text);

            Controllers.Produto.AtualizarProduto(produto);
            MessageBox.Show("O produto foi alterado !");

            Views.ListarProduto ProdutoList = Application.OpenForms.OfType<Views.ListarProduto>().FirstOrDefault();
            if (ProdutoList != null){
                ProdutoList.RefreshList();
            }
            this.Close();
        }
        public EditarProduto(Models.Produto produto){

            this.produto = produto;

            this.Text = "Editar produto";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(280, 220);

            this.lblName = new Label();
            this.lblName.Text = "Nome:";
            this.lblName.Location = new System.Drawing.Point(10, 40);
            this.lblName.Size = new System.Drawing.Size(50, 20);

            this.txtName = new TextBox();
            this.txtName.Text = produto.Nome;
            this.txtName.Location = new System.Drawing.Point(80, 40);
            this.txtName.Size = new System.Drawing.Size(150, 20);

            this.lblPrice = new Label();
            this.lblPrice.Text = "Preço:";
            this.lblPrice.Location = new System.Drawing.Point(10, 70);
            this.lblPrice.Size = new System.Drawing.Size(50, 20);

            this.txtPrice = new TextBox();
            this.txtPrice.Text = produto.Preco.ToString();
            this.txtPrice.Location = new System.Drawing.Point(80, 70);
            this.txtPrice.Size = new System.Drawing.Size(150, 20);

            this.btnRegister = new Button();
            this.btnRegister.Text = "Registrar";
            this.btnRegister.Location = new System.Drawing.Point(80, 110);
            this.btnRegister.Size = new System.Drawing.Size(150, 35);
            this.btnRegister.Click += new EventHandler(this.btnEdit_Click);

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnRegister);
        }
    }
}
