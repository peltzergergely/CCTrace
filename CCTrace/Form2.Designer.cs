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
            this.prodTbx = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.headerLbl = new System.Windows.Forms.Label();
            this.carrTbx = new System.Windows.Forms.TextBox();
            this.prodLbl = new System.Windows.Forms.Label();
            this.carrLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beállításokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segítségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodTbx
            // 
            this.prodTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTbx.Location = new System.Drawing.Point(334, 201);
            this.prodTbx.Name = "prodTbx";
            this.prodTbx.Size = new System.Drawing.Size(562, 74);
            this.prodTbx.TabIndex = 0;
            this.prodTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prodTbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.prodTbx_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.67506F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.32494F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.exitBtn, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.prodTbx, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.headerLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.carrTbx, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.prodLbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.carrLbl, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.47887F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1320, 633);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(1140, 555);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(153, 55);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Kilépés";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // headerLbl
            // 
            this.headerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.headerLbl, 4);
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(23, 20);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(1270, 178);
            this.headerLbl.TabIndex = 0;
            this.headerLbl.Text = "Olvasd be a Termék majd a szállító keret vonalkódját";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carrTbx
            // 
            this.carrTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carrTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrTbx.Location = new System.Drawing.Point(334, 281);
            this.carrTbx.Name = "carrTbx";
            this.carrTbx.Size = new System.Drawing.Size(562, 74);
            this.carrTbx.TabIndex = 1;
            this.carrTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prodLbl
            // 
            this.prodLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.prodLbl.AutoSize = true;
            this.prodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodLbl.Location = new System.Drawing.Point(82, 204);
            this.prodLbl.Name = "prodLbl";
            this.prodLbl.Size = new System.Drawing.Size(246, 67);
            this.prodLbl.TabIndex = 7;
            this.prodLbl.Text = "Termék:";
            // 
            // carrLbl
            // 
            this.carrLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.carrLbl.AutoSize = true;
            this.carrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrLbl.Location = new System.Drawing.Point(142, 284);
            this.carrLbl.Name = "carrLbl";
            this.carrLbl.Size = new System.Drawing.Size(186, 67);
            this.carrLbl.TabIndex = 8;
            this.carrLbl.Text = "Keret:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beállításokToolStripMenuItem,
            this.segítségToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1320, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beállításokToolStripMenuItem
            // 
            this.beállításokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
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
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.adminToolStripMenuItem.Text = "AdminPage";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Termék1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beállításokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segítségToolStripMenuItem;
    }
}