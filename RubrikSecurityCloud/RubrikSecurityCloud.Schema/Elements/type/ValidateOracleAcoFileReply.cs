// ValidateOracleAcoFileReply.cs
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
    #region ValidateOracleAcoFileReply
    public class ValidateOracleAcoFileReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? AcoParameterErrors
        // GraphQL -> acoParameterErrors: [String!]! (scalar)
        [JsonProperty("acoParameterErrors")]
        public List<System.String>? AcoParameterErrors { get; set; }

        //      C# -> List<OracleAcoParameterDetail>? AcoMap
        // GraphQL -> acoMap: [OracleAcoParameterDetail!]! (type)
        [JsonProperty("acoMap")]
        public List<OracleAcoParameterDetail>? AcoMap { get; set; }

        //      C# -> List<OracleAcoValueErrorDetail>? AcoValueValidationErrors
        // GraphQL -> acoValueValidationErrors: [OracleAcoValueErrorDetail!]! (type)
        [JsonProperty("acoValueValidationErrors")]
        public List<OracleAcoValueErrorDetail>? AcoValueValidationErrors { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateOracleAcoFileReply";
    }

    public ValidateOracleAcoFileReply Set(
        List<System.String>? AcoParameterErrors = null,
        List<OracleAcoParameterDetail>? AcoMap = null,
        List<OracleAcoValueErrorDetail>? AcoValueValidationErrors = null
    ) 
    {
        if ( AcoParameterErrors != null ) {
            this.AcoParameterErrors = AcoParameterErrors;
        }
        if ( AcoMap != null ) {
            this.AcoMap = AcoMap;
        }
        if ( AcoValueValidationErrors != null ) {
            this.AcoValueValidationErrors = AcoValueValidationErrors;
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
        //      C# -> List<System.String>? AcoParameterErrors
        // GraphQL -> acoParameterErrors: [String!]! (scalar)
        if (this.AcoParameterErrors != null) {
            if (conf.Flat) {
                s += conf.Prefix + "acoParameterErrors\n" ;
            } else {
                s += ind + "acoParameterErrors\n" ;
            }
        }
        //      C# -> List<OracleAcoParameterDetail>? AcoMap
        // GraphQL -> acoMap: [OracleAcoParameterDetail!]! (type)
        if (this.AcoMap != null) {
            var fspec = this.AcoMap.AsFieldSpec(conf.Child("acoMap"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "acoMap {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<OracleAcoValueErrorDetail>? AcoValueValidationErrors
        // GraphQL -> acoValueValidationErrors: [OracleAcoValueErrorDetail!]! (type)
        if (this.AcoValueValidationErrors != null) {
            var fspec = this.AcoValueValidationErrors.AsFieldSpec(conf.Child("acoValueValidationErrors"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "acoValueValidationErrors {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? AcoParameterErrors
        // GraphQL -> acoParameterErrors: [String!]! (scalar)
        if (ec.Includes("acoParameterErrors",true))
        {
            if(this.AcoParameterErrors == null) {

                this.AcoParameterErrors = new List<System.String>();

            } else {


            }
        }
        else if (this.AcoParameterErrors != null && ec.Excludes("acoParameterErrors",true))
        {
            this.AcoParameterErrors = null;
        }
        //      C# -> List<OracleAcoParameterDetail>? AcoMap
        // GraphQL -> acoMap: [OracleAcoParameterDetail!]! (type)
        if (ec.Includes("acoMap",false))
        {
            if(this.AcoMap == null) {

                this.AcoMap = new List<OracleAcoParameterDetail>();
                this.AcoMap.ApplyExploratoryFieldSpec(ec.NewChild("acoMap"));

            } else {

                this.AcoMap.ApplyExploratoryFieldSpec(ec.NewChild("acoMap"));

            }
        }
        else if (this.AcoMap != null && ec.Excludes("acoMap",false))
        {
            this.AcoMap = null;
        }
        //      C# -> List<OracleAcoValueErrorDetail>? AcoValueValidationErrors
        // GraphQL -> acoValueValidationErrors: [OracleAcoValueErrorDetail!]! (type)
        if (ec.Includes("acoValueValidationErrors",false))
        {
            if(this.AcoValueValidationErrors == null) {

                this.AcoValueValidationErrors = new List<OracleAcoValueErrorDetail>();
                this.AcoValueValidationErrors.ApplyExploratoryFieldSpec(ec.NewChild("acoValueValidationErrors"));

            } else {

                this.AcoValueValidationErrors.ApplyExploratoryFieldSpec(ec.NewChild("acoValueValidationErrors"));

            }
        }
        else if (this.AcoValueValidationErrors != null && ec.Excludes("acoValueValidationErrors",false))
        {
            this.AcoValueValidationErrors = null;
        }
    }


    #endregion

    } // class ValidateOracleAcoFileReply
    
    #endregion

    public static class ListValidateOracleAcoFileReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ValidateOracleAcoFileReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ValidateOracleAcoFileReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ValidateOracleAcoFileReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateOracleAcoFileReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidateOracleAcoFileReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types