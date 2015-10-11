﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SyncthingApi.Data
{
    [DataContract]
    public class DiscoveryConnectionData
    {
        [DataMember(Name = "Address", IsRequired = true, EmitDefaultValue = false)]
        private string address;

        public string Address
        {
            get { return this.address; }
        }

        [DataMember(Name = "Seen", IsRequired = true, EmitDefaultValue = false)]
        private string seen;

        public string Seen
        {
            get { return this.seen; }
        }
    }
}
