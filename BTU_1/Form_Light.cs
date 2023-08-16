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
    public partial class Form_Light : Form
    {
        public Form_Light()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int squMeter))
            {
                // คำนวณเกรด
                string BTU;
                if (squMeter > 52)
                    BTU = "กรุณาติดต่อบริษัทเพื่อเลือกขนาดที่เหมาะสม";
                else if (squMeter >= 48 && squMeter <= 52)
                    BTU = "40,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 44 && squMeter <= 47)
                    BTU = "36,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 35 && squMeter <= 39)
                    BTU = "30,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 28 && squMeter <= 32)
                    BTU = "24,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 25 && squMeter <= 29)
                    BTU = "22,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 23 && squMeter <= 27)
                    BTU = "20,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 20 && squMeter <= 24)
                    BTU = "18,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 17 && squMeter <= 21)
                    BTU = "15,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 13 && squMeter <= 17)
                    BTU = "12,000 BTU คือขนาดแอร์ที่เหมาะสม ";
                else if (squMeter >= 9 && squMeter <= 13)
                    BTU = "9,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 4 && squMeter <= 8)
                    BTU = "5,000  BTU คือขนาดแอร์ที่เหมาะสม";
               


                else
                    BTU = "5,000 คือขนาดแอร์ที่เหมาะสม ";

                // แสดงผลลัพธ์ใน MessageBox
                MessageBox.Show($"ขนาดพื้นที่ห้องนอน {squMeter} ตร.ม.  {BTU}", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("โปรดกรอกข้อมูลที่ถูกต้องให้ครบถ้วน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
