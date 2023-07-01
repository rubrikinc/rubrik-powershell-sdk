// AddCloudNativeSqlServerBackupCredentialsReply.cs
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
    #region AddCloudNativeSqlServerBackupCredentialsReply
    public class AddCloudNativeSqlServerBackupCredentialsReply: BaseType
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
        return "AddCloudNativeSqlServerBackupCredentialsReply";
    }

    public AddCloudNativeSqlServerBackupCredentialsReply Set(
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<System.String>? FailedObjectIds
        // GraphQL -> failedObjectIds: [UUID!]! (scalar)
        if (this.FailedObjectIds != null) {
            s += ind + "failedObjectIds\n" ;
        }
        //      C# -> List<System.String>? SuccessObjectIds
        // GraphQL -> successObjectIds: [UUID!]! (scalar)
        if (this.SuccessObjectIds != null) {
            s += ind + "successObjectIds\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? FailedObjectIds
        // GraphQL -> failedObjectIds: [UUID!]! (scalar)
        if (this.FailedObjectIds == null && Exploration.Includes(parent + ".failedObjectIds", true))
        {
            this.FailedObjectIds = new List<System.String>();
        }
        //      C# -> List<System.String>? SuccessObjectIds
        // GraphQL -> successObjectIds: [UUID!]! (scalar)
        if (this.SuccessObjectIds == null && Exploration.Includes(parent + ".successObjectIds", true))
        {
            this.SuccessObjectIds = new List<System.String>();
        }
    }


    #endregion

    } // class AddCloudNativeSqlServerBackupCredentialsReply
    
    #endregion

    public static class ListAddCloudNativeSqlServerBackupCredentialsReplyExtensions
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
            this List<AddCloudNativeSqlServerBackupCredentialsReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AddCloudNativeSqlServerBackupCredentialsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AddCloudNativeSqlServerBackupCredentialsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types