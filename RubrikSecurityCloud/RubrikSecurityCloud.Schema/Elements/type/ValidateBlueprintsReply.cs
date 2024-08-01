// ValidateBlueprintsReply.cs
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
    #region ValidateBlueprintsReply
    public class ValidateBlueprintsReply: BaseType
    {
        #region members

        //      C# -> List<ValidateBlueprintReply>? BlueprintStatus
        // GraphQL -> blueprintStatus: [ValidateBlueprintReply!]! (type)
        [JsonProperty("blueprintStatus")]
        public List<ValidateBlueprintReply>? BlueprintStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateBlueprintsReply";
    }

    public ValidateBlueprintsReply Set(
        List<ValidateBlueprintReply>? BlueprintStatus = null
    ) 
    {
        if ( BlueprintStatus != null ) {
            this.BlueprintStatus = BlueprintStatus;
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
        //      C# -> List<ValidateBlueprintReply>? BlueprintStatus
        // GraphQL -> blueprintStatus: [ValidateBlueprintReply!]! (type)
        if (this.BlueprintStatus != null) {
            var fspec = this.BlueprintStatus.AsFieldSpec(conf.Child("blueprintStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "blueprintStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ValidateBlueprintReply>? BlueprintStatus
        // GraphQL -> blueprintStatus: [ValidateBlueprintReply!]! (type)
        if (ec.Includes("blueprintStatus",false))
        {
            if(this.BlueprintStatus == null) {

                this.BlueprintStatus = new List<ValidateBlueprintReply>();
                this.BlueprintStatus.ApplyExploratoryFieldSpec(ec.NewChild("blueprintStatus"));

            } else {

                this.BlueprintStatus.ApplyExploratoryFieldSpec(ec.NewChild("blueprintStatus"));

            }
        }
        else if (this.BlueprintStatus != null && ec.Excludes("blueprintStatus",false))
        {
            this.BlueprintStatus = null;
        }
    }


    #endregion

    } // class ValidateBlueprintsReply
    
    #endregion

    public static class ListValidateBlueprintsReplyExtensions
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
            this List<ValidateBlueprintsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ValidateBlueprintsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ValidateBlueprintsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateBlueprintsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidateBlueprintsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types