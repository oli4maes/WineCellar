using WineCellar.Application.Features.Cellar.AddBottleToCellar;
using WineCellar.Domain.Entities;
using WineCellar.Domain.Enums;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.UnitTests.Features.Cellar.AddBottleToCellar;

public class AddBottleToCellarHandlerTests
{
    private readonly Mock<IBottleRepository> _bottleRepositoryMock = new();

    [Fact]
    public async Task Handle_Should_Add_Bottle_To_Cellar_And_Return_Response()
    {
        // Arrange
        const string username = "test user name";
        const string auth0Id = "test auth 0 id";
        const int wineId = 1;
        const double pricePerBottle = 10.99;
        const BottleSize bottleSize = BottleSize.Standard;

        var addBottleToCellarRequest =
            new AddBottleToCellarRequest(wineId, bottleSize, username, DateTime.UtcNow, auth0Id, pricePerBottle);

        var sut = new AddBottleToCellarHandler(_bottleRepositoryMock.Object);

        // Act
        var result = await sut.Handle(addBottleToCellarRequest, default);

        // Assert
        _bottleRepositoryMock.Verify(x => x.Create(It.IsAny<Bottle>()), Times.Once);

        result.Should().BeOfType<AddBottleToCellarResponse>();
    }
}