// ActiveDirectorySearchVersions.cs
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
    #region ActiveDirectorySearchVersions
    public class ActiveDirectorySearchVersions: BaseType
    {
        #region members

        //      C# -> ActiveDirectoryObjectType? ActiveDirectoryObjectType
        // GraphQL -> activeDirectoryObjectType: ActiveDirectoryObjectType! (enum)
        [JsonProperty("activeDirectoryObjectType")]
        public ActiveDirectoryObjectType? ActiveDirectoryObjectType { get; set; }

        //      C# -> System.String? Dn
        // GraphQL -> dn: String! (scalar)
        [JsonProperty("dn")]
        public System.String? Dn { get; set; }

        //      C# -> System.Int32? Dnt
        // GraphQL -> dnt: Int! (scalar)
        [JsonProperty("dnt")]
        public System.Int32? Dnt { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectorySearchVersions";
    }

    public ActiveDirectorySearchVersions Set(
        ActiveDirectoryObjectType? ActiveDirectoryObjectType = null,
        System.String? Dn = null,
        System.Int32? Dnt = null,
        System.String? SnapshotId = null
    ) 
    {
        if ( ActiveDirectoryObjectType != null ) {
            this.ActiveDirectoryObjectType = ActiveDirectoryObjectType;
        }
        if ( Dn != null ) {
            this.Dn = Dn;
        }
        if ( Dnt != null ) {
            this.Dnt = Dnt;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
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
        //      C# -> ActiveDirectoryObjectType? ActiveDirectoryObjectType
        // GraphQL -> activeDirectoryObjectType: ActiveDirectoryObjectType! (enum)
        if (this.ActiveDirectoryObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeDirectoryObjectType\n" ;
            } else {
                s += ind + "activeDirectoryObjectType\n" ;
            }
        }
        //      C# -> System.String? Dn
        // GraphQL -> dn: String! (scalar)
        if (this.Dn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dn\n" ;
            } else {
                s += ind + "dn\n" ;
            }
        }
        //      C# -> System.Int32? Dnt
        // GraphQL -> dnt: Int! (scalar)
        if (this.Dnt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dnt\n" ;
            } else {
                s += ind + "dnt\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ActiveDirectoryObjectType? ActiveDirectoryObjectType
        // GraphQL -> activeDirectoryObjectType: ActiveDirectoryObjectType! (enum)
        if (ec.Includes("activeDirectoryObjectType",true))
        {
            if(this.ActiveDirectoryObjectType == null) {

                this.ActiveDirectoryObjectType = new ActiveDirectoryObjectType();

            } else {


            }
        }
        else if (this.ActiveDirectoryObjectType != null && ec.Excludes("activeDirectoryObjectType",true))
        {
            this.ActiveDirectoryObjectType = null;
        }
        //      C# -> System.String? Dn
        // GraphQL -> dn: String! (scalar)
        if (ec.Includes("dn",true))
        {
            if(this.Dn == null) {

                this.Dn = "FETCH";

            } else {


            }
        }
        else if (this.Dn != null && ec.Excludes("dn",true))
        {
            this.Dn = null;
        }
        //      C# -> System.Int32? Dnt
        // GraphQL -> dnt: Int! (scalar)
        if (ec.Includes("dnt",true))
        {
            if(this.Dnt == null) {

                this.Dnt = Int32.MinValue;

            } else {


            }
        }
        else if (this.Dnt != null && ec.Excludes("dnt",true))
        {
            this.Dnt = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
    }


    #endregion

    } // class ActiveDirectorySearchVersions
    
    #endregion

    public static class ListActiveDirectorySearchVersionsExtensions
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
            this List<ActiveDirectorySearchVersions> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ActiveDirectorySearchVersions> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectorySearchVersions> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectorySearchVersions());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectorySearchVersions> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types