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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? AcoParameterErrors
        // GraphQL -> acoParameterErrors: [String!]! (scalar)
        if (this.AcoParameterErrors != null) {
            s += ind + "acoParameterErrors\n" ;
        }
        //      C# -> List<OracleAcoParameterDetail>? AcoMap
        // GraphQL -> acoMap: [OracleAcoParameterDetail!]! (type)
        if (this.AcoMap != null) {
            s += ind + "acoMap {\n" + this.AcoMap.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<OracleAcoValueErrorDetail>? AcoValueValidationErrors
        // GraphQL -> acoValueValidationErrors: [OracleAcoValueErrorDetail!]! (type)
        if (this.AcoValueValidationErrors != null) {
            s += ind + "acoValueValidationErrors {\n" + this.AcoValueValidationErrors.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? AcoParameterErrors
        // GraphQL -> acoParameterErrors: [String!]! (scalar)
        if (this.AcoParameterErrors == null && Exploration.Includes(parent + ".acoParameterErrors", true))
        {
            this.AcoParameterErrors = new List<System.String>();
        }
        //      C# -> List<OracleAcoParameterDetail>? AcoMap
        // GraphQL -> acoMap: [OracleAcoParameterDetail!]! (type)
        if (this.AcoMap == null && Exploration.Includes(parent + ".acoMap"))
        {
            this.AcoMap = new List<OracleAcoParameterDetail>();
            this.AcoMap.ApplyExploratoryFieldSpec(parent + ".acoMap");
        }
        //      C# -> List<OracleAcoValueErrorDetail>? AcoValueValidationErrors
        // GraphQL -> acoValueValidationErrors: [OracleAcoValueErrorDetail!]! (type)
        if (this.AcoValueValidationErrors == null && Exploration.Includes(parent + ".acoValueValidationErrors"))
        {
            this.AcoValueValidationErrors = new List<OracleAcoValueErrorDetail>();
            this.AcoValueValidationErrors.ApplyExploratoryFieldSpec(parent + ".acoValueValidationErrors");
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
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ValidateOracleAcoFileReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ValidateOracleAcoFileReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types