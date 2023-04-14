using System;
using System.Reflection;
using NUnit.Framework;
using Rubrik.SecurityCloud.Types;

namespace Rubrik.SecurityCloud.Schema.Tests
{
    [TestFixture]
    public class FragmentFactoryTests
    {
        [Test]
        public void GetFragment_ReturnsNonEmptyString()
        {
            // Arrange
            var inputObject = new AccountSetting { IsEmailNotificationEnabled = false, IsEulaAccepted = true };

            // Act
            var result = inputObject.AsFragment();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [Test]
        public void GetFragment_ReturnsEmptyString()
        {
            // Arrange
            var inputObject = new AccountSetting();

            // Act
            var result = inputObject.AsFragment();

            // Assert

            Assert.IsNotNull(result);
            Assert.IsEmpty(result);

        }

        [Test]
        public void GetFragment_ReturnsListOfNotNullSimpleProperties()
        {
            // Arrange
            string ind = new string(' ', 0 * 2);
            var inputObject = new AccountSetting { IsEulaAccepted = true};
            string expected = ind + "isEulaAccepted\n";
            // Act
            var result = inputObject.AsFragment();

            // Assert

            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void GetFragment_ReturnsListOfNotNullNestedProperties()
        {
            // Arrange
            string ind = new string(' ', 0 * 2);
            var inputObject = new VsphereVm {
                Id = "FETCH",
                Name = "FETCH",
                Cluster = new Cluster
                {
                    Id = "FETCH",
                    Name = "FETCH"
                }
            };

            string expected = "id\nname\ncluster\n{\n  id\n  name\n}\n";

            // Act
            var result = inputObject.AsFragment();

            // Assert

            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void InitializeToDefaultValues_ReturnsPopulatedSimpleObject()
        {
            // Arrange
            AccountSetting inputObject = new AccountSetting();


            AccountSetting expected = new AccountSetting
            {
                IsEmailNotificationEnabled = false,
                IsEulaAccepted = false
            };

            var expectedProps = expected.GetType().GetProperties();
            var inputObjectProps = inputObject.GetType().GetProperties();

            // Act
            inputObject.ApplyExploratoryFragment();

            // Assert
            Assert.IsNotNull(inputObject);
            
            foreach (PropertyInfo prop in inputObjectProps)
            {
                var expectedVal = prop.GetValue(expected);
                var inputObjectVal = prop.GetValue(inputObject);

                Assert.That(inputObjectVal, Is.EqualTo(expectedVal));
            }
        }

        [Test]
        public void GetFragment_ReturnInterfaceFragment()
        {
            // Arrange
            VsphereVm inputObject = new VsphereVm
            {
                Name = "FETCH",
                Id = "FETCH",
                EffectiveSlaDomain = new ClusterSlaDomain
                {
                    Id = "FETCH",
                    Name = "FETCH"
                }
            };
            string ind = new string(' ', 2);

            string expected = "id\nname\neffectiveSlaDomain\n" +
                "{\n... on ClusterSlaDomain\n{\n" +
                ind + "id\n" +
                ind + "name\n}\n}\n";

            //Act
            string result = inputObject.AsFragment();

            // Assert

            Assert.IsNotNull(result);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void InitializeToDefaultValues_ReturnsPopulatedComplexObject()
        {
            // Arrange
            VsphereVm inputObject = new VsphereVm();


            VsphereVm expected = new VsphereVm
            {
                Id = "FETCH",
                Name = "FETCH",
                Cluster = new Cluster(),
                EffectiveSlaDomain = new ClusterSlaDomain()
            };

            var expectedProps = expected.GetType().GetProperties();
            var inputObjectProps = inputObject.GetType().GetProperties();

            // Act
            inputObject.ApplyExploratoryFragment();

            // Assert
            Assert.IsNotNull(inputObject);

            foreach (PropertyInfo prop in expectedProps)
            {
                if (prop.GetValue(expected) != null)
                {
                    var expectedVal = prop.GetValue(expected);
                    var inputObjectVal = prop.GetValue(inputObject);

                    if (prop.PropertyType.IsClass || prop.PropertyType.IsInterface)
                    {
                        Assert.IsNotNull(inputObjectVal);
                        Assert.That(inputObjectVal.GetType().Name,
                            Is.EqualTo(expectedVal.GetType().Name));
                    }
                    else
                    {
                        Assert.That(inputObjectVal, Is.EqualTo(expectedVal));
                    }
                }
            }
        }

    }
}
