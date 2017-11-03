namespace CCTrace
{
    partial class Form3
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.termék1 = new System.Windows.Forms.Button();
            this.lakk = new System.Windows.Forms.Button();
            this.queryBx = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.simpletableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cCDBDataSet = new CCTrace.CCDBDataSet();
            this.simple_tableTableAdapter = new CCTrace.CCDBDataSetTableAdapters.simple_tableTableAdapter();
            this.ccdbDataSet1 = new CCTrace.CCDBDataSet();
            this.cCDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cCDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.volvo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpletableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.termék1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lakk, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.queryBx, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.exitBtn, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.volvo, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 6);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(947, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adatbázis kapcsolat tesztelés";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 6);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(22, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 349);
            this.dataGridView1.TabIndex = 6;
            // 
            // termék1
            // 
            this.termék1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termék1.Location = new System.Drawing.Point(23, 54);
            this.termék1.Name = "termék1";
            this.termék1.Size = new System.Drawing.Size(75, 27);
            this.termék1.TabIndex = 7;
            this.termék1.Text = "BMW";
            this.termék1.UseVisualStyleBackColor = true;
            this.termék1.Click += new System.EventHandler(this.termék1_Click);
            // 
            // lakk
            // 
            this.lakk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lakk.Location = new System.Drawing.Point(185, 54);
            this.lakk.Name = "lakk";
            this.lakk.Size = new System.Drawing.Size(75, 27);
            this.lakk.TabIndex = 8;
            this.lakk.Text = "Lakk";
            this.lakk.UseVisualStyleBackColor = true;
            this.lakk.Click += new System.EventHandler(this.lakk_Click);
            // 
            // queryBx
            // 
            this.queryBx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryBx.Location = new System.Drawing.Point(266, 54);
            this.queryBx.Name = "queryBx";
            this.queryBx.Size = new System.Drawing.Size(288, 23);
            this.queryBx.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Termék1",
            "Termék1 Keret",
            "Lakk?"});
            this.comboBox1.Location = new System.Drawing.Point(266, 440);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Keresés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(854, 439);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(115, 45);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Kilépés";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // simpletableBindingSource
            // 
            this.simpletableBindingSource.DataMember = "simple_table";
            this.simpletableBindingSource.DataSource = this.cCDBDataSet;
            // 
            // cCDBDataSet
            // 
            this.cCDBDataSet.DataSetName = "CCDBDataSet";
            this.cCDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simple_tableTableAdapter
            // 
            this.simple_tableTableAdapter.ClearBeforeFill = true;
            // 
            // ccdbDataSet1
            // 
            this.ccdbDataSet1.DataSetName = "CCDBDataSet";
            this.ccdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cCDBDataSetBindingSource
            // 
            this.cCDBDataSetBindingSource.DataSource = this.cCDBDataSet;
            this.cCDBDataSetBindingSource.Position = 0;
            // 
            // cCDBDataSetBindingSource1
            // 
            this.cCDBDataSetBindingSource1.DataSource = this.cCDBDataSet;
            this.cCDBDataSetBindingSource1.Position = 0;
            // 
            // volvo
            // 
            this.volvo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volvo.Location = new System.Drawing.Point(104, 54);
            this.volvo.Name = "volvo";
            this.volvo.Size = new System.Drawing.Size(75, 27);
            this.volvo.TabIndex = 11;
            this.volvo.Text = "Volvo";
            this.volvo.UseVisualStyleBackColor = true;
            this.volvo.Click += new System.EventHandler(this.volvo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpletableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private CCDBDataSet cCDBDataSet;
        private System.Windows.Forms.BindingSource simpletableBindingSource;
        private CCDBDataSetTableAdapters.simple_tableTableAdapter simple_tableTableAdapter;
        private CCDBDataSet ccdbDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button termék1;
        private System.Windows.Forms.Button lakk;
        private System.Windows.Forms.TextBox queryBx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cCDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource cCDBDataSetBindingSource;
        private System.Windows.Forms.Button volvo;
    }
}