// O365OrgInfo.cs
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
    #region O365OrgInfo
    public class O365OrgInfo: BaseType
    {
        #region members

        //      C# -> ProvisionStatus? Status
        // GraphQL -> status: ProvisionStatus! (enum)
        [JsonProperty("status")]
        public ProvisionStatus? Status { get; set; }

        //      C# -> System.Boolean? ExchangeOnColossus
        // GraphQL -> exchangeOnColossus: Boolean! (scalar)
        [JsonProperty("exchangeOnColossus")]
        public System.Boolean? ExchangeOnColossus { get; set; }

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.Int32? Past1DayMailboxComplianceCount
        // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
        [JsonProperty("past1DayMailboxComplianceCount")]
        public System.Int32? Past1DayMailboxComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
        // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayMailboxOutOfComplianceCount")]
        public System.Int32? Past1DayMailboxOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayOnedriveComplianceCount
        // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
        [JsonProperty("past1DayOnedriveComplianceCount")]
        public System.Int32? Past1DayOnedriveComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
        // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayOnedriveOutOfComplianceCount")]
        public System.Int32? Past1DayOnedriveOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySharepointComplianceCount
        // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySharepointComplianceCount")]
        public System.Int32? Past1DaySharepointComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
        // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySharepointOutOfComplianceCount")]
        public System.Int32? Past1DaySharepointOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpListComplianceCount
        // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpListComplianceCount")]
        public System.Int32? Past1DaySpListComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
        // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpListOutOfComplianceCount")]
        public System.Int32? Past1DaySpListOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpSiteCollectionComplianceCount
        // GraphQL -> past1DaySpSiteCollectionComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpSiteCollectionComplianceCount")]
        public System.Int32? Past1DaySpSiteCollectionComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount
        // GraphQL -> past1DaySpSiteCollectionOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpSiteCollectionOutOfComplianceCount")]
        public System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayTeamsComplianceCount
        // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
        [JsonProperty("past1DayTeamsComplianceCount")]
        public System.Int32? Past1DayTeamsComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
        // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayTeamsOutOfComplianceCount")]
        public System.Int32? Past1DayTeamsOutOfComplianceCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365OrgInfo";
    }

    public O365OrgInfo Set(
        ProvisionStatus? Status = null,
        System.Boolean? ExchangeOnColossus = null,
        System.String? OrgId = null,
        System.Int32? Past1DayMailboxComplianceCount = null,
        System.Int32? Past1DayMailboxOutOfComplianceCount = null,
        System.Int32? Past1DayOnedriveComplianceCount = null,
        System.Int32? Past1DayOnedriveOutOfComplianceCount = null,
        System.Int32? Past1DaySharepointComplianceCount = null,
        System.Int32? Past1DaySharepointOutOfComplianceCount = null,
        System.Int32? Past1DaySpListComplianceCount = null,
        System.Int32? Past1DaySpListOutOfComplianceCount = null,
        System.Int32? Past1DaySpSiteCollectionComplianceCount = null,
        System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount = null,
        System.Int32? Past1DayTeamsComplianceCount = null,
        System.Int32? Past1DayTeamsOutOfComplianceCount = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ExchangeOnColossus != null ) {
            this.ExchangeOnColossus = ExchangeOnColossus;
        }
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( Past1DayMailboxComplianceCount != null ) {
            this.Past1DayMailboxComplianceCount = Past1DayMailboxComplianceCount;
        }
        if ( Past1DayMailboxOutOfComplianceCount != null ) {
            this.Past1DayMailboxOutOfComplianceCount = Past1DayMailboxOutOfComplianceCount;
        }
        if ( Past1DayOnedriveComplianceCount != null ) {
            this.Past1DayOnedriveComplianceCount = Past1DayOnedriveComplianceCount;
        }
        if ( Past1DayOnedriveOutOfComplianceCount != null ) {
            this.Past1DayOnedriveOutOfComplianceCount = Past1DayOnedriveOutOfComplianceCount;
        }
        if ( Past1DaySharepointComplianceCount != null ) {
            this.Past1DaySharepointComplianceCount = Past1DaySharepointComplianceCount;
        }
        if ( Past1DaySharepointOutOfComplianceCount != null ) {
            this.Past1DaySharepointOutOfComplianceCount = Past1DaySharepointOutOfComplianceCount;
        }
        if ( Past1DaySpListComplianceCount != null ) {
            this.Past1DaySpListComplianceCount = Past1DaySpListComplianceCount;
        }
        if ( Past1DaySpListOutOfComplianceCount != null ) {
            this.Past1DaySpListOutOfComplianceCount = Past1DaySpListOutOfComplianceCount;
        }
        if ( Past1DaySpSiteCollectionComplianceCount != null ) {
            this.Past1DaySpSiteCollectionComplianceCount = Past1DaySpSiteCollectionComplianceCount;
        }
        if ( Past1DaySpSiteCollectionOutOfComplianceCount != null ) {
            this.Past1DaySpSiteCollectionOutOfComplianceCount = Past1DaySpSiteCollectionOutOfComplianceCount;
        }
        if ( Past1DayTeamsComplianceCount != null ) {
            this.Past1DayTeamsComplianceCount = Past1DayTeamsComplianceCount;
        }
        if ( Past1DayTeamsOutOfComplianceCount != null ) {
            this.Past1DayTeamsOutOfComplianceCount = Past1DayTeamsOutOfComplianceCount;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ProvisionStatus? Status
        // GraphQL -> status: ProvisionStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Boolean? ExchangeOnColossus
        // GraphQL -> exchangeOnColossus: Boolean! (scalar)
        if (this.ExchangeOnColossus != null) {
            s += ind + "exchangeOnColossus\n" ;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            s += ind + "orgId\n" ;
        }
        //      C# -> System.Int32? Past1DayMailboxComplianceCount
        // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
        if (this.Past1DayMailboxComplianceCount != null) {
            s += ind + "past1DayMailboxComplianceCount\n" ;
        }
        //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
        // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayMailboxOutOfComplianceCount != null) {
            s += ind + "past1DayMailboxOutOfComplianceCount\n" ;
        }
        //      C# -> System.Int32? Past1DayOnedriveComplianceCount
        // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
        if (this.Past1DayOnedriveComplianceCount != null) {
            s += ind + "past1DayOnedriveComplianceCount\n" ;
        }
        //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
        // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayOnedriveOutOfComplianceCount != null) {
            s += ind + "past1DayOnedriveOutOfComplianceCount\n" ;
        }
        //      C# -> System.Int32? Past1DaySharepointComplianceCount
        // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
        if (this.Past1DaySharepointComplianceCount != null) {
            s += ind + "past1DaySharepointComplianceCount\n" ;
        }
        //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
        // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySharepointOutOfComplianceCount != null) {
            s += ind + "past1DaySharepointOutOfComplianceCount\n" ;
        }
        //      C# -> System.Int32? Past1DaySpListComplianceCount
        // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
        if (this.Past1DaySpListComplianceCount != null) {
            s += ind + "past1DaySpListComplianceCount\n" ;
        }
        //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
        // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySpListOutOfComplianceCount != null) {
            s += ind + "past1DaySpListOutOfComplianceCount\n" ;
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionComplianceCount
        // GraphQL -> past1DaySpSiteCollectionComplianceCount: Int! (scalar)
        if (this.Past1DaySpSiteCollectionComplianceCount != null) {
            s += ind + "past1DaySpSiteCollectionComplianceCount\n" ;
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount
        // GraphQL -> past1DaySpSiteCollectionOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySpSiteCollectionOutOfComplianceCount != null) {
            s += ind + "past1DaySpSiteCollectionOutOfComplianceCount\n" ;
        }
        //      C# -> System.Int32? Past1DayTeamsComplianceCount
        // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
        if (this.Past1DayTeamsComplianceCount != null) {
            s += ind + "past1DayTeamsComplianceCount\n" ;
        }
        //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
        // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayTeamsOutOfComplianceCount != null) {
            s += ind + "past1DayTeamsOutOfComplianceCount\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ProvisionStatus? Status
        // GraphQL -> status: ProvisionStatus! (enum)
        if (this.Status == null && ec.Includes("status",true))
        {
            this.Status = new ProvisionStatus();
        }
        //      C# -> System.Boolean? ExchangeOnColossus
        // GraphQL -> exchangeOnColossus: Boolean! (scalar)
        if (this.ExchangeOnColossus == null && ec.Includes("exchangeOnColossus",true))
        {
            this.ExchangeOnColossus = true;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId == null && ec.Includes("orgId",true))
        {
            this.OrgId = "FETCH";
        }
        //      C# -> System.Int32? Past1DayMailboxComplianceCount
        // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
        if (this.Past1DayMailboxComplianceCount == null && ec.Includes("past1DayMailboxComplianceCount",true))
        {
            this.Past1DayMailboxComplianceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
        // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayMailboxOutOfComplianceCount == null && ec.Includes("past1DayMailboxOutOfComplianceCount",true))
        {
            this.Past1DayMailboxOutOfComplianceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Past1DayOnedriveComplianceCount
        // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
        if (this.Past1DayOnedriveComplianceCount == null && ec.Includes("past1DayOnedriveComplianceCount",true))
        {
            this.Past1DayOnedriveComplianceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
        // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayOnedriveOutOfComplianceCount == null && ec.Includes("past1DayOnedriveOutOfComplianceCount",true))
        {
            this.Past1DayOnedriveOutOfComplianceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Past1DaySharepointComplianceCount
        // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
        if (this.Past1DaySharepointComplianceCount == null && ec.Includes("past1DaySharepointComplianceCount",true))
        {
            this.Past1DaySharepointComplianceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
        // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySharepointOutOfComplianceCount == null && ec.Includes("past1DaySharepointOutOfComplianceCount",true))
        {
            this.Past1DaySharepointOutOfComplianceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Past1DaySpListComplianceCount
        // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
        if (this.Past1DaySpListComplianceCount == null && ec.Includes("past1DaySpListComplianceCount",true))
        {
            this.Past1DaySpListComplianceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
        // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySpListOutOfComplianceCount == null && ec.Includes("past1DaySpListOutOfComplianceCount",true))
        {
            this.Past1DaySpListOutOfComplianceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionComplianceCount
        // GraphQL -> past1DaySpSiteCollectionComplianceCount: Int! (scalar)
        if (this.Past1DaySpSiteCollectionComplianceCount == null && ec.Includes("past1DaySpSiteCollectionComplianceCount",true))
        {
            this.Past1DaySpSiteCollectionComplianceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount
        // GraphQL -> past1DaySpSiteCollectionOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySpSiteCollectionOutOfComplianceCount == null && ec.Includes("past1DaySpSiteCollectionOutOfComplianceCount",true))
        {
            this.Past1DaySpSiteCollectionOutOfComplianceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Past1DayTeamsComplianceCount
        // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
        if (this.Past1DayTeamsComplianceCount == null && ec.Includes("past1DayTeamsComplianceCount",true))
        {
            this.Past1DayTeamsComplianceCount = Int32.MinValue;
        }
        //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
        // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayTeamsOutOfComplianceCount == null && ec.Includes("past1DayTeamsOutOfComplianceCount",true))
        {
            this.Past1DayTeamsOutOfComplianceCount = Int32.MinValue;
        }
    }


    #endregion

    } // class O365OrgInfo
    
    #endregion

    public static class ListO365OrgInfoExtensions
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
            this List<O365OrgInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365OrgInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365OrgInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365OrgInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types