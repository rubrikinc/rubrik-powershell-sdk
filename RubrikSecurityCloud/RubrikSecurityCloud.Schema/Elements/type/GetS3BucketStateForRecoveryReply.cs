// GetS3BucketStateForRecoveryReply.cs
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
    #region GetS3BucketStateForRecoveryReply
    public class GetS3BucketStateForRecoveryReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsObjectAclEnabled
        // GraphQL -> isObjectAclEnabled: Boolean! (scalar)
        [JsonProperty("isObjectAclEnabled")]
        public System.Boolean? IsObjectAclEnabled { get; set; }

        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        [JsonProperty("isVersioningEnabled")]
        public System.Boolean? IsVersioningEnabled { get; set; }


        #endregion

    #region methods

    public GetS3BucketStateForRecoveryReply Set(
        System.Boolean? IsObjectAclEnabled = null,
        System.Boolean? IsVersioningEnabled = null
    ) 
    {
        if ( IsObjectAclEnabled != null ) {
            this.IsObjectAclEnabled = IsObjectAclEnabled;
        }
        if ( IsVersioningEnabled != null ) {
            this.IsVersioningEnabled = IsVersioningEnabled;
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
        //      C# -> System.Boolean? IsObjectAclEnabled
        // GraphQL -> isObjectAclEnabled: Boolean! (scalar)
        if (this.IsObjectAclEnabled != null) {
            s += ind + "isObjectAclEnabled\n" ;
        }
        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        if (this.IsVersioningEnabled != null) {
            s += ind + "isVersioningEnabled\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsObjectAclEnabled
        // GraphQL -> isObjectAclEnabled: Boolean! (scalar)
        if (this.IsObjectAclEnabled == null && Exploration.Includes(parent + ".isObjectAclEnabled", true))
        {
            this.IsObjectAclEnabled = true;
        }
        //      C# -> System.Boolean? IsVersioningEnabled
        // GraphQL -> isVersioningEnabled: Boolean! (scalar)
        if (this.IsVersioningEnabled == null && Exploration.Includes(parent + ".isVersioningEnabled", true))
        {
            this.IsVersioningEnabled = true;
        }
    }


    #endregion

    } // class GetS3BucketStateForRecoveryReply
    
    #endregion

    public static class ListGetS3BucketStateForRecoveryReplyExtensions
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
            this List<GetS3BucketStateForRecoveryReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetS3BucketStateForRecoveryReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetS3BucketStateForRecoveryReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types