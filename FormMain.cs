using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessHelper
{
    public partial class FormMain : Form
    {
        private List<Workout> currentWorkouts = new List<Workout>();
        private BindingSource bs;
        private VoiceOver voice = new VoiceOver();
        private System.Windows.Forms.Timer timer;
        private FileHelper fileHelper = new FileHelper();
        int seconds = 0;
        int secondsforWorkout = 0;
        bool currentRest = false;
        int reps = 0;
        public FormMain()
        {
            InitializeComponent();
            SetupDataGrid();
            buttonPause.Enabled = false;
        }

        private void SetupDataGrid()
        {
            bs = new BindingSource
            {
                DataSource = currentWorkouts
            };
            dataGridMainTrainings.DataSource = bs;
            bs.EndEdit();
            bs.ResetBindings(false);
            dataGridMainTrainings.AutoResizeColumns();
            dataGridMainTrainings.Refresh();
        }

        private void buttonAddTraining_Click(object sender, EventArgs e)
        {
            FormChooseTraining formChoose = new FormChooseTraining();
            var result = formChoose.ShowDialog();
            if(result == DialogResult.OK)
            {
                if(formChoose.GetUserChoice())
                {
                    currentWorkouts.AddRange(formChoose.GetPremadeWorkout().Workouts);
                }
                else
                {
                    currentWorkouts.Add(formChoose.GetWorkout());
                    label1.Text = formChoose.GetWorkout().Name;
                }
            }
            bs.EndEdit();
            bs.ResetBindings(false);
            formChoose.Dispose();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            reps = (int)numericRepeat.Value+1;
            if(numericRestBetwExercise.Value!=0)
            {
                Workout temp = new Workout();
                temp.Name = "Rest";
                temp.Seconds = (int)numericRestBetwExercise.Value;
                for (int i = currentWorkouts.Count - 1; i > 0; i--)
                    currentWorkouts.Insert(i, temp);
                bs.EndEdit();
                bs.ResetBindings(false);
            }
            startWorkout();

        }
        void timer_Tick(object sender, EventArgs e)
        {
            //for(int i =0; i<=numericRepeat.Value; i++)
            seconds++;
            secondsforWorkout++;
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            label1.Text = time.ToString(@"hh\:mm\:ss");
            if (currentRest)
            {
                if(secondsforWorkout==1)
                {
                    //voice.Speak(VoiceOver.MessageType.Rest, numericPause.Value.ToString());
                }
                if (secondsforWorkout == numericPause.Value)
                {
                    secondsforWorkout = 0;
                    currentRest = false;
                }
            }
            else
            {
                foreach (Workout workout in currentWorkouts)
                {
                    if (workout.Completed == false)
                    {
                        if (secondsforWorkout == 1)
                        {
                            //voice.Speak(VoiceOver.MessageType.Time, workout.Seconds.ToString());
                        }
                        if (secondsforWorkout == workout.Seconds)
                        {
                            voice.Beep();
                            secondsforWorkout -= workout.Seconds;
                            workout.Completed = true;
                            bs.EndEdit();
                            bs.ResetBindings(false);//rest between workouts undone
                        }
                        break;
                    }
                }
                Workout w = new Workout
                {
                    Completed = false
                };
                if (!currentWorkouts.Contains(w))
                {
                    secondsforWorkout = 0;
                    reps--;
                    if (reps == 0)
                    {
                        timer.Stop();
                        buttonPause.Enabled = false;
                        buttonStart.Enabled = true;
                        timer.Dispose();
                    }
                    else
                    {
                        currentWorkouts.ForEach(delegate (Workout workout1)
                        {
                            workout1.Completed = false;
                        });
                        currentRest = true;
                    }
                }
            }
        }

        void timer_TickRest(object sender, EventArgs e)
        {
            if(secondsforWorkout==numericPause.Value)
            {
                secondsforWorkout = 0;
                timer.Stop(); 
                timer.Dispose();
                label2.Text = "SADASD";
            }
        }

        private void startWorkout()
        {
            seconds = 0;
            secondsforWorkout = 0;
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Start();
            buttonStart.Enabled = false;
            buttonPause.Enabled = true;
        }

        private void startRestBetweenTrainigs()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_TickRest);
            timer.Interval = 1000;
            timer.Start();
            buttonStart.Enabled = false;
            buttonPause.Enabled = true;
        }
        private void buttonRemoveTraining_Click(object sender, EventArgs e)
        {
            
            List<PremadeWorkout> premadeWorkouts = new List<PremadeWorkout>();
            PremadeWorkout pw = new PremadeWorkout();
            pw.Duration = 100;
            pw.Name = "Test";
            pw.Workouts = currentWorkouts;
            premadeWorkouts.Add(pw);
            premadeWorkouts.Add(pw);
            fileHelper.Write(premadeWorkouts);
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if(buttonPause.Text=="Pause")
            {
                timer.Stop();
                buttonPause.Text = "Resume";
            }
            else if(buttonPause.Text == "Resume")
            {
                timer.Start();
                buttonPause.Text = "Pause";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
