namespace QuentinhasDoBill;

public partial class Home : Form
{
    public Home()
    {
        InitializeComponent();
    }

    private void Cliente_Click(object sender, EventArgs e)
    {
        Cliente cl = new();
        cl.Show();
    }

    private void Admin_Click(object sender, EventArgs e)
    {
        Admin adm = new();
        adm.Show();
    }


}
