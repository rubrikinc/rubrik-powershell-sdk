// SubscriptionType.cs
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
    #region SubscriptionType
    public class SubscriptionType: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsSubscribedToAllAudits
        // GraphQL -> isSubscribedToAllAudits: Boolean! (scalar)
        [JsonProperty("isSubscribedToAllAudits")]
        public System.Boolean? IsSubscribedToAllAudits { get; set; }

        //      C# -> System.Boolean? IsSubscribedToAllEvents
        // GraphQL -> isSubscribedToAllEvents: Boolean! (scalar)
        [JsonProperty("isSubscribedToAllEvents")]
        public System.Boolean? IsSubscribedToAllEvents { get; set; }

        //      C# -> List<UserAuditTypeEnum>? AuditTypes
        // GraphQL -> auditTypes: [UserAuditTypeEnum!]! (enum)
        [JsonProperty("auditTypes")]
        public List<UserAuditTypeEnum>? AuditTypes { get; set; }

        //      C# -> List<ActivityTypeEnum>? EventTypes
        // GraphQL -> eventTypes: [ActivityTypeEnum!]! (enum)
        [JsonProperty("eventTypes")]
        public List<ActivityTypeEnum>? EventTypes { get; set; }

        #endregion

    #region methods

    public SubscriptionType Set(
        System.Boolean? IsSubscribedToAllAudits = null,
        System.Boolean? IsSubscribedToAllEvents = null,
        List<UserAuditTypeEnum>? AuditTypes = null,
        List<ActivityTypeEnum>? EventTypes = null
    ) 
    {
        if ( IsSubscribedToAllAudits != null ) {
            this.IsSubscribedToAllAudits = IsSubscribedToAllAudits;
        }
        if ( IsSubscribedToAllEvents != null ) {
            this.IsSubscribedToAllEvents = IsSubscribedToAllEvents;
        }
        if ( AuditTypes != null ) {
            this.AuditTypes = AuditTypes;
        }
        if ( EventTypes != null ) {
            this.EventTypes = EventTypes;
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
            //      C# -> System.Boolean? IsSubscribedToAllAudits
            // GraphQL -> isSubscribedToAllAudits: Boolean! (scalar)
            if (this.IsSubscribedToAllAudits != null)
            {
                 s += ind + "isSubscribedToAllAudits\n";

            }
            //      C# -> System.Boolean? IsSubscribedToAllEvents
            // GraphQL -> isSubscribedToAllEvents: Boolean! (scalar)
            if (this.IsSubscribedToAllEvents != null)
            {
                 s += ind + "isSubscribedToAllEvents\n";

            }
            //      C# -> List<UserAuditTypeEnum>? AuditTypes
            // GraphQL -> auditTypes: [UserAuditTypeEnum!]! (enum)
            if (this.AuditTypes != null)
            {
                 s += ind + "auditTypes\n";

            }
            //      C# -> List<ActivityTypeEnum>? EventTypes
            // GraphQL -> eventTypes: [ActivityTypeEnum!]! (enum)
            if (this.EventTypes != null)
            {
                 s += ind + "eventTypes\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsSubscribedToAllAudits
            // GraphQL -> isSubscribedToAllAudits: Boolean! (scalar)
            if (this.IsSubscribedToAllAudits == null && Exploration.Includes(parent + ".isSubscribedToAllAudits$"))
            {
                this.IsSubscribedToAllAudits = new System.Boolean();
            }
            //      C# -> System.Boolean? IsSubscribedToAllEvents
            // GraphQL -> isSubscribedToAllEvents: Boolean! (scalar)
            if (this.IsSubscribedToAllEvents == null && Exploration.Includes(parent + ".isSubscribedToAllEvents$"))
            {
                this.IsSubscribedToAllEvents = new System.Boolean();
            }
            //      C# -> List<UserAuditTypeEnum>? AuditTypes
            // GraphQL -> auditTypes: [UserAuditTypeEnum!]! (enum)
            if (this.AuditTypes == null && Exploration.Includes(parent + ".auditTypes$"))
            {
                this.AuditTypes = new List<UserAuditTypeEnum>();
            }
            //      C# -> List<ActivityTypeEnum>? EventTypes
            // GraphQL -> eventTypes: [ActivityTypeEnum!]! (enum)
            if (this.EventTypes == null && Exploration.Includes(parent + ".eventTypes$"))
            {
                this.EventTypes = new List<ActivityTypeEnum>();
            }
        }


    #endregion

    } // class SubscriptionType
    #endregion

    public static class ListSubscriptionTypeExtensions
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
            this List<SubscriptionType> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SubscriptionType> list, 
            String parent = "")
        {
            var item = new SubscriptionType();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types