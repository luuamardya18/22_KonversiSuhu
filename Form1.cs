namespace konversi_suhu_22_LuluAmardiya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Fungsi terpisah untuk konversi suhu
        private double ConvertTemperature(double value, string fromUnit, string toUnit)
        {
            {
                double celsius = value;

                // Ubah semua ke Celsius dulu
                if (fromUnit == "Fahrenheit")
                    celsius = (value - 32) * 5 / 9;
                else if (fromUnit == "Kelvin")
                    celsius = value - 273.15;

                // Lalu konversi dari Celsius ke unit tujuan
                if (toUnit == "Celsius")
                    return celsius;
                else if (toUnit == "Fahrenheit")
                    return (celsius * 9 / 5) + 32;
                else if (toUnit == "Kelvin")
                    return celsius + 273.15;

                return value;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbfrom.Items.AddRange(new string[] { "Celcius", "Fahrenheit", "Kelvin" });
            cmbto.Items.AddRange(new string[] { "Celcius", "Fahrenheit", "Kelvin" });
            cmbfrom.SelectedIndex = 0;
            cmbto.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txttemperature.Text, out double inputTemp))
            {
                string fromUnit = cmbfrom.SelectedItem.ToString();
                string toUnit = cmbto.SelectedItem.ToString();

                // Panggil fungsi terpisah
                double result = ConvertTemperature(inputTemp, fromUnit, toUnit);

                // Tampilkan ke TextBox hasil
                txtresult.Text = result.ToString("F2");
            }
            else
            {
                MessageBox.Show("Masukkan angka suhu yang valid!");
            }
        }



        private void btnresult_Click(object sender, EventArgs e)
        {

        }
    }
}