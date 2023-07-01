// DeleteAzureCloudAccountExocomputeConfigurationsReply.cs
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
    #region DeleteAzureCloudAccountExocomputeConfigurationsReply
    public class DeleteAzureCloudAccountExocomputeConfigurationsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? DeletionFailedIds
        // GraphQL -> deletionFailedIds: [String!]! (scalar)
        [JsonProperty("deletionFailedIds")]
        public List<System.String>? DeletionFailedIds { get; set; }

        //      C# -> List<System.String>? DeletionSuccessIds
        // GraphQL -> deletionSuccessIds: [String!]! (scalar)
        [JsonProperty("deletionSuccessIds")]
        public List<System.String>? DeletionSuccessIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DeleteAzureCloudAccountExocomputeConfigurationsReply";
    }

    public DeleteAzureCloudAccountExocomputeConfigurationsReply Set(
        List<System.String>? DeletionFailedIds = null,
        List<System.String>? DeletionSuccessIds = null
    ) 
    {
        if ( DeletionFailedIds != null ) {
            this.DeletionFailedIds = DeletionFailedIds;
        }
        if ( DeletionSuccessIds != null ) {
            this.DeletionSuccessIds = DeletionSuccessIds;
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
        //      C# -> List<System.String>? DeletionFailedIds
        // GraphQL -> deletionFailedIds: [String!]! (scalar)
        if (this.DeletionFailedIds != null) {
            s += ind + "deletionFailedIds\n" ;
        }
        //      C# -> List<System.String>? DeletionSuccessIds
        // GraphQL -> deletionSuccessIds: [String!]! (scalar)
        if (this.DeletionSuccessIds != null) {
            s += ind + "deletionSuccessIds\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? DeletionFailedIds
        // GraphQL -> deletionFailedIds: [String!]! (scalar)
        if (this.DeletionFailedIds == null && Exploration.Includes(parent + ".deletionFailedIds", true))
        {
            this.DeletionFailedIds = new List<System.String>();
        }
        //      C# -> List<System.String>? DeletionSuccessIds
        // GraphQL -> deletionSuccessIds: [String!]! (scalar)
        if (this.DeletionSuccessIds == null && Exploration.Includes(parent + ".deletionSuccessIds", true))
        {
            this.DeletionSuccessIds = new List<System.String>();
        }
    }


    #endregion

    } // class DeleteAzureCloudAccountExocomputeConfigurationsReply
    
    #endregion

    public static class ListDeleteAzureCloudAccountExocomputeConfigurationsReplyExtensions
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
            this List<DeleteAzureCloudAccountExocomputeConfigurationsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DeleteAzureCloudAccountExocomputeConfigurationsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DeleteAzureCloudAccountExocomputeConfigurationsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types