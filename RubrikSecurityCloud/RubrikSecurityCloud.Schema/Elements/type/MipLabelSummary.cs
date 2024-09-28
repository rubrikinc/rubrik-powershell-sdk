// MipLabelSummary.cs
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
    #region MipLabelSummary
    public class MipLabelSummary: BaseType
    {
        #region members

        //      C# -> SummaryCount? FilesCount
        // GraphQL -> filesCount: SummaryCount (type)
        [JsonProperty("filesCount")]
        public SummaryCount? FilesCount { get; set; }

        //      C# -> MipLabel? MipLabel
        // GraphQL -> mipLabel: MipLabel (type)
        [JsonProperty("mipLabel")]
        public MipLabel? MipLabel { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MipLabelSummary";
    }

    public MipLabelSummary Set(
        SummaryCount? FilesCount = null,
        MipLabel? MipLabel = null
    ) 
    {
        if ( FilesCount != null ) {
            this.FilesCount = FilesCount;
        }
        if ( MipLabel != null ) {
            this.MipLabel = MipLabel;
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
        //      C# -> SummaryCount? FilesCount
        // GraphQL -> filesCount: SummaryCount (type)
        if (this.FilesCount != null) {
            var fspec = this.FilesCount.AsFieldSpec(conf.Child("filesCount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filesCount" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MipLabel? MipLabel
        // GraphQL -> mipLabel: MipLabel (type)
        if (this.MipLabel != null) {
            var fspec = this.MipLabel.AsFieldSpec(conf.Child("mipLabel"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mipLabel" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SummaryCount? FilesCount
        // GraphQL -> filesCount: SummaryCount (type)
        if (ec.Includes("filesCount",false))
        {
            if(this.FilesCount == null) {

                this.FilesCount = new SummaryCount();
                this.FilesCount.ApplyExploratoryFieldSpec(ec.NewChild("filesCount"));

            } else {

                this.FilesCount.ApplyExploratoryFieldSpec(ec.NewChild("filesCount"));

            }
        }
        else if (this.FilesCount != null && ec.Excludes("filesCount",false))
        {
            this.FilesCount = null;
        }
        //      C# -> MipLabel? MipLabel
        // GraphQL -> mipLabel: MipLabel (type)
        if (ec.Includes("mipLabel",false))
        {
            if(this.MipLabel == null) {

                this.MipLabel = new MipLabel();
                this.MipLabel.ApplyExploratoryFieldSpec(ec.NewChild("mipLabel"));

            } else {

                this.MipLabel.ApplyExploratoryFieldSpec(ec.NewChild("mipLabel"));

            }
        }
        else if (this.MipLabel != null && ec.Excludes("mipLabel",false))
        {
            this.MipLabel = null;
        }
    }


    #endregion

    } // class MipLabelSummary
    
    #endregion

    public static class ListMipLabelSummaryExtensions
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
            this List<MipLabelSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MipLabelSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MipLabelSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MipLabelSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MipLabelSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types