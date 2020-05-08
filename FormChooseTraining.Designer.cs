namespace FitnessHelper
{
    partial class FormChooseTraining
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxRest = new System.Windows.Forms.CheckBox();
            this.textBoxNameW = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericTime = new System.Windows.Forms.NumericUpDown();
            this.checkBPremadeWorkout = new System.Windows.Forms.CheckBox();
            this.dataGridPremadeWorkouts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPremadeWorkouts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(37, 358);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(109, 35);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(177, 358);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(109, 35);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxRest
            // 
            this.checkBoxRest.AutoSize = true;
            this.checkBoxRest.Location = new System.Drawing.Point(293, 42);
            this.checkBoxRest.Name = "checkBoxRest";
            this.checkBoxRest.Size = new System.Drawing.Size(48, 17);
            this.checkBoxRest.TabIndex = 2;
            this.checkBoxRest.Text = "Rest";
            this.checkBoxRest.UseVisualStyleBackColor = true;
            this.checkBoxRest.CheckedChanged += new System.EventHandler(this.checkBoxRest_CheckedChanged);
            // 
            // textBoxNameW
            // 
            this.textBoxNameW.Location = new System.Drawing.Point(26, 39);
            this.textBoxNameW.Name = "textBoxNameW";
            this.textBoxNameW.Size = new System.Drawing.Size(233, 20);
            this.textBoxNameW.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(366, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(434, 450);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Duration (in seconds)";
            // 
            // numericTime
            // 
            this.numericTime.Location = new System.Drawing.Point(26, 87);
            this.numericTime.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTime.Name = "numericTime";
            this.numericTime.Size = new System.Drawing.Size(120, 20);
            this.numericTime.TabIndex = 7;
            this.numericTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBPremadeWorkout
            // 
            this.checkBPremadeWorkout.AutoSize = true;
            this.checkBPremadeWorkout.Location = new System.Drawing.Point(381, 12);
            this.checkBPremadeWorkout.Name = "checkBPremadeWorkout";
            this.checkBPremadeWorkout.Size = new System.Drawing.Size(170, 17);
            this.checkBPremadeWorkout.TabIndex = 8;
            this.checkBPremadeWorkout.Text = "Use premade workout scheme";
            this.checkBPremadeWorkout.UseVisualStyleBackColor = true;
            this.checkBPremadeWorkout.CheckedChanged += new System.EventHandler(this.checkBPremadeWorkout_CheckedChanged);
            // 
            // dataGridPremadeWorkouts
            // 
            this.dataGridPremadeWorkouts.AllowUserToAddRows = false;
            this.dataGridPremadeWorkouts.AllowUserToDeleteRows = false;
            this.dataGridPremadeWorkouts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPremadeWorkouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPremadeWorkouts.Location = new System.Drawing.Point(381, 39);
            this.dataGridPremadeWorkouts.MultiSelect = false;
            this.dataGridPremadeWorkouts.Name = "dataGridPremadeWorkouts";
            this.dataGridPremadeWorkouts.ReadOnly = true;
            this.dataGridPremadeWorkouts.RowHeadersVisible = false;
            this.dataGridPremadeWorkouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPremadeWorkouts.ShowEditingIcon = false;
            this.dataGridPremadeWorkouts.Size = new System.Drawing.Size(407, 399);
            this.dataGridPremadeWorkouts.TabIndex = 9;
            // 
            // FormChooseTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridPremadeWorkouts);
            this.Controls.Add(this.checkBPremadeWorkout);
            this.Controls.Add(this.numericTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.textBoxNameW);
            this.Controls.Add(this.checkBoxRest);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.Name = "FormChooseTraining";
            this.Text = "Choose training";
            ((System.ComponentModel.ISupportInitialize)(this.numericTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPremadeWorkouts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxRest;
        private System.Windows.Forms.TextBox textBoxNameW;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericTime;
        private System.Windows.Forms.CheckBox checkBPremadeWorkout;
        private System.Windows.Forms.DataGridView dataGridPremadeWorkouts;
    }
}