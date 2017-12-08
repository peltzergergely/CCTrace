namespace CCTrace
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.prodTbx = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.varnBtn = new System.Windows.Forms.Button();
            this.headerLbl = new System.Windows.Forms.Label();
            this.prodLbl = new System.Windows.Forms.Label();
            this.carrLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.carrTbx = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.outputMsgLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dailyProdLbl = new System.Windows.Forms.Label();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodTbx
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.prodTbx, 2);
            this.prodTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTbx.Location = new System.Drawing.Point(235, 246);
            this.prodTbx.Margin = new System.Windows.Forms.Padding(2);
            this.prodTbx.Name = "prodTbx";
            this.prodTbx.Size = new System.Drawing.Size(940, 60);
            this.prodTbx.TabIndex = 0;
            this.prodTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prodTbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.varnBtn, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.headerLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.prodLbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.carrLbl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.exitBtn, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.carrTbx, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.prodTbx, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.saveBtn, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.outputMsgLbl, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.outputLbl, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dailyProdLbl, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1477, 778);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // varnBtn
            // 
            this.varnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.varnBtn.BackColor = System.Drawing.Color.LightYellow;
            this.varnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.varnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varnBtn.Location = new System.Drawing.Point(1207, 530);
            this.varnBtn.Margin = new System.Windows.Forms.Padding(30, 32, 30, 32);
            this.varnBtn.Name = "varnBtn";
            this.varnBtn.Size = new System.Drawing.Size(208, 151);
            this.varnBtn.TabIndex = 11;
            this.varnBtn.TabStop = false;
            this.varnBtn.Text = "Lakk feltöltése";
            this.varnBtn.UseVisualStyleBackColor = false;
            this.varnBtn.Click += new System.EventHandler(this.VarnBtn_Click);
            // 
            // headerLbl
            // 
            this.headerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.headerLbl, 5);
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(22, 16);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(1453, 228);
            this.headerLbl.TabIndex = 0;
            this.headerLbl.Text = "Olvasd be a Termék majd a szállító keret vonalkódját";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodLbl
            // 
            this.prodLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.prodLbl.AutoSize = true;
            this.prodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodLbl.Location = new System.Drawing.Point(35, 249);
            this.prodLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prodLbl.Name = "prodLbl";
            this.prodLbl.Size = new System.Drawing.Size(196, 54);
            this.prodLbl.TabIndex = 7;
            this.prodLbl.Text = "Termék:";
            // 
            // carrLbl
            // 
            this.carrLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.carrLbl.AutoSize = true;
            this.carrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrLbl.Location = new System.Drawing.Point(83, 313);
            this.carrLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carrLbl.Name = "carrLbl";
            this.carrLbl.Size = new System.Drawing.Size(148, 54);
            this.carrLbl.TabIndex = 8;
            this.carrLbl.Text = "Keret:";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(22, 715);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(115, 45);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "Kilépés";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // carrTbx
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.carrTbx, 2);
            this.carrTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carrTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrTbx.Location = new System.Drawing.Point(235, 310);
            this.carrTbx.Margin = new System.Windows.Forms.Padding(2);
            this.carrTbx.Name = "carrTbx";
            this.carrTbx.Size = new System.Drawing.Size(940, 60);
            this.carrTbx.TabIndex = 1;
            this.carrTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.carrTbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(1328, 715);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(115, 45);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Mentés";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            this.saveBtn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // outputMsgLbl
            // 
            this.outputMsgLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputMsgLbl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.outputMsgLbl, 2);
            this.outputMsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMsgLbl.Location = new System.Drawing.Point(236, 558);
            this.outputMsgLbl.Name = "outputMsgLbl";
            this.outputMsgLbl.Size = new System.Drawing.Size(0, 54);
            this.outputMsgLbl.TabIndex = 10;
            // 
            // outputLbl
            // 
            this.outputLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.outputLbl.AutoSize = true;
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.Location = new System.Drawing.Point(23, 558);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(207, 54);
            this.outputLbl.TabIndex = 9;
            this.outputLbl.Text = "Kimenet:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(236, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(938, 80);
            this.dataGridView1.TabIndex = 12;
            // 
            // dailyProdLbl
            // 
            this.dailyProdLbl.AutoSize = true;
            this.dailyProdLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dailyProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyProdLbl.Location = new System.Drawing.Point(1180, 244);
            this.dailyProdLbl.Name = "dailyProdLbl";
            this.tableLayoutPanel1.SetRowSpan(this.dailyProdLbl, 2);
            this.dailyProdLbl.Size = new System.Drawing.Size(262, 128);
            this.dailyProdLbl.TabIndex = 13;
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.beállításokToolStripMenuItem.Text = "Adatbázis";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.adminToolStripMenuItem.Text = "Megnyitás";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.AdminToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beállításokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1477, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 802);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Termék1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prodTbx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.TextBox carrTbx;
        private System.Windows.Forms.Label prodLbl;
        private System.Windows.Forms.Label carrLbl;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Label outputMsgLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button varnBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label dailyProdLbl;
    }
}