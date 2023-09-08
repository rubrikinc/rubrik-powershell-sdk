// ExocomputeStorageAccountIds.cs
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
    #region ExocomputeStorageAccountIds
    public class ExocomputeStorageAccountIds: BaseType
    {
        #region members

        //      C# -> List<System.String>? Ids
        // GraphQL -> ids: [String!]! (scalar)
        [JsonProperty("ids")]
        public List<System.String>? Ids { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExocomputeStorageAccountIds";
    }

    public ExocomputeStorageAccountIds Set(
        List<System.String>? Ids = null
    ) 
    {
        if ( Ids != null ) {
            this.Ids = Ids;
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
        //      C# -> List<System.String>? Ids
        // GraphQL -> ids: [String!]! (scalar)
        if (this.Ids != null) {
            s += ind + "ids\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Ids
        // GraphQL -> ids: [String!]! (scalar)
        if (this.Ids == null && ec.Includes("ids",true))
        {
            this.Ids = new List<System.String>();
        }
    }


    #endregion

    } // class ExocomputeStorageAccountIds
    
    #endregion

    public static class ListExocomputeStorageAccountIdsExtensions
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
            this List<ExocomputeStorageAccountIds> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ExocomputeStorageAccountIds> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExocomputeStorageAccountIds());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ExocomputeStorageAccountIds> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types