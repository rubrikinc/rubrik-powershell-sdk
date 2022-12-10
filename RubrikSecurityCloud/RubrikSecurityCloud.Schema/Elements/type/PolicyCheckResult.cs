// PolicyCheckResult.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:16.
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
    #region PolicyCheckResult
    public class PolicyCheckResult: IFragment
    {
        #region members
        //      C# -> System.String? CheckOutput
        // GraphQL -> checkOutput: String (scalar)
        [JsonProperty("checkOutput")]
        public System.String? CheckOutput { get; set; }

        //      C# -> System.Boolean? IsCheckPassed
        // GraphQL -> isCheckPassed: Boolean! (scalar)
        [JsonProperty("isCheckPassed")]
        public System.Boolean? IsCheckPassed { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        #endregion

    #region methods

    public PolicyCheckResult Set(
        System.String? CheckOutput = null,
        System.Boolean? IsCheckPassed = null,
        System.String? NodeId = null,
        System.String? PolicyId = null
    ) 
    {
        if ( CheckOutput != null ) {
            this.CheckOutput = CheckOutput;
        }
        if ( IsCheckPassed != null ) {
            this.IsCheckPassed = IsCheckPassed;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
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
            //      C# -> System.String? CheckOutput
            // GraphQL -> checkOutput: String (scalar)
            if (this.CheckOutput != null)
            {
                 s += ind + "checkOutput\n";

            }
            //      C# -> System.Boolean? IsCheckPassed
            // GraphQL -> isCheckPassed: Boolean! (scalar)
            if (this.IsCheckPassed != null)
            {
                 s += ind + "isCheckPassed\n";

            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId != null)
            {
                 s += ind + "nodeId\n";

            }
            //      C# -> System.String? PolicyId
            // GraphQL -> policyId: String! (scalar)
            if (this.PolicyId != null)
            {
                 s += ind + "policyId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CheckOutput
            // GraphQL -> checkOutput: String (scalar)
            if (this.CheckOutput == null && Exploration.Includes(parent + ".checkOutput$"))
            {
                this.CheckOutput = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsCheckPassed
            // GraphQL -> isCheckPassed: Boolean! (scalar)
            if (this.IsCheckPassed == null && Exploration.Includes(parent + ".isCheckPassed$"))
            {
                this.IsCheckPassed = new System.Boolean();
            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId == null && Exploration.Includes(parent + ".nodeId$"))
            {
                this.NodeId = new System.String("FETCH");
            }
            //      C# -> System.String? PolicyId
            // GraphQL -> policyId: String! (scalar)
            if (this.PolicyId == null && Exploration.Includes(parent + ".policyId$"))
            {
                this.PolicyId = new System.String("FETCH");
            }
        }


    #endregion

    } // class PolicyCheckResult
    #endregion

    public static class ListPolicyCheckResultExtensions
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
            this List<PolicyCheckResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PolicyCheckResult> list, 
            String parent = "")
        {
            var item = new PolicyCheckResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types