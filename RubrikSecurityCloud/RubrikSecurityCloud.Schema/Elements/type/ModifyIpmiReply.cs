// ModifyIpmiReply.cs
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
    #region ModifyIpmiReply
    public class ModifyIpmiReply: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsAvailable
        // GraphQL -> isAvailable: Boolean! (scalar)
        [JsonProperty("isAvailable")]
        public System.Boolean? IsAvailable { get; set; }

        //      C# -> IpmiAccess? Access
        // GraphQL -> access: IpmiAccess (type)
        [JsonProperty("access")]
        public IpmiAccess? Access { get; set; }

        #endregion

    #region methods

    public ModifyIpmiReply Set(
        System.Boolean? IsAvailable = null,
        IpmiAccess? Access = null
    ) 
    {
        if ( IsAvailable != null ) {
            this.IsAvailable = IsAvailable;
        }
        if ( Access != null ) {
            this.Access = Access;
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
            //      C# -> System.Boolean? IsAvailable
            // GraphQL -> isAvailable: Boolean! (scalar)
            if (this.IsAvailable != null)
            {
                 s += ind + "isAvailable\n";

            }
            //      C# -> IpmiAccess? Access
            // GraphQL -> access: IpmiAccess (type)
            if (this.Access != null)
            {
                 s += ind + "access\n";

                 s += ind + "{\n" + 
                 this.Access.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsAvailable
            // GraphQL -> isAvailable: Boolean! (scalar)
            if (this.IsAvailable == null && Exploration.Includes(parent + ".isAvailable$"))
            {
                this.IsAvailable = new System.Boolean();
            }
            //      C# -> IpmiAccess? Access
            // GraphQL -> access: IpmiAccess (type)
            if (this.Access == null && Exploration.Includes(parent + ".access"))
            {
                this.Access = new IpmiAccess();
                this.Access.ApplyExploratoryFragment(parent + ".access");
            }
        }


    #endregion

    } // class ModifyIpmiReply
    #endregion

    public static class ListModifyIpmiReplyExtensions
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
            this List<ModifyIpmiReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ModifyIpmiReply> list, 
            String parent = "")
        {
            var item = new ModifyIpmiReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types