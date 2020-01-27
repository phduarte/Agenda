using Gadz.Agenda.Web.Models;
using Microsoft.AspNetCore.Http;

namespace Gadz.Agenda.Helpers
{
    public class AccessHelper
    {
        public static ICredencial GetCredencial(string id)
        {
            var cookie = new DefaultHttpContext().Request.Cookies["userId"];

            return new Credencial { };
        }
    }
}