// SubscriptionType.cs
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
    #region SubscriptionType
    public class SubscriptionType: BaseType
    {
        #region members

        //      C# -> List<UserAuditTypeEnum>? AuditTypes
        // GraphQL -> auditTypes: [UserAuditTypeEnum!]! (enum)
        [JsonProperty("auditTypes")]
        public List<UserAuditTypeEnum>? AuditTypes { get; set; }

        //      C# -> List<ActivityTypeEnum>? EventTypes
        // GraphQL -> eventTypes: [ActivityTypeEnum!]! (enum)
        [JsonProperty("eventTypes")]
        public List<ActivityTypeEnum>? EventTypes { get; set; }

        //      C# -> System.Boolean? IsSubscribedToAllAudits
        // GraphQL -> isSubscribedToAllAudits: Boolean! (scalar)
        [JsonProperty("isSubscribedToAllAudits")]
        public System.Boolean? IsSubscribedToAllAudits { get; set; }

        //      C# -> System.Boolean? IsSubscribedToAllEvents
        // GraphQL -> isSubscribedToAllEvents: Boolean! (scalar)
        [JsonProperty("isSubscribedToAllEvents")]
        public System.Boolean? IsSubscribedToAllEvents { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SubscriptionType";
    }

    public SubscriptionType Set(
        List<UserAuditTypeEnum>? AuditTypes = null,
        List<ActivityTypeEnum>? EventTypes = null,
        System.Boolean? IsSubscribedToAllAudits = null,
        System.Boolean? IsSubscribedToAllEvents = null
    ) 
    {
        if ( AuditTypes != null ) {
            this.AuditTypes = AuditTypes;
        }
        if ( EventTypes != null ) {
            this.EventTypes = EventTypes;
        }
        if ( IsSubscribedToAllAudits != null ) {
            this.IsSubscribedToAllAudits = IsSubscribedToAllAudits;
        }
        if ( IsSubscribedToAllEvents != null ) {
            this.IsSubscribedToAllEvents = IsSubscribedToAllEvents;
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
        //      C# -> List<UserAuditTypeEnum>? AuditTypes
        // GraphQL -> auditTypes: [UserAuditTypeEnum!]! (enum)
        if (this.AuditTypes != null) {
            s += ind + "auditTypes\n" ;
        }
        //      C# -> List<ActivityTypeEnum>? EventTypes
        // GraphQL -> eventTypes: [ActivityTypeEnum!]! (enum)
        if (this.EventTypes != null) {
            s += ind + "eventTypes\n" ;
        }
        //      C# -> System.Boolean? IsSubscribedToAllAudits
        // GraphQL -> isSubscribedToAllAudits: Boolean! (scalar)
        if (this.IsSubscribedToAllAudits != null) {
            s += ind + "isSubscribedToAllAudits\n" ;
        }
        //      C# -> System.Boolean? IsSubscribedToAllEvents
        // GraphQL -> isSubscribedToAllEvents: Boolean! (scalar)
        if (this.IsSubscribedToAllEvents != null) {
            s += ind + "isSubscribedToAllEvents\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<UserAuditTypeEnum>? AuditTypes
        // GraphQL -> auditTypes: [UserAuditTypeEnum!]! (enum)
        if (this.AuditTypes == null && ec.Includes("auditTypes",true))
        {
            this.AuditTypes = new List<UserAuditTypeEnum>();
        }
        //      C# -> List<ActivityTypeEnum>? EventTypes
        // GraphQL -> eventTypes: [ActivityTypeEnum!]! (enum)
        if (this.EventTypes == null && ec.Includes("eventTypes",true))
        {
            this.EventTypes = new List<ActivityTypeEnum>();
        }
        //      C# -> System.Boolean? IsSubscribedToAllAudits
        // GraphQL -> isSubscribedToAllAudits: Boolean! (scalar)
        if (this.IsSubscribedToAllAudits == null && ec.Includes("isSubscribedToAllAudits",true))
        {
            this.IsSubscribedToAllAudits = true;
        }
        //      C# -> System.Boolean? IsSubscribedToAllEvents
        // GraphQL -> isSubscribedToAllEvents: Boolean! (scalar)
        if (this.IsSubscribedToAllEvents == null && ec.Includes("isSubscribedToAllEvents",true))
        {
            this.IsSubscribedToAllEvents = true;
        }
    }


    #endregion

    } // class SubscriptionType
    
    #endregion

    public static class ListSubscriptionTypeExtensions
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
            this List<SubscriptionType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SubscriptionType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SubscriptionType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SubscriptionType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types