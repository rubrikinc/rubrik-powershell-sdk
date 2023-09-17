// ArchivalStorageUsage.cs
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
    #region ArchivalStorageUsage
    public class ArchivalStorageUsage: BaseType
    {
        #region members

        //      C# -> DateTime? LogTimestamp
        // GraphQL -> logTimestamp: DateTime! (scalar)
        [JsonProperty("logTimestamp")]
        public DateTime? LogTimestamp { get; set; }

        //      C# -> System.Int64? StorageUsage
        // GraphQL -> storageUsage: Long! (scalar)
        [JsonProperty("storageUsage")]
        public System.Int64? StorageUsage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalStorageUsage";
    }

    public ArchivalStorageUsage Set(
        DateTime? LogTimestamp = null,
        System.Int64? StorageUsage = null
    ) 
    {
        if ( LogTimestamp != null ) {
            this.LogTimestamp = LogTimestamp;
        }
        if ( StorageUsage != null ) {
            this.StorageUsage = StorageUsage;
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
        //      C# -> DateTime? LogTimestamp
        // GraphQL -> logTimestamp: DateTime! (scalar)
        if (this.LogTimestamp != null) {
            s += ind + "logTimestamp\n" ;
        }
        //      C# -> System.Int64? StorageUsage
        // GraphQL -> storageUsage: Long! (scalar)
        if (this.StorageUsage != null) {
            s += ind + "storageUsage\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? LogTimestamp
        // GraphQL -> logTimestamp: DateTime! (scalar)
        if (this.LogTimestamp == null && ec.Includes("logTimestamp",true))
        {
            this.LogTimestamp = new DateTime();
        }
        //      C# -> System.Int64? StorageUsage
        // GraphQL -> storageUsage: Long! (scalar)
        if (this.StorageUsage == null && ec.Includes("storageUsage",true))
        {
            this.StorageUsage = new System.Int64();
        }
    }


    #endregion

    } // class ArchivalStorageUsage
    
    #endregion

    public static class ListArchivalStorageUsageExtensions
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
            this List<ArchivalStorageUsage> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalStorageUsage> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalStorageUsage());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalStorageUsage> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types