using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailSender.Lib.Additions;

namespace MailSender.Lib.Tests.Additions
{
    /// <summary>
    /// Класс модульных тестов для StringEncryptorTests
    /// </summary>
    [TestClass]
    public class StringEncryptorTests
    {
        public StringEncryptorTests()
        {
            //
            // TODO: добавьте здесь логику конструктора
            //
        }

        private TestContext _testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return _testContextInstance;
            }
            set
            {
                _testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void EncryptMethod_on_ASD_Return_BTE_with_Key_1()
        {
            //AAA

            //Arrange
            const string str = "ASD";
            const string expectedResult = "BTE";
            const int key = 1;

            //Act
            var actualResult = str.Encrypt(key);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DecryptMethod_on_BTE_Return_ASD_with_Key_1()
        {
            //AAA

            //Arrange
            const string str = "BTE";
            const string expectedResult = "ASD";
            const int key = 1;

            //Act
            var actualResult = str.Decrypt(key);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            
        }
    }
}
