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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<UserAuditTypeEnum>? AuditTypes
        // GraphQL -> auditTypes: [UserAuditTypeEnum!]! (enum)
        if (this.AuditTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "auditTypes\n" ;
            } else {
                s += ind + "auditTypes\n" ;
            }
        }
        //      C# -> List<ActivityTypeEnum>? EventTypes
        // GraphQL -> eventTypes: [ActivityTypeEnum!]! (enum)
        if (this.EventTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventTypes\n" ;
            } else {
                s += ind + "eventTypes\n" ;
            }
        }
        //      C# -> System.Boolean? IsSubscribedToAllAudits
        // GraphQL -> isSubscribedToAllAudits: Boolean! (scalar)
        if (this.IsSubscribedToAllAudits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSubscribedToAllAudits\n" ;
            } else {
                s += ind + "isSubscribedToAllAudits\n" ;
            }
        }
        //      C# -> System.Boolean? IsSubscribedToAllEvents
        // GraphQL -> isSubscribedToAllEvents: Boolean! (scalar)
        if (this.IsSubscribedToAllEvents != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSubscribedToAllEvents\n" ;
            } else {
                s += ind + "isSubscribedToAllEvents\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<UserAuditTypeEnum>? AuditTypes
        // GraphQL -> auditTypes: [UserAuditTypeEnum!]! (enum)
        if (ec.Includes("auditTypes",true))
        {
            if(this.AuditTypes == null) {

                this.AuditTypes = new List<UserAuditTypeEnum>();

            } else {


            }
        }
        else if (this.AuditTypes != null && ec.Excludes("auditTypes",true))
        {
            this.AuditTypes = null;
        }
        //      C# -> List<ActivityTypeEnum>? EventTypes
        // GraphQL -> eventTypes: [ActivityTypeEnum!]! (enum)
        if (ec.Includes("eventTypes",true))
        {
            if(this.EventTypes == null) {

                this.EventTypes = new List<ActivityTypeEnum>();

            } else {


            }
        }
        else if (this.EventTypes != null && ec.Excludes("eventTypes",true))
        {
            this.EventTypes = null;
        }
        //      C# -> System.Boolean? IsSubscribedToAllAudits
        // GraphQL -> isSubscribedToAllAudits: Boolean! (scalar)
        if (ec.Includes("isSubscribedToAllAudits",true))
        {
            if(this.IsSubscribedToAllAudits == null) {

                this.IsSubscribedToAllAudits = true;

            } else {


            }
        }
        else if (this.IsSubscribedToAllAudits != null && ec.Excludes("isSubscribedToAllAudits",true))
        {
            this.IsSubscribedToAllAudits = null;
        }
        //      C# -> System.Boolean? IsSubscribedToAllEvents
        // GraphQL -> isSubscribedToAllEvents: Boolean! (scalar)
        if (ec.Includes("isSubscribedToAllEvents",true))
        {
            if(this.IsSubscribedToAllEvents == null) {

                this.IsSubscribedToAllEvents = true;

            } else {


            }
        }
        else if (this.IsSubscribedToAllEvents != null && ec.Excludes("isSubscribedToAllEvents",true))
        {
            this.IsSubscribedToAllEvents = null;
        }
    }


    #endregion

    } // class SubscriptionType
    
    #endregion

    public static class ListSubscriptionTypeExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SubscriptionType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SubscriptionType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<SubscriptionType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types