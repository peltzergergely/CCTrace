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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpletableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cCDBDataSet = new CCTrace.CCDBDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.táblákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekérdezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simple_tableTableAdapter = new CCTrace.CCDBDataSetTableAdapters.simple_tableTableAdapter();
            this.ccdbDataSet1 = new CCTrace.CCDBDataSet();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpletableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccdbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 502F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.exitBtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 329F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1307, 493);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1131, 394);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(153, 55);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Kilépés";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adatbázis kapcsolat tesztelés";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Csatlakozás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(23, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1102, 323);
            this.dataGridView1.TabIndex = 6;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.táblákToolStripMenuItem,
            this.lekérdezésToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // táblákToolStripMenuItem
            // 
            this.táblákToolStripMenuItem.Name = "táblákToolStripMenuItem";
            this.táblákToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.táblákToolStripMenuItem.Text = "Táblák";
            // 
            // lekérdezésToolStripMenuItem
            // 
            this.lekérdezésToolStripMenuItem.Name = "lekérdezésToolStripMenuItem";
            this.lekérdezésToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.lekérdezésToolStripMenuItem.Text = "Lekérdezés";
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 521);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "AdminPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpletableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccdbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem táblákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekérdezésToolStripMenuItem;
        private CCDBDataSet cCDBDataSet;
        private System.Windows.Forms.BindingSource simpletableBindingSource;
        private CCDBDataSetTableAdapters.simple_tableTableAdapter simple_tableTableAdapter;
        private CCDBDataSet ccdbDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}