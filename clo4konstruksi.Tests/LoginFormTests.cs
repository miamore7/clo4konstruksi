using Microsoft.VisualStudio.TestTools.UnitTesting;
using clo4konstruksi;
using System;

namespace clo4konstruksi.Tests
{
    [TestClass]
    public class LoginFormTests
    {
        [TestMethod]
        public void Login_WithValidCredentials_ShouldSucceed()
        {
            // Arrange
            var loginService = LoginService.Instance;

            // Act
            bool result = loginService.Login("superadmin", "superadmin");

            // Assert
            Assert.IsTrue(result);
            Assert.IsNotNull(loginService.LoggedInUser);
        }

        [TestMethod]
        public void Login_WithInvalidPassword_ShouldFail()
        {
            // Arrange
            var loginService = LoginService.Instance;

            // Act
            bool result = loginService.Login("admin", "password_salah");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Login_WithEmptyUsername_ShouldThrowException()
        {
            // Arrange
            var loginService = LoginService.Instance;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => loginService.Login("", "password"));
        }

        [TestMethod]
        public void Login_WithInactiveUser_ShouldFail()
        {
            // Arrange
            var loginService = LoginService.Instance;
            loginService.SetUserStatus("user", false); // Non-aktifkan user

            // Act
            bool result = loginService.Login("user", "user");

            // Assert
            Assert.IsFalse(result, "Pengguna yang tidak aktif seharusnya tidak bisa login.");

            // Cleanup
            loginService.SetUserStatus("user", true);
        }
    }
}