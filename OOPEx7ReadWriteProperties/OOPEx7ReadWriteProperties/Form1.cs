using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMADPartyStore;

namespace OOPEx7ReadWriteProperties
{
    public partial class Form1 : Form
    {
        private Balloon balloon;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                balloon = new Balloon();

                balloon.Diameter = Convert.ToInt16(txtDiameter.Text);
                balloon.Colour = txtColour.Text.Trim();
                balloon.Height = Convert.ToInt16(txtHeight.Text);


            }
            catch (Exception ex)
            {
                balloon = null;
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        private void btnGet_Click(object sender, EventArgs e)
        {
            if (balloon != null)
            {
                label4.Text = $"Colour: {balloon.Colour}\n" +
                    $"Height: {balloon.Height.ToString()}\n" +
                    $"Diameter: {balloon.Diameter.ToString()}";
            }
            else
            {
                MessageBox.Show("You break bussiness rules, the balloon is invalid");
            }
        }
    }
}
