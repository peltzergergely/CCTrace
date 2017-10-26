namespace CCTrace
{
    partial class MainScr
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.prodBtn = new System.Windows.Forms.Button();
            this.varnBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segítségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1155, 521);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(153, 55);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Kilépés";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CausesValidation = false;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.425617F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.22149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.35289F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.exitBtn, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.headerLbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.prodBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.varnBtn, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77779F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1333, 600);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // headerLbl
            // 
            this.headerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.headerLbl, 2);
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(42, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(1107, 115);
            this.headerLbl.TabIndex = 4;
            this.headerLbl.Text = "Kattints a megfelelő gombra az adatok feltöltéséhez!";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerLbl.UseMnemonic = false;
            // 
            // prodBtn
            // 
            this.prodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodBtn.Location = new System.Drawing.Point(96, 155);
            this.prodBtn.Margin = new System.Windows.Forms.Padding(40);
            this.prodBtn.Name = "prodBtn";
            this.prodBtn.Size = new System.Drawing.Size(447, 323);
            this.prodBtn.TabIndex = 5;
            this.prodBtn.Text = "Termék";
            this.prodBtn.UseVisualStyleBackColor = true;
            this.prodBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // varnBtn
            // 
            this.varnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varnBtn.Location = new System.Drawing.Point(623, 155);
            this.varnBtn.Margin = new System.Windows.Forms.Padding(40);
            this.varnBtn.Name = "varnBtn";
            this.varnBtn.Size = new System.Drawing.Size(447, 323);
            this.varnBtn.TabIndex = 6;
            this.varnBtn.Text = "Lakk";
            this.varnBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beállításokToolStripMenuItem,
            this.segítségToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminPageToolStripMenuItem});
            this.beállításokToolStripMenuItem.Name = "beállításokToolStripMenuItem";
            this.beállításokToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.beállításokToolStripMenuItem.Text = "Beállítások";
            // 
            // segítségToolStripMenuItem
            // 
            this.segítségToolStripMenuItem.Name = "segítségToolStripMenuItem";
            this.segítségToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.segítségToolStripMenuItem.Text = "Segítség";
            // 
            // adminPageToolStripMenuItem
            // 
            this.adminPageToolStripMenuItem.Name = "adminPageToolStripMenuItem";
            this.adminPageToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.adminPageToolStripMenuItem.Text = "AdminPage";
            this.adminPageToolStripMenuItem.Click += new System.EventHandler(this.adminPageToolStripMenuItem_Click);
            // 
            // MainScr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 628);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "MainScr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főmenü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScr_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Button prodBtn;
        private System.Windows.Forms.Button varnBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segítségToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminPageToolStripMenuItem;
    }
}

