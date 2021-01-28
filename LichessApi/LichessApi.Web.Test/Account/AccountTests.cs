using System;
using LichessApi.Web.Test;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace LichessApi.Test
{
    public class AccountTests : ApiTest
    {
        public AccountTests(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
        }

        [Theory]
        [InlineData("Georges")]
        public void Account_GetProfile_ReturnsUserExtended(string expectedName)
        {
            // Act
            var response = ApiClient.Account.GetProfile().Result;
            
            // Assert
            Assert.Equal( expectedName, response.Username);
        }

        [Theory]
        [InlineData("abathur@mail.org")]
        public void Account_GetEmailAddress_ReturnsEmailAddress(string email)
        {
            // Act
            var response = ApiClient.Account.GetEmailAddress().Result;

            // Assert
            Assert.Equal(email, response.Email);
        }
    }
}
