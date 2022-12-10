// GetWhitelistReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:42.
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
    #region GetWhitelistReply
    public class GetWhitelistReply: IFragment
    {
        #region members
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        //      C# -> List<System.String>? IpCidrs
        // GraphQL -> ipCidrs: [String!]! (scalar)
        [JsonProperty("ipCidrs")]
        public List<System.String>? IpCidrs { get; set; }

        //      C# -> WhitelistModeEnum? Mode
        // GraphQL -> mode: WhitelistModeEnum! (enum)
        [JsonProperty("mode")]
        public WhitelistModeEnum? Mode { get; set; }

        #endregion

    #region methods

    public GetWhitelistReply Set(
        System.Boolean? Enabled = null,
        List<System.String>? IpCidrs = null,
        WhitelistModeEnum? Mode = null
    ) 
    {
        if ( Enabled != null ) {
            this.Enabled = Enabled;
        }
        if ( IpCidrs != null ) {
            this.IpCidrs = IpCidrs;
        }
        if ( Mode != null ) {
            this.Mode = Mode;
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
            //      C# -> System.Boolean? Enabled
            // GraphQL -> enabled: Boolean! (scalar)
            if (this.Enabled != null)
            {
                 s += ind + "enabled\n";

            }
            //      C# -> List<System.String>? IpCidrs
            // GraphQL -> ipCidrs: [String!]! (scalar)
            if (this.IpCidrs != null)
            {
                 s += ind + "ipCidrs\n";

            }
            //      C# -> WhitelistModeEnum? Mode
            // GraphQL -> mode: WhitelistModeEnum! (enum)
            if (this.Mode != null)
            {
                 s += ind + "mode\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? Enabled
            // GraphQL -> enabled: Boolean! (scalar)
            if (this.Enabled == null && Exploration.Includes(parent + ".enabled$"))
            {
                this.Enabled = new System.Boolean();
            }
            //      C# -> List<System.String>? IpCidrs
            // GraphQL -> ipCidrs: [String!]! (scalar)
            if (this.IpCidrs == null && Exploration.Includes(parent + ".ipCidrs$"))
            {
                this.IpCidrs = new List<System.String>();
            }
            //      C# -> WhitelistModeEnum? Mode
            // GraphQL -> mode: WhitelistModeEnum! (enum)
            if (this.Mode == null && Exploration.Includes(parent + ".mode$"))
            {
                this.Mode = new WhitelistModeEnum();
            }
        }


    #endregion

    } // class GetWhitelistReply
    #endregion

    public static class ListGetWhitelistReplyExtensions
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
            this List<GetWhitelistReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetWhitelistReply> list, 
            String parent = "")
        {
            var item = new GetWhitelistReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types