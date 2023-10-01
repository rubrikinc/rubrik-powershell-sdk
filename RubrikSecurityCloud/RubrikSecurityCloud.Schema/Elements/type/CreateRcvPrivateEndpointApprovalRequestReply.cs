// CreateRcvPrivateEndpointApprovalRequestReply.cs
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
    #region CreateRcvPrivateEndpointApprovalRequestReply
    public class CreateRcvPrivateEndpointApprovalRequestReply: BaseType
    {
        #region members

        //      C# -> System.String? RequestMessage
        // GraphQL -> requestMessage: String! (scalar)
        [JsonProperty("requestMessage")]
        public System.String? RequestMessage { get; set; }

        //      C# -> System.String? StorageAccountId
        // GraphQL -> storageAccountId: String! (scalar)
        [JsonProperty("storageAccountId")]
        public System.String? StorageAccountId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateRcvPrivateEndpointApprovalRequestReply";
    }

    public CreateRcvPrivateEndpointApprovalRequestReply Set(
        System.String? RequestMessage = null,
        System.String? StorageAccountId = null
    ) 
    {
        if ( RequestMessage != null ) {
            this.RequestMessage = RequestMessage;
        }
        if ( StorageAccountId != null ) {
            this.StorageAccountId = StorageAccountId;
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
        //      C# -> System.String? RequestMessage
        // GraphQL -> requestMessage: String! (scalar)
        if (this.RequestMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "requestMessage\n" ;
            } else {
                s += ind + "requestMessage\n" ;
            }
        }
        //      C# -> System.String? StorageAccountId
        // GraphQL -> storageAccountId: String! (scalar)
        if (this.StorageAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageAccountId\n" ;
            } else {
                s += ind + "storageAccountId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? RequestMessage
        // GraphQL -> requestMessage: String! (scalar)
        if (ec.Includes("requestMessage",true))
        {
            if(this.RequestMessage == null) {

                this.RequestMessage = "FETCH";

            } else {


            }
        }
        else if (this.RequestMessage != null && ec.Excludes("requestMessage",true))
        {
            this.RequestMessage = null;
        }
        //      C# -> System.String? StorageAccountId
        // GraphQL -> storageAccountId: String! (scalar)
        if (ec.Includes("storageAccountId",true))
        {
            if(this.StorageAccountId == null) {

                this.StorageAccountId = "FETCH";

            } else {


            }
        }
        else if (this.StorageAccountId != null && ec.Excludes("storageAccountId",true))
        {
            this.StorageAccountId = null;
        }
    }


    #endregion

    } // class CreateRcvPrivateEndpointApprovalRequestReply
    
    #endregion

    public static class ListCreateRcvPrivateEndpointApprovalRequestReplyExtensions
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
            this List<CreateRcvPrivateEndpointApprovalRequestReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CreateRcvPrivateEndpointApprovalRequestReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateRcvPrivateEndpointApprovalRequestReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateRcvPrivateEndpointApprovalRequestReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateRcvPrivateEndpointApprovalRequestReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types