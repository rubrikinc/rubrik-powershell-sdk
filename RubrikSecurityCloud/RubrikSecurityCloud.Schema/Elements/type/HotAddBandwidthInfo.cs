// HotAddBandwidthInfo.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region HotAddBandwidthInfo
    public class HotAddBandwidthInfo: BaseType
    {
        #region members

        //      C# -> System.Int32? ExportLimit
        // GraphQL -> exportLimit: Int! (scalar)
        [JsonProperty("exportLimit")]
        public System.Int32? ExportLimit { get; set; }

        //      C# -> System.Int32? IngestLimit
        // GraphQL -> ingestLimit: Int! (scalar)
        [JsonProperty("ingestLimit")]
        public System.Int32? IngestLimit { get; set; }


        #endregion

    #region methods

    public HotAddBandwidthInfo Set(
        System.Int32? ExportLimit = null,
        System.Int32? IngestLimit = null
    ) 
    {
        if ( ExportLimit != null ) {
            this.ExportLimit = ExportLimit;
        }
        if ( IngestLimit != null ) {
            this.IngestLimit = IngestLimit;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Int32? ExportLimit
        // GraphQL -> exportLimit: Int! (scalar)
        if (this.ExportLimit != null) {
            s += ind + "exportLimit\n" ;
        }
        //      C# -> System.Int32? IngestLimit
        // GraphQL -> ingestLimit: Int! (scalar)
        if (this.IngestLimit != null) {
            s += ind + "ingestLimit\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? ExportLimit
        // GraphQL -> exportLimit: Int! (scalar)
        if (this.ExportLimit == null && Exploration.Includes(parent + ".exportLimit", true))
        {
            this.ExportLimit = Int32.MinValue;
        }
        //      C# -> System.Int32? IngestLimit
        // GraphQL -> ingestLimit: Int! (scalar)
        if (this.IngestLimit == null && Exploration.Includes(parent + ".ingestLimit", true))
        {
            this.IngestLimit = Int32.MinValue;
        }
    }


    #endregion

    } // class HotAddBandwidthInfo
    
    #endregion

    public static class ListHotAddBandwidthInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<HotAddBandwidthInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HotAddBandwidthInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HotAddBandwidthInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types