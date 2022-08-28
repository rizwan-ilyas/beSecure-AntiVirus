using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using beSecure.Common;

namespace beSecure.DAL
{
    public class Databases
    {
        public String connectionString;
        public static MySqlConnection myConnection;

        public Databases()
        {
            try
            {
                connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
                openConnection();
            }catch(Exception e)
            {
                throw (e);
            }
            
        }
        public Databases(string conStr)
        {
            connectionString = conStr;
        }

        private bool openConnection()
        {
            try
            {
                if (myConnection == null)
                {
                    myConnection = new MySqlConnection(connectionString);
                    myConnection.Open();
                    if (myConnection.State == System.Data.ConnectionState.Open)
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    if (myConnection.State == System.Data.ConnectionState.Open)
                    {
                        return true;
                    }
                    return false;
                }
            }catch(Exception e)
            {
                throw (e);
            }

        }

        private bool closeConnection()
        {
            try
            {
                if (myConnection == null)
                {
                    return true;
                }
                else
                {
                    if (myConnection.State == System.Data.ConnectionState.Open)
                    {
                        myConnection.Close();
                        return true;
                    }
                    else if(myConnection.State == System.Data.ConnectionState.Closed)
                    {
                        return true;
                    }return false;
                }
                       

            }catch (Exception e)
            {
                throw (e);
            }
        }

        public int isWhiteListed(certificateMajor cInfo)
        {
            try
            {
                string query = "select isBlackListed from whitelist where sName='" + cInfo.name + "',sOrganization='" + cInfo.organization + "',iOrganization='" + cInfo.iOrganization + "',publicKey= '" + cInfo.publicKey + "';";
                MySqlCommand myCom = new MySqlCommand(query);
                var data = myCom.ExecuteReader();
                if (data.HasRows)
                {
                    data.Read();
                    if ((bool)data["isBlackListed"])
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                return 0;
            }catch(Exception e)
            {
                throw (e);

            }
        }
        ~Databases()
        {
            this.closeConnection();
            myConnection = null;
            this.connectionString = null;
        }





    }
}
