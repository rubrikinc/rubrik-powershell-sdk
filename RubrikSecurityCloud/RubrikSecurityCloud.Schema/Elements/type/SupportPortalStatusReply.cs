// SupportPortalStatusReply.cs
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
    #region SupportPortalStatusReply
    public class SupportPortalStatusReply: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsLoggedIn
        // GraphQL -> isLoggedIn: Boolean! (scalar)
        [JsonProperty("isLoggedIn")]
        public System.Boolean? IsLoggedIn { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> StatusResponse? Status
        // GraphQL -> status: StatusResponse (type)
        [JsonProperty("status")]
        public StatusResponse? Status { get; set; }

        #endregion

    #region methods

    public SupportPortalStatusReply Set(
        System.Boolean? IsLoggedIn = null,
        System.String? Username = null,
        StatusResponse? Status = null
    ) 
    {
        if ( IsLoggedIn != null ) {
            this.IsLoggedIn = IsLoggedIn;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.Boolean? IsLoggedIn
            // GraphQL -> isLoggedIn: Boolean! (scalar)
            if (this.IsLoggedIn != null)
            {
                 s += ind + "isLoggedIn\n";

            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username != null)
            {
                 s += ind + "username\n";

            }
            //      C# -> StatusResponse? Status
            // GraphQL -> status: StatusResponse (type)
            if (this.Status != null)
            {
                 s += ind + "status\n";

                 s += ind + "{\n" + 
                 this.Status.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsLoggedIn
            // GraphQL -> isLoggedIn: Boolean! (scalar)
            if (this.IsLoggedIn == null && Exploration.Includes(parent + ".isLoggedIn$"))
            {
                this.IsLoggedIn = new System.Boolean();
            }
            //      C# -> System.String? Username
            // GraphQL -> username: String! (scalar)
            if (this.Username == null && Exploration.Includes(parent + ".username$"))
            {
                this.Username = new System.String("FETCH");
            }
            //      C# -> StatusResponse? Status
            // GraphQL -> status: StatusResponse (type)
            if (this.Status == null && Exploration.Includes(parent + ".status"))
            {
                this.Status = new StatusResponse();
                this.Status.ApplyExploratoryFragment(parent + ".status");
            }
        }


    #endregion

    } // class SupportPortalStatusReply
    #endregion

    public static class ListSupportPortalStatusReplyExtensions
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
            this List<SupportPortalStatusReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SupportPortalStatusReply> list, 
            String parent = "")
        {
            var item = new SupportPortalStatusReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types