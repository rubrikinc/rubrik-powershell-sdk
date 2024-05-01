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
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "deletionStatus" + " " + "{\n" + fspec + ind + "}\n" ;
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<DeleteAwsExocomputeConfigsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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