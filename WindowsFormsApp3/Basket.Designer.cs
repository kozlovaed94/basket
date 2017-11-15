namespace WindowsFormsApp3
{
    partial class BasketOfGoods
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasketOfGoods));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Del = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.Discount = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BasketDiscount = new System.Windows.Forms.Button();
            this.CouponeBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cheque = new System.Windows.Forms.Button();
            this.BasketCostBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.More = new System.Windows.Forms.Button();
            this.Less = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Change = new System.Windows.Forms.Button();
            this.ChangeNumber = new System.Windows.Forms.Button();
            this.ChangeNumBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BasketDiscountBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(15, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(738, 263);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.NumBox);
            this.groupBox1.Controls.Add(this.CostBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(280, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить товар";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Coral;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.ForeColor = System.Drawing.SystemColors.Window;
            this.Add.Location = new System.Drawing.Point(136, 96);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(127, 29);
            this.Add.TabIndex = 6;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // NumBox
            // 
            this.NumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumBox.Location = new System.Drawing.Point(136, 71);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(127, 24);
            this.NumBox.TabIndex = 5;
            this.NumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numerous_KeyPress);
            // 
            // CostBox
            // 
            this.CostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostBox.Location = new System.Drawing.Point(136, 48);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(127, 24);
            this.CostBox.TabIndex = 4;
            this.CostBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numerous_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(136, 24);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(127, 24);
            this.NameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // Del
            // 
            this.Del.BackColor = System.Drawing.Color.Coral;
            this.Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del.ForeColor = System.Drawing.SystemColors.Window;
            this.Del.Location = new System.Drawing.Point(14, 474);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(86, 29);
            this.Del.TabIndex = 7;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = false;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Redo
            // 
            this.Redo.BackColor = System.Drawing.Color.Coral;
            this.Redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Redo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Redo.ForeColor = System.Drawing.SystemColors.Window;
            this.Redo.Location = new System.Drawing.Point(77, 10);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(55, 29);
            this.Redo.TabIndex = 8;
            this.Redo.Text = "Redo";
            this.Redo.UseVisualStyleBackColor = false;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // Undo
            // 
            this.Undo.BackColor = System.Drawing.Color.Coral;
            this.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Undo.ForeColor = System.Drawing.SystemColors.Window;
            this.Undo.Location = new System.Drawing.Point(14, 10);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(57, 29);
            this.Undo.TabIndex = 9;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = false;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Discount
            // 
            this.Discount.BackColor = System.Drawing.Color.Coral;
            this.Discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discount.ForeColor = System.Drawing.SystemColors.Window;
            this.Discount.Location = new System.Drawing.Point(10, 69);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(173, 29);
            this.Discount.TabIndex = 10;
            this.Discount.Text = "Применить к товару";
            this.Discount.UseVisualStyleBackColor = false;
            this.Discount.Click += new System.EventHandler(this.Discount_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BasketDiscount);
            this.groupBox2.Controls.Add(this.Discount);
            this.groupBox2.Controls.Add(this.CouponeBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(556, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(196, 133);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Купон";
            // 
            // BasketDiscount
            // 
            this.BasketDiscount.BackColor = System.Drawing.Color.Coral;
            this.BasketDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BasketDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BasketDiscount.ForeColor = System.Drawing.SystemColors.Window;
            this.BasketDiscount.Location = new System.Drawing.Point(10, 98);
            this.BasketDiscount.Name = "BasketDiscount";
            this.BasketDiscount.Size = new System.Drawing.Size(173, 29);
            this.BasketDiscount.TabIndex = 11;
            this.BasketDiscount.Text = " Применить к корзине";
            this.BasketDiscount.UseVisualStyleBackColor = false;
            this.BasketDiscount.Click += new System.EventHandler(this.BasketDiscount_Click);
            // 
            // CouponeBox
            // 
            this.CouponeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CouponeBox.Location = new System.Drawing.Point(31, 33);
            this.CouponeBox.Name = "CouponeBox";
            this.CouponeBox.Size = new System.Drawing.Size(45, 24);
            this.CouponeBox.TabIndex = 7;
            this.CouponeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numerous_KeyPress);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 41);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cheque
            // 
            this.Cheque.BackColor = System.Drawing.Color.Coral;
            this.Cheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cheque.ForeColor = System.Drawing.SystemColors.Window;
            this.Cheque.Location = new System.Drawing.Point(159, 10);
            this.Cheque.Name = "Cheque";
            this.Cheque.Size = new System.Drawing.Size(118, 29);
            this.Cheque.TabIndex = 12;
            this.Cheque.Text = "Печать чека";
            this.Cheque.UseVisualStyleBackColor = false;
            this.Cheque.Click += new System.EventHandler(this.Cheque_Click);
            // 
            // BasketCostBox
            // 
            this.BasketCostBox.BackColor = System.Drawing.Color.Coral;
            this.BasketCostBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BasketCostBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BasketCostBox.ForeColor = System.Drawing.SystemColors.Window;
            this.BasketCostBox.Location = new System.Drawing.Point(62, 11);
            this.BasketCostBox.Multiline = true;
            this.BasketCostBox.Name = "BasketCostBox";
            this.BasketCostBox.ReadOnly = true;
            this.BasketCostBox.Size = new System.Drawing.Size(63, 29);
            this.BasketCostBox.TabIndex = 13;
            this.BasketCostBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BasketCostBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(620, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 44);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Итог";
            // 
            // More
            // 
            this.More.BackColor = System.Drawing.Color.Coral;
            this.More.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.More.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.More.ForeColor = System.Drawing.SystemColors.Window;
            this.More.Location = new System.Drawing.Point(117, 56);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(40, 34);
            this.More.TabIndex = 15;
            this.More.Text = ">";
            this.More.UseVisualStyleBackColor = false;
            this.More.Click += new System.EventHandler(this.ChangeNumber_Click);
            // 
            // Less
            // 
            this.Less.BackColor = System.Drawing.Color.Coral;
            this.Less.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Less.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Less.ForeColor = System.Drawing.SystemColors.Window;
            this.Less.Location = new System.Drawing.Point(14, 56);
            this.Less.Name = "Less";
            this.Less.Size = new System.Drawing.Size(39, 34);
            this.Less.TabIndex = 16;
            this.Less.Text = "<";
            this.Less.UseVisualStyleBackColor = false;
            this.Less.Click += new System.EventHandler(this.ChangeNumber_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Change);
            this.groupBox4.Controls.Add(this.ChangeNumber);
            this.groupBox4.Controls.Add(this.ChangeNumBox);
            this.groupBox4.Controls.Add(this.More);
            this.groupBox4.Controls.Add(this.Less);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(339, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(166, 135);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Количество";
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.Coral;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.ForeColor = System.Drawing.SystemColors.Window;
            this.Change.Location = new System.Drawing.Point(14, 24);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(143, 29);
            this.Change.TabIndex = 17;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // ChangeNumber
            // 
            this.ChangeNumber.BackColor = System.Drawing.Color.Coral;
            this.ChangeNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.ChangeNumber.Location = new System.Drawing.Point(14, 93);
            this.ChangeNumber.Name = "ChangeNumber";
            this.ChangeNumber.Size = new System.Drawing.Size(143, 29);
            this.ChangeNumber.TabIndex = 7;
            this.ChangeNumber.Text = "Применить";
            this.ChangeNumber.UseVisualStyleBackColor = false;
            this.ChangeNumber.Click += new System.EventHandler(this.ChangeNumber_Click_1);
            // 
            // ChangeNumBox
            // 
            this.ChangeNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeNumBox.Location = new System.Drawing.Point(59, 61);
            this.ChangeNumBox.Multiline = true;
            this.ChangeNumBox.Name = "ChangeNumBox";
            this.ChangeNumBox.ReadOnly = true;
            this.ChangeNumBox.Size = new System.Drawing.Size(52, 24);
            this.ChangeNumBox.TabIndex = 4;
            this.ChangeNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BasketDiscountBox);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(464, 464);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(150, 44);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Скидка";
            // 
            // BasketDiscountBox
            // 
            this.BasketDiscountBox.BackColor = System.Drawing.Color.Coral;
            this.BasketDiscountBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BasketDiscountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BasketDiscountBox.ForeColor = System.Drawing.SystemColors.Window;
            this.BasketDiscountBox.Location = new System.Drawing.Point(81, 11);
            this.BasketDiscountBox.Multiline = true;
            this.BasketDiscountBox.Name = "BasketDiscountBox";
            this.BasketDiscountBox.ReadOnly = true;
            this.BasketDiscountBox.Size = new System.Drawing.Size(63, 29);
            this.BasketDiscountBox.TabIndex = 13;
            this.BasketDiscountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Наименование";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Скидка";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Стоимость";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // BasketOfGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 515);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Cheque);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BasketOfGoods";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Корзина товаров";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Discount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CouponeBox;
        private System.Windows.Forms.Button Cheque;
        private System.Windows.Forms.TextBox BasketCostBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button More;
        private System.Windows.Forms.Button Less;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ChangeNumber;
        private System.Windows.Forms.TextBox ChangeNumBox;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button BasketDiscount;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox BasketDiscountBox;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

