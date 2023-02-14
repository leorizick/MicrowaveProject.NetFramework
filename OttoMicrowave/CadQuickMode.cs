using OttoMicrowave.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OttoMicrowave
{
    public partial class CadQuickMode : Form
    {

        private Microwave microwave;
        private QuickMode quickMode;

        
        public CadQuickMode(Microwave _microwave, QuickMode _quickMode)
        {
            InitializeComponent();
            microwave = _microwave;
            quickMode = _quickMode;
            inputCode.MaxLength = 1;
            if(quickMode != null)
            {
                inputFood.Text = quickMode.Food;
                inputName.Text = quickMode.Name;
                inputTime.Text = "" + quickMode.Time;
                inputPower.Text = "" + quickMode.Power;
                inputCode.Text = quickMode.code;
                inputInstructions.Text = quickMode.Instruction;
            }
            if (quickMode.Initial)
            {
                inputFood.Enabled = false;
                inputName.Enabled = false;
                inputTime.Enabled = false;
                inputPower.Enabled = false;
                inputCode.Enabled = false;
                inputInstructions.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private bool verifyInputsNotEmpty()
        {
            foreach (var item in microwave.Modes)
            {
                if (inputCode.Text.Equals(item.code) || inputCode.Text.Equals("."))
                {
                    MessageBox.Show("Codigo ja utilizado para outro QuickMode");
                    return false;
                }
            }
            if (inputName.Text.Length > 0 && 
                inputFood.Text.Length > 0 && 
                inputPower.Text.Length > 0 &&
                int.Parse(inputPower.Text) > 0  &&
                int.Parse(inputPower.Text) <= 10 &&
                inputTime.Text.Length > 0 &&
                int.Parse(inputTime.Text) > 0)
            {
                return true;
            }
           
            MessageBox.Show("Preencha os todos dados");
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadQuickMode_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inputNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!verifyInputsNotEmpty()) return;

            quickMode.Name = inputName.Text;
            quickMode.Food = inputFood.Text;
            quickMode.Instruction = inputInstructions.Text;
            quickMode.code = inputCode.Text;
            quickMode.Initial = false;
            quickMode.Time = int.Parse(inputTime.Text);
            quickMode.Power = int.Parse(inputPower.Text);
            try
            {
                foreach (var item in microwave.Modes)
                {
                    if (item.Name == inputName.Text)
                    {
                        microwave.Modes.Remove(item);
                    }
                }
            }
            catch(Exception ex)
            {

            }
            
            microwave.Modes.Add(quickMode);
            Close();
        }
    }
}
