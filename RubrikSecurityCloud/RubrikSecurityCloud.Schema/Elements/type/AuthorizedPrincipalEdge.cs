// AuthorizedPrincipalEdge.cs
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
    #region AuthorizedPrincipalEdge
    public class AuthorizedPrincipalEdge: BaseType
    {
        #region members

        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        [JsonProperty("cursor")]
        public System.String? Cursor { get; set; }

        //      C# -> AuthorizedPrincipal? Node
        // GraphQL -> node: AuthorizedPrincipal! (type)
        [JsonProperty("node")]
        public AuthorizedPrincipal? Node { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AuthorizedPrincipalEdge";
    }

    public AuthorizedPrincipalEdge Set(
        System.String? Cursor = null,
        AuthorizedPrincipal? Node = null
    ) 
    {
        if ( Cursor != null ) {
            this.Cursor = Cursor;
        }
        if ( Node != null ) {
            this.Node = Node;
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
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor != null) {
            s += ind + "cursor\n" ;
        }
        //      C# -> AuthorizedPrincipal? Node
        // GraphQL -> node: AuthorizedPrincipal! (type)
        if (this.Node != null) {
            var fspec = this.Node.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "node {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor == null && ec.Includes("cursor",true))
        {
            this.Cursor = "FETCH";
        }
        //      C# -> AuthorizedPrincipal? Node
        // GraphQL -> node: AuthorizedPrincipal! (type)
        if (this.Node == null && ec.Includes("node",false))
        {
            this.Node = new AuthorizedPrincipal();
            this.Node.ApplyExploratoryFieldSpec(ec.NewChild("node"));
        }
    }


    #endregion

    } // class AuthorizedPrincipalEdge
    
    #endregion

    public static class ListAuthorizedPrincipalEdgeExtensions
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
            this List<AuthorizedPrincipalEdge> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AuthorizedPrincipalEdge> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AuthorizedPrincipalEdge());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AuthorizedPrincipalEdge> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types