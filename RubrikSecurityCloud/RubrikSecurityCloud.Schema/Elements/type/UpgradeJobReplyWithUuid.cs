// UpgradeJobReplyWithUuid.cs
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
    #region UpgradeJobReplyWithUuid
    public class UpgradeJobReplyWithUuid: IFragment
    {
        #region members
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }

        //      C# -> UpgradeJobReply? UpgradeJobReply
        // GraphQL -> upgradeJobReply: UpgradeJobReply! (type)
        [JsonProperty("upgradeJobReply")]
        public UpgradeJobReply? UpgradeJobReply { get; set; }

        #endregion

    #region methods

    public UpgradeJobReplyWithUuid Set(
        System.String? Uuid = null,
        UpgradeJobReply? UpgradeJobReply = null
    ) 
    {
        if ( Uuid != null ) {
            this.Uuid = Uuid;
        }
        if ( UpgradeJobReply != null ) {
            this.UpgradeJobReply = UpgradeJobReply;
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
            //      C# -> System.String? Uuid
            // GraphQL -> uuid: String! (scalar)
            if (this.Uuid != null)
            {
                 s += ind + "uuid\n";

            }
            //      C# -> UpgradeJobReply? UpgradeJobReply
            // GraphQL -> upgradeJobReply: UpgradeJobReply! (type)
            if (this.UpgradeJobReply != null)
            {
                 s += ind + "upgradeJobReply\n";

                 s += ind + "{\n" + 
                 this.UpgradeJobReply.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Uuid
            // GraphQL -> uuid: String! (scalar)
            if (this.Uuid == null && Exploration.Includes(parent + ".uuid$"))
            {
                this.Uuid = new System.String("FETCH");
            }
            //      C# -> UpgradeJobReply? UpgradeJobReply
            // GraphQL -> upgradeJobReply: UpgradeJobReply! (type)
            if (this.UpgradeJobReply == null && Exploration.Includes(parent + ".upgradeJobReply"))
            {
                this.UpgradeJobReply = new UpgradeJobReply();
                this.UpgradeJobReply.ApplyExploratoryFragment(parent + ".upgradeJobReply");
            }
        }


    #endregion

    } // class UpgradeJobReplyWithUuid
    #endregion

    public static class ListUpgradeJobReplyWithUuidExtensions
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
            this List<UpgradeJobReplyWithUuid> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpgradeJobReplyWithUuid> list, 
            String parent = "")
        {
            var item = new UpgradeJobReplyWithUuid();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types