namespace repair
{
    partial class NewProblem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RTProblem = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBEx = new System.Windows.Forms.ComboBox();
            this.CBPriority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CBPriority);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBEx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RTProblem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задача для заявки №";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проблема";
            // 
            // RTProblem
            // 
            this.RTProblem.Location = new System.Drawing.Point(20, 71);
            this.RTProblem.Name = "RTProblem";
            this.RTProblem.Size = new System.Drawing.Size(211, 63);
            this.RTProblem.TabIndex = 1;
            this.RTProblem.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Исполнитель";
            // 
            // CBEx
            // 
            this.CBEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBEx.FormattingEnabled = true;
            this.CBEx.Items.AddRange(new object[] {
            "Не начато",
            "В работе",
            "Выполнен"});
            this.CBEx.Location = new System.Drawing.Point(20, 189);
            this.CBEx.Name = "CBEx";
            this.CBEx.Size = new System.Drawing.Size(211, 28);
            this.CBEx.TabIndex = 30;
            this.CBEx.Text = "Выбирите";
            // 
            // CBPriority
            // 
            this.CBPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBPriority.FormattingEnabled = true;
            this.CBPriority.Items.AddRange(new object[] {
            "Не начато",
            "В работе",
            "Выполнен"});
            this.CBPriority.Location = new System.Drawing.Point(20, 275);
            this.CBPriority.Name = "CBPriority";
            this.CBPriority.Size = new System.Drawing.Size(211, 28);
            this.CBPriority.TabIndex = 32;
            this.CBPriority.Text = "Выбирите";
            this.CBPriority.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Приоритет";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 41);
            this.button1.TabIndex = 33;
            this.button1.Text = "Сохранить задачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 436);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewProblem";
            this.Text = "NewProblem";
            this.Load += new System.EventHandler(this.NewProblem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTProblem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBEx;
        private System.Windows.Forms.ComboBox CBPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}