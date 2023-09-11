using AutoFixture;
using NSubstitute;
using PersonApi.Models;
using PersonApi.Repositories;
using PersonApi.Services;

namespace TestProject
{
    public class PersonRepTest
    {
        private readonly Fixture _fixture = new Fixture();

        private readonly IPersonService _sut;

        private readonly IGenericRepository<Person> _repository = Substitute.For<IGenericRepository<Person>>();

        public PersonRepTest()
        {
            _sut = new PersonRepService(_repository);
        }

        [Fact]
        public async void SavePersonAsync_ReturnSavedPerson()
        {

            //Arrange => create new instance of my entity.
            var person = _fixture.Create<Person>();

            //mock the repository
            _repository.SaveAsync(person).Returns(person);


            //Act => call my service
            var result = await _sut.SavePersonAsync(person);

            //Assert
            Assert.Equal(person, result);
        }
    }
}
