// ValidateBlueprintReply.cs
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
    #region ValidateBlueprintReply
    public class ValidateBlueprintReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsValidationSucceeded
        // GraphQL -> isValidationSucceeded: Boolean! (scalar)
        [JsonProperty("isValidationSucceeded")]
        public System.Boolean? IsValidationSucceeded { get; set; }

        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: id (type)
        [JsonProperty("blueprintId")]
        public System.String? BlueprintId { get; set; }

        //      C# -> List<ValidationStatusInfo>? StatusInfos
        // GraphQL -> statusInfos: [ValidationStatusInfo!]! (type)
        [JsonProperty("statusInfos")]
        public List<ValidationStatusInfo>? StatusInfos { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateBlueprintReply";
    }

    public ValidateBlueprintReply Set(
        System.Boolean? IsValidationSucceeded = null,
        System.String? BlueprintId = null,
        List<ValidationStatusInfo>? StatusInfos = null
    ) 
    {
        if ( IsValidationSucceeded != null ) {
            this.IsValidationSucceeded = IsValidationSucceeded;
        }
        if ( BlueprintId != null ) {
            this.BlueprintId = BlueprintId;
        }
        if ( StatusInfos != null ) {
            this.StatusInfos = StatusInfos;
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
        //      C# -> System.Boolean? IsValidationSucceeded
        // GraphQL -> isValidationSucceeded: Boolean! (scalar)
        if (this.IsValidationSucceeded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isValidationSucceeded\n" ;
            } else {
                s += ind + "isValidationSucceeded\n" ;
            }
        }
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: id (type)
        if (this.BlueprintId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "blueprintId\n" ;
            } else {
                s += ind + "blueprintId\n" ;
            }
        }
        //      C# -> List<ValidationStatusInfo>? StatusInfos
        // GraphQL -> statusInfos: [ValidationStatusInfo!]! (type)
        if (this.StatusInfos != null) {
            var fspec = this.StatusInfos.AsFieldSpec(conf.Child("statusInfos"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "statusInfos" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsValidationSucceeded
        // GraphQL -> isValidationSucceeded: Boolean! (scalar)
        if (ec.Includes("isValidationSucceeded",true))
        {
            if(this.IsValidationSucceeded == null) {

                this.IsValidationSucceeded = true;

            } else {


            }
        }
        else if (this.IsValidationSucceeded != null && ec.Excludes("isValidationSucceeded",true))
        {
            this.IsValidationSucceeded = null;
        }
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: id (type)
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
        //      C# -> List<ValidationStatusInfo>? StatusInfos
        // GraphQL -> statusInfos: [ValidationStatusInfo!]! (type)
        if (ec.Includes("statusInfos",false))
        {
            if(this.StatusInfos == null) {

                this.StatusInfos = new List<ValidationStatusInfo>();
                this.StatusInfos.ApplyExploratoryFieldSpec(ec.NewChild("statusInfos"));

            } else {

                this.StatusInfos.ApplyExploratoryFieldSpec(ec.NewChild("statusInfos"));

            }
        }
        else if (this.StatusInfos != null && ec.Excludes("statusInfos",false))
        {
            this.StatusInfos = null;
        }
    }


    #endregion

    } // class ValidateBlueprintReply
    
    #endregion

    public static class ListValidateBlueprintReplyExtensions
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
            this List<ValidateBlueprintReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ValidateBlueprintReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ValidateBlueprintReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateBlueprintReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidateBlueprintReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types