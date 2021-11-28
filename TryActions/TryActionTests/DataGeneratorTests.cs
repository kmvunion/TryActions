using NUnit.Framework;
using System;
using TryActions;

namespace TryActionTests
{
    [TestFixture]
    public class DataGeneratorTests
    {

        [Test]
        public void GetGuid_Call_Success()
        {
            //Arrange Act

            var result = DataGenerator.GetGuid();

            //Assert
            var parsResult = Guid.TryParse(result, out Guid resultGuid);

            Assert.IsNotNull(result);
            Assert.IsTrue(parsResult);
            Assert.IsFalse(Guid.Equals(Guid.Empty, resultGuid));
        }

    }
}
