// SnapshotSummary.cs
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
    #region SnapshotSummary
    public class SnapshotSummary: BaseType
    {
        #region members

        //      C# -> UnmanagedSnapshotType? SnapshotType
        // GraphQL -> snapshotType: UnmanagedSnapshotType! (enum)
        [JsonProperty("snapshotType")]
        public UnmanagedSnapshotType? SnapshotType { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        [JsonProperty("isCustomRetentionApplied")]
        public System.Boolean? IsCustomRetentionApplied { get; set; }

        //      C# -> System.Boolean? IsRetentionLockApplied
        // GraphQL -> isRetentionLockApplied: Boolean! (scalar)
        [JsonProperty("isRetentionLockApplied")]
        public System.Boolean? IsRetentionLockApplied { get; set; }

        //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
        [JsonProperty("snapshotRetentionInfo")]
        public SnapshotRetentionInfo? SnapshotRetentionInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotSummary";
    }

    public SnapshotSummary Set(
        UnmanagedSnapshotType? SnapshotType = null,
        DateTime? Date = null,
        System.String? Id = null,
        System.Boolean? IsCustomRetentionApplied = null,
        System.Boolean? IsRetentionLockApplied = null,
        SnapshotRetentionInfo? SnapshotRetentionInfo = null
    ) 
    {
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsCustomRetentionApplied != null ) {
            this.IsCustomRetentionApplied = IsCustomRetentionApplied;
        }
        if ( IsRetentionLockApplied != null ) {
            this.IsRetentionLockApplied = IsRetentionLockApplied;
        }
        if ( SnapshotRetentionInfo != null ) {
            this.SnapshotRetentionInfo = SnapshotRetentionInfo;
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
        //      C# -> UnmanagedSnapshotType? SnapshotType
        // GraphQL -> snapshotType: UnmanagedSnapshotType! (enum)
        if (this.SnapshotType != null) {
            s += ind + "snapshotType\n" ;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date != null) {
            s += ind + "date\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        if (this.IsCustomRetentionApplied != null) {
            s += ind + "isCustomRetentionApplied\n" ;
        }
        //      C# -> System.Boolean? IsRetentionLockApplied
        // GraphQL -> isRetentionLockApplied: Boolean! (scalar)
        if (this.IsRetentionLockApplied != null) {
            s += ind + "isRetentionLockApplied\n" ;
        }
        //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
        if (this.SnapshotRetentionInfo != null) {
            var fspec = this.SnapshotRetentionInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotRetentionInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> UnmanagedSnapshotType? SnapshotType
        // GraphQL -> snapshotType: UnmanagedSnapshotType! (enum)
        if (this.SnapshotType == null && Exploration.Includes(parent + ".snapshotType", true))
        {
            this.SnapshotType = new UnmanagedSnapshotType();
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date == null && Exploration.Includes(parent + ".date", true))
        {
            this.Date = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        if (this.IsCustomRetentionApplied == null && Exploration.Includes(parent + ".isCustomRetentionApplied", true))
        {
            this.IsCustomRetentionApplied = true;
        }
        //      C# -> System.Boolean? IsRetentionLockApplied
        // GraphQL -> isRetentionLockApplied: Boolean! (scalar)
        if (this.IsRetentionLockApplied == null && Exploration.Includes(parent + ".isRetentionLockApplied", true))
        {
            this.IsRetentionLockApplied = true;
        }
        //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
        if (this.SnapshotRetentionInfo == null && Exploration.Includes(parent + ".snapshotRetentionInfo"))
        {
            this.SnapshotRetentionInfo = new SnapshotRetentionInfo();
            this.SnapshotRetentionInfo.ApplyExploratoryFieldSpec(parent + ".snapshotRetentionInfo");
        }
    }


    #endregion

    } // class SnapshotSummary
    
    #endregion

    public static class ListSnapshotSummaryExtensions
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
            this List<SnapshotSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types