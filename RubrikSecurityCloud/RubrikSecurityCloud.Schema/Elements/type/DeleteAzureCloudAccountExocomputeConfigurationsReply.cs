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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? DeletionFailedIds
        // GraphQL -> deletionFailedIds: [String!]! (scalar)
        if (this.DeletionFailedIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deletionFailedIds\n" ;
            } else {
                s += ind + "deletionFailedIds\n" ;
            }
        }
        //      C# -> List<System.String>? DeletionSuccessIds
        // GraphQL -> deletionSuccessIds: [String!]! (scalar)
        if (this.DeletionSuccessIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deletionSuccessIds\n" ;
            } else {
                s += ind + "deletionSuccessIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? DeletionFailedIds
        // GraphQL -> deletionFailedIds: [String!]! (scalar)
        if (ec.Includes("deletionFailedIds",true))
        {
            if(this.DeletionFailedIds == null) {

                this.DeletionFailedIds = new List<System.String>();

            } else {


            }
        }
        else if (this.DeletionFailedIds != null && ec.Excludes("deletionFailedIds",true))
        {
            this.DeletionFailedIds = null;
        }
        //      C# -> List<System.String>? DeletionSuccessIds
        // GraphQL -> deletionSuccessIds: [String!]! (scalar)
        if (ec.Includes("deletionSuccessIds",true))
        {
            if(this.DeletionSuccessIds == null) {

                this.DeletionSuccessIds = new List<System.String>();

            } else {


            }
        }
        else if (this.DeletionSuccessIds != null && ec.Excludes("deletionSuccessIds",true))
        {
            this.DeletionSuccessIds = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DeleteAzureCloudAccountExocomputeConfigurationsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DeleteAzureCloudAccountExocomputeConfigurationsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DeleteAzureCloudAccountExocomputeConfigurationsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DeleteAzureCloudAccountExocomputeConfigurationsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types