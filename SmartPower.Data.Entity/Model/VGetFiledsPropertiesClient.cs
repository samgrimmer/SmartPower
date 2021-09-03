using System;
using System.Collections.Generic;

#nullable disable

namespace SmartPower.Data.Entity.Model
{
    public partial class VGetFiledsPropertiesClient
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public int? CharacterMaximumLength { get; set; }
        public string IsNullable { get; set; }
    }
}
