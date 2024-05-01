// ValidateAwsNativeRdsInstanceNameForExportReply.cs
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
    #region ValidateAwsNativeRdsInstanceNameForExportReply
    public class ValidateAwsNativeRdsInstanceNameForExportReply: BaseType
    {
        #region members

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean! (scalar)
        [JsonProperty("isValid")]
        public System.Boolean? IsValid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateAwsNativeRdsInstanceNameForExportReply";
    }

    public ValidateAwsNativeRdsInstanceNameForExportReply Set(
        System.String? Error = null,
        System.Boolean? IsValid = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( IsValid != null ) {
            this.IsValid = IsValid;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean! (scalar)
        if (this.IsValid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isValid\n" ;
            } else {
                s += ind + "isValid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = "FETCH";

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
        //      C# -> System.Boolean? IsValid
        // GraphQL -> isValid: Boolean! (scalar)
        if (ec.Includes("isValid",true))
        {
            if(this.IsValid == null) {

                this.IsValid = true;

            } else {


            }
        }
        else if (this.IsValid != null && ec.Excludes("isValid",true))
        {
            this.IsValid = null;
        }
    }


    #endregion

    } // class ValidateAwsNativeRdsInstanceNameForExportReply
    
    #endregion

    public static class ListValidateAwsNativeRdsInstanceNameForExportReplyExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<ValidateAwsNativeRdsInstanceNameForExportReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ValidateAwsNativeRdsInstanceNameForExportReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ValidateAwsNativeRdsInstanceNameForExportReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateAwsNativeRdsInstanceNameForExportReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidateAwsNativeRdsInstanceNameForExportReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types