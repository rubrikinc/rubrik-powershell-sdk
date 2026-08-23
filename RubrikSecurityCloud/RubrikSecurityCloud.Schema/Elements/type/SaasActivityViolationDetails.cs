// SaasActivityViolationDetails.cs
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
    #region SaasActivityViolationDetails
 
    public class SaasActivityViolationDetails: BaseType, ViolationDetailsUnion
    {
        #region members

        //      C# -> System.String? ActivityId
        // GraphQL -> activityId: String! (scalar)
        [JsonProperty("activityId")]
        public System.String? ActivityId { get; set; }

        //      C# -> System.String? ActivityType
        // GraphQL -> activityType: String! (scalar)
        [JsonProperty("activityType")]
        public System.String? ActivityType { get; set; }

        //      C# -> System.String? ActorEmail
        // GraphQL -> actorEmail: String! (scalar)
        [JsonProperty("actorEmail")]
        public System.String? ActorEmail { get; set; }

        //      C# -> System.String? ActorType
        // GraphQL -> actorType: String! (scalar)
        [JsonProperty("actorType")]
        public System.String? ActorType { get; set; }

        //      C# -> DateTime? EventCreatedAt
        // GraphQL -> eventCreatedAt: DateTime (scalar)
        [JsonProperty("eventCreatedAt")]
        public DateTime? EventCreatedAt { get; set; }

        //      C# -> System.String? RscOrgId
        // GraphQL -> rscOrgId: String! (scalar)
        [JsonProperty("rscOrgId")]
        public System.String? RscOrgId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SaasActivityViolationDetails";
    }

    public SaasActivityViolationDetails Set(
        System.String? ActivityId = null,
        System.String? ActivityType = null,
        System.String? ActorEmail = null,
        System.String? ActorType = null,
        DateTime? EventCreatedAt = null,
        System.String? RscOrgId = null
    ) 
    {
        if ( ActivityId != null ) {
            this.ActivityId = ActivityId;
        }
        if ( ActivityType != null ) {
            this.ActivityType = ActivityType;
        }
        if ( ActorEmail != null ) {
            this.ActorEmail = ActorEmail;
        }
        if ( ActorType != null ) {
            this.ActorType = ActorType;
        }
        if ( EventCreatedAt != null ) {
            this.EventCreatedAt = EventCreatedAt;
        }
        if ( RscOrgId != null ) {
            this.RscOrgId = RscOrgId;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ActivityId
        // GraphQL -> activityId: String! (scalar)
        if (this.ActivityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activityId\n" ;
            } else {
                s += ind + "activityId\n" ;
            }
        }
        //      C# -> System.String? ActivityType
        // GraphQL -> activityType: String! (scalar)
        if (this.ActivityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activityType\n" ;
            } else {
                s += ind + "activityType\n" ;
            }
        }
        //      C# -> System.String? ActorEmail
        // GraphQL -> actorEmail: String! (scalar)
        if (this.ActorEmail != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorEmail\n" ;
            } else {
                s += ind + "actorEmail\n" ;
            }
        }
        //      C# -> System.String? ActorType
        // GraphQL -> actorType: String! (scalar)
        if (this.ActorType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorType\n" ;
            } else {
                s += ind + "actorType\n" ;
            }
        }
        //      C# -> DateTime? EventCreatedAt
        // GraphQL -> eventCreatedAt: DateTime (scalar)
        if (this.EventCreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventCreatedAt\n" ;
            } else {
                s += ind + "eventCreatedAt\n" ;
            }
        }
        //      C# -> System.String? RscOrgId
        // GraphQL -> rscOrgId: String! (scalar)
        if (this.RscOrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rscOrgId\n" ;
            } else {
                s += ind + "rscOrgId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ActivityId
        // GraphQL -> activityId: String! (scalar)
        if (ec.Includes("activityId",true))
        {
            if(this.ActivityId == null) {

                this.ActivityId = "FETCH";

            } else {


            }
        }
        else if (this.ActivityId != null && ec.Excludes("activityId",true))
        {
            this.ActivityId = null;
        }
        //      C# -> System.String? ActivityType
        // GraphQL -> activityType: String! (scalar)
        if (ec.Includes("activityType",true))
        {
            if(this.ActivityType == null) {

                this.ActivityType = "FETCH";

            } else {


            }
        }
        else if (this.ActivityType != null && ec.Excludes("activityType",true))
        {
            this.ActivityType = null;
        }
        //      C# -> System.String? ActorEmail
        // GraphQL -> actorEmail: String! (scalar)
        if (ec.Includes("actorEmail",true))
        {
            if(this.ActorEmail == null) {

                this.ActorEmail = "FETCH";

            } else {


            }
        }
        else if (this.ActorEmail != null && ec.Excludes("actorEmail",true))
        {
            this.ActorEmail = null;
        }
        //      C# -> System.String? ActorType
        // GraphQL -> actorType: String! (scalar)
        if (ec.Includes("actorType",true))
        {
            if(this.ActorType == null) {

                this.ActorType = "FETCH";

            } else {


            }
        }
        else if (this.ActorType != null && ec.Excludes("actorType",true))
        {
            this.ActorType = null;
        }
        //      C# -> DateTime? EventCreatedAt
        // GraphQL -> eventCreatedAt: DateTime (scalar)
        if (ec.Includes("eventCreatedAt",true))
        {
            if(this.EventCreatedAt == null) {

                this.EventCreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.EventCreatedAt != null && ec.Excludes("eventCreatedAt",true))
        {
            this.EventCreatedAt = null;
        }
        //      C# -> System.String? RscOrgId
        // GraphQL -> rscOrgId: String! (scalar)
        if (ec.Includes("rscOrgId",true))
        {
            if(this.RscOrgId == null) {

                this.RscOrgId = "FETCH";

            } else {


            }
        }
        else if (this.RscOrgId != null && ec.Excludes("rscOrgId",true))
        {
            this.RscOrgId = null;
        }
    }


    #endregion

    } // class SaasActivityViolationDetails
    
    #endregion

    public static class ListSaasActivityViolationDetailsExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SaasActivityViolationDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SaasActivityViolationDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SaasActivityViolationDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SaasActivityViolationDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SaasActivityViolationDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types