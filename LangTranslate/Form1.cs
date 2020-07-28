using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestSharp;
using Newtonsoft.Json;
using System.Collections;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace LangTranslate
{
    public partial class Form1 : Form
    {
        //GUI Move
        int mov;
        int movX;
        int movY;

        //Contains list of all language id
        private List<string> AvailLangs;

        public class DetectResult
        {
            public string Language { get; set; }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void txtSrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDestlang_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboAvailableLangs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string route = "/translate?api-version=3.0&to=";

            Object[] body = new Object[] { new { Text = txtSrc.Text } };
            var requestBody = JsonConvert.SerializeObject(body);


            var Client = new RestClient(AppData.endpoint_var);
            var Request = new RestRequest(route + AvailLangs[comboAvailableLangs.SelectedIndex] , Method.POST);
            //Passing the api key
            Request.AddHeader("Ocp-Apim-Subscription-Key", AppData.key_var);
            //passing the region
            Request.AddHeader("Ocp-Apim-Subscription-Region", AppData.region);
            //passing the data as the body
            Request.AddParameter("application/json", requestBody, ParameterType.RequestBody);

            //Get the raw Json response
            var Response = Client.Execute(Request);
            //Pasrsing the text from the raw response
            string Response_Raw = Response.Content.Trim().Trim('[', ']');
            Console.WriteLine(Response_Raw);

            string StartFrom = "text\":\"";
            string EndTo = "\",\"to\":";
            int pFrom = Response_Raw.IndexOf(StartFrom) + StartFrom.Length;
            int pTo = Response_Raw.LastIndexOf(EndTo);

            String result = Response_Raw.Substring(pFrom, pTo - pFrom);
            txtDestlang.Text = result;
        }

        private void btnDetectSrcLang_Click(object sender, EventArgs e)
        {
            //detect language
            string route = "/detect?api-version=3.0";
            //change the text to jason raw data with [] brackets as per
            System.Object[] body = new System.Object[] { new { Text = txtSrc.Text } };
            var requestBody = JsonConvert.SerializeObject(body);


            var Client = new RestClient(AppData.endpoint_var);
            var Request = new RestRequest(route, Method.POST);
            //Passing the api key
            Request.AddHeader("Ocp-Apim-Subscription-Key", AppData.key_var);
            //passing the region
            Request.AddHeader("Ocp-Apim-Subscription-Region", AppData.region);
            //passing the data as the body
            Request.AddParameter("application/json", requestBody, ParameterType.RequestBody);

            //Get the raw Json response
            var Response = Client.Execute(Request);
            //The returned data is in array, so
            //Removing the [] from then end and begining
            string Response_Json = Response.Content.Trim().Trim('[', ']');

            var dict = JsonConvert.DeserializeObject<IDictionary>(Response_Json);
            foreach (DictionaryEntry entry in dict)
            {
                if (entry.Key.Equals("language"))
                {
                    //setting value of the source to the detected lang id
                    lblSrcLang.Text = entry.Value.ToString();
                }                
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            //Gets all available Languages for conversion
            string route = "/languages?api-version=3.0";
            var Client = new RestClient(AppData.endpoint_var);
            var Request = new RestRequest(route, Method.GET);
            //Get the raw Json response
            var Response = Client.Execute(Request);
            //Parse the Json and store in dictionary
            var dict = JsonConvert.DeserializeObject<IDictionary>(Response.Content);
            //Adding the Languages to the drop down menu and id to the list
            foreach (DictionaryEntry entry in dict)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);

                if(entry.Key.Equals("translation"))
                {
                    var AC = (JObject)entry.Value;
                    AvailLangs = new List<string>();

                    comboAvailableLangs.Items.Clear();
                    foreach(var LangKey in AC)
                    {
                        if(!LangKey.Equals(lblSrcLang.Text))
                        {
                            var LangName = (JObject)LangKey.Value;
                            foreach(var x in LangName)
                            {
                                if(x.Key=="name")
                                {
                                    //Populating the drop down Menu
                                    comboAvailableLangs.Items.Add(x.Value);
                                }
                            }
                            //Storing the language ids in the list for further use
                            AvailLangs.Add(LangKey.Key);
                        }
                    }
                }
            }

        }

        private void lblSrcLang_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docs.microsoft.com/en-us/azure/cognitive-services/Translator/reference/v3-0-reference");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Set your api key, endpoint and location in the userdata.txt file or the program won't work.");
        }
    }
}
