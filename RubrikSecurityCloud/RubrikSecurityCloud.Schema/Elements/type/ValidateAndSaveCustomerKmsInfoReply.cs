// ValidateAndSaveCustomerKmsInfoReply.cs
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
    #region ValidateAndSaveCustomerKmsInfoReply
    public class ValidateAndSaveCustomerKmsInfoReply: BaseType
    {
        #region members

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.String? InputFieldName
        // GraphQL -> inputFieldName: String! (scalar)
        [JsonProperty("inputFieldName")]
        public System.String? InputFieldName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ValidateAndSaveCustomerKmsInfoReply";
    }

    public ValidateAndSaveCustomerKmsInfoReply Set(
        System.String? ErrorMessage = null,
        System.String? InputFieldName = null
    ) 
    {
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( InputFieldName != null ) {
            this.InputFieldName = InputFieldName;
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
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMessage\n" ;
            } else {
                s += ind + "errorMessage\n" ;
            }
        }
        //      C# -> System.String? InputFieldName
        // GraphQL -> inputFieldName: String! (scalar)
        if (this.InputFieldName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inputFieldName\n" ;
            } else {
                s += ind + "inputFieldName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (ec.Includes("errorMessage",true))
        {
            if(this.ErrorMessage == null) {

                this.ErrorMessage = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMessage != null && ec.Excludes("errorMessage",true))
        {
            this.ErrorMessage = null;
        }
        //      C# -> System.String? InputFieldName
        // GraphQL -> inputFieldName: String! (scalar)
        if (ec.Includes("inputFieldName",true))
        {
            if(this.InputFieldName == null) {

                this.InputFieldName = "FETCH";

            } else {


            }
        }
        else if (this.InputFieldName != null && ec.Excludes("inputFieldName",true))
        {
            this.InputFieldName = null;
        }
    }


    #endregion

    } // class ValidateAndSaveCustomerKmsInfoReply
    
    #endregion

    public static class ListValidateAndSaveCustomerKmsInfoReplyExtensions
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
            this List<ValidateAndSaveCustomerKmsInfoReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValidateAndSaveCustomerKmsInfoReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateAndSaveCustomerKmsInfoReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ValidateAndSaveCustomerKmsInfoReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types