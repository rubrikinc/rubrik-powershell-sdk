// UpdateO365OrgCustomNameReply.cs
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
    #region UpdateO365OrgCustomNameReply
    public class UpdateO365OrgCustomNameReply: BaseType
    {
        #region members

        //      C# -> System.String? CustomName
        // GraphQL -> customName: String! (scalar)
        [JsonProperty("customName")]
        public System.String? CustomName { get; set; }

        //      C# -> System.String? OrgUuid
        // GraphQL -> orgUuid: UUID! (scalar)
        [JsonProperty("orgUuid")]
        public System.String? OrgUuid { get; set; }


        #endregion

    #region methods

    public UpdateO365OrgCustomNameReply Set(
        System.String? CustomName = null,
        System.String? OrgUuid = null
    ) 
    {
        if ( CustomName != null ) {
            this.CustomName = CustomName;
        }
        if ( OrgUuid != null ) {
            this.OrgUuid = OrgUuid;
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
        //      C# -> System.String? CustomName
        // GraphQL -> customName: String! (scalar)
        if (this.CustomName != null) {
            s += ind + "customName\n" ;
        }
        //      C# -> System.String? OrgUuid
        // GraphQL -> orgUuid: UUID! (scalar)
        if (this.OrgUuid != null) {
            s += ind + "orgUuid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? CustomName
        // GraphQL -> customName: String! (scalar)
        if (this.CustomName == null && Exploration.Includes(parent + ".customName", true))
        {
            this.CustomName = "FETCH";
        }
        //      C# -> System.String? OrgUuid
        // GraphQL -> orgUuid: UUID! (scalar)
        if (this.OrgUuid == null && Exploration.Includes(parent + ".orgUuid", true))
        {
            this.OrgUuid = "FETCH";
        }
    }


    #endregion

    } // class UpdateO365OrgCustomNameReply
    
    #endregion

    public static class ListUpdateO365OrgCustomNameReplyExtensions
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
            this List<UpdateO365OrgCustomNameReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateO365OrgCustomNameReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateO365OrgCustomNameReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types