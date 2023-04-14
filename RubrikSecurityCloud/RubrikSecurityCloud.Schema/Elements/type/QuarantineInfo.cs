// QuarantineInfo.cs
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
    #region QuarantineInfo
    public class QuarantineInfo: IFragment
    {
        #region members
        //      C# -> System.Boolean? ContainsQuarantinedFiles
        // GraphQL -> containsQuarantinedFiles: Boolean! (scalar)
        [JsonProperty("containsQuarantinedFiles")]
        public System.Boolean? ContainsQuarantinedFiles { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }

        #endregion

    #region methods

    public QuarantineInfo Set(
        System.Boolean? ContainsQuarantinedFiles = null,
        System.Boolean? IsQuarantined = null
    ) 
    {
        if ( ContainsQuarantinedFiles != null ) {
            this.ContainsQuarantinedFiles = ContainsQuarantinedFiles;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
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
            //      C# -> System.Boolean? ContainsQuarantinedFiles
            // GraphQL -> containsQuarantinedFiles: Boolean! (scalar)
            if (this.ContainsQuarantinedFiles != null)
            {
                 s += ind + "containsQuarantinedFiles\n";

            }
            //      C# -> System.Boolean? IsQuarantined
            // GraphQL -> isQuarantined: Boolean! (scalar)
            if (this.IsQuarantined != null)
            {
                 s += ind + "isQuarantined\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? ContainsQuarantinedFiles
            // GraphQL -> containsQuarantinedFiles: Boolean! (scalar)
            if (this.ContainsQuarantinedFiles == null && Exploration.Includes(parent + ".containsQuarantinedFiles$"))
            {
                this.ContainsQuarantinedFiles = new System.Boolean();
            }
            //      C# -> System.Boolean? IsQuarantined
            // GraphQL -> isQuarantined: Boolean! (scalar)
            if (this.IsQuarantined == null && Exploration.Includes(parent + ".isQuarantined$"))
            {
                this.IsQuarantined = new System.Boolean();
            }
        }


    #endregion

    } // class QuarantineInfo
    #endregion

    public static class ListQuarantineInfoExtensions
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
            this List<QuarantineInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<QuarantineInfo> list, 
            String parent = "")
        {
            var item = new QuarantineInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types