namespace Views {

    public class ListarAlmoxarifado : Form{

        ListView listAlmoxarifado;
        public ListarAlmoxarifado(){

            this.Controls.Add(listAlmoxarifado);
            this.Size = new Size(720, 370);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Listar Almoxarifados";

            listAlmoxarifado = new ListView();
            listAlmoxarifado.Size = new Size(605, 180);
            listAlmoxarifado.Location = new Point(50, 50);
            listAlmoxarifado.View = View.Details;
            listAlmoxarifado.Columns.Add("ID", 50);
            listAlmoxarifado.Columns.Add("Nome", 100);
            listAlmoxarifado.Columns[0].Width = 30;
            listAlmoxarifado.Columns[1].Width = 100;
            listAlmoxarifado.FullRowSelect = true;
            this.Controls.Add(listAlmoxarifado);

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
            new CriarAlmoxarifado().ShowDialog();
            RefreshList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Almoxarifado almoxarifado = GetProdutoBySelected();
                var editarAlmoxarifadoView = new Views.EditarAlmoxarifado(almoxarifado);
                if (editarAlmoxarifadoView.ShowDialog() == DialogResult.OK)
                {
                    RefreshList();
                    MessageBox.Show("Almoxarifado modificado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e){

            try{
                Models.Almoxarifado almoxarifado = GetProdutoBySelected();
                DialogResult result = MessageBox.Show("Tem certeza que deseja deletar esse item?", "Confirmar exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Controllers.Almoxarifado.DeletarAlmoxarifado(almoxarifado);
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

        public void AddToListView(Models.Almoxarifado almoxarifado)
        {
            ListViewItem item = new ListViewItem(almoxarifado.Id.ToString());
            item.SubItems.Add(almoxarifado.Nome);
            listAlmoxarifado.Items.Add(item);
        }

        public void RefreshList()
        {
            listAlmoxarifado.Items.Clear();

            List<Models.Almoxarifado> almoxarifados = Controllers.Almoxarifado.ListarAlmoxarifados();


            foreach (Models.Almoxarifado almoxarifado in almoxarifados)
            {
                AddToListView(almoxarifado);
            }
        }
        public Models.Almoxarifado GetProdutoBySelected()
        {
            if (listAlmoxarifado.SelectedItems.Count > 0)
            {
                int selectedProduct = int.Parse(listAlmoxarifado.SelectedItems[0].Text);
                return Controllers.Almoxarifado.BuscarAlmoxarifado(selectedProduct);
            }
            else
            {
                throw new Exception("Por gentileza, selecione um item para prosseguir com a ação" );
            }
        }
    }
}
