// FilesetTemplateDetail.cs
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
    #region FilesetTemplateDetail
    public class FilesetTemplateDetail: BaseType
    {
        #region members

        //      C# -> System.Int32? HostCount
        // GraphQL -> hostCount: Int (scalar)
        [JsonProperty("hostCount")]
        public System.Int32? HostCount { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        [JsonProperty("isCreatedByKupr")]
        public System.Boolean? IsCreatedByKupr { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }

        //      C# -> System.Int32? ShareCount
        // GraphQL -> shareCount: Int (scalar)
        [JsonProperty("shareCount")]
        public System.Int32? ShareCount { get; set; }

        //      C# -> FilesetTemplateCreate? FilesetTemplateCreate
        // GraphQL -> filesetTemplateCreate: FilesetTemplateCreate (type)
        [JsonProperty("filesetTemplateCreate")]
        public FilesetTemplateCreate? FilesetTemplateCreate { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilesetTemplateDetail";
    }

    public FilesetTemplateDetail Set(
        System.Int32? HostCount = null,
        System.String? Id = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsCreatedByKupr = null,
        System.String? PrimaryClusterId = null,
        System.Int32? ShareCount = null,
        FilesetTemplateCreate? FilesetTemplateCreate = null
    ) 
    {
        if ( HostCount != null ) {
            this.HostCount = HostCount;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsCreatedByKupr != null ) {
            this.IsCreatedByKupr = IsCreatedByKupr;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        if ( ShareCount != null ) {
            this.ShareCount = ShareCount;
        }
        if ( FilesetTemplateCreate != null ) {
            this.FilesetTemplateCreate = FilesetTemplateCreate;
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
        //      C# -> System.Int32? HostCount
        // GraphQL -> hostCount: Int (scalar)
        if (this.HostCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostCount\n" ;
            } else {
                s += ind + "hostCount\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        if (this.IsCreatedByKupr != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCreatedByKupr\n" ;
            } else {
                s += ind + "isCreatedByKupr\n" ;
            }
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterId\n" ;
            } else {
                s += ind + "primaryClusterId\n" ;
            }
        }
        //      C# -> System.Int32? ShareCount
        // GraphQL -> shareCount: Int (scalar)
        if (this.ShareCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shareCount\n" ;
            } else {
                s += ind + "shareCount\n" ;
            }
        }
        //      C# -> FilesetTemplateCreate? FilesetTemplateCreate
        // GraphQL -> filesetTemplateCreate: FilesetTemplateCreate (type)
        if (this.FilesetTemplateCreate != null) {
            var fspec = this.FilesetTemplateCreate.AsFieldSpec(conf.Child("filesetTemplateCreate"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filesetTemplateCreate" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? HostCount
        // GraphQL -> hostCount: Int (scalar)
        if (ec.Includes("hostCount",true))
        {
            if(this.HostCount == null) {

                this.HostCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.HostCount != null && ec.Excludes("hostCount",true))
        {
            this.HostCount = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.Boolean? IsCreatedByKupr
        // GraphQL -> isCreatedByKupr: Boolean (scalar)
        if (ec.Includes("isCreatedByKupr",true))
        {
            if(this.IsCreatedByKupr == null) {

                this.IsCreatedByKupr = true;

            } else {


            }
        }
        else if (this.IsCreatedByKupr != null && ec.Excludes("isCreatedByKupr",true))
        {
            this.IsCreatedByKupr = null;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (ec.Includes("primaryClusterId",true))
        {
            if(this.PrimaryClusterId == null) {

                this.PrimaryClusterId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterId != null && ec.Excludes("primaryClusterId",true))
        {
            this.PrimaryClusterId = null;
        }
        //      C# -> System.Int32? ShareCount
        // GraphQL -> shareCount: Int (scalar)
        if (ec.Includes("shareCount",true))
        {
            if(this.ShareCount == null) {

                this.ShareCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ShareCount != null && ec.Excludes("shareCount",true))
        {
            this.ShareCount = null;
        }
        //      C# -> FilesetTemplateCreate? FilesetTemplateCreate
        // GraphQL -> filesetTemplateCreate: FilesetTemplateCreate (type)
        if (ec.Includes("filesetTemplateCreate",false))
        {
            if(this.FilesetTemplateCreate == null) {

                this.FilesetTemplateCreate = new FilesetTemplateCreate();
                this.FilesetTemplateCreate.ApplyExploratoryFieldSpec(ec.NewChild("filesetTemplateCreate"));

            } else {

                this.FilesetTemplateCreate.ApplyExploratoryFieldSpec(ec.NewChild("filesetTemplateCreate"));

            }
        }
        else if (this.FilesetTemplateCreate != null && ec.Excludes("filesetTemplateCreate",false))
        {
            this.FilesetTemplateCreate = null;
        }
    }


    #endregion

    } // class FilesetTemplateDetail
    
    #endregion

    public static class ListFilesetTemplateDetailExtensions
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
            this List<FilesetTemplateDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FilesetTemplateDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilesetTemplateDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetTemplateDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesetTemplateDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types