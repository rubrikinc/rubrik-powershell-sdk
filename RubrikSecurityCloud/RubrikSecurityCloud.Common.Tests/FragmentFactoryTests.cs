using System;
using System.Reflection;
using NUnit.Framework;
using RubrikSecurityCloud.Types;

namespace RubrikSecurityCloud.Tests
{
    [TestFixture]
    public class FragmentFactoryTests
    {
        [Test]
        public void GetFragment_ReturnsNonEmptyString()
        {
            // Arrange
            var inputObject = new AccountSetting
            {
                IsEmailNotificationEnabled = false,
                IsEulaAccepted = true
            };

            // Act
            var result = inputObject.AsFieldSpec();

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
            var result = inputObject.AsFieldSpec();

            // Assert

            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

        [Test]
        public void GetFragment_ReturnsListOfNotNullSimpleProperties()
        {
            // Arrange
            string ind = new(' ', 0 * 2);
            var inputObject = new AccountSetting { IsEulaAccepted = true };
            string expected = ind + "isEulaAccepted\n";
            // Act
            var result = inputObject.AsFieldSpec();

            // Assert

            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetFragment_ReturnsListOfNotNullNestedProperties()
        {
            // Arrange
            var inputObject = new VsphereVm
            {
                Id = "FETCH",
                Name = "FETCH",
                Cluster = new Cluster { Id = "FETCH", Name = "FETCH" }
            };

            const string expected = "id\nname\ncluster {\n  id\n  name\n}\n";

            // Act
            var result = inputObject.AsFieldSpec();

            // Assert

            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void InitializeToDefaultValues_ReturnsPopulatedSimpleObject()
        {
            // Arrange
            AccountSetting inputObject = new();

            AccountSetting expected =
                new() { IsEmailNotificationEnabled = true, IsEulaAccepted = true };

            var inputObjectProps = inputObject.GetType().GetProperties();

            // Act
            inputObject.SelectForRetrieval();

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
            VsphereVm inputObject =
                new()
                {
                    Name = "FETCH",
                    Id = "FETCH",
                    EffectiveSlaDomain = new RscInterface<SlaDomain> {
                        new ClusterSlaDomain { Id = "FETCH", Name = "FETCH" } }
                };
            var ind = new string(' ', 2);

            string expected = "effectiveSlaDomain{...onClusterSlaDomain{idname}}idname";

            //Act
            string result = inputObject.AsFieldSpec();
            result = result.Replace(" ", "").Replace("\n", "");
            // Assert

            Assert.IsNotNull(result);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void InitializeToDefaultValues_ReturnsPopulatedComplexObject()
        {
            // Arrange
            VsphereVm inputObject = new();

            VsphereVm expected = new() { Id = "FETCH", Name = "FETCH", };

            var expectedProps = expected.GetType().GetProperties();

            // Act
            inputObject.SelectForRetrieval();

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
                        Assert.That(
                            inputObjectVal?.GetType().Name,
                            Is.EqualTo(expectedVal?.GetType().Name)
                        );
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
