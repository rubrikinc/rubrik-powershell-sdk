// UpdateServiceAccountReply.cs
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
    #region UpdateServiceAccountReply
    public class UpdateServiceAccountReply: IFragment
    {
        #region members
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> DateTime? LastLogin
        // GraphQL -> lastLogin: DateTime (scalar)
        [JsonProperty("lastLogin")]
        public DateTime? LastLogin { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        #endregion

    #region methods

    public UpdateServiceAccountReply Set(
        System.String? ClientId = null,
        System.String? Description = null,
        DateTime? LastLogin = null,
        System.String? Name = null
    ) 
    {
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( LastLogin != null ) {
            this.LastLogin = LastLogin;
        }
        if ( Name != null ) {
            this.Name = Name;
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
            //      C# -> System.String? ClientId
            // GraphQL -> clientId: String! (scalar)
            if (this.ClientId != null)
            {
                 s += ind + "clientId\n";

            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> DateTime? LastLogin
            // GraphQL -> lastLogin: DateTime (scalar)
            if (this.LastLogin != null)
            {
                 s += ind + "lastLogin\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClientId
            // GraphQL -> clientId: String! (scalar)
            if (this.ClientId == null && Exploration.Includes(parent + ".clientId$"))
            {
                this.ClientId = new System.String("FETCH");
            }
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> DateTime? LastLogin
            // GraphQL -> lastLogin: DateTime (scalar)
            if (this.LastLogin == null && Exploration.Includes(parent + ".lastLogin$"))
            {
                this.LastLogin = new DateTime();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
        }


    #endregion

    } // class UpdateServiceAccountReply
    #endregion

    public static class ListUpdateServiceAccountReplyExtensions
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
            this List<UpdateServiceAccountReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateServiceAccountReply> list, 
            String parent = "")
        {
            var item = new UpdateServiceAccountReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types