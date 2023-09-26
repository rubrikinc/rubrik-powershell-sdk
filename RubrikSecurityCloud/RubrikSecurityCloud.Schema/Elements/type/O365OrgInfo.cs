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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ProvisionStatus? Status
        // GraphQL -> status: ProvisionStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Boolean? ExchangeOnColossus
        // GraphQL -> exchangeOnColossus: Boolean! (scalar)
        if (this.ExchangeOnColossus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "exchangeOnColossus\n" ;
            } else {
                s += ind + "exchangeOnColossus\n" ;
            }
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.Int32? Past1DayMailboxComplianceCount
        // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
        if (this.Past1DayMailboxComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayMailboxComplianceCount\n" ;
            } else {
                s += ind + "past1DayMailboxComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
        // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayMailboxOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayMailboxOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DayMailboxOutOfComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DayOnedriveComplianceCount
        // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
        if (this.Past1DayOnedriveComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayOnedriveComplianceCount\n" ;
            } else {
                s += ind + "past1DayOnedriveComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
        // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayOnedriveOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayOnedriveOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DayOnedriveOutOfComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySharepointComplianceCount
        // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
        if (this.Past1DaySharepointComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySharepointComplianceCount\n" ;
            } else {
                s += ind + "past1DaySharepointComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
        // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySharepointOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySharepointOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DaySharepointOutOfComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySpListComplianceCount
        // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
        if (this.Past1DaySpListComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySpListComplianceCount\n" ;
            } else {
                s += ind + "past1DaySpListComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
        // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySpListOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySpListOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DaySpListOutOfComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionComplianceCount
        // GraphQL -> past1DaySpSiteCollectionComplianceCount: Int! (scalar)
        if (this.Past1DaySpSiteCollectionComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySpSiteCollectionComplianceCount\n" ;
            } else {
                s += ind + "past1DaySpSiteCollectionComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount
        // GraphQL -> past1DaySpSiteCollectionOutOfComplianceCount: Int! (scalar)
        if (this.Past1DaySpSiteCollectionOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DaySpSiteCollectionOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DaySpSiteCollectionOutOfComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DayTeamsComplianceCount
        // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
        if (this.Past1DayTeamsComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayTeamsComplianceCount\n" ;
            } else {
                s += ind + "past1DayTeamsComplianceCount\n" ;
            }
        }
        //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
        // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
        if (this.Past1DayTeamsOutOfComplianceCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "past1DayTeamsOutOfComplianceCount\n" ;
            } else {
                s += ind + "past1DayTeamsOutOfComplianceCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ProvisionStatus? Status
        // GraphQL -> status: ProvisionStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ProvisionStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Boolean? ExchangeOnColossus
        // GraphQL -> exchangeOnColossus: Boolean! (scalar)
        if (ec.Includes("exchangeOnColossus",true))
        {
            if(this.ExchangeOnColossus == null) {

                this.ExchangeOnColossus = true;

            } else {


            }
        }
        else if (this.ExchangeOnColossus != null && ec.Excludes("exchangeOnColossus",true))
        {
            this.ExchangeOnColossus = null;
        }
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: String! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.Int32? Past1DayMailboxComplianceCount
        // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayMailboxComplianceCount",true))
        {
            if(this.Past1DayMailboxComplianceCount == null) {

                this.Past1DayMailboxComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayMailboxComplianceCount != null && ec.Excludes("past1DayMailboxComplianceCount",true))
        {
            this.Past1DayMailboxComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
        // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayMailboxOutOfComplianceCount",true))
        {
            if(this.Past1DayMailboxOutOfComplianceCount == null) {

                this.Past1DayMailboxOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayMailboxOutOfComplianceCount != null && ec.Excludes("past1DayMailboxOutOfComplianceCount",true))
        {
            this.Past1DayMailboxOutOfComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DayOnedriveComplianceCount
        // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayOnedriveComplianceCount",true))
        {
            if(this.Past1DayOnedriveComplianceCount == null) {

                this.Past1DayOnedriveComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayOnedriveComplianceCount != null && ec.Excludes("past1DayOnedriveComplianceCount",true))
        {
            this.Past1DayOnedriveComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
        // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayOnedriveOutOfComplianceCount",true))
        {
            if(this.Past1DayOnedriveOutOfComplianceCount == null) {

                this.Past1DayOnedriveOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayOnedriveOutOfComplianceCount != null && ec.Excludes("past1DayOnedriveOutOfComplianceCount",true))
        {
            this.Past1DayOnedriveOutOfComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySharepointComplianceCount
        // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySharepointComplianceCount",true))
        {
            if(this.Past1DaySharepointComplianceCount == null) {

                this.Past1DaySharepointComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySharepointComplianceCount != null && ec.Excludes("past1DaySharepointComplianceCount",true))
        {
            this.Past1DaySharepointComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
        // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySharepointOutOfComplianceCount",true))
        {
            if(this.Past1DaySharepointOutOfComplianceCount == null) {

                this.Past1DaySharepointOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySharepointOutOfComplianceCount != null && ec.Excludes("past1DaySharepointOutOfComplianceCount",true))
        {
            this.Past1DaySharepointOutOfComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySpListComplianceCount
        // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySpListComplianceCount",true))
        {
            if(this.Past1DaySpListComplianceCount == null) {

                this.Past1DaySpListComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySpListComplianceCount != null && ec.Excludes("past1DaySpListComplianceCount",true))
        {
            this.Past1DaySpListComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
        // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySpListOutOfComplianceCount",true))
        {
            if(this.Past1DaySpListOutOfComplianceCount == null) {

                this.Past1DaySpListOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySpListOutOfComplianceCount != null && ec.Excludes("past1DaySpListOutOfComplianceCount",true))
        {
            this.Past1DaySpListOutOfComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionComplianceCount
        // GraphQL -> past1DaySpSiteCollectionComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySpSiteCollectionComplianceCount",true))
        {
            if(this.Past1DaySpSiteCollectionComplianceCount == null) {

                this.Past1DaySpSiteCollectionComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySpSiteCollectionComplianceCount != null && ec.Excludes("past1DaySpSiteCollectionComplianceCount",true))
        {
            this.Past1DaySpSiteCollectionComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount
        // GraphQL -> past1DaySpSiteCollectionOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DaySpSiteCollectionOutOfComplianceCount",true))
        {
            if(this.Past1DaySpSiteCollectionOutOfComplianceCount == null) {

                this.Past1DaySpSiteCollectionOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DaySpSiteCollectionOutOfComplianceCount != null && ec.Excludes("past1DaySpSiteCollectionOutOfComplianceCount",true))
        {
            this.Past1DaySpSiteCollectionOutOfComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DayTeamsComplianceCount
        // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayTeamsComplianceCount",true))
        {
            if(this.Past1DayTeamsComplianceCount == null) {

                this.Past1DayTeamsComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayTeamsComplianceCount != null && ec.Excludes("past1DayTeamsComplianceCount",true))
        {
            this.Past1DayTeamsComplianceCount = null;
        }
        //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
        // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
        if (ec.Includes("past1DayTeamsOutOfComplianceCount",true))
        {
            if(this.Past1DayTeamsOutOfComplianceCount == null) {

                this.Past1DayTeamsOutOfComplianceCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.Past1DayTeamsOutOfComplianceCount != null && ec.Excludes("past1DayTeamsOutOfComplianceCount",true))
        {
            this.Past1DayTeamsOutOfComplianceCount = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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