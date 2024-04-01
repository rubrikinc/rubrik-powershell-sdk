// DownloadPackageStatusReply.cs
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
    #region DownloadPackageStatusReply
    public class DownloadPackageStatusReply: BaseType
    {
        #region members

        //      C# -> System.String? Availability
        // GraphQL -> availability: String! (scalar)
        [JsonProperty("availability")]
        public System.String? Availability { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Md5Sum
        // GraphQL -> md5Sum: String! (scalar)
        [JsonProperty("md5Sum")]
        public System.String? Md5Sum { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> DownloadJobInfo? DownloadJobInfo
        // GraphQL -> downloadJobInfo: DownloadJobInfo (type)
        [JsonProperty("downloadJobInfo")]
        public DownloadJobInfo? DownloadJobInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DownloadPackageStatusReply";
    }

    public DownloadPackageStatusReply Set(
        System.String? Availability = null,
        System.String? Description = null,
        System.String? Md5Sum = null,
        System.Int64? Size = null,
        System.String? Version = null,
        DownloadJobInfo? DownloadJobInfo = null
    ) 
    {
        if ( Availability != null ) {
            this.Availability = Availability;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Md5Sum != null ) {
            this.Md5Sum = Md5Sum;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( DownloadJobInfo != null ) {
            this.DownloadJobInfo = DownloadJobInfo;
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
        //      C# -> System.String? Availability
        // GraphQL -> availability: String! (scalar)
        if (this.Availability != null) {
            if (conf.Flat) {
                s += conf.Prefix + "availability\n" ;
            } else {
                s += ind + "availability\n" ;
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
        //      C# -> System.String? Md5Sum
        // GraphQL -> md5Sum: String! (scalar)
        if (this.Md5Sum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "md5Sum\n" ;
            } else {
                s += ind + "md5Sum\n" ;
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
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> DownloadJobInfo? DownloadJobInfo
        // GraphQL -> downloadJobInfo: DownloadJobInfo (type)
        if (this.DownloadJobInfo != null) {
            var fspec = this.DownloadJobInfo.AsFieldSpec(conf.Child("downloadJobInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "downloadJobInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Availability
        // GraphQL -> availability: String! (scalar)
        if (ec.Includes("availability",true))
        {
            if(this.Availability == null) {

                this.Availability = "FETCH";

            } else {


            }
        }
        else if (this.Availability != null && ec.Excludes("availability",true))
        {
            this.Availability = null;
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
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> DownloadJobInfo? DownloadJobInfo
        // GraphQL -> downloadJobInfo: DownloadJobInfo (type)
        if (ec.Includes("downloadJobInfo",false))
        {
            if(this.DownloadJobInfo == null) {

                this.DownloadJobInfo = new DownloadJobInfo();
                this.DownloadJobInfo.ApplyExploratoryFieldSpec(ec.NewChild("downloadJobInfo"));

            } else {

                this.DownloadJobInfo.ApplyExploratoryFieldSpec(ec.NewChild("downloadJobInfo"));

            }
        }
        else if (this.DownloadJobInfo != null && ec.Excludes("downloadJobInfo",false))
        {
            this.DownloadJobInfo = null;
        }
    }


    #endregion

    } // class DownloadPackageStatusReply
    
    #endregion

    public static class ListDownloadPackageStatusReplyExtensions
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
            this List<DownloadPackageStatusReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DownloadPackageStatusReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DownloadPackageStatusReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DownloadPackageStatusReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DownloadPackageStatusReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types