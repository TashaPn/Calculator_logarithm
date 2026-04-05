using System;
using System.IO;
using System.Windows.Forms;


namespace Calculator_app
{
    public partial class Form1 : Form
    {

        const string logFile = "calculator.log";

        public Form1()
        {
            InitializeComponent();
            File.WriteAllText(logFile, "");
        }

        private (Logarithm logOne, Logarithm logTwo) getLogarithms()
        {
            double logOneBase = 0;
            double logOneArg = 0;
            double logTwoBase = 0;
            double logTwoArg = 0;


            logOneBase = double.Parse(textBox1.Text);
            logOneArg = double.Parse(textBox2.Text);
            logTwoBase = double.Parse(textBox4.Text);
            logTwoArg = double.Parse(textBox5.Text);

            Logarithm log1 = new Logarithm(logOneBase, logOneArg);
            Logarithm log2 = new Logarithm(logTwoBase, logTwoArg);

            return (log1, log2);

        }

        private (Logarithm logOne, double count) getLogcount()
        {
            double logOneBase = 0;
            double logOneArg = 0;
            double count = 0;

            logOneBase = double.Parse(textBox6.Text);
            logOneArg = double.Parse(textBox3.Text);
            count = double.Parse(textBox7.Text);

            Logarithm log1 = new Logarithm(logOneBase, logOneArg);

            return (log1, count);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label11.Text = "ошибка :";
            var calculator = new LogCalculator();
            try
            {
                var logs = getLogcount();
                Logarithm log1 = logs.logOne;
                double count = logs.count;

                double result = calculator.Power(log1, count);
                label14.Text = "^";
                label9.Text = result.ToString();

                File.AppendAllText(logFile, $"{log1}^{count} = {result}" + Environment.NewLine);

            }
            catch (Exception ex)
            {
                label11.Text = $"ошибка : {ex.Message}";
                File.AppendAllText(logFile, $"{ex.Message}" + Environment.NewLine);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label11.Text = "ошибка :";
            var calculator = new LogCalculator();
            try {
                var logs = getLogarithms();
                Logarithm log1 = logs.logOne;
                Logarithm log2 = logs.logTwo;

                double result = log1 - log2;
                label13.Text = "-";
                label6.Text = result.ToString();

                File.AppendAllText(logFile, $"{log1}-{log2} = {result}" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                label11.Text = $"ошибка : {ex.Message}";
                File.AppendAllText(logFile, $"{ex.Message}" + Environment.NewLine);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            label11.Text = "ошибка :";
            var calculator = new LogCalculator();
            try
            {
                var logs = getLogarithms();
                Logarithm log1 = logs.logOne;
                Logarithm log2 = logs.logTwo;

                double result = log1 / log2;
                label13.Text = "/";
                label6.Text = result.ToString();

                File.AppendAllText(logFile, $"{log1}/{log2} = {result}" + Environment.NewLine);

            }
            catch (Exception ex)
            {
                label11.Text = $"ошибка : {ex.Message}";
                File.AppendAllText(logFile, $"{ex.Message}" + Environment.NewLine);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label11.Text = "ошибка :";
            var calculator = new LogCalculator();
            try
            {
                var logs = getLogarithms();
                Logarithm log1 = logs.logOne;
                Logarithm log2 = logs.logTwo;

                double result = log1 + log2;
                label13.Text = "+";
                label6.Text = result.ToString();

                File.AppendAllText(logFile, $"{log1}+{log2} = {result}" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                label11.Text = $"ошибка : {ex.Message}";
                File.AppendAllText(logFile, $"{ex.Message}" + Environment.NewLine);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label11.Text = "ошибка :";
            var calculator = new LogCalculator();
            try
            {
                var logs = getLogarithms();
                Logarithm log1 = logs.logOne;
                Logarithm log2 = logs.logTwo;

                double result = log1 * log2;
                label13.Text = "*";
                label6.Text = result.ToString();

                File.AppendAllText(logFile, $"{log1}*{log2} = {result}" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                label11.Text = $"ошибка : {ex.Message}";
                File.AppendAllText(logFile, $"{ex.Message}" + Environment.NewLine);
            }
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            label12.Text = "Операция : Сложение логарифмов";
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            label12.Text = "Операция : ";
        }

        private void button13_MouseEnter(object sender, EventArgs e)
        {
            label12.Text = "Операция : Вычитание логарифмов";
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            label12.Text = "Операция : ";
        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            label12.Text = "Операция : Умножение логарифмов";
        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            label12.Text = "Операция : ";
        }

        private void button14_MouseEnter(object sender, EventArgs e)
        {
            label12.Text = "Операция : Деление логарифмов";
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            label12.Text = "Операция : ";
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            label12.Text = "Операция : Возведение логарифма в степень";
        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            label12.Text = "Операция : ";
        }

        private void button17_MouseEnter(object sender, EventArgs e)
        {
            label12.Text = "Операция : Приведение логарифма к новому основанию";
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            label12.Text = "Операция : ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            label11.Text = "ошибка :";
            var calculator = new LogCalculator();
            try
            {
                var logs = getLogcount();
                Logarithm log1 = logs.logOne;
                double count = logs.count;

                double result = calculator.ChangeBaseValue(log1, count);
                label14.Text = "nb";
                label9.Text = result.ToString();

                File.AppendAllText(logFile, $"{log1} nb {count} = {result}" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                label11.Text = $"ошибка : {ex.Message}";
                File.AppendAllText(logFile, $"{ex.Message}" + Environment.NewLine);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 helpForm = new Form2();

            helpForm.Show();
        }
    }

    public class Logarithm
    {
        public double Base { get; set; }

        public double Argument { get; set; }

        // Создаёт объект логарифма с указанным основанием и аргументом.
        // logBase - целочисленное основание логарифма; должно быть больше нуля и не равно единице.
        // logArg - целочисленный аргумент логарифма; должен быть больше нуля. 
        public Logarithm(double logBase, double logArg)
        {
            if (logBase != 1 && logBase <= 0)
            {
                throw new ArgumentException("База логарифма должна быть больше 0 и не равна 1");
            }
            else if (logArg <= 0)
            {
                throw new ArgumentException("Аргумент логарифма должна быть больше 0 ");
            }

            Base = logBase;
            Argument = logArg;
            Console.WriteLine($"log{Base}_{Argument}");
        }

        // Возвращает строковое представление логарифма в удобном для вывода формате.
        public override string ToString()
        {
            return $"log{Base}_{Argument}";
        }

        // Складывает численные значения двух логарифмов - !перегруженная операция!
        public static double operator +(Logarithm a, Logarithm b)
        {
            double firstlog = Math.Log(a.Argument, a.Base);
            double secondlog = Math.Log(b.Argument, b.Base);

            double result = firstlog + secondlog;

            return result;
        }

        // Вычитает численное значение второго логарифма из численного значения первого - !перегруженная операция!
        public static double operator -(Logarithm a, Logarithm b)
        {
            double firstlog = Math.Log(a.Argument, a.Base);
            double secondlog = Math.Log(b.Argument, b.Base);

            double result = firstlog - secondlog;

            return result;
        }

        // Умножает численные значения двух логарифмов - !перегруженная операция!
        public static double operator *(Logarithm a, Logarithm b)
        {
            double firstlog = Math.Log(a.Argument, a.Base);
            double secondlog = Math.Log(b.Argument, b.Base);

            double result = firstlog * secondlog;

            return result;
        }

        // Делит численное значение первого логарифма на численное значение второго - !перегруженная операция!
        public static double operator /(Logarithm a, Logarithm b)
        {
            double firstlog = Math.Log(a.Argument, a.Base);
            double secondlog = Math.Log(b.Argument, b.Base);

            double result = firstlog / secondlog;

            return result;
        }

    }

    public class LogCalculator
    {

        // Возводит численное значение логарифма в указанную степень.
        public double Power(Logarithm a, double exponent)
        {
            double firstlog = Math.Log(a.Argument, a.Base);
            double result = Math.Pow(firstlog, exponent);


            return result;
        }

        // Выполняет переход к другому основанию и возвращает численное значение логарифма в новом основании.
        public double ChangeBaseValue(Logarithm a, double newBase)
        {
            double firstlog = Math.Log(a.Argument, a.Base);
            double result = Math.Log(firstlog, newBase);


            return result;
        }
    }
}
