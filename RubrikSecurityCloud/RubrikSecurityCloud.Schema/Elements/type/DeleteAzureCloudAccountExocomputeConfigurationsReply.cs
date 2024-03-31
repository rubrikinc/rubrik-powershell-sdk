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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<DeleteAzureCloudAccountExocomputeConfigurationsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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