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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region UpgradeJobReplyWithUuid
    public class UpgradeJobReplyWithUuid: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (this.Uuid != null) {
            s += ind + "uuid\n" ;
        }
        //      C# -> UpgradeJobReply? UpgradeJobReply
        // GraphQL -> upgradeJobReply: UpgradeJobReply! (type)
        if (this.UpgradeJobReply != null) {
            var fspec = this.UpgradeJobReply.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "upgradeJobReply {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: String! (scalar)
        if (this.Uuid == null && Exploration.Includes(parent + ".uuid", true))
        {
            this.Uuid = "FETCH";
        }
        //      C# -> UpgradeJobReply? UpgradeJobReply
        // GraphQL -> upgradeJobReply: UpgradeJobReply! (type)
        if (this.UpgradeJobReply == null && Exploration.Includes(parent + ".upgradeJobReply"))
        {
            this.UpgradeJobReply = new UpgradeJobReply();
            this.UpgradeJobReply.ApplyExploratoryFieldSpec(parent + ".upgradeJobReply");
        }
    }


    #endregion

    } // class UpgradeJobReplyWithUuid
    
    #endregion

    public static class ListUpgradeJobReplyWithUuidExtensions
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
            this List<UpgradeJobReplyWithUuid> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpgradeJobReplyWithUuid> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpgradeJobReplyWithUuid());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types