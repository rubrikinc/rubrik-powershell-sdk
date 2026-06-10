// RemediationMetadata.cs
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
    #region RemediationMetadata
    public class RemediationMetadata: BaseType
    {
        #region members

        //      C# -> RemediationLocation? Location
        // GraphQL -> location: RemediationLocation! (enum)
        [JsonProperty("location")]
        public RemediationLocation? Location { get; set; }

        //      C# -> PolicyResourceType? ResourceType
        // GraphQL -> resourceType: PolicyResourceType! (enum)
        [JsonProperty("resourceType")]
        public PolicyResourceType? ResourceType { get; set; }

        //      C# -> RemediationState? State
        // GraphQL -> state: RemediationState! (enum)
        [JsonProperty("state")]
        public RemediationState? State { get; set; }

        //      C# -> RemediationType? Type
        // GraphQL -> type: RemediationType! (enum)
        [JsonProperty("type")]
        public RemediationType? Type { get; set; }

        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime (scalar)
        [JsonProperty("lastUpdatedAt")]
        public DateTime? LastUpdatedAt { get; set; }

        //      C# -> System.String? LastUpdatedBy
        // GraphQL -> lastUpdatedBy: String! (scalar)
        [JsonProperty("lastUpdatedBy")]
        public System.String? LastUpdatedBy { get; set; }

        //      C# -> System.String? PolicyViolationId
        // GraphQL -> policyViolationId: String! (scalar)
        [JsonProperty("policyViolationId")]
        public System.String? PolicyViolationId { get; set; }

        //      C# -> System.String? RemediationId
        // GraphQL -> remediationId: String! (scalar)
        [JsonProperty("remediationId")]
        public System.String? RemediationId { get; set; }

        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        [JsonProperty("resourceId")]
        public System.String? ResourceId { get; set; }

        //      C# -> RemediationActionDetails? RemediationDetails
        // GraphQL -> remediationDetails: RemediationActionDetails (type)
        [JsonProperty("remediationDetails")]
        public RemediationActionDetails? RemediationDetails { get; set; }

        //      C# -> RemediationTargets? Targets
        // GraphQL -> targets: RemediationTargets (type)
        [JsonProperty("targets")]
        public RemediationTargets? Targets { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RemediationMetadata";
    }

    public RemediationMetadata Set(
        RemediationLocation? Location = null,
        PolicyResourceType? ResourceType = null,
        RemediationState? State = null,
        RemediationType? Type = null,
        DateTime? LastUpdatedAt = null,
        System.String? LastUpdatedBy = null,
        System.String? PolicyViolationId = null,
        System.String? RemediationId = null,
        System.String? ResourceId = null,
        RemediationActionDetails? RemediationDetails = null,
        RemediationTargets? Targets = null
    ) 
    {
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( ResourceType != null ) {
            this.ResourceType = ResourceType;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( LastUpdatedAt != null ) {
            this.LastUpdatedAt = LastUpdatedAt;
        }
        if ( LastUpdatedBy != null ) {
            this.LastUpdatedBy = LastUpdatedBy;
        }
        if ( PolicyViolationId != null ) {
            this.PolicyViolationId = PolicyViolationId;
        }
        if ( RemediationId != null ) {
            this.RemediationId = RemediationId;
        }
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
        if ( RemediationDetails != null ) {
            this.RemediationDetails = RemediationDetails;
        }
        if ( Targets != null ) {
            this.Targets = Targets;
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
        //      C# -> RemediationLocation? Location
        // GraphQL -> location: RemediationLocation! (enum)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> PolicyResourceType? ResourceType
        // GraphQL -> resourceType: PolicyResourceType! (enum)
        if (this.ResourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceType\n" ;
            } else {
                s += ind + "resourceType\n" ;
            }
        }
        //      C# -> RemediationState? State
        // GraphQL -> state: RemediationState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> RemediationType? Type
        // GraphQL -> type: RemediationType! (enum)
        if (this.Type != null) {
            if (conf.Flat) {
                s += conf.Prefix + "type\n" ;
            } else {
                s += ind + "type\n" ;
            }
        }
        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime (scalar)
        if (this.LastUpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdatedAt\n" ;
            } else {
                s += ind + "lastUpdatedAt\n" ;
            }
        }
        //      C# -> System.String? LastUpdatedBy
        // GraphQL -> lastUpdatedBy: String! (scalar)
        if (this.LastUpdatedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdatedBy\n" ;
            } else {
                s += ind + "lastUpdatedBy\n" ;
            }
        }
        //      C# -> System.String? PolicyViolationId
        // GraphQL -> policyViolationId: String! (scalar)
        if (this.PolicyViolationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyViolationId\n" ;
            } else {
                s += ind + "policyViolationId\n" ;
            }
        }
        //      C# -> System.String? RemediationId
        // GraphQL -> remediationId: String! (scalar)
        if (this.RemediationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remediationId\n" ;
            } else {
                s += ind + "remediationId\n" ;
            }
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (this.ResourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceId\n" ;
            } else {
                s += ind + "resourceId\n" ;
            }
        }
        //      C# -> RemediationActionDetails? RemediationDetails
        // GraphQL -> remediationDetails: RemediationActionDetails (type)
        if (this.RemediationDetails != null) {
            var fspec = this.RemediationDetails.AsFieldSpec(conf.Child("remediationDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "remediationDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RemediationTargets? Targets
        // GraphQL -> targets: RemediationTargets (type)
        if (this.Targets != null) {
            var fspec = this.Targets.AsFieldSpec(conf.Child("targets"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targets" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RemediationLocation? Location
        // GraphQL -> location: RemediationLocation! (enum)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = new RemediationLocation();

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> PolicyResourceType? ResourceType
        // GraphQL -> resourceType: PolicyResourceType! (enum)
        if (ec.Includes("resourceType",true))
        {
            if(this.ResourceType == null) {

                this.ResourceType = new PolicyResourceType();

            } else {


            }
        }
        else if (this.ResourceType != null && ec.Excludes("resourceType",true))
        {
            this.ResourceType = null;
        }
        //      C# -> RemediationState? State
        // GraphQL -> state: RemediationState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new RemediationState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> RemediationType? Type
        // GraphQL -> type: RemediationType! (enum)
        if (ec.Includes("type",true))
        {
            if(this.Type == null) {

                this.Type = new RemediationType();

            } else {


            }
        }
        else if (this.Type != null && ec.Excludes("type",true))
        {
            this.Type = null;
        }
        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime (scalar)
        if (ec.Includes("lastUpdatedAt",true))
        {
            if(this.LastUpdatedAt == null) {

                this.LastUpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastUpdatedAt != null && ec.Excludes("lastUpdatedAt",true))
        {
            this.LastUpdatedAt = null;
        }
        //      C# -> System.String? LastUpdatedBy
        // GraphQL -> lastUpdatedBy: String! (scalar)
        if (ec.Includes("lastUpdatedBy",true))
        {
            if(this.LastUpdatedBy == null) {

                this.LastUpdatedBy = "FETCH";

            } else {


            }
        }
        else if (this.LastUpdatedBy != null && ec.Excludes("lastUpdatedBy",true))
        {
            this.LastUpdatedBy = null;
        }
        //      C# -> System.String? PolicyViolationId
        // GraphQL -> policyViolationId: String! (scalar)
        if (ec.Includes("policyViolationId",true))
        {
            if(this.PolicyViolationId == null) {

                this.PolicyViolationId = "FETCH";

            } else {


            }
        }
        else if (this.PolicyViolationId != null && ec.Excludes("policyViolationId",true))
        {
            this.PolicyViolationId = null;
        }
        //      C# -> System.String? RemediationId
        // GraphQL -> remediationId: String! (scalar)
        if (ec.Includes("remediationId",true))
        {
            if(this.RemediationId == null) {

                this.RemediationId = "FETCH";

            } else {


            }
        }
        else if (this.RemediationId != null && ec.Excludes("remediationId",true))
        {
            this.RemediationId = null;
        }
        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        if (ec.Includes("resourceId",true))
        {
            if(this.ResourceId == null) {

                this.ResourceId = "FETCH";

            } else {


            }
        }
        else if (this.ResourceId != null && ec.Excludes("resourceId",true))
        {
            this.ResourceId = null;
        }
        //      C# -> RemediationActionDetails? RemediationDetails
        // GraphQL -> remediationDetails: RemediationActionDetails (type)
        if (ec.Includes("remediationDetails",false))
        {
            if(this.RemediationDetails == null) {

                this.RemediationDetails = new RemediationActionDetails();
                this.RemediationDetails.ApplyExploratoryFieldSpec(ec.NewChild("remediationDetails"));

            } else {

                this.RemediationDetails.ApplyExploratoryFieldSpec(ec.NewChild("remediationDetails"));

            }
        }
        else if (this.RemediationDetails != null && ec.Excludes("remediationDetails",false))
        {
            this.RemediationDetails = null;
        }
        //      C# -> RemediationTargets? Targets
        // GraphQL -> targets: RemediationTargets (type)
        if (ec.Includes("targets",false))
        {
            if(this.Targets == null) {

                this.Targets = new RemediationTargets();
                this.Targets.ApplyExploratoryFieldSpec(ec.NewChild("targets"));

            } else {

                this.Targets.ApplyExploratoryFieldSpec(ec.NewChild("targets"));

            }
        }
        else if (this.Targets != null && ec.Excludes("targets",false))
        {
            this.Targets = null;
        }
    }


    #endregion

    } // class RemediationMetadata
    
    #endregion

    public static class ListRemediationMetadataExtensions
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
            this List<RemediationMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RemediationMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RemediationMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RemediationMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RemediationMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types