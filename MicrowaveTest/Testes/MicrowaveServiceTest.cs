using NUnit.Framework;
using OttoMicrowave.entities;
using OttoMicrowave.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OttoMicrowave.Testes
{
    [TestFixture]
    public class MicrowaveServiceTest
    {
        [Test]
        public void TransformTimeToMinutesAndSeconds_Test()
        {
            var microwave = new Microwave
            {
                Working = true,
                Time = 0,
                Minutes = 0,
                Seconds = 0,
                Power = 0,
                ActualMode = null
            };

            MicrowaveService microwaveService = new MicrowaveService(microwave);
            microwaveService.TransformTimeToMinutesAndSeconds();

            Assert.AreEqual(30, microwave.Seconds);
            Assert.AreEqual(0, microwave.Time);
            
        }

        [Test]
        public void TransformTimeToMinutesAndSeconds_WorkingAndTimeIsNotZero_TransformsToMinutesAndSeconds()
        {
            // Arrange
            var microwave = new Microwave { Working = true, Time = 90, Minutes = 0, Seconds = 0 };

            MicrowaveService microwaveService = new MicrowaveService(microwave);
            // Act
            microwaveService.TransformTimeToMinutesAndSeconds();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(microwave.Minutes, Is.EqualTo(1));
                Assert.That(microwave.Seconds, Is.EqualTo(30));
                Assert.That(microwave.Time, Is.EqualTo(0));
            });
        }

        [Test]
        public void TransformTimeToMinutesAndSeconds_NotWorking_DoesNothing()
        {
            // Arrange
            var microwave = new Microwave { Working = false, Time = 90, Minutes = 0, Seconds = 0 };

            // Act
            MicrowaveService microwaveService = new MicrowaveService(microwave);
            microwaveService.TransformTimeToMinutesAndSeconds();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(microwave.Minutes, Is.EqualTo(0));
                Assert.That(microwave.Seconds, Is.EqualTo(0));
                Assert.That(microwave.Time, Is.EqualTo(90));
            });
        }
    }
}
