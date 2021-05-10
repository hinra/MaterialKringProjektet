namespace Class2Table {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.kundIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaNamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktNamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.omsattningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kunderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_getOne = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kunderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kundIDDataGridViewTextBoxColumn,
            this.firmaNamnDataGridViewTextBoxColumn,
            this.kontaktNamnDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.omsattningDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kunderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 283);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(443, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hämta data och fyll datagrid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kunduppgifter: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(545, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(105, 30);
            this.listBox1.TabIndex = 6;
            // 
            // kundIDDataGridViewTextBoxColumn
            // 
            this.kundIDDataGridViewTextBoxColumn.DataPropertyName = "Kund_ID";
            this.kundIDDataGridViewTextBoxColumn.HeaderText = "Kund_ID";
            this.kundIDDataGridViewTextBoxColumn.Name = "kundIDDataGridViewTextBoxColumn";
            this.kundIDDataGridViewTextBoxColumn.Width = 74;
            // 
            // firmaNamnDataGridViewTextBoxColumn
            // 
            this.firmaNamnDataGridViewTextBoxColumn.DataPropertyName = "FirmaNamn";
            this.firmaNamnDataGridViewTextBoxColumn.HeaderText = "FirmaNamn";
            this.firmaNamnDataGridViewTextBoxColumn.Name = "firmaNamnDataGridViewTextBoxColumn";
            this.firmaNamnDataGridViewTextBoxColumn.Width = 85;
            // 
            // kontaktNamnDataGridViewTextBoxColumn
            // 
            this.kontaktNamnDataGridViewTextBoxColumn.DataPropertyName = "KontaktNamn";
            this.kontaktNamnDataGridViewTextBoxColumn.HeaderText = "KontaktNamn";
            this.kontaktNamnDataGridViewTextBoxColumn.Name = "kontaktNamnDataGridViewTextBoxColumn";
            this.kontaktNamnDataGridViewTextBoxColumn.Width = 97;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.Width = 49;
            // 
            // omsattningDataGridViewTextBoxColumn
            // 
            this.omsattningDataGridViewTextBoxColumn.DataPropertyName = "Omsattning";
            this.omsattningDataGridViewTextBoxColumn.HeaderText = "Omsattning";
            this.omsattningDataGridViewTextBoxColumn.Name = "omsattningDataGridViewTextBoxColumn";
            this.omsattningDataGridViewTextBoxColumn.Width = 85;
            // 
            // kunderBindingSource
            // 
            this.kunderBindingSource.DataSource = typeof(Class2Table.Kunder);
            // 
            // btn_getOne
            // 
            this.btn_getOne.Location = new System.Drawing.Point(545, 86);
            this.btn_getOne.Name = "btn_getOne";
            this.btn_getOne.Size = new System.Drawing.Size(200, 23);
            this.btn_getOne.TabIndex = 3;
            this.btn_getOne.Text = "Hämta en kund";
            this.btn_getOne.UseVisualStyleBackColor = true;
            this.btn_getOne.Click += new System.EventHandler(this.btn_getOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 415);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_getOne);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kunderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaNamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktNamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn omsattningDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kunderBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_getOne;
    }
}

