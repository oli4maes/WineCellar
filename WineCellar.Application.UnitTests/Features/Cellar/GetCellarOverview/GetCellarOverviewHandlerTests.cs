using WineCellar.Application.Features.Cellar.GetCellarOverview;
using WineCellar.Domain.Entities;
using WineCellar.Domain.Enums;
using WineCellar.Domain.Interfaces.Repositories;

namespace WineCellar.Application.UnitTests.Features.Cellar.GetCellarOverview;

public class GetCellarOverviewHandlerTests
{
    private readonly Mock<IUserWineRepository> _userWineRepositoryMock;
    
    public GetCellarOverviewHandlerTests()
    {
        _userWineRepositoryMock = new();
    }

    [Fact]
    public async Task Handle_Should_Get_The_User_Wines_And_Return_Response()
    {
        // Arrange
        const string AUTH0ID = "testUserId";
        const int WINEID1 = 1;
        const int WINEID2 = 2;

        var expectedUserWine1 = new UserWine()
        {
            Amount = 1,
            WineId = WINEID1,
            Auth0Id = AUTH0ID,
            Wine = new Wine()
            {
                Id = WINEID1,
                Name = "wine1",
                WineType = WineType.Red,
                Winery = new Winery()
                {
                    Name = "winery1"
                }
            }
        };
        
        var expectedUserWine2 = new UserWine()
        {
            Amount = 3,
            WineId = WINEID2,
            Auth0Id = AUTH0ID,
            Wine = new Wine()
            {
                Id = WINEID1,
                Name = "wine2",
                WineType = WineType.White,
                Winery = new Winery()
                {
                    Name = "winery2"
                }
            }
        };

        var userWines = new List<UserWine>();
        userWines.Add(expectedUserWine1);
        userWines.Add(expectedUserWine2);
        
        var request = new GetCellarOverviewRequest(AUTH0ID);
        var SUT = new GetCellarOverviewHandler(_userWineRepositoryMock.Object);

        _userWineRepositoryMock.Setup(x => x.GetUserWines(request.UserId))
            .ReturnsAsync(userWines);

        // Act
        var result = await SUT.Handle(request, default);

        // Assert
        _userWineRepositoryMock.Verify(x => x.GetUserWines(request.UserId), Times.Once);
        
        result.Should().NotBeNull();
        result.Should().BeOfType<GetCellarOverviewResponse>();
        result.UserWines.Count().Should().Be(2);
        
        result.UserWines.ToList()[0].Amount.Should().Be(expectedUserWine1.Amount);
        result.UserWines.ToList()[0].WineId.Should().Be(expectedUserWine1.WineId);
        result.UserWines.ToList()[0].WineName.Should().Be(expectedUserWine1.Wine.Name);
        result.UserWines.ToList()[0].WineryName.Should().Be(expectedUserWine1.Wine.Winery.Name);
        result.UserWines.ToList()[0].WineType.Should().Be(expectedUserWine1.Wine.WineType);

        result.UserWines.ToList()[1].Amount.Should().Be(expectedUserWine2.Amount);
        result.UserWines.ToList()[1].WineId.Should().Be(expectedUserWine2.WineId);
        result.UserWines.ToList()[1].WineName.Should().Be(expectedUserWine2.Wine.Name);
        result.UserWines.ToList()[1].WineryName.Should().Be(expectedUserWine2.Wine.Winery.Name);
        result.UserWines.ToList()[1].WineType.Should().Be(expectedUserWine2.Wine.WineType);
    }
}