// ParentAppInfo.cs
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
    #region ParentAppInfo
    public class ParentAppInfo: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsProtectedThruHierarchy
        // GraphQL -> isProtectedThruHierarchy: Boolean! (scalar)
        [JsonProperty("isProtectedThruHierarchy")]
        public System.Boolean? IsProtectedThruHierarchy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ParentAppInfo";
    }

    public ParentAppInfo Set(
        System.String? Id = null,
        System.Boolean? IsProtectedThruHierarchy = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsProtectedThruHierarchy != null ) {
            this.IsProtectedThruHierarchy = IsProtectedThruHierarchy;
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
        // GraphQL -> id: String (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsProtectedThruHierarchy
        // GraphQL -> isProtectedThruHierarchy: Boolean! (scalar)
        if (this.IsProtectedThruHierarchy != null) {
            s += ind + "isProtectedThruHierarchy\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsProtectedThruHierarchy
        // GraphQL -> isProtectedThruHierarchy: Boolean! (scalar)
        if (this.IsProtectedThruHierarchy == null && ec.Includes("isProtectedThruHierarchy",true))
        {
            this.IsProtectedThruHierarchy = true;
        }
    }


    #endregion

    } // class ParentAppInfo
    
    #endregion

    public static class ListParentAppInfoExtensions
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
            this List<ParentAppInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ParentAppInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ParentAppInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ParentAppInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types