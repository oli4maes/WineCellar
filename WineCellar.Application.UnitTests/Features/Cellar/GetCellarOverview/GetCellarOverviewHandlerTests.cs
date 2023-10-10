using WineCellar.Application.Features.Cellar.GetCellarOverview;
using WineCellar.Domain.Entities;
using WineCellar.Domain.Enums;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.UnitTests.Features.Cellar.GetCellarOverview;

public class GetCellarOverviewHandlerTests
{
    private readonly Mock<IBottleRepository> _userWineRepositoryMock;

    public GetCellarOverviewHandlerTests()
    {
        _userWineRepositoryMock = new Mock<IBottleRepository>();
    }

    [Fact]
    public async Task Handle_Should_Get_The_User_Wines_And_Return_Response()
    {
        // Arrange
        const string auth0Id = "testUserId";
        const int wineId1 = 1;
        const int wineId2 = 2;

        var expectedUserWine1 = new Bottle()
        {
            WineId = wineId1,
            Auth0Id = auth0Id,
            Wine = new Wine()
            {
                Id = wineId1,
                Name = "wine1",
                WineType = WineType.Red,
                Winery = new Winery()
                {
                    Name = "winery1"
                }
            }
        };

        var expectedUserWine2 = new Bottle()
        {
            WineId = wineId2,
            Auth0Id = auth0Id,
            Wine = new Wine()
            {
                Id = wineId1,
                Name = "wine2",
                WineType = WineType.White,
                Winery = new Winery()
                {
                    Name = "winery2"
                }
            }
        };

        var userWines = new List<Bottle>
        {
            expectedUserWine1,
            expectedUserWine2
        };

        var request = new GetCellarOverviewRequest(auth0Id);
        var sut = new GetCellarOverviewHandler(_userWineRepositoryMock.Object);

        _userWineRepositoryMock.Setup(x => x.GetUserBottlesInCellar(request.Auth0Id))
            .ReturnsAsync(userWines);

        // Act
        var result = await sut.Handle(request, default);

        // Assert
        _userWineRepositoryMock.Verify(x => x.GetUserBottlesInCellar(request.Auth0Id), Times.Once);

        result.Should().NotBeNull();
        result.Should().BeOfType<GetCellarOverviewResponse>();
        result.Bottles.Count().Should().Be(2);

        result.Bottles.ToList()[0].WineId.Should().Be(expectedUserWine1.WineId);
        result.Bottles.ToList()[0].WineName.Should().Be(expectedUserWine1.Wine.Name);
        result.Bottles.ToList()[0].WineryName.Should().Be(expectedUserWine1.Wine.Winery.Name);
        result.Bottles.ToList()[0].WineType.Should().Be(expectedUserWine1.Wine.WineType);

        result.Bottles.ToList()[1].WineId.Should().Be(expectedUserWine2.WineId);
        result.Bottles.ToList()[1].WineName.Should().Be(expectedUserWine2.Wine.Name);
        result.Bottles.ToList()[1].WineryName.Should().Be(expectedUserWine2.Wine.Winery.Name);
        result.Bottles.ToList()[1].WineType.Should().Be(expectedUserWine2.Wine.WineType);
    }
}