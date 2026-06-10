// PolicyViolation.cs
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
    #region PolicyViolation
    public class PolicyViolation: BaseType
    {
        #region members

        //      C# -> Severity? ResourceMaxSeverity
        // GraphQL -> resourceMaxSeverity: Severity! (enum)
        [JsonProperty("resourceMaxSeverity")]
        public Severity? ResourceMaxSeverity { get; set; }

        //      C# -> PolicyResourceType? ResourceType
        // GraphQL -> resourceType: PolicyResourceType! (enum)
        [JsonProperty("resourceType")]
        public PolicyResourceType? ResourceType { get; set; }

        //      C# -> PolicyResourceType? SecondaryResourceType
        // GraphQL -> secondaryResourceType: PolicyResourceType! (enum)
        [JsonProperty("secondaryResourceType")]
        public PolicyResourceType? SecondaryResourceType { get; set; }

        //      C# -> PolicyViolationStatus? Status
        // GraphQL -> status: PolicyViolationStatus! (enum)
        [JsonProperty("status")]
        public PolicyViolationStatus? Status { get; set; }

        //      C# -> PolicyViolationStatusReason? StatusReason
        // GraphQL -> statusReason: PolicyViolationStatusReason! (enum)
        [JsonProperty("statusReason")]
        public PolicyViolationStatusReason? StatusReason { get; set; }

        //      C# -> Severity? ViolationSeverity
        // GraphQL -> violationSeverity: Severity! (enum)
        [JsonProperty("violationSeverity")]
        public Severity? ViolationSeverity { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> DateTime? LastEvaluatedAt
        // GraphQL -> lastEvaluatedAt: DateTime (scalar)
        [JsonProperty("lastEvaluatedAt")]
        public DateTime? LastEvaluatedAt { get; set; }

        //      C# -> DateTime? LastUpdatedAt
        // GraphQL -> lastUpdatedAt: DateTime (scalar)
        [JsonProperty("lastUpdatedAt")]
        public DateTime? LastUpdatedAt { get; set; }

        //      C# -> System.String? LastUpdatedBy
        // GraphQL -> lastUpdatedBy: String! (scalar)
        [JsonProperty("lastUpdatedBy")]
        public System.String? LastUpdatedBy { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OriginId
        // GraphQL -> originId: String (scalar)
        [JsonProperty("originId")]
        public System.String? OriginId { get; set; }

        //      C# -> DateTime? OriginStartTime
        // GraphQL -> originStartTime: DateTime (scalar)
        [JsonProperty("originStartTime")]
        public DateTime? OriginStartTime { get; set; }

        //      C# -> System.String? ParentPolicyViolationId
        // GraphQL -> parentPolicyViolationId: String (scalar)
        [JsonProperty("parentPolicyViolationId")]
        public System.String? ParentPolicyViolationId { get; set; }

        //      C# -> System.Int32? PolicyVersion
        // GraphQL -> policyVersion: Int! (scalar)
        [JsonProperty("policyVersion")]
        public System.Int32? PolicyVersion { get; set; }

        //      C# -> System.String? PolicyViolationId
        // GraphQL -> policyViolationId: String! (scalar)
        [JsonProperty("policyViolationId")]
        public System.String? PolicyViolationId { get; set; }

        //      C# -> System.Int32? ResourceCriticalViolationsCount
        // GraphQL -> resourceCriticalViolationsCount: Int! (scalar)
        [JsonProperty("resourceCriticalViolationsCount")]
        public System.Int32? ResourceCriticalViolationsCount { get; set; }

        //      C# -> System.Int32? ResourceHighViolationsCount
        // GraphQL -> resourceHighViolationsCount: Int! (scalar)
        [JsonProperty("resourceHighViolationsCount")]
        public System.Int32? ResourceHighViolationsCount { get; set; }

        //      C# -> System.String? ResourceId
        // GraphQL -> resourceId: String! (scalar)
        [JsonProperty("resourceId")]
        public System.String? ResourceId { get; set; }

        //      C# -> System.Int32? ResourceLowViolationsCount
        // GraphQL -> resourceLowViolationsCount: Int! (scalar)
        [JsonProperty("resourceLowViolationsCount")]
        public System.Int32? ResourceLowViolationsCount { get; set; }

        //      C# -> System.Int32? ResourceMediumViolationsCount
        // GraphQL -> resourceMediumViolationsCount: Int! (scalar)
        [JsonProperty("resourceMediumViolationsCount")]
        public System.Int32? ResourceMediumViolationsCount { get; set; }

        //      C# -> System.Int32? ResourceViolationsCount
        // GraphQL -> resourceViolationsCount: Int! (scalar)
        [JsonProperty("resourceViolationsCount")]
        public System.Int32? ResourceViolationsCount { get; set; }

        //      C# -> System.String? SecondaryResourceId
        // GraphQL -> secondaryResourceId: String (scalar)
        [JsonProperty("secondaryResourceId")]
        public System.String? SecondaryResourceId { get; set; }

        //      C# -> System.String? UserFriendlyViolationId
        // GraphQL -> userFriendlyViolationId: String! (scalar)
        [JsonProperty("userFriendlyViolationId")]
        public System.String? UserFriendlyViolationId { get; set; }

        //      C# -> DspmPolicy? Policy
        // GraphQL -> policy: DSPMPolicy! (type)
        [JsonProperty("policy")]
        public DspmPolicy? Policy { get; set; }

        //      C# -> List<RemediationAvailability>? PossibleRemediationsForViolationTarget
        // GraphQL -> possibleRemediationsForViolationTarget: [RemediationAvailability!] (type)
        [JsonProperty("possibleRemediationsForViolationTarget")]
        public List<RemediationAvailability>? PossibleRemediationsForViolationTarget { get; set; }

        //      C# -> List<RemediationMetadata>? Remediations
        // GraphQL -> remediations: [RemediationMetadata!] (type)
        [JsonProperty("remediations")]
        public List<RemediationMetadata>? Remediations { get; set; }

        //      C# -> ResourceMetadata? ResourceMetadata
        // GraphQL -> resourceMetadata: ResourceMetadata (type)
        [JsonProperty("resourceMetadata")]
        public ResourceMetadata? ResourceMetadata { get; set; }

        //      C# -> User? UserLastUpdated
        // GraphQL -> userLastUpdated: User (type)
        [JsonProperty("userLastUpdated")]
        public User? UserLastUpdated { get; set; }

        //      C# -> ViolationSummaryForResource? ViolationSummaryForResource
        // GraphQL -> violationSummaryForResource: ViolationSummaryForResource (type)
        [JsonProperty("violationSummaryForResource")]
        public ViolationSummaryForResource? ViolationSummaryForResource { get; set; }

        //      C# -> ViolationDetailsUnion? Details
        // GraphQL -> details: ViolationDetailsUnion (union)
        [JsonProperty("details")]
        public ViolationDetailsUnion? Details { get; set; }

        [JsonProperty("vars")]
        public InlineVars Vars { get; set; }

        #endregion

    #region methods
    public class InlineVars {
        public RscGqlVars ViolationSummaryForResource { get; set; }


        public InlineVars() {
            Tuple<string, string>[] violationSummaryForResourceArgs = {
                    Tuple.Create("policyTypes", "[PolicyType!]!"),
                };
            this.ViolationSummaryForResource =
                new RscGqlVars(null, violationSummaryForResourceArgs, null, true);
        }
    }

    public PolicyViolation()
    {
        this.Vars = new InlineVars();
    }

    public override string GetGqlTypeName() {
        return "PolicyViolation";
    }

    public PolicyViolation Set(
        Severity? ResourceMaxSeverity = null,
        PolicyResourceType? ResourceType = null,
        PolicyResourceType? SecondaryResourceType = null,
        PolicyViolationStatus? Status = null,
        PolicyViolationStatusReason? StatusReason = null,
        Severity? ViolationSeverity = null,
        DateTime? CreatedAt = null,
        DateTime? LastEvaluatedAt = null,
        DateTime? LastUpdatedAt = null,
        System.String? LastUpdatedBy = null,
        System.String? Name = null,
        System.String? OriginId = null,
        DateTime? OriginStartTime = null,
        System.String? ParentPolicyViolationId = null,
        System.Int32? PolicyVersion = null,
        System.String? PolicyViolationId = null,
        System.Int32? ResourceCriticalViolationsCount = null,
        System.Int32? ResourceHighViolationsCount = null,
        System.String? ResourceId = null,
        System.Int32? ResourceLowViolationsCount = null,
        System.Int32? ResourceMediumViolationsCount = null,
        System.Int32? ResourceViolationsCount = null,
        System.String? SecondaryResourceId = null,
        System.String? UserFriendlyViolationId = null,
        DspmPolicy? Policy = null,
        List<RemediationAvailability>? PossibleRemediationsForViolationTarget = null,
        List<RemediationMetadata>? Remediations = null,
        ResourceMetadata? ResourceMetadata = null,
        User? UserLastUpdated = null,
        ViolationSummaryForResource? ViolationSummaryForResource = null,
        ViolationDetailsUnion? Details = null
    ) 
    {
        if ( ResourceMaxSeverity != null ) {
            this.ResourceMaxSeverity = ResourceMaxSeverity;
        }
        if ( ResourceType != null ) {
            this.ResourceType = ResourceType;
        }
        if ( SecondaryResourceType != null ) {
            this.SecondaryResourceType = SecondaryResourceType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( StatusReason != null ) {
            this.StatusReason = StatusReason;
        }
        if ( ViolationSeverity != null ) {
            this.ViolationSeverity = ViolationSeverity;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( LastEvaluatedAt != null ) {
            this.LastEvaluatedAt = LastEvaluatedAt;
        }
        if ( LastUpdatedAt != null ) {
            this.LastUpdatedAt = LastUpdatedAt;
        }
        if ( LastUpdatedBy != null ) {
            this.LastUpdatedBy = LastUpdatedBy;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OriginId != null ) {
            this.OriginId = OriginId;
        }
        if ( OriginStartTime != null ) {
            this.OriginStartTime = OriginStartTime;
        }
        if ( ParentPolicyViolationId != null ) {
            this.ParentPolicyViolationId = ParentPolicyViolationId;
        }
        if ( PolicyVersion != null ) {
            this.PolicyVersion = PolicyVersion;
        }
        if ( PolicyViolationId != null ) {
            this.PolicyViolationId = PolicyViolationId;
        }
        if ( ResourceCriticalViolationsCount != null ) {
            this.ResourceCriticalViolationsCount = ResourceCriticalViolationsCount;
        }
        if ( ResourceHighViolationsCount != null ) {
            this.ResourceHighViolationsCount = ResourceHighViolationsCount;
        }
        if ( ResourceId != null ) {
            this.ResourceId = ResourceId;
        }
        if ( ResourceLowViolationsCount != null ) {
            this.ResourceLowViolationsCount = ResourceLowViolationsCount;
        }
        if ( ResourceMediumViolationsCount != null ) {
            this.ResourceMediumViolationsCount = ResourceMediumViolationsCount;
        }
        if ( ResourceViolationsCount != null ) {
            this.ResourceViolationsCount = ResourceViolationsCount;
        }
        if ( SecondaryResourceId != null ) {
            this.SecondaryResourceId = SecondaryResourceId;
        }
        if ( UserFriendlyViolationId != null ) {
            this.UserFriendlyViolationId = UserFriendlyViolationId;
        }
        if ( Policy != null ) {
            this.Policy = Policy;
        }
        if ( PossibleRemediationsForViolationTarget != null ) {
            this.PossibleRemediationsForViolationTarget = PossibleRemediationsForViolationTarget;
        }
        if ( Remediations != null ) {
            this.Remediations = Remediations;
        }
        if ( ResourceMetadata != null ) {
            this.ResourceMetadata = ResourceMetadata;
        }
        if ( UserLastUpdated != null ) {
            this.UserLastUpdated = UserLastUpdated;
        }
        if ( ViolationSummaryForResource != null ) {
            this.ViolationSummaryForResource = ViolationSummaryForResource;
        }
        if ( Details != null ) {
            this.Details = Details;
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
        //      C# -> Severity? ResourceMaxSeverity
        // GraphQL -> resourceMaxSeverity: Severity! (enum)
        if (this.ResourceMaxSeverity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceMaxSeverity\n" ;
            } else {
                s += ind + "resourceMaxSeverity\n" ;
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
        //      C# -> PolicyResourceType? SecondaryResourceType
        // GraphQL -> secondaryResourceType: PolicyResourceType! (enum)
        if (this.SecondaryResourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secondaryResourceType\n" ;
            } else {
                s += ind + "secondaryResourceType\n" ;
            }
        }
        //      C# -> PolicyViolationStatus? Status
        // GraphQL -> status: PolicyViolationStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> PolicyViolationStatusReason? StatusReason
        // GraphQL -> statusReason: PolicyViolationStatusReason! (enum)
        if (this.StatusReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusReason\n" ;
            } else {
                s += ind + "statusReason\n" ;
            }
        }
        //      C# -> Severity? ViolationSeverity
        // GraphQL -> violationSeverity: Severity! (enum)
        if (this.ViolationSeverity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violationSeverity\n" ;
            } else {
                s += ind + "violationSeverity\n" ;
            }
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (this.CreatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdAt\n" ;
            } else {
                s += ind + "createdAt\n" ;
            }
        }
        //      C# -> DateTime? LastEvaluatedAt
        // GraphQL -> lastEvaluatedAt: DateTime (scalar)
        if (this.LastEvaluatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastEvaluatedAt\n" ;
            } else {
                s += ind + "lastEvaluatedAt\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? OriginId
        // GraphQL -> originId: String (scalar)
        if (this.OriginId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "originId\n" ;
            } else {
                s += ind + "originId\n" ;
            }
        }
        //      C# -> DateTime? OriginStartTime
        // GraphQL -> originStartTime: DateTime (scalar)
        if (this.OriginStartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "originStartTime\n" ;
            } else {
                s += ind + "originStartTime\n" ;
            }
        }
        //      C# -> System.String? ParentPolicyViolationId
        // GraphQL -> parentPolicyViolationId: String (scalar)
        if (this.ParentPolicyViolationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentPolicyViolationId\n" ;
            } else {
                s += ind + "parentPolicyViolationId\n" ;
            }
        }
        //      C# -> System.Int32? PolicyVersion
        // GraphQL -> policyVersion: Int! (scalar)
        if (this.PolicyVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyVersion\n" ;
            } else {
                s += ind + "policyVersion\n" ;
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
        //      C# -> System.Int32? ResourceCriticalViolationsCount
        // GraphQL -> resourceCriticalViolationsCount: Int! (scalar)
        if (this.ResourceCriticalViolationsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceCriticalViolationsCount\n" ;
            } else {
                s += ind + "resourceCriticalViolationsCount\n" ;
            }
        }
        //      C# -> System.Int32? ResourceHighViolationsCount
        // GraphQL -> resourceHighViolationsCount: Int! (scalar)
        if (this.ResourceHighViolationsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceHighViolationsCount\n" ;
            } else {
                s += ind + "resourceHighViolationsCount\n" ;
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
        //      C# -> System.Int32? ResourceLowViolationsCount
        // GraphQL -> resourceLowViolationsCount: Int! (scalar)
        if (this.ResourceLowViolationsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceLowViolationsCount\n" ;
            } else {
                s += ind + "resourceLowViolationsCount\n" ;
            }
        }
        //      C# -> System.Int32? ResourceMediumViolationsCount
        // GraphQL -> resourceMediumViolationsCount: Int! (scalar)
        if (this.ResourceMediumViolationsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceMediumViolationsCount\n" ;
            } else {
                s += ind + "resourceMediumViolationsCount\n" ;
            }
        }
        //      C# -> System.Int32? ResourceViolationsCount
        // GraphQL -> resourceViolationsCount: Int! (scalar)
        if (this.ResourceViolationsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceViolationsCount\n" ;
            } else {
                s += ind + "resourceViolationsCount\n" ;
            }
        }
        //      C# -> System.String? SecondaryResourceId
        // GraphQL -> secondaryResourceId: String (scalar)
        if (this.SecondaryResourceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "secondaryResourceId\n" ;
            } else {
                s += ind + "secondaryResourceId\n" ;
            }
        }
        //      C# -> System.String? UserFriendlyViolationId
        // GraphQL -> userFriendlyViolationId: String! (scalar)
        if (this.UserFriendlyViolationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userFriendlyViolationId\n" ;
            } else {
                s += ind + "userFriendlyViolationId\n" ;
            }
        }
        //      C# -> DspmPolicy? Policy
        // GraphQL -> policy: DSPMPolicy! (type)
        if (this.Policy != null) {
            var fspec = this.Policy.AsFieldSpec(conf.Child("policy"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policy" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RemediationAvailability>? PossibleRemediationsForViolationTarget
        // GraphQL -> possibleRemediationsForViolationTarget: [RemediationAvailability!] (type)
        if (this.PossibleRemediationsForViolationTarget != null) {
            var fspec = this.PossibleRemediationsForViolationTarget.AsFieldSpec(conf.Child("possibleRemediationsForViolationTarget"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "possibleRemediationsForViolationTarget" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RemediationMetadata>? Remediations
        // GraphQL -> remediations: [RemediationMetadata!] (type)
        if (this.Remediations != null) {
            var fspec = this.Remediations.AsFieldSpec(conf.Child("remediations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "remediations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ResourceMetadata? ResourceMetadata
        // GraphQL -> resourceMetadata: ResourceMetadata (type)
        if (this.ResourceMetadata != null) {
            var fspec = this.ResourceMetadata.AsFieldSpec(conf.Child("resourceMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resourceMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> User? UserLastUpdated
        // GraphQL -> userLastUpdated: User (type)
        if (this.UserLastUpdated != null) {
            var fspec = this.UserLastUpdated.AsFieldSpec(conf.Child("userLastUpdated"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "userLastUpdated" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ViolationSummaryForResource? ViolationSummaryForResource
        // GraphQL -> violationSummaryForResource: ViolationSummaryForResource (type)
        if (this.ViolationSummaryForResource != null) {
            var fspec = this.ViolationSummaryForResource.AsFieldSpec(conf.Child("violationSummaryForResource"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "violationSummaryForResource" + "\n(" + this.Vars.ViolationSummaryForResource.ToInlineArguments() + ")\n" + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ViolationDetailsUnion? Details
        // GraphQL -> details: ViolationDetailsUnion (union)
        if (this.Details != null) {
            var fspec = this.Details.AsFieldSpec(conf.Child("details"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "details" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> Severity? ResourceMaxSeverity
        // GraphQL -> resourceMaxSeverity: Severity! (enum)
        if (ec.Includes("resourceMaxSeverity",true))
        {
            if(this.ResourceMaxSeverity == null) {

                this.ResourceMaxSeverity = new Severity();

            } else {


            }
        }
        else if (this.ResourceMaxSeverity != null && ec.Excludes("resourceMaxSeverity",true))
        {
            this.ResourceMaxSeverity = null;
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
        //      C# -> PolicyResourceType? SecondaryResourceType
        // GraphQL -> secondaryResourceType: PolicyResourceType! (enum)
        if (ec.Includes("secondaryResourceType",true))
        {
            if(this.SecondaryResourceType == null) {

                this.SecondaryResourceType = new PolicyResourceType();

            } else {


            }
        }
        else if (this.SecondaryResourceType != null && ec.Excludes("secondaryResourceType",true))
        {
            this.SecondaryResourceType = null;
        }
        //      C# -> PolicyViolationStatus? Status
        // GraphQL -> status: PolicyViolationStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new PolicyViolationStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> PolicyViolationStatusReason? StatusReason
        // GraphQL -> statusReason: PolicyViolationStatusReason! (enum)
        if (ec.Includes("statusReason",true))
        {
            if(this.StatusReason == null) {

                this.StatusReason = new PolicyViolationStatusReason();

            } else {


            }
        }
        else if (this.StatusReason != null && ec.Excludes("statusReason",true))
        {
            this.StatusReason = null;
        }
        //      C# -> Severity? ViolationSeverity
        // GraphQL -> violationSeverity: Severity! (enum)
        if (ec.Includes("violationSeverity",true))
        {
            if(this.ViolationSeverity == null) {

                this.ViolationSeverity = new Severity();

            } else {


            }
        }
        else if (this.ViolationSeverity != null && ec.Excludes("violationSeverity",true))
        {
            this.ViolationSeverity = null;
        }
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        if (ec.Includes("createdAt",true))
        {
            if(this.CreatedAt == null) {

                this.CreatedAt = new DateTime();

            } else {


            }
        }
        else if (this.CreatedAt != null && ec.Excludes("createdAt",true))
        {
            this.CreatedAt = null;
        }
        //      C# -> DateTime? LastEvaluatedAt
        // GraphQL -> lastEvaluatedAt: DateTime (scalar)
        if (ec.Includes("lastEvaluatedAt",true))
        {
            if(this.LastEvaluatedAt == null) {

                this.LastEvaluatedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastEvaluatedAt != null && ec.Excludes("lastEvaluatedAt",true))
        {
            this.LastEvaluatedAt = null;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? OriginId
        // GraphQL -> originId: String (scalar)
        if (ec.Includes("originId",true))
        {
            if(this.OriginId == null) {

                this.OriginId = "FETCH";

            } else {


            }
        }
        else if (this.OriginId != null && ec.Excludes("originId",true))
        {
            this.OriginId = null;
        }
        //      C# -> DateTime? OriginStartTime
        // GraphQL -> originStartTime: DateTime (scalar)
        if (ec.Includes("originStartTime",true))
        {
            if(this.OriginStartTime == null) {

                this.OriginStartTime = new DateTime();

            } else {


            }
        }
        else if (this.OriginStartTime != null && ec.Excludes("originStartTime",true))
        {
            this.OriginStartTime = null;
        }
        //      C# -> System.String? ParentPolicyViolationId
        // GraphQL -> parentPolicyViolationId: String (scalar)
        if (ec.Includes("parentPolicyViolationId",true))
        {
            if(this.ParentPolicyViolationId == null) {

                this.ParentPolicyViolationId = "FETCH";

            } else {


            }
        }
        else if (this.ParentPolicyViolationId != null && ec.Excludes("parentPolicyViolationId",true))
        {
            this.ParentPolicyViolationId = null;
        }
        //      C# -> System.Int32? PolicyVersion
        // GraphQL -> policyVersion: Int! (scalar)
        if (ec.Includes("policyVersion",true))
        {
            if(this.PolicyVersion == null) {

                this.PolicyVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.PolicyVersion != null && ec.Excludes("policyVersion",true))
        {
            this.PolicyVersion = null;
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
        //      C# -> System.Int32? ResourceCriticalViolationsCount
        // GraphQL -> resourceCriticalViolationsCount: Int! (scalar)
        if (ec.Includes("resourceCriticalViolationsCount",true))
        {
            if(this.ResourceCriticalViolationsCount == null) {

                this.ResourceCriticalViolationsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ResourceCriticalViolationsCount != null && ec.Excludes("resourceCriticalViolationsCount",true))
        {
            this.ResourceCriticalViolationsCount = null;
        }
        //      C# -> System.Int32? ResourceHighViolationsCount
        // GraphQL -> resourceHighViolationsCount: Int! (scalar)
        if (ec.Includes("resourceHighViolationsCount",true))
        {
            if(this.ResourceHighViolationsCount == null) {

                this.ResourceHighViolationsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ResourceHighViolationsCount != null && ec.Excludes("resourceHighViolationsCount",true))
        {
            this.ResourceHighViolationsCount = null;
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
        //      C# -> System.Int32? ResourceLowViolationsCount
        // GraphQL -> resourceLowViolationsCount: Int! (scalar)
        if (ec.Includes("resourceLowViolationsCount",true))
        {
            if(this.ResourceLowViolationsCount == null) {

                this.ResourceLowViolationsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ResourceLowViolationsCount != null && ec.Excludes("resourceLowViolationsCount",true))
        {
            this.ResourceLowViolationsCount = null;
        }
        //      C# -> System.Int32? ResourceMediumViolationsCount
        // GraphQL -> resourceMediumViolationsCount: Int! (scalar)
        if (ec.Includes("resourceMediumViolationsCount",true))
        {
            if(this.ResourceMediumViolationsCount == null) {

                this.ResourceMediumViolationsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ResourceMediumViolationsCount != null && ec.Excludes("resourceMediumViolationsCount",true))
        {
            this.ResourceMediumViolationsCount = null;
        }
        //      C# -> System.Int32? ResourceViolationsCount
        // GraphQL -> resourceViolationsCount: Int! (scalar)
        if (ec.Includes("resourceViolationsCount",true))
        {
            if(this.ResourceViolationsCount == null) {

                this.ResourceViolationsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ResourceViolationsCount != null && ec.Excludes("resourceViolationsCount",true))
        {
            this.ResourceViolationsCount = null;
        }
        //      C# -> System.String? SecondaryResourceId
        // GraphQL -> secondaryResourceId: String (scalar)
        if (ec.Includes("secondaryResourceId",true))
        {
            if(this.SecondaryResourceId == null) {

                this.SecondaryResourceId = "FETCH";

            } else {


            }
        }
        else if (this.SecondaryResourceId != null && ec.Excludes("secondaryResourceId",true))
        {
            this.SecondaryResourceId = null;
        }
        //      C# -> System.String? UserFriendlyViolationId
        // GraphQL -> userFriendlyViolationId: String! (scalar)
        if (ec.Includes("userFriendlyViolationId",true))
        {
            if(this.UserFriendlyViolationId == null) {

                this.UserFriendlyViolationId = "FETCH";

            } else {


            }
        }
        else if (this.UserFriendlyViolationId != null && ec.Excludes("userFriendlyViolationId",true))
        {
            this.UserFriendlyViolationId = null;
        }
        //      C# -> DspmPolicy? Policy
        // GraphQL -> policy: DSPMPolicy! (type)
        if (ec.Includes("policy",false))
        {
            if(this.Policy == null) {

                this.Policy = new DspmPolicy();
                this.Policy.ApplyExploratoryFieldSpec(ec.NewChild("policy"));

            } else {

                this.Policy.ApplyExploratoryFieldSpec(ec.NewChild("policy"));

            }
        }
        else if (this.Policy != null && ec.Excludes("policy",false))
        {
            this.Policy = null;
        }
        //      C# -> List<RemediationAvailability>? PossibleRemediationsForViolationTarget
        // GraphQL -> possibleRemediationsForViolationTarget: [RemediationAvailability!] (type)
        if (ec.Includes("possibleRemediationsForViolationTarget",false))
        {
            if(this.PossibleRemediationsForViolationTarget == null) {

                this.PossibleRemediationsForViolationTarget = new List<RemediationAvailability>();
                this.PossibleRemediationsForViolationTarget.ApplyExploratoryFieldSpec(ec.NewChild("possibleRemediationsForViolationTarget"));

            } else {

                this.PossibleRemediationsForViolationTarget.ApplyExploratoryFieldSpec(ec.NewChild("possibleRemediationsForViolationTarget"));

            }
        }
        else if (this.PossibleRemediationsForViolationTarget != null && ec.Excludes("possibleRemediationsForViolationTarget",false))
        {
            this.PossibleRemediationsForViolationTarget = null;
        }
        //      C# -> List<RemediationMetadata>? Remediations
        // GraphQL -> remediations: [RemediationMetadata!] (type)
        if (ec.Includes("remediations",false))
        {
            if(this.Remediations == null) {

                this.Remediations = new List<RemediationMetadata>();
                this.Remediations.ApplyExploratoryFieldSpec(ec.NewChild("remediations"));

            } else {

                this.Remediations.ApplyExploratoryFieldSpec(ec.NewChild("remediations"));

            }
        }
        else if (this.Remediations != null && ec.Excludes("remediations",false))
        {
            this.Remediations = null;
        }
        //      C# -> ResourceMetadata? ResourceMetadata
        // GraphQL -> resourceMetadata: ResourceMetadata (type)
        if (ec.Includes("resourceMetadata",false))
        {
            if(this.ResourceMetadata == null) {

                this.ResourceMetadata = new ResourceMetadata();
                this.ResourceMetadata.ApplyExploratoryFieldSpec(ec.NewChild("resourceMetadata"));

            } else {

                this.ResourceMetadata.ApplyExploratoryFieldSpec(ec.NewChild("resourceMetadata"));

            }
        }
        else if (this.ResourceMetadata != null && ec.Excludes("resourceMetadata",false))
        {
            this.ResourceMetadata = null;
        }
        //      C# -> User? UserLastUpdated
        // GraphQL -> userLastUpdated: User (type)
        if (ec.Includes("userLastUpdated",false))
        {
            if(this.UserLastUpdated == null) {

                this.UserLastUpdated = new User();
                this.UserLastUpdated.ApplyExploratoryFieldSpec(ec.NewChild("userLastUpdated"));

            } else {

                this.UserLastUpdated.ApplyExploratoryFieldSpec(ec.NewChild("userLastUpdated"));

            }
        }
        else if (this.UserLastUpdated != null && ec.Excludes("userLastUpdated",false))
        {
            this.UserLastUpdated = null;
        }
        //      C# -> ViolationSummaryForResource? ViolationSummaryForResource
        // GraphQL -> violationSummaryForResource: ViolationSummaryForResource (type)
        if (ec.Includes("violationSummaryForResource",false))
        {
            if(this.ViolationSummaryForResource == null) {

                this.ViolationSummaryForResource = new ViolationSummaryForResource();
                this.ViolationSummaryForResource.ApplyExploratoryFieldSpec(ec.NewChild("violationSummaryForResource"));

            } else {

                this.ViolationSummaryForResource.ApplyExploratoryFieldSpec(ec.NewChild("violationSummaryForResource"));

            }
        }
        else if (this.ViolationSummaryForResource != null && ec.Excludes("violationSummaryForResource",false))
        {
            this.ViolationSummaryForResource = null;
        }
        //      C# -> ViolationDetailsUnion? Details
        // GraphQL -> details: ViolationDetailsUnion (union)
        if (ec.Includes("details",false))
        {
            if(this.Details == null) {

                var impls = new List<ViolationDetailsUnion>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("details"));
                this.Details = (ViolationDetailsUnion)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<ViolationDetailsUnion>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("details"));
                this.Details = (ViolationDetailsUnion)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Details != null && ec.Excludes("details",false))
        {
            this.Details = null;
        }
    }


    #endregion

    } // class PolicyViolation
    
    #endregion

    public static class ListPolicyViolationExtensions
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
            this List<PolicyViolation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PolicyViolation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PolicyViolation> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PolicyViolation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PolicyViolation> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types