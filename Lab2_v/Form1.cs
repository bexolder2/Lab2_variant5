using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        RecordingStudio rs = new RecordingStudio();

        public Form1()
        {
            InitializeComponent();
            RecordingStudio rs = new RecordingStudio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add
            rs.AddRoom();
            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Del
            if (rs.NumberOfRooms > 0)
            {
                rs.DeleteRoom();
                Invalidate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //-empl
            if(rs.NumberOfEmployee > 0)
            {
                rs.DeleteEmployee();
                Invalidate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //+empl
            rs.AddEmployee();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SolidBrush brush = new SolidBrush(Color.FromArgb(192, 0, 192));
            Point point = new Point(135, 23);
            g.DrawString(rs.Adress, font, brush, point);

            point.Y = 110;
            string price = "-" + rs.PricePerTrack.ToString() + "$";
            g.DrawString(price, font, brush, point);

            point.Y = 170;
            point.X = 180;
            string cash = "-" + rs.CashRegister.ToString() + "$";
            g.DrawString(cash, font, brush, point);

            Font font_ = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            point.X = 340;
            point.Y = 374;
            g.DrawString(rs.NumberOfEmployee.ToString(), font_, brush, point);

            point.Y = 403;
            g.DrawString(rs.NumberOfRooms.ToString(), font_, brush, point);
        }

        private void PlusPlus_ButtonClick(object sender, EventArgs e)
        {
            if(rs.CashRegister > 10)
            {
                rs++;
                Invalidate();
            } 
        }

        private void Minus_ButtonClick(object sender, EventArgs e)
        {
            if(rs.NumberOfRooms > 0)
            {
                rs = -rs;
                Invalidate();
            } 
        }

        private void indexer_Click(object sender, EventArgs e)
        {
            double salary = rs[1];
            double sum = rs[2];
            double cashregister = rs[3];

            MessageBox.Show($"Salary: {salary}\nSumSalary: {sum}\nCash Register: {cashregister}", "Indexer data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
