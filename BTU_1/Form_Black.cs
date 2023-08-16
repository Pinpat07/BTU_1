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
    public partial class Form_Black : Form
    {
        public Form_Black()
        {
            InitializeComponent();
        }

        private void Form_Black_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtScore.Text, out int squMeter))
            {
                // คำนวณเกรด
                string BTU;
                if (squMeter >55)
                    BTU = "กรุณาติดต่อบริษัทเพื่อเลือกขนาดที่เหมาะสม";
                else if (squMeter >= 51 && squMeter <= 55)
                    BTU = "40,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 46 && squMeter <= 50)
                    BTU = "36,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 38 && squMeter <= 42)
                    BTU = "30,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 30 && squMeter <= 34)
                    BTU = "24,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 27 && squMeter <= 31)
                    BTU = "22,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 25 && squMeter <= 29)
                    BTU = "20,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 22 && squMeter <= 26)
                    BTU = "18,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 18 && squMeter <= 22)
                    BTU = "15,000 BTU คือขนาดแอร์ที่เหมาะสม ";
                else if (squMeter >= 14 && squMeter <= 18)
                    BTU = "12,000 BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 10 && squMeter <= 14)
                    BTU = "9,000  BTU คือขนาดแอร์ที่เหมาะสม";
                else if (squMeter >= 5 && squMeter <= 7)
                    BTU = "5,000 BTU คือขนาดแอร์ที่เหมาะสม";


                else
                    BTU = "5,000 ";

                // แสดงผลลัพธ์ใน MessageBox
                MessageBox.Show($"ขนาดพื้นที่ห้องนอน {squMeter} ตร.ม.  {BTU}", "ผลลัพธ์", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("โปรดกรอกข้อมูลที่ถูกต้องให้ครบถ้วน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            
        }
    }
}
