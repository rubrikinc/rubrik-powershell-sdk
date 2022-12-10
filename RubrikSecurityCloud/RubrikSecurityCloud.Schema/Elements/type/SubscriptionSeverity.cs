// SubscriptionSeverity.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:01.
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
    #region SubscriptionSeverity
    public class SubscriptionSeverity: IFragment
    {
        #region members
        //      C# -> List<UserAuditSeverityEnum>? AuditSeverities
        // GraphQL -> auditSeverities: [UserAuditSeverityEnum!]! (enum)
        [JsonProperty("auditSeverities")]
        public List<UserAuditSeverityEnum>? AuditSeverities { get; set; }

        //      C# -> List<ActivitySeverityEnum>? EventSeverities
        // GraphQL -> eventSeverities: [ActivitySeverityEnum!]! (enum)
        [JsonProperty("eventSeverities")]
        public List<ActivitySeverityEnum>? EventSeverities { get; set; }

        #endregion

    #region methods

    public SubscriptionSeverity Set(
        List<UserAuditSeverityEnum>? AuditSeverities = null,
        List<ActivitySeverityEnum>? EventSeverities = null
    ) 
    {
        if ( AuditSeverities != null ) {
            this.AuditSeverities = AuditSeverities;
        }
        if ( EventSeverities != null ) {
            this.EventSeverities = EventSeverities;
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
            //      C# -> List<UserAuditSeverityEnum>? AuditSeverities
            // GraphQL -> auditSeverities: [UserAuditSeverityEnum!]! (enum)
            if (this.AuditSeverities != null)
            {
                 s += ind + "auditSeverities\n";

            }
            //      C# -> List<ActivitySeverityEnum>? EventSeverities
            // GraphQL -> eventSeverities: [ActivitySeverityEnum!]! (enum)
            if (this.EventSeverities != null)
            {
                 s += ind + "eventSeverities\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<UserAuditSeverityEnum>? AuditSeverities
            // GraphQL -> auditSeverities: [UserAuditSeverityEnum!]! (enum)
            if (this.AuditSeverities == null && Exploration.Includes(parent + ".auditSeverities$"))
            {
                this.AuditSeverities = new List<UserAuditSeverityEnum>();
            }
            //      C# -> List<ActivitySeverityEnum>? EventSeverities
            // GraphQL -> eventSeverities: [ActivitySeverityEnum!]! (enum)
            if (this.EventSeverities == null && Exploration.Includes(parent + ".eventSeverities$"))
            {
                this.EventSeverities = new List<ActivitySeverityEnum>();
            }
        }


    #endregion

    } // class SubscriptionSeverity
    #endregion

    public static class ListSubscriptionSeverityExtensions
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
            this List<SubscriptionSeverity> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SubscriptionSeverity> list, 
            String parent = "")
        {
            var item = new SubscriptionSeverity();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types