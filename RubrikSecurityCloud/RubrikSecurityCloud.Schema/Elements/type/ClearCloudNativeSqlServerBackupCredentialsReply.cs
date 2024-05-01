// ClearCloudNativeSqlServerBackupCredentialsReply.cs
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
    #region ClearCloudNativeSqlServerBackupCredentialsReply
    public class ClearCloudNativeSqlServerBackupCredentialsReply: BaseType
    {
        #region members

        //      C# -> List<System.String>? FailedObjectIds
        // GraphQL -> failedObjectIds: [UUID!]! (scalar)
        [JsonProperty("failedObjectIds")]
        public List<System.String>? FailedObjectIds { get; set; }

        //      C# -> List<System.String>? SuccessObjectIds
        // GraphQL -> successObjectIds: [UUID!]! (scalar)
        [JsonProperty("successObjectIds")]
        public List<System.String>? SuccessObjectIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClearCloudNativeSqlServerBackupCredentialsReply";
    }

    public ClearCloudNativeSqlServerBackupCredentialsReply Set(
        List<System.String>? FailedObjectIds = null,
        List<System.String>? SuccessObjectIds = null
    ) 
    {
        if ( FailedObjectIds != null ) {
            this.FailedObjectIds = FailedObjectIds;
        }
        if ( SuccessObjectIds != null ) {
            this.SuccessObjectIds = SuccessObjectIds;
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
        //      C# -> List<System.String>? FailedObjectIds
        // GraphQL -> failedObjectIds: [UUID!]! (scalar)
        if (this.FailedObjectIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failedObjectIds\n" ;
            } else {
                s += ind + "failedObjectIds\n" ;
            }
        }
        //      C# -> List<System.String>? SuccessObjectIds
        // GraphQL -> successObjectIds: [UUID!]! (scalar)
        if (this.SuccessObjectIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "successObjectIds\n" ;
            } else {
                s += ind + "successObjectIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? FailedObjectIds
        // GraphQL -> failedObjectIds: [UUID!]! (scalar)
        if (ec.Includes("failedObjectIds",true))
        {
            if(this.FailedObjectIds == null) {

                this.FailedObjectIds = new List<System.String>();

            } else {


            }
        }
        else if (this.FailedObjectIds != null && ec.Excludes("failedObjectIds",true))
        {
            this.FailedObjectIds = null;
        }
        //      C# -> List<System.String>? SuccessObjectIds
        // GraphQL -> successObjectIds: [UUID!]! (scalar)
        if (ec.Includes("successObjectIds",true))
        {
            if(this.SuccessObjectIds == null) {

                this.SuccessObjectIds = new List<System.String>();

            } else {


            }
        }
        else if (this.SuccessObjectIds != null && ec.Excludes("successObjectIds",true))
        {
            this.SuccessObjectIds = null;
        }
    }


    #endregion

    } // class ClearCloudNativeSqlServerBackupCredentialsReply
    
    #endregion

    public static class ListClearCloudNativeSqlServerBackupCredentialsReplyExtensions
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
            this List<ClearCloudNativeSqlServerBackupCredentialsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClearCloudNativeSqlServerBackupCredentialsReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClearCloudNativeSqlServerBackupCredentialsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClearCloudNativeSqlServerBackupCredentialsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClearCloudNativeSqlServerBackupCredentialsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types