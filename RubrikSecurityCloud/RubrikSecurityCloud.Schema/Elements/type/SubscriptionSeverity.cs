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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<UserAuditSeverityEnum>? AuditSeverities
        // GraphQL -> auditSeverities: [UserAuditSeverityEnum!]! (enum)
        if (this.AuditSeverities != null) {
            if (conf.Flat) {
                s += conf.Prefix + "auditSeverities\n" ;
            } else {
                s += ind + "auditSeverities\n" ;
            }
        }
        //      C# -> List<ActivitySeverityEnum>? EventSeverities
        // GraphQL -> eventSeverities: [ActivitySeverityEnum!]! (enum)
        if (this.EventSeverities != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventSeverities\n" ;
            } else {
                s += ind + "eventSeverities\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<UserAuditSeverityEnum>? AuditSeverities
        // GraphQL -> auditSeverities: [UserAuditSeverityEnum!]! (enum)
        if (ec.Includes("auditSeverities",true))
        {
            if(this.AuditSeverities == null) {

                this.AuditSeverities = new List<UserAuditSeverityEnum>();

            } else {


            }
        }
        else if (this.AuditSeverities != null && ec.Excludes("auditSeverities",true))
        {
            this.AuditSeverities = null;
        }
        //      C# -> List<ActivitySeverityEnum>? EventSeverities
        // GraphQL -> eventSeverities: [ActivitySeverityEnum!]! (enum)
        if (ec.Includes("eventSeverities",true))
        {
            if(this.EventSeverities == null) {

                this.EventSeverities = new List<ActivitySeverityEnum>();

            } else {


            }
        }
        else if (this.EventSeverities != null && ec.Excludes("eventSeverities",true))
        {
            this.EventSeverities = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SubscriptionSeverity> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<SubscriptionSeverity> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types