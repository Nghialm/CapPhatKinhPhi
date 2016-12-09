using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vns.CapPhatKinhPhi.Domain;
using System.Xml;
using Vns.Core;

namespace CapPhatKinhPhi
{
    public class General
    {
        public static IList<Info> lstThamSo = new List<Info>();
        public static string FileDataBase = "";
        public static int NamKeToan = 2014;

        public static string TenDv = "";
        public static string DiaChi = "";
        public static string KBDv = "";
        public static string MaTkkt = "";
        public static string MaDvQhns = "";
    }

    public class GetXmlInfo
    {

        public static int GetNamKeToan()
        {
            XmlDocument doc = XMLConfig.XmlReader("KTConfig.xml");
            XmlElement root = doc.DocumentElement;
            XmlNode serverNode = root.SelectSingleNode("nam_ke_toan_info");
            string nam_kt = serverNode.SelectSingleNode("nam_kt").InnerText;
            int namketoan = 0;
            if (nam_kt.Equals(""))
            {
                namketoan = DateTime.Now.Year;
            }
            else
            {
                try
                {
                    namketoan = int.Parse(nam_kt);
                }
                catch
                {
                    namketoan = DateTime.Now.Year;
                }

            }
            return namketoan;
        }

        public static void WriteInfo(string nam_ke_toan)
        {
            try
            {
                //Get Document
                XmlDocument doc = XMLConfig.XmlReader("KTConfig.xml");
                //Get Root Element
                XmlElement root = doc.DocumentElement;
                //Get element named "database_info", that include info about server setting
                XmlNode serverNode = root.SelectSingleNode("nam_ke_toan_info");
                //Write to file
                serverNode.SelectSingleNode("nam_kt").InnerText = nam_ke_toan;

                //Save info
                doc.Save("KTConfig.xml");

                //Add Lock
                //AddLock()
            }
            catch
            {
            }
        }
    }
}
