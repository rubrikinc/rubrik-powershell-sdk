// ClusterIpv6ModeReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ClusterIpv6ModeReply
    public class ClusterIpv6ModeReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsIpv6Mode
        // GraphQL -> isIpv6Mode: Boolean! (scalar)
        [JsonProperty("isIpv6Mode")]
        public System.Boolean? IsIpv6Mode { get; set; }


        #endregion

    #region methods

    public ClusterIpv6ModeReply Set(
        System.Boolean? IsIpv6Mode = null
    ) 
    {
        if ( IsIpv6Mode != null ) {
            this.IsIpv6Mode = IsIpv6Mode;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.Boolean? IsIpv6Mode
        // GraphQL -> isIpv6Mode: Boolean! (scalar)
        if (this.IsIpv6Mode != null) {
            s += ind + "isIpv6Mode\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsIpv6Mode
        // GraphQL -> isIpv6Mode: Boolean! (scalar)
        if (this.IsIpv6Mode == null && Exploration.Includes(parent + ".isIpv6Mode", true))
        {
            this.IsIpv6Mode = true;
        }
    }


    #endregion

    } // class ClusterIpv6ModeReply
    
    #endregion

    public static class ListClusterIpv6ModeReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ClusterIpv6ModeReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterIpv6ModeReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterIpv6ModeReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types