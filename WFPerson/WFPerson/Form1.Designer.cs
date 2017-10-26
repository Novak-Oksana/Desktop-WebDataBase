namespace WFPerson
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
            this.dataGridBD = new System.Windows.Forms.DataGridView();
            this.btnread = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btncreate = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_lastname = new System.Windows.Forms.TextBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SQLSwitch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBD
            // 
            this.dataGridBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBD.Location = new System.Drawing.Point(14, 14);
            this.dataGridBD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridBD.Name = "dataGridBD";
            this.dataGridBD.Size = new System.Drawing.Size(699, 310);
            this.dataGridBD.TabIndex = 0;
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(171, 399);
            this.btnread.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(120, 26);
            this.btnread.TabIndex = 1;
            this.btnread.Text = "READ";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(456, 399);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(120, 26);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(310, 399);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(120, 26);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(36, 399);
            this.btncreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(120, 26);
            this.btncreate.TabIndex = 4;
            this.btncreate.Text = "CREATE";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(36, 354);
            this.tb_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(119, 21);
            this.tb_id.TabIndex = 5;
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(456, 354);
            this.tb_age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(119, 21);
            this.tb_age.TabIndex = 6;
            // 
            // tb_lastname
            // 
            this.tb_lastname.Location = new System.Drawing.Point(310, 354);
            this.tb_lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_lastname.Name = "tb_lastname";
            this.tb_lastname.Size = new System.Drawing.Size(119, 21);
            this.tb_lastname.TabIndex = 7;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(171, 354);
            this.tb_firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(119, 21);
            this.tb_firstname.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(501, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(333, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(199, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "FirstName";
            // 
            // SQLSwitch
            // 
            this.SQLSwitch.FormattingEnabled = true;
            this.SQLSwitch.Items.AddRange(new object[] {
            "Binary",
            "BinaryL",
            "MsSQL",
            "MySQL",
            "H2",
            "JsonLb",
            "XmlLb",
            "CsvLb",
            "YamlLb",
            "Json",
            "Xml",
            "Csv",
            "Yaml",
            "MongoDb",
            "MsSQLEf",
            "Mock"});
            this.SQLSwitch.Location = new System.Drawing.Point(581, 352);
            this.SQLSwitch.Name = "SQLSwitch";
            this.SQLSwitch.Size = new System.Drawing.Size(132, 23);
            this.SQLSwitch.TabIndex = 13;
            this.SQLSwitch.SelectedIndexChanged += new System.EventHandler(this.SelectServer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 452);
            this.Controls.Add(this.SQLSwitch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.tb_lastname);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.dataGridBD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBD;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.TextBox tb_lastname;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SQLSwitch;
    }
}

