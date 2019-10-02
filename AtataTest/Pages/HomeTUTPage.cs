using Atata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataTest.Pages
{
    using _ = TUTHomePage;
    [Url("")]
    public class TUTHomePage : Page<_>
    {
        [FindByXPath("div/a[@class='enter']")]
        public Link<_> Enter { get; set; }

        [FindByName("login", OuterXPath = "//form[@class='auth-form']//")]
        public Input<string, _> Login {get; set;}

        [FindByName("password", OuterXPath = "//form[@class='auth-form']//")]
        public PasswordInput<_> Password { get; set; }

        [FindByXPath("*[contains(@class, 'button')]", OuterXPath = "//form[@class='auth-form']//")]
        public Button<_> EnterAgain { get; set; }

        public Control<_> ResponseCode { get; set; }

        public Control<_> LoggedIn { get; set; }

        [FindByLabel("Запомнить")]
        public CheckBox<_> RememberMe { get; private set; }

    }
}
