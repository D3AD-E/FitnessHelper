namespace FitnessHelper
{
    partial class FormMain
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
            this.buttonAddTraining = new System.Windows.Forms.Button();
            this.buttonRemoveTraining = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.dataGridMainTrainings = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericPause = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.numericRepeat = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericRestBetwExercise = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMainTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRestBetwExercise)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddTraining
            // 
            this.buttonAddTraining.Location = new System.Drawing.Point(673, 15);
            this.buttonAddTraining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddTraining.Name = "buttonAddTraining";
            this.buttonAddTraining.Size = new System.Drawing.Size(149, 58);
            this.buttonAddTraining.TabIndex = 0;
            this.buttonAddTraining.Text = "Add";
            this.buttonAddTraining.UseVisualStyleBackColor = true;
            this.buttonAddTraining.Click += new System.EventHandler(this.buttonAddTraining_Click);
            // 
            // buttonRemoveTraining
            // 
            this.buttonRemoveTraining.Location = new System.Drawing.Point(672, 80);
            this.buttonRemoveTraining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveTraining.Name = "buttonRemoveTraining";
            this.buttonRemoveTraining.Size = new System.Drawing.Size(151, 58);
            this.buttonRemoveTraining.TabIndex = 1;
            this.buttonRemoveTraining.Text = "Remove";
            this.buttonRemoveTraining.UseVisualStyleBackColor = true;
            this.buttonRemoveTraining.Click += new System.EventHandler(this.buttonRemoveTraining_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(673, 476);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(377, 63);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // dataGridMainTrainings
            // 
            this.dataGridMainTrainings.AllowUserToAddRows = false;
            this.dataGridMainTrainings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMainTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMainTrainings.Location = new System.Drawing.Point(16, 15);
            this.dataGridMainTrainings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridMainTrainings.MultiSelect = false;
            this.dataGridMainTrainings.Name = "dataGridMainTrainings";
            this.dataGridMainTrainings.ReadOnly = true;
            this.dataGridMainTrainings.RowHeadersVisible = false;
            this.dataGridMainTrainings.ShowEditingIcon = false;
            this.dataGridMainTrainings.Size = new System.Drawing.Size(648, 524);
            this.dataGridMainTrainings.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(831, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time passed: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(672, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time left until next exercise: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(672, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "How many times do we repeat training?";
            // 
            // numericPause
            // 
            this.numericPause.Location = new System.Drawing.Point(673, 277);
            this.numericPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericPause.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericPause.Name = "numericPause";
            this.numericPause.Size = new System.Drawing.Size(160, 22);
            this.numericPause.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(672, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pause between trainings (in seconds)";
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(676, 404);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(375, 47);
            this.buttonPause.TabIndex = 10;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // numericRepeat
            // 
            this.numericRepeat.Location = new System.Drawing.Point(673, 223);
            this.numericRepeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericRepeat.Name = "numericRepeat";
            this.numericRepeat.Size = new System.Drawing.Size(160, 22);
            this.numericRepeat.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(669, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rest between each exercise (in seconds)";
            // 
            // numericRestBetwExercise
            // 
            this.numericRestBetwExercise.Location = new System.Drawing.Point(673, 331);
            this.numericRestBetwExercise.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericRestBetwExercise.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericRestBetwExercise.Name = "numericRestBetwExercise";
            this.numericRestBetwExercise.Size = new System.Drawing.Size(160, 22);
            this.numericRestBetwExercise.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.numericRestBetwExercise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericRepeat);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericPause);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridMainTrainings);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonRemoveTraining);
            this.Controls.Add(this.buttonAddTraining);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Fitness helper";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMainTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRestBetwExercise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTraining;
        private System.Windows.Forms.Button buttonRemoveTraining;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataGridView dataGridMainTrainings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericPause;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.NumericUpDown numericRepeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericRestBetwExercise;
    }
}

