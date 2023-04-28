using Models;
using Controllers;


namespace Views
{

    public class Menu : Form{

        public Menu(){

            this.Text = "MENU";
            this.Size = new Size(300, 350);
            this.StartPosition = FormStartPosition.CenterScreen;

            Button btnProdutos = new Button();
            button.BackColor = Color.Blue;
            btnProdutos.Text = "Produtos";
            btnProdutos.Size = new Size(150, 50);
            using Models;
using Controllers;


namespace Views
{

    public class Menu : Form{

        public Menu(){

            this.Text = "Menu";
            this.Size = new Size(300, 350);
            this.StartPosition = FormStartPosition.CenterScreen;

            Button btnProdutos = new Button();
            button.BackColor = Color.Blue;
            btnProdutos.Text = "Produtos";
            
            btnProdutos.Size = new Size(150, 50);
            btnProdutos.Location = new Point(70, 50);
            btnProdutos.Click += new EventHandler(btnProdutos_Click);

            Button btnAlmoxarifados = new Button();
            
            btnAlmoxarifados.Text = "Almoxarifados";
            btnAlmoxarifados.Size = new Size(150, 50);
            btnAlmoxarifados.Location = new Point(70, 100);
            btnAlmoxarifados.Click += new EventHandler(btnAlmoxarifados_Click);

            Button btnSaldos = new Button();
            button.BackColor = Color.Blue;
            btnSaldos.Text = "Saldos";
            btnSaldos.Size = new Size(150, 50);
            btnSaldos.Location = new Point(70, 150);
            btnSaldos.Click += new EventHandler(btnSaldos_Click);

            Button btnSair = new Button();
            button.BackColor = Color.Red; 
            btnSair.Text = "Sair";
            btnSair.Size = new Size(150, 50);
            btnSair.Location = new Point(70, 200);
            btnSair.Click += new EventHandler(btnSair_Click);
            

            this.Controls.Add(btnProdutos);
            this.Controls.Add(btnAlmoxarifados);
            this.Controls.Add(btnSaldos);    
            this.Controls.Add(btnSair);


        }

        private void btnProdutos_Click(object sender, EventArgs e){
            ListarProduto produtoView = new ListarProduto();
            produtoView.Show();
        }

        private void btnAlmoxarifados_Click(object sender, EventArgs e){
            ListarAlmoxarifado almoxarifadoView = new ListarAlmoxarifado();
            almoxarifadoView.Show();
        }

        private void btnSaldos_Click(object sender, EventArgs e){
            ListarSaldo saldoView = new ListarSaldo();
            saldoView.Show();
        }

        private void btnSair_Click(object sender, EventArgs e){
            this.Close();
        }


    }
}
            btnProdutos.Location = new Point(70, 50);
            btnProdutos.Click += new EventHandler(btnProdutos_Click);

            Button btnAlmoxarifados = new Button();
            button.BackColor = Color.Blue;
            btnAlmoxarifados.Text = "Almoxarifados";
            btnAlmoxarifados.Size = new Size(150, 50);
            btnAlmoxarifados.Location = new Point(70, 100);
            btnAlmoxarifados.Click += new EventHandler(btnAlmoxarifados_Click);

            Button btnSaldos = new Button();
            button.BackColor = Color.Blue;
            btnSaldos.Text = "Saldos";
            btnSaldos.Size = new Size(150, 50);
            btnSaldos.Location = new Point(70, 150);
            btnSaldos.Click += new EventHandler(btnSaldos_Click);

            Button btnSair = new Button();
            button.BackColor = Color.Red;
            btnSair.Text = "Sair";
            btnSair.Size = new Size(150, 50);
            btnSair.Location = new Point(70, 200);
            btnSair.Click += new EventHandler(btnSair_Click);
            

            this.Controls.Add(btnProdutos);
            this.Controls.Add(btnAlmoxarifados);
            this.Controls.Add(btnSaldos);    
            this.Controls.Add(btnSair);


        }

        private void btnProdutos_Click(object sender, EventArgs e){
            ListarProduto produtoView = new ListarProduto();
            produtoView.Show();
        }

        private void btnAlmoxarifados_Click(object sender, EventArgs e){
            ListarAlmoxarifado almoxarifadoView = new ListarAlmoxarifado();
            almoxarifadoView.Show();
        }

        private void btnSaldos_Click(object sender, EventArgs e){
            ListarSaldo saldoView = new ListarSaldo();
            saldoView.Show();
        }

        private void btnSair_Click(object sender, EventArgs e){
            this.Close();
        }


    }
}
