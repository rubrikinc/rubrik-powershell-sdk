// SourceBlueprintInfo.cs
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
    #region SourceBlueprintInfo
    public class SourceBlueprintInfo: BaseType
    {
        #region members

        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String! (scalar)
        [JsonProperty("blueprintId")]
        public System.String? BlueprintId { get; set; }

        //      C# -> List<SourceChildInfo>? SourceChildInfos
        // GraphQL -> sourceChildInfos: [SourceChildInfo!]! (type)
        [JsonProperty("sourceChildInfos")]
        public List<SourceChildInfo>? SourceChildInfos { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SourceBlueprintInfo";
    }

    public SourceBlueprintInfo Set(
        System.String? BlueprintId = null,
        List<SourceChildInfo>? SourceChildInfos = null
    ) 
    {
        if ( BlueprintId != null ) {
            this.BlueprintId = BlueprintId;
        }
        if ( SourceChildInfos != null ) {
            this.SourceChildInfos = SourceChildInfos;
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
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String! (scalar)
        if (this.BlueprintId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "blueprintId\n" ;
            } else {
                s += ind + "blueprintId\n" ;
            }
        }
        //      C# -> List<SourceChildInfo>? SourceChildInfos
        // GraphQL -> sourceChildInfos: [SourceChildInfo!]! (type)
        if (this.SourceChildInfos != null) {
            var fspec = this.SourceChildInfos.AsFieldSpec(conf.Child("sourceChildInfos"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceChildInfos" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String! (scalar)
        if (ec.Includes("blueprintId",true))
        {
            if(this.BlueprintId == null) {

                this.BlueprintId = "FETCH";

            } else {


            }
        }
        else if (this.BlueprintId != null && ec.Excludes("blueprintId",true))
        {
            this.BlueprintId = null;
        }
        //      C# -> List<SourceChildInfo>? SourceChildInfos
        // GraphQL -> sourceChildInfos: [SourceChildInfo!]! (type)
        if (ec.Includes("sourceChildInfos",false))
        {
            if(this.SourceChildInfos == null) {

                this.SourceChildInfos = new List<SourceChildInfo>();
                this.SourceChildInfos.ApplyExploratoryFieldSpec(ec.NewChild("sourceChildInfos"));

            } else {

                this.SourceChildInfos.ApplyExploratoryFieldSpec(ec.NewChild("sourceChildInfos"));

            }
        }
        else if (this.SourceChildInfos != null && ec.Excludes("sourceChildInfos",false))
        {
            this.SourceChildInfos = null;
        }
    }


    #endregion

    } // class SourceBlueprintInfo
    
    #endregion

    public static class ListSourceBlueprintInfoExtensions
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
            this List<SourceBlueprintInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SourceBlueprintInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SourceBlueprintInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SourceBlueprintInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SourceBlueprintInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types