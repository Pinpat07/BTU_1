using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTU_1
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Black form_Black = new Form_Black();
            form_Black.ShowDialog();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Light form_light = new Form_Light();
            form_light.ShowDialog();

            
            
        }
    }
}
