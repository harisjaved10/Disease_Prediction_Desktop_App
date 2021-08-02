using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ProjectX
{

    public partial class Form3 : Form
    {
        SqlConnection connection;

        public Form3()
        {
            InitializeComponent();

            string ConnectionString = Properties.Settings.Default.ConnectionString;
            connection = new SqlConnection(ConnectionString);
        }

        // SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=ProjectDB;Integrated Security=True");


        string imglocation = "";
        SqlCommand cmd;



        private void button2_Click(object sender, EventArgs e)
        {
            string Symptom1 = comboBox1.Text;
            string Symptom2 = comboBox2.Text;
            string Symptom3 = comboBox3.Text;

            if ((Symptom1 == "Cough" || Symptom1 == "Headache" || Symptom1 == "High Temperature") && (Symptom2 == "Cough" || Symptom2 == "Headache" || Symptom2 == "High Temperature") && (Symptom3 == "Cough" || Symptom3 == "Headache" || Symptom3 == "High Temperature"))
            {
                Result.Text = "Corona Virus";
            }

            if ((Symptom1 == "High Blood Pressure") || (Symptom2 == "High Blood Pressure") || (Symptom3 == "High Blood Pressure"))
            {
                Result.Text = "Heart Problem";
            }

            if ((Symptom1 == "Low Blood Pressure") || (Symptom2 == "Low Blood Pressure") || (Symptom3 == "Low Blood Pressure"))
            {
                Result.Text = "Dehydration";
            }

            if ((Symptom1 == "Flu" || Symptom1 == "Cough" || Symptom1 == "Coldness") && (Symptom2 == "Flu" || Symptom2 == "Cough" || Symptom2 == "Coldness") && (Symptom3 == "Flu" || Symptom3 == "Cough" || Symptom3 == "Coldness"))
            {
                Result.Text = "Viral Infection";
            }

            if ((Symptom1 == "Flu") || (Symptom2 == "Flu") || (Symptom3 == "Flu"))
            {
                Result.Text = "Viral Infection";
            }

            if ((Symptom1 == "BackPain") || (Symptom2 == "BackPain") || (Symptom3 == "BackPain"))
            {
                Result.Text = "Spinal Issues";
            }

            if ((Symptom1 == "Coldness") || (Symptom2 == "Coldness") || (Symptom3 == "Coldness"))
            {
                Result.Text = "Fever";
            }

            if ((Symptom1 == "Nausea" || Symptom1 == "Vomiting") && (Symptom2 == "Nausea" || Symptom2 == "Vomiting") && (Symptom3 == "Nausea" || Symptom3 == "Vomiting"))
            {
                Result.Text = "Food Poisoning";
            }

            if ((Symptom1 == "Abdominal Cramps") || (Symptom2 == "Abdominal Cramps") || (Symptom3 == "Abdominal Cramps"))
            {
                Result.Text = "Diarrhea";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png | jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog()==DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imglocation;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imglocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            connection.Open();
            string sqlQuery = "Insert into ImageTable(Image)Values(@images)";
            cmd = new SqlCommand(sqlQuery,connection);
            cmd.Parameters.Add(new SqlParameter("@images",images));
            int N = cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(N.ToString()+"Image Saved");
        }
    }
}
