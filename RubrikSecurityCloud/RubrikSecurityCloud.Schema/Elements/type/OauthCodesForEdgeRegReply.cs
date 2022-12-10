// OauthCodesForEdgeRegReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:04.
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
    #region OauthCodesForEdgeRegReply
    public class OauthCodesForEdgeRegReply: IFragment
    {
        #region members
        //      C# -> System.String? CdmOvaLink
        // GraphQL -> cdmOvaLink: String! (scalar)
        [JsonProperty("cdmOvaLink")]
        public System.String? CdmOvaLink { get; set; }

        //      C# -> System.String? WindowsToolLink
        // GraphQL -> windowsToolLink: String! (scalar)
        [JsonProperty("windowsToolLink")]
        public System.String? WindowsToolLink { get; set; }

        //      C# -> List<OauthAccessToken>? RegistrationCodes
        // GraphQL -> registrationCodes: [OauthAccessToken!]! (type)
        [JsonProperty("registrationCodes")]
        public List<OauthAccessToken>? RegistrationCodes { get; set; }

        #endregion

    #region methods

    public OauthCodesForEdgeRegReply Set(
        System.String? CdmOvaLink = null,
        System.String? WindowsToolLink = null,
        List<OauthAccessToken>? RegistrationCodes = null
    ) 
    {
        if ( CdmOvaLink != null ) {
            this.CdmOvaLink = CdmOvaLink;
        }
        if ( WindowsToolLink != null ) {
            this.WindowsToolLink = WindowsToolLink;
        }
        if ( RegistrationCodes != null ) {
            this.RegistrationCodes = RegistrationCodes;
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
            //      C# -> System.String? CdmOvaLink
            // GraphQL -> cdmOvaLink: String! (scalar)
            if (this.CdmOvaLink != null)
            {
                 s += ind + "cdmOvaLink\n";

            }
            //      C# -> System.String? WindowsToolLink
            // GraphQL -> windowsToolLink: String! (scalar)
            if (this.WindowsToolLink != null)
            {
                 s += ind + "windowsToolLink\n";

            }
            //      C# -> List<OauthAccessToken>? RegistrationCodes
            // GraphQL -> registrationCodes: [OauthAccessToken!]! (type)
            if (this.RegistrationCodes != null)
            {
                 s += ind + "registrationCodes\n";

                 s += ind + "{\n" + 
                 this.RegistrationCodes.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmOvaLink
            // GraphQL -> cdmOvaLink: String! (scalar)
            if (this.CdmOvaLink == null && Exploration.Includes(parent + ".cdmOvaLink$"))
            {
                this.CdmOvaLink = new System.String("FETCH");
            }
            //      C# -> System.String? WindowsToolLink
            // GraphQL -> windowsToolLink: String! (scalar)
            if (this.WindowsToolLink == null && Exploration.Includes(parent + ".windowsToolLink$"))
            {
                this.WindowsToolLink = new System.String("FETCH");
            }
            //      C# -> List<OauthAccessToken>? RegistrationCodes
            // GraphQL -> registrationCodes: [OauthAccessToken!]! (type)
            if (this.RegistrationCodes == null && Exploration.Includes(parent + ".registrationCodes"))
            {
                this.RegistrationCodes = new List<OauthAccessToken>();
                this.RegistrationCodes.ApplyExploratoryFragment(parent + ".registrationCodes");
            }
        }


    #endregion

    } // class OauthCodesForEdgeRegReply
    #endregion

    public static class ListOauthCodesForEdgeRegReplyExtensions
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
            this List<OauthCodesForEdgeRegReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OauthCodesForEdgeRegReply> list, 
            String parent = "")
        {
            var item = new OauthCodesForEdgeRegReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types