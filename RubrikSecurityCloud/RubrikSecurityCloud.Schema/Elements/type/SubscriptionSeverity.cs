// SubscriptionSeverity.cs
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
    #region SubscriptionSeverity
    public class SubscriptionSeverity: BaseType
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

    public override string GetGqlTypeName() {
        return "SubscriptionSeverity";
    }

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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<UserAuditSeverityEnum>? AuditSeverities
        // GraphQL -> auditSeverities: [UserAuditSeverityEnum!]! (enum)
        if (this.AuditSeverities != null) {
            s += ind + "auditSeverities\n" ;
        }
        //      C# -> List<ActivitySeverityEnum>? EventSeverities
        // GraphQL -> eventSeverities: [ActivitySeverityEnum!]! (enum)
        if (this.EventSeverities != null) {
            s += ind + "eventSeverities\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<UserAuditSeverityEnum>? AuditSeverities
        // GraphQL -> auditSeverities: [UserAuditSeverityEnum!]! (enum)
        if (this.AuditSeverities == null && ec.Includes("auditSeverities",true))
        {
            this.AuditSeverities = new List<UserAuditSeverityEnum>();
        }
        //      C# -> List<ActivitySeverityEnum>? EventSeverities
        // GraphQL -> eventSeverities: [ActivitySeverityEnum!]! (enum)
        if (this.EventSeverities == null && ec.Includes("eventSeverities",true))
        {
            this.EventSeverities = new List<ActivitySeverityEnum>();
        }
    }


    #endregion

    } // class SubscriptionSeverity
    
    #endregion

    public static class ListSubscriptionSeverityExtensions
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
            this List<SubscriptionSeverity> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SubscriptionSeverity> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SubscriptionSeverity());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SubscriptionSeverity> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types