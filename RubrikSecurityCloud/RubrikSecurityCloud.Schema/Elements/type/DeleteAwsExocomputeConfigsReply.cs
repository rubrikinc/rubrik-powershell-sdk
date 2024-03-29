// DeleteAwsExocomputeConfigsReply.cs
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
    #region DeleteAwsExocomputeConfigsReply
    public class DeleteAwsExocomputeConfigsReply: BaseType
    {
        #region members

        //      C# -> List<AwsExocomputeConfigsDeletionStatusType>? DeletionStatus
        // GraphQL -> deletionStatus: [AwsExocomputeConfigsDeletionStatusType!]! (type)
        [JsonProperty("deletionStatus")]
        public List<AwsExocomputeConfigsDeletionStatusType>? DeletionStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DeleteAwsExocomputeConfigsReply";
    }

    public DeleteAwsExocomputeConfigsReply Set(
        List<AwsExocomputeConfigsDeletionStatusType>? DeletionStatus = null
    ) 
    {
        if ( DeletionStatus != null ) {
            this.DeletionStatus = DeletionStatus;
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
        //      C# -> List<AwsExocomputeConfigsDeletionStatusType>? DeletionStatus
        // GraphQL -> deletionStatus: [AwsExocomputeConfigsDeletionStatusType!]! (type)
        if (this.DeletionStatus != null) {
            var fspec = this.DeletionStatus.AsFieldSpec(conf.Child("deletionStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deletionStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AwsExocomputeConfigsDeletionStatusType>? DeletionStatus
        // GraphQL -> deletionStatus: [AwsExocomputeConfigsDeletionStatusType!]! (type)
        if (ec.Includes("deletionStatus",false))
        {
            if(this.DeletionStatus == null) {

                this.DeletionStatus = new List<AwsExocomputeConfigsDeletionStatusType>();
                this.DeletionStatus.ApplyExploratoryFieldSpec(ec.NewChild("deletionStatus"));

            } else {

                this.DeletionStatus.ApplyExploratoryFieldSpec(ec.NewChild("deletionStatus"));

            }
        }
        else if (this.DeletionStatus != null && ec.Excludes("deletionStatus",false))
        {
            this.DeletionStatus = null;
        }
    }


    #endregion

    } // class DeleteAwsExocomputeConfigsReply
    
    #endregion

    public static class ListDeleteAwsExocomputeConfigsReplyExtensions
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
            this List<DeleteAwsExocomputeConfigsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DeleteAwsExocomputeConfigsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DeleteAwsExocomputeConfigsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DeleteAwsExocomputeConfigsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DeleteAwsExocomputeConfigsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types