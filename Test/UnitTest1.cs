namespace test;

public class UnitTest1
{
    Register register = new Register(); 
    [Fact]
    public void LoginMenu()
    {
        Login login = new Login(); 

        Assert.Equal(login.Menu("1"), "Login");

    }
}