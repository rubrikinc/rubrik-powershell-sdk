// RegisterCloudClusterReply.cs
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
    #region RegisterCloudClusterReply
    public class RegisterCloudClusterReply: IFragment
    {
        #region members
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> System.Boolean? IsSuccessful
        // GraphQL -> isSuccessful: Boolean! (scalar)
        [JsonProperty("isSuccessful")]
        public System.Boolean? IsSuccessful { get; set; }

        #endregion

    #region methods

    public RegisterCloudClusterReply Set(
        System.String? Error = null,
        System.Boolean? IsSuccessful = null
    ) 
    {
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( IsSuccessful != null ) {
            this.IsSuccessful = IsSuccessful;
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
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error != null)
            {
                 s += ind + "error\n";

            }
            //      C# -> System.Boolean? IsSuccessful
            // GraphQL -> isSuccessful: Boolean! (scalar)
            if (this.IsSuccessful != null)
            {
                 s += ind + "isSuccessful\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Error
            // GraphQL -> error: String! (scalar)
            if (this.Error == null && Exploration.Includes(parent + ".error$"))
            {
                this.Error = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsSuccessful
            // GraphQL -> isSuccessful: Boolean! (scalar)
            if (this.IsSuccessful == null && Exploration.Includes(parent + ".isSuccessful$"))
            {
                this.IsSuccessful = new System.Boolean();
            }
        }


    #endregion

    } // class RegisterCloudClusterReply
    #endregion

    public static class ListRegisterCloudClusterReplyExtensions
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
            this List<RegisterCloudClusterReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RegisterCloudClusterReply> list, 
            String parent = "")
        {
            var item = new RegisterCloudClusterReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types