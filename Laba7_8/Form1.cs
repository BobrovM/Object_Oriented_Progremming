using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;
using System.Xml;
using System.Net;
using System.IO;

namespace Laba7_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        XmlDocument xmlNews = new XmlDocument();
        XmlNodeList childNodeList;

        private void Button_Read_Click(object sender, EventArgs e)
        {
            string strNews;
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://news.yandex.ru/business.rss");
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            xmlNews.Load("https://news.yandex.ru/business.rss");
            Stream ioStream = Response.GetResponseStream();
            StreamReader ioReader = new StreamReader(ioStream);
            strNews = ioReader.ReadToEnd();

            RichTextBox_XML.Text = strNews;

            childNodeList = xmlNews.DocumentElement.SelectSingleNode("channel").SelectNodes("item");

            string strTextOutput = "";

            foreach (XmlNode xmlNode in childNodeList)
            {
                string title = xmlNode.SelectSingleNode("title").InnerText;
                string link = xmlNode.SelectSingleNode("link").InnerText;
                string description = xmlNode.SelectSingleNode("description").InnerText;
                string pubDate = xmlNode.SelectSingleNode("pubDate").InnerText;

                strTextOutput = strTextOutput.Insert(strTextOutput.Length, title + "\n" + "\n"
                    + pubDate + "\n" + "\n" + description + "\n" + "\n" + link + "\n" + "\n" + "\n" + "\n" + "\n");
            }

            RichTextBox_News.Text = strTextOutput;
        }

        private void Button_Write_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlDataBase;
            SQLiteCommand sqlCommand;
            sqlDataBase = new SQLiteConnection("Data Source = dataBase.db");
            sqlDataBase.Open();

            sqlCommand = new SQLiteCommand("DELETE FROM News", sqlDataBase);
            sqlCommand.ExecuteNonQuery();

            sqlCommand = new SQLiteCommand("PRAGMA synchronous = 1; CREATE TABLE IF NOT EXISTS News" +
                "(Id INTEGER PRIMARY KEY AUTOINCREMENT, Title, Link, Description, PubDate);", sqlDataBase);
            sqlCommand.ExecuteNonQuery();

            xmlNews.Load("https://news.yandex.ru/business.rss");

            childNodeList = xmlNews.DocumentElement.SelectSingleNode("channel").SelectNodes("item");

            string strTextOutput = "";

            foreach (XmlNode xmlNode in childNodeList)
            {
                sqlCommand = new SQLiteCommand("INSERT INTO News(Title, Link, Description, PubDate)" +
                    "VALUES (@title, @link, @description, @pubDate)", sqlDataBase);

                string title = xmlNode.SelectSingleNode("title").InnerText;
                string link = xmlNode.SelectSingleNode("link").InnerText;
                string description = xmlNode.SelectSingleNode("description").InnerText;
                string pubDate = xmlNode.SelectSingleNode("pubDate").InnerText;

                sqlCommand.Parameters.AddWithValue("@title", title);
                sqlCommand.Parameters.AddWithValue("@link", link);
                sqlCommand.Parameters.AddWithValue("@description", description);
                sqlCommand.Parameters.AddWithValue("@pubDate", pubDate);

                strTextOutput = strTextOutput.Insert(strTextOutput.Length, title + "\n" + "\n"
                    + pubDate + "\n" + "\n" + description + "\n" + "\n" + link + "\n" + "\n" + "\n" + "\n" + "\n");

                sqlCommand.ExecuteNonQuery();
            }

            RichTextBox_DataBase.Text = strTextOutput;

            sqlDataBase.Close();
            sqlDataBase.Dispose();
        }

        private void Button_ReadDB_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlDataBase = new SQLiteConnection("Data Source = dataBase.db"); ;
            SQLiteCommand sqlCommand = new SQLiteCommand("SELECT * FROM News", sqlDataBase); ;
            SQLiteDataReader sqlReader;

            sqlDataBase.Open();
            sqlReader = sqlCommand.ExecuteReader();

            string strTextOutput = "";

            foreach (DbDataRecord item in sqlReader)
            {
                string title = item["Title"].ToString();
                string pubDate = item["PubDate"].ToString();
                string link = item["Link"].ToString();
                string description = item["Description"].ToString();

                strTextOutput = strTextOutput.Insert(strTextOutput.Length, title + "\n" + "\n"
                    + pubDate + "\n" + "\n" + description + "\n" + "\n" + link + "\n" + "\n" + "\n" + "\n" + "\n");
            }

            RichTextBox_DataBase.Text = strTextOutput;

            sqlDataBase.Close();
            sqlDataBase.Dispose();
        }

        private void RichTextBox_XML_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox_News_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox_DataBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_XMLCode_Click(object sender, EventArgs e)
        {

        }

        private void Label_XMLToText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
