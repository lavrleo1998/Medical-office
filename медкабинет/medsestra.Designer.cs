namespace медкабинет
{
    partial class medsestra
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
            this.dataGridView_nazn = new System.Windows.Forms.DataGridView();
            this.comboBox_add = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_choice = new System.Windows.Forms.TextBox();
            this.batton_choice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nazn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_nazn
            // 
            this.dataGridView_nazn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nazn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_nazn.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_nazn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_nazn.Name = "dataGridView_nazn";
            this.dataGridView_nazn.Size = new System.Drawing.Size(732, 272);
            this.dataGridView_nazn.TabIndex = 0;
            // 
            // comboBox_add
            // 
            this.comboBox_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_add.FormattingEnabled = true;
            this.comboBox_add.Location = new System.Drawing.Point(307, 508);
            this.comboBox_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_add.Name = "comboBox_add";
            this.comboBox_add.Size = new System.Drawing.Size(217, 26);
            this.comboBox_add.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(535, 508);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(153, 65);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // textBox_choice
            // 
            this.textBox_choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_choice.Location = new System.Drawing.Point(307, 442);
            this.textBox_choice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_choice.Name = "textBox_choice";
            this.textBox_choice.Size = new System.Drawing.Size(217, 24);
            this.textBox_choice.TabIndex = 3;
            // 
            // batton_choice
            // 
            this.batton_choice.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.batton_choice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.batton_choice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.batton_choice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batton_choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.batton_choice.Location = new System.Drawing.Point(535, 439);
            this.batton_choice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.batton_choice.Name = "batton_choice";
            this.batton_choice.Size = new System.Drawing.Size(153, 60);
            this.batton_choice.TabIndex = 5;
            this.batton_choice.Text = "Добавить";
            this.batton_choice.UseVisualStyleBackColor = true;
            this.batton_choice.Click += new System.EventHandler(this.Batton_choice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 442);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Укажите номер записи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 508);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите заключение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 582);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Результат действия";
            // 
            // textBox_status
            // 
            this.textBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_status.Location = new System.Drawing.Point(303, 582);
            this.textBox_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(301, 24);
            this.textBox_status.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(535, 290);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 24);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(535, 324);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 55);
            this.button2.TabIndex = 12;
            this.button2.Text = "Загрузить назначения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 291);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(512, 130);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // medsestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(732, 629);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.batton_choice);
            this.Controls.Add(this.textBox_choice);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_add);
            this.Controls.Add(this.dataGridView_nazn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "medsestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "medsestra";
            this.Load += new System.EventHandler(this.Medsestra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nazn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView_nazn;
        private System.Windows.Forms.ComboBox comboBox_add;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_choice;
        private System.Windows.Forms.Button batton_choice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}