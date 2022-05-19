﻿
namespace Praktik_UI
{
    partial class Suppliers
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
            this.SuppliersGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.nomer1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buy = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SuppliersGrid
            // 
            this.SuppliersGrid.AllowUserToAddRows = false;
            this.SuppliersGrid.AllowUserToDeleteRows = false;
            this.SuppliersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppliersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomer1Col,
            this.id,
            this.nameCol,
            this.amountCol,
            this.priceCol});
            this.SuppliersGrid.Location = new System.Drawing.Point(1, 12);
            this.SuppliersGrid.Name = "SuppliersGrid";
            this.SuppliersGrid.ReadOnly = true;
            this.SuppliersGrid.RowHeadersWidth = 51;
            this.SuppliersGrid.RowTemplate.Height = 24;
            this.SuppliersGrid.Size = new System.Drawing.Size(607, 426);
            this.SuppliersGrid.TabIndex = 0;
            this.SuppliersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SuppliersGrid_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(639, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Загрузка из файла";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(639, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранение в файл";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(639, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавление запчасти";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(639, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nomer1Col
            // 
            this.nomer1Col.HeaderText = "№";
            this.nomer1Col.Name = "nomer1Col";
            this.nomer1Col.ReadOnly = true;
            this.nomer1Col.Width = 30;
            // 
            // id
            // 
            this.id.HeaderText = "Артикул";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Название";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Width = 125;
            // 
            // amountCol
            // 
            this.amountCol.HeaderText = "Количество";
            this.amountCol.MinimumWidth = 6;
            this.amountCol.Name = "amountCol";
            this.amountCol.ReadOnly = true;
            this.amountCol.Width = 125;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Цена";
            this.priceCol.MinimumWidth = 6;
            this.priceCol.Name = "priceCol";
            this.priceCol.ReadOnly = true;
            this.priceCol.Width = 125;
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buy.Location = new System.Drawing.Point(639, 204);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(149, 42);
            this.buy.TabIndex = 5;
            this.buy.Text = "Купить";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buy1_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DimGray;
            this.back.ForeColor = System.Drawing.Color.AliceBlue;
            this.back.Location = new System.Drawing.Point(639, 348);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(149, 42);
            this.back.TabIndex = 6;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DimGray;
            this.exit.ForeColor = System.Drawing.Color.AliceBlue;
            this.exit.Location = new System.Drawing.Point(639, 396);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(149, 42);
            this.exit.TabIndex = 7;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.delete.Location = new System.Drawing.Point(639, 252);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(149, 42);
            this.delete.TabIndex = 8;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SuppliersGrid);
            this.Name = "Suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoDoc";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SuppliersGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomer1Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button delete;
    }
}