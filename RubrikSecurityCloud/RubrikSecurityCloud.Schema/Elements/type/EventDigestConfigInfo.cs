// EventDigestConfigInfo.cs
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
    #region EventDigestConfigInfo
    public class EventDigestConfigInfo: BaseType
    {
        #region members

        //      C# -> List<ActivitySeverityEnum>? ActivitySeverity
        // GraphQL -> activitySeverity: [ActivitySeverityEnum!] (enum)
        [JsonProperty("activitySeverity")]
        public List<ActivitySeverityEnum>? ActivitySeverity { get; set; }

        //      C# -> List<ActivityStatusEnum>? ActivityStatus
        // GraphQL -> activityStatus: [ActivityStatusEnum!] (enum)
        [JsonProperty("activityStatus")]
        public List<ActivityStatusEnum>? ActivityStatus { get; set; }

        //      C# -> List<UserAuditTypeEnum>? AuditType
        // GraphQL -> auditType: [UserAuditTypeEnum!] (enum)
        [JsonProperty("auditType")]
        public List<UserAuditTypeEnum>? AuditType { get; set; }

        //      C# -> List<ActivityObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ActivityObjectTypeEnum!] (enum)
        [JsonProperty("objectType")]
        public List<ActivityObjectTypeEnum>? ObjectType { get; set; }

        //      C# -> List<System.String>? ActivityType
        // GraphQL -> activityType: [String!] (scalar)
        [JsonProperty("activityType")]
        public List<System.String>? ActivityType { get; set; }

        //      C# -> List<System.String>? Clusters
        // GraphQL -> clusters: [String!] (scalar)
        [JsonProperty("clusters")]
        public List<System.String>? Clusters { get; set; }

        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!] (scalar)
        [JsonProperty("emailAddresses")]
        public List<System.String>? EmailAddresses { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EventDigestConfigInfo";
    }

    public EventDigestConfigInfo Set(
        List<ActivitySeverityEnum>? ActivitySeverity = null,
        List<ActivityStatusEnum>? ActivityStatus = null,
        List<UserAuditTypeEnum>? AuditType = null,
        List<ActivityObjectTypeEnum>? ObjectType = null,
        List<System.String>? ActivityType = null,
        List<System.String>? Clusters = null,
        List<System.String>? EmailAddresses = null
    ) 
    {
        if ( ActivitySeverity != null ) {
            this.ActivitySeverity = ActivitySeverity;
        }
        if ( ActivityStatus != null ) {
            this.ActivityStatus = ActivityStatus;
        }
        if ( AuditType != null ) {
            this.AuditType = AuditType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( ActivityType != null ) {
            this.ActivityType = ActivityType;
        }
        if ( Clusters != null ) {
            this.Clusters = Clusters;
        }
        if ( EmailAddresses != null ) {
            this.EmailAddresses = EmailAddresses;
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
        //      C# -> List<ActivitySeverityEnum>? ActivitySeverity
        // GraphQL -> activitySeverity: [ActivitySeverityEnum!] (enum)
        if (this.ActivitySeverity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activitySeverity\n" ;
            } else {
                s += ind + "activitySeverity\n" ;
            }
        }
        //      C# -> List<ActivityStatusEnum>? ActivityStatus
        // GraphQL -> activityStatus: [ActivityStatusEnum!] (enum)
        if (this.ActivityStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activityStatus\n" ;
            } else {
                s += ind + "activityStatus\n" ;
            }
        }
        //      C# -> List<UserAuditTypeEnum>? AuditType
        // GraphQL -> auditType: [UserAuditTypeEnum!] (enum)
        if (this.AuditType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "auditType\n" ;
            } else {
                s += ind + "auditType\n" ;
            }
        }
        //      C# -> List<ActivityObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ActivityObjectTypeEnum!] (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> List<System.String>? ActivityType
        // GraphQL -> activityType: [String!] (scalar)
        if (this.ActivityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activityType\n" ;
            } else {
                s += ind + "activityType\n" ;
            }
        }
        //      C# -> List<System.String>? Clusters
        // GraphQL -> clusters: [String!] (scalar)
        if (this.Clusters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusters\n" ;
            } else {
                s += ind + "clusters\n" ;
            }
        }
        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!] (scalar)
        if (this.EmailAddresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "emailAddresses\n" ;
            } else {
                s += ind + "emailAddresses\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ActivitySeverityEnum>? ActivitySeverity
        // GraphQL -> activitySeverity: [ActivitySeverityEnum!] (enum)
        if (ec.Includes("activitySeverity",true))
        {
            if(this.ActivitySeverity == null) {

                this.ActivitySeverity = new List<ActivitySeverityEnum>();

            } else {


            }
        }
        else if (this.ActivitySeverity != null && ec.Excludes("activitySeverity",true))
        {
            this.ActivitySeverity = null;
        }
        //      C# -> List<ActivityStatusEnum>? ActivityStatus
        // GraphQL -> activityStatus: [ActivityStatusEnum!] (enum)
        if (ec.Includes("activityStatus",true))
        {
            if(this.ActivityStatus == null) {

                this.ActivityStatus = new List<ActivityStatusEnum>();

            } else {


            }
        }
        else if (this.ActivityStatus != null && ec.Excludes("activityStatus",true))
        {
            this.ActivityStatus = null;
        }
        //      C# -> List<UserAuditTypeEnum>? AuditType
        // GraphQL -> auditType: [UserAuditTypeEnum!] (enum)
        if (ec.Includes("auditType",true))
        {
            if(this.AuditType == null) {

                this.AuditType = new List<UserAuditTypeEnum>();

            } else {


            }
        }
        else if (this.AuditType != null && ec.Excludes("auditType",true))
        {
            this.AuditType = null;
        }
        //      C# -> List<ActivityObjectTypeEnum>? ObjectType
        // GraphQL -> objectType: [ActivityObjectTypeEnum!] (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new List<ActivityObjectTypeEnum>();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> List<System.String>? ActivityType
        // GraphQL -> activityType: [String!] (scalar)
        if (ec.Includes("activityType",true))
        {
            if(this.ActivityType == null) {

                this.ActivityType = new List<System.String>();

            } else {


            }
        }
        else if (this.ActivityType != null && ec.Excludes("activityType",true))
        {
            this.ActivityType = null;
        }
        //      C# -> List<System.String>? Clusters
        // GraphQL -> clusters: [String!] (scalar)
        if (ec.Includes("clusters",true))
        {
            if(this.Clusters == null) {

                this.Clusters = new List<System.String>();

            } else {


            }
        }
        else if (this.Clusters != null && ec.Excludes("clusters",true))
        {
            this.Clusters = null;
        }
        //      C# -> List<System.String>? EmailAddresses
        // GraphQL -> emailAddresses: [String!] (scalar)
        if (ec.Includes("emailAddresses",true))
        {
            if(this.EmailAddresses == null) {

                this.EmailAddresses = new List<System.String>();

            } else {


            }
        }
        else if (this.EmailAddresses != null && ec.Excludes("emailAddresses",true))
        {
            this.EmailAddresses = null;
        }
    }


    #endregion

    } // class EventDigestConfigInfo
    
    #endregion

    public static class ListEventDigestConfigInfoExtensions
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
            this List<EventDigestConfigInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EventDigestConfigInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EventDigestConfigInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EventDigestConfigInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EventDigestConfigInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types