using Mediator;
using WineCellar.Application.Features.Cellar.AddBottleToCellar;
using WineCellar.Application.Features.Cellar.BulkAddBottleToCellar;
using WineCellar.Domain.Enums;

namespace WineCellar.Application.UnitTests.Features.Cellar.BulkAddBottleToCellar;

public class BulkAddBottleToCellarTests
{
    private readonly Mock<IMediator> _mediatorMock = new();

    [Fact]
    public async Task Handle_Should_Bulk_Add_Bottles_To_Cellar_And_Return_Response()
    {
        // Arrange
        const string username = "test user name";
        const string auth0Id = "test auth 0 id";
        const int wineId = 1;
        const int amountOfBottles = 3;
        const double pricePerBottle = 10.99;
        const BottleSize bottleSize = BottleSize.Standard;

        var bulkAddBottlesToCellarRequest = new BulkAddBottleToCellarRequest(wineId, bottleSize, amountOfBottles,
            DateTime.UtcNow, username, auth0Id, pricePerBottle);

        var sut = new BulkAddBottleToCellarHandler(_mediatorMock.Object);

        // Act
        var result = await sut.Handle(bulkAddBottlesToCellarRequest, default);

        // Assert
        _mediatorMock.Verify(x =>
            x.Send(It.IsAny<AddBottleToCellarRequest>(), default), Times.Exactly(3));

        result.Should().BeOfType<BulkAddBottleToCellarResponse>();
        result.AmountFailed.Should().Be(0);
        result.AmountSucceeded.Should().Be(3);
    }
}