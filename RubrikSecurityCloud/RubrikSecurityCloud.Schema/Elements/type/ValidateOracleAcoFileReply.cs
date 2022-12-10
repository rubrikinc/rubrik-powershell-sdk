// ValidateOracleAcoFileReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:34.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region ValidateOracleAcoFileReply
    public class ValidateOracleAcoFileReply: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> List<System.String>? AcoParameterErrors
            // GraphQL -> acoParameterErrors: [String!]! (scalar)
            if (this.AcoParameterErrors != null)
            {
                 s += ind + "acoParameterErrors\n";

            }
            //      C# -> List<OracleAcoParameterDetail>? AcoMap
            // GraphQL -> acoMap: [OracleAcoParameterDetail!]! (type)
            if (this.AcoMap != null)
            {
                 s += ind + "acoMap\n";

                 s += ind + "{\n" + 
                 this.AcoMap.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<OracleAcoValueErrorDetail>? AcoValueValidationErrors
            // GraphQL -> acoValueValidationErrors: [OracleAcoValueErrorDetail!]! (type)
            if (this.AcoValueValidationErrors != null)
            {
                 s += ind + "acoValueValidationErrors\n";

                 s += ind + "{\n" + 
                 this.AcoValueValidationErrors.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? AcoParameterErrors
            // GraphQL -> acoParameterErrors: [String!]! (scalar)
            if (this.AcoParameterErrors == null && Exploration.Includes(parent + ".acoParameterErrors$"))
            {
                this.AcoParameterErrors = new List<System.String>();
            }
            //      C# -> List<OracleAcoParameterDetail>? AcoMap
            // GraphQL -> acoMap: [OracleAcoParameterDetail!]! (type)
            if (this.AcoMap == null && Exploration.Includes(parent + ".acoMap"))
            {
                this.AcoMap = new List<OracleAcoParameterDetail>();
                this.AcoMap.ApplyExploratoryFragment(parent + ".acoMap");
            }
            //      C# -> List<OracleAcoValueErrorDetail>? AcoValueValidationErrors
            // GraphQL -> acoValueValidationErrors: [OracleAcoValueErrorDetail!]! (type)
            if (this.AcoValueValidationErrors == null && Exploration.Includes(parent + ".acoValueValidationErrors"))
            {
                this.AcoValueValidationErrors = new List<OracleAcoValueErrorDetail>();
                this.AcoValueValidationErrors.ApplyExploratoryFragment(parent + ".acoValueValidationErrors");
            }
        }


    #endregion

    } // class ValidateOracleAcoFileReply
    #endregion

    public static class ListValidateOracleAcoFileReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<ValidateOracleAcoFileReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ValidateOracleAcoFileReply> list, 
            String parent = "")
        {
            var item = new ValidateOracleAcoFileReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types