// PausedClustersInfo.cs
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
    #region PausedClustersInfo
    public class PausedClustersInfo: BaseType
    {
        #region members

        //      C# -> System.Int32? PausedClustersCount
        // GraphQL -> pausedClustersCount: Int! (scalar)
        [JsonProperty("pausedClustersCount")]
        public System.Int32? PausedClustersCount { get; set; }

        //      C# -> List<Cluster>? PausedClusters
        // GraphQL -> pausedClusters: [Cluster!] (type)
        [JsonProperty("pausedClusters")]
        public List<Cluster>? PausedClusters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PausedClustersInfo";
    }

    public PausedClustersInfo Set(
        System.Int32? PausedClustersCount = null,
        List<Cluster>? PausedClusters = null
    ) 
    {
        if ( PausedClustersCount != null ) {
            this.PausedClustersCount = PausedClustersCount;
        }
        if ( PausedClusters != null ) {
            this.PausedClusters = PausedClusters;
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
        //      C# -> System.Int32? PausedClustersCount
        // GraphQL -> pausedClustersCount: Int! (scalar)
        if (this.PausedClustersCount != null) {
            s += ind + "pausedClustersCount\n" ;
        }
        //      C# -> List<Cluster>? PausedClusters
        // GraphQL -> pausedClusters: [Cluster!] (type)
        if (this.PausedClusters != null) {
            var fspec = this.PausedClusters.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pausedClusters {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? PausedClustersCount
        // GraphQL -> pausedClustersCount: Int! (scalar)
        if (this.PausedClustersCount == null && ec.Includes("pausedClustersCount",true))
        {
            this.PausedClustersCount = Int32.MinValue;
        }
        //      C# -> List<Cluster>? PausedClusters
        // GraphQL -> pausedClusters: [Cluster!] (type)
        if (this.PausedClusters == null && ec.Includes("pausedClusters",false))
        {
            this.PausedClusters = new List<Cluster>();
            this.PausedClusters.ApplyExploratoryFieldSpec(ec.NewChild("pausedClusters"));
        }
    }


    #endregion

    } // class PausedClustersInfo
    
    #endregion

    public static class ListPausedClustersInfoExtensions
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
            this List<PausedClustersInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PausedClustersInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PausedClustersInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PausedClustersInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types