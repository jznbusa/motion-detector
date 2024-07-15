
namespace Finals_152_153_2019
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLdate = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pirTBL = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pirtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iotDataSet = new Finals_152_153_2019.iotDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLtime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pirtblTableAdapter = new Finals_152_153_2019.iotDataSetTableAdapters.pirtblTableAdapter();
            this.BTNclear = new System.Windows.Forms.Button();
            this.BTNdel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pirTBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(276, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOTION DETECTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Pink;
            this.label2.Location = new System.Drawing.Point(212, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "RECORDS";
            // 
            // LBLdate
            // 
            this.LBLdate.AutoSize = true;
            this.LBLdate.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLdate.ForeColor = System.Drawing.Color.Pink;
            this.LBLdate.Location = new System.Drawing.Point(4, 38);
            this.LBLdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLdate.Name = "LBLdate";
            this.LBLdate.Size = new System.Drawing.Size(53, 20);
            this.LBLdate.TabIndex = 4;
            this.LBLdate.Text = "Date";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM8";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BTNdel);
            this.panel1.Controls.Add(this.pirTBL);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LBLtime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LBLdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Location = new System.Drawing.Point(201, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 360);
            this.panel1.TabIndex = 6;
            // 
            // pirTBL
            // 
            this.pirTBL.AllowUserToOrderColumns = true;
            this.pirTBL.AutoGenerateColumns = false;
            this.pirTBL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pirTBL.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.pirTBL.ColumnHeadersHeight = 25;
            this.pirTBL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.pirTBL.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.pirTBL.DataSource = this.pirtblBindingSource;
            this.pirTBL.GridColor = System.Drawing.Color.SlateBlue;
            this.pirTBL.Location = new System.Drawing.Point(4, 121);
            this.pirTBL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pirTBL.Name = "pirTBL";
            this.pirTBL.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pirTBL.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pirTBL.RowHeadersWidth = 62;
            this.pirTBL.Size = new System.Drawing.Size(561, 228);
            this.pirTBL.TabIndex = 7;
            this.pirTBL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pirTBL_CellContentClick_1);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pirtblBindingSource
            // 
            this.pirtblBindingSource.DataMember = "pirtbl";
            this.pirtblBindingSource.DataSource = this.iotDataSet;
            // 
            // iotDataSet
            // 
            this.iotDataSet.DataSetName = "iotDataSet";
            this.iotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.Location = new System.Drawing.Point(393, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Pink;
            this.label3.Location = new System.Drawing.Point(4, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search by Date:";
            // 
            // LBLtime
            // 
            this.LBLtime.AutoSize = true;
            this.LBLtime.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtime.ForeColor = System.Drawing.Color.Pink;
            this.LBLtime.Location = new System.Drawing.Point(420, 37);
            this.LBLtime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLtime.Name = "LBLtime";
            this.LBLtime.Size = new System.Drawing.Size(53, 20);
            this.LBLtime.TabIndex = 6;
            this.LBLtime.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(219, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Finals_152_153_2019.Properties.Resources.MotionDetect_smaller;
            this.pictureBox2.Location = new System.Drawing.Point(709, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 64);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Finals_152_153_2019.Properties.Resources.MotionDetect_smaller;
            this.pictureBox1.Location = new System.Drawing.Point(201, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pirtblTableAdapter
            // 
            this.pirtblTableAdapter.ClearBeforeFill = true;
            // 
            // BTNclear
            // 
            this.BTNclear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BTNclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNclear.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclear.ForeColor = System.Drawing.Color.Pink;
            this.BTNclear.Location = new System.Drawing.Point(431, 492);
            this.BTNclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(119, 48);
            this.BTNclear.TabIndex = 8;
            this.BTNclear.Text = "Clear History";
            this.BTNclear.UseVisualStyleBackColor = false;
            this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // BTNdel
            // 
            this.BTNdel.BackColor = System.Drawing.Color.Lavender;
            this.BTNdel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNdel.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.BTNdel.Location = new System.Drawing.Point(476, 91);
            this.BTNdel.Margin = new System.Windows.Forms.Padding(4);
            this.BTNdel.Name = "BTNdel";
            this.BTNdel.Size = new System.Drawing.Size(83, 25);
            this.BTNdel.TabIndex = 13;
            this.BTNdel.Text = "Delete";
            this.BTNdel.UseVisualStyleBackColor = false;
            this.BTNdel.Click += new System.EventHandler(this.BTNdel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(977, 554);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Motion Detection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pirTBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLdate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBLtime;
        private System.Windows.Forms.DataGridView pirTBL;
        private iotDataSet iotDataSet;
        private System.Windows.Forms.BindingSource pirtblBindingSource;
        private iotDataSetTableAdapters.pirtblTableAdapter pirtblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNdel;
    }
}

