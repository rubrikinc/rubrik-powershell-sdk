// CdmUpgradeReleaseDetail.cs
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
    #region CdmUpgradeReleaseDetail
    public class CdmUpgradeReleaseDetail: BaseType
    {
        #region members

        //      C# -> AdoptionStatus? AdoptionStatus
        // GraphQL -> adoptionStatus: AdoptionStatus! (enum)
        [JsonProperty("adoptionStatus")]
        public AdoptionStatus? AdoptionStatus { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? GaReleaseDate
        // GraphQL -> gaReleaseDate: String! (scalar)
        [JsonProperty("gaReleaseDate")]
        public System.String? GaReleaseDate { get; set; }

        //      C# -> System.Boolean? IsRecommended
        // GraphQL -> isRecommended: Boolean! (scalar)
        [JsonProperty("isRecommended")]
        public System.Boolean? IsRecommended { get; set; }

        //      C# -> System.Boolean? IsUpgradable
        // GraphQL -> isUpgradable: Boolean! (scalar)
        [JsonProperty("isUpgradable")]
        public System.Boolean? IsUpgradable { get; set; }

        //      C# -> System.String? Md5Sum
        // GraphQL -> md5Sum: String! (scalar)
        [JsonProperty("md5Sum")]
        public System.String? Md5Sum { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ReleaseDate
        // GraphQL -> releaseDate: String! (scalar)
        [JsonProperty("releaseDate")]
        public System.String? ReleaseDate { get; set; }

        //      C# -> System.String? ReleaseNotesLink
        // GraphQL -> releaseNotesLink: String! (scalar)
        [JsonProperty("releaseNotesLink")]
        public System.String? ReleaseNotesLink { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? TarDownloadLink
        // GraphQL -> tarDownloadLink: String! (scalar)
        [JsonProperty("tarDownloadLink")]
        public System.String? TarDownloadLink { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmUpgradeReleaseDetail";
    }

    public CdmUpgradeReleaseDetail Set(
        AdoptionStatus? AdoptionStatus = null,
        System.String? Description = null,
        System.String? GaReleaseDate = null,
        System.Boolean? IsRecommended = null,
        System.Boolean? IsUpgradable = null,
        System.String? Md5Sum = null,
        System.String? Name = null,
        System.String? ReleaseDate = null,
        System.String? ReleaseNotesLink = null,
        System.Int64? Size = null,
        System.String? TarDownloadLink = null
    ) 
    {
        if ( AdoptionStatus != null ) {
            this.AdoptionStatus = AdoptionStatus;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( GaReleaseDate != null ) {
            this.GaReleaseDate = GaReleaseDate;
        }
        if ( IsRecommended != null ) {
            this.IsRecommended = IsRecommended;
        }
        if ( IsUpgradable != null ) {
            this.IsUpgradable = IsUpgradable;
        }
        if ( Md5Sum != null ) {
            this.Md5Sum = Md5Sum;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ReleaseDate != null ) {
            this.ReleaseDate = ReleaseDate;
        }
        if ( ReleaseNotesLink != null ) {
            this.ReleaseNotesLink = ReleaseNotesLink;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( TarDownloadLink != null ) {
            this.TarDownloadLink = TarDownloadLink;
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
        //      C# -> AdoptionStatus? AdoptionStatus
        // GraphQL -> adoptionStatus: AdoptionStatus! (enum)
        if (this.AdoptionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "adoptionStatus\n" ;
            } else {
                s += ind + "adoptionStatus\n" ;
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
        //      C# -> System.String? GaReleaseDate
        // GraphQL -> gaReleaseDate: String! (scalar)
        if (this.GaReleaseDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gaReleaseDate\n" ;
            } else {
                s += ind + "gaReleaseDate\n" ;
            }
        }
        //      C# -> System.Boolean? IsRecommended
        // GraphQL -> isRecommended: Boolean! (scalar)
        if (this.IsRecommended != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRecommended\n" ;
            } else {
                s += ind + "isRecommended\n" ;
            }
        }
        //      C# -> System.Boolean? IsUpgradable
        // GraphQL -> isUpgradable: Boolean! (scalar)
        if (this.IsUpgradable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUpgradable\n" ;
            } else {
                s += ind + "isUpgradable\n" ;
            }
        }
        //      C# -> System.String? Md5Sum
        // GraphQL -> md5Sum: String! (scalar)
        if (this.Md5Sum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "md5Sum\n" ;
            } else {
                s += ind + "md5Sum\n" ;
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
        //      C# -> System.String? ReleaseDate
        // GraphQL -> releaseDate: String! (scalar)
        if (this.ReleaseDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "releaseDate\n" ;
            } else {
                s += ind + "releaseDate\n" ;
            }
        }
        //      C# -> System.String? ReleaseNotesLink
        // GraphQL -> releaseNotesLink: String! (scalar)
        if (this.ReleaseNotesLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "releaseNotesLink\n" ;
            } else {
                s += ind + "releaseNotesLink\n" ;
            }
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            if (conf.Flat) {
                s += conf.Prefix + "size\n" ;
            } else {
                s += ind + "size\n" ;
            }
        }
        //      C# -> System.String? TarDownloadLink
        // GraphQL -> tarDownloadLink: String! (scalar)
        if (this.TarDownloadLink != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tarDownloadLink\n" ;
            } else {
                s += ind + "tarDownloadLink\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AdoptionStatus? AdoptionStatus
        // GraphQL -> adoptionStatus: AdoptionStatus! (enum)
        if (ec.Includes("adoptionStatus",true))
        {
            if(this.AdoptionStatus == null) {

                this.AdoptionStatus = new AdoptionStatus();

            } else {


            }
        }
        else if (this.AdoptionStatus != null && ec.Excludes("adoptionStatus",true))
        {
            this.AdoptionStatus = null;
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
        //      C# -> System.String? GaReleaseDate
        // GraphQL -> gaReleaseDate: String! (scalar)
        if (ec.Includes("gaReleaseDate",true))
        {
            if(this.GaReleaseDate == null) {

                this.GaReleaseDate = "FETCH";

            } else {


            }
        }
        else if (this.GaReleaseDate != null && ec.Excludes("gaReleaseDate",true))
        {
            this.GaReleaseDate = null;
        }
        //      C# -> System.Boolean? IsRecommended
        // GraphQL -> isRecommended: Boolean! (scalar)
        if (ec.Includes("isRecommended",true))
        {
            if(this.IsRecommended == null) {

                this.IsRecommended = true;

            } else {


            }
        }
        else if (this.IsRecommended != null && ec.Excludes("isRecommended",true))
        {
            this.IsRecommended = null;
        }
        //      C# -> System.Boolean? IsUpgradable
        // GraphQL -> isUpgradable: Boolean! (scalar)
        if (ec.Includes("isUpgradable",true))
        {
            if(this.IsUpgradable == null) {

                this.IsUpgradable = true;

            } else {


            }
        }
        else if (this.IsUpgradable != null && ec.Excludes("isUpgradable",true))
        {
            this.IsUpgradable = null;
        }
        //      C# -> System.String? Md5Sum
        // GraphQL -> md5Sum: String! (scalar)
        if (ec.Includes("md5Sum",true))
        {
            if(this.Md5Sum == null) {

                this.Md5Sum = "FETCH";

            } else {


            }
        }
        else if (this.Md5Sum != null && ec.Excludes("md5Sum",true))
        {
            this.Md5Sum = null;
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
        //      C# -> System.String? ReleaseDate
        // GraphQL -> releaseDate: String! (scalar)
        if (ec.Includes("releaseDate",true))
        {
            if(this.ReleaseDate == null) {

                this.ReleaseDate = "FETCH";

            } else {


            }
        }
        else if (this.ReleaseDate != null && ec.Excludes("releaseDate",true))
        {
            this.ReleaseDate = null;
        }
        //      C# -> System.String? ReleaseNotesLink
        // GraphQL -> releaseNotesLink: String! (scalar)
        if (ec.Includes("releaseNotesLink",true))
        {
            if(this.ReleaseNotesLink == null) {

                this.ReleaseNotesLink = "FETCH";

            } else {


            }
        }
        else if (this.ReleaseNotesLink != null && ec.Excludes("releaseNotesLink",true))
        {
            this.ReleaseNotesLink = null;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (ec.Includes("size",true))
        {
            if(this.Size == null) {

                this.Size = new System.Int64();

            } else {


            }
        }
        else if (this.Size != null && ec.Excludes("size",true))
        {
            this.Size = null;
        }
        //      C# -> System.String? TarDownloadLink
        // GraphQL -> tarDownloadLink: String! (scalar)
        if (ec.Includes("tarDownloadLink",true))
        {
            if(this.TarDownloadLink == null) {

                this.TarDownloadLink = "FETCH";

            } else {


            }
        }
        else if (this.TarDownloadLink != null && ec.Excludes("tarDownloadLink",true))
        {
            this.TarDownloadLink = null;
        }
    }


    #endregion

    } // class CdmUpgradeReleaseDetail
    
    #endregion

    public static class ListCdmUpgradeReleaseDetailExtensions
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
            this List<CdmUpgradeReleaseDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmUpgradeReleaseDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmUpgradeReleaseDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmUpgradeReleaseDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types