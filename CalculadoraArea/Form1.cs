using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum PolygonType
{
    Triangle,
    Square,
    Polygon,
    Rectangle,
}

namespace CalculadoraArea
{
    public partial class Form1 : Form
    {
        Dictionary<RadioButton, PolygonType> polygonTypeRadMap;
        PolygonType polygonType;
        public Form1()
        {
            InitializeComponent();
            this.polygonTypeRadMap = new Dictionary<RadioButton, PolygonType>();
            polygonTypeRadMap.Add(rad_triangle, PolygonType.Triangle);
            polygonTypeRadMap.Add(rad_square, PolygonType.Square);
            polygonTypeRadMap.Add(rad_rectangle, PolygonType.Rectangle);
            polygonTypeRadMap.Add(rad_poly, PolygonType.Polygon);
            txt_area.Enabled = false;
            rad_triangle.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selected = sender as RadioButton;
            if (selected != null)
            {
                if (selected.Checked)
                {
                    this.polygonType = this.polygonTypeRadMap[selected];
                    UpdateView();
                }
            }
        }


        private void UpdateView()
        {
            txt_height.Show();
            txt_area.Text = "";
            switch (this.polygonType)
            {
                case PolygonType.Polygon:
                    lbl_base.Text = "Lado";
                    lbl_height.Text = "N° Lados";
                    break;
                case PolygonType.Rectangle:
                    lbl_base.Text = "Base";
                    lbl_height.Text = "Altura";
                    break;
                case PolygonType.Square:
                    lbl_base.Text = "Lado";
                    lbl_height.Text = "";
                    txt_height.Hide();
                    break;
                case PolygonType.Triangle:
                    lbl_base.Text = "Base";
                    lbl_height.Text = "Altura";
                    break;
            }
        }

        private double CalculatePolygonArea(double side, int numberOfSides)
        {
            double perimeter = side * numberOfSides;
            double alpha = ConvertDegreeToRadians(360 / numberOfSides);
            double apothem = side / (2 * Math.Tan(alpha / 2));
            double result = (perimeter * apothem) / 2;
            return result;
        }

        private double CalculateRectangleArea(double longSide, double shortSide)
        {
            return longSide * shortSide;
        }

        private double CalculateTriangleArea(double _base, double height)
        {
            return (_base * height) / 2;
        }

        private double ConvertDegreeToRadians(double angleInDegree)
        {
            return (Math.PI / 180) * angleInDegree;
        }

        private double GetBase()
        {
            return double.Parse(txt_base.Text);
        }

        private double GetHeight()
        {
            return double.Parse(txt_height.Text);
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double result = 0.0;
            try
            {
                double _base = GetBase();
                double height = GetHeight();
                switch (this.polygonType)
                {
                    case PolygonType.Polygon:
                        result = CalculatePolygonArea(_base, int.Parse(height.ToString()));
                        break;
                    case PolygonType.Rectangle:
                        result = CalculateRectangleArea(_base, height);
                        break;
                    case PolygonType.Square:
                        result = CalculateRectangleArea(_base, _base);
                        break;
                    case PolygonType.Triangle:
                        result = CalculateTriangleArea(_base, height);
                        break;
                }
                this.txt_area.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Dato erróneo");
            }
        }
    }
}
