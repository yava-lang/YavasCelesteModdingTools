namespace YavaCelesteModdingTools
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            label1.Text = "Welcome to the" + Environment.NewLine +
            "Yava's Celeste Modding Tools!";
            label2.Text = "Yava's Celeste Modding Tools are created to simplify mod's technical creation process." + Environment.NewLine +
            "Features may vary from basic mod structure setup, up to adding custom tilesets and decals with easy to set up attributes";
            button1.Text = "Start";
        }

        private void label1_Click(object sender, System.EventArgs e)
        {
        
        }

        private void Welcome_Load(object sender, System.EventArgs e)
        {
        
        }

        private void label2_Click(object sender, System.EventArgs e)
        {
        
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            NewProject next = new NewProject();
            next.Show();
            this.Hide();
        }
    }
}
