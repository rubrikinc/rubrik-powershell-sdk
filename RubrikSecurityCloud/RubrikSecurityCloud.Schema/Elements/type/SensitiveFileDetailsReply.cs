// SensitiveFileDetailsReply.cs
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
    #region SensitiveFileDetailsReply
    public class SensitiveFileDetailsReply: BaseType
    {
        #region members

        //      C# -> List<ExposureSummary>? ExposureSummary
        // GraphQL -> exposureSummary: [ExposureSummary!]! (type)
        [JsonProperty("exposureSummary")]
        public List<ExposureSummary>? ExposureSummary { get; set; }

        //      C# -> SensitiveFileMetadata? FileMetadata
        // GraphQL -> fileMetadata: SensitiveFileMetadata! (type)
        [JsonProperty("fileMetadata")]
        public SensitiveFileMetadata? FileMetadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SensitiveFileDetailsReply";
    }

    public SensitiveFileDetailsReply Set(
        List<ExposureSummary>? ExposureSummary = null,
        SensitiveFileMetadata? FileMetadata = null
    ) 
    {
        if ( ExposureSummary != null ) {
            this.ExposureSummary = ExposureSummary;
        }
        if ( FileMetadata != null ) {
            this.FileMetadata = FileMetadata;
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
        //      C# -> List<ExposureSummary>? ExposureSummary
        // GraphQL -> exposureSummary: [ExposureSummary!]! (type)
        if (this.ExposureSummary != null) {
            var fspec = this.ExposureSummary.AsFieldSpec(conf.Child("exposureSummary"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exposureSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveFileMetadata? FileMetadata
        // GraphQL -> fileMetadata: SensitiveFileMetadata! (type)
        if (this.FileMetadata != null) {
            var fspec = this.FileMetadata.AsFieldSpec(conf.Child("fileMetadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "fileMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<ExposureSummary>? ExposureSummary
        // GraphQL -> exposureSummary: [ExposureSummary!]! (type)
        if (ec.Includes("exposureSummary",false))
        {
            if(this.ExposureSummary == null) {

                this.ExposureSummary = new List<ExposureSummary>();
                this.ExposureSummary.ApplyExploratoryFieldSpec(ec.NewChild("exposureSummary"));

            } else {

                this.ExposureSummary.ApplyExploratoryFieldSpec(ec.NewChild("exposureSummary"));

            }
        }
        else if (this.ExposureSummary != null && ec.Excludes("exposureSummary",false))
        {
            this.ExposureSummary = null;
        }
        //      C# -> SensitiveFileMetadata? FileMetadata
        // GraphQL -> fileMetadata: SensitiveFileMetadata! (type)
        if (ec.Includes("fileMetadata",false))
        {
            if(this.FileMetadata == null) {

                this.FileMetadata = new SensitiveFileMetadata();
                this.FileMetadata.ApplyExploratoryFieldSpec(ec.NewChild("fileMetadata"));

            } else {

                this.FileMetadata.ApplyExploratoryFieldSpec(ec.NewChild("fileMetadata"));

            }
        }
        else if (this.FileMetadata != null && ec.Excludes("fileMetadata",false))
        {
            this.FileMetadata = null;
        }
    }


    #endregion

    } // class SensitiveFileDetailsReply
    
    #endregion

    public static class ListSensitiveFileDetailsReplyExtensions
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
            this List<SensitiveFileDetailsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SensitiveFileDetailsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SensitiveFileDetailsReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SensitiveFileDetailsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SensitiveFileDetailsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types