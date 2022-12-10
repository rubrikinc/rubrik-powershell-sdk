// O365OrgInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:55.
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
    #region O365OrgInfo
    public class O365OrgInfo: IFragment
    {
        #region members
        //      C# -> System.Boolean? ExchangeOnColossus
        // GraphQL -> exchangeOnColossus: Boolean! (scalar)
        [JsonProperty("exchangeOnColossus")]
        public System.Boolean? ExchangeOnColossus { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.Int32? Past1DayMailboxComplianceCount
        // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
        [JsonProperty("past1DayMailboxComplianceCount")]
        public System.Int32? Past1DayMailboxComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
        // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayMailboxOutOfComplianceCount")]
        public System.Int32? Past1DayMailboxOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayOnedriveComplianceCount
        // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
        [JsonProperty("past1DayOnedriveComplianceCount")]
        public System.Int32? Past1DayOnedriveComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
        // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayOnedriveOutOfComplianceCount")]
        public System.Int32? Past1DayOnedriveOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySharepointComplianceCount
        // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySharepointComplianceCount")]
        public System.Int32? Past1DaySharepointComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
        // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySharepointOutOfComplianceCount")]
        public System.Int32? Past1DaySharepointOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpListComplianceCount
        // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpListComplianceCount")]
        public System.Int32? Past1DaySpListComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
        // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpListOutOfComplianceCount")]
        public System.Int32? Past1DaySpListOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayTeamsComplianceCount
        // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
        [JsonProperty("past1DayTeamsComplianceCount")]
        public System.Int32? Past1DayTeamsComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
        // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayTeamsOutOfComplianceCount")]
        public System.Int32? Past1DayTeamsOutOfComplianceCount { get; set; }

        //      C# -> ProvisionStatus? Status
        // GraphQL -> status: ProvisionStatus! (enum)
        [JsonProperty("status")]
        public ProvisionStatus? Status { get; set; }

        #endregion

    #region methods

    public O365OrgInfo Set(
        System.Boolean? ExchangeOnColossus = null,
        System.String? OrgId = null,
        System.Int32? Past1DayMailboxComplianceCount = null,
        System.Int32? Past1DayMailboxOutOfComplianceCount = null,
        System.Int32? Past1DayOnedriveComplianceCount = null,
        System.Int32? Past1DayOnedriveOutOfComplianceCount = null,
        System.Int32? Past1DaySharepointComplianceCount = null,
        System.Int32? Past1DaySharepointOutOfComplianceCount = null,
        System.Int32? Past1DaySpListComplianceCount = null,
        System.Int32? Past1DaySpListOutOfComplianceCount = null,
        System.Int32? Past1DayTeamsComplianceCount = null,
        System.Int32? Past1DayTeamsOutOfComplianceCount = null,
        ProvisionStatus? Status = null
    ) 
    {
        if ( ExchangeOnColossus != null ) {
            this.ExchangeOnColossus = ExchangeOnColossus;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( Past1DayMailboxComplianceCount != null ) {
            this.Past1DayMailboxComplianceCount = Past1DayMailboxComplianceCount;
        }
        if ( Past1DayMailboxOutOfComplianceCount != null ) {
            this.Past1DayMailboxOutOfComplianceCount = Past1DayMailboxOutOfComplianceCount;
        }
        if ( Past1DayOnedriveComplianceCount != null ) {
            this.Past1DayOnedriveComplianceCount = Past1DayOnedriveComplianceCount;
        }
        if ( Past1DayOnedriveOutOfComplianceCount != null ) {
            this.Past1DayOnedriveOutOfComplianceCount = Past1DayOnedriveOutOfComplianceCount;
        }
        if ( Past1DaySharepointComplianceCount != null ) {
            this.Past1DaySharepointComplianceCount = Past1DaySharepointComplianceCount;
        }
        if ( Past1DaySharepointOutOfComplianceCount != null ) {
            this.Past1DaySharepointOutOfComplianceCount = Past1DaySharepointOutOfComplianceCount;
        }
        if ( Past1DaySpListComplianceCount != null ) {
            this.Past1DaySpListComplianceCount = Past1DaySpListComplianceCount;
        }
        if ( Past1DaySpListOutOfComplianceCount != null ) {
            this.Past1DaySpListOutOfComplianceCount = Past1DaySpListOutOfComplianceCount;
        }
        if ( Past1DayTeamsComplianceCount != null ) {
            this.Past1DayTeamsComplianceCount = Past1DayTeamsComplianceCount;
        }
        if ( Past1DayTeamsOutOfComplianceCount != null ) {
            this.Past1DayTeamsOutOfComplianceCount = Past1DayTeamsOutOfComplianceCount;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.Boolean? ExchangeOnColossus
            // GraphQL -> exchangeOnColossus: Boolean! (scalar)
            if (this.ExchangeOnColossus != null)
            {
                 s += ind + "exchangeOnColossus\n";

            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId != null)
            {
                 s += ind + "orgId\n";

            }
            //      C# -> System.Int32? Past1DayMailboxComplianceCount
            // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
            if (this.Past1DayMailboxComplianceCount != null)
            {
                 s += ind + "past1DayMailboxComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
            // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayMailboxOutOfComplianceCount != null)
            {
                 s += ind + "past1DayMailboxOutOfComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DayOnedriveComplianceCount
            // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
            if (this.Past1DayOnedriveComplianceCount != null)
            {
                 s += ind + "past1DayOnedriveComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
            // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayOnedriveOutOfComplianceCount != null)
            {
                 s += ind + "past1DayOnedriveOutOfComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DaySharepointComplianceCount
            // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
            if (this.Past1DaySharepointComplianceCount != null)
            {
                 s += ind + "past1DaySharepointComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
            // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
            if (this.Past1DaySharepointOutOfComplianceCount != null)
            {
                 s += ind + "past1DaySharepointOutOfComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DaySpListComplianceCount
            // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
            if (this.Past1DaySpListComplianceCount != null)
            {
                 s += ind + "past1DaySpListComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
            // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
            if (this.Past1DaySpListOutOfComplianceCount != null)
            {
                 s += ind + "past1DaySpListOutOfComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DayTeamsComplianceCount
            // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
            if (this.Past1DayTeamsComplianceCount != null)
            {
                 s += ind + "past1DayTeamsComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
            // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayTeamsOutOfComplianceCount != null)
            {
                 s += ind + "past1DayTeamsOutOfComplianceCount\n";

            }
            //      C# -> ProvisionStatus? Status
            // GraphQL -> status: ProvisionStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? ExchangeOnColossus
            // GraphQL -> exchangeOnColossus: Boolean! (scalar)
            if (this.ExchangeOnColossus == null && Exploration.Includes(parent + ".exchangeOnColossus$"))
            {
                this.ExchangeOnColossus = new System.Boolean();
            }
            //      C# -> System.String? OrgId
            // GraphQL -> orgId: String! (scalar)
            if (this.OrgId == null && Exploration.Includes(parent + ".orgId$"))
            {
                this.OrgId = new System.String("FETCH");
            }
            //      C# -> System.Int32? Past1DayMailboxComplianceCount
            // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
            if (this.Past1DayMailboxComplianceCount == null && Exploration.Includes(parent + ".past1DayMailboxComplianceCount$"))
            {
                this.Past1DayMailboxComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
            // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayMailboxOutOfComplianceCount == null && Exploration.Includes(parent + ".past1DayMailboxOutOfComplianceCount$"))
            {
                this.Past1DayMailboxOutOfComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DayOnedriveComplianceCount
            // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
            if (this.Past1DayOnedriveComplianceCount == null && Exploration.Includes(parent + ".past1DayOnedriveComplianceCount$"))
            {
                this.Past1DayOnedriveComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
            // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayOnedriveOutOfComplianceCount == null && Exploration.Includes(parent + ".past1DayOnedriveOutOfComplianceCount$"))
            {
                this.Past1DayOnedriveOutOfComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DaySharepointComplianceCount
            // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
            if (this.Past1DaySharepointComplianceCount == null && Exploration.Includes(parent + ".past1DaySharepointComplianceCount$"))
            {
                this.Past1DaySharepointComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
            // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
            if (this.Past1DaySharepointOutOfComplianceCount == null && Exploration.Includes(parent + ".past1DaySharepointOutOfComplianceCount$"))
            {
                this.Past1DaySharepointOutOfComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DaySpListComplianceCount
            // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
            if (this.Past1DaySpListComplianceCount == null && Exploration.Includes(parent + ".past1DaySpListComplianceCount$"))
            {
                this.Past1DaySpListComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
            // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
            if (this.Past1DaySpListOutOfComplianceCount == null && Exploration.Includes(parent + ".past1DaySpListOutOfComplianceCount$"))
            {
                this.Past1DaySpListOutOfComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DayTeamsComplianceCount
            // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
            if (this.Past1DayTeamsComplianceCount == null && Exploration.Includes(parent + ".past1DayTeamsComplianceCount$"))
            {
                this.Past1DayTeamsComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
            // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayTeamsOutOfComplianceCount == null && Exploration.Includes(parent + ".past1DayTeamsOutOfComplianceCount$"))
            {
                this.Past1DayTeamsOutOfComplianceCount = new System.Int32();
            }
            //      C# -> ProvisionStatus? Status
            // GraphQL -> status: ProvisionStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new ProvisionStatus();
            }
        }


    #endregion

    } // class O365OrgInfo
    #endregion

    public static class ListO365OrgInfoExtensions
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
            this List<O365OrgInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365OrgInfo> list, 
            String parent = "")
        {
            var item = new O365OrgInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types