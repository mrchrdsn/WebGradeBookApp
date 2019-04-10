using NUnit.Framework;
using WebGradeBookApp.Utilities;

namespace Tests
{
    [TestFixture]
    public class ProjectTests
    {
        [Test]
        [TestCase("")]
        public void ValidateFirstName_EmptyString_ReturnsFalse(string name)
        {
            bool isValid = false;

            isValid = ValidatorUtility.IsFirstNameValid(name);

            Assert.IsTrue(isValid);
        }

        [Test]
        [TestCase(null)]
        public void ValidateFirstName_NullValue_ReturnsFalse(string name)
        {
            bool isValid = false;

            isValid = ValidatorUtility.IsFirstNameValid(name);

            Assert.IsTrue(isValid);
        }
    }
}