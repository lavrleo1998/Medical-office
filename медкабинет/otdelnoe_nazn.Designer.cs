namespace медкабинет
{
    partial class otdelnoe_nazn
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
            this.button_go_back = new System.Windows.Forms.Button();
            this.richTextBox_otd_and_istoriya = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_open_result_nazn = new System.Windows.Forms.TextBox();
            this.button_open_result_nazn = new System.Windows.Forms.Button();
            this.richTextBox_nazn = new System.Windows.Forms.RichTextBox();
            this.textBox_zaklychenie = new System.Windows.Forms.TextBox();
            this.button_add_zaklychenie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_vse_naznacheniya = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_go_back
            // 
            this.button_go_back.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.button_go_back.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.button_go_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_go_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_go_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_go_back.Location = new System.Drawing.Point(7, 7);
            this.button_go_back.Margin = new System.Windows.Forms.Padding(4);
            this.button_go_back.Name = "button_go_back";
            this.button_go_back.Size = new System.Drawing.Size(96, 66);
            this.button_go_back.TabIndex = 0;
            this.button_go_back.Text = "Вернуться к списку всех назначений ";
            this.button_go_back.UseVisualStyleBackColor = true;
            this.button_go_back.Click += new System.EventHandler(this.button_go_back_Click);
            // 
            // richTextBox_otd_and_istoriya
            // 
            this.richTextBox_otd_and_istoriya.Location = new System.Drawing.Point(110, 31);
            this.richTextBox_otd_and_istoriya.Name = "richTextBox_otd_and_istoriya";
            this.richTextBox_otd_and_istoriya.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_otd_and_istoriya.Size = new System.Drawing.Size(257, 269);
            this.richTextBox_otd_and_istoriya.TabIndex = 1;
            this.richTextBox_otd_and_istoriya.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(169, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "История болезни";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(80, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список всех назначений отдыхающего";
            // 
            // textBox_open_result_nazn
            // 
            this.textBox_open_result_nazn.Location = new System.Drawing.Point(110, 652);
            this.textBox_open_result_nazn.Name = "textBox_open_result_nazn";
            this.textBox_open_result_nazn.Size = new System.Drawing.Size(240, 22);
            this.textBox_open_result_nazn.TabIndex = 5;
            // 
            // button_open_result_nazn
            // 
            this.button_open_result_nazn.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.button_open_result_nazn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.button_open_result_nazn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_open_result_nazn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_open_result_nazn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open_result_nazn.Location = new System.Drawing.Point(137, 699);
            this.button_open_result_nazn.Name = "button_open_result_nazn";
            this.button_open_result_nazn.Size = new System.Drawing.Size(151, 48);
            this.button_open_result_nazn.TabIndex = 6;
            this.button_open_result_nazn.Text = "Посмотреть назначение";
            this.button_open_result_nazn.UseVisualStyleBackColor = true;
            this.button_open_result_nazn.Click += new System.EventHandler(this.button_open_result_nazn_Click);
            // 
            // richTextBox_nazn
            // 
            this.richTextBox_nazn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_nazn.Location = new System.Drawing.Point(386, 31);
            this.richTextBox_nazn.Name = "richTextBox_nazn";
            this.richTextBox_nazn.Size = new System.Drawing.Size(946, 96);
            this.richTextBox_nazn.TabIndex = 8;
            this.richTextBox_nazn.Text = "";
            // 
            // textBox_zaklychenie
            // 
            this.textBox_zaklychenie.Location = new System.Drawing.Point(386, 154);
            this.textBox_zaklychenie.Multiline = true;
            this.textBox_zaklychenie.Name = "textBox_zaklychenie";
            this.textBox_zaklychenie.Size = new System.Drawing.Size(946, 512);
            this.textBox_zaklychenie.TabIndex = 9;
            // 
            // button_add_zaklychenie
            // 
            this.button_add_zaklychenie.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.button_add_zaklychenie.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.button_add_zaklychenie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button_add_zaklychenie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_add_zaklychenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_zaklychenie.Location = new System.Drawing.Point(768, 672);
            this.button_add_zaklychenie.Name = "button_add_zaklychenie";
            this.button_add_zaklychenie.Size = new System.Drawing.Size(195, 73);
            this.button_add_zaklychenie.TabIndex = 10;
            this.button_add_zaklychenie.Text = "Добавить заключение";
            this.button_add_zaklychenie.UseVisualStyleBackColor = true;
            this.button_add_zaklychenie.Click += new System.EventHandler(this.button_add_zaklychenie_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(782, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Назначение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(782, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Заключение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(80, 627);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Укажите номер выбраного назначения";
            // 
            // richTextBox_vse_naznacheniya
            // 
            this.richTextBox_vse_naznacheniya.Location = new System.Drawing.Point(110, 355);
            this.richTextBox_vse_naznacheniya.Name = "richTextBox_vse_naznacheniya";
            this.richTextBox_vse_naznacheniya.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_vse_naznacheniya.Size = new System.Drawing.Size(257, 269);
            this.richTextBox_vse_naznacheniya.TabIndex = 14;
            this.richTextBox_vse_naznacheniya.Text = "";
            // 
            // otdelnoe_nazn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1340, 757);
            this.ControlBox = false;
            this.Controls.Add(this.richTextBox_vse_naznacheniya);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_add_zaklychenie);
            this.Controls.Add(this.textBox_zaklychenie);
            this.Controls.Add(this.richTextBox_nazn);
            this.Controls.Add(this.button_open_result_nazn);
            this.Controls.Add(this.textBox_open_result_nazn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_otd_and_istoriya);
            this.Controls.Add(this.button_go_back);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "otdelnoe_nazn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "otdelnoe_nazn";
            this.Load += new System.EventHandler(this.otdelnoe_nazn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_go_back;
        private System.Windows.Forms.RichTextBox richTextBox_otd_and_istoriya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_open_result_nazn;
        private System.Windows.Forms.Button button_open_result_nazn;
        private System.Windows.Forms.RichTextBox richTextBox_nazn;
        private System.Windows.Forms.TextBox textBox_zaklychenie;
        private System.Windows.Forms.Button button_add_zaklychenie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_vse_naznacheniya;
    }
}