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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? SourceClusterAddress
        // GraphQL -> sourceClusterAddress: String (scalar)
        if (this.SourceClusterAddress != null) {
            s += ind + "sourceClusterAddress\n" ;
        }
        //      C# -> System.String? SourceClusterName
        // GraphQL -> sourceClusterName: String! (scalar)
        if (this.SourceClusterName != null) {
            s += ind + "sourceClusterName\n" ;
        }
        //      C# -> System.String? SourceClusterUuid
        // GraphQL -> sourceClusterUuid: UUID! (scalar)
        if (this.SourceClusterUuid != null) {
            s += ind + "sourceClusterUuid\n" ;
        }
        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        if (this.TotalStorage != null) {
            s += ind + "totalStorage\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? SourceClusterAddress
        // GraphQL -> sourceClusterAddress: String (scalar)
        if (this.SourceClusterAddress == null && Exploration.Includes(parent + ".sourceClusterAddress", true))
        {
            this.SourceClusterAddress = "FETCH";
        }
        //      C# -> System.String? SourceClusterName
        // GraphQL -> sourceClusterName: String! (scalar)
        if (this.SourceClusterName == null && Exploration.Includes(parent + ".sourceClusterName", true))
        {
            this.SourceClusterName = "FETCH";
        }
        //      C# -> System.String? SourceClusterUuid
        // GraphQL -> sourceClusterUuid: UUID! (scalar)
        if (this.SourceClusterUuid == null && Exploration.Includes(parent + ".sourceClusterUuid", true))
        {
            this.SourceClusterUuid = "FETCH";
        }
        //      C# -> System.Int64? TotalStorage
        // GraphQL -> totalStorage: Long (scalar)
        if (this.TotalStorage == null && Exploration.Includes(parent + ".totalStorage", true))
        {
            this.TotalStorage = new System.Int64();
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationSource> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationSource());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types