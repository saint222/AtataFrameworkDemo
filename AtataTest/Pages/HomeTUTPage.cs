using Atata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataTest.Pages
{
    using _ = HomeTUTPage;
    //[Url("www.tut.by")]
    public class HomeTUTPage : Page<_>
    {
        [FindByXPath("div/a[@class='enter']")]
        public Link<_> Enter { get; set; }

        [FindByName("login", OuterXPath = "//form[@class='auth-form']//")]
        public Input<string, _> Login {get; set;}

        [FindByName("password", OuterXPath = "//form[@class='auth-form']//")]
        public PasswordInput<_> Password { get; set; }

        [FindByXPath("*[contains(@class, 'button')]", OuterXPath = "//form[@class='auth-form']//")]
        public Button<_> EnterAgain { get; set; }
        
        public Control<_> LoggedIn { get; set; }
        
        //public Control<_> ResponseCode { get; set; }

        //[FindById("search_from_str")]
        //public Input<string, _> Inp { get; set; }
    }
}
