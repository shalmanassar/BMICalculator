namespace BMICalculator
{
    partial class form_BMI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_feet = new System.Windows.Forms.TextBox();
            this.tb_cm = new System.Windows.Forms.TextBox();
            this.tb_lbs = new System.Windows.Forms.TextBox();
            this.tb_kilos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_process = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.rd_customary = new System.Windows.Forms.RadioButton();
            this.rd_metric = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_inches = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "How tall are you?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "How much do you weigh?";
            // 
            // tb_feet
            // 
            this.tb_feet.Location = new System.Drawing.Point(239, 111);
            this.tb_feet.Name = "tb_feet";
            this.tb_feet.ReadOnly = true;
            this.tb_feet.Size = new System.Drawing.Size(79, 34);
            this.tb_feet.TabIndex = 2;
            this.tb_feet.TextChanged += new System.EventHandler(this.tb_feet_TextChanged);
            // 
            // tb_cm
            // 
            this.tb_cm.Location = new System.Drawing.Point(527, 111);
            this.tb_cm.Name = "tb_cm";
            this.tb_cm.ReadOnly = true;
            this.tb_cm.Size = new System.Drawing.Size(79, 34);
            this.tb_cm.TabIndex = 4;
            this.tb_cm.TextChanged += new System.EventHandler(this.tb_cm_TextChanged);
            // 
            // tb_lbs
            // 
            this.tb_lbs.Location = new System.Drawing.Point(305, 156);
            this.tb_lbs.Name = "tb_lbs";
            this.tb_lbs.ReadOnly = true;
            this.tb_lbs.Size = new System.Drawing.Size(119, 34);
            this.tb_lbs.TabIndex = 5;
            this.tb_lbs.TextChanged += new System.EventHandler(this.tb_lbs_TextChanged);
            // 
            // tb_kilos
            // 
            this.tb_kilos.Location = new System.Drawing.Point(487, 153);
            this.tb_kilos.Name = "tb_kilos";
            this.tb_kilos.ReadOnly = true;
            this.tb_kilos.Size = new System.Drawing.Size(119, 34);
            this.tb_kilos.TabIndex = 6;
            this.tb_kilos.TextChanged += new System.EventHandler(this.tb_kilos_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please enter your data (either customary or metric).";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(717, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter feet and inches as a whole number.  Enter pounds, centimeters and kilograms" +
    " as a decimal equivalent.";
            // 
            // btn_process
            // 
            this.btn_process.Location = new System.Drawing.Point(71, 242);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(143, 38);
            this.btn_process.TabIndex = 11;
            this.btn_process.Text = "Process BMI";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(271, 242);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(143, 38);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear Data";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(463, 242);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(143, 38);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Exit App";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // rd_customary
            // 
            this.rd_customary.AutoSize = true;
            this.rd_customary.Checked = true;
            this.rd_customary.Location = new System.Drawing.Point(29, 19);
            this.rd_customary.Name = "rd_customary";
            this.rd_customary.Size = new System.Drawing.Size(148, 33);
            this.rd_customary.TabIndex = 14;
            this.rd_customary.TabStop = true;
            this.rd_customary.Text = "Customary";
            this.rd_customary.UseVisualStyleBackColor = true;
            this.rd_customary.CheckedChanged += new System.EventHandler(this.rd_customary_CheckedChanged);
            // 
            // rd_metric
            // 
            this.rd_metric.AutoSize = true;
            this.rd_metric.Location = new System.Drawing.Point(238, 19);
            this.rd_metric.Name = "rd_metric";
            this.rd_metric.Size = new System.Drawing.Size(100, 33);
            this.rd_metric.TabIndex = 15;
            this.rd_metric.Text = "Metric";
            this.rd_metric.UseVisualStyleBackColor = true;
            this.rd_metric.CheckedChanged += new System.EventHandler(this.rd_metric_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_customary);
            this.groupBox1.Controls.Add(this.rd_metric);
            this.groupBox1.Location = new System.Drawing.Point(289, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 53);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // tb_inches
            // 
            this.tb_inches.Location = new System.Drawing.Point(356, 111);
            this.tb_inches.Name = "tb_inches";
            this.tb_inches.ReadOnly = true;
            this.tb_inches.Size = new System.Drawing.Size(79, 34);
            this.tb_inches.TabIndex = 3;
            this.tb_inches.TextChanged += new System.EventHandler(this.tb_inches_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "ft";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "in";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "lbs";
            // 
            // form_BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 317);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_process);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_kilos);
            this.Controls.Add(this.tb_lbs);
            this.Controls.Add(this.tb_cm);
            this.Controls.Add(this.tb_inches);
            this.Controls.Add(this.tb_feet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "form_BMI";
            this.Text = "Body Mass Index Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_feet;
        private System.Windows.Forms.TextBox tb_cm;
        private System.Windows.Forms.TextBox tb_lbs;
        private System.Windows.Forms.TextBox tb_kilos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.RadioButton rd_customary;
        private System.Windows.Forms.RadioButton rd_metric;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_inches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

