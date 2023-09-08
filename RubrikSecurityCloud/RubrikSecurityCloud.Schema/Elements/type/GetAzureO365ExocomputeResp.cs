// GetAzureO365ExocomputeResp.cs
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
    #region GetAzureO365ExocomputeResp
    public class GetAzureO365ExocomputeResp: BaseType
    {
        #region members

        //      C# -> AzureO365ExocomputeCluster? Cluster
        // GraphQL -> cluster: AzureO365ExocomputeCluster (type)
        [JsonProperty("cluster")]
        public AzureO365ExocomputeCluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetAzureO365ExocomputeResp";
    }

    public GetAzureO365ExocomputeResp Set(
        AzureO365ExocomputeCluster? Cluster = null
    ) 
    {
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
        //      C# -> AzureO365ExocomputeCluster? Cluster
        // GraphQL -> cluster: AzureO365ExocomputeCluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureO365ExocomputeCluster? Cluster
        // GraphQL -> cluster: AzureO365ExocomputeCluster (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new AzureO365ExocomputeCluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
    }


    #endregion

    } // class GetAzureO365ExocomputeResp
    
    #endregion

    public static class ListGetAzureO365ExocomputeRespExtensions
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
            this List<GetAzureO365ExocomputeResp> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetAzureO365ExocomputeResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetAzureO365ExocomputeResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GetAzureO365ExocomputeResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types