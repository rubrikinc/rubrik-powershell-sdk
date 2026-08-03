// IdentityEventViolationDetails.cs
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
    #region IdentityEventViolationDetails
 
    public class IdentityEventViolationDetails: BaseType, ViolationDetailsUnion
    {
        #region members

        //      C# -> LambdaEventType? EventType
        // GraphQL -> eventType: LambdaEventType! (enum)
        [JsonProperty("eventType")]
        public LambdaEventType? EventType { get; set; }

        //      C# -> GpoStatus? GpoStatus
        // GraphQL -> gpoStatus: GpoStatus! (enum)
        [JsonProperty("gpoStatus")]
        public GpoStatus? GpoStatus { get; set; }

        //      C# -> RemediationState? RevertStatus
        // GraphQL -> revertStatus: RemediationState! (enum)
        [JsonProperty("revertStatus")]
        public RemediationState? RevertStatus { get; set; }

        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        [JsonProperty("actorIdentityId")]
        public System.String? ActorIdentityId { get; set; }

        //      C# -> DateTime? EventTime
        // GraphQL -> eventTime: DateTime (scalar)
        [JsonProperty("eventTime")]
        public DateTime? EventTime { get; set; }

        //      C# -> System.String? SourceIdentityId
        // GraphQL -> sourceIdentityId: String! (scalar)
        [JsonProperty("sourceIdentityId")]
        public System.String? SourceIdentityId { get; set; }

        //      C# -> IdentityInfo? ActorIdentityDetails
        // GraphQL -> actorIdentityDetails: IdentityInfo (type)
        [JsonProperty("actorIdentityDetails")]
        public IdentityInfo? ActorIdentityDetails { get; set; }

        //      C# -> IdentityInfo? SourceIdentityDetails
        // GraphQL -> sourceIdentityDetails: IdentityInfo (type)
        [JsonProperty("sourceIdentityDetails")]
        public IdentityInfo? SourceIdentityDetails { get; set; }

        //      C# -> IdentityInfo? TargetIdentityDetails
        // GraphQL -> targetIdentityDetails: IdentityInfo (type)
        [JsonProperty("targetIdentityDetails")]
        public IdentityInfo? TargetIdentityDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityEventViolationDetails";
    }

    public IdentityEventViolationDetails Set(
        LambdaEventType? EventType = null,
        GpoStatus? GpoStatus = null,
        RemediationState? RevertStatus = null,
        System.String? ActorIdentityId = null,
        DateTime? EventTime = null,
        System.String? SourceIdentityId = null,
        IdentityInfo? ActorIdentityDetails = null,
        IdentityInfo? SourceIdentityDetails = null,
        IdentityInfo? TargetIdentityDetails = null
    ) 
    {
        if ( EventType != null ) {
            this.EventType = EventType;
        }
        if ( GpoStatus != null ) {
            this.GpoStatus = GpoStatus;
        }
        if ( RevertStatus != null ) {
            this.RevertStatus = RevertStatus;
        }
        if ( ActorIdentityId != null ) {
            this.ActorIdentityId = ActorIdentityId;
        }
        if ( EventTime != null ) {
            this.EventTime = EventTime;
        }
        if ( SourceIdentityId != null ) {
            this.SourceIdentityId = SourceIdentityId;
        }
        if ( ActorIdentityDetails != null ) {
            this.ActorIdentityDetails = ActorIdentityDetails;
        }
        if ( SourceIdentityDetails != null ) {
            this.SourceIdentityDetails = SourceIdentityDetails;
        }
        if ( TargetIdentityDetails != null ) {
            this.TargetIdentityDetails = TargetIdentityDetails;
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
        //      C# -> LambdaEventType? EventType
        // GraphQL -> eventType: LambdaEventType! (enum)
        if (this.EventType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventType\n" ;
            } else {
                s += ind + "eventType\n" ;
            }
        }
        //      C# -> GpoStatus? GpoStatus
        // GraphQL -> gpoStatus: GpoStatus! (enum)
        if (this.GpoStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gpoStatus\n" ;
            } else {
                s += ind + "gpoStatus\n" ;
            }
        }
        //      C# -> RemediationState? RevertStatus
        // GraphQL -> revertStatus: RemediationState! (enum)
        if (this.RevertStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "revertStatus\n" ;
            } else {
                s += ind + "revertStatus\n" ;
            }
        }
        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        if (this.ActorIdentityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorIdentityId\n" ;
            } else {
                s += ind + "actorIdentityId\n" ;
            }
        }
        //      C# -> DateTime? EventTime
        // GraphQL -> eventTime: DateTime (scalar)
        if (this.EventTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventTime\n" ;
            } else {
                s += ind + "eventTime\n" ;
            }
        }
        //      C# -> System.String? SourceIdentityId
        // GraphQL -> sourceIdentityId: String! (scalar)
        if (this.SourceIdentityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceIdentityId\n" ;
            } else {
                s += ind + "sourceIdentityId\n" ;
            }
        }
        //      C# -> IdentityInfo? ActorIdentityDetails
        // GraphQL -> actorIdentityDetails: IdentityInfo (type)
        if (this.ActorIdentityDetails != null) {
            var fspec = this.ActorIdentityDetails.AsFieldSpec(conf.Child("actorIdentityDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "actorIdentityDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IdentityInfo? SourceIdentityDetails
        // GraphQL -> sourceIdentityDetails: IdentityInfo (type)
        if (this.SourceIdentityDetails != null) {
            var fspec = this.SourceIdentityDetails.AsFieldSpec(conf.Child("sourceIdentityDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceIdentityDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IdentityInfo? TargetIdentityDetails
        // GraphQL -> targetIdentityDetails: IdentityInfo (type)
        if (this.TargetIdentityDetails != null) {
            var fspec = this.TargetIdentityDetails.AsFieldSpec(conf.Child("targetIdentityDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetIdentityDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> LambdaEventType? EventType
        // GraphQL -> eventType: LambdaEventType! (enum)
        if (ec.Includes("eventType",true))
        {
            if(this.EventType == null) {

                this.EventType = new LambdaEventType();

            } else {


            }
        }
        else if (this.EventType != null && ec.Excludes("eventType",true))
        {
            this.EventType = null;
        }
        //      C# -> GpoStatus? GpoStatus
        // GraphQL -> gpoStatus: GpoStatus! (enum)
        if (ec.Includes("gpoStatus",true))
        {
            if(this.GpoStatus == null) {

                this.GpoStatus = new GpoStatus();

            } else {


            }
        }
        else if (this.GpoStatus != null && ec.Excludes("gpoStatus",true))
        {
            this.GpoStatus = null;
        }
        //      C# -> RemediationState? RevertStatus
        // GraphQL -> revertStatus: RemediationState! (enum)
        if (ec.Includes("revertStatus",true))
        {
            if(this.RevertStatus == null) {

                this.RevertStatus = new RemediationState();

            } else {


            }
        }
        else if (this.RevertStatus != null && ec.Excludes("revertStatus",true))
        {
            this.RevertStatus = null;
        }
        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        if (ec.Includes("actorIdentityId",true))
        {
            if(this.ActorIdentityId == null) {

                this.ActorIdentityId = "FETCH";

            } else {


            }
        }
        else if (this.ActorIdentityId != null && ec.Excludes("actorIdentityId",true))
        {
            this.ActorIdentityId = null;
        }
        //      C# -> DateTime? EventTime
        // GraphQL -> eventTime: DateTime (scalar)
        if (ec.Includes("eventTime",true))
        {
            if(this.EventTime == null) {

                this.EventTime = new DateTime();

            } else {


            }
        }
        else if (this.EventTime != null && ec.Excludes("eventTime",true))
        {
            this.EventTime = null;
        }
        //      C# -> System.String? SourceIdentityId
        // GraphQL -> sourceIdentityId: String! (scalar)
        if (ec.Includes("sourceIdentityId",true))
        {
            if(this.SourceIdentityId == null) {

                this.SourceIdentityId = "FETCH";

            } else {


            }
        }
        else if (this.SourceIdentityId != null && ec.Excludes("sourceIdentityId",true))
        {
            this.SourceIdentityId = null;
        }
        //      C# -> IdentityInfo? ActorIdentityDetails
        // GraphQL -> actorIdentityDetails: IdentityInfo (type)
        if (ec.Includes("actorIdentityDetails",false))
        {
            if(this.ActorIdentityDetails == null) {

                this.ActorIdentityDetails = new IdentityInfo();
                this.ActorIdentityDetails.ApplyExploratoryFieldSpec(ec.NewChild("actorIdentityDetails"));

            } else {

                this.ActorIdentityDetails.ApplyExploratoryFieldSpec(ec.NewChild("actorIdentityDetails"));

            }
        }
        else if (this.ActorIdentityDetails != null && ec.Excludes("actorIdentityDetails",false))
        {
            this.ActorIdentityDetails = null;
        }
        //      C# -> IdentityInfo? SourceIdentityDetails
        // GraphQL -> sourceIdentityDetails: IdentityInfo (type)
        if (ec.Includes("sourceIdentityDetails",false))
        {
            if(this.SourceIdentityDetails == null) {

                this.SourceIdentityDetails = new IdentityInfo();
                this.SourceIdentityDetails.ApplyExploratoryFieldSpec(ec.NewChild("sourceIdentityDetails"));

            } else {

                this.SourceIdentityDetails.ApplyExploratoryFieldSpec(ec.NewChild("sourceIdentityDetails"));

            }
        }
        else if (this.SourceIdentityDetails != null && ec.Excludes("sourceIdentityDetails",false))
        {
            this.SourceIdentityDetails = null;
        }
        //      C# -> IdentityInfo? TargetIdentityDetails
        // GraphQL -> targetIdentityDetails: IdentityInfo (type)
        if (ec.Includes("targetIdentityDetails",false))
        {
            if(this.TargetIdentityDetails == null) {

                this.TargetIdentityDetails = new IdentityInfo();
                this.TargetIdentityDetails.ApplyExploratoryFieldSpec(ec.NewChild("targetIdentityDetails"));

            } else {

                this.TargetIdentityDetails.ApplyExploratoryFieldSpec(ec.NewChild("targetIdentityDetails"));

            }
        }
        else if (this.TargetIdentityDetails != null && ec.Excludes("targetIdentityDetails",false))
        {
            this.TargetIdentityDetails = null;
        }
    }


    #endregion

    } // class IdentityEventViolationDetails
    
    #endregion

    public static class ListIdentityEventViolationDetailsExtensions
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
            this List<IdentityEventViolationDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IdentityEventViolationDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdentityEventViolationDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdentityEventViolationDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdentityEventViolationDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types