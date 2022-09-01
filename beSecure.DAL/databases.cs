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
                //openConnection();
            }catch(Exception e)
            {
                throw (e);
            }
            
        }
        public Databases(string conStr)
        {
            connectionString = conStr;
            //openConnection();
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
                using (MySqlConnection myCon = new MySqlConnection(connectionString))
                {
                    myCon.Open();
                    string query = "select isBlackListed from whitelist where sName='" + cInfo.name + "' and sOrganization='" + cInfo.organization + "' and iOrganization='" + cInfo.iOrganization + "' and publicKey='" + cInfo.publicKey + "';";

                    MySqlCommand myCom = new MySqlCommand(query, myCon);
                    var data = myCom.ExecuteReader();
                    if (data.HasRows)
                    {
                        data.Read();
                        if ((Boolean)data["isBlackListed"])
                        {
                            closeConnection();
                            return -1;
                        }
                        else
                        {
                            closeConnection();
                            return 1;
                        }
                    }
                    closeConnection();
                    return 0;

                }
                }catch (Exception e)
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
