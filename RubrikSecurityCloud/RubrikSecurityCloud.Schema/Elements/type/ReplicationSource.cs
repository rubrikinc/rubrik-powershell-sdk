// ReplicationSource.cs
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
    #region ReplicationSource
    public class ReplicationSource: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? SourceClusterAddress
        // GraphQL -> sourceClusterAddress: String (scalar)
        [JsonProperty("sourceClusterAddress")]
        public System.String? SourceClusterAddress { get; set; }

        //      C# -> System.String? SourceClusterName
        // GraphQL -> sourceClusterName: String! (scalar)
        [JsonProperty("sourceClusterName")]
        public System.String? SourceClusterName { get; set; }

        //      C# -> System.String? SourceClusterUuid
        // GraphQL -> sourceClusterUuid: UUID! (scalar)
        [JsonProperty("sourceClusterUuid")]
        public System.String? SourceClusterUuid { get; set; }

        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        [JsonProperty("totalStorage")]
        public System.Int64? TotalStorage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicationSource";
    }

    public ReplicationSource Set(
        System.String? Id = null,
        System.String? SourceClusterAddress = null,
        System.String? SourceClusterName = null,
        System.String? SourceClusterUuid = null,
        System.Int64? TotalStorage = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( SourceClusterAddress != null ) {
            this.SourceClusterAddress = SourceClusterAddress;
        }
        if ( SourceClusterName != null ) {
            this.SourceClusterName = SourceClusterName;
        }
        if ( SourceClusterUuid != null ) {
            this.SourceClusterUuid = SourceClusterUuid;
        }
        if ( TotalStorage != null ) {
            this.TotalStorage = TotalStorage;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? SourceClusterAddress
        // GraphQL -> sourceClusterAddress: String (scalar)
        if (this.SourceClusterAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceClusterAddress\n" ;
            } else {
                s += ind + "sourceClusterAddress\n" ;
            }
        }
        //      C# -> System.String? SourceClusterName
        // GraphQL -> sourceClusterName: String! (scalar)
        if (this.SourceClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceClusterName\n" ;
            } else {
                s += ind + "sourceClusterName\n" ;
            }
        }
        //      C# -> System.String? SourceClusterUuid
        // GraphQL -> sourceClusterUuid: UUID! (scalar)
        if (this.SourceClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceClusterUuid\n" ;
            } else {
                s += ind + "sourceClusterUuid\n" ;
            }
        }
        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        if (this.TotalStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalStorage\n" ;
            } else {
                s += ind + "totalStorage\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> System.String? SourceClusterAddress
        // GraphQL -> sourceClusterAddress: String (scalar)
        if (ec.Includes("sourceClusterAddress",true))
        {
            if(this.SourceClusterAddress == null) {

                this.SourceClusterAddress = "FETCH";

            } else {


            }
        }
        else if (this.SourceClusterAddress != null && ec.Excludes("sourceClusterAddress",true))
        {
            this.SourceClusterAddress = null;
        }
        //      C# -> System.String? SourceClusterName
        // GraphQL -> sourceClusterName: String! (scalar)
        if (ec.Includes("sourceClusterName",true))
        {
            if(this.SourceClusterName == null) {

                this.SourceClusterName = "FETCH";

            } else {


            }
        }
        else if (this.SourceClusterName != null && ec.Excludes("sourceClusterName",true))
        {
            this.SourceClusterName = null;
        }
        //      C# -> System.String? SourceClusterUuid
        // GraphQL -> sourceClusterUuid: UUID! (scalar)
        if (ec.Includes("sourceClusterUuid",true))
        {
            if(this.SourceClusterUuid == null) {

                this.SourceClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.SourceClusterUuid != null && ec.Excludes("sourceClusterUuid",true))
        {
            this.SourceClusterUuid = null;
        }
        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        if (ec.Includes("totalStorage",true))
        {
            if(this.TotalStorage == null) {

                this.TotalStorage = new System.Int64();

            } else {


            }
        }
        else if (this.TotalStorage != null && ec.Excludes("totalStorage",true))
        {
            this.TotalStorage = null;
        }
    }


    #endregion

    } // class ReplicationSource
    
    #endregion

    public static class ListReplicationSourceExtensions
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
            this List<ReplicationSource> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ReplicationSource> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationSource> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationSource());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationSource> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types