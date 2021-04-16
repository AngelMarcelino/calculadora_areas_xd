
namespace CalculadoraArea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_base = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.txt_base = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.rad_triangle = new System.Windows.Forms.RadioButton();
            this.rad_square = new System.Windows.Forms.RadioButton();
            this.rad_rectangle = new System.Windows.Forms.RadioButton();
            this.rad_poly = new System.Windows.Forms.RadioButton();
            this.group_polygon_type = new System.Windows.Forms.GroupBox();
            this.group_polygon_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(317, 175);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Calcular";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_base
            // 
            this.lbl_base.AutoSize = true;
            this.lbl_base.Location = new System.Drawing.Point(12, 75);
            this.lbl_base.Name = "lbl_base";
            this.lbl_base.Size = new System.Drawing.Size(31, 15);
            this.lbl_base.TabIndex = 1;
            this.lbl_base.Text = "Base";
            this.lbl_base.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(12, 100);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(39, 15);
            this.lbl_height.TabIndex = 2;
            this.lbl_height.Text = "Altura";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.Location = new System.Drawing.Point(12, 126);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(31, 15);
            this.lbl_area.TabIndex = 3;
            this.lbl_area.Text = "Area";
            // 
            // txt_base
            // 
            this.txt_base.Location = new System.Drawing.Point(70, 72);
            this.txt_base.Name = "txt_base";
            this.txt_base.Size = new System.Drawing.Size(141, 23);
            this.txt_base.TabIndex = 4;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(70, 97);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(141, 23);
            this.txt_height.TabIndex = 5;
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(70, 123);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(141, 23);
            this.txt_area.TabIndex = 6;
            // 
            // rad_triangle
            // 
            this.rad_triangle.AutoSize = true;
            this.rad_triangle.Location = new System.Drawing.Point(6, 22);
            this.rad_triangle.Name = "rad_triangle";
            this.rad_triangle.Size = new System.Drawing.Size(74, 19);
            this.rad_triangle.TabIndex = 7;
            this.rad_triangle.TabStop = true;
            this.rad_triangle.Text = "Triángulo";
            this.rad_triangle.UseVisualStyleBackColor = true;
            this.rad_triangle.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_square
            // 
            this.rad_square.AutoSize = true;
            this.rad_square.Location = new System.Drawing.Point(6, 47);
            this.rad_square.Name = "rad_square";
            this.rad_square.Size = new System.Drawing.Size(77, 19);
            this.rad_square.TabIndex = 8;
            this.rad_square.TabStop = true;
            this.rad_square.Text = "Cuadrado";
            this.rad_square.UseVisualStyleBackColor = true;
            this.rad_square.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_rectangle
            // 
            this.rad_rectangle.AutoSize = true;
            this.rad_rectangle.Location = new System.Drawing.Point(6, 73);
            this.rad_rectangle.Name = "rad_rectangle";
            this.rad_rectangle.Size = new System.Drawing.Size(85, 19);
            this.rad_rectangle.TabIndex = 9;
            this.rad_rectangle.TabStop = true;
            this.rad_rectangle.Text = "Rectángulo";
            this.rad_rectangle.UseVisualStyleBackColor = true;
            this.rad_rectangle.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_poly
            // 
            this.rad_poly.AutoSize = true;
            this.rad_poly.Location = new System.Drawing.Point(6, 98);
            this.rad_poly.Name = "rad_poly";
            this.rad_poly.Size = new System.Drawing.Size(73, 19);
            this.rad_poly.TabIndex = 10;
            this.rad_poly.TabStop = true;
            this.rad_poly.Text = "Polígono";
            this.rad_poly.UseVisualStyleBackColor = true;
            this.rad_poly.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // group_polygon_type
            // 
            this.group_polygon_type.Controls.Add(this.rad_triangle);
            this.group_polygon_type.Controls.Add(this.rad_poly);
            this.group_polygon_type.Controls.Add(this.rad_square);
            this.group_polygon_type.Controls.Add(this.rad_rectangle);
            this.group_polygon_type.Location = new System.Drawing.Point(251, 42);
            this.group_polygon_type.Name = "group_polygon_type";
            this.group_polygon_type.Size = new System.Drawing.Size(141, 127);
            this.group_polygon_type.TabIndex = 11;
            this.group_polygon_type.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 208);
            this.Controls.Add(this.group_polygon_type);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_base);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.lbl_base);
            this.Controls.Add(this.btn_calculate);
            this.Name = "Form1";
            this.Text = "Calculadora de areas";
            this.group_polygon_type.ResumeLayout(false);
            this.group_polygon_type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label @base;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_base;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton rad_triangle;
        private System.Windows.Forms.RadioButton rad_square;
        private System.Windows.Forms.RadioButton rad_;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label lbl_base;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.RadioButton rad_rectangle;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rad_poly;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.GroupBox group_polygon_type;
    }
}

