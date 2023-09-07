// AuthorizedOps.cs
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
    #region AuthorizedOps
    public class AuthorizedOps: BaseType
    {
        #region members

        //      C# -> List<AuthorizedOperation>? Operations
        // GraphQL -> operations: [AuthorizedOperation!]! (enum)
        [JsonProperty("operations")]
        public List<AuthorizedOperation>? Operations { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AuthorizedOps";
    }

    public AuthorizedOps Set(
        List<AuthorizedOperation>? Operations = null,
        System.String? ObjectId = null
    ) 
    {
        if ( Operations != null ) {
            this.Operations = Operations;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
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
        //      C# -> List<AuthorizedOperation>? Operations
        // GraphQL -> operations: [AuthorizedOperation!]! (enum)
        if (this.Operations != null) {
            s += ind + "operations\n" ;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        if (this.ObjectId != null) {
            s += ind + "objectId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AuthorizedOperation>? Operations
        // GraphQL -> operations: [AuthorizedOperation!]! (enum)
        if (this.Operations == null && ec.Includes("operations",true))
        {
            this.Operations = new List<AuthorizedOperation>();
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: UUID! (scalar)
        if (this.ObjectId == null && ec.Includes("objectId",true))
        {
            this.ObjectId = "FETCH";
        }
    }


    #endregion

    } // class AuthorizedOps
    
    #endregion

    public static class ListAuthorizedOpsExtensions
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
            this List<AuthorizedOps> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AuthorizedOps> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AuthorizedOps());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AuthorizedOps> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types