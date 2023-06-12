// UpdateOrgReply.cs
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
    #region UpdateOrgReply
    public class UpdateOrgReply: BaseType
    {
        #region members

        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        [JsonProperty("organizationId")]
        public System.String? OrganizationId { get; set; }


        #endregion

    #region methods

    public UpdateOrgReply Set(
        System.String? OrganizationId = null
    ) 
    {
        if ( OrganizationId != null ) {
            this.OrganizationId = OrganizationId;
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
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        if (this.OrganizationId != null) {
            s += ind + "organizationId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? OrganizationId
        // GraphQL -> organizationId: String! (scalar)
        if (this.OrganizationId == null && Exploration.Includes(parent + ".organizationId", true))
        {
            this.OrganizationId = "FETCH";
        }
    }


    #endregion

    } // class UpdateOrgReply
    
    #endregion

    public static class ListUpdateOrgReplyExtensions
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
            this List<UpdateOrgReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateOrgReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateOrgReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types