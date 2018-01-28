using Gadz.Staff.Agenda.Web.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gadz.Staff.Agenda.Helpers
{
    public class AccessHelper {

        public static ICredencial GetCredencial(string id) {
            var cookie = new DefaultHttpContext().Request.Cookies["userId"]; 

            return new Credencial {  };
        }
    }
}
