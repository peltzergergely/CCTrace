namespace CCTrace
{
    partial class form4
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.batchLbl = new System.Windows.Forms.Label();
            this.expLbl = new System.Windows.Forms.Label();
            this.outputLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.prodTbx = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.outputMsgLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.63636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.headerLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.batchLbl, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.expLbl, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.outputLbl, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.exitBtn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.prodTbx, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.saveBtn, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.outputMsgLbl, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1285, 594);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // headerLbl
            // 
            this.headerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.headerLbl, 7);
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.Location = new System.Drawing.Point(22, 16);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(1261, 228);
            this.headerLbl.TabIndex = 0;
            this.headerLbl.Text = "Írd be a LAKK batch számát és lejárati dátumát!";
            this.headerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // batchLbl
            // 
            this.batchLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.batchLbl.AutoSize = true;
            this.batchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchLbl.Location = new System.Drawing.Point(356, 249);
            this.batchLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.batchLbl.Name = "batchLbl";
            this.batchLbl.Size = new System.Drawing.Size(143, 54);
            this.batchLbl.TabIndex = 7;
            this.batchLbl.Text = "Batch";
            // 
            // expLbl
            // 
            this.expLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.expLbl.AutoSize = true;
            this.expLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expLbl.Location = new System.Drawing.Point(333, 314);
            this.expLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.expLbl.Name = "expLbl";
            this.expLbl.Size = new System.Drawing.Size(166, 54);
            this.expLbl.TabIndex = 8;
            this.expLbl.Text = "Lejárat";
            // 
            // outputLbl
            // 
            this.outputLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.outputLbl.AutoSize = true;
            this.outputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLbl.Location = new System.Drawing.Point(291, 424);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(207, 54);
            this.outputLbl.TabIndex = 9;
            this.outputLbl.Text = "Kimenet:";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(22, 531);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(115, 45);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.TabStop = false;
            this.exitBtn.Text = "Kilépés";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // prodTbx
            // 
            this.prodTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTbx.Location = new System.Drawing.Point(503, 246);
            this.prodTbx.Margin = new System.Windows.Forms.Padding(2);
            this.prodTbx.Name = "prodTbx";
            this.prodTbx.Size = new System.Drawing.Size(372, 60);
            this.prodTbx.TabIndex = 0;
            this.prodTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prodTbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(1142, 531);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(115, 45);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Mentés";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // outputMsgLbl
            // 
            this.outputMsgLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputMsgLbl.AutoSize = true;
            this.outputMsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMsgLbl.Location = new System.Drawing.Point(504, 424);
            this.outputMsgLbl.Name = "outputMsgLbl";
            this.outputMsgLbl.Size = new System.Drawing.Size(288, 54);
            this.outputMsgLbl.TabIndex = 10;
            this.outputMsgLbl.Text = "EREDMÉNY";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(504, 311);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 60);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
            // 
            // form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 594);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form4";
            this.Text = "Lakk anyag felvitel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form4_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Label batchLbl;
        private System.Windows.Forms.Label expLbl;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox prodTbx;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label outputMsgLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}