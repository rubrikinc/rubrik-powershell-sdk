// ErrorInfo.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region ErrorInfo
    public class ErrorInfo: IFragment
    {
        #region members
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.Int32? StatusCode
        // GraphQL -> statusCode: Int! (scalar)
        [JsonProperty("statusCode")]
        public System.Int32? StatusCode { get; set; }

        #endregion

    #region methods

    public ErrorInfo Set(
        System.String? ErrorMessage = null,
        System.Int32? StatusCode = null
    ) 
    {
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( StatusCode != null ) {
            this.StatusCode = StatusCode;
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
            //      C# -> System.String? ErrorMessage
            // GraphQL -> errorMessage: String! (scalar)
            if (this.ErrorMessage != null)
            {
                 s += ind + "errorMessage\n";

            }
            //      C# -> System.Int32? StatusCode
            // GraphQL -> statusCode: Int! (scalar)
            if (this.StatusCode != null)
            {
                 s += ind + "statusCode\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ErrorMessage
            // GraphQL -> errorMessage: String! (scalar)
            if (this.ErrorMessage == null && Exploration.Includes(parent + ".errorMessage$"))
            {
                this.ErrorMessage = new System.String("FETCH");
            }
            //      C# -> System.Int32? StatusCode
            // GraphQL -> statusCode: Int! (scalar)
            if (this.StatusCode == null && Exploration.Includes(parent + ".statusCode$"))
            {
                this.StatusCode = new System.Int32();
            }
        }


    #endregion

    } // class ErrorInfo
    #endregion

    public static class ListErrorInfoExtensions
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
            this List<ErrorInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ErrorInfo> list, 
            String parent = "")
        {
            var item = new ErrorInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types