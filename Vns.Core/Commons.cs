using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraGrid.Views.Grid;
using System.Xml;

namespace Vns.Core
{
    public class Commons
    {
        #region Message

        public static bool Message_Confirm(string sMessage, bool bShowRetry = false)
        {
            //Hàm hiện message confirm 
            if (bShowRetry)
            {
                return (MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry);
            }
            else
            {
                return (MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            }
        }

        public static DialogResult Message_YesNoCancel(string sMessage)
        {
            //Hàm hiện message YesNoCancel
            return MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static void Message_Information(string sMessage)
        {
            //Thủ tục hiện message information
            MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Message_Warning(string sMessage)
        {
            //Thủ tục hiện message warning
            MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Message_Error(Exception ex)
        {
            // Message_Error(ex, "");
            Message_Warning("Đã có lỗi xảy ra, vui lòng kiểm tra lại hệ thống");

        }

        public static void Message_Error(Exception ex, string sDesc)
        {
            MessageBox.Show(ex.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static IList<DateTime> GetTuNgayDenNgayTrongThang(int Thang, int Nam)
        {
            DateTime TuNgay = new DateTime(Nam, Thang, 1);

            TuNgay = TuNgay.AddDays((-TuNgay.Day) + 1);

            DateTime DenNgay = new DateTime(Nam, Thang, 1);
            //DenNgay = DenNgay.AddMonths(1).AddDays(-1);
            DenNgay = DenNgay.AddMonths(1);
            DenNgay = DenNgay.AddDays(-(DenNgay.Day));
            IList<DateTime> lst = new List<DateTime>();
            lst.Add(TuNgay);
            lst.Add(DenNgay);
            // MessageBox.Show(TuNgay.ToString() + "---" + DenNgay.ToString());
            return lst;
        }
        #endregion

        //#region DataHelper
        //public static DataTable ToDataTable<T>(IList<T> data)
        //{
        //    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
        //    DataTable dt = new DataTable();
        //    for (int i = 0; i <= properties.Count - 1; i++)
        //    {
        //        PropertyDescriptor property = properties[i];
        //        try
        //        {
        //            dt.Columns.Add(property.Name, property.PropertyType);
        //        }
        //        catch (Exception ex)
        //        {
        //            dt.Columns.Add(property.Name, typeof(DateTime));
        //        }

        //    }
        //    object[] values = new object[properties.Count];
        //    foreach (T item in data)
        //    {
        //        for (int i = 0; i <= values.Length - 1; i++)
        //        {
        //            if (object.ReferenceEquals(properties[i].PropertyType, typeof(DateTime)))
        //            {
        //                DateTime tmp = (DateTime)properties[i].GetValue(item);
        //                values[i] = tmp <= DateTime.MinValue ? null : properties[i].GetValue(item);
        //            }
        //            else if (object.ReferenceEquals(properties[i].PropertyType, typeof(decimal)))
        //            {
        //                decimal tmp = (decimal)properties[i].GetValue(item);
        //                values[i] = tmp <= Int32.MinValue ? null : properties[i].GetValue(item);
        //            }
        //            else
        //            {
        //                values[i] = properties[i].GetValue(item);
        //            }
        //        }
        //        dt.Rows.Add(values);
        //    }
        //    return dt;
        //}
        //#endregion
    }


/// <summary>
/// Read and Write info in XML File
/// </summary>
/// <remarks></remarks>
public class XMLConfig
{

	/// <summary>
	/// Get XML Document form string
	/// </summary>
	/// <param name="message"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static XmlDocument CreateXMLDocument(string message)
	{
		XmlDocument doc = new XmlDocument();
		try {
			doc.LoadXml(message);
		} catch (Exception ex) {
			//MessageBox.Show("XML syntax invalid !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		}
		return doc;
	}

	/// <summary>
	/// Get XML Document form XML file path
	/// </summary>
	/// <param name="filename"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	public static XmlDocument XmlReader(string filename)
	{
		XmlDocument doc = new XmlDocument();
		try {
			doc.Load(filename);
		} catch (Exception ex) {
			//MessageBox.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		return doc;
	}

	/// <summary>
	/// Write info to XML file
	/// </summary>
	/// <param name="filename"></param>
	/// <param name="username"></param>
	/// <param name="password"></param>
	/// <param name="donvi_id"></param>
	/// <param name="ten_donvi"></param>
	/// <param name="other1"></param>
	/// <param name="other2"></param>
	/// <param name="other3"></param>
	/// <param name="other4"></param>
	/// <param name="other5"></param>
	/// <remarks></remarks>
	public static void XMLWriter(string filename, string username, string password, string donvi_id, string ten_donvi, string other1, string other2, string other3, string other4, string other5)
	{
		try {
			XmlTextWriter writer = new XmlTextWriter(filename, null);
			writer.Formatting = Formatting.Indented;

			writer.WriteStartDocument();
			writer.WriteComment("Do not change content of this file." + "\\n Information basic :" + "\\n\\t servername : ten Server." + "\\n\\t username : ten dang nhap he thong." + "\\n\\t password : mat khau dang nhap he thong." + "\\n\\t database : ten co so du lieu.");
			writer.WriteStartElement("config");

			writer.WriteStartElement("username");
			writer.WriteString(username);
			writer.WriteEndElement();

			writer.WriteStartElement("password");
			writer.WriteString(password);
			writer.WriteEndElement();

			writer.WriteStartElement("donvi_id");
			writer.WriteString(donvi_id);
			writer.WriteEndElement();

			writer.WriteStartElement("ten_donvi");
			writer.WriteString(ten_donvi);
			writer.WriteEndElement();

			writer.WriteStartElement("other1");
			writer.WriteString(other1);
			writer.WriteEndElement();

			writer.WriteStartElement("other2");
			writer.WriteString(other2);
			writer.WriteEndElement();

			writer.WriteStartElement("other3");
			writer.WriteString(other3);
			writer.WriteEndElement();

			writer.WriteStartElement("other4");
			writer.WriteString(other4);
			writer.WriteEndElement();

			writer.WriteStartElement("other5");
			writer.WriteString(other5);
			writer.WriteEndElement();

			writer.WriteEndElement();
			writer.WriteEndDocument();

			writer.Close();
		} catch (Exception ex) {
		}
	}
}

    public class ReadXML
    {
        
    }
}
