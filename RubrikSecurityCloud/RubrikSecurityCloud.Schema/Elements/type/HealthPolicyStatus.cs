// HealthPolicyStatus.cs
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
    #region HealthPolicyStatus
    public class HealthPolicyStatus: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsHealthy
        // GraphQL -> isHealthy: Boolean! (scalar)
        [JsonProperty("isHealthy")]
        public System.Boolean? IsHealthy { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> HardwareHealthPolicyName? PolicyName
        // GraphQL -> policyName: HardwareHealthPolicyName! (enum)
        [JsonProperty("policyName")]
        public HardwareHealthPolicyName? PolicyName { get; set; }

        #endregion

    #region methods

    public HealthPolicyStatus Set(
        System.Boolean? IsHealthy = null,
        System.String? Message = null,
        HardwareHealthPolicyName? PolicyName = null
    ) 
    {
        if ( IsHealthy != null ) {
            this.IsHealthy = IsHealthy;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( PolicyName != null ) {
            this.PolicyName = PolicyName;
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
            //      C# -> System.Boolean? IsHealthy
            // GraphQL -> isHealthy: Boolean! (scalar)
            if (this.IsHealthy != null)
            {
                 s += ind + "isHealthy\n";

            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            //      C# -> HardwareHealthPolicyName? PolicyName
            // GraphQL -> policyName: HardwareHealthPolicyName! (enum)
            if (this.PolicyName != null)
            {
                 s += ind + "policyName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsHealthy
            // GraphQL -> isHealthy: Boolean! (scalar)
            if (this.IsHealthy == null && Exploration.Includes(parent + ".isHealthy$"))
            {
                this.IsHealthy = new System.Boolean();
            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
            //      C# -> HardwareHealthPolicyName? PolicyName
            // GraphQL -> policyName: HardwareHealthPolicyName! (enum)
            if (this.PolicyName == null && Exploration.Includes(parent + ".policyName$"))
            {
                this.PolicyName = new HardwareHealthPolicyName();
            }
        }


    #endregion

    } // class HealthPolicyStatus
    #endregion

    public static class ListHealthPolicyStatusExtensions
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
            this List<HealthPolicyStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HealthPolicyStatus> list, 
            String parent = "")
        {
            var item = new HealthPolicyStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types