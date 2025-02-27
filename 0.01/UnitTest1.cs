using NUnit.Framework;
using Lommeregner;

namespace Lommeregner
{
    [TestFixture]
    public class Lommeregner
    {
        private PrimeService _primeService;

        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);

            Assert.That(result, Is.False, "1 should not be prime");
        }
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first.");
        }
            }

            [TestCase(-1)]
[TestCase(0)]
[TestCase(1)]
public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
{
    var result = _primeService?.IsPrime(value);

    Assert.That(result, Is.False, $"{value} should not be prime");
}
}