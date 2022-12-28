using DBProject.View;

namespace DBProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new JoinUsForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ProvideUsForm().Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var F = new ViewXForm();
            F.SetSource(new Controller.MainContext().Customers.ToList());
            F.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var F = new ViewXForm();
            F.SetSource(new Controller.MainContext().Shops.ToList());
            F.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var F = new ViewXForm();
            F.SetSource(new Controller.MainContext().Items.ToList());
            F.Show();
        }
    }
}