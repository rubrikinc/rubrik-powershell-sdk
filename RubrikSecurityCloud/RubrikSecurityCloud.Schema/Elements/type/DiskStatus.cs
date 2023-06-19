// DiskStatus.cs
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
    #region DiskStatus
    public class DiskStatus: BaseType
    {
        #region members

        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String! (scalar)
        [JsonProperty("diskType")]
        public System.String? DiskType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsDegraded
        // GraphQL -> isDegraded: Boolean! (scalar)
        [JsonProperty("isDegraded")]
        public System.Boolean? IsDegraded { get; set; }

        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        [JsonProperty("isEncrypted")]
        public System.Boolean? IsEncrypted { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }


        #endregion

    #region methods

    public DiskStatus Set(
        System.String? DiskType = null,
        System.String? Id = null,
        System.Boolean? IsDegraded = null,
        System.Boolean? IsEncrypted = null,
        System.String? NodeId = null,
        System.String? Status = null
    ) 
    {
        if ( DiskType != null ) {
            this.DiskType = DiskType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsDegraded != null ) {
            this.IsDegraded = IsDegraded;
        }
        if ( IsEncrypted != null ) {
            this.IsEncrypted = IsEncrypted;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String! (scalar)
        if (this.DiskType != null) {
            s += ind + "diskType\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsDegraded
        // GraphQL -> isDegraded: Boolean! (scalar)
        if (this.IsDegraded != null) {
            s += ind + "isDegraded\n" ;
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (this.IsEncrypted != null) {
            s += ind + "isEncrypted\n" ;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId != null) {
            s += ind + "nodeId\n" ;
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? DiskType
        // GraphQL -> diskType: String! (scalar)
        if (this.DiskType == null && Exploration.Includes(parent + ".diskType", true))
        {
            this.DiskType = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsDegraded
        // GraphQL -> isDegraded: Boolean! (scalar)
        if (this.IsDegraded == null && Exploration.Includes(parent + ".isDegraded", true))
        {
            this.IsDegraded = true;
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (this.IsEncrypted == null && Exploration.Includes(parent + ".isEncrypted", true))
        {
            this.IsEncrypted = true;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        if (this.NodeId == null && Exploration.Includes(parent + ".nodeId", true))
        {
            this.NodeId = "FETCH";
        }
        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = "FETCH";
        }
    }


    #endregion

    } // class DiskStatus
    
    #endregion

    public static class ListDiskStatusExtensions
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
            this List<DiskStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DiskStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DiskStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types