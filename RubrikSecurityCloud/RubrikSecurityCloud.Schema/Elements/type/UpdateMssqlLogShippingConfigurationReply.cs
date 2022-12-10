// UpdateMssqlLogShippingConfigurationReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:30.
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
    #region UpdateMssqlLogShippingConfigurationReply
    public class UpdateMssqlLogShippingConfigurationReply: IFragment
    {
        #region members
        //      C# -> System.Boolean? ShouldDisconnectStandbyUsers
        // GraphQL -> shouldDisconnectStandbyUsers: Boolean (scalar)
        [JsonProperty("shouldDisconnectStandbyUsers")]
        public System.Boolean? ShouldDisconnectStandbyUsers { get; set; }

        //      C# -> MssqlLogShippingLinks? Links
        // GraphQL -> links: MssqlLogShippingLinks (type)
        [JsonProperty("links")]
        public MssqlLogShippingLinks? Links { get; set; }

        //      C# -> MssqlLogShippingSummaryV2? MssqlLogShippingSummaryV2
        // GraphQL -> mssqlLogShippingSummaryV2: MssqlLogShippingSummaryV2 (type)
        [JsonProperty("mssqlLogShippingSummaryV2")]
        public MssqlLogShippingSummaryV2? MssqlLogShippingSummaryV2 { get; set; }

        #endregion

    #region methods

    public UpdateMssqlLogShippingConfigurationReply Set(
        System.Boolean? ShouldDisconnectStandbyUsers = null,
        MssqlLogShippingLinks? Links = null,
        MssqlLogShippingSummaryV2? MssqlLogShippingSummaryV2 = null
    ) 
    {
        if ( ShouldDisconnectStandbyUsers != null ) {
            this.ShouldDisconnectStandbyUsers = ShouldDisconnectStandbyUsers;
        }
        if ( Links != null ) {
            this.Links = Links;
        }
        if ( MssqlLogShippingSummaryV2 != null ) {
            this.MssqlLogShippingSummaryV2 = MssqlLogShippingSummaryV2;
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
            //      C# -> System.Boolean? ShouldDisconnectStandbyUsers
            // GraphQL -> shouldDisconnectStandbyUsers: Boolean (scalar)
            if (this.ShouldDisconnectStandbyUsers != null)
            {
                 s += ind + "shouldDisconnectStandbyUsers\n";

            }
            //      C# -> MssqlLogShippingLinks? Links
            // GraphQL -> links: MssqlLogShippingLinks (type)
            if (this.Links != null)
            {
                 s += ind + "links\n";

                 s += ind + "{\n" + 
                 this.Links.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MssqlLogShippingSummaryV2? MssqlLogShippingSummaryV2
            // GraphQL -> mssqlLogShippingSummaryV2: MssqlLogShippingSummaryV2 (type)
            if (this.MssqlLogShippingSummaryV2 != null)
            {
                 s += ind + "mssqlLogShippingSummaryV2\n";

                 s += ind + "{\n" + 
                 this.MssqlLogShippingSummaryV2.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? ShouldDisconnectStandbyUsers
            // GraphQL -> shouldDisconnectStandbyUsers: Boolean (scalar)
            if (this.ShouldDisconnectStandbyUsers == null && Exploration.Includes(parent + ".shouldDisconnectStandbyUsers$"))
            {
                this.ShouldDisconnectStandbyUsers = new System.Boolean();
            }
            //      C# -> MssqlLogShippingLinks? Links
            // GraphQL -> links: MssqlLogShippingLinks (type)
            if (this.Links == null && Exploration.Includes(parent + ".links"))
            {
                this.Links = new MssqlLogShippingLinks();
                this.Links.ApplyExploratoryFragment(parent + ".links");
            }
            //      C# -> MssqlLogShippingSummaryV2? MssqlLogShippingSummaryV2
            // GraphQL -> mssqlLogShippingSummaryV2: MssqlLogShippingSummaryV2 (type)
            if (this.MssqlLogShippingSummaryV2 == null && Exploration.Includes(parent + ".mssqlLogShippingSummaryV2"))
            {
                this.MssqlLogShippingSummaryV2 = new MssqlLogShippingSummaryV2();
                this.MssqlLogShippingSummaryV2.ApplyExploratoryFragment(parent + ".mssqlLogShippingSummaryV2");
            }
        }


    #endregion

    } // class UpdateMssqlLogShippingConfigurationReply
    #endregion

    public static class ListUpdateMssqlLogShippingConfigurationReplyExtensions
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
            this List<UpdateMssqlLogShippingConfigurationReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateMssqlLogShippingConfigurationReply> list, 
            String parent = "")
        {
            var item = new UpdateMssqlLogShippingConfigurationReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types