using FluentAssertions;
using System;
using Xunit;
using static UnitTestSpeaker.SpeakerBuilder;


namespace UnitTestSpeaker
{
    public class SpeakerTests
    {
        [Fact]
        public void Speaker_CannotBeCreatedWithout_Name()
        {
            Action act = () => GivenSpeaker().WithNullName();

            act
                .Should()
                .Throw<ArgumentException>()
                .WithMessage("Name cannot be null");
        }

        [Fact]
        public void Speaker_CannotBeCreatedWithout_Address()
        {
            Action act = () => GivenSpeaker().WithNullAddress();

            act
                .Should()
                .Throw<ArgumentException>()
                .WithMessage("Address cannot be null");
        }

        [Fact]
        public void Speaker_CannotBeCreatedWithout_Birthdate()
        {
            Action act = () => GivenSpeaker().WithNullBirthDate();

            act
                .Should()
                .Throw<ArgumentException>()
                .WithMessage("Birthdate cannot be empty");
        }

        [Fact]
        public void Speaker_CannotBeCreatedWithout_SpeakerWebsities()
        {
            Action act = () => new Speaker
            (
                new Name("Cezary", "W"),
                new DateTime(1974, 6, 26),
                new Address("Poland", "00-001", "Warsaw", "Lemonowa 81"),
                null,
                 ""
                , new Contact("555-555-555", "c@gmail.com")
            );

            act
                .Should()
                .Throw<ArgumentException>()
                .WithMessage("SpeakerWebsites cannot be empty");
        }
    }
}
