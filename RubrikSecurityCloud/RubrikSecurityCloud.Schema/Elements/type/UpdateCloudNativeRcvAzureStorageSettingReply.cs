// UpdateCloudNativeRcvAzureStorageSettingReply.cs
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
    #region UpdateCloudNativeRcvAzureStorageSettingReply
    public class UpdateCloudNativeRcvAzureStorageSettingReply: BaseType
    {
        #region members

        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping! (type)
        [JsonProperty("targetMapping")]
        public TargetMapping? TargetMapping { get; set; }


        #endregion

    #region methods

    public UpdateCloudNativeRcvAzureStorageSettingReply Set(
        TargetMapping? TargetMapping = null
    ) 
    {
        if ( TargetMapping != null ) {
            this.TargetMapping = TargetMapping;
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
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping! (type)
        if (this.TargetMapping != null) {
            s += ind + "targetMapping {\n" + this.TargetMapping.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping! (type)
        if (this.TargetMapping == null && Exploration.Includes(parent + ".targetMapping"))
        {
            this.TargetMapping = new TargetMapping();
            this.TargetMapping.ApplyExploratoryFieldSpec(parent + ".targetMapping");
        }
    }


    #endregion

    } // class UpdateCloudNativeRcvAzureStorageSettingReply
    
    #endregion

    public static class ListUpdateCloudNativeRcvAzureStorageSettingReplyExtensions
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
            this List<UpdateCloudNativeRcvAzureStorageSettingReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateCloudNativeRcvAzureStorageSettingReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateCloudNativeRcvAzureStorageSettingReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types