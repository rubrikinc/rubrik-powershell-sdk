// HypervScvmmSummary.cs
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
    #region HypervScvmmSummary
    public class HypervScvmmSummary: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.String? RunAsAccount
        // GraphQL -> runAsAccount: String! (scalar)
        [JsonProperty("runAsAccount")]
        public System.String? RunAsAccount { get; set; }

        //      C# -> System.String? ScvmmVersion
        // GraphQL -> scvmmVersion: String (scalar)
        [JsonProperty("scvmmVersion")]
        public System.String? ScvmmVersion { get; set; }

        //      C# -> System.Boolean? ShouldDeployAgent
        // GraphQL -> shouldDeployAgent: Boolean! (scalar)
        [JsonProperty("shouldDeployAgent")]
        public System.Boolean? ShouldDeployAgent { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }

        #endregion

    #region methods

    public HypervScvmmSummary Set(
        System.String? Id = null,
        System.String? PrimaryClusterId = null,
        System.String? RunAsAccount = null,
        System.String? ScvmmVersion = null,
        System.Boolean? ShouldDeployAgent = null,
        System.String? Status = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( RunAsAccount != null ) {
            this.RunAsAccount = RunAsAccount;
        }
        if ( ScvmmVersion != null ) {
            this.ScvmmVersion = ScvmmVersion;
        }
        if ( ShouldDeployAgent != null ) {
            this.ShouldDeployAgent = ShouldDeployAgent;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId != null)
            {
                 s += ind + "primaryClusterId\n";

            }
            //      C# -> System.String? RunAsAccount
            // GraphQL -> runAsAccount: String! (scalar)
            if (this.RunAsAccount != null)
            {
                 s += ind + "runAsAccount\n";

            }
            //      C# -> System.String? ScvmmVersion
            // GraphQL -> scvmmVersion: String (scalar)
            if (this.ScvmmVersion != null)
            {
                 s += ind + "scvmmVersion\n";

            }
            //      C# -> System.Boolean? ShouldDeployAgent
            // GraphQL -> shouldDeployAgent: Boolean! (scalar)
            if (this.ShouldDeployAgent != null)
            {
                 s += ind + "shouldDeployAgent\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable != null)
            {
                 s += ind + "slaAssignable\n";

                 s += ind + "{\n" + 
                 this.SlaAssignable.AsFragment(indent+1) + 
                 ind + "}\n";
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
            //      C# -> System.String? PrimaryClusterId
            // GraphQL -> primaryClusterId: String! (scalar)
            if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId$"))
            {
                this.PrimaryClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? RunAsAccount
            // GraphQL -> runAsAccount: String! (scalar)
            if (this.RunAsAccount == null && Exploration.Includes(parent + ".runAsAccount$"))
            {
                this.RunAsAccount = new System.String("FETCH");
            }
            //      C# -> System.String? ScvmmVersion
            // GraphQL -> scvmmVersion: String (scalar)
            if (this.ScvmmVersion == null && Exploration.Includes(parent + ".scvmmVersion$"))
            {
                this.ScvmmVersion = new System.String("FETCH");
            }
            //      C# -> System.Boolean? ShouldDeployAgent
            // GraphQL -> shouldDeployAgent: Boolean! (scalar)
            if (this.ShouldDeployAgent == null && Exploration.Includes(parent + ".shouldDeployAgent$"))
            {
                this.ShouldDeployAgent = new System.Boolean();
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
            //      C# -> SlaAssignable? SlaAssignable
            // GraphQL -> slaAssignable: SlaAssignable (type)
            if (this.SlaAssignable == null && Exploration.Includes(parent + ".slaAssignable"))
            {
                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFragment(parent + ".slaAssignable");
            }
        }


    #endregion

    } // class HypervScvmmSummary
    #endregion

    public static class ListHypervScvmmSummaryExtensions
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
            this List<HypervScvmmSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HypervScvmmSummary> list, 
            String parent = "")
        {
            var item = new HypervScvmmSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types