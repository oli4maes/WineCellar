using WineCellar.Application.Features.Cellar.EditBottle;
using WineCellar.Domain.Entities;
using WineCellar.Domain.Enums;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.UnitTests.Features.Cellar.EditBottle;

public class EditBottleTests
{
    private readonly Mock<IBottleRepository> _bottleRepositoryMock = new();

    [Fact]
    public async Task Handle_Should_Update_Bottle_And_Return_Response()
    {
        // Arrange
        const string username = "test user name";
        const int bottleId = 1;
        const double price = 10.99;
        const int vintage = 2022;

        var request = new EditBottleRequest(bottleId, BottleSize.Standard, DateTime.Now, username, price, vintage);

        var sut = new EditBottleHandler(_bottleRepositoryMock.Object);

        // Act
        var result = await sut.Handle(request, default);

        // Assert
        _bottleRepositoryMock.Verify(x => x.Update(It.IsAny<Bottle>()), Times.Once);

        result.Should().BeOfType<EditBottleResponse>();
    }
}