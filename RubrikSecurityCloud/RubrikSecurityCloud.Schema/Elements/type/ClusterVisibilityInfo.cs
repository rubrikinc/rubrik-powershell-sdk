// ClusterVisibilityInfo.cs
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
    #region ClusterVisibilityInfo
    public class ClusterVisibilityInfo: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> ClusterVisibilityConfig? ClusterVisibilityConfig
        // GraphQL -> clusterVisibilityConfig: ClusterVisibilityConfig (type)
        [JsonProperty("clusterVisibilityConfig")]
        public ClusterVisibilityConfig? ClusterVisibilityConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterVisibilityInfo";
    }

    public ClusterVisibilityInfo Set(
        System.String? Name = null,
        ClusterVisibilityConfig? ClusterVisibilityConfig = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ClusterVisibilityConfig != null ) {
            this.ClusterVisibilityConfig = ClusterVisibilityConfig;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> ClusterVisibilityConfig? ClusterVisibilityConfig
        // GraphQL -> clusterVisibilityConfig: ClusterVisibilityConfig (type)
        if (this.ClusterVisibilityConfig != null) {
            var fspec = this.ClusterVisibilityConfig.AsFieldSpec(conf.Child("clusterVisibilityConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterVisibilityConfig {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> ClusterVisibilityConfig? ClusterVisibilityConfig
        // GraphQL -> clusterVisibilityConfig: ClusterVisibilityConfig (type)
        if (ec.Includes("clusterVisibilityConfig",false))
        {
            if(this.ClusterVisibilityConfig == null) {

                this.ClusterVisibilityConfig = new ClusterVisibilityConfig();
                this.ClusterVisibilityConfig.ApplyExploratoryFieldSpec(ec.NewChild("clusterVisibilityConfig"));

            } else {

                this.ClusterVisibilityConfig.ApplyExploratoryFieldSpec(ec.NewChild("clusterVisibilityConfig"));

            }
        }
        else if (this.ClusterVisibilityConfig != null && ec.Excludes("clusterVisibilityConfig",false))
        {
            this.ClusterVisibilityConfig = null;
        }
    }


    #endregion

    } // class ClusterVisibilityInfo
    
    #endregion

    public static class ListClusterVisibilityInfoExtensions
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
            this List<ClusterVisibilityInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterVisibilityInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterVisibilityInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterVisibilityInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types