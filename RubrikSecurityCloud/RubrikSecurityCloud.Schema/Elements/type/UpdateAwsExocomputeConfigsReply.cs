// UpdateAwsExocomputeConfigsReply.cs
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
    #region UpdateAwsExocomputeConfigsReply
    public class UpdateAwsExocomputeConfigsReply: BaseType
    {
        #region members

        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        [JsonProperty("configs")]
        public List<AwsExocomputeGetConfigResponse>? Configs { get; set; }

        //      C# -> List<AwsExocomputeConfigsDeletionStatusType>? DeleteStatus
        // GraphQL -> deleteStatus: [AwsExocomputeConfigsDeletionStatusType!]! (type)
        [JsonProperty("deleteStatus")]
        public List<AwsExocomputeConfigsDeletionStatusType>? DeleteStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateAwsExocomputeConfigsReply";
    }

    public UpdateAwsExocomputeConfigsReply Set(
        List<AwsExocomputeGetConfigResponse>? Configs = null,
        List<AwsExocomputeConfigsDeletionStatusType>? DeleteStatus = null
    ) 
    {
        if ( Configs != null ) {
            this.Configs = Configs;
        }
        if ( DeleteStatus != null ) {
            this.DeleteStatus = DeleteStatus;
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
        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.Configs != null) {
            var fspec = this.Configs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<AwsExocomputeConfigsDeletionStatusType>? DeleteStatus
        // GraphQL -> deleteStatus: [AwsExocomputeConfigsDeletionStatusType!]! (type)
        if (this.DeleteStatus != null) {
            var fspec = this.DeleteStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "deleteStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsExocomputeGetConfigResponse>? Configs
        // GraphQL -> configs: [AwsExocomputeGetConfigResponse!]! (type)
        if (this.Configs == null && ec.Includes("configs",false))
        {
            this.Configs = new List<AwsExocomputeGetConfigResponse>();
            this.Configs.ApplyExploratoryFieldSpec(ec.NewChild("configs"));
        }
        //      C# -> List<AwsExocomputeConfigsDeletionStatusType>? DeleteStatus
        // GraphQL -> deleteStatus: [AwsExocomputeConfigsDeletionStatusType!]! (type)
        if (this.DeleteStatus == null && ec.Includes("deleteStatus",false))
        {
            this.DeleteStatus = new List<AwsExocomputeConfigsDeletionStatusType>();
            this.DeleteStatus.ApplyExploratoryFieldSpec(ec.NewChild("deleteStatus"));
        }
    }


    #endregion

    } // class UpdateAwsExocomputeConfigsReply
    
    #endregion

    public static class ListUpdateAwsExocomputeConfigsReplyExtensions
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
            this List<UpdateAwsExocomputeConfigsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateAwsExocomputeConfigsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateAwsExocomputeConfigsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateAwsExocomputeConfigsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types