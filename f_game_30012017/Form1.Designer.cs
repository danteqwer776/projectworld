namespace f_game_30012017
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_map = new System.Windows.Forms.DataGridView();
            this.button_create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_meth = new System.Windows.Forms.GroupBox();
            this.button_add_dinam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_cow = new System.Windows.Forms.Label();
            this.label_wf = new System.Windows.Forms.Label();
            this.label_wtr = new System.Windows.Forms.Label();
            this.label_grs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_map)).BeginInit();
            this.groupBox_meth.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_map
            // 
            this.dataGridView_map.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_map.Location = new System.Drawing.Point(238, 22);
            this.dataGridView_map.Name = "dataGridView_map";
            this.dataGridView_map.Size = new System.Drawing.Size(300, 272);
            this.dataGridView_map.TabIndex = 0;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(15, 21);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(121, 23);
            this.button_create.TabIndex = 1;
            this.button_create.Text = "создать мир";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "кол-во grass";
            // 
            // groupBox_meth
            // 
            this.groupBox_meth.Controls.Add(this.button_add_dinam);
            this.groupBox_meth.Controls.Add(this.button_create);
            this.groupBox_meth.Location = new System.Drawing.Point(12, 22);
            this.groupBox_meth.Name = "groupBox_meth";
            this.groupBox_meth.Size = new System.Drawing.Size(196, 272);
            this.groupBox_meth.TabIndex = 4;
            this.groupBox_meth.TabStop = false;
            this.groupBox_meth.Text = "действия";
            // 
            // button_add_dinam
            // 
            this.button_add_dinam.Location = new System.Drawing.Point(15, 58);
            this.button_add_dinam.Name = "button_add_dinam";
            this.button_add_dinam.Size = new System.Drawing.Size(121, 23);
            this.button_add_dinam.TabIndex = 2;
            this.button_add_dinam.Text = "добавить животных";
            this.button_add_dinam.UseVisualStyleBackColor = true;
            this.button_add_dinam.Click += new System.EventHandler(this.button_add_dinam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_cow);
            this.groupBox1.Controls.Add(this.label_wf);
            this.groupBox1.Controls.Add(this.label_wtr);
            this.groupBox1.Controls.Add(this.label_grs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(565, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "основная информация";
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // label_cow
            // 
            this.label_cow.AutoSize = true;
            this.label_cow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_cow.Location = new System.Drawing.Point(107, 82);
            this.label_cow.Name = "label_cow";
            this.label_cow.Size = new System.Drawing.Size(23, 13);
            this.label_cow.TabIndex = 11;
            this.label_cow.Text = "null";
            // 
            // label_wf
            // 
            this.label_wf.AutoSize = true;
            this.label_wf.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_wf.Location = new System.Drawing.Point(107, 110);
            this.label_wf.Name = "label_wf";
            this.label_wf.Size = new System.Drawing.Size(23, 13);
            this.label_wf.TabIndex = 10;
            this.label_wf.Text = "null";
            // 
            // label_wtr
            // 
            this.label_wtr.AutoSize = true;
            this.label_wtr.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_wtr.Location = new System.Drawing.Point(107, 56);
            this.label_wtr.Name = "label_wtr";
            this.label_wtr.Size = new System.Drawing.Size(23, 13);
            this.label_wtr.TabIndex = 8;
            this.label_wtr.Text = "null";
            // 
            // label_grs
            // 
            this.label_grs.AutoSize = true;
            this.label_grs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_grs.Location = new System.Drawing.Point(107, 32);
            this.label_grs.Name = "label_grs";
            this.label_grs.Size = new System.Drawing.Size(23, 13);
            this.label_grs.TabIndex = 7;
            this.label_grs.Text = "null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "кол-во wolf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "кол-во cow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "кол-во water";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_meth);
            this.Controls.Add(this.dataGridView_map);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_map)).EndInit();
            this.groupBox_meth.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_map;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_meth;
        private System.Windows.Forms.Button button_add_dinam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_wf;
        private System.Windows.Forms.Label label_wtr;
        private System.Windows.Forms.Label label_grs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_cow;
        private System.Windows.Forms.Timer timer1;
    }
}

