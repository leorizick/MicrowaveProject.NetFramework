using OttoMicrowave.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OttoMicrowave.services
{
    public class MicrowaveService
    {
        private Microwave _microwave;

        public MicrowaveService(Microwave microwave)
        {
            _microwave = microwave;
        }

        public void TransformTimeToMinutesAndSeconds()
        {
            if (_microwave.Working && _microwave.Time == 0)
            {
                if ((_microwave.Seconds + 30)  > 60)
                {
                    _microwave.Minutes++;
                    _microwave.Seconds += 30 - 60;
                }
                else
                _microwave.Seconds += 30;
            }
            else
            {
                var Minutes = _microwave.Time / 60;
                var Seconds = _microwave.Time % 60;
                _microwave.Seconds = Seconds;
                _microwave.Minutes = Minutes;
                _microwave.Time = 0;
            }
            
        }

        public List<QuickMode> FindAllQuickModes()
        {
            return _microwave.Modes;
        }

        public void AddQuickMode(QuickMode mode)
        {
            _microwave.Modes.Add(mode);
        }

        public void RemoveQuickMode(QuickMode mode)
        {
            _microwave.Modes.Remove(mode);
        }


        public void SetQuickMode(QuickMode quickMode)
        {
            _microwave.ActualMode = quickMode;
            _microwave.Time = quickMode.Time;
            _microwave.Power = quickMode.Power;
        }

        public void ResetDefaultMode()
        {
            _microwave.Power = 10;
            _microwave.Time = 30;
        }

    }
}
