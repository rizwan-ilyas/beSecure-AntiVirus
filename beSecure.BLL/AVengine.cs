using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using beSecure.Common;
using beSecure.DAL;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Security.AccessControl;

namespace beSecure.BLL
{
    public class AVengine
    {
        public event UpdateControlDel updateForm;
        public static List<FileDetails> scannedFiles;
        public static List<FileDetails> blackListed;
        public static List<FileDetails> whiteListed;
        public static List<FileDetails> noSignedList;
        public static List<FileDetails> noCertificateList;
        
        Databases database;
        String qurantineAddress;
        String CurrentFile;
        public String path;
        public int noOfFiles;
        public int ProcessednoFiles;

        public AVengine()
        {
            scannedFiles = new List<FileDetails>();
            whiteListed = new List<FileDetails>();
            blackListed  = new List<FileDetails>();
            noSignedList = new List<FileDetails>();
            noCertificateList = new List<FileDetails>();
            database = new Databases();
            qurantineAddress = @"D:\Quarantine";
            CurrentFile = "";
            path = "";
            ProcessednoFiles = 1;
        }

        public List<FileDetails> getScannedFile()
        {
            return scannedFiles;
        }
        public List<FileDetails> getWhiteListedFiles()
        {
            return whiteListed;
        }
        public List<FileDetails> getBlackListedFiles()
        {
            return blackListed;
        }
        public List<FileDetails> getnoSignedFiles()
        {
            return noSignedList;
        }


        public void QuickScan()
        {
            String drive="";
            foreach (var d in DriveInfo.GetDrives())
            {
                drive = @d.ToString();
                if (drive != "C:\\" && drive != "D:\\")
                {
                    this.path = drive;
                    Scan(drive, drive.Split(':')[0],true);
                }
                
            }
        }

        public void CustomScan()
        {
            if (path.Length == 3)
            {
                Scan(@path, path.Split(':')[0]);
            }
            else {
                Scan(@path);
            }
            
        }

        public void Scan(string path, string driveletter = "\0",bool isQuick=false)
        {
            try {
                String[] files;
                if (driveletter != "\0")
                {

                    if (isQuick)
                    {
                        files = Directory.GetFiles(path,".exe");
                    }
                    else
                    {
                        files = Directory.GetFiles(path);
                    }
                    
                }
                else
                {
                    files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                }
           
            String[] nextDirecties = Directory.GetDirectories(path);

            foreach (var file in files)
            {
                    CurrentFile = file;
                scannedFiles.Add(verifyFile(file));
                updateForm(++ProcessednoFiles, file); 
            }

            if (nextDirecties.Length != 0)
            {
                foreach(var dir in nextDirecties)
                {
                    if (driveletter != "\0")
                    {
                        if(dir != driveletter+":\\System Volume Information" && dir != driveletter + ":\\$RECYCLE.BIN" && dir!= "C:\\Documents" && dir!="C:\\Settings")
                        {
                                if (isQuick)
                                {
                                    Scan(dir, driveletter,true);
                                }
                                else
                                {
                                    Scan(dir, driveletter);
                                }
                        }


                    }
                    else
                    {
                        Scan(dir);
                    }
                }
            }
            }catch(Exception e)
            {
                throw (e);
            }
        }

        public FileDetails verifyFile(String file)
        {
            certificateMajor certInfo = getCertDetails(file);
            FileDetails filedetail = new FileDetails();
            filedetail.name = file;
            filedetail.time = DateTime.Now;
            if (certInfo != null)
            {
                int result = database.isWhiteListed(certInfo);
                switch (result)
                {
                    case 0:
                        filedetail.status = "Not Listed";
                        noSignedList.Add(filedetail);
                        //qurantineFile(filedetail.name);
                        break;
                    case -1:
                        filedetail.status = "Black Listed";
                        blackListed.Add(filedetail);
                        //deleteVirus(filedetail.name);
                        
                        break;
                    case 1:
                        filedetail.status = "White Listed";
                        whiteListed.Add(filedetail);
                        break;
                }
            }
            filedetail.status="No Certificate";
            noCertificateList.Add(filedetail);
            return filedetail;
        }

        private bool deleteVirus(String file)
        {
            try
            {
                File.Delete(@file);
                return true;
            }catch (Exception e)
            {
                throw (e);
            }
        }
        


        private certificateMajor getCertDetails(string file)
        {
            try
            {
                X509Certificate signer = X509Certificate.CreateFromSignedFile(@file);
                X509Certificate2 certificate = new X509Certificate2(signer);

                return mouldCertificate(certificate);
            }
            catch (System.Security.Cryptography.CryptographicException)
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
            foreach (var i in subject.Split(','))
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
            foreach (var i in issuer.Split(','))
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

       public Boolean qurantineFile(String file)
        {
            try {

                //FileSecurity fileSecurity = new FileSecurity(file);
                /* var noExeRule = new FileSystemAccessRule(file, FileSystemRights.ExecuteFile, AccessControlType.Deny);
                 FileSecurity fileSecurity = new FileSecurity();
                 fileSecurity.AddAccessRule(noExeRule);
                     File.SetAccessControl(file, fileSecurity);*/
                

            File.Move(file, qurantineAddress);
                return true;
            }catch (Exception e)
            {
                throw (e);
            }
        }

        public string getCurrentFile()
        {
            return CurrentFile;
        }
        
        public void getAllFiles()
        {
            if (this.path.Length == 3)
            {
                int total = Directory.GetFiles(path).Length;
                string dir = this.path.Split(':')[0];
                foreach (var item in Directory.GetDirectories(@path))
                {
                    if(item!= dir+ ":\\System Volume Information" && item != dir + ":\\$RECYCLE.BIN" && item != "C:\\Documents" && dir != ":\\Settings")
                    {
                        total+= Directory.GetFiles(item, "*", SearchOption.AllDirectories).Length;
                    }
                }
                this.noOfFiles = total;
                //return total;
            }
            else
            {
                int total1 = Directory.GetFiles(this.path, "*", SearchOption.AllDirectories).Length;
                this.noOfFiles = total1;
            }
            
            //return total1;
        }


    }
}
