using JSON.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           List<EmploeeModel> _emplooeList = new List<EmploeeModel> { 

            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            new EmploeeModel {Id = 101, FirstName = "Morteza", LastName = "Chegeni"},
            };
        private void btnSerializeToJson_Click(object sender, EventArgs e)
        {
           string json = Newtonsoft.Json.JsonConvert.SerializeObject(_emplooeList);
            var filePath = Application.StartupPath + "\\" + "data.json";
            File.WriteAllText(filePath, json);  
            txtSerializeOutput.Text = json;
        }

        private void btnDeserializeToObject_Click(object sender, EventArgs e)
        {
            var filePath = Application.StartupPath + "\\" + "data.json";
            var data = File.ReadAllText(filePath);
            List<EmploeeModel> emploeeList = JsonConvert.DeserializeObject<List<EmploeeModel>>(data);
        }

        private void btnSerializeToXMl_Click(object sender, EventArgs e)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(List<EmploeeModel>));
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, _emplooeList);
                    xml = sww.ToString(); // Your XML
                }
            }

            var filePath = Application.StartupPath + "\\" + "data.xml";
            File.WriteAllText(filePath, xml);
            txtSerializeOutput.Text = xml;
        }

        private void btnDeserializeFromXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<EmploeeModel>));

            var filePath = Application.StartupPath + "\\" + "data.xml";
            StreamReader reader = new StreamReader(filePath);
            var result = (List<EmploeeModel>)serializer.Deserialize(reader);

            reader.Close(); 
          

        }

        private void btnKeyboardEvents_Click(object sender, EventArgs e)
        {
            var frm = new frmKeyboardEvent();
            frm.ShowDialog();
        }
    }
}
