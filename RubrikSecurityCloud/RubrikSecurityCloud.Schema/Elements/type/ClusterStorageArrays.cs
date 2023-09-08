// ClusterStorageArrays.cs
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
    #region ClusterStorageArrays
    public class ClusterStorageArrays: BaseType
    {
        #region members

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<StorageArrayDetail>? StorageArrays
        // GraphQL -> storageArrays: [StorageArrayDetail!]! (type)
        [JsonProperty("storageArrays")]
        public List<StorageArrayDetail>? StorageArrays { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterStorageArrays";
    }

    public ClusterStorageArrays Set(
        System.String? ErrorMessage = null,
        Cluster? Cluster = null,
        List<StorageArrayDetail>? StorageArrays = null
    ) 
    {
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( StorageArrays != null ) {
            this.StorageArrays = StorageArrays;
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
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        if (this.ErrorMessage != null) {
            s += ind + "errorMessage\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<StorageArrayDetail>? StorageArrays
        // GraphQL -> storageArrays: [StorageArrayDetail!]! (type)
        if (this.StorageArrays != null) {
            var fspec = this.StorageArrays.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "storageArrays {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        if (this.ErrorMessage == null && ec.Includes("errorMessage",true))
        {
            this.ErrorMessage = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> List<StorageArrayDetail>? StorageArrays
        // GraphQL -> storageArrays: [StorageArrayDetail!]! (type)
        if (this.StorageArrays == null && ec.Includes("storageArrays",false))
        {
            this.StorageArrays = new List<StorageArrayDetail>();
            this.StorageArrays.ApplyExploratoryFieldSpec(ec.NewChild("storageArrays"));
        }
    }


    #endregion

    } // class ClusterStorageArrays
    
    #endregion

    public static class ListClusterStorageArraysExtensions
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
            this List<ClusterStorageArrays> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterStorageArrays> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterStorageArrays());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ClusterStorageArrays> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types