// NcdObjectProtectionStatus.cs
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
    #region NcdObjectProtectionStatus
    public class NcdObjectProtectionStatus: BaseType
    {
        #region members

        //      C# -> System.Int64? AverageFileSize
        // GraphQL -> averageFileSize: Long! (scalar)
        [JsonProperty("averageFileSize")]
        public System.Int64? AverageFileSize { get; set; }

        //      C# -> System.Int64? Throughput
        // GraphQL -> throughput: Long! (scalar)
        [JsonProperty("throughput")]
        public System.Int64? Throughput { get; set; }

        //      C# -> NcdFilesObjectProtectionStatusData? Files
        // GraphQL -> files: NcdFilesObjectProtectionStatusData (type)
        [JsonProperty("files")]
        public NcdFilesObjectProtectionStatusData? Files { get; set; }

        //      C# -> NcdSharesObjectProtectionStatusData? Shares
        // GraphQL -> shares: NcdSharesObjectProtectionStatusData (type)
        [JsonProperty("shares")]
        public NcdSharesObjectProtectionStatusData? Shares { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdObjectProtectionStatus";
    }

    public NcdObjectProtectionStatus Set(
        System.Int64? AverageFileSize = null,
        System.Int64? Throughput = null,
        NcdFilesObjectProtectionStatusData? Files = null,
        NcdSharesObjectProtectionStatusData? Shares = null
    ) 
    {
        if ( AverageFileSize != null ) {
            this.AverageFileSize = AverageFileSize;
        }
        if ( Throughput != null ) {
            this.Throughput = Throughput;
        }
        if ( Files != null ) {
            this.Files = Files;
        }
        if ( Shares != null ) {
            this.Shares = Shares;
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
        //      C# -> System.Int64? AverageFileSize
        // GraphQL -> averageFileSize: Long! (scalar)
        if (this.AverageFileSize != null) {
            s += ind + "averageFileSize\n" ;
        }
        //      C# -> System.Int64? Throughput
        // GraphQL -> throughput: Long! (scalar)
        if (this.Throughput != null) {
            s += ind + "throughput\n" ;
        }
        //      C# -> NcdFilesObjectProtectionStatusData? Files
        // GraphQL -> files: NcdFilesObjectProtectionStatusData (type)
        if (this.Files != null) {
            var fspec = this.Files.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "files {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> NcdSharesObjectProtectionStatusData? Shares
        // GraphQL -> shares: NcdSharesObjectProtectionStatusData (type)
        if (this.Shares != null) {
            var fspec = this.Shares.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "shares {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? AverageFileSize
        // GraphQL -> averageFileSize: Long! (scalar)
        if (this.AverageFileSize == null && ec.Includes("averageFileSize",true))
        {
            this.AverageFileSize = new System.Int64();
        }
        //      C# -> System.Int64? Throughput
        // GraphQL -> throughput: Long! (scalar)
        if (this.Throughput == null && ec.Includes("throughput",true))
        {
            this.Throughput = new System.Int64();
        }
        //      C# -> NcdFilesObjectProtectionStatusData? Files
        // GraphQL -> files: NcdFilesObjectProtectionStatusData (type)
        if (this.Files == null && ec.Includes("files",false))
        {
            this.Files = new NcdFilesObjectProtectionStatusData();
            this.Files.ApplyExploratoryFieldSpec(ec.NewChild("files"));
        }
        //      C# -> NcdSharesObjectProtectionStatusData? Shares
        // GraphQL -> shares: NcdSharesObjectProtectionStatusData (type)
        if (this.Shares == null && ec.Includes("shares",false))
        {
            this.Shares = new NcdSharesObjectProtectionStatusData();
            this.Shares.ApplyExploratoryFieldSpec(ec.NewChild("shares"));
        }
    }


    #endregion

    } // class NcdObjectProtectionStatus
    
    #endregion

    public static class ListNcdObjectProtectionStatusExtensions
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
            this List<NcdObjectProtectionStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NcdObjectProtectionStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdObjectProtectionStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NcdObjectProtectionStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types