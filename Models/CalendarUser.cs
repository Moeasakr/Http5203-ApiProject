using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiProjectV2.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class rsp
    {

        private rspUser userField;

        private string statField;

        /// <remarks/>
        public rspUser user
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stat
        {
            get
            {
                return this.statField;
            }
            set
            {
                this.statField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rspUser
    {

        private uint idField;

        private byte facebookIdField;

        private string firstNameField;

        private string lastNameField;

        private object avatarField;

        private object statusField;

        private object bioField;

        private string dateFormatField;

        private string timeZoneField;

        private System.DateTime createDateField;

        private byte startDayField;

        private byte use24HourClockField;

        /// <remarks/>
        public uint id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public byte facebookId
        {
            get
            {
                return this.facebookIdField;
            }
            set
            {
                this.facebookIdField = value;
            }
        }

        /// <remarks/>
        public string firstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string lastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        public object avatar
        {
            get
            {
                return this.avatarField;
            }
            set
            {
                this.avatarField = value;
            }
        }

        /// <remarks/>
        public object status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public object bio
        {
            get
            {
                return this.bioField;
            }
            set
            {
                this.bioField = value;
            }
        }

        /// <remarks/>
        public string dateFormat
        {
            get
            {
                return this.dateFormatField;
            }
            set
            {
                this.dateFormatField = value;
            }
        }

        /// <remarks/>
        public string timeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime createDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }

        /// <remarks/>
        public byte startDay
        {
            get
            {
                return this.startDayField;
            }
            set
            {
                this.startDayField = value;
            }
        }

        /// <remarks/>
        public byte use24HourClock
        {
            get
            {
                return this.use24HourClockField;
            }
            set
            {
                this.use24HourClockField = value;
            }
        }
    }



}