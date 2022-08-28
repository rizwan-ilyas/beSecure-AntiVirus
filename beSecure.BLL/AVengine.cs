using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using beSecure.Common;
using beSecure.DAL;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace beSecure.BLL
{
    public class AVengine
    {
        List<FileDetails> scannedFiles;

        AVengine()
        {
            scannedFiles = new List<FileDetails>();
        }

        

        public <> scan(string directory)
        {

        }

        public static List<String> traverseDir(String p)
        {
            try
            {
                ;
                //"E:\\$RECYCLE.BIN"
                //"E:\\System Volume Information"
                //IEnumerable<String> files = Directory.GetFiles(p, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".pdf") || s.EndsWith(".exe"));

                String[] files = Directory.GetFiles(p);
                String[] dirct = Directory.GetDirectories(p);
                if (dirct.Length == 0)
                {
                    allFiles.AddRange(files);
                    //printFiles(files); 
                    return allFiles;
                }
                else
                {
                    foreach (var d in dirct)
                    {
                        if (d != "D:\\System Volume Information" && d != "D:\\$RECYCLE.BIN")
                        {
                            traverseDir(d);
                        }

                    }
                    //printFiles(files);
                    allFiles.AddRange(files);
                    return allFiles;
                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }


            private certificateMajor getCertDetails(string file)
        {
            try { 
            X509Certificate signer = X509Certificate.CreateFromSignedFile(@file);
            X509Certificate2 certificate = new X509Certificate2(signer);

                return mouldCertificate(certificate);
            }catch (System.Security.Cryptography.CryptographicException)
            {
                return null;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        private certificateMajor mouldCertificate(X509Certificate2 cert)
        {
            string subject = cert.Subject;
            string issuer = cert.Issuer;
            certificateMajor certinfo = new certificateMajor();
            foreach(var i in subject.Split(','))
            {
                string[] temp = i.Split('=');
                switch (temp[0].Trim(' '))
                {
                    case "CN":
                        certinfo.name = temp[1];
                        break;
                    case "O":
                        certinfo.organization = temp[1];
                        break;
                }
            }
            foreach(var i in issuer.Split(','))
            {
                string[] temp = i.Split('=');
                if (temp[0].Trim(' ') == "O")
                {
                    certinfo.iOrganization = temp[1];
                    break;
                }
            }
            certinfo.publicKey = cert.GetPublicKeyString();
            return certinfo;
        }



        
    }
}
