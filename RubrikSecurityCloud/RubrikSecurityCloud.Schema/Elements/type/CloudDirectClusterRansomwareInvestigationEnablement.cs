// CloudDirectClusterRansomwareInvestigationEnablement.cs
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
    #region CloudDirectClusterRansomwareInvestigationEnablement
    public class CloudDirectClusterRansomwareInvestigationEnablement: BaseType
    {
        #region members

        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        //      C# -> CloudDirectCluster? Cluster
        // GraphQL -> cluster: CloudDirectCluster! (type)
        [JsonProperty("cluster")]
        public CloudDirectCluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectClusterRansomwareInvestigationEnablement";
    }

    public CloudDirectClusterRansomwareInvestigationEnablement Set(
        System.Boolean? Enabled = null,
        CloudDirectCluster? Cluster = null
    ) 
    {
        if ( Enabled != null ) {
            this.Enabled = Enabled;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled != null) {
            s += ind + "enabled\n" ;
        }
        //      C# -> CloudDirectCluster? Cluster
        // GraphQL -> cluster: CloudDirectCluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled == null && Exploration.Includes(parent + ".enabled", true))
        {
            this.Enabled = true;
        }
        //      C# -> CloudDirectCluster? Cluster
        // GraphQL -> cluster: CloudDirectCluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new CloudDirectCluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
    }


    #endregion

    } // class CloudDirectClusterRansomwareInvestigationEnablement
    
    #endregion

    public static class ListCloudDirectClusterRansomwareInvestigationEnablementExtensions
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
            this List<CloudDirectClusterRansomwareInvestigationEnablement> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectClusterRansomwareInvestigationEnablement> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectClusterRansomwareInvestigationEnablement());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types