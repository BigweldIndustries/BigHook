using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class hooks
    {
        public static byte[] webhook(string uri, System.Collections.Specialized.NameValueCollection pairs)
        {
            using (WebClient wb = new WebClient())
            {
                return wb.UploadValues(uri, pairs);
            }
        }
    }
}