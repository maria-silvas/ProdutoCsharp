using Controllers;
using Models;

namespace Views
{
    public class CriarAlmoxarifado : Form
    {
        public Label lblName;
        public TextBox txtName;
        public Button btnRegister;

        public void btnRegister_Click(object sender, EventArgs e)
        {
            Models.Almoxarifado almoxarifado = new Models.Almoxarifado(
                txtName.Text
            );

            Controllers.Almoxarifado.CriarAlmoxarifado(almoxarifado);
            MessageBox.Show("Almoxarifado foi registrado!");

            ClearForm();

            ListarAlmoxarifado AlmoxarifadoLsit = Application.OpenForms.OfType<ListarAlmoxarifado>().FirstOrDefault();
            if (AlmoxarifadoLsit != null)
            {
                AlmoxarifadoLsit.RefreshList();
            }

            this.Close();
        }

        private void ClearForm(){
            txtName.Clear();
        }

        public CriarAlmoxarifado()
        {
            this.Text = "Registar Almoxarifado";
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
            this.txtName.Location = new System.Drawing.Point(80, 40);
            this.txtName.Size = new System.Drawing.Size(150, 20);

            this.btnRegister = new Button();
            button.BackColor = Color.Green;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.Location = new System.Drawing.Point(80, 110);
            this.btnRegister.Size = new System.Drawing.Size(150, 35);
            this.btnRegister.Click += new EventHandler(this.btnRegister_Click);

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRegister);

        }
    }

}
