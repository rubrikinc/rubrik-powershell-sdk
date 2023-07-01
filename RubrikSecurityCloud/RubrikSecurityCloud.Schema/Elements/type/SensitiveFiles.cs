// SensitiveFiles.cs
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
    #region SensitiveFiles
    public class SensitiveFiles: BaseType
    {
        #region members

        //      C# -> SummaryCount? HighRiskFileCount
        // GraphQL -> highRiskFileCount: SummaryCount (type)
        [JsonProperty("highRiskFileCount")]
        public SummaryCount? HighRiskFileCount { get; set; }

        //      C# -> SummaryCount? LowRiskFileCount
        // GraphQL -> lowRiskFileCount: SummaryCount (type)
        [JsonProperty("lowRiskFileCount")]
        public SummaryCount? LowRiskFileCount { get; set; }

        //      C# -> SummaryCount? MediumRiskFileCount
        // GraphQL -> mediumRiskFileCount: SummaryCount (type)
        [JsonProperty("mediumRiskFileCount")]
        public SummaryCount? MediumRiskFileCount { get; set; }

        //      C# -> SummaryCount? TotalFileCount
        // GraphQL -> totalFileCount: SummaryCount (type)
        [JsonProperty("totalFileCount")]
        public SummaryCount? TotalFileCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SensitiveFiles";
    }

    public SensitiveFiles Set(
        SummaryCount? HighRiskFileCount = null,
        SummaryCount? LowRiskFileCount = null,
        SummaryCount? MediumRiskFileCount = null,
        SummaryCount? TotalFileCount = null
    ) 
    {
        if ( HighRiskFileCount != null ) {
            this.HighRiskFileCount = HighRiskFileCount;
        }
        if ( LowRiskFileCount != null ) {
            this.LowRiskFileCount = LowRiskFileCount;
        }
        if ( MediumRiskFileCount != null ) {
            this.MediumRiskFileCount = MediumRiskFileCount;
        }
        if ( TotalFileCount != null ) {
            this.TotalFileCount = TotalFileCount;
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
        //      C# -> SummaryCount? HighRiskFileCount
        // GraphQL -> highRiskFileCount: SummaryCount (type)
        if (this.HighRiskFileCount != null) {
            var fspec = this.HighRiskFileCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "highRiskFileCount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryCount? LowRiskFileCount
        // GraphQL -> lowRiskFileCount: SummaryCount (type)
        if (this.LowRiskFileCount != null) {
            var fspec = this.LowRiskFileCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lowRiskFileCount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryCount? MediumRiskFileCount
        // GraphQL -> mediumRiskFileCount: SummaryCount (type)
        if (this.MediumRiskFileCount != null) {
            var fspec = this.MediumRiskFileCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mediumRiskFileCount {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SummaryCount? TotalFileCount
        // GraphQL -> totalFileCount: SummaryCount (type)
        if (this.TotalFileCount != null) {
            var fspec = this.TotalFileCount.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "totalFileCount {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SummaryCount? HighRiskFileCount
        // GraphQL -> highRiskFileCount: SummaryCount (type)
        if (this.HighRiskFileCount == null && Exploration.Includes(parent + ".highRiskFileCount"))
        {
            this.HighRiskFileCount = new SummaryCount();
            this.HighRiskFileCount.ApplyExploratoryFieldSpec(parent + ".highRiskFileCount");
        }
        //      C# -> SummaryCount? LowRiskFileCount
        // GraphQL -> lowRiskFileCount: SummaryCount (type)
        if (this.LowRiskFileCount == null && Exploration.Includes(parent + ".lowRiskFileCount"))
        {
            this.LowRiskFileCount = new SummaryCount();
            this.LowRiskFileCount.ApplyExploratoryFieldSpec(parent + ".lowRiskFileCount");
        }
        //      C# -> SummaryCount? MediumRiskFileCount
        // GraphQL -> mediumRiskFileCount: SummaryCount (type)
        if (this.MediumRiskFileCount == null && Exploration.Includes(parent + ".mediumRiskFileCount"))
        {
            this.MediumRiskFileCount = new SummaryCount();
            this.MediumRiskFileCount.ApplyExploratoryFieldSpec(parent + ".mediumRiskFileCount");
        }
        //      C# -> SummaryCount? TotalFileCount
        // GraphQL -> totalFileCount: SummaryCount (type)
        if (this.TotalFileCount == null && Exploration.Includes(parent + ".totalFileCount"))
        {
            this.TotalFileCount = new SummaryCount();
            this.TotalFileCount.ApplyExploratoryFieldSpec(parent + ".totalFileCount");
        }
    }


    #endregion

    } // class SensitiveFiles
    
    #endregion

    public static class ListSensitiveFilesExtensions
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
            this List<SensitiveFiles> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SensitiveFiles> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SensitiveFiles());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types