using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Runtime.Serialization.Json;

namespace postproc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            using (System.IO.Stream f = new FileStream(this.textBoxFile.Text, FileMode.Open))
            {
                XmlReader reader = new XmlTextReader(f);
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);

                string json = "";


                if ((string)this.comboBoxNetworkType.SelectedItem == "DVB-S")
                {
                    List<ServiceDVBS> servicelist = new System.Collections.Generic.List<ServiceDVBS>();
                    foreach (var service in doc["services"].ChildNodes)
                    {
                        ServiceDVBS s = new ServiceDVBS();
                        ExtractService((XmlNode)service, s);
                        servicelist.Add(s);
                    }
                    json = CreateJSONString(servicelist);
                }
                else if ((string)this.comboBoxNetworkType.SelectedItem == "DVB-T")
                {
                    List<ServiceDVBT> servicelist = new System.Collections.Generic.List<ServiceDVBT>();
                    foreach (var service in doc["services"].ChildNodes)
                    {
                        ServiceDVBT s = new ServiceDVBT();
                        ExtractService((XmlNode)service, s);
                        servicelist.Add(s);
                    }
                    json = CreateJSONString(servicelist);
                }
                else if ((string)this.comboBoxNetworkType.SelectedItem == "DVB-C")
                {
                    List<ServiceDVBC> servicelist = new System.Collections.Generic.List<ServiceDVBC>();
                    foreach (var service in doc["services"].ChildNodes)
                    {
                        ServiceDVBC s = new ServiceDVBC();
                        ExtractService((XmlNode)service, s);
                        servicelist.Add(s);
                    }
                    json = CreateJSONString(servicelist);
                }
                else
                {
                    throw new Exception(string.Format("Unexpected network type '{0}'", (string)this.comboBoxNetworkType.SelectedItem));
                }

                //Trace.WriteLine(json);

                this.textBoxStatusCode.Text = "";
                this.textBoxResponseBody.Text = "";
                SendHTTPRequest(json);
            }
        }

        private void SendHTTPRequest(string body)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.textBoxURL.Text);

            try
            {
                request.Method = Properties.Settings.Default.Method;
                request.ContentType = this.textBoxContentType.Text;

                UTF8Encoding encoding1 = new UTF8Encoding();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] byte1 = encoding1.GetBytes(body);
                request.ContentLength = byte1.Length;

                System.IO.Stream stream = request.GetRequestStream();
                stream.Write(byte1, 0, byte1.Length);
                stream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string status = string.Format("{0} {1}", Convert.ToInt32(response.StatusCode), response.StatusDescription);
                //Trace.WriteLine(status);
                this.textBoxStatusCode.Text = status;

                StreamReader reader = new StreamReader(response.GetResponseStream());
                this.textBoxResponseBody.Text = reader.ReadToEnd();

            }
            catch (WebException e)
            {
                string status = string.Format("{0} {1}", Convert.ToInt32(((HttpWebResponse)e.Response).StatusCode), ((HttpWebResponse)e.Response).StatusDescription);
                Trace.WriteLine(status);
                this.textBoxStatusCode.Text = status;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                this.textBoxResponseBody.Text = reader.ReadToEnd();
            }
        }

        private void ExtractService(XmlNode l, Service s)
        {
            s.Name = l.Attributes["name"].Value;
            s.FreeCaMode = l.Attributes["free_ca_mode"].Value=="1";
            s.Type = Convert.ToInt32(l.Attributes["type"].Value);
            s.Pcr = Convert.ToInt32(l.Attributes["pcr"].Value);
            s.Pmt = Convert.ToInt32(l.Attributes["pmt"].Value);
            s.Sid = Convert.ToInt32(l.Attributes["sid"].Value);
            s.Tsid = Convert.ToInt32(l.Attributes["tsid"].Value);
            s.Nid = Convert.ToInt32(l.Attributes["nid"].Value);
            s.Onid = Convert.ToInt32(l.Attributes["onid"].Value);
            s.Provider = l.Attributes["provider"].Value;

            foreach (var item in l["ca_list"].ChildNodes)
            {
                CA  ca = new CA();
                ExtractCA((XmlNode)item, ca);
                s.CAList.Add(ca);
            }

            foreach (var item in l["streams"])
            {
                Stream stream = new Stream();
                ExtractStream((XmlNode)item, stream);
                s.Streams.Add(stream);
            }
        }

        private void ExtractService(XmlNode l, ServiceDVBS s)
        {
            ExtractService(l, (Service)s);
            s.RollOff = Convert.ToInt32(l.Attributes["roll_off"].Value);
            s.ModulationType = Convert.ToInt32(l.Attributes["modulation_type"].Value);
            s.ModulationSystem = Convert.ToInt32(l.Attributes["modulation_system"].Value);
            s.Fec = l.Attributes["fec"].Value;
            s.Symbolrate = Convert.ToInt32(l.Attributes["symbolrate"].Value);
            s.Polarity = l.Attributes["polarity"].Value;
            s.Frequency = Convert.ToInt32(l.Attributes["frequency"].Value);
            s.Position = l.Attributes["position"].Value;
        }

        private void ExtractService(XmlNode l, ServiceDVBT s)
        {
            ExtractService(l, (Service)s);
            s.Frequency = Convert.ToInt32(l.Attributes["frequency"].Value);
        }

        private void ExtractService(XmlNode l, ServiceDVBC s)
        {
            ExtractService(l, (Service)s);
            s.Frequency = Convert.ToInt32(l.Attributes["frequency"].Value);
        }

        private void ExtractCA(XmlNode l, CA ca)
        {
            ca.Pid = Convert.ToInt32(l.Attributes["CA_PID"].Value);
            ca.SystemId = Convert.ToInt32(l.Attributes["CA_system_ID"].Value);

            //TODO: ca private_bytes
        }

        private void ExtractStream(XmlNode l, Stream s)
        {
            s.Type = Convert.ToInt32(l.Attributes["type"].Value);
            s.Type2 = l.Attributes["type2"].Value;
            s.Pid = Convert.ToInt32(l.Attributes["pid"].Value);

            foreach (var item in l["ca_list"].ChildNodes)
            {
                CA ca = new CA();
                ExtractCA((XmlNode)item, ca);
                s.CAList.Add(ca);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = Properties.Settings.Default.ServiceFile;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.textBoxFile.Text = dlg.FileName;
                Properties.Settings.Default.ServiceFile = dlg.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBoxFile.Text = Properties.Settings.Default.ServiceFile;
            this.textBoxURL.Text = Properties.Settings.Default.URL;
            this.textBoxMethod.Text = Properties.Settings.Default.Method;
            this.comboBoxNetworkType.SelectedItem = Properties.Settings.Default.NetworkType;
            this.textBoxContentType.Text = Properties.Settings.Default.ContentType;
           
        }

        private void textBoxURL_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.URL = this.textBoxURL.Text;
            Properties.Settings.Default.Save();
        }

        private string CreateJSONString(List<ServiceDVBS> s)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<ServiceDVBS>));
                ser.WriteObject(stream, s);
                stream.Position = 0;
                StreamReader r = new StreamReader(stream);
                return r.ReadToEnd();
            }
        }

        private string CreateJSONString(List<ServiceDVBT> s)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<ServiceDVBT>));
                ser.WriteObject(stream, s);
                stream.Position = 0;
                StreamReader r = new StreamReader(stream);
                return r.ReadToEnd();
            }
        }

        private string CreateJSONString(List<ServiceDVBC> s)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<ServiceDVBC>));
                ser.WriteObject(stream, s);
                stream.Position = 0;
                StreamReader r = new StreamReader(stream);
                return r.ReadToEnd();
            }
        }

        private void textBoxMethod_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Method = this.textBoxMethod.Text;
            Properties.Settings.Default.Save();
        }

        private void comboBoxNetworkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NetworkType = (string)this.comboBoxNetworkType.SelectedItem;
            Properties.Settings.Default.Save();
        }

        private void textBoxContentType_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ContentType = this.textBoxContentType.Text;
            Properties.Settings.Default.Save();
        }
    }
}
