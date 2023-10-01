// CdmUpgradeReleaseDetailsFromSupportPortalReply.cs
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
    #region CdmUpgradeReleaseDetailsFromSupportPortalReply
    public class CdmUpgradeReleaseDetailsFromSupportPortalReply: BaseType
    {
        #region members

        //      C# -> System.String? CompatibilityMatrixLink
        // GraphQL -> compatibilityMatrixLink: String! (scalar)
        [JsonProperty("compatibilityMatrixLink")]
        public System.String? CompatibilityMatrixLink { get; set; }

        //      C# -> System.String? SupportSoftwareLink
        // GraphQL -> supportSoftwareLink: String! (scalar)
        [JsonProperty("supportSoftwareLink")]
        public System.String? SupportSoftwareLink { get; set; }

        //      C# -> List<CdmUpgradeReleaseDetail>? ReleaseDetails
        // GraphQL -> releaseDetails: [CdmUpgradeReleaseDetail!]! (type)
        [JsonProperty("releaseDetails")]
        public List<CdmUpgradeReleaseDetail>? ReleaseDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmUpgradeReleaseDetailsFromSupportPortalReply";
    }

    public CdmUpgradeReleaseDetailsFromSupportPortalReply Set(
        System.String? CompatibilityMatrixLink = null,
        System.String? SupportSoftwareLink = null,
        List<CdmUpgradeReleaseDetail>? ReleaseDetails = null
    ) 
    {
        if ( CompatibilityMatrixLink != null ) {
            this.CompatibilityMatrixLink = CompatibilityMatrixLink;
        }
        if ( SupportSoftwareLink != null ) {
            this.SupportSoftwareLink = SupportSoftwareLink;
        }
        if ( ReleaseDetails != null ) {
            this.ReleaseDetails = ReleaseDetails;
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
        //      C# -> System.String? CompatibilityMatrixLink
        // GraphQL -> compatibilityMatrixLink: String! (scalar)
        if (this.CompatibilityMatrixLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "compatibilityMatrixLink\n" ;
            } else {
                s += ind + "compatibilityMatrixLink\n" ;
            }
        }
        //      C# -> System.String? SupportSoftwareLink
        // GraphQL -> supportSoftwareLink: String! (scalar)
        if (this.SupportSoftwareLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supportSoftwareLink\n" ;
            } else {
                s += ind + "supportSoftwareLink\n" ;
            }
        }
        //      C# -> List<CdmUpgradeReleaseDetail>? ReleaseDetails
        // GraphQL -> releaseDetails: [CdmUpgradeReleaseDetail!]! (type)
        if (this.ReleaseDetails != null) {
            var fspec = this.ReleaseDetails.AsFieldSpec(conf.Child("releaseDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "releaseDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CompatibilityMatrixLink
        // GraphQL -> compatibilityMatrixLink: String! (scalar)
        if (ec.Includes("compatibilityMatrixLink",true))
        {
            if(this.CompatibilityMatrixLink == null) {

                this.CompatibilityMatrixLink = "FETCH";

            } else {


            }
        }
        else if (this.CompatibilityMatrixLink != null && ec.Excludes("compatibilityMatrixLink",true))
        {
            this.CompatibilityMatrixLink = null;
        }
        //      C# -> System.String? SupportSoftwareLink
        // GraphQL -> supportSoftwareLink: String! (scalar)
        if (ec.Includes("supportSoftwareLink",true))
        {
            if(this.SupportSoftwareLink == null) {

                this.SupportSoftwareLink = "FETCH";

            } else {


            }
        }
        else if (this.SupportSoftwareLink != null && ec.Excludes("supportSoftwareLink",true))
        {
            this.SupportSoftwareLink = null;
        }
        //      C# -> List<CdmUpgradeReleaseDetail>? ReleaseDetails
        // GraphQL -> releaseDetails: [CdmUpgradeReleaseDetail!]! (type)
        if (ec.Includes("releaseDetails",false))
        {
            if(this.ReleaseDetails == null) {

                this.ReleaseDetails = new List<CdmUpgradeReleaseDetail>();
                this.ReleaseDetails.ApplyExploratoryFieldSpec(ec.NewChild("releaseDetails"));

            } else {

                this.ReleaseDetails.ApplyExploratoryFieldSpec(ec.NewChild("releaseDetails"));

            }
        }
        else if (this.ReleaseDetails != null && ec.Excludes("releaseDetails",false))
        {
            this.ReleaseDetails = null;
        }
    }


    #endregion

    } // class CdmUpgradeReleaseDetailsFromSupportPortalReply
    
    #endregion

    public static class ListCdmUpgradeReleaseDetailsFromSupportPortalReplyExtensions
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
            this List<CdmUpgradeReleaseDetailsFromSupportPortalReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CdmUpgradeReleaseDetailsFromSupportPortalReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmUpgradeReleaseDetailsFromSupportPortalReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmUpgradeReleaseDetailsFromSupportPortalReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmUpgradeReleaseDetailsFromSupportPortalReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types