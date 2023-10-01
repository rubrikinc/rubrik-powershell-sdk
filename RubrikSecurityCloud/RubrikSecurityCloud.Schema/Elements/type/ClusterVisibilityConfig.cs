// ClusterVisibilityConfig.cs
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
    #region ClusterVisibilityConfig
    public class ClusterVisibilityConfig: BaseType
    {
        #region members

        //      C# -> List<System.String>? HostGroupFilter
        // GraphQL -> hostGroupFilter: [String!]! (scalar)
        [JsonProperty("hostGroupFilter")]
        public List<System.String>? HostGroupFilter { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsVmwareMetroStorageCluster
        // GraphQL -> isVmwareMetroStorageCluster: Boolean (scalar)
        [JsonProperty("isVmwareMetroStorageCluster")]
        public System.Boolean? IsVmwareMetroStorageCluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterVisibilityConfig";
    }

    public ClusterVisibilityConfig Set(
        List<System.String>? HostGroupFilter = null,
        System.String? Id = null,
        System.Boolean? IsVmwareMetroStorageCluster = null
    ) 
    {
        if ( HostGroupFilter != null ) {
            this.HostGroupFilter = HostGroupFilter;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsVmwareMetroStorageCluster != null ) {
            this.IsVmwareMetroStorageCluster = IsVmwareMetroStorageCluster;
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
        //      C# -> List<System.String>? HostGroupFilter
        // GraphQL -> hostGroupFilter: [String!]! (scalar)
        if (this.HostGroupFilter != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostGroupFilter\n" ;
            } else {
                s += ind + "hostGroupFilter\n" ;
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
        //      C# -> System.Boolean? IsVmwareMetroStorageCluster
        // GraphQL -> isVmwareMetroStorageCluster: Boolean (scalar)
        if (this.IsVmwareMetroStorageCluster != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isVmwareMetroStorageCluster\n" ;
            } else {
                s += ind + "isVmwareMetroStorageCluster\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? HostGroupFilter
        // GraphQL -> hostGroupFilter: [String!]! (scalar)
        if (ec.Includes("hostGroupFilter",true))
        {
            if(this.HostGroupFilter == null) {

                this.HostGroupFilter = new List<System.String>();

            } else {


            }
        }
        else if (this.HostGroupFilter != null && ec.Excludes("hostGroupFilter",true))
        {
            this.HostGroupFilter = null;
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
        //      C# -> System.Boolean? IsVmwareMetroStorageCluster
        // GraphQL -> isVmwareMetroStorageCluster: Boolean (scalar)
        if (ec.Includes("isVmwareMetroStorageCluster",true))
        {
            if(this.IsVmwareMetroStorageCluster == null) {

                this.IsVmwareMetroStorageCluster = true;

            } else {


            }
        }
        else if (this.IsVmwareMetroStorageCluster != null && ec.Excludes("isVmwareMetroStorageCluster",true))
        {
            this.IsVmwareMetroStorageCluster = null;
        }
    }


    #endregion

    } // class ClusterVisibilityConfig
    
    #endregion

    public static class ListClusterVisibilityConfigExtensions
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
            this List<ClusterVisibilityConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ClusterVisibilityConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterVisibilityConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterVisibilityConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterVisibilityConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types