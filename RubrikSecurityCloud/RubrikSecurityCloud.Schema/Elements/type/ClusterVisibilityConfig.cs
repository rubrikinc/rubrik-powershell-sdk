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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ClusterVisibilityConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterVisibilityConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterVisibilityConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterVisibilityConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterVisibilityConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types