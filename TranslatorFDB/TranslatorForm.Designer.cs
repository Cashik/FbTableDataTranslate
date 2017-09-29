namespace TranslatorFDB
{
    partial class TranslatorForm
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
            this.StartDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnsCLB = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultDGV = new System.Windows.Forms.DataGridView();
            this.StartLangCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EndLangCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TranslateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TableNameTB = new System.Windows.Forms.TextBox();
            this.ChooseTableBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PkNameTB = new System.Windows.Forms.TextBox();
            this.MakeScriptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDGV
            // 
            this.StartDGV.AllowUserToAddRows = false;
            this.StartDGV.AllowUserToDeleteRows = false;
            this.StartDGV.AllowUserToResizeRows = false;
            this.StartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StartDGV.Location = new System.Drawing.Point(12, 229);
            this.StartDGV.Name = "StartDGV";
            this.StartDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.StartDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.StartDGV.Size = new System.Drawing.Size(470, 359);
            this.StartDGV.TabIndex = 0;
            this.StartDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите название таблицы:";
            // 
            // ColumnsCLB
            // 
            this.ColumnsCLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColumnsCLB.FormattingEnabled = true;
            this.ColumnsCLB.Location = new System.Drawing.Point(490, 42);
            this.ColumnsCLB.Name = "ColumnsCLB";
            this.ColumnsCLB.Size = new System.Drawing.Size(471, 92);
            this.ColumnsCLB.TabIndex = 3;
            this.ColumnsCLB.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ColumnsCLB_ItemCheck);
            this.ColumnsCLB.SelectedIndexChanged += new System.EventHandler(this.ColumnsCLB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(490, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите поля для для перевода:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ResultDGV
            // 
            this.ResultDGV.AllowUserToAddRows = false;
            this.ResultDGV.AllowUserToOrderColumns = true;
            this.ResultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDGV.Location = new System.Drawing.Point(490, 229);
            this.ResultDGV.Name = "ResultDGV";
            this.ResultDGV.Size = new System.Drawing.Size(472, 359);
            this.ResultDGV.TabIndex = 5;
            // 
            // StartLangCB
            // 
            this.StartLangCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartLangCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StartLangCB.Items.AddRange(new object[] {
            "auto",
            "uk",
            "ru",
            "en"});
            this.StartLangCB.Location = new System.Drawing.Point(119, 133);
            this.StartLangCB.Margin = new System.Windows.Forms.Padding(0);
            this.StartLangCB.Name = "StartLangCB";
            this.StartLangCB.Size = new System.Drawing.Size(153, 21);
            this.StartLangCB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(486, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Таблица после перевода:\r\n";
            // 
            // EndLangCB
            // 
            this.EndLangCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndLangCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.EndLangCB.Items.AddRange(new object[] {
            "uk",
            "ru",
            "en"});
            this.EndLangCB.Location = new System.Drawing.Point(321, 133);
            this.EndLangCB.Name = "EndLangCB";
            this.EndLangCB.Size = new System.Drawing.Size(161, 21);
            this.EndLangCB.TabIndex = 8;
            this.EndLangCB.SelectedIndexChanged += new System.EventHandler(this.EndLangCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Перевести с ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(284, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "на ";
            // 
            // TranslateBtn
            // 
            this.TranslateBtn.Enabled = false;
            this.TranslateBtn.Location = new System.Drawing.Point(321, 167);
            this.TranslateBtn.Name = "TranslateBtn";
            this.TranslateBtn.Size = new System.Drawing.Size(163, 23);
            this.TranslateBtn.TabIndex = 12;
            this.TranslateBtn.Text = "Перевести";
            this.TranslateBtn.UseVisualStyleBackColor = true;
            this.TranslateBtn.Click += new System.EventHandler(this.TranslateBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(12, 167);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(134, 23);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Сохранить результаты";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Таблица до перевода:\r\n";
            // 
            // TableNameTB
            // 
            this.TableNameTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TableNameTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TableNameTB.Location = new System.Drawing.Point(12, 42);
            this.TableNameTB.Name = "TableNameTB";
            this.TableNameTB.Size = new System.Drawing.Size(343, 20);
            this.TableNameTB.TabIndex = 1;
            this.TableNameTB.TextChanged += new System.EventHandler(this.TableNameTB_TextChanged);
            // 
            // ChooseTableBtn
            // 
            this.ChooseTableBtn.Location = new System.Drawing.Point(361, 40);
            this.ChooseTableBtn.Name = "ChooseTableBtn";
            this.ChooseTableBtn.Size = new System.Drawing.Size(121, 23);
            this.ChooseTableBtn.TabIndex = 15;
            this.ChooseTableBtn.Text = "Выбрать";
            this.ChooseTableBtn.UseVisualStyleBackColor = true;
            this.ChooseTableBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Первичный ключ таблицы:";
            // 
            // PkNameTB
            // 
            this.PkNameTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PkNameTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PkNameTB.Location = new System.Drawing.Point(12, 98);
            this.PkNameTB.Name = "PkNameTB";
            this.PkNameTB.Size = new System.Drawing.Size(470, 20);
            this.PkNameTB.TabIndex = 17;
            // 
            // MakeScriptBtn
            // 
            this.MakeScriptBtn.Location = new System.Drawing.Point(148, 167);
            this.MakeScriptBtn.Name = "MakeScriptBtn";
            this.MakeScriptBtn.Size = new System.Drawing.Size(167, 23);
            this.MakeScriptBtn.TabIndex = 18;
            this.MakeScriptBtn.Text = "Создать UPDATE скрипт";
            this.MakeScriptBtn.UseVisualStyleBackColor = true;
            this.MakeScriptBtn.Click += new System.EventHandler(this.MakeScriptBtn_Click);
            // 
            // TranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 600);
            this.Controls.Add(this.MakeScriptBtn);
            this.Controls.Add(this.PkNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChooseTableBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TranslateBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndLangCB);
            this.Controls.Add(this.StartLangCB);
            this.Controls.Add(this.ResultDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColumnsCLB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableNameTB);
            this.Controls.Add(this.StartDGV);
            this.Name = "TranslatorForm";
            this.Text = "TranslatorForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StartDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StartDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox ColumnsCLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ResultDGV;
        private System.Windows.Forms.ComboBox StartLangCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EndLangCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TranslateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TableNameTB;
        private System.Windows.Forms.Button ChooseTableBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PkNameTB;
        private System.Windows.Forms.Button MakeScriptBtn;
    }
}

