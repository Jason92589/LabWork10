using LabWork10;

namespace PasswordValidatorTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            bool result = PasswordValidator.ValidatePassword("Password123");
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            bool result = PasswordValidator.ValidatePassword("qwerty12");
            Assert.True(result);
        }

        [Fact]
        public void Test3()
        {
            bool result = PasswordValidator.ValidatePassword("Abcd1");
            Assert.True(result);
        }

        [Fact]
        public void Test4()
        {
            bool result = PasswordValidator.ValidatePassword("Password");
            Assert.True(result);
        }
    }
}
