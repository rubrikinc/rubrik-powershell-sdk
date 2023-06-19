// ObjectIdToSnapshotIds.cs
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
    #region ObjectIdToSnapshotIds
    public class ObjectIdToSnapshotIds: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? Snapshots
        // GraphQL -> snapshots: [String!]! (scalar)
        [JsonProperty("snapshots")]
        public List<System.String>? Snapshots { get; set; }


        #endregion

    #region methods

    public ObjectIdToSnapshotIds Set(
        System.String? Id = null,
        List<System.String>? Snapshots = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Snapshots != null ) {
            this.Snapshots = Snapshots;
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
        //      C# -> List<System.String>? Snapshots
        // GraphQL -> snapshots: [String!]! (scalar)
        if (this.Snapshots != null) {
            s += ind + "snapshots\n" ;
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
        //      C# -> List<System.String>? Snapshots
        // GraphQL -> snapshots: [String!]! (scalar)
        if (this.Snapshots == null && Exploration.Includes(parent + ".snapshots", true))
        {
            this.Snapshots = new List<System.String>();
        }
    }


    #endregion

    } // class ObjectIdToSnapshotIds
    
    #endregion

    public static class ListObjectIdToSnapshotIdsExtensions
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
            this List<ObjectIdToSnapshotIds> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ObjectIdToSnapshotIds> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectIdToSnapshotIds());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types