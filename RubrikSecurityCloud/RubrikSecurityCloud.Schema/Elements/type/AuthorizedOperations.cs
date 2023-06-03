// AuthorizedOperations.cs
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
    #region AuthorizedOperations
    public class AuthorizedOperations: BaseType
    {
        #region members

        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        [JsonProperty("operations")]
        public List<Operation>? Operations { get; set; }

        //      C# -> WorkloadLevelHierarchy? WorkloadHierarchy
        // GraphQL -> workloadHierarchy: WorkloadLevelHierarchy (enum)
        [JsonProperty("workloadHierarchy")]
        public WorkloadLevelHierarchy? WorkloadHierarchy { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }


        #endregion

    #region methods

    public AuthorizedOperations Set(
        List<Operation>? Operations = null,
        WorkloadLevelHierarchy? WorkloadHierarchy = null,
        System.String? Id = null
    ) 
    {
        if ( Operations != null ) {
            this.Operations = Operations;
        }
        if ( WorkloadHierarchy != null ) {
            this.WorkloadHierarchy = WorkloadHierarchy;
        }
        if ( Id != null ) {
            this.Id = Id;
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
        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        if (this.Operations != null) {
            s += ind + "operations\n" ;
        }
        //      C# -> WorkloadLevelHierarchy? WorkloadHierarchy
        // GraphQL -> workloadHierarchy: WorkloadLevelHierarchy (enum)
        if (this.WorkloadHierarchy != null) {
            s += ind + "workloadHierarchy\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        if (this.Operations == null && Exploration.Includes(parent + ".operations", true))
        {
            this.Operations = new List<Operation>();
        }
        //      C# -> WorkloadLevelHierarchy? WorkloadHierarchy
        // GraphQL -> workloadHierarchy: WorkloadLevelHierarchy (enum)
        if (this.WorkloadHierarchy == null && Exploration.Includes(parent + ".workloadHierarchy", true))
        {
            this.WorkloadHierarchy = new WorkloadLevelHierarchy();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
    }


    #endregion

    } // class AuthorizedOperations
    
    #endregion

    public static class ListAuthorizedOperationsExtensions
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
            this List<AuthorizedOperations> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AuthorizedOperations> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AuthorizedOperations());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types