namespace медкабинет
{
    partial class ter_rasp
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
            this.dateTimePicker_jurnal = new System.Windows.Forms.DateTimePicker();
            this.button_open_jurnal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_enter_nazn = new System.Windows.Forms.TextBox();
            this.button_open_nazn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.dataGridView_nazn.Size = new System.Drawing.Size(732, 367);
            this.dataGridView_nazn.TabIndex = 0;
            // 
            // dateTimePicker_jurnal
            // 
            this.dateTimePicker_jurnal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_jurnal.CalendarTitleBackColor = System.Drawing.Color.Khaki;
            this.dateTimePicker_jurnal.Location = new System.Drawing.Point(13, 377);
            this.dateTimePicker_jurnal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_jurnal.Name = "dateTimePicker_jurnal";
            this.dateTimePicker_jurnal.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker_jurnal.TabIndex = 1;
            // 
            // button_open_jurnal
            // 
            this.button_open_jurnal.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.button_open_jurnal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_open_jurnal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_open_jurnal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open_jurnal.Location = new System.Drawing.Point(70, 413);
            this.button_open_jurnal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_open_jurnal.Name = "button_open_jurnal";
            this.button_open_jurnal.Size = new System.Drawing.Size(190, 35);
            this.button_open_jurnal.TabIndex = 2;
            this.button_open_jurnal.Text = "Загрузить расписание";
            this.button_open_jurnal.UseVisualStyleBackColor = true;
            this.button_open_jurnal.Click += new System.EventHandler(this.button_open_jurnal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 492);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Укажите номер выбираемого назначения";
            // 
            // textBox_enter_nazn
            // 
            this.textBox_enter_nazn.Location = new System.Drawing.Point(340, 486);
            this.textBox_enter_nazn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_enter_nazn.Name = "textBox_enter_nazn";
            this.textBox_enter_nazn.Size = new System.Drawing.Size(148, 26);
            this.textBox_enter_nazn.TabIndex = 4;
            // 
            // button_open_nazn
            // 
            this.button_open_nazn.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.button_open_nazn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_open_nazn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_open_nazn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open_nazn.Location = new System.Drawing.Point(496, 485);
            this.button_open_nazn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_open_nazn.Name = "button_open_nazn";
            this.button_open_nazn.Size = new System.Drawing.Size(191, 35);
            this.button_open_nazn.TabIndex = 5;
            this.button_open_nazn.Text = "Загрузить назначение";
            this.button_open_nazn.UseVisualStyleBackColor = true;
            this.button_open_nazn.Click += new System.EventHandler(this.button_open_nazn_Click);
            // 
            // ter_rasp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(732, 550);
            this.ControlBox = false;
            this.Controls.Add(this.button_open_nazn);
            this.Controls.Add(this.textBox_enter_nazn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_open_jurnal);
            this.Controls.Add(this.dateTimePicker_jurnal);
            this.Controls.Add(this.dataGridView_nazn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ter_rasp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ter_rasp";
            this.Load += new System.EventHandler(this.ter_rasp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nazn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_nazn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_jurnal;
        private System.Windows.Forms.Button button_open_jurnal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_enter_nazn;
        private System.Windows.Forms.Button button_open_nazn;
    }
}