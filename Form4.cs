using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            
        }

        private void Cure_Click(object sender, EventArgs e)
        {
            
        }

        private void Cure_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void cure_btn_Click_1(object sender, EventArgs e)
        {
            string disease = disease_combo.Text;

            if (disease == "Corona Virus")
            {
                Cure.Text = "1. Get your tests done \r\n" +
                    "2. Quarantine for 14 days \r\n" +
                    "3. Avoid Social Interaction \r\n" +
                    "4. Use Oximeter to check oxygen level \r\n" +
                    "5. Wear Mask";
            }

            if (disease == "Viral Infection")
            {
                Cure.Text = "1. Use Doctor's prescribed Antibiotics \r\n" +
                    "2. Rest as much as possible\r\n" +
                    "3. Take plenty of healthy fluids";
            }

            if (disease == "Heart Problem")
            {
                Cure.Text = "1. Use Doctor's prescribed Medications \r\n" +
                    "2. Eat Green Vegetables \r\n" +
                    "3. Exercise Daily \r\n" +
                    "4. Quit Smoking \r\n" +
                    "5. Take Healthy Diet";
            }

            if (disease == "Spinal Issues")
            {
                Cure.Text = "1. Physical Therapy \r\n" +
                    "2. Maintain good body posture \r\n" +
                    "3. Use correct listing and moving techniques \r\n" +
                    "4. Don't put extra stress on your back \r\n" +
                    "5. Take Healthy Diet";
            }

            if (disease == "Dehydration")
            {
                Cure.Text = "1. Use Natural ingredients in Water \r\n" +
                    "2. Eat more water filled foods \r\n" +
                    "3. Take Fresh Fruits \r\n" +
                    "4. Exercise Daily";
            }

            if (disease == "Fever")
            {
                Cure.Text = "1. Use Doctor's Prescriped Medicines \r\n" +
                    "2. Do Necessary Tests \r\n" +
                    "3. Take Healthy Diet";
            }

            if (disease == "Diarrhea")
            {
                Cure.Text = "1. Use Doctor's Prescriped Antibiotics \r\n" +
                    "2. Drink plenty of clear liquids \r\n" +
                    "3. Avoid certain foods \r\n" +
                    "4. Take Healthy Diet";
            }

            if (disease == "Food Poisoning")
            {
                Cure.Text = "1. Use Doctor's Prescriped Medicines \r\n" +
                    "2. Ease back into eating \r\n" +
                    "3. Avoid certain foods and substances until you're feeling better \r\n" +
                    "4. Rest as much as possible";
            }









        }
    }
}
