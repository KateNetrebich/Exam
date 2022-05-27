using NUnit.Framework;
using ЕкзаменаційнеЗавданняБілет_2;

namespace Test
{
    public class Tests
    {
        private Parachute _parachute;
        private ParachuteType _parachuteType;

        [SetUp]
        public void Setup()
        {
            _parachute = new Parachute();
            _parachuteType = new ParachuteType();
        }

        [Test]
        public void CheckWeightWhenItsWrong()
        {
            var result = _parachute.CheckWeight(100);
            Assert.That(result, Is.Null);
        }

        [Test]
        public void CheckWeightWhenItsCorrect()
        {
            var result = _parachute.CheckWeight(67);
            Assert.That(result, Is.EqualTo(67));
        }

        [Test]
        public void CheckParachuteTypeIsSport()
        {
            var result = _parachute.ReturnParachuteType(1);
            Assert.That(result, Is.EqualTo(ParachuteType.SportParachute));
        }

        [Test]
        public void CheckParachuteTypeIsParachute()
        {
            var result = _parachute.ReturnParachuteType(2);
            Assert.That(result, Is.EqualTo(ParachuteType.Parachute));
        }

        [Test]
        public void CheckParachuteTypeIsNull()
        {
            var result = _parachute.ReturnParachuteType(6);
            Assert.That(result, Is.Null);
        }

        [Test]
        public void CheckThatWindSpeedIsNotCorrect()
        {
            var result = _parachute.ReturnWindSpeed(3);
            Assert.That(result, Is.False);
        }

        [Test]
        public void CheckThatWindSpeedIsCorrect()
        {
            var result = _parachute.ReturnWindSpeed(10);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CheckThatHeightIsNotCorrect()
        {
            var result = _parachute.ReturnWindSpeed(1000);
            Assert.That(result, Is.False);
        }

        [Test]
        public void CheckThatHeightIsCorrect()
        {
            var result = _parachute.ReturnWindSpeed(5000);
            Assert.That(result, Is.True);
        }
    }
}