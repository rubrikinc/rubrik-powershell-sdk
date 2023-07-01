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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> AdoptionStatus? AdoptionStatus
        // GraphQL -> adoptionStatus: AdoptionStatus! (enum)
        if (this.AdoptionStatus != null) {
            s += ind + "adoptionStatus\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? GaReleaseDate
        // GraphQL -> gaReleaseDate: String! (scalar)
        if (this.GaReleaseDate != null) {
            s += ind + "gaReleaseDate\n" ;
        }
        //      C# -> System.Boolean? IsRecommended
        // GraphQL -> isRecommended: Boolean! (scalar)
        if (this.IsRecommended != null) {
            s += ind + "isRecommended\n" ;
        }
        //      C# -> System.Boolean? IsUpgradable
        // GraphQL -> isUpgradable: Boolean! (scalar)
        if (this.IsUpgradable != null) {
            s += ind + "isUpgradable\n" ;
        }
        //      C# -> System.String? Md5Sum
        // GraphQL -> md5Sum: String! (scalar)
        if (this.Md5Sum != null) {
            s += ind + "md5Sum\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? ReleaseDate
        // GraphQL -> releaseDate: String! (scalar)
        if (this.ReleaseDate != null) {
            s += ind + "releaseDate\n" ;
        }
        //      C# -> System.String? ReleaseNotesLink
        // GraphQL -> releaseNotesLink: String! (scalar)
        if (this.ReleaseNotesLink != null) {
            s += ind + "releaseNotesLink\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> System.String? TarDownloadLink
        // GraphQL -> tarDownloadLink: String! (scalar)
        if (this.TarDownloadLink != null) {
            s += ind + "tarDownloadLink\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AdoptionStatus? AdoptionStatus
        // GraphQL -> adoptionStatus: AdoptionStatus! (enum)
        if (this.AdoptionStatus == null && Exploration.Includes(parent + ".adoptionStatus", true))
        {
            this.AdoptionStatus = new AdoptionStatus();
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? GaReleaseDate
        // GraphQL -> gaReleaseDate: String! (scalar)
        if (this.GaReleaseDate == null && Exploration.Includes(parent + ".gaReleaseDate", true))
        {
            this.GaReleaseDate = "FETCH";
        }
        //      C# -> System.Boolean? IsRecommended
        // GraphQL -> isRecommended: Boolean! (scalar)
        if (this.IsRecommended == null && Exploration.Includes(parent + ".isRecommended", true))
        {
            this.IsRecommended = true;
        }
        //      C# -> System.Boolean? IsUpgradable
        // GraphQL -> isUpgradable: Boolean! (scalar)
        if (this.IsUpgradable == null && Exploration.Includes(parent + ".isUpgradable", true))
        {
            this.IsUpgradable = true;
        }
        //      C# -> System.String? Md5Sum
        // GraphQL -> md5Sum: String! (scalar)
        if (this.Md5Sum == null && Exploration.Includes(parent + ".md5Sum", true))
        {
            this.Md5Sum = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? ReleaseDate
        // GraphQL -> releaseDate: String! (scalar)
        if (this.ReleaseDate == null && Exploration.Includes(parent + ".releaseDate", true))
        {
            this.ReleaseDate = "FETCH";
        }
        //      C# -> System.String? ReleaseNotesLink
        // GraphQL -> releaseNotesLink: String! (scalar)
        if (this.ReleaseNotesLink == null && Exploration.Includes(parent + ".releaseNotesLink", true))
        {
            this.ReleaseNotesLink = "FETCH";
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        if (this.Size == null && Exploration.Includes(parent + ".size", true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? TarDownloadLink
        // GraphQL -> tarDownloadLink: String! (scalar)
        if (this.TarDownloadLink == null && Exploration.Includes(parent + ".tarDownloadLink", true))
        {
            this.TarDownloadLink = "FETCH";
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
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmUpgradeReleaseDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmUpgradeReleaseDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types