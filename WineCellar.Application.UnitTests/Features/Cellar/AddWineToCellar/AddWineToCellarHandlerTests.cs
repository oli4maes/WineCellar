using WineCellar.Application.Dtos;
using WineCellar.Application.Features.Cellar.AddWineToCellar;
using WineCellar.Domain.Entities;
using WineCellar.Domain.Persistence.Repositories;

namespace WineCellar.Application.UnitTests.Features.Cellar.AddWineToCellar;

public class AddWineToCellarHandlerTests
{
    private readonly Mock<IUserWineRepository> _userWineRepositoryMock;

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
        
        var expectedUserWine = new UserWineDto()
        {
            Id = USERWINEID,
            Amount = AMOUNT,
            WineId = WINEID,
            Wine = new WineDto()
        };

        var addWineToCellarRequest =
            new AddWineToCellarRequest(expectedUserWine.WineId, expectedUserWine.Amount, USERNAME, AUTH0ID);

        var SUT = new AddWineToCellarHandler(_userWineRepositoryMock.Object);

        // Act
        var result = await SUT.Handle(addWineToCellarRequest, default);

        // Assert
        _userWineRepositoryMock.Verify(x => x.Create(It.IsAny<UserWine>()), Times.Once);
        
        result.Should().BeOfType<AddWineToCellarResponse>();
        result.UserWine.Should().NotBeNull();
        result.UserWine?.WineId.Should().Be(expectedUserWine.WineId);
        result.UserWine?.Amount.Should().Be(expectedUserWine.Amount);
    }
}