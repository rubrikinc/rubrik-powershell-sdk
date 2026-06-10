// DspmPolicy.cs
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
    #region DspmPolicy
    public class DspmPolicy: BaseType
    {
        #region members

        //      C# -> Category? PolicyCategory
        // GraphQL -> policyCategory: Category! (enum)
        [JsonProperty("policyCategory")]
        public Category? PolicyCategory { get; set; }

        //      C# -> Severity? PolicySeverity
        // GraphQL -> policySeverity: Severity! (enum)
        [JsonProperty("policySeverity")]
        public Severity? PolicySeverity { get; set; }

        //      C# -> PolicyType? PolicyType
        // GraphQL -> policyType: PolicyType! (enum)
        [JsonProperty("policyType")]
        public PolicyType? PolicyType { get; set; }

        //      C# -> System.Boolean? ContainsAccessFilters
        // GraphQL -> containsAccessFilters: Boolean (scalar)
        [JsonProperty("containsAccessFilters")]
        public System.Boolean? ContainsAccessFilters { get; set; }

        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String! (scalar)
        [JsonProperty("createdBy")]
        public System.String? CreatedBy { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> List<System.String>? Frameworks
        // GraphQL -> frameworks: [String!]! (scalar)
        [JsonProperty("frameworks")]
        public List<System.String>? Frameworks { get; set; }

        //      C# -> System.Boolean? IsAutomationEnabled
        // GraphQL -> isAutomationEnabled: Boolean! (scalar)
        [JsonProperty("isAutomationEnabled")]
        public System.Boolean? IsAutomationEnabled { get; set; }

        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        [JsonProperty("isDeleted")]
        public System.Boolean? IsDeleted { get; set; }

        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.Boolean? IsPredefined
        // GraphQL -> isPredefined: Boolean! (scalar)
        [JsonProperty("isPredefined")]
        public System.Boolean? IsPredefined { get; set; }

        //      C# -> System.Int32? LatestPolicyVersion
        // GraphQL -> latestPolicyVersion: Int! (scalar)
        [JsonProperty("latestPolicyVersion")]
        public System.Int32? LatestPolicyVersion { get; set; }

        //      C# -> System.String? ManualRemediationProcess
        // GraphQL -> manualRemediationProcess: String (scalar)
        [JsonProperty("manualRemediationProcess")]
        public System.String? ManualRemediationProcess { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> System.String? ProbabilityOfCompromise
        // GraphQL -> probabilityOfCompromise: String (scalar)
        [JsonProperty("probabilityOfCompromise")]
        public System.String? ProbabilityOfCompromise { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> List<AutomationRule>? AutomationRules
        // GraphQL -> automationRules: [AutomationRule!]! (type)
        [JsonProperty("automationRules")]
        public List<AutomationRule>? AutomationRules { get; set; }

        //      C# -> PolicyFilter? Filter
        // GraphQL -> filter: PolicyFilter (type)
        [JsonProperty("filter")]
        public PolicyFilter? Filter { get; set; }

        //      C# -> List<FilterTypeLabelEntry>? Labels
        // GraphQL -> labels: [FilterTypeLabelEntry!]! (type)
        [JsonProperty("labels")]
        public List<FilterTypeLabelEntry>? Labels { get; set; }

        //      C# -> PolicyTypeInfo? PolicyTypeInfo
        // GraphQL -> policyTypeInfo: PolicyTypeInfo (type)
        [JsonProperty("policyTypeInfo")]
        public PolicyTypeInfo? PolicyTypeInfo { get; set; }

        //      C# -> PolicyFilter? ThresholdFilter
        // GraphQL -> thresholdFilter: PolicyFilter (type)
        [JsonProperty("thresholdFilter")]
        public PolicyFilter? ThresholdFilter { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DSPMPolicy";
    }

    public DspmPolicy Set(
        Category? PolicyCategory = null,
        Severity? PolicySeverity = null,
        PolicyType? PolicyType = null,
        System.Boolean? ContainsAccessFilters = null,
        DateTime? CreatedAt = null,
        System.String? CreatedBy = null,
        System.String? Description = null,
        List<System.String>? Frameworks = null,
        System.Boolean? IsAutomationEnabled = null,
        System.Boolean? IsDeleted = null,
        System.Boolean? IsEnabled = null,
        System.Boolean? IsPredefined = null,
        System.Int32? LatestPolicyVersion = null,
        System.String? ManualRemediationProcess = null,
        System.String? Name = null,
        System.String? PolicyId = null,
        System.String? ProbabilityOfCompromise = null,
        DateTime? UpdatedAt = null,
        List<AutomationRule>? AutomationRules = null,
        PolicyFilter? Filter = null,
        List<FilterTypeLabelEntry>? Labels = null,
        PolicyTypeInfo? PolicyTypeInfo = null,
        PolicyFilter? ThresholdFilter = null
    ) 
    {
        if ( PolicyCategory != null ) {
            this.PolicyCategory = PolicyCategory;
        }
        if ( PolicySeverity != null ) {
            this.PolicySeverity = PolicySeverity;
        }
        if ( PolicyType != null ) {
            this.PolicyType = PolicyType;
        }
        if ( ContainsAccessFilters != null ) {
            this.ContainsAccessFilters = ContainsAccessFilters;
        }
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( CreatedBy != null ) {
            this.CreatedBy = CreatedBy;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Frameworks != null ) {
            this.Frameworks = Frameworks;
        }
        if ( IsAutomationEnabled != null ) {
            this.IsAutomationEnabled = IsAutomationEnabled;
        }
        if ( IsDeleted != null ) {
            this.IsDeleted = IsDeleted;
        }
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( IsPredefined != null ) {
            this.IsPredefined = IsPredefined;
        }
        if ( LatestPolicyVersion != null ) {
            this.LatestPolicyVersion = LatestPolicyVersion;
        }
        if ( ManualRemediationProcess != null ) {
            this.ManualRemediationProcess = ManualRemediationProcess;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PolicyId != null ) {
            this.PolicyId = PolicyId;
        }
        if ( ProbabilityOfCompromise != null ) {
            this.ProbabilityOfCompromise = ProbabilityOfCompromise;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( AutomationRules != null ) {
            this.AutomationRules = AutomationRules;
        }
        if ( Filter != null ) {
            this.Filter = Filter;
        }
        if ( Labels != null ) {
            this.Labels = Labels;
        }
        if ( PolicyTypeInfo != null ) {
            this.PolicyTypeInfo = PolicyTypeInfo;
        }
        if ( ThresholdFilter != null ) {
            this.ThresholdFilter = ThresholdFilter;
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
        //      C# -> Category? PolicyCategory
        // GraphQL -> policyCategory: Category! (enum)
        if (this.PolicyCategory != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyCategory\n" ;
            } else {
                s += ind + "policyCategory\n" ;
            }
        }
        //      C# -> Severity? PolicySeverity
        // GraphQL -> policySeverity: Severity! (enum)
        if (this.PolicySeverity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policySeverity\n" ;
            } else {
                s += ind + "policySeverity\n" ;
            }
        }
        //      C# -> PolicyType? PolicyType
        // GraphQL -> policyType: PolicyType! (enum)
        if (this.PolicyType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyType\n" ;
            } else {
                s += ind + "policyType\n" ;
            }
        }
        //      C# -> System.Boolean? ContainsAccessFilters
        // GraphQL -> containsAccessFilters: Boolean (scalar)
        if (this.ContainsAccessFilters != null) {
            if (conf.Flat) {
                s += conf.Prefix + "containsAccessFilters\n" ;
            } else {
                s += ind + "containsAccessFilters\n" ;
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
        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String! (scalar)
        if (this.CreatedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdBy\n" ;
            } else {
                s += ind + "createdBy\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
            }
        }
        //      C# -> List<System.String>? Frameworks
        // GraphQL -> frameworks: [String!]! (scalar)
        if (this.Frameworks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frameworks\n" ;
            } else {
                s += ind + "frameworks\n" ;
            }
        }
        //      C# -> System.Boolean? IsAutomationEnabled
        // GraphQL -> isAutomationEnabled: Boolean! (scalar)
        if (this.IsAutomationEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAutomationEnabled\n" ;
            } else {
                s += ind + "isAutomationEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (this.IsDeleted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDeleted\n" ;
            } else {
                s += ind + "isDeleted\n" ;
            }
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (this.IsEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEnabled\n" ;
            } else {
                s += ind + "isEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsPredefined
        // GraphQL -> isPredefined: Boolean! (scalar)
        if (this.IsPredefined != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPredefined\n" ;
            } else {
                s += ind + "isPredefined\n" ;
            }
        }
        //      C# -> System.Int32? LatestPolicyVersion
        // GraphQL -> latestPolicyVersion: Int! (scalar)
        if (this.LatestPolicyVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestPolicyVersion\n" ;
            } else {
                s += ind + "latestPolicyVersion\n" ;
            }
        }
        //      C# -> System.String? ManualRemediationProcess
        // GraphQL -> manualRemediationProcess: String (scalar)
        if (this.ManualRemediationProcess != null) {
            if (conf.Flat) {
                s += conf.Prefix + "manualRemediationProcess\n" ;
            } else {
                s += ind + "manualRemediationProcess\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        if (this.PolicyId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "policyId\n" ;
            } else {
                s += ind + "policyId\n" ;
            }
        }
        //      C# -> System.String? ProbabilityOfCompromise
        // GraphQL -> probabilityOfCompromise: String (scalar)
        if (this.ProbabilityOfCompromise != null) {
            if (conf.Flat) {
                s += conf.Prefix + "probabilityOfCompromise\n" ;
            } else {
                s += ind + "probabilityOfCompromise\n" ;
            }
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (this.UpdatedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "updatedAt\n" ;
            } else {
                s += ind + "updatedAt\n" ;
            }
        }
        //      C# -> List<AutomationRule>? AutomationRules
        // GraphQL -> automationRules: [AutomationRule!]! (type)
        if (this.AutomationRules != null) {
            var fspec = this.AutomationRules.AsFieldSpec(conf.Child("automationRules"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "automationRules" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolicyFilter? Filter
        // GraphQL -> filter: PolicyFilter (type)
        if (this.Filter != null) {
            var fspec = this.Filter.AsFieldSpec(conf.Child("filter"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filter" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FilterTypeLabelEntry>? Labels
        // GraphQL -> labels: [FilterTypeLabelEntry!]! (type)
        if (this.Labels != null) {
            var fspec = this.Labels.AsFieldSpec(conf.Child("labels"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "labels" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolicyTypeInfo? PolicyTypeInfo
        // GraphQL -> policyTypeInfo: PolicyTypeInfo (type)
        if (this.PolicyTypeInfo != null) {
            var fspec = this.PolicyTypeInfo.AsFieldSpec(conf.Child("policyTypeInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policyTypeInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PolicyFilter? ThresholdFilter
        // GraphQL -> thresholdFilter: PolicyFilter (type)
        if (this.ThresholdFilter != null) {
            var fspec = this.ThresholdFilter.AsFieldSpec(conf.Child("thresholdFilter"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "thresholdFilter" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> Category? PolicyCategory
        // GraphQL -> policyCategory: Category! (enum)
        if (ec.Includes("policyCategory",true))
        {
            if(this.PolicyCategory == null) {

                this.PolicyCategory = new Category();

            } else {


            }
        }
        else if (this.PolicyCategory != null && ec.Excludes("policyCategory",true))
        {
            this.PolicyCategory = null;
        }
        //      C# -> Severity? PolicySeverity
        // GraphQL -> policySeverity: Severity! (enum)
        if (ec.Includes("policySeverity",true))
        {
            if(this.PolicySeverity == null) {

                this.PolicySeverity = new Severity();

            } else {


            }
        }
        else if (this.PolicySeverity != null && ec.Excludes("policySeverity",true))
        {
            this.PolicySeverity = null;
        }
        //      C# -> PolicyType? PolicyType
        // GraphQL -> policyType: PolicyType! (enum)
        if (ec.Includes("policyType",true))
        {
            if(this.PolicyType == null) {

                this.PolicyType = new PolicyType();

            } else {


            }
        }
        else if (this.PolicyType != null && ec.Excludes("policyType",true))
        {
            this.PolicyType = null;
        }
        //      C# -> System.Boolean? ContainsAccessFilters
        // GraphQL -> containsAccessFilters: Boolean (scalar)
        if (ec.Includes("containsAccessFilters",true))
        {
            if(this.ContainsAccessFilters == null) {

                this.ContainsAccessFilters = true;

            } else {


            }
        }
        else if (this.ContainsAccessFilters != null && ec.Excludes("containsAccessFilters",true))
        {
            this.ContainsAccessFilters = null;
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
        //      C# -> System.String? CreatedBy
        // GraphQL -> createdBy: String! (scalar)
        if (ec.Includes("createdBy",true))
        {
            if(this.CreatedBy == null) {

                this.CreatedBy = "FETCH";

            } else {


            }
        }
        else if (this.CreatedBy != null && ec.Excludes("createdBy",true))
        {
            this.CreatedBy = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
        }
        //      C# -> List<System.String>? Frameworks
        // GraphQL -> frameworks: [String!]! (scalar)
        if (ec.Includes("frameworks",true))
        {
            if(this.Frameworks == null) {

                this.Frameworks = new List<System.String>();

            } else {


            }
        }
        else if (this.Frameworks != null && ec.Excludes("frameworks",true))
        {
            this.Frameworks = null;
        }
        //      C# -> System.Boolean? IsAutomationEnabled
        // GraphQL -> isAutomationEnabled: Boolean! (scalar)
        if (ec.Includes("isAutomationEnabled",true))
        {
            if(this.IsAutomationEnabled == null) {

                this.IsAutomationEnabled = true;

            } else {


            }
        }
        else if (this.IsAutomationEnabled != null && ec.Excludes("isAutomationEnabled",true))
        {
            this.IsAutomationEnabled = null;
        }
        //      C# -> System.Boolean? IsDeleted
        // GraphQL -> isDeleted: Boolean! (scalar)
        if (ec.Includes("isDeleted",true))
        {
            if(this.IsDeleted == null) {

                this.IsDeleted = true;

            } else {


            }
        }
        else if (this.IsDeleted != null && ec.Excludes("isDeleted",true))
        {
            this.IsDeleted = null;
        }
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        if (ec.Includes("isEnabled",true))
        {
            if(this.IsEnabled == null) {

                this.IsEnabled = true;

            } else {


            }
        }
        else if (this.IsEnabled != null && ec.Excludes("isEnabled",true))
        {
            this.IsEnabled = null;
        }
        //      C# -> System.Boolean? IsPredefined
        // GraphQL -> isPredefined: Boolean! (scalar)
        if (ec.Includes("isPredefined",true))
        {
            if(this.IsPredefined == null) {

                this.IsPredefined = true;

            } else {


            }
        }
        else if (this.IsPredefined != null && ec.Excludes("isPredefined",true))
        {
            this.IsPredefined = null;
        }
        //      C# -> System.Int32? LatestPolicyVersion
        // GraphQL -> latestPolicyVersion: Int! (scalar)
        if (ec.Includes("latestPolicyVersion",true))
        {
            if(this.LatestPolicyVersion == null) {

                this.LatestPolicyVersion = Int32.MinValue;

            } else {


            }
        }
        else if (this.LatestPolicyVersion != null && ec.Excludes("latestPolicyVersion",true))
        {
            this.LatestPolicyVersion = null;
        }
        //      C# -> System.String? ManualRemediationProcess
        // GraphQL -> manualRemediationProcess: String (scalar)
        if (ec.Includes("manualRemediationProcess",true))
        {
            if(this.ManualRemediationProcess == null) {

                this.ManualRemediationProcess = "FETCH";

            } else {


            }
        }
        else if (this.ManualRemediationProcess != null && ec.Excludes("manualRemediationProcess",true))
        {
            this.ManualRemediationProcess = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
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
        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: UUID! (scalar)
        if (ec.Includes("policyId",true))
        {
            if(this.PolicyId == null) {

                this.PolicyId = "FETCH";

            } else {


            }
        }
        else if (this.PolicyId != null && ec.Excludes("policyId",true))
        {
            this.PolicyId = null;
        }
        //      C# -> System.String? ProbabilityOfCompromise
        // GraphQL -> probabilityOfCompromise: String (scalar)
        if (ec.Includes("probabilityOfCompromise",true))
        {
            if(this.ProbabilityOfCompromise == null) {

                this.ProbabilityOfCompromise = "FETCH";

            } else {


            }
        }
        else if (this.ProbabilityOfCompromise != null && ec.Excludes("probabilityOfCompromise",true))
        {
            this.ProbabilityOfCompromise = null;
        }
        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime (scalar)
        if (ec.Includes("updatedAt",true))
        {
            if(this.UpdatedAt == null) {

                this.UpdatedAt = new DateTime();

            } else {


            }
        }
        else if (this.UpdatedAt != null && ec.Excludes("updatedAt",true))
        {
            this.UpdatedAt = null;
        }
        //      C# -> List<AutomationRule>? AutomationRules
        // GraphQL -> automationRules: [AutomationRule!]! (type)
        if (ec.Includes("automationRules",false))
        {
            if(this.AutomationRules == null) {

                this.AutomationRules = new List<AutomationRule>();
                this.AutomationRules.ApplyExploratoryFieldSpec(ec.NewChild("automationRules"));

            } else {

                this.AutomationRules.ApplyExploratoryFieldSpec(ec.NewChild("automationRules"));

            }
        }
        else if (this.AutomationRules != null && ec.Excludes("automationRules",false))
        {
            this.AutomationRules = null;
        }
        //      C# -> PolicyFilter? Filter
        // GraphQL -> filter: PolicyFilter (type)
        if (ec.Includes("filter",false))
        {
            if(this.Filter == null) {

                this.Filter = new PolicyFilter();
                this.Filter.ApplyExploratoryFieldSpec(ec.NewChild("filter"));

            } else {

                this.Filter.ApplyExploratoryFieldSpec(ec.NewChild("filter"));

            }
        }
        else if (this.Filter != null && ec.Excludes("filter",false))
        {
            this.Filter = null;
        }
        //      C# -> List<FilterTypeLabelEntry>? Labels
        // GraphQL -> labels: [FilterTypeLabelEntry!]! (type)
        if (ec.Includes("labels",false))
        {
            if(this.Labels == null) {

                this.Labels = new List<FilterTypeLabelEntry>();
                this.Labels.ApplyExploratoryFieldSpec(ec.NewChild("labels"));

            } else {

                this.Labels.ApplyExploratoryFieldSpec(ec.NewChild("labels"));

            }
        }
        else if (this.Labels != null && ec.Excludes("labels",false))
        {
            this.Labels = null;
        }
        //      C# -> PolicyTypeInfo? PolicyTypeInfo
        // GraphQL -> policyTypeInfo: PolicyTypeInfo (type)
        if (ec.Includes("policyTypeInfo",false))
        {
            if(this.PolicyTypeInfo == null) {

                this.PolicyTypeInfo = new PolicyTypeInfo();
                this.PolicyTypeInfo.ApplyExploratoryFieldSpec(ec.NewChild("policyTypeInfo"));

            } else {

                this.PolicyTypeInfo.ApplyExploratoryFieldSpec(ec.NewChild("policyTypeInfo"));

            }
        }
        else if (this.PolicyTypeInfo != null && ec.Excludes("policyTypeInfo",false))
        {
            this.PolicyTypeInfo = null;
        }
        //      C# -> PolicyFilter? ThresholdFilter
        // GraphQL -> thresholdFilter: PolicyFilter (type)
        if (ec.Includes("thresholdFilter",false))
        {
            if(this.ThresholdFilter == null) {

                this.ThresholdFilter = new PolicyFilter();
                this.ThresholdFilter.ApplyExploratoryFieldSpec(ec.NewChild("thresholdFilter"));

            } else {

                this.ThresholdFilter.ApplyExploratoryFieldSpec(ec.NewChild("thresholdFilter"));

            }
        }
        else if (this.ThresholdFilter != null && ec.Excludes("thresholdFilter",false))
        {
            this.ThresholdFilter = null;
        }
    }


    #endregion

    } // class DspmPolicy
    
    #endregion

    public static class ListDspmPolicyExtensions
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
            this List<DspmPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DspmPolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DspmPolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DspmPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DspmPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types