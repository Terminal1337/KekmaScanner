using System;
using System.Net.Http;

namespace SYNSCAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"                                                   Disclaimer!!\n We do not Promote Any Illegal Activities by The Use of This Software, You Are Solely Responsible For what you do.\n\n Note: You need to run a worldscan on port 80 and put the list in addresses.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text: $"Started Scan on {textBox1.Text} with Timeout {textBox2.Text}");
            string[] lines = textBox3.Lines;
            string regex = textBox7.Text;

            textBox8.Text = lines.Length.ToString();
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Host", textBox1.Text);
            client.Timeout = TimeSpan.FromSeconds(int.Parse(textBox2.Text));
            progressBar1.Maximum = lines.Length;
            foreach (string line in lines)
            {
                try
                {
                    var response = await client.GetAsync($"http://{line}");

                    if (response.IsSuccessStatusCode)
                    {
                        var responseText = await response.Content.ReadAsStringAsync();
                        if (responseText.Contains(regex))
                        {
                            textBox4.Text += $"\n{line}";
                            progressBar1.Value++;
                            textBox5.Text = Convert.ToString(int.Parse(textBox5.Text) + 1);
                            textBox6.Text = Convert.ToString(int.Parse(textBox6.Text) + 1);
                        }
                    }
                    else
                    {
                        textBox9.Text = Convert.ToString(int.Parse(textBox9.Text) + 1);
                        textBox5.Text = Convert.ToString(int.Parse(textBox5.Text) + 1);

                        progressBar1.Value++;

                    }
                }
                catch (Exception)
                {
                    progressBar1.Value++;
                    textBox9.Text = Convert.ToString(int.Parse(textBox9.Text) + 1);
                    textBox5.Text = Convert.ToString(int.Parse(textBox5.Text) + 1);
                }

            }
            MessageBox.Show(text: "Scan Successfully Completed..");


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}