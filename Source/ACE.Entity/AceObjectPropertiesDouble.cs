﻿using System;
using ACE.Common;
using MySql.Data.MySqlClient;
using ACE.Entity.Enum;

namespace ACE.Entity
{
    [DbTable("ace_object_properties_double")]
    public class AceObjectPropertiesDouble : BaseAceProperty, ICloneable
    {
        private double? _value = 0;
        
        [DbField("dblPropertyId", (int)MySqlDbType.UInt16, IsCriteria = true, Update = false)]
        public new ushort PropertyId { get; set; }

        [DbField("propertyIndex", (int)MySqlDbType.Byte, IsCriteria = true, Update = false)]
        public byte Index { get; set; } = 0;

        [DbField("propertyValue", (int)MySqlDbType.Double)]
        public double? PropertyValue
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                IsDirty = true;
            }
        }

        public override AceObjectPropertyType PropertyType
        { get { return AceObjectPropertyType.PropertyDouble; } }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
