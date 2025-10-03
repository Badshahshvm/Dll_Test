using ClassLibrary4;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Call your DLL function

                Class1.initCommand();
                // Get what DLL printed
                string output = sw.ToString();

                // Show output in MessageBox
                MessageBox.Show(output, "DLL Output");
            }
       
        }
    }
}
