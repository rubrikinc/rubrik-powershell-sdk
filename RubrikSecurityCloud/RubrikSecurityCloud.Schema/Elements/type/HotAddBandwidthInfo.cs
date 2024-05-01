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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "HotAddBandwidthInfo";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Int32? ExportLimit
        // GraphQL -> exportLimit: Int! (scalar)
        if (this.ExportLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exportLimit\n" ;
            } else {
                s += ind + "exportLimit\n" ;
            }
        }
        //      C# -> System.Int32? IngestLimit
        // GraphQL -> ingestLimit: Int! (scalar)
        if (this.IngestLimit != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ingestLimit\n" ;
            } else {
                s += ind + "ingestLimit\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? ExportLimit
        // GraphQL -> exportLimit: Int! (scalar)
        if (ec.Includes("exportLimit",true))
        {
            if(this.ExportLimit == null) {

                this.ExportLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.ExportLimit != null && ec.Excludes("exportLimit",true))
        {
            this.ExportLimit = null;
        }
        //      C# -> System.Int32? IngestLimit
        // GraphQL -> ingestLimit: Int! (scalar)
        if (ec.Includes("ingestLimit",true))
        {
            if(this.IngestLimit == null) {

                this.IngestLimit = Int32.MinValue;

            } else {


            }
        }
        else if (this.IngestLimit != null && ec.Excludes("ingestLimit",true))
        {
            this.IngestLimit = null;
        }
    }


    #endregion

    } // class HotAddBandwidthInfo
    
    #endregion

    public static class ListHotAddBandwidthInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<HotAddBandwidthInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HotAddBandwidthInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HotAddBandwidthInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HotAddBandwidthInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HotAddBandwidthInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types