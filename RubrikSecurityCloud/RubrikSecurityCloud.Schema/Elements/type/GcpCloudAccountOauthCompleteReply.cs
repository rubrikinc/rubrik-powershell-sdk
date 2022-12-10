// GcpCloudAccountOauthCompleteReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:22.
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
    #region GcpCloudAccountOauthCompleteReply
    public class GcpCloudAccountOauthCompleteReply: IFragment
    {
        #region members
        //      C# -> GcpOauthUserInfo? UserInfo
        // GraphQL -> userInfo: GcpOauthUserInfo (type)
        [JsonProperty("userInfo")]
        public GcpOauthUserInfo? UserInfo { get; set; }

        #endregion

    #region methods

    public GcpCloudAccountOauthCompleteReply Set(
        GcpOauthUserInfo? UserInfo = null
    ) 
    {
        if ( UserInfo != null ) {
            this.UserInfo = UserInfo;
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
            //      C# -> GcpOauthUserInfo? UserInfo
            // GraphQL -> userInfo: GcpOauthUserInfo (type)
            if (this.UserInfo != null)
            {
                 s += ind + "userInfo\n";

                 s += ind + "{\n" + 
                 this.UserInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> GcpOauthUserInfo? UserInfo
            // GraphQL -> userInfo: GcpOauthUserInfo (type)
            if (this.UserInfo == null && Exploration.Includes(parent + ".userInfo"))
            {
                this.UserInfo = new GcpOauthUserInfo();
                this.UserInfo.ApplyExploratoryFragment(parent + ".userInfo");
            }
        }


    #endregion

    } // class GcpCloudAccountOauthCompleteReply
    #endregion

    public static class ListGcpCloudAccountOauthCompleteReplyExtensions
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
            this List<GcpCloudAccountOauthCompleteReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpCloudAccountOauthCompleteReply> list, 
            String parent = "")
        {
            var item = new GcpCloudAccountOauthCompleteReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types