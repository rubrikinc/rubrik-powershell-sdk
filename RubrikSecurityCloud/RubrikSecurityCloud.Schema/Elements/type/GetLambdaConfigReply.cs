// GetLambdaConfigReply.cs
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
    #region GetLambdaConfigReply
    public class GetLambdaConfigReply: BaseType
    {
        #region members

        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        [JsonProperty("accountId")]
        public System.String? AccountId { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? DefaultDiffFmdUploadPrefix
        // GraphQL -> defaultDiffFmdUploadPrefix: String! (scalar)
        [JsonProperty("defaultDiffFmdUploadPrefix")]
        public System.String? DefaultDiffFmdUploadPrefix { get; set; }

        //      C# -> System.Boolean? EnableAutomaticFmdUpload
        // GraphQL -> enableAutomaticFmdUpload: Boolean! (scalar)
        [JsonProperty("enableAutomaticFmdUpload")]
        public System.Boolean? EnableAutomaticFmdUpload { get; set; }

        //      C# -> System.Boolean? EnableFmdUploadForAllResources
        // GraphQL -> enableFmdUploadForAllResources: Boolean! (scalar)
        [JsonProperty("enableFmdUploadForAllResources")]
        public System.Boolean? EnableFmdUploadForAllResources { get; set; }

        //      C# -> System.Int32? MaxSnapshotsToUploadAutomatically
        // GraphQL -> maxSnapshotsToUploadAutomatically: Int! (scalar)
        [JsonProperty("maxSnapshotsToUploadAutomatically")]
        public System.Int32? MaxSnapshotsToUploadAutomatically { get; set; }


        #endregion

    #region methods

    public GetLambdaConfigReply Set(
        System.String? AccountId = null,
        System.String? ClusterId = null,
        System.String? DefaultDiffFmdUploadPrefix = null,
        System.Boolean? EnableAutomaticFmdUpload = null,
        System.Boolean? EnableFmdUploadForAllResources = null,
        System.Int32? MaxSnapshotsToUploadAutomatically = null
    ) 
    {
        if ( AccountId != null ) {
            this.AccountId = AccountId;
        }
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( DefaultDiffFmdUploadPrefix != null ) {
            this.DefaultDiffFmdUploadPrefix = DefaultDiffFmdUploadPrefix;
        }
        if ( EnableAutomaticFmdUpload != null ) {
            this.EnableAutomaticFmdUpload = EnableAutomaticFmdUpload;
        }
        if ( EnableFmdUploadForAllResources != null ) {
            this.EnableFmdUploadForAllResources = EnableFmdUploadForAllResources;
        }
        if ( MaxSnapshotsToUploadAutomatically != null ) {
            this.MaxSnapshotsToUploadAutomatically = MaxSnapshotsToUploadAutomatically;
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
        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        if (this.AccountId != null) {
            s += ind + "accountId\n" ;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (this.ClusterId != null) {
            s += ind + "clusterId\n" ;
        }
        //      C# -> System.String? DefaultDiffFmdUploadPrefix
        // GraphQL -> defaultDiffFmdUploadPrefix: String! (scalar)
        if (this.DefaultDiffFmdUploadPrefix != null) {
            s += ind + "defaultDiffFmdUploadPrefix\n" ;
        }
        //      C# -> System.Boolean? EnableAutomaticFmdUpload
        // GraphQL -> enableAutomaticFmdUpload: Boolean! (scalar)
        if (this.EnableAutomaticFmdUpload != null) {
            s += ind + "enableAutomaticFmdUpload\n" ;
        }
        //      C# -> System.Boolean? EnableFmdUploadForAllResources
        // GraphQL -> enableFmdUploadForAllResources: Boolean! (scalar)
        if (this.EnableFmdUploadForAllResources != null) {
            s += ind + "enableFmdUploadForAllResources\n" ;
        }
        //      C# -> System.Int32? MaxSnapshotsToUploadAutomatically
        // GraphQL -> maxSnapshotsToUploadAutomatically: Int! (scalar)
        if (this.MaxSnapshotsToUploadAutomatically != null) {
            s += ind + "maxSnapshotsToUploadAutomatically\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        if (this.AccountId == null && Exploration.Includes(parent + ".accountId", true))
        {
            this.AccountId = "FETCH";
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: String! (scalar)
        if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId", true))
        {
            this.ClusterId = "FETCH";
        }
        //      C# -> System.String? DefaultDiffFmdUploadPrefix
        // GraphQL -> defaultDiffFmdUploadPrefix: String! (scalar)
        if (this.DefaultDiffFmdUploadPrefix == null && Exploration.Includes(parent + ".defaultDiffFmdUploadPrefix", true))
        {
            this.DefaultDiffFmdUploadPrefix = "FETCH";
        }
        //      C# -> System.Boolean? EnableAutomaticFmdUpload
        // GraphQL -> enableAutomaticFmdUpload: Boolean! (scalar)
        if (this.EnableAutomaticFmdUpload == null && Exploration.Includes(parent + ".enableAutomaticFmdUpload", true))
        {
            this.EnableAutomaticFmdUpload = true;
        }
        //      C# -> System.Boolean? EnableFmdUploadForAllResources
        // GraphQL -> enableFmdUploadForAllResources: Boolean! (scalar)
        if (this.EnableFmdUploadForAllResources == null && Exploration.Includes(parent + ".enableFmdUploadForAllResources", true))
        {
            this.EnableFmdUploadForAllResources = true;
        }
        //      C# -> System.Int32? MaxSnapshotsToUploadAutomatically
        // GraphQL -> maxSnapshotsToUploadAutomatically: Int! (scalar)
        if (this.MaxSnapshotsToUploadAutomatically == null && Exploration.Includes(parent + ".maxSnapshotsToUploadAutomatically", true))
        {
            this.MaxSnapshotsToUploadAutomatically = Int32.MinValue;
        }
    }


    #endregion

    } // class GetLambdaConfigReply
    
    #endregion

    public static class ListGetLambdaConfigReplyExtensions
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
            this List<GetLambdaConfigReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetLambdaConfigReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetLambdaConfigReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types