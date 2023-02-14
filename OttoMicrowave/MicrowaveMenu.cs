using OttoMicrowave.entities;
using OttoMicrowave.services;
using OttoMicrowave.services.exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OttoMicrowave
{
    public partial class MicrowaveMenu : Form
    {

        private const int MaxTime = 120, MinTime = 1, DefaultTime = 30;
        private const int MaxPower = 10, MinPower = 1, DefaultPower = 10;
        private string ErrorTime => $"O tempo não pode ser definido em valores maiores que " + MaxTime + " nem menores que " + MinTime;
        private string ErrorPower => $"A potencia não pode ser definida em valores maiores que " + MaxPower + " nem menores que " + MinPower;
        private static Microwave Microwave = new Microwave();
        MicrowaveService microwaveService = new MicrowaveService(Microwave);
        private Thread countdownThread;
        private bool countingDown;
        private bool paused;
        private SoundPlayer SPlayerOn = new SoundPlayer(Properties.Resources.Microwave_On);
        private SoundPlayer SPlayerOff = new SoundPlayer(Properties.Resources.Microwave_Offt);


        public event EventHandler<TimeInvalidException> EventException;
        private void OnEventException(string exception)
        {
            if (EventException != null)
            {
                EventException.Invoke(this, new TimeInvalidException(exception));
            }
            else
            {
                MessageBox.Show(exception);
            }
        }

        public MicrowaveMenu()
        {
            InitializeComponent();
            Microwave.CreationOfQuickModes();
            listQuickModes.DataSource = Microwave.Modes.ToList();
            labelTime.Text = "";
            labelPower.Text = "";
            labelTime.Text = "0:00";
            labelOutPut.Text = "";
            labelQuickMode.Text = "";
            Microwave.Working = false;
        }



        public void PrepareMicrowave()
        {
            if (Microwave.ActualMode != null)
            {
                setConfiguration(Microwave.ActualMode);
            }
            else
            {
                SetConfiguration();
            }
            Microwave.Working = true;
        }

        public void RearangeLabels()
        {
            microwaveService.TransformTimeToMinutesAndSeconds();
            labelTime.Text = $"{Microwave.Minutes}:{Microwave.Seconds}";
            labelPower.Text = Microwave.Power.ToString();
            inputPower.Text = "";
            inputTime.Text = "";
        }

        public bool ValidateStringsInput()
        {
            if (inputTime.Text.Length >= 1)
            {
                var time = int.Parse(inputTime.Text);
                if (time > MaxTime || time < MinTime)
                {
                    OnEventException(ErrorTime);
                    return false;
                }
            }
            if (inputPower.Text.Length >= 1)
            {
                var power = int.Parse(inputPower.Text);
                if (power > MaxPower || power < MinPower)
                {
                    OnEventException(ErrorPower);
                    return false;
                }
            }
            return true;
        }

        private void SetConfiguration()
        {
            switch (inputTime.Text.Length)
            {
                case 0:
                    if (Microwave.Working) { return; }
                    else
                    {
                        Microwave.Time = DefaultTime;
                    }
                    break;
                default:
                    Microwave.Time = int.Parse(inputTime.Text);
                    break;
            }
            switch (inputPower.Text.Length)
            {
                case 0:
                    if (Microwave.Working) { return; }
                    else
                    {
                        Microwave.Power = DefaultPower;
                    }
                    break;
                default:
                    Microwave.Power = int.Parse(inputPower.Text);
                    break;
            }

        }

        private void setConfiguration(QuickMode quickMode)
        {
            Microwave.Time = quickMode.Time;
            Microwave.Power = quickMode.Power;
        }
        private void CountDown()
        {
            var text = OutputText();
            while (Microwave.Seconds >= 0)
            {
                if (!paused)
                {
                    if (Microwave.Seconds == 0 && Microwave.Minutes > 0)
                    {
                        Microwave.Minutes--;
                        Microwave.Seconds = 60;
                    }
                    UpdateLabelTime(Microwave.Minutes + ":" + Microwave.Seconds);
                    Thread.Sleep(1000);
                    Microwave.Seconds--;
                    if (Microwave.Seconds >= 0 || Microwave.Minutes > 0)
                        labelOutPut.Text += text;
                }


            }
            SPlayerOn.Stop();
            SPlayerOff.Play();
            labelOutPut.Text += "Aquecimento concluído";
            Microwave.Working = false;
            countingDown = false;
        }

        private string OutputText()
        {
            if (Microwave.ActualMode != null)
            {
                return StringBuilderService.StringBuilderWithQuickModeChar(Microwave.ActualMode);
            }
            else
            {
                return StringBuilderService.StringBuilderWithQuickModeChar(Microwave.Power);
            }
        }
        private void UpdateLabelTime(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateLabelTime), text);
            }
            else
            {
                labelTime.Text = text;
            }
        }

        private void StartCountdown()
        {
            if (!countingDown)
            {
                SPlayerOn.PlayLooping();
                countingDown = true;
                countdownThread = new Thread(new ThreadStart(CountDown));
                countdownThread.Start();
            }
        }

        private void StopCountdown()
        {
            SPlayerOn.Stop();

            if (countingDown)
            {
                countingDown = false;
                countdownThread.Abort();
                paused = false;
            }
        }

        private void PauseCountdown()
        {
            SPlayerOff.Play();
            paused = true;
        }

        private void ResumeCountdown()
        {
            SPlayerOn.PlayLooping();
            Microwave.Working = true;
            paused = false;
        }
        private void turnOn_Click(object sender, EventArgs e)
        {
            labelOutPut.Text = "";
            if (Microwave.ActualMode != null && Microwave.Working == true)
            {
                MessageBox.Show("Não é possivel mudar o tempo para QuickModes pré-programados");
                return;
            }
            if (paused) ResumeCountdown();
            else
            {
                if (!ValidateStringsInput()) return;
                PrepareMicrowave();
                RearangeLabels();
                if (!paused) StartCountdown();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PauseCountdown();
            if (!Microwave.Working)
            {
                StopCountdown();
                inputTime.Text = "";
                inputPower.Text = "";
                labelTime.Text = "0:00";
                labelPower.Text = "";
                Microwave.Time = 0;
                labelOutPut.Text = "";
                Microwave.ActualMode = null;
                labelQuickMode.Text = "";
                listQuickModes.SelectedItem = null;
            }
            Microwave.Working = false;
        }
        private void btnCad_Click(object sender, EventArgs e)
        {
            CadQuickMode cadQuickMode = new CadQuickMode(Microwave, new QuickMode());
            cadQuickMode.ShowDialog();

            listQuickModes.DataSource = null;
            listQuickModes.DataSource = Microwave.Modes.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            QuickMode quickMode = (QuickMode)listQuickModes.SelectedItems[0];

            if (quickMode != null && !quickMode.Initial)
            {
                microwaveService.RemoveQuickMode(quickMode);

                listQuickModes.DataSource = null;
                listQuickModes.DataSource = Microwave.Modes.ToList();
            }
            else
            {
                MessageBox.Show("Não é possivel excluir modos que ja vem no sistema");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countingDown = false;
        }



        private void listQuickModes_Click(object sender, EventArgs e)
        {
            StopCountdown();
            Microwave.ActualMode = (QuickMode)listQuickModes.SelectedItem;
            Microwave.Working = false;
            labelOutPut.Text = "";
            labelQuickMode.Text = "QuickMode: " + Microwave.ActualMode.Name.ToString();
            labelTime.Text = "";
            labelPower.Text = "";
        }

        private void listQuickModes_DoubleClick(object sender, EventArgs e)
        {
            CadQuickMode cadQuickMode = new CadQuickMode(Microwave, (QuickMode)listQuickModes.SelectedItem);
            cadQuickMode.ShowDialog();

            //Recaregar lista de QuickModes
            listQuickModes.DataSource = null;
            listQuickModes.DataSource = Microwave.Modes.ToList();
        }

        private void inputNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopCountdown();
        }
    }
}
