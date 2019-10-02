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
        public void TutLogin()
        {
            Go.To<HomeTUTPage>()
                .Enter.Click()
                .Login.Set("saint12maloj@gmail.com")
                .Password.Set("Iambored12")
                .EnterAgain.Click()
                //.ResponseCode.Content.Should.Contain("200")                
                //.Inp.Set("новости")
                .LoggedIn.Content.Should.Contain("Saint Saint")
                .Wait(10);
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
