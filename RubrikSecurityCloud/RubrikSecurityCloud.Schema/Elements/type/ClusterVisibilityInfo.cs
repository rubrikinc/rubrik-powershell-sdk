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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> ClusterVisibilityConfig? ClusterVisibilityConfig
        // GraphQL -> clusterVisibilityConfig: ClusterVisibilityConfig (type)
        if (this.ClusterVisibilityConfig != null) {
            s += ind + "clusterVisibilityConfig {\n" + this.ClusterVisibilityConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> ClusterVisibilityConfig? ClusterVisibilityConfig
        // GraphQL -> clusterVisibilityConfig: ClusterVisibilityConfig (type)
        if (this.ClusterVisibilityConfig == null && Exploration.Includes(parent + ".clusterVisibilityConfig"))
        {
            this.ClusterVisibilityConfig = new ClusterVisibilityConfig();
            this.ClusterVisibilityConfig.ApplyExploratoryFieldSpec(parent + ".clusterVisibilityConfig");
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterVisibilityInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterVisibilityInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types