namespace Locadora
{
    public partial class Frm_locadora : Form
    {
        public Frm_locadora()
        {
            InitializeComponent();
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {
            tb_email.TextAlign = HorizontalAlignment.Left;
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            tb_password.TextAlign = HorizontalAlignment.Left;
        }

        private void lk_clique_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
