using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace postproc
{
    [DataContract]
    internal class CA
    {
        [DataMember]
        int ca_pid = -1;
        [DataMember]
        int ca_system_id = -1;
        [DataMember]
        byte[] ca_private_bytes = new byte[0];

        public int Pid
        {
            get
            {
                return this.ca_pid;
            }
            set
            {
                this.ca_pid = value;
            }
        }
        public int SystemId
        {
            get
            {
                return this.ca_system_id;
            }
            set
            {
                this.ca_system_id = value;
            }
        }
        public byte[] PrivateBytes
        {
            get
            {
                return this.ca_private_bytes;
            }
            set
            {
                this.ca_private_bytes = value;
            }
        }
    }

    [DataContract]
    internal class Stream
    {
        [DataMember]
        int type = -1;
        [DataMember]
        string type2 = "";
        [DataMember]
        int pid = -1;
        [DataMember]
        List<CA> ca_list = new List<CA>();

        public int Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public string Type2
        {
            get
            {
                return this.type2;
            }
            set
            {
                this.type2 = value;
            }
        }
        public int Pid
        {
            get
            {
                return this.pid;
            }
            set
            {
                this.pid = value;
            }
        }
        public List<CA> CAList
        {
            get
            {
                return this.ca_list;
            }
            set
            {
                this.ca_list = value;
            }
        }
    }

    [DataContract]
    internal class Service
    {
        [DataMember]
        int lcn=-1;
        [DataMember]
        bool freecamode = false;
        [DataMember]
        int type = -1;
        [DataMember]
        int pcr = -1;
        [DataMember]
        int pmt = -1;
        [DataMember]
        int sid = -1;
        [DataMember]
        int tsid = -1;
        [DataMember]
        int nid = -1;
        [DataMember]
        int onid = -1;
        [DataMember]
        string network_name = "";
        [DataMember]
        string network_type = "";
        [DataMember]
        string provider = "";
        [DataMember]
        string name = "";
        [DataMember]
        List<Stream> streams = new List<Stream>();
        [DataMember]
        List<CA> ca_list = new List<CA>();

        public int Lcn
        {
            get
            {
                return this.lcn;
            }
            set
            {
                this.lcn = value;
            }
        }
        public bool FreeCaMode
        {
            get
            {
                return this.freecamode;
            }
            set
            {
                this.freecamode = value;
            }
        }
        public int Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public int Pcr
        {
            get
            {
                return this.pcr;
            }
            set
            {
                this.pcr = value;
            }
        }
        public int Pmt
        {
            get
            {
                return this.pmt;
            }
            set
            {
                this.pmt = value;
            }
        }
        public int Sid
        {
            get
            {
                return this.sid;
            }
            set
            {
                this.sid = value;
            }
        }
        public int Tsid
        {
            get
            {
                return this.tsid;
            }
            set
            {
                this.tsid = value;
            }
        }
        public int Nid
        {
            get
            {
                return this.nid;
            }
            set
            {
                this.nid = value;
            }
        }
        public int Onid
        {
            get
            {
                return this.onid;
            }
            set
            {
                this.onid = value;
            }
        }
        public string NetworkName
        {
            get
            {
                return this.network_name;
            }
            set
            {
                this.network_name = value;
            }
        }
        public string NetworkType
        {
            get
            {
                return this.network_type;
            }
            set
            {
                this.network_type = value;
            }
        }
        public string Provider
        {
            get
            {
                return this.provider;
            }
            set
            {
                this.provider = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public List<Stream> Streams
        {
            get
            {
                return this.streams;
            }
            set
            {
                this.streams = value;
            }
        }
        public List<CA> CAList
        {
            get
            {
                return this.ca_list;
            }
            set
            {
                this.ca_list = value;
            }
        }
    }

    [DataContract]
    internal class ServiceDVBS : Service
    {
        [DataMember]
        int roll_off = -1;
        [DataMember]
        int modulation_type = -1;
        [DataMember]
        int modulation_system = -1;
        [DataMember]
        string fec = "";
        [DataMember]
        int symbolrate = -1;
        [DataMember]
        string polarity = "";
        [DataMember]
        int frequency = -1;
        [DataMember]
        string position = "";

        public int RollOff
        {
            get
            {
                return this.roll_off;
            }
            set
            {
                this.roll_off = value;
            }
        }
        public int ModulationType
        {
            get
            {
                return this.modulation_type;
            }
            set
            {
                this.modulation_type = value;
            }
        }
        public int ModulationSystem
        {
            get
            {
                return this.modulation_system;
            }
            set
            {
                this.modulation_system = value;
            }
        }
        public string Fec
        {
            get
            {
                return this.fec;
            }
            set
            {
                this.fec = value;
            }
        }
        public int Symbolrate
        {
            get
            {
                return this.symbolrate;
            }
            set
            {
                this.symbolrate = value;
            }
        }
        public string Polarity
        {
            get
            {
                return this.polarity;
            }
            set
            {
                this.polarity = value;
            }
        }
        public int Frequency
        {
            get
            {
                return this.frequency;
            }
            set
            {
                this.frequency = value;
            }
        }
        public string Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }
    }

    [DataContract]
    internal class ServiceDVBT : Service
    {
        [DataMember]
        int frequency = -1;

        public int Frequency
        {
            get
            {
                return this.frequency;
            }
            set
            {
                this.frequency = value;
            }
        }
    }

    [DataContract]
    internal class ServiceDVBC : Service
    {
        [DataMember]
        int frequency = -1;

        public int Frequency
        {
            get
            {
                return this.frequency;
            }
            set
            {
                this.frequency = value;
            }
        }
    }
}
