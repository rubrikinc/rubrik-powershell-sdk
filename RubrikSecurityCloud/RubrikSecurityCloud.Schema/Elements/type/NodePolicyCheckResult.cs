// NodePolicyCheckResult.cs
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
    #region NodePolicyCheckResult
    public class NodePolicyCheckResult: IFragment
    {
        #region members
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> List<PolicyCheckResult>? CheckResults
        // GraphQL -> checkResults: [PolicyCheckResult!]! (type)
        [JsonProperty("checkResults")]
        public List<PolicyCheckResult>? CheckResults { get; set; }

        #endregion

    #region methods

    public NodePolicyCheckResult Set(
        System.String? NodeId = null,
        List<PolicyCheckResult>? CheckResults = null
    ) 
    {
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( CheckResults != null ) {
            this.CheckResults = CheckResults;
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
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId != null)
            {
                 s += ind + "nodeId\n";

            }
            //      C# -> List<PolicyCheckResult>? CheckResults
            // GraphQL -> checkResults: [PolicyCheckResult!]! (type)
            if (this.CheckResults != null)
            {
                 s += ind + "checkResults\n";

                 s += ind + "{\n" + 
                 this.CheckResults.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId == null && Exploration.Includes(parent + ".nodeId$"))
            {
                this.NodeId = new System.String("FETCH");
            }
            //      C# -> List<PolicyCheckResult>? CheckResults
            // GraphQL -> checkResults: [PolicyCheckResult!]! (type)
            if (this.CheckResults == null && Exploration.Includes(parent + ".checkResults"))
            {
                this.CheckResults = new List<PolicyCheckResult>();
                this.CheckResults.ApplyExploratoryFragment(parent + ".checkResults");
            }
        }


    #endregion

    } // class NodePolicyCheckResult
    #endregion

    public static class ListNodePolicyCheckResultExtensions
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
            this List<NodePolicyCheckResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NodePolicyCheckResult> list, 
            String parent = "")
        {
            var item = new NodePolicyCheckResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types