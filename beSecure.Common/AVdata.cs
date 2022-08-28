using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beSecure.Common
{
    public class CertificateInfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string organization { get; set; }
        public string locality { get; set; }
        public string country { get; set; }

        public string iName { get; set; }
        public string iOrganization { get; set; }

        public string iLocality { get; set; }
        public string iC { get; set; }

        public string publicKey { get; set; }
    }

    public class certificateMajor
    {
        public string name { get; set; }
        public string organization { get; set; }
        public string iOrganization { get; set; }
        public string publicKey { get; set; }
    }

    public class FileDetails
    {
        public string name { get; set; }
        public string status { get; set; }
    }



}
