namespace YavaCelesteModdingTools
{
    public partial class NewProject : Form
    {
        private string? textBox1temp;
        private string? celesteFolder;
        private string? projectUsername;
        private string? projectCampaign;
        private string? projectMapname;
        public NewProject()
        {
            InitializeComponent();
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void NewProject_Load(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            label5.Text = "";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            celesteFolder = null;
            projectUsername = null;
            projectCampaign = null;
            projectMapname = null;

            // Celeste Folder
            if (textBox1.Text.Length == 0) label5.Text = "! The path is not selected";
            else if (!Directory.Exists(textBox1.Text)) label5.Text = "! That is not a folder that exist";
            else if (!File.Exists(textBox1.Text + "\\Celeste.exe")) label5.Text = "! Doesn't seem to be a Celeste folder.";
            else if (!Directory.Exists(textBox1.Text + "\\Mods")) label5.Text = "! Make sure to select MODDED celeste folder";
            else celesteFolder = textBox1.Text;

            // Username
            if (textBox2.Text.Length == 0) label6.Text = "! The username is not filled";
            else if (textBox2.Text.Length < 3) label6.Text = "! Username is too small for me to notice it";
            else if (textBox2.Text.Length > 20) label6.Text = "! Username is too big for me to comprehend it";
            else if (!textBox2.Text.All(c => char.IsAsciiLetterOrDigit(c) || c == '_')) label6.Text = "! Username should only use latin symbols, numbers or underscores";
            else projectUsername = textBox2.Text;

            // Campaing Name
            if (textBox3.Text.Length == 0) label7.Text = "! The campaign name is not filled";

            // Map Name
            if (textBox4.Text.Length == 0) label8.Text = "! The map name is not filled";
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            textBox1temp = textBox1.Text;

            textBox1.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Celeste";
            folderBrowserDialog1.SelectedPath = textBox1.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                textBox1.Text = textBox1temp;
            }
        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {
            label6.Text = "";
        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, System.EventArgs e)
        {
            label7.Text = "";
        }

        private void textBox4_TextChanged(object sender, System.EventArgs e)
        {
            label8.Text = "";
        }
    }
}
