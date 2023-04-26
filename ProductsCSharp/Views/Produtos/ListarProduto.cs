namespace Views{

    public class ListarProduto : Form{

        ListView listProducts;
        public ListarProduto(){

            this.Controls.Add(listProducts);
            this.Size = new Size(720, 370);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Listar Produtos";

            listProducts = new ListView();
            listProducts.Size = new Size(605, 180);
            listProducts.Location = new Point(50, 50);
            listProducts.View = View.Details;
            listProducts.Columns.Add("ID", 50);
            listProducts.Columns.Add("Nome", 100);
            listProducts.Columns.Add("Preço", 100);
            listProducts.Columns[0].Width = 30;
            listProducts.Columns[1].Width = 100;
            listProducts.Columns[2].Width = 80;
            listProducts.FullRowSelect = true;
            this.Controls.Add(listProducts);

            RefreshList();

            Button btnAdd = new Button();
            btnAdd.Text = "Adicionar";
            btnAdd.Size = new Size(100, 30);
            btnAdd.Location = new Point(50, 270);
            btnAdd.Click += new EventHandler(btnAdd_Click);
            this.Controls.Add(btnAdd);

            Button btnEdit = new Button();
            btnEdit.Text = "Editar";
            btnEdit.Size = new Size(100, 30);
            btnEdit.Location = new Point(170, 270);
            btnEdit.Click += new EventHandler(btnEdit_Click);
            this.Controls.Add(btnEdit);

            Button btnDelete = new Button();
            btnDelete.Text = "Deletar";
            btnDelete.Size = new Size(100, 30);
            btnDelete.Location = new Point(290, 270);
            btnDelete.Click += new EventHandler(btnDelete_Click);
            this.Controls.Add(btnDelete);


            Button btnClose = new Button();
            btnClose.Text = "Sair";
            btnClose.Size = new Size(100, 30);
            btnClose.Location = new Point(550, 270);
            btnClose.Click += new EventHandler(btnExit_Click);
            this.Controls.Add(btnClose);
        }

        private void btnAdd_Click(object sender, EventArgs e){
            new CriarProduto().ShowDialog();
            RefreshList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Produto produto = GetProdutoBySelected();
                var editarProdutoView = new Views.EditarProduto(produto);
                if (editarProdutoView.ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                    MessageBox.Show("Produto modificado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e){

            try{
                Models.Produto produto = GetProdutoBySelected();
                DialogResult result = MessageBox.Show("Tem certeza que deseja deletar esse item?", "Confirmar exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Controllers.Produto.DeletarProduto(produto);
                    RefreshList();
                }
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e){
            this.Close();
        }

        public void AddToListView(Models.Produto produto)
        {
            ListViewItem item = new ListViewItem(produto.Id.ToString());
            item.SubItems.Add(produto.Nome);
            item.SubItems.Add(produto.Preco.ToString());
            listProducts.Items.Add(item);
        }

        public void RefreshList()
        {
            listProducts.Items.Clear();

            List<Models.Produto> produtos = Controllers.Produto.ListarProdutos();


            foreach (Models.Produto produto in produtos)
            {
                AddToListView(produto);
            }
        }
        public Models.Produto GetProdutoBySelected()
        {
            if (listProducts.SelectedItems.Count > 0)
            {
                int selectedProduct = int.Parse(listProducts.SelectedItems[0].Text);
                return Controllers.Produto.BuscarProduto(selectedProduct);
            }
            else
            {
                throw new Exception("Por gentileza, selecione um item para prosseguir com a ação" );
            }
        }




    }
}