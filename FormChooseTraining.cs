using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessHelper
{
    public partial class FormChooseTraining : Form
    {
        private FileHelper fileHelper = new FileHelper();
        private List<PremadeWorkout> premadeWorkouts = new List<PremadeWorkout>();

        public FormChooseTraining()
        {
            InitializeComponent();
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            premadeWorkouts = fileHelper.Read(FileHelper.ReadMode.Premade);
            dataGridPremadeWorkouts.ColumnCount = 2;
            dataGridPremadeWorkouts.Columns[0].Name = "Name";
            dataGridPremadeWorkouts.Columns[1].Name = "Duration";
            foreach (var workout in premadeWorkouts)
            {
                object[] row = new object[] { workout.Name, workout.Duration };
                dataGridPremadeWorkouts.Rows.Add(row);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBoxRest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRest.Checked)
            {
                textBoxNameW.Text = "Rest";
                textBoxNameW.Enabled = false;
            }
            else
            {
                textBoxNameW.Text = "";
                textBoxNameW.Enabled = true;
            }
        }

        public bool GetUserChoice()
        {
            return checkBPremadeWorkout.Checked;
        }

        public Workout GetWorkout()
        {
            Workout toreturn = new Workout();
            toreturn.Name = textBoxNameW.Text;
            toreturn.Seconds = (int)numericTime.Value;
            toreturn.Completed = false;
            return toreturn;
        }

        public PremadeWorkout GetPremadeWorkout()
        {
            return premadeWorkouts[dataGridPremadeWorkouts.SelectedRows[0].Index];
        }

        private void checkBPremadeWorkout_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBPremadeWorkout.Checked)
            {
                checkBoxRest.Enabled = false;
                numericTime.Enabled = false;
                textBoxNameW.Enabled = false;
            }
            else
            {
                checkBoxRest.Enabled = true;
                numericTime.Enabled = true;
                textBoxNameW.Enabled = true;
            }
        }
    }
}