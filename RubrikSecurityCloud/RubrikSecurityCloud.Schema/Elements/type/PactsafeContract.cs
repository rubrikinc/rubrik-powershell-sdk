// PactsafeContract.cs
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
    #region PactsafeContract
    public class PactsafeContract: BaseType
    {
        #region members

        //      C# -> System.String? ContractFile
        // GraphQL -> contractFile: String! (scalar)
        [JsonProperty("contractFile")]
        public System.String? ContractFile { get; set; }

        //      C# -> System.String? ContractId
        // GraphQL -> contractId: String! (scalar)
        [JsonProperty("contractId")]
        public System.String? ContractId { get; set; }

        //      C# -> System.String? DownloadEndpoint
        // GraphQL -> downloadEndpoint: URL! (scalar)
        [JsonProperty("downloadEndpoint")]
        public System.String? DownloadEndpoint { get; set; }

        //      C# -> DateTime? EffectiveDate
        // GraphQL -> effectiveDate: DateTime! (scalar)
        [JsonProperty("effectiveDate")]
        public DateTime? EffectiveDate { get; set; }

        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        [JsonProperty("isAccepted")]
        public System.Boolean? IsAccepted { get; set; }

        //      C# -> System.String? MajorVersionId
        // GraphQL -> majorVersionId: String! (scalar)
        [JsonProperty("majorVersionId")]
        public System.String? MajorVersionId { get; set; }

        //      C# -> System.String? PublishedVersionId
        // GraphQL -> publishedVersionId: String! (scalar)
        [JsonProperty("publishedVersionId")]
        public System.String? PublishedVersionId { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PactsafeContract";
    }

    public PactsafeContract Set(
        System.String? ContractFile = null,
        System.String? ContractId = null,
        System.String? DownloadEndpoint = null,
        DateTime? EffectiveDate = null,
        System.Boolean? IsAccepted = null,
        System.String? MajorVersionId = null,
        System.String? PublishedVersionId = null,
        System.String? Title = null
    ) 
    {
        if ( ContractFile != null ) {
            this.ContractFile = ContractFile;
        }
        if ( ContractId != null ) {
            this.ContractId = ContractId;
        }
        if ( DownloadEndpoint != null ) {
            this.DownloadEndpoint = DownloadEndpoint;
        }
        if ( EffectiveDate != null ) {
            this.EffectiveDate = EffectiveDate;
        }
        if ( IsAccepted != null ) {
            this.IsAccepted = IsAccepted;
        }
        if ( MajorVersionId != null ) {
            this.MajorVersionId = MajorVersionId;
        }
        if ( PublishedVersionId != null ) {
            this.PublishedVersionId = PublishedVersionId;
        }
        if ( Title != null ) {
            this.Title = Title;
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
        //      C# -> System.String? ContractFile
        // GraphQL -> contractFile: String! (scalar)
        if (this.ContractFile != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contractFile\n" ;
            } else {
                s += ind + "contractFile\n" ;
            }
        }
        //      C# -> System.String? ContractId
        // GraphQL -> contractId: String! (scalar)
        if (this.ContractId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "contractId\n" ;
            } else {
                s += ind + "contractId\n" ;
            }
        }
        //      C# -> System.String? DownloadEndpoint
        // GraphQL -> downloadEndpoint: URL! (scalar)
        if (this.DownloadEndpoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "downloadEndpoint\n" ;
            } else {
                s += ind + "downloadEndpoint\n" ;
            }
        }
        //      C# -> DateTime? EffectiveDate
        // GraphQL -> effectiveDate: DateTime! (scalar)
        if (this.EffectiveDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveDate\n" ;
            } else {
                s += ind + "effectiveDate\n" ;
            }
        }
        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        if (this.IsAccepted != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAccepted\n" ;
            } else {
                s += ind + "isAccepted\n" ;
            }
        }
        //      C# -> System.String? MajorVersionId
        // GraphQL -> majorVersionId: String! (scalar)
        if (this.MajorVersionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "majorVersionId\n" ;
            } else {
                s += ind + "majorVersionId\n" ;
            }
        }
        //      C# -> System.String? PublishedVersionId
        // GraphQL -> publishedVersionId: String! (scalar)
        if (this.PublishedVersionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "publishedVersionId\n" ;
            } else {
                s += ind + "publishedVersionId\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ContractFile
        // GraphQL -> contractFile: String! (scalar)
        if (ec.Includes("contractFile",true))
        {
            if(this.ContractFile == null) {

                this.ContractFile = "FETCH";

            } else {


            }
        }
        else if (this.ContractFile != null && ec.Excludes("contractFile",true))
        {
            this.ContractFile = null;
        }
        //      C# -> System.String? ContractId
        // GraphQL -> contractId: String! (scalar)
        if (ec.Includes("contractId",true))
        {
            if(this.ContractId == null) {

                this.ContractId = "FETCH";

            } else {


            }
        }
        else if (this.ContractId != null && ec.Excludes("contractId",true))
        {
            this.ContractId = null;
        }
        //      C# -> System.String? DownloadEndpoint
        // GraphQL -> downloadEndpoint: URL! (scalar)
        if (ec.Includes("downloadEndpoint",true))
        {
            if(this.DownloadEndpoint == null) {

                this.DownloadEndpoint = "FETCH";

            } else {


            }
        }
        else if (this.DownloadEndpoint != null && ec.Excludes("downloadEndpoint",true))
        {
            this.DownloadEndpoint = null;
        }
        //      C# -> DateTime? EffectiveDate
        // GraphQL -> effectiveDate: DateTime! (scalar)
        if (ec.Includes("effectiveDate",true))
        {
            if(this.EffectiveDate == null) {

                this.EffectiveDate = new DateTime();

            } else {


            }
        }
        else if (this.EffectiveDate != null && ec.Excludes("effectiveDate",true))
        {
            this.EffectiveDate = null;
        }
        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        if (ec.Includes("isAccepted",true))
        {
            if(this.IsAccepted == null) {

                this.IsAccepted = true;

            } else {


            }
        }
        else if (this.IsAccepted != null && ec.Excludes("isAccepted",true))
        {
            this.IsAccepted = null;
        }
        //      C# -> System.String? MajorVersionId
        // GraphQL -> majorVersionId: String! (scalar)
        if (ec.Includes("majorVersionId",true))
        {
            if(this.MajorVersionId == null) {

                this.MajorVersionId = "FETCH";

            } else {


            }
        }
        else if (this.MajorVersionId != null && ec.Excludes("majorVersionId",true))
        {
            this.MajorVersionId = null;
        }
        //      C# -> System.String? PublishedVersionId
        // GraphQL -> publishedVersionId: String! (scalar)
        if (ec.Includes("publishedVersionId",true))
        {
            if(this.PublishedVersionId == null) {

                this.PublishedVersionId = "FETCH";

            } else {


            }
        }
        else if (this.PublishedVersionId != null && ec.Excludes("publishedVersionId",true))
        {
            this.PublishedVersionId = null;
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
    }


    #endregion

    } // class PactsafeContract
    
    #endregion

    public static class ListPactsafeContractExtensions
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
            this List<PactsafeContract> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PactsafeContract> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PactsafeContract> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PactsafeContract());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PactsafeContract> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types