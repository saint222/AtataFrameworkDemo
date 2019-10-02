using Atata;
using AtataTest.Pages;
using NUnit.Framework;

namespace AtataTest
{
    [TestFixture]
    public class UITestFixture
    {
        [SetUp]
        public void SetUp()
        {
            // Find information about AtataContext set-up on https://atata.io/getting-started/#set-up
            AtataContext.Configure().
                UseChrome().
                //    WithArguments("start-maximized").
                UseBaseUrl("https://www.tut.by").
                UseCulture("en-us").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                LogNUnitError().
                UseAssertionExceptionType<NUnit.Framework.AssertionException>().
                UseNUnitAggregateAssertionStrategy().
                Build();
        }

        [Test]
        public void Tut_Login_Positive()
        {
            Go.To<TUTHomePage>()
                .Enter.Click()
                .Login.Set("test@gmail.com")
                .Password.Set("Test!2")
                .Wait(5)
                .RememberMe.Click() //checkbox "Запомнить меня"
                .Wait(5)
                .EnterAgain.Click()
                .ResponseCode.Content.Should.Contain("200")           
                .LoggedIn.Content.Should.Contain("Saint Saint")
                .Wait(5);
        }

        [Test]
        public void Tut_Login_Negative()
        {
            Go.To<TUTHomePage>()
                .Enter.Click()
                .Login.Set("saint12maloj@gmail.com")
                .Password.Set("Iambored123")
                .EnterAgain.Click()
                //.ResponseCode.Content.Should.Contain("401")
                .LoggedIn.Content.Should.Not.Contain("Saint Saint")
                .Wait(5);
        }

        [Test]
        public void Tut_Afisha_Positive()
        {
            Go.To<AfishaTUTPage>()
                .CinemaClick.Click()
                .ResponseCode.Content.Should.Contain("200")
                .Wait(5);
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
