using WineCellar.Application.Dtos;
using WineCellar.Application.Features.Cellar.AddBottleToCellar;
using WineCellar.Domain.Entities;
using WineCellar.Domain.Enums;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.UnitTests.Features.Cellar.AddBottleToCellar;

public class AddBottleToCellarHandlerTests
{
    private readonly Mock<IBottleRepository> _userWineRepositoryMock;

    public AddBottleToCellarHandlerTests()
    {
        _userWineRepositoryMock = new Mock<IBottleRepository>();
    }

    [Fact]
    public async Task Handle_Should_Create_UserWine_And_Return_Response()
    {
        // Arrange
        const string username = "test user name";
        const string auth0Id = "test auth 0 id";
        const int wineId = 1;
        const int bottleId = 1;
        const BottleSize bottleSize = BottleSize.Standard;

        var addWineToCellarRequest =
            new AddBottleToCellarRequest(wineId, bottleSize, username, DateTime.UtcNow, auth0Id);

        var sut = new AddBottleToCellarHandler(_userWineRepositoryMock.Object);

        // Act
        var result = await sut.Handle(addWineToCellarRequest, default);

        // Assert
        _userWineRepositoryMock.Verify(x => x.Create(It.IsAny<Bottle>()), Times.Once);

        result.Should().BeOfType<AddBottleToCellarResponse>();
    }
}