using Models;
using Controllers;


namespace Views{
    public class EditarAlmoxarifado : Form{

        public Label lblName;
        public TextBox txtName;
        public Button btnRegister;
        public Models.Almoxarifado almoxarifado;


        public void btnEdit_Click(object sender, EventArgs e){

            Models.Almoxarifado almoxarifado = this.almoxarifado;
            almoxarifado.Nome = txtName.Text;

            Controllers.Almoxarifado.AtualizarAlmoxarifado(almoxarifado);
            MessageBox.Show("O almoxarifado foi alterado!");

            Views.ListarAlmoxarifado AlmoxarifadoList = Application.OpenForms.OfType<Views.ListarAlmoxarifado>().FirstOrDefault();
            if (AlmoxarifadoList != null){
                AlmoxarifadoList.RefreshList();
            }
            this.Close();
        }
        public EditarAlmoxarifado(Models.Almoxarifado almoxarifado){

            this.almoxarifado = almoxarifado;

            this.Text = "Editar almoxarifado";
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
            this.txtName.Text = almoxarifado.Nome;
            this.txtName.Location = new System.Drawing.Point(80, 40);
            this.txtName.Size = new System.Drawing.Size(150, 20);

            this.btnRegister = new Button();
            button.BackColor = Color.Blue;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.Location = new System.Drawing.Point(80, 110);
            this.btnRegister.Size = new System.Drawing.Size(150, 35);
            this.btnRegister.Click += new EventHandler(this.btnEdit_Click);

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRegister);
        }
    }
}
