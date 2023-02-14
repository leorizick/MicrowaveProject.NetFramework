using OttoMicrowave.entities;
using OttoMicrowave.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OttoMicrowave.Testes
{
    public class MicrowaveTest
    {
      
        [Fact]
        public void FindAllQuickModes_Test()
        {
            var microwave = new Microwave
            {
                Working = true,
                Time = 90,
                Minutes = 0,
                Seconds = 0
            };

            microwave.CreationOfQuickModes();

            Assert.True(microwave.Modes.Count > 1);
            Assert.True(microwave.Modes.Count == 5);
            Assert.NotNull(microwave.Modes[0]);
        }

    }
}
