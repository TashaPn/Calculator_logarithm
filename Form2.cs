using System.IO;
using System.Windows.Forms;

namespace Calculator_app
{
    public partial class Form2 : Form
    {

        const string logFile = "calculator.log";

        public Form2()
        {
            InitializeComponent();
            string allLog = File.ReadAllText(logFile );
            textBox1.Text = allLog;
        }
    }
}
