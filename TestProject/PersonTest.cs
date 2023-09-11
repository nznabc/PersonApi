using AutoFixture;
using NSubstitute;
using PersonApi.Models;
using PersonApi.Services;

namespace TestProject
{
    public class PersonTest
    {
        private readonly Fixture _fixture = new Fixture();

        private readonly IPersonService _personService = Substitute.For<IPersonService>();

        [Fact]
        public void SavePersonAsync_AddNewPerson()
        {
            //Arrange
            //create new instance of person
            var person = _fixture.Create<Person>();

            _personService.SavePersonAsync(person).Returns(person);

            //Act
            //call my service
            var result = _personService.SavePersonAsync(person);

            //Assert
            //compare result and expected objects
            Assert.Equal(person, result.Result);

        }

        [Theory]
        [InlineData("updatedName")]
        public async Task UpdatePersonAsync_ReturnUpdatedPerson(string name)
        {
            //Arrange
            var person = _fixture.Create<Person>();

            person.Name = name;

            _personService.UpdatePersonAsync(person).Returns(person);

            //Act
            var updatedperson = await _personService.UpdatePersonAsync(person);

            //Assert
            Assert.Equal(person, updatedperson);
        }

    }
}

