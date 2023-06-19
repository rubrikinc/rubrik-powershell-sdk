// ArchivalLocationToClusterMapping.cs
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
    #region ArchivalLocationToClusterMapping
    public class ArchivalLocationToClusterMapping: BaseType
    {
        #region members

        //      C# -> SlaArchivalCluster? Cluster
        // GraphQL -> cluster: SlaArchivalCluster (type)
        [JsonProperty("cluster")]
        public SlaArchivalCluster? Cluster { get; set; }

        //      C# -> DlsArchivalLocation? Location
        // GraphQL -> location: DlsArchivalLocation (type)
        [JsonProperty("location")]
        public DlsArchivalLocation? Location { get; set; }


        #endregion

    #region methods

    public ArchivalLocationToClusterMapping Set(
        SlaArchivalCluster? Cluster = null,
        DlsArchivalLocation? Location = null
    ) 
    {
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Location != null ) {
            this.Location = Location;
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
        //      C# -> SlaArchivalCluster? Cluster
        // GraphQL -> cluster: SlaArchivalCluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> DlsArchivalLocation? Location
        // GraphQL -> location: DlsArchivalLocation (type)
        if (this.Location != null) {
            var fspec = this.Location.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "location {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> SlaArchivalCluster? Cluster
        // GraphQL -> cluster: SlaArchivalCluster (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new SlaArchivalCluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> DlsArchivalLocation? Location
        // GraphQL -> location: DlsArchivalLocation (type)
        if (this.Location == null && Exploration.Includes(parent + ".location"))
        {
            this.Location = new DlsArchivalLocation();
            this.Location.ApplyExploratoryFieldSpec(parent + ".location");
        }
    }


    #endregion

    } // class ArchivalLocationToClusterMapping
    
    #endregion

    public static class ListArchivalLocationToClusterMappingExtensions
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
            this List<ArchivalLocationToClusterMapping> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationToClusterMapping> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationToClusterMapping());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types