// PrincipalSummary.cs
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
    #region PrincipalSummary
    public class PrincipalSummary: BaseType
    {
        #region members

        //      C# -> HybridState? HybridState
        // GraphQL -> hybridState: HybridState! (enum)
        [JsonProperty("hybridState")]
        public HybridState? HybridState { get; set; }

        //      C# -> List<IdentityTag>? IdentityTags
        // GraphQL -> identityTags: [IdentityTag!]! (enum)
        [JsonProperty("identityTags")]
        public List<IdentityTag>? IdentityTags { get; set; }

        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        [JsonProperty("idpType")]
        public IdpType? IdpType { get; set; }

        //      C# -> NativeType? NativeType
        // GraphQL -> nativeType: NativeType! (enum)
        [JsonProperty("nativeType")]
        public NativeType? NativeType { get; set; }

        //      C# -> RiskLevelType? PreviousRiskLevel
        // GraphQL -> previousRiskLevel: RiskLevelType! (enum)
        [JsonProperty("previousRiskLevel")]
        public RiskLevelType? PreviousRiskLevel { get; set; }

        //      C# -> PrincipalOrigin? PrincipalOrigin
        // GraphQL -> principalOrigin: PrincipalOrigin! (enum)
        [JsonProperty("principalOrigin")]
        public PrincipalOrigin? PrincipalOrigin { get; set; }

        //      C# -> PrincipalRiskySummaryPrincipalType? PrincipalType
        // GraphQL -> principalType: PrincipalRiskySummaryPrincipalType! (enum)
        [JsonProperty("principalType")]
        public PrincipalRiskySummaryPrincipalType? PrincipalType { get; set; }

        //      C# -> PrivilegeType? PrivilegeType
        // GraphQL -> privilegeType: PrivilegeType! (enum)
        [JsonProperty("privilegeType")]
        public PrivilegeType? PrivilegeType { get; set; }

        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        [JsonProperty("riskLevel")]
        public RiskLevelType? RiskLevel { get; set; }

        //      C# -> IdentityStatus? Status
        // GraphQL -> status: IdentityStatus! (enum)
        [JsonProperty("status")]
        public IdentityStatus? Status { get; set; }

        //      C# -> System.Int64? CreationTime
        // GraphQL -> creationTime: Long! (scalar)
        [JsonProperty("creationTime")]
        public System.Int64? CreationTime { get; set; }

        //      C# -> DateTime? DeletedAt
        // GraphQL -> deletedAt: DateTime (scalar)
        [JsonProperty("deletedAt")]
        public DateTime? DeletedAt { get; set; }

        //      C# -> System.String? Department
        // GraphQL -> department: String! (scalar)
        [JsonProperty("department")]
        public System.String? Department { get; set; }

        //      C# -> System.String? DomainFid
        // GraphQL -> domainFid: String! (scalar)
        [JsonProperty("domainFid")]
        public System.String? DomainFid { get; set; }

        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String! (scalar)
        [JsonProperty("domainId")]
        public System.String? DomainId { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        [JsonProperty("entityId")]
        public System.String? EntityId { get; set; }

        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        [JsonProperty("entityName")]
        public System.String? EntityName { get; set; }

        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        [JsonProperty("fullName")]
        public System.String? FullName { get; set; }

        //      C# -> System.Boolean? HasInsights
        // GraphQL -> hasInsights: Boolean! (scalar)
        [JsonProperty("hasInsights")]
        public System.Boolean? HasInsights { get; set; }

        //      C# -> System.Boolean? IsComplete
        // GraphQL -> isComplete: Boolean! (scalar)
        [JsonProperty("isComplete")]
        public System.Boolean? IsComplete { get; set; }

        //      C# -> System.Boolean? IsNewlyAdded
        // GraphQL -> isNewlyAdded: Boolean! (scalar)
        [JsonProperty("isNewlyAdded")]
        public System.Boolean? IsNewlyAdded { get; set; }

        //      C# -> System.Boolean? IsPrimary
        // GraphQL -> isPrimary: Boolean! (scalar)
        [JsonProperty("isPrimary")]
        public System.Boolean? IsPrimary { get; set; }

        //      C# -> DateTime? LastChanged
        // GraphQL -> lastChanged: DateTime (scalar)
        [JsonProperty("lastChanged")]
        public DateTime? LastChanged { get; set; }

        //      C# -> System.Int32? NumDescendants
        // GraphQL -> numDescendants: Int! (scalar)
        [JsonProperty("numDescendants")]
        public System.Int32? NumDescendants { get; set; }

        //      C# -> System.Int32? ObjectCount
        // GraphQL -> objectCount: Int! (scalar)
        [JsonProperty("objectCount")]
        public System.Int32? ObjectCount { get; set; }

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        //      C# -> System.String? RootDomainId
        // GraphQL -> rootDomainId: String! (scalar)
        [JsonProperty("rootDomainId")]
        public System.String? RootDomainId { get; set; }

        //      C# -> System.String? RootDomainName
        // GraphQL -> rootDomainName: String! (scalar)
        [JsonProperty("rootDomainName")]
        public System.String? RootDomainName { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> System.String? UniqueIdentifier
        // GraphQL -> uniqueIdentifier: String! (scalar)
        [JsonProperty("uniqueIdentifier")]
        public System.String? UniqueIdentifier { get; set; }

        //      C# -> System.String? Upn
        // GraphQL -> upn: String! (scalar)
        [JsonProperty("upn")]
        public System.String? Upn { get; set; }

        //      C# -> AccessTypeSummary? AccessTypeSummary
        // GraphQL -> accessTypeSummary: AccessTypeSummary (type)
        [JsonProperty("accessTypeSummary")]
        public AccessTypeSummary? AccessTypeSummary { get; set; }

        //      C# -> PrincipalSummaryAdditionalMetadata? AdditionalMetadata
        // GraphQL -> additionalMetadata: PrincipalSummaryAdditionalMetadata (type)
        [JsonProperty("additionalMetadata")]
        public PrincipalSummaryAdditionalMetadata? AdditionalMetadata { get; set; }

        //      C# -> AlertInfo? AlertInfo
        // GraphQL -> alertInfo: AlertInfo (type)
        [JsonProperty("alertInfo")]
        public AlertInfo? AlertInfo { get; set; }

        //      C# -> CloudAccountInfo? CloudAccountInfo
        // GraphQL -> cloudAccountInfo: CloudAccountInfo (type)
        [JsonProperty("cloudAccountInfo")]
        public CloudAccountInfo? CloudAccountInfo { get; set; }

        //      C# -> List<DataCategoryResult>? DataCategoryResults
        // GraphQL -> dataCategoryResults: [DataCategoryResult!]! (type)
        [JsonProperty("dataCategoryResults")]
        public List<DataCategoryResult>? DataCategoryResults { get; set; }

        //      C# -> List<DataTypeResult>? DataTypeResults
        // GraphQL -> dataTypeResults: [DataTypeResult!]! (type)
        [JsonProperty("dataTypeResults")]
        public List<DataTypeResult>? DataTypeResults { get; set; }

        //      C# -> ViolationInfo? DataViolationInfo
        // GraphQL -> dataViolationInfo: ViolationInfo (type)
        [JsonProperty("dataViolationInfo")]
        public ViolationInfo? DataViolationInfo { get; set; }

        //      C# -> SensitiveFiles? DeltaSensitiveFiles
        // GraphQL -> deltaSensitiveFiles: SensitiveFiles (type)
        [JsonProperty("deltaSensitiveFiles")]
        public SensitiveFiles? DeltaSensitiveFiles { get; set; }

        //      C# -> SummaryHits? DeltaSensitiveHits
        // GraphQL -> deltaSensitiveHits: SummaryHits (type)
        [JsonProperty("deltaSensitiveHits")]
        public SummaryHits? DeltaSensitiveHits { get; set; }

        //      C# -> ViolationInfo? IdentityViolationInfo
        // GraphQL -> identityViolationInfo: ViolationInfo (type)
        [JsonProperty("identityViolationInfo")]
        public ViolationInfo? IdentityViolationInfo { get; set; }

        //      C# -> List<OwnerInfo>? Owners
        // GraphQL -> owners: [OwnerInfo!]! (type)
        [JsonProperty("owners")]
        public List<OwnerInfo>? Owners { get; set; }

        //      C# -> MembershipCount? PrivilegedMembershipDetails
        // GraphQL -> privilegedMembershipDetails: MembershipCount (type)
        [JsonProperty("privilegedMembershipDetails")]
        public MembershipCount? PrivilegedMembershipDetails { get; set; }

        //      C# -> PrincipalRiskReasons? RiskReasons
        // GraphQL -> riskReasons: PrincipalRiskReasons (type)
        [JsonProperty("riskReasons")]
        public PrincipalRiskReasons? RiskReasons { get; set; }

        //      C# -> List<SecretMetaData>? SecretsMetadata
        // GraphQL -> secretsMetadata: [SecretMetaData!]! (type)
        [JsonProperty("secretsMetadata")]
        public List<SecretMetaData>? SecretsMetadata { get; set; }

        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        [JsonProperty("sensitiveFiles")]
        public SensitiveFiles? SensitiveFiles { get; set; }

        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        [JsonProperty("sensitiveHits")]
        public SensitiveHits? SensitiveHits { get; set; }

        //      C# -> SummaryCount? SensitiveObjectCount
        // GraphQL -> sensitiveObjectCount: SummaryCount (type)
        [JsonProperty("sensitiveObjectCount")]
        public SummaryCount? SensitiveObjectCount { get; set; }

        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        [JsonProperty("totalSensitiveHits")]
        public SummaryHits? TotalSensitiveHits { get; set; }

        //      C# -> ViolationInfo? ViolationInfo
        // GraphQL -> violationInfo: ViolationInfo (type)
        [JsonProperty("violationInfo")]
        public ViolationInfo? ViolationInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrincipalSummary";
    }

    public PrincipalSummary Set(
        HybridState? HybridState = null,
        List<IdentityTag>? IdentityTags = null,
        IdpType? IdpType = null,
        NativeType? NativeType = null,
        RiskLevelType? PreviousRiskLevel = null,
        PrincipalOrigin? PrincipalOrigin = null,
        PrincipalRiskySummaryPrincipalType? PrincipalType = null,
        PrivilegeType? PrivilegeType = null,
        RiskLevelType? RiskLevel = null,
        IdentityStatus? Status = null,
        System.Int64? CreationTime = null,
        DateTime? DeletedAt = null,
        System.String? Department = null,
        System.String? DomainFid = null,
        System.String? DomainId = null,
        System.String? DomainName = null,
        System.String? EntityId = null,
        System.String? EntityName = null,
        System.String? FullName = null,
        System.Boolean? HasInsights = null,
        System.Boolean? IsComplete = null,
        System.Boolean? IsNewlyAdded = null,
        System.Boolean? IsPrimary = null,
        DateTime? LastChanged = null,
        System.Int32? NumDescendants = null,
        System.Int32? ObjectCount = null,
        System.String? PrincipalId = null,
        System.String? RootDomainId = null,
        System.String? RootDomainName = null,
        System.String? Title = null,
        System.String? UniqueIdentifier = null,
        System.String? Upn = null,
        AccessTypeSummary? AccessTypeSummary = null,
        PrincipalSummaryAdditionalMetadata? AdditionalMetadata = null,
        AlertInfo? AlertInfo = null,
        CloudAccountInfo? CloudAccountInfo = null,
        List<DataCategoryResult>? DataCategoryResults = null,
        List<DataTypeResult>? DataTypeResults = null,
        ViolationInfo? DataViolationInfo = null,
        SensitiveFiles? DeltaSensitiveFiles = null,
        SummaryHits? DeltaSensitiveHits = null,
        ViolationInfo? IdentityViolationInfo = null,
        List<OwnerInfo>? Owners = null,
        MembershipCount? PrivilegedMembershipDetails = null,
        PrincipalRiskReasons? RiskReasons = null,
        List<SecretMetaData>? SecretsMetadata = null,
        SensitiveFiles? SensitiveFiles = null,
        SensitiveHits? SensitiveHits = null,
        SummaryCount? SensitiveObjectCount = null,
        SummaryHits? TotalSensitiveHits = null,
        ViolationInfo? ViolationInfo = null
    ) 
    {
        if ( HybridState != null ) {
            this.HybridState = HybridState;
        }
        if ( IdentityTags != null ) {
            this.IdentityTags = IdentityTags;
        }
        if ( IdpType != null ) {
            this.IdpType = IdpType;
        }
        if ( NativeType != null ) {
            this.NativeType = NativeType;
        }
        if ( PreviousRiskLevel != null ) {
            this.PreviousRiskLevel = PreviousRiskLevel;
        }
        if ( PrincipalOrigin != null ) {
            this.PrincipalOrigin = PrincipalOrigin;
        }
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
        }
        if ( PrivilegeType != null ) {
            this.PrivilegeType = PrivilegeType;
        }
        if ( RiskLevel != null ) {
            this.RiskLevel = RiskLevel;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CreationTime != null ) {
            this.CreationTime = CreationTime;
        }
        if ( DeletedAt != null ) {
            this.DeletedAt = DeletedAt;
        }
        if ( Department != null ) {
            this.Department = Department;
        }
        if ( DomainFid != null ) {
            this.DomainFid = DomainFid;
        }
        if ( DomainId != null ) {
            this.DomainId = DomainId;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( EntityId != null ) {
            this.EntityId = EntityId;
        }
        if ( EntityName != null ) {
            this.EntityName = EntityName;
        }
        if ( FullName != null ) {
            this.FullName = FullName;
        }
        if ( HasInsights != null ) {
            this.HasInsights = HasInsights;
        }
        if ( IsComplete != null ) {
            this.IsComplete = IsComplete;
        }
        if ( IsNewlyAdded != null ) {
            this.IsNewlyAdded = IsNewlyAdded;
        }
        if ( IsPrimary != null ) {
            this.IsPrimary = IsPrimary;
        }
        if ( LastChanged != null ) {
            this.LastChanged = LastChanged;
        }
        if ( NumDescendants != null ) {
            this.NumDescendants = NumDescendants;
        }
        if ( ObjectCount != null ) {
            this.ObjectCount = ObjectCount;
        }
        if ( PrincipalId != null ) {
            this.PrincipalId = PrincipalId;
        }
        if ( RootDomainId != null ) {
            this.RootDomainId = RootDomainId;
        }
        if ( RootDomainName != null ) {
            this.RootDomainName = RootDomainName;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( UniqueIdentifier != null ) {
            this.UniqueIdentifier = UniqueIdentifier;
        }
        if ( Upn != null ) {
            this.Upn = Upn;
        }
        if ( AccessTypeSummary != null ) {
            this.AccessTypeSummary = AccessTypeSummary;
        }
        if ( AdditionalMetadata != null ) {
            this.AdditionalMetadata = AdditionalMetadata;
        }
        if ( AlertInfo != null ) {
            this.AlertInfo = AlertInfo;
        }
        if ( CloudAccountInfo != null ) {
            this.CloudAccountInfo = CloudAccountInfo;
        }
        if ( DataCategoryResults != null ) {
            this.DataCategoryResults = DataCategoryResults;
        }
        if ( DataTypeResults != null ) {
            this.DataTypeResults = DataTypeResults;
        }
        if ( DataViolationInfo != null ) {
            this.DataViolationInfo = DataViolationInfo;
        }
        if ( DeltaSensitiveFiles != null ) {
            this.DeltaSensitiveFiles = DeltaSensitiveFiles;
        }
        if ( DeltaSensitiveHits != null ) {
            this.DeltaSensitiveHits = DeltaSensitiveHits;
        }
        if ( IdentityViolationInfo != null ) {
            this.IdentityViolationInfo = IdentityViolationInfo;
        }
        if ( Owners != null ) {
            this.Owners = Owners;
        }
        if ( PrivilegedMembershipDetails != null ) {
            this.PrivilegedMembershipDetails = PrivilegedMembershipDetails;
        }
        if ( RiskReasons != null ) {
            this.RiskReasons = RiskReasons;
        }
        if ( SecretsMetadata != null ) {
            this.SecretsMetadata = SecretsMetadata;
        }
        if ( SensitiveFiles != null ) {
            this.SensitiveFiles = SensitiveFiles;
        }
        if ( SensitiveHits != null ) {
            this.SensitiveHits = SensitiveHits;
        }
        if ( SensitiveObjectCount != null ) {
            this.SensitiveObjectCount = SensitiveObjectCount;
        }
        if ( TotalSensitiveHits != null ) {
            this.TotalSensitiveHits = TotalSensitiveHits;
        }
        if ( ViolationInfo != null ) {
            this.ViolationInfo = ViolationInfo;
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
        //      C# -> HybridState? HybridState
        // GraphQL -> hybridState: HybridState! (enum)
        if (this.HybridState != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hybridState\n" ;
            } else {
                s += ind + "hybridState\n" ;
            }
        }
        //      C# -> List<IdentityTag>? IdentityTags
        // GraphQL -> identityTags: [IdentityTag!]! (enum)
        if (this.IdentityTags != null) {
            if (conf.Flat) {
                s += conf.Prefix + "identityTags\n" ;
            } else {
                s += ind + "identityTags\n" ;
            }
        }
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (this.IdpType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpType\n" ;
            } else {
                s += ind + "idpType\n" ;
            }
        }
        //      C# -> NativeType? NativeType
        // GraphQL -> nativeType: NativeType! (enum)
        if (this.NativeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeType\n" ;
            } else {
                s += ind + "nativeType\n" ;
            }
        }
        //      C# -> RiskLevelType? PreviousRiskLevel
        // GraphQL -> previousRiskLevel: RiskLevelType! (enum)
        if (this.PreviousRiskLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "previousRiskLevel\n" ;
            } else {
                s += ind + "previousRiskLevel\n" ;
            }
        }
        //      C# -> PrincipalOrigin? PrincipalOrigin
        // GraphQL -> principalOrigin: PrincipalOrigin! (enum)
        if (this.PrincipalOrigin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalOrigin\n" ;
            } else {
                s += ind + "principalOrigin\n" ;
            }
        }
        //      C# -> PrincipalRiskySummaryPrincipalType? PrincipalType
        // GraphQL -> principalType: PrincipalRiskySummaryPrincipalType! (enum)
        if (this.PrincipalType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalType\n" ;
            } else {
                s += ind + "principalType\n" ;
            }
        }
        //      C# -> PrivilegeType? PrivilegeType
        // GraphQL -> privilegeType: PrivilegeType! (enum)
        if (this.PrivilegeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "privilegeType\n" ;
            } else {
                s += ind + "privilegeType\n" ;
            }
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (this.RiskLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "riskLevel\n" ;
            } else {
                s += ind + "riskLevel\n" ;
            }
        }
        //      C# -> IdentityStatus? Status
        // GraphQL -> status: IdentityStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Int64? CreationTime
        // GraphQL -> creationTime: Long! (scalar)
        if (this.CreationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creationTime\n" ;
            } else {
                s += ind + "creationTime\n" ;
            }
        }
        //      C# -> DateTime? DeletedAt
        // GraphQL -> deletedAt: DateTime (scalar)
        if (this.DeletedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deletedAt\n" ;
            } else {
                s += ind + "deletedAt\n" ;
            }
        }
        //      C# -> System.String? Department
        // GraphQL -> department: String! (scalar)
        if (this.Department != null) {
            if (conf.Flat) {
                s += conf.Prefix + "department\n" ;
            } else {
                s += ind + "department\n" ;
            }
        }
        //      C# -> System.String? DomainFid
        // GraphQL -> domainFid: String! (scalar)
        if (this.DomainFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainFid\n" ;
            } else {
                s += ind + "domainFid\n" ;
            }
        }
        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String! (scalar)
        if (this.DomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainId\n" ;
            } else {
                s += ind + "domainId\n" ;
            }
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainName\n" ;
            } else {
                s += ind + "domainName\n" ;
            }
        }
        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        if (this.EntityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityId\n" ;
            } else {
                s += ind + "entityId\n" ;
            }
        }
        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        if (this.EntityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entityName\n" ;
            } else {
                s += ind + "entityName\n" ;
            }
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (this.FullName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fullName\n" ;
            } else {
                s += ind + "fullName\n" ;
            }
        }
        //      C# -> System.Boolean? HasInsights
        // GraphQL -> hasInsights: Boolean! (scalar)
        if (this.HasInsights != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasInsights\n" ;
            } else {
                s += ind + "hasInsights\n" ;
            }
        }
        //      C# -> System.Boolean? IsComplete
        // GraphQL -> isComplete: Boolean! (scalar)
        if (this.IsComplete != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isComplete\n" ;
            } else {
                s += ind + "isComplete\n" ;
            }
        }
        //      C# -> System.Boolean? IsNewlyAdded
        // GraphQL -> isNewlyAdded: Boolean! (scalar)
        if (this.IsNewlyAdded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isNewlyAdded\n" ;
            } else {
                s += ind + "isNewlyAdded\n" ;
            }
        }
        //      C# -> System.Boolean? IsPrimary
        // GraphQL -> isPrimary: Boolean! (scalar)
        if (this.IsPrimary != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPrimary\n" ;
            } else {
                s += ind + "isPrimary\n" ;
            }
        }
        //      C# -> DateTime? LastChanged
        // GraphQL -> lastChanged: DateTime (scalar)
        if (this.LastChanged != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastChanged\n" ;
            } else {
                s += ind + "lastChanged\n" ;
            }
        }
        //      C# -> System.Int32? NumDescendants
        // GraphQL -> numDescendants: Int! (scalar)
        if (this.NumDescendants != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numDescendants\n" ;
            } else {
                s += ind + "numDescendants\n" ;
            }
        }
        //      C# -> System.Int32? ObjectCount
        // GraphQL -> objectCount: Int! (scalar)
        if (this.ObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectCount\n" ;
            } else {
                s += ind + "objectCount\n" ;
            }
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (this.PrincipalId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalId\n" ;
            } else {
                s += ind + "principalId\n" ;
            }
        }
        //      C# -> System.String? RootDomainId
        // GraphQL -> rootDomainId: String! (scalar)
        if (this.RootDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rootDomainId\n" ;
            } else {
                s += ind + "rootDomainId\n" ;
            }
        }
        //      C# -> System.String? RootDomainName
        // GraphQL -> rootDomainName: String! (scalar)
        if (this.RootDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rootDomainName\n" ;
            } else {
                s += ind + "rootDomainName\n" ;
            }
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            if (conf.Flat) {
                s += conf.Prefix + "title\n" ;
            } else {
                s += ind + "title\n" ;
            }
        }
        //      C# -> System.String? UniqueIdentifier
        // GraphQL -> uniqueIdentifier: String! (scalar)
        if (this.UniqueIdentifier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uniqueIdentifier\n" ;
            } else {
                s += ind + "uniqueIdentifier\n" ;
            }
        }
        //      C# -> System.String? Upn
        // GraphQL -> upn: String! (scalar)
        if (this.Upn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upn\n" ;
            } else {
                s += ind + "upn\n" ;
            }
        }
        //      C# -> AccessTypeSummary? AccessTypeSummary
        // GraphQL -> accessTypeSummary: AccessTypeSummary (type)
        if (this.AccessTypeSummary != null) {
            var fspec = this.AccessTypeSummary.AsFieldSpec(conf.Child("accessTypeSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "accessTypeSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalSummaryAdditionalMetadata? AdditionalMetadata
        // GraphQL -> additionalMetadata: PrincipalSummaryAdditionalMetadata (type)
        if (this.AdditionalMetadata != null) {
            var fspec = this.AdditionalMetadata.AsFieldSpec(conf.Child("additionalMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "additionalMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AlertInfo? AlertInfo
        // GraphQL -> alertInfo: AlertInfo (type)
        if (this.AlertInfo != null) {
            var fspec = this.AlertInfo.AsFieldSpec(conf.Child("alertInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "alertInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudAccountInfo? CloudAccountInfo
        // GraphQL -> cloudAccountInfo: CloudAccountInfo (type)
        if (this.CloudAccountInfo != null) {
            var fspec = this.CloudAccountInfo.AsFieldSpec(conf.Child("cloudAccountInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudAccountInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataCategoryResult>? DataCategoryResults
        // GraphQL -> dataCategoryResults: [DataCategoryResult!]! (type)
        if (this.DataCategoryResults != null) {
            var fspec = this.DataCategoryResults.AsFieldSpec(conf.Child("dataCategoryResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataCategoryResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataTypeResult>? DataTypeResults
        // GraphQL -> dataTypeResults: [DataTypeResult!]! (type)
        if (this.DataTypeResults != null) {
            var fspec = this.DataTypeResults.AsFieldSpec(conf.Child("dataTypeResults"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataTypeResults" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ViolationInfo? DataViolationInfo
        // GraphQL -> dataViolationInfo: ViolationInfo (type)
        if (this.DataViolationInfo != null) {
            var fspec = this.DataViolationInfo.AsFieldSpec(conf.Child("dataViolationInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataViolationInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveFiles? DeltaSensitiveFiles
        // GraphQL -> deltaSensitiveFiles: SensitiveFiles (type)
        if (this.DeltaSensitiveFiles != null) {
            var fspec = this.DeltaSensitiveFiles.AsFieldSpec(conf.Child("deltaSensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deltaSensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryHits? DeltaSensitiveHits
        // GraphQL -> deltaSensitiveHits: SummaryHits (type)
        if (this.DeltaSensitiveHits != null) {
            var fspec = this.DeltaSensitiveHits.AsFieldSpec(conf.Child("deltaSensitiveHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deltaSensitiveHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ViolationInfo? IdentityViolationInfo
        // GraphQL -> identityViolationInfo: ViolationInfo (type)
        if (this.IdentityViolationInfo != null) {
            var fspec = this.IdentityViolationInfo.AsFieldSpec(conf.Child("identityViolationInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "identityViolationInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<OwnerInfo>? Owners
        // GraphQL -> owners: [OwnerInfo!]! (type)
        if (this.Owners != null) {
            var fspec = this.Owners.AsFieldSpec(conf.Child("owners"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "owners" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MembershipCount? PrivilegedMembershipDetails
        // GraphQL -> privilegedMembershipDetails: MembershipCount (type)
        if (this.PrivilegedMembershipDetails != null) {
            var fspec = this.PrivilegedMembershipDetails.AsFieldSpec(conf.Child("privilegedMembershipDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "privilegedMembershipDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrincipalRiskReasons? RiskReasons
        // GraphQL -> riskReasons: PrincipalRiskReasons (type)
        if (this.RiskReasons != null) {
            var fspec = this.RiskReasons.AsFieldSpec(conf.Child("riskReasons"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "riskReasons" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<SecretMetaData>? SecretsMetadata
        // GraphQL -> secretsMetadata: [SecretMetaData!]! (type)
        if (this.SecretsMetadata != null) {
            var fspec = this.SecretsMetadata.AsFieldSpec(conf.Child("secretsMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "secretsMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (this.SensitiveFiles != null) {
            var fspec = this.SensitiveFiles.AsFieldSpec(conf.Child("sensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (this.SensitiveHits != null) {
            var fspec = this.SensitiveHits.AsFieldSpec(conf.Child("sensitiveHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryCount? SensitiveObjectCount
        // GraphQL -> sensitiveObjectCount: SummaryCount (type)
        if (this.SensitiveObjectCount != null) {
            var fspec = this.SensitiveObjectCount.AsFieldSpec(conf.Child("sensitiveObjectCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sensitiveObjectCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (this.TotalSensitiveHits != null) {
            var fspec = this.TotalSensitiveHits.AsFieldSpec(conf.Child("totalSensitiveHits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalSensitiveHits" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ViolationInfo? ViolationInfo
        // GraphQL -> violationInfo: ViolationInfo (type)
        if (this.ViolationInfo != null) {
            var fspec = this.ViolationInfo.AsFieldSpec(conf.Child("violationInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "violationInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HybridState? HybridState
        // GraphQL -> hybridState: HybridState! (enum)
        if (ec.Includes("hybridState",true))
        {
            if(this.HybridState == null) {

                this.HybridState = new HybridState();

            } else {


            }
        }
        else if (this.HybridState != null && ec.Excludes("hybridState",true))
        {
            this.HybridState = null;
        }
        //      C# -> List<IdentityTag>? IdentityTags
        // GraphQL -> identityTags: [IdentityTag!]! (enum)
        if (ec.Includes("identityTags",true))
        {
            if(this.IdentityTags == null) {

                this.IdentityTags = new List<IdentityTag>();

            } else {


            }
        }
        else if (this.IdentityTags != null && ec.Excludes("identityTags",true))
        {
            this.IdentityTags = null;
        }
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (ec.Includes("idpType",true))
        {
            if(this.IdpType == null) {

                this.IdpType = new IdpType();

            } else {


            }
        }
        else if (this.IdpType != null && ec.Excludes("idpType",true))
        {
            this.IdpType = null;
        }
        //      C# -> NativeType? NativeType
        // GraphQL -> nativeType: NativeType! (enum)
        if (ec.Includes("nativeType",true))
        {
            if(this.NativeType == null) {

                this.NativeType = new NativeType();

            } else {


            }
        }
        else if (this.NativeType != null && ec.Excludes("nativeType",true))
        {
            this.NativeType = null;
        }
        //      C# -> RiskLevelType? PreviousRiskLevel
        // GraphQL -> previousRiskLevel: RiskLevelType! (enum)
        if (ec.Includes("previousRiskLevel",true))
        {
            if(this.PreviousRiskLevel == null) {

                this.PreviousRiskLevel = new RiskLevelType();

            } else {


            }
        }
        else if (this.PreviousRiskLevel != null && ec.Excludes("previousRiskLevel",true))
        {
            this.PreviousRiskLevel = null;
        }
        //      C# -> PrincipalOrigin? PrincipalOrigin
        // GraphQL -> principalOrigin: PrincipalOrigin! (enum)
        if (ec.Includes("principalOrigin",true))
        {
            if(this.PrincipalOrigin == null) {

                this.PrincipalOrigin = new PrincipalOrigin();

            } else {


            }
        }
        else if (this.PrincipalOrigin != null && ec.Excludes("principalOrigin",true))
        {
            this.PrincipalOrigin = null;
        }
        //      C# -> PrincipalRiskySummaryPrincipalType? PrincipalType
        // GraphQL -> principalType: PrincipalRiskySummaryPrincipalType! (enum)
        if (ec.Includes("principalType",true))
        {
            if(this.PrincipalType == null) {

                this.PrincipalType = new PrincipalRiskySummaryPrincipalType();

            } else {


            }
        }
        else if (this.PrincipalType != null && ec.Excludes("principalType",true))
        {
            this.PrincipalType = null;
        }
        //      C# -> PrivilegeType? PrivilegeType
        // GraphQL -> privilegeType: PrivilegeType! (enum)
        if (ec.Includes("privilegeType",true))
        {
            if(this.PrivilegeType == null) {

                this.PrivilegeType = new PrivilegeType();

            } else {


            }
        }
        else if (this.PrivilegeType != null && ec.Excludes("privilegeType",true))
        {
            this.PrivilegeType = null;
        }
        //      C# -> RiskLevelType? RiskLevel
        // GraphQL -> riskLevel: RiskLevelType! (enum)
        if (ec.Includes("riskLevel",true))
        {
            if(this.RiskLevel == null) {

                this.RiskLevel = new RiskLevelType();

            } else {


            }
        }
        else if (this.RiskLevel != null && ec.Excludes("riskLevel",true))
        {
            this.RiskLevel = null;
        }
        //      C# -> IdentityStatus? Status
        // GraphQL -> status: IdentityStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new IdentityStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Int64? CreationTime
        // GraphQL -> creationTime: Long! (scalar)
        if (ec.Includes("creationTime",true))
        {
            if(this.CreationTime == null) {

                this.CreationTime = new System.Int64();

            } else {


            }
        }
        else if (this.CreationTime != null && ec.Excludes("creationTime",true))
        {
            this.CreationTime = null;
        }
        //      C# -> DateTime? DeletedAt
        // GraphQL -> deletedAt: DateTime (scalar)
        if (ec.Includes("deletedAt",true))
        {
            if(this.DeletedAt == null) {

                this.DeletedAt = new DateTime();

            } else {


            }
        }
        else if (this.DeletedAt != null && ec.Excludes("deletedAt",true))
        {
            this.DeletedAt = null;
        }
        //      C# -> System.String? Department
        // GraphQL -> department: String! (scalar)
        if (ec.Includes("department",true))
        {
            if(this.Department == null) {

                this.Department = "FETCH";

            } else {


            }
        }
        else if (this.Department != null && ec.Excludes("department",true))
        {
            this.Department = null;
        }
        //      C# -> System.String? DomainFid
        // GraphQL -> domainFid: String! (scalar)
        if (ec.Includes("domainFid",true))
        {
            if(this.DomainFid == null) {

                this.DomainFid = "FETCH";

            } else {


            }
        }
        else if (this.DomainFid != null && ec.Excludes("domainFid",true))
        {
            this.DomainFid = null;
        }
        //      C# -> System.String? DomainId
        // GraphQL -> domainId: String! (scalar)
        if (ec.Includes("domainId",true))
        {
            if(this.DomainId == null) {

                this.DomainId = "FETCH";

            } else {


            }
        }
        else if (this.DomainId != null && ec.Excludes("domainId",true))
        {
            this.DomainId = null;
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (ec.Includes("domainName",true))
        {
            if(this.DomainName == null) {

                this.DomainName = "FETCH";

            } else {


            }
        }
        else if (this.DomainName != null && ec.Excludes("domainName",true))
        {
            this.DomainName = null;
        }
        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        if (ec.Includes("entityId",true))
        {
            if(this.EntityId == null) {

                this.EntityId = "FETCH";

            } else {


            }
        }
        else if (this.EntityId != null && ec.Excludes("entityId",true))
        {
            this.EntityId = null;
        }
        //      C# -> System.String? EntityName
        // GraphQL -> entityName: String! (scalar)
        if (ec.Includes("entityName",true))
        {
            if(this.EntityName == null) {

                this.EntityName = "FETCH";

            } else {


            }
        }
        else if (this.EntityName != null && ec.Excludes("entityName",true))
        {
            this.EntityName = null;
        }
        //      C# -> System.String? FullName
        // GraphQL -> fullName: String! (scalar)
        if (ec.Includes("fullName",true))
        {
            if(this.FullName == null) {

                this.FullName = "FETCH";

            } else {


            }
        }
        else if (this.FullName != null && ec.Excludes("fullName",true))
        {
            this.FullName = null;
        }
        //      C# -> System.Boolean? HasInsights
        // GraphQL -> hasInsights: Boolean! (scalar)
        if (ec.Includes("hasInsights",true))
        {
            if(this.HasInsights == null) {

                this.HasInsights = true;

            } else {


            }
        }
        else if (this.HasInsights != null && ec.Excludes("hasInsights",true))
        {
            this.HasInsights = null;
        }
        //      C# -> System.Boolean? IsComplete
        // GraphQL -> isComplete: Boolean! (scalar)
        if (ec.Includes("isComplete",true))
        {
            if(this.IsComplete == null) {

                this.IsComplete = true;

            } else {


            }
        }
        else if (this.IsComplete != null && ec.Excludes("isComplete",true))
        {
            this.IsComplete = null;
        }
        //      C# -> System.Boolean? IsNewlyAdded
        // GraphQL -> isNewlyAdded: Boolean! (scalar)
        if (ec.Includes("isNewlyAdded",true))
        {
            if(this.IsNewlyAdded == null) {

                this.IsNewlyAdded = true;

            } else {


            }
        }
        else if (this.IsNewlyAdded != null && ec.Excludes("isNewlyAdded",true))
        {
            this.IsNewlyAdded = null;
        }
        //      C# -> System.Boolean? IsPrimary
        // GraphQL -> isPrimary: Boolean! (scalar)
        if (ec.Includes("isPrimary",true))
        {
            if(this.IsPrimary == null) {

                this.IsPrimary = true;

            } else {


            }
        }
        else if (this.IsPrimary != null && ec.Excludes("isPrimary",true))
        {
            this.IsPrimary = null;
        }
        //      C# -> DateTime? LastChanged
        // GraphQL -> lastChanged: DateTime (scalar)
        if (ec.Includes("lastChanged",true))
        {
            if(this.LastChanged == null) {

                this.LastChanged = new DateTime();

            } else {


            }
        }
        else if (this.LastChanged != null && ec.Excludes("lastChanged",true))
        {
            this.LastChanged = null;
        }
        //      C# -> System.Int32? NumDescendants
        // GraphQL -> numDescendants: Int! (scalar)
        if (ec.Includes("numDescendants",true))
        {
            if(this.NumDescendants == null) {

                this.NumDescendants = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumDescendants != null && ec.Excludes("numDescendants",true))
        {
            this.NumDescendants = null;
        }
        //      C# -> System.Int32? ObjectCount
        // GraphQL -> objectCount: Int! (scalar)
        if (ec.Includes("objectCount",true))
        {
            if(this.ObjectCount == null) {

                this.ObjectCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ObjectCount != null && ec.Excludes("objectCount",true))
        {
            this.ObjectCount = null;
        }
        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        if (ec.Includes("principalId",true))
        {
            if(this.PrincipalId == null) {

                this.PrincipalId = "FETCH";

            } else {


            }
        }
        else if (this.PrincipalId != null && ec.Excludes("principalId",true))
        {
            this.PrincipalId = null;
        }
        //      C# -> System.String? RootDomainId
        // GraphQL -> rootDomainId: String! (scalar)
        if (ec.Includes("rootDomainId",true))
        {
            if(this.RootDomainId == null) {

                this.RootDomainId = "FETCH";

            } else {


            }
        }
        else if (this.RootDomainId != null && ec.Excludes("rootDomainId",true))
        {
            this.RootDomainId = null;
        }
        //      C# -> System.String? RootDomainName
        // GraphQL -> rootDomainName: String! (scalar)
        if (ec.Includes("rootDomainName",true))
        {
            if(this.RootDomainName == null) {

                this.RootDomainName = "FETCH";

            } else {


            }
        }
        else if (this.RootDomainName != null && ec.Excludes("rootDomainName",true))
        {
            this.RootDomainName = null;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (ec.Includes("title",true))
        {
            if(this.Title == null) {

                this.Title = "FETCH";

            } else {


            }
        }
        else if (this.Title != null && ec.Excludes("title",true))
        {
            this.Title = null;
        }
        //      C# -> System.String? UniqueIdentifier
        // GraphQL -> uniqueIdentifier: String! (scalar)
        if (ec.Includes("uniqueIdentifier",true))
        {
            if(this.UniqueIdentifier == null) {

                this.UniqueIdentifier = "FETCH";

            } else {


            }
        }
        else if (this.UniqueIdentifier != null && ec.Excludes("uniqueIdentifier",true))
        {
            this.UniqueIdentifier = null;
        }
        //      C# -> System.String? Upn
        // GraphQL -> upn: String! (scalar)
        if (ec.Includes("upn",true))
        {
            if(this.Upn == null) {

                this.Upn = "FETCH";

            } else {


            }
        }
        else if (this.Upn != null && ec.Excludes("upn",true))
        {
            this.Upn = null;
        }
        //      C# -> AccessTypeSummary? AccessTypeSummary
        // GraphQL -> accessTypeSummary: AccessTypeSummary (type)
        if (ec.Includes("accessTypeSummary",false))
        {
            if(this.AccessTypeSummary == null) {

                this.AccessTypeSummary = new AccessTypeSummary();
                this.AccessTypeSummary.ApplyExploratoryFieldSpec(ec.NewChild("accessTypeSummary"));

            } else {

                this.AccessTypeSummary.ApplyExploratoryFieldSpec(ec.NewChild("accessTypeSummary"));

            }
        }
        else if (this.AccessTypeSummary != null && ec.Excludes("accessTypeSummary",false))
        {
            this.AccessTypeSummary = null;
        }
        //      C# -> PrincipalSummaryAdditionalMetadata? AdditionalMetadata
        // GraphQL -> additionalMetadata: PrincipalSummaryAdditionalMetadata (type)
        if (ec.Includes("additionalMetadata",false))
        {
            if(this.AdditionalMetadata == null) {

                this.AdditionalMetadata = new PrincipalSummaryAdditionalMetadata();
                this.AdditionalMetadata.ApplyExploratoryFieldSpec(ec.NewChild("additionalMetadata"));

            } else {

                this.AdditionalMetadata.ApplyExploratoryFieldSpec(ec.NewChild("additionalMetadata"));

            }
        }
        else if (this.AdditionalMetadata != null && ec.Excludes("additionalMetadata",false))
        {
            this.AdditionalMetadata = null;
        }
        //      C# -> AlertInfo? AlertInfo
        // GraphQL -> alertInfo: AlertInfo (type)
        if (ec.Includes("alertInfo",false))
        {
            if(this.AlertInfo == null) {

                this.AlertInfo = new AlertInfo();
                this.AlertInfo.ApplyExploratoryFieldSpec(ec.NewChild("alertInfo"));

            } else {

                this.AlertInfo.ApplyExploratoryFieldSpec(ec.NewChild("alertInfo"));

            }
        }
        else if (this.AlertInfo != null && ec.Excludes("alertInfo",false))
        {
            this.AlertInfo = null;
        }
        //      C# -> CloudAccountInfo? CloudAccountInfo
        // GraphQL -> cloudAccountInfo: CloudAccountInfo (type)
        if (ec.Includes("cloudAccountInfo",false))
        {
            if(this.CloudAccountInfo == null) {

                this.CloudAccountInfo = new CloudAccountInfo();
                this.CloudAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccountInfo"));

            } else {

                this.CloudAccountInfo.ApplyExploratoryFieldSpec(ec.NewChild("cloudAccountInfo"));

            }
        }
        else if (this.CloudAccountInfo != null && ec.Excludes("cloudAccountInfo",false))
        {
            this.CloudAccountInfo = null;
        }
        //      C# -> List<DataCategoryResult>? DataCategoryResults
        // GraphQL -> dataCategoryResults: [DataCategoryResult!]! (type)
        if (ec.Includes("dataCategoryResults",false))
        {
            if(this.DataCategoryResults == null) {

                this.DataCategoryResults = new List<DataCategoryResult>();
                this.DataCategoryResults.ApplyExploratoryFieldSpec(ec.NewChild("dataCategoryResults"));

            } else {

                this.DataCategoryResults.ApplyExploratoryFieldSpec(ec.NewChild("dataCategoryResults"));

            }
        }
        else if (this.DataCategoryResults != null && ec.Excludes("dataCategoryResults",false))
        {
            this.DataCategoryResults = null;
        }
        //      C# -> List<DataTypeResult>? DataTypeResults
        // GraphQL -> dataTypeResults: [DataTypeResult!]! (type)
        if (ec.Includes("dataTypeResults",false))
        {
            if(this.DataTypeResults == null) {

                this.DataTypeResults = new List<DataTypeResult>();
                this.DataTypeResults.ApplyExploratoryFieldSpec(ec.NewChild("dataTypeResults"));

            } else {

                this.DataTypeResults.ApplyExploratoryFieldSpec(ec.NewChild("dataTypeResults"));

            }
        }
        else if (this.DataTypeResults != null && ec.Excludes("dataTypeResults",false))
        {
            this.DataTypeResults = null;
        }
        //      C# -> ViolationInfo? DataViolationInfo
        // GraphQL -> dataViolationInfo: ViolationInfo (type)
        if (ec.Includes("dataViolationInfo",false))
        {
            if(this.DataViolationInfo == null) {

                this.DataViolationInfo = new ViolationInfo();
                this.DataViolationInfo.ApplyExploratoryFieldSpec(ec.NewChild("dataViolationInfo"));

            } else {

                this.DataViolationInfo.ApplyExploratoryFieldSpec(ec.NewChild("dataViolationInfo"));

            }
        }
        else if (this.DataViolationInfo != null && ec.Excludes("dataViolationInfo",false))
        {
            this.DataViolationInfo = null;
        }
        //      C# -> SensitiveFiles? DeltaSensitiveFiles
        // GraphQL -> deltaSensitiveFiles: SensitiveFiles (type)
        if (ec.Includes("deltaSensitiveFiles",false))
        {
            if(this.DeltaSensitiveFiles == null) {

                this.DeltaSensitiveFiles = new SensitiveFiles();
                this.DeltaSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("deltaSensitiveFiles"));

            } else {

                this.DeltaSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("deltaSensitiveFiles"));

            }
        }
        else if (this.DeltaSensitiveFiles != null && ec.Excludes("deltaSensitiveFiles",false))
        {
            this.DeltaSensitiveFiles = null;
        }
        //      C# -> SummaryHits? DeltaSensitiveHits
        // GraphQL -> deltaSensitiveHits: SummaryHits (type)
        if (ec.Includes("deltaSensitiveHits",false))
        {
            if(this.DeltaSensitiveHits == null) {

                this.DeltaSensitiveHits = new SummaryHits();
                this.DeltaSensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("deltaSensitiveHits"));

            } else {

                this.DeltaSensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("deltaSensitiveHits"));

            }
        }
        else if (this.DeltaSensitiveHits != null && ec.Excludes("deltaSensitiveHits",false))
        {
            this.DeltaSensitiveHits = null;
        }
        //      C# -> ViolationInfo? IdentityViolationInfo
        // GraphQL -> identityViolationInfo: ViolationInfo (type)
        if (ec.Includes("identityViolationInfo",false))
        {
            if(this.IdentityViolationInfo == null) {

                this.IdentityViolationInfo = new ViolationInfo();
                this.IdentityViolationInfo.ApplyExploratoryFieldSpec(ec.NewChild("identityViolationInfo"));

            } else {

                this.IdentityViolationInfo.ApplyExploratoryFieldSpec(ec.NewChild("identityViolationInfo"));

            }
        }
        else if (this.IdentityViolationInfo != null && ec.Excludes("identityViolationInfo",false))
        {
            this.IdentityViolationInfo = null;
        }
        //      C# -> List<OwnerInfo>? Owners
        // GraphQL -> owners: [OwnerInfo!]! (type)
        if (ec.Includes("owners",false))
        {
            if(this.Owners == null) {

                this.Owners = new List<OwnerInfo>();
                this.Owners.ApplyExploratoryFieldSpec(ec.NewChild("owners"));

            } else {

                this.Owners.ApplyExploratoryFieldSpec(ec.NewChild("owners"));

            }
        }
        else if (this.Owners != null && ec.Excludes("owners",false))
        {
            this.Owners = null;
        }
        //      C# -> MembershipCount? PrivilegedMembershipDetails
        // GraphQL -> privilegedMembershipDetails: MembershipCount (type)
        if (ec.Includes("privilegedMembershipDetails",false))
        {
            if(this.PrivilegedMembershipDetails == null) {

                this.PrivilegedMembershipDetails = new MembershipCount();
                this.PrivilegedMembershipDetails.ApplyExploratoryFieldSpec(ec.NewChild("privilegedMembershipDetails"));

            } else {

                this.PrivilegedMembershipDetails.ApplyExploratoryFieldSpec(ec.NewChild("privilegedMembershipDetails"));

            }
        }
        else if (this.PrivilegedMembershipDetails != null && ec.Excludes("privilegedMembershipDetails",false))
        {
            this.PrivilegedMembershipDetails = null;
        }
        //      C# -> PrincipalRiskReasons? RiskReasons
        // GraphQL -> riskReasons: PrincipalRiskReasons (type)
        if (ec.Includes("riskReasons",false))
        {
            if(this.RiskReasons == null) {

                this.RiskReasons = new PrincipalRiskReasons();
                this.RiskReasons.ApplyExploratoryFieldSpec(ec.NewChild("riskReasons"));

            } else {

                this.RiskReasons.ApplyExploratoryFieldSpec(ec.NewChild("riskReasons"));

            }
        }
        else if (this.RiskReasons != null && ec.Excludes("riskReasons",false))
        {
            this.RiskReasons = null;
        }
        //      C# -> List<SecretMetaData>? SecretsMetadata
        // GraphQL -> secretsMetadata: [SecretMetaData!]! (type)
        if (ec.Includes("secretsMetadata",false))
        {
            if(this.SecretsMetadata == null) {

                this.SecretsMetadata = new List<SecretMetaData>();
                this.SecretsMetadata.ApplyExploratoryFieldSpec(ec.NewChild("secretsMetadata"));

            } else {

                this.SecretsMetadata.ApplyExploratoryFieldSpec(ec.NewChild("secretsMetadata"));

            }
        }
        else if (this.SecretsMetadata != null && ec.Excludes("secretsMetadata",false))
        {
            this.SecretsMetadata = null;
        }
        //      C# -> SensitiveFiles? SensitiveFiles
        // GraphQL -> sensitiveFiles: SensitiveFiles (type)
        if (ec.Includes("sensitiveFiles",false))
        {
            if(this.SensitiveFiles == null) {

                this.SensitiveFiles = new SensitiveFiles();
                this.SensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveFiles"));

            } else {

                this.SensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveFiles"));

            }
        }
        else if (this.SensitiveFiles != null && ec.Excludes("sensitiveFiles",false))
        {
            this.SensitiveFiles = null;
        }
        //      C# -> SensitiveHits? SensitiveHits
        // GraphQL -> sensitiveHits: SensitiveHits (type)
        if (ec.Includes("sensitiveHits",false))
        {
            if(this.SensitiveHits == null) {

                this.SensitiveHits = new SensitiveHits();
                this.SensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveHits"));

            } else {

                this.SensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveHits"));

            }
        }
        else if (this.SensitiveHits != null && ec.Excludes("sensitiveHits",false))
        {
            this.SensitiveHits = null;
        }
        //      C# -> SummaryCount? SensitiveObjectCount
        // GraphQL -> sensitiveObjectCount: SummaryCount (type)
        if (ec.Includes("sensitiveObjectCount",false))
        {
            if(this.SensitiveObjectCount == null) {

                this.SensitiveObjectCount = new SummaryCount();
                this.SensitiveObjectCount.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveObjectCount"));

            } else {

                this.SensitiveObjectCount.ApplyExploratoryFieldSpec(ec.NewChild("sensitiveObjectCount"));

            }
        }
        else if (this.SensitiveObjectCount != null && ec.Excludes("sensitiveObjectCount",false))
        {
            this.SensitiveObjectCount = null;
        }
        //      C# -> SummaryHits? TotalSensitiveHits
        // GraphQL -> totalSensitiveHits: SummaryHits (type)
        if (ec.Includes("totalSensitiveHits",false))
        {
            if(this.TotalSensitiveHits == null) {

                this.TotalSensitiveHits = new SummaryHits();
                this.TotalSensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("totalSensitiveHits"));

            } else {

                this.TotalSensitiveHits.ApplyExploratoryFieldSpec(ec.NewChild("totalSensitiveHits"));

            }
        }
        else if (this.TotalSensitiveHits != null && ec.Excludes("totalSensitiveHits",false))
        {
            this.TotalSensitiveHits = null;
        }
        //      C# -> ViolationInfo? ViolationInfo
        // GraphQL -> violationInfo: ViolationInfo (type)
        if (ec.Includes("violationInfo",false))
        {
            if(this.ViolationInfo == null) {

                this.ViolationInfo = new ViolationInfo();
                this.ViolationInfo.ApplyExploratoryFieldSpec(ec.NewChild("violationInfo"));

            } else {

                this.ViolationInfo.ApplyExploratoryFieldSpec(ec.NewChild("violationInfo"));

            }
        }
        else if (this.ViolationInfo != null && ec.Excludes("violationInfo",false))
        {
            this.ViolationInfo = null;
        }
    }


    #endregion

    } // class PrincipalSummary
    
    #endregion

    public static class ListPrincipalSummaryExtensions
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
            this List<PrincipalSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PrincipalSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrincipalSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrincipalSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrincipalSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types