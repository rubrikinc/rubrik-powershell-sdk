// FilesSummaryCountResultType.cs
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
    #region FilesSummaryCountResultType
    public class FilesSummaryCountResultType: BaseType
    {
        #region members

        //      C# -> SensitiveFiles? UnusedSensitiveFiles
        // GraphQL -> unusedSensitiveFiles: SensitiveFiles (type)
        [JsonProperty("unusedSensitiveFiles")]
        public SensitiveFiles? UnusedSensitiveFiles { get; set; }

        //      C# -> SensitiveFiles? UsedSensitiveFiles
        // GraphQL -> usedSensitiveFiles: SensitiveFiles (type)
        [JsonProperty("usedSensitiveFiles")]
        public SensitiveFiles? UsedSensitiveFiles { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilesSummaryCountResultType";
    }

    public FilesSummaryCountResultType Set(
        SensitiveFiles? UnusedSensitiveFiles = null,
        SensitiveFiles? UsedSensitiveFiles = null
    ) 
    {
        if ( UnusedSensitiveFiles != null ) {
            this.UnusedSensitiveFiles = UnusedSensitiveFiles;
        }
        if ( UsedSensitiveFiles != null ) {
            this.UsedSensitiveFiles = UsedSensitiveFiles;
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
        //      C# -> SensitiveFiles? UnusedSensitiveFiles
        // GraphQL -> unusedSensitiveFiles: SensitiveFiles (type)
        if (this.UnusedSensitiveFiles != null) {
            var fspec = this.UnusedSensitiveFiles.AsFieldSpec(conf.Child("unusedSensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "unusedSensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SensitiveFiles? UsedSensitiveFiles
        // GraphQL -> usedSensitiveFiles: SensitiveFiles (type)
        if (this.UsedSensitiveFiles != null) {
            var fspec = this.UsedSensitiveFiles.AsFieldSpec(conf.Child("usedSensitiveFiles"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "usedSensitiveFiles" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SensitiveFiles? UnusedSensitiveFiles
        // GraphQL -> unusedSensitiveFiles: SensitiveFiles (type)
        if (ec.Includes("unusedSensitiveFiles",false))
        {
            if(this.UnusedSensitiveFiles == null) {

                this.UnusedSensitiveFiles = new SensitiveFiles();
                this.UnusedSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("unusedSensitiveFiles"));

            } else {

                this.UnusedSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("unusedSensitiveFiles"));

            }
        }
        else if (this.UnusedSensitiveFiles != null && ec.Excludes("unusedSensitiveFiles",false))
        {
            this.UnusedSensitiveFiles = null;
        }
        //      C# -> SensitiveFiles? UsedSensitiveFiles
        // GraphQL -> usedSensitiveFiles: SensitiveFiles (type)
        if (ec.Includes("usedSensitiveFiles",false))
        {
            if(this.UsedSensitiveFiles == null) {

                this.UsedSensitiveFiles = new SensitiveFiles();
                this.UsedSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("usedSensitiveFiles"));

            } else {

                this.UsedSensitiveFiles.ApplyExploratoryFieldSpec(ec.NewChild("usedSensitiveFiles"));

            }
        }
        else if (this.UsedSensitiveFiles != null && ec.Excludes("usedSensitiveFiles",false))
        {
            this.UsedSensitiveFiles = null;
        }
    }


    #endregion

    } // class FilesSummaryCountResultType
    
    #endregion

    public static class ListFilesSummaryCountResultTypeExtensions
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
            this List<FilesSummaryCountResultType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FilesSummaryCountResultType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilesSummaryCountResultType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesSummaryCountResultType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesSummaryCountResultType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types