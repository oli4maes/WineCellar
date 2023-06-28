using WineCellar.Application.Dtos;
using WineCellar.Application.Features.Cellar.AddBottleToCellar;
using WineCellar.Domain.Entities;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.UnitTests.Features.Cellar.AddWineToCellar;

public class AddWineToCellarHandlerTests
{
    private readonly Mock<IBottleRepository> _userWineRepositoryMock;

    public AddWineToCellarHandlerTests()
    {
        _userWineRepositoryMock = new();
    }

    [Fact]
    public async Task Handle_Should_Create_UserWine_And_Return_Response()
    {
        // Arrange
        const string USERNAME = "test user name";
        const string AUTH0ID = "test auth 0 id";
        const int WINEID = 1;
        const int AMOUNT = 1;
        const int USERWINEID = 1;

        var expectedUserWine = new BottleDto()
        {
            Id = USERWINEID,
            WineId = WINEID,
            Wine = new WineDto()
        };

        var addWineToCellarRequest =
            new AddBottleToCellarRequest(expectedUserWine.WineId, expectedUserWine.BottleSize, USERNAME, AUTH0ID);

        var SUT = new AddBottleToCellarHandler(_userWineRepositoryMock.Object);

        // Act
        var result = await SUT.Handle(addWineToCellarRequest, default);

        // Assert
        _userWineRepositoryMock.Verify(x => x.Create(It.IsAny<Bottle>()), Times.Once);

        result.Should().BeOfType<AddBottleToCellarResponse>();
        result.Bottle.Should().NotBeNull();
        result.Bottle?.WineId.Should().Be(expectedUserWine.WineId);
    }
}