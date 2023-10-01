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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> UnmanagedSnapshotType? SnapshotType
        // GraphQL -> snapshotType: UnmanagedSnapshotType! (enum)
        if (this.SnapshotType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotType\n" ;
            } else {
                s += ind + "snapshotType\n" ;
            }
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date != null) {
            if (conf.Flat) {
                s += conf.Prefix + "date\n" ;
            } else {
                s += ind + "date\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        if (this.IsCustomRetentionApplied != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCustomRetentionApplied\n" ;
            } else {
                s += ind + "isCustomRetentionApplied\n" ;
            }
        }
        //      C# -> System.Boolean? IsRetentionLockApplied
        // GraphQL -> isRetentionLockApplied: Boolean! (scalar)
        if (this.IsRetentionLockApplied != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRetentionLockApplied\n" ;
            } else {
                s += ind + "isRetentionLockApplied\n" ;
            }
        }
        //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
        if (this.SnapshotRetentionInfo != null) {
            var fspec = this.SnapshotRetentionInfo.AsFieldSpec(conf.Child("snapshotRetentionInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotRetentionInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UnmanagedSnapshotType? SnapshotType
        // GraphQL -> snapshotType: UnmanagedSnapshotType! (enum)
        if (ec.Includes("snapshotType",true))
        {
            if(this.SnapshotType == null) {

                this.SnapshotType = new UnmanagedSnapshotType();

            } else {


            }
        }
        else if (this.SnapshotType != null && ec.Excludes("snapshotType",true))
        {
            this.SnapshotType = null;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (ec.Includes("date",true))
        {
            if(this.Date == null) {

                this.Date = new DateTime();

            } else {


            }
        }
        else if (this.Date != null && ec.Excludes("date",true))
        {
            this.Date = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsCustomRetentionApplied
        // GraphQL -> isCustomRetentionApplied: Boolean! (scalar)
        if (ec.Includes("isCustomRetentionApplied",true))
        {
            if(this.IsCustomRetentionApplied == null) {

                this.IsCustomRetentionApplied = true;

            } else {


            }
        }
        else if (this.IsCustomRetentionApplied != null && ec.Excludes("isCustomRetentionApplied",true))
        {
            this.IsCustomRetentionApplied = null;
        }
        //      C# -> System.Boolean? IsRetentionLockApplied
        // GraphQL -> isRetentionLockApplied: Boolean! (scalar)
        if (ec.Includes("isRetentionLockApplied",true))
        {
            if(this.IsRetentionLockApplied == null) {

                this.IsRetentionLockApplied = true;

            } else {


            }
        }
        else if (this.IsRetentionLockApplied != null && ec.Excludes("isRetentionLockApplied",true))
        {
            this.IsRetentionLockApplied = null;
        }
        //      C# -> SnapshotRetentionInfo? SnapshotRetentionInfo
        // GraphQL -> snapshotRetentionInfo: SnapshotRetentionInfo (type)
        if (ec.Includes("snapshotRetentionInfo",false))
        {
            if(this.SnapshotRetentionInfo == null) {

                this.SnapshotRetentionInfo = new SnapshotRetentionInfo();
                this.SnapshotRetentionInfo.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRetentionInfo"));

            } else {

                this.SnapshotRetentionInfo.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRetentionInfo"));

            }
        }
        else if (this.SnapshotRetentionInfo != null && ec.Excludes("snapshotRetentionInfo",false))
        {
            this.SnapshotRetentionInfo = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SnapshotSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types