// AzureAdPimPolicy.cs
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
    #region AzureAdPimPolicy
    public class AzureAdPimPolicy: BaseType
    {
        #region members

        //      C# -> System.Int32? ActivationMaxDurationMinutes
        // GraphQL -> activationMaxDurationMinutes: Int! (scalar)
        [JsonProperty("activationMaxDurationMinutes")]
        public System.Int32? ActivationMaxDurationMinutes { get; set; }

        //      C# -> System.Int64? ActivationMaxDurationSeconds
        // GraphQL -> activationMaxDurationSeconds: Long! (scalar)
        [JsonProperty("activationMaxDurationSeconds")]
        public System.Int64? ActivationMaxDurationSeconds { get; set; }

        //      C# -> System.Int32? ActiveAssignmentExpirationDays
        // GraphQL -> activeAssignmentExpirationDays: Int! (scalar)
        [JsonProperty("activeAssignmentExpirationDays")]
        public System.Int32? ActiveAssignmentExpirationDays { get; set; }

        //      C# -> System.Int64? ActiveAssignmentExpirationSeconds
        // GraphQL -> activeAssignmentExpirationSeconds: Long! (scalar)
        [JsonProperty("activeAssignmentExpirationSeconds")]
        public System.Int64? ActiveAssignmentExpirationSeconds { get; set; }

        //      C# -> System.Boolean? AllowPermanentActiveAssignment
        // GraphQL -> allowPermanentActiveAssignment: Boolean! (scalar)
        [JsonProperty("allowPermanentActiveAssignment")]
        public System.Boolean? AllowPermanentActiveAssignment { get; set; }

        //      C# -> System.Boolean? AllowPermanentEligibleAssignment
        // GraphQL -> allowPermanentEligibleAssignment: Boolean! (scalar)
        [JsonProperty("allowPermanentEligibleAssignment")]
        public System.Boolean? AllowPermanentEligibleAssignment { get; set; }

        //      C# -> List<System.String>? Approvers
        // GraphQL -> approvers: [String!]! (scalar)
        [JsonProperty("approvers")]
        public List<System.String>? Approvers { get; set; }

        //      C# -> System.Int32? EligibleAssignmentExpirationDays
        // GraphQL -> eligibleAssignmentExpirationDays: Int! (scalar)
        [JsonProperty("eligibleAssignmentExpirationDays")]
        public System.Int32? EligibleAssignmentExpirationDays { get; set; }

        //      C# -> System.Int64? EligibleAssignmentExpirationSeconds
        // GraphQL -> eligibleAssignmentExpirationSeconds: Long! (scalar)
        [JsonProperty("eligibleAssignmentExpirationSeconds")]
        public System.Int64? EligibleAssignmentExpirationSeconds { get; set; }

        //      C# -> System.Boolean? RequireApprovalToActivate
        // GraphQL -> requireApprovalToActivate: Boolean! (scalar)
        [JsonProperty("requireApprovalToActivate")]
        public System.Boolean? RequireApprovalToActivate { get; set; }

        //      C# -> System.Boolean? RequireMfaOnActiveAssignment
        // GraphQL -> requireMfaOnActiveAssignment: Boolean! (scalar)
        [JsonProperty("requireMfaOnActiveAssignment")]
        public System.Boolean? RequireMfaOnActiveAssignment { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdPimPolicy";
    }

    public AzureAdPimPolicy Set(
        System.Int32? ActivationMaxDurationMinutes = null,
        System.Int64? ActivationMaxDurationSeconds = null,
        System.Int32? ActiveAssignmentExpirationDays = null,
        System.Int64? ActiveAssignmentExpirationSeconds = null,
        System.Boolean? AllowPermanentActiveAssignment = null,
        System.Boolean? AllowPermanentEligibleAssignment = null,
        List<System.String>? Approvers = null,
        System.Int32? EligibleAssignmentExpirationDays = null,
        System.Int64? EligibleAssignmentExpirationSeconds = null,
        System.Boolean? RequireApprovalToActivate = null,
        System.Boolean? RequireMfaOnActiveAssignment = null
    ) 
    {
        if ( ActivationMaxDurationMinutes != null ) {
            this.ActivationMaxDurationMinutes = ActivationMaxDurationMinutes;
        }
        if ( ActivationMaxDurationSeconds != null ) {
            this.ActivationMaxDurationSeconds = ActivationMaxDurationSeconds;
        }
        if ( ActiveAssignmentExpirationDays != null ) {
            this.ActiveAssignmentExpirationDays = ActiveAssignmentExpirationDays;
        }
        if ( ActiveAssignmentExpirationSeconds != null ) {
            this.ActiveAssignmentExpirationSeconds = ActiveAssignmentExpirationSeconds;
        }
        if ( AllowPermanentActiveAssignment != null ) {
            this.AllowPermanentActiveAssignment = AllowPermanentActiveAssignment;
        }
        if ( AllowPermanentEligibleAssignment != null ) {
            this.AllowPermanentEligibleAssignment = AllowPermanentEligibleAssignment;
        }
        if ( Approvers != null ) {
            this.Approvers = Approvers;
        }
        if ( EligibleAssignmentExpirationDays != null ) {
            this.EligibleAssignmentExpirationDays = EligibleAssignmentExpirationDays;
        }
        if ( EligibleAssignmentExpirationSeconds != null ) {
            this.EligibleAssignmentExpirationSeconds = EligibleAssignmentExpirationSeconds;
        }
        if ( RequireApprovalToActivate != null ) {
            this.RequireApprovalToActivate = RequireApprovalToActivate;
        }
        if ( RequireMfaOnActiveAssignment != null ) {
            this.RequireMfaOnActiveAssignment = RequireMfaOnActiveAssignment;
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
        //      C# -> System.Int32? ActivationMaxDurationMinutes
        // GraphQL -> activationMaxDurationMinutes: Int! (scalar)
        if (this.ActivationMaxDurationMinutes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activationMaxDurationMinutes\n" ;
            } else {
                s += ind + "activationMaxDurationMinutes\n" ;
            }
        }
        //      C# -> System.Int64? ActivationMaxDurationSeconds
        // GraphQL -> activationMaxDurationSeconds: Long! (scalar)
        if (this.ActivationMaxDurationSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activationMaxDurationSeconds\n" ;
            } else {
                s += ind + "activationMaxDurationSeconds\n" ;
            }
        }
        //      C# -> System.Int32? ActiveAssignmentExpirationDays
        // GraphQL -> activeAssignmentExpirationDays: Int! (scalar)
        if (this.ActiveAssignmentExpirationDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeAssignmentExpirationDays\n" ;
            } else {
                s += ind + "activeAssignmentExpirationDays\n" ;
            }
        }
        //      C# -> System.Int64? ActiveAssignmentExpirationSeconds
        // GraphQL -> activeAssignmentExpirationSeconds: Long! (scalar)
        if (this.ActiveAssignmentExpirationSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeAssignmentExpirationSeconds\n" ;
            } else {
                s += ind + "activeAssignmentExpirationSeconds\n" ;
            }
        }
        //      C# -> System.Boolean? AllowPermanentActiveAssignment
        // GraphQL -> allowPermanentActiveAssignment: Boolean! (scalar)
        if (this.AllowPermanentActiveAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowPermanentActiveAssignment\n" ;
            } else {
                s += ind + "allowPermanentActiveAssignment\n" ;
            }
        }
        //      C# -> System.Boolean? AllowPermanentEligibleAssignment
        // GraphQL -> allowPermanentEligibleAssignment: Boolean! (scalar)
        if (this.AllowPermanentEligibleAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowPermanentEligibleAssignment\n" ;
            } else {
                s += ind + "allowPermanentEligibleAssignment\n" ;
            }
        }
        //      C# -> List<System.String>? Approvers
        // GraphQL -> approvers: [String!]! (scalar)
        if (this.Approvers != null) {
            if (conf.Flat) {
                s += conf.Prefix + "approvers\n" ;
            } else {
                s += ind + "approvers\n" ;
            }
        }
        //      C# -> System.Int32? EligibleAssignmentExpirationDays
        // GraphQL -> eligibleAssignmentExpirationDays: Int! (scalar)
        if (this.EligibleAssignmentExpirationDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eligibleAssignmentExpirationDays\n" ;
            } else {
                s += ind + "eligibleAssignmentExpirationDays\n" ;
            }
        }
        //      C# -> System.Int64? EligibleAssignmentExpirationSeconds
        // GraphQL -> eligibleAssignmentExpirationSeconds: Long! (scalar)
        if (this.EligibleAssignmentExpirationSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eligibleAssignmentExpirationSeconds\n" ;
            } else {
                s += ind + "eligibleAssignmentExpirationSeconds\n" ;
            }
        }
        //      C# -> System.Boolean? RequireApprovalToActivate
        // GraphQL -> requireApprovalToActivate: Boolean! (scalar)
        if (this.RequireApprovalToActivate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requireApprovalToActivate\n" ;
            } else {
                s += ind + "requireApprovalToActivate\n" ;
            }
        }
        //      C# -> System.Boolean? RequireMfaOnActiveAssignment
        // GraphQL -> requireMfaOnActiveAssignment: Boolean! (scalar)
        if (this.RequireMfaOnActiveAssignment != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requireMfaOnActiveAssignment\n" ;
            } else {
                s += ind + "requireMfaOnActiveAssignment\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? ActivationMaxDurationMinutes
        // GraphQL -> activationMaxDurationMinutes: Int! (scalar)
        if (ec.Includes("activationMaxDurationMinutes",true))
        {
            if(this.ActivationMaxDurationMinutes == null) {

                this.ActivationMaxDurationMinutes = Int32.MinValue;

            } else {


            }
        }
        else if (this.ActivationMaxDurationMinutes != null && ec.Excludes("activationMaxDurationMinutes",true))
        {
            this.ActivationMaxDurationMinutes = null;
        }
        //      C# -> System.Int64? ActivationMaxDurationSeconds
        // GraphQL -> activationMaxDurationSeconds: Long! (scalar)
        if (ec.Includes("activationMaxDurationSeconds",true))
        {
            if(this.ActivationMaxDurationSeconds == null) {

                this.ActivationMaxDurationSeconds = new System.Int64();

            } else {


            }
        }
        else if (this.ActivationMaxDurationSeconds != null && ec.Excludes("activationMaxDurationSeconds",true))
        {
            this.ActivationMaxDurationSeconds = null;
        }
        //      C# -> System.Int32? ActiveAssignmentExpirationDays
        // GraphQL -> activeAssignmentExpirationDays: Int! (scalar)
        if (ec.Includes("activeAssignmentExpirationDays",true))
        {
            if(this.ActiveAssignmentExpirationDays == null) {

                this.ActiveAssignmentExpirationDays = Int32.MinValue;

            } else {


            }
        }
        else if (this.ActiveAssignmentExpirationDays != null && ec.Excludes("activeAssignmentExpirationDays",true))
        {
            this.ActiveAssignmentExpirationDays = null;
        }
        //      C# -> System.Int64? ActiveAssignmentExpirationSeconds
        // GraphQL -> activeAssignmentExpirationSeconds: Long! (scalar)
        if (ec.Includes("activeAssignmentExpirationSeconds",true))
        {
            if(this.ActiveAssignmentExpirationSeconds == null) {

                this.ActiveAssignmentExpirationSeconds = new System.Int64();

            } else {


            }
        }
        else if (this.ActiveAssignmentExpirationSeconds != null && ec.Excludes("activeAssignmentExpirationSeconds",true))
        {
            this.ActiveAssignmentExpirationSeconds = null;
        }
        //      C# -> System.Boolean? AllowPermanentActiveAssignment
        // GraphQL -> allowPermanentActiveAssignment: Boolean! (scalar)
        if (ec.Includes("allowPermanentActiveAssignment",true))
        {
            if(this.AllowPermanentActiveAssignment == null) {

                this.AllowPermanentActiveAssignment = true;

            } else {


            }
        }
        else if (this.AllowPermanentActiveAssignment != null && ec.Excludes("allowPermanentActiveAssignment",true))
        {
            this.AllowPermanentActiveAssignment = null;
        }
        //      C# -> System.Boolean? AllowPermanentEligibleAssignment
        // GraphQL -> allowPermanentEligibleAssignment: Boolean! (scalar)
        if (ec.Includes("allowPermanentEligibleAssignment",true))
        {
            if(this.AllowPermanentEligibleAssignment == null) {

                this.AllowPermanentEligibleAssignment = true;

            } else {


            }
        }
        else if (this.AllowPermanentEligibleAssignment != null && ec.Excludes("allowPermanentEligibleAssignment",true))
        {
            this.AllowPermanentEligibleAssignment = null;
        }
        //      C# -> List<System.String>? Approvers
        // GraphQL -> approvers: [String!]! (scalar)
        if (ec.Includes("approvers",true))
        {
            if(this.Approvers == null) {

                this.Approvers = new List<System.String>();

            } else {


            }
        }
        else if (this.Approvers != null && ec.Excludes("approvers",true))
        {
            this.Approvers = null;
        }
        //      C# -> System.Int32? EligibleAssignmentExpirationDays
        // GraphQL -> eligibleAssignmentExpirationDays: Int! (scalar)
        if (ec.Includes("eligibleAssignmentExpirationDays",true))
        {
            if(this.EligibleAssignmentExpirationDays == null) {

                this.EligibleAssignmentExpirationDays = Int32.MinValue;

            } else {


            }
        }
        else if (this.EligibleAssignmentExpirationDays != null && ec.Excludes("eligibleAssignmentExpirationDays",true))
        {
            this.EligibleAssignmentExpirationDays = null;
        }
        //      C# -> System.Int64? EligibleAssignmentExpirationSeconds
        // GraphQL -> eligibleAssignmentExpirationSeconds: Long! (scalar)
        if (ec.Includes("eligibleAssignmentExpirationSeconds",true))
        {
            if(this.EligibleAssignmentExpirationSeconds == null) {

                this.EligibleAssignmentExpirationSeconds = new System.Int64();

            } else {


            }
        }
        else if (this.EligibleAssignmentExpirationSeconds != null && ec.Excludes("eligibleAssignmentExpirationSeconds",true))
        {
            this.EligibleAssignmentExpirationSeconds = null;
        }
        //      C# -> System.Boolean? RequireApprovalToActivate
        // GraphQL -> requireApprovalToActivate: Boolean! (scalar)
        if (ec.Includes("requireApprovalToActivate",true))
        {
            if(this.RequireApprovalToActivate == null) {

                this.RequireApprovalToActivate = true;

            } else {


            }
        }
        else if (this.RequireApprovalToActivate != null && ec.Excludes("requireApprovalToActivate",true))
        {
            this.RequireApprovalToActivate = null;
        }
        //      C# -> System.Boolean? RequireMfaOnActiveAssignment
        // GraphQL -> requireMfaOnActiveAssignment: Boolean! (scalar)
        if (ec.Includes("requireMfaOnActiveAssignment",true))
        {
            if(this.RequireMfaOnActiveAssignment == null) {

                this.RequireMfaOnActiveAssignment = true;

            } else {


            }
        }
        else if (this.RequireMfaOnActiveAssignment != null && ec.Excludes("requireMfaOnActiveAssignment",true))
        {
            this.RequireMfaOnActiveAssignment = null;
        }
    }


    #endregion

    } // class AzureAdPimPolicy
    
    #endregion

    public static class ListAzureAdPimPolicyExtensions
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
            this List<AzureAdPimPolicy> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdPimPolicy> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdPimPolicy> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdPimPolicy());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdPimPolicy> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types