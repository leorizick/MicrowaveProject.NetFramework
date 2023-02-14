using OttoMicrowave.entities;
using OttoMicrowave.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OttoMicrowave.Testes
{
    public class MicrowaveServiceTest
    {
        [Fact]
        public void TransformTimeToMinutesAndSeconds_PassingZeroValues_ToSum30_Test()
        {
            var microwave = new Microwave()
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

            Assert.Equal(30, microwave.Seconds);
            Assert.Equal(0, microwave.Time);

        }

        [Fact]
        public void TransformTimeToMinutesAndSeconds_SecondsPlus30IsBiggerThan60()
        {
            var microwave = new Microwave
            {
                Working = true,
                Time = 0,
                Minutes = 0,
                Seconds = 40
            };

            MicrowaveService microwaveService = new MicrowaveService(microwave);
            // Act
            microwaveService.TransformTimeToMinutesAndSeconds();

            // Assert

            Assert.Equal(1, microwave.Minutes);
            Assert.Equal(10, microwave.Seconds);
            Assert.Equal(0, microwave.Time);
        }

        [Fact]
        public void TransformTimeToMinutesAndSeconds_WorkingAndTimeIsNotZero_TransformsToMinutesAndSeconds()
        {
            // Arrange
            var microwave = new Microwave { Working = true, Time = 90, Minutes = 0, Seconds = 0 };

            MicrowaveService microwaveService = new MicrowaveService(microwave);
            // Act
            microwaveService.TransformTimeToMinutesAndSeconds();

            // Assert

            Assert.Equal(1, microwave.Minutes);
            Assert.Equal(30, microwave.Seconds);
            Assert.Equal(0, microwave.Time);

        }

        [Fact]
        public void AddQuickModes_test()
        {
            var QuickMode = new QuickMode
            {
                Name = "Test",
                Food = "Test",
                code = "T",
                Initial = true,
                Instruction = "T",
                Power = 10,
                Time = 10
            };

            var microwave = new Microwave
            {
                Working = true,
                Time = 90,
                Minutes = 0,
                Seconds = 0
            };

            MicrowaveService microwaveService = new MicrowaveService(microwave);

            microwaveService.AddQuickMode(QuickMode);

            Assert.Equal(microwave.Modes.First(), QuickMode  );          
        }

        [Fact]
        public void FindAllQuickModes_Test()
        {
            var QuickMode = new QuickMode
            {
                Name = "Test",
                Food = "Test",
                code = "T",
                Initial = true,
                Instruction = "T",
                Power = 10,
                Time = 10
            };

            var QuickMode2 = new QuickMode
            {
                Name = "Test",
                Food = "Test",
                code = "T",
                Initial = true,
                Instruction = "T",
                Power = 10,
                Time = 10
            };

            var microwave = new Microwave
            {
                Working = true,
                Time = 90,
                Minutes = 0,
                Seconds = 0
            };

            MicrowaveService microwaveService = new MicrowaveService(microwave);

            microwaveService.AddQuickMode(QuickMode);
            microwaveService.AddQuickMode(QuickMode2);

            var list = microwaveService.FindAllQuickModes();

            Assert.True(list.Count > 1);
            Assert.Equal(list.First(), QuickMode);
        }

        [Fact]
        public void RemoveQuickMode_Test()
        {
            var QuickMode = new QuickMode
            {
                Name = "Test",
                Food = "Test",
                code = "T",
                Initial = true,
                Instruction = "T",
                Power = 10,
                Time = 10
            };

            var QuickMode2 = new QuickMode
            {
                Name = "Test",
                Food = "Test",
                code = "T",
                Initial = true,
                Instruction = "T",
                Power = 10,
                Time = 10
            };

            var microwave = new Microwave
            {
                Working = true,
                Time = 90,
                Minutes = 0,
                Seconds = 0
            };

            MicrowaveService microwaveService = new MicrowaveService(microwave);

            microwaveService.AddQuickMode(QuickMode);
            microwaveService.AddQuickMode(QuickMode2);

            microwaveService.RemoveQuickMode(QuickMode2);

           

            Assert.True(microwave.Modes.Count == 1);
        }

        [Fact]
        public void SetQuickMode_Test()
        {
            var QuickMode = new QuickMode
            {
                Name = "Test",
                Food = "Test",
                code = "T",
                Initial = true,
                Instruction = "T",
                Power = 10,
                Time = 10
            };

            var microwave = new Microwave
            {
                Working = true,
                Time = 90,
                Minutes = 0,
                Seconds = 0
            };

            MicrowaveService microwaveService = new MicrowaveService(microwave);

            microwaveService.AddQuickMode(QuickMode);

            microwaveService.SetQuickMode(QuickMode);

            Assert.Equal(microwave.Power, QuickMode.Power);
            Assert.Equal(microwave.Time, QuickMode.Time);
            Assert.Equal(microwave.ActualMode, QuickMode);
        }

        [Fact]
        public void ResetDefaultMode_Test()
        {
            var microwave = new Microwave
            {
                Working = true,
                Time = 90,
                Minutes = 0,
                Seconds = 0
            };

            MicrowaveService microwaveService = new MicrowaveService(microwave);

            microwaveService.ResetDefaultMode();

            Assert.Equal(10, microwave.Power);
            Assert.Equal(30, microwave.Time);

        }

    }
}
