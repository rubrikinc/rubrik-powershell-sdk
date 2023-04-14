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

namespace Rubrik.SecurityCloud.Types
{
    #region AuthorizedOperations
    public class AuthorizedOperations: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        [JsonProperty("operations")]
        public List<Operation>? Operations { get; set; }

        //      C# -> WorkloadLevelHierarchy? WorkloadHierarchy
        // GraphQL -> workloadHierarchy: WorkloadLevelHierarchy (enum)
        [JsonProperty("workloadHierarchy")]
        public WorkloadLevelHierarchy? WorkloadHierarchy { get; set; }

        #endregion

    #region methods

    public AuthorizedOperations Set(
        System.String? Id = null,
        List<Operation>? Operations = null,
        WorkloadLevelHierarchy? WorkloadHierarchy = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Operations != null ) {
            this.Operations = Operations;
        }
        if ( WorkloadHierarchy != null ) {
            this.WorkloadHierarchy = WorkloadHierarchy;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> List<Operation>? Operations
            // GraphQL -> operations: [Operation!]! (enum)
            if (this.Operations != null)
            {
                 s += ind + "operations\n";

            }
            //      C# -> WorkloadLevelHierarchy? WorkloadHierarchy
            // GraphQL -> workloadHierarchy: WorkloadLevelHierarchy (enum)
            if (this.WorkloadHierarchy != null)
            {
                 s += ind + "workloadHierarchy\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> List<Operation>? Operations
            // GraphQL -> operations: [Operation!]! (enum)
            if (this.Operations == null && Exploration.Includes(parent + ".operations$"))
            {
                this.Operations = new List<Operation>();
            }
            //      C# -> WorkloadLevelHierarchy? WorkloadHierarchy
            // GraphQL -> workloadHierarchy: WorkloadLevelHierarchy (enum)
            if (this.WorkloadHierarchy == null && Exploration.Includes(parent + ".workloadHierarchy$"))
            {
                this.WorkloadHierarchy = new WorkloadLevelHierarchy();
            }
        }


    #endregion

    } // class AuthorizedOperations
    #endregion

    public static class ListAuthorizedOperationsExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<AuthorizedOperations> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AuthorizedOperations> list, 
            String parent = "")
        {
            var item = new AuthorizedOperations();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types