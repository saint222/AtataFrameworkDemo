using Atata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataTest.Pages
{
    using _ = AfishaTUTPage;


    [Url("https://afisha.tut.by")]
    public class AfishaTUTPage : Page<_>
    {
        [FindByTitle("Кино")]
        public Link<_> CinemaClick { get; set; }

        public Control<_> ResponseCode { get; set; }

    }
}
