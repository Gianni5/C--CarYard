namespace CarYard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nUdPlate = new System.Windows.Forms.NumericUpDown();
            this.bntSaveCar = new System.Windows.Forms.Button();
            this.btnLoadCars = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.txbColour = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.txbBrand = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bntOpenFile = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nUdPlate);
            this.groupBox1.Controls.Add(this.bntSaveCar);
            this.groupBox1.Controls.Add(this.btnLoadCars);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Model);
            this.groupBox1.Controls.Add(this.txbColour);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txbModel);
            this.groupBox1.Controls.Add(this.txbBrand);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cars";
            // 
            // nUdPlate
            // 
            this.nUdPlate.Location = new System.Drawing.Point(82, 57);
            this.nUdPlate.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUdPlate.Name = "nUdPlate";
            this.nUdPlate.Size = new System.Drawing.Size(111, 20);
            this.nUdPlate.TabIndex = 13;
            // 
            // bntSaveCar
            // 
            this.bntSaveCar.Location = new System.Drawing.Point(184, 244);
            this.bntSaveCar.Name = "bntSaveCar";
            this.bntSaveCar.Size = new System.Drawing.Size(75, 23);
            this.bntSaveCar.TabIndex = 12;
            this.bntSaveCar.Text = "Save Car";
            this.bntSaveCar.UseVisualStyleBackColor = true;
            this.bntSaveCar.Click += new System.EventHandler(this.bntSaveCar_Click);
            // 
            // btnLoadCars
            // 
            this.btnLoadCars.Location = new System.Drawing.Point(96, 244);
            this.btnLoadCars.Name = "btnLoadCars";
            this.btnLoadCars.Size = new System.Drawing.Size(75, 23);
            this.btnLoadCars.TabIndex = 11;
            this.btnLoadCars.Text = "Load Cars";
            this.btnLoadCars.UseVisualStyleBackColor = true;
            this.btnLoadCars.Click += new System.EventHandler(this.btnLoadCars_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(7, 244);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Colour:";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(37, 100);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(39, 13);
            this.Model.TabIndex = 7;
            this.Model.Text = "Model:";
            // 
            // txbColour
            // 
            this.txbColour.Location = new System.Drawing.Point(83, 139);
            this.txbColour.Name = "txbColour";
            this.txbColour.Size = new System.Drawing.Size(110, 20);
            this.txbColour.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plate:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txbModel
            // 
            this.txbModel.Location = new System.Drawing.Point(83, 97);
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(110, 20);
            this.txbModel.TabIndex = 2;
            // 
            // txbBrand
            // 
            this.txbBrand.Location = new System.Drawing.Point(82, 19);
            this.txbBrand.Name = "txbBrand";
            this.txbBrand.Size = new System.Drawing.Size(110, 20);
            this.txbBrand.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(302, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 289);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // bntOpenFile
            // 
            this.bntOpenFile.Location = new System.Drawing.Point(122, 339);
            this.bntOpenFile.Name = "bntOpenFile";
            this.bntOpenFile.Size = new System.Drawing.Size(83, 33);
            this.bntOpenFile.TabIndex = 2;
            this.bntOpenFile.Text = "OpenFile";
            this.bntOpenFile.UseVisualStyleBackColor = true;
            this.bntOpenFile.Click += new System.EventHandler(this.bntOpenFile_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 384);
            this.Controls.Add(this.bntOpenFile);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cars Yard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdPlate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.TextBox txbBrand;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbColour;
        private System.Windows.Forms.Button bntSaveCar;
        private System.Windows.Forms.Button btnLoadCars;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.NumericUpDown nUdPlate;
        private System.Windows.Forms.Button bntOpenFile;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

