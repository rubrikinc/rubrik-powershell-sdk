// GetLambdaConfigReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:04.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region GetLambdaConfigReply
    public class GetLambdaConfigReply: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? AccountId
            // GraphQL -> accountId: String! (scalar)
            if (this.AccountId != null)
            {
                 s += ind + "accountId\n";

            }
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: String! (scalar)
            if (this.ClusterId != null)
            {
                 s += ind + "clusterId\n";

            }
            //      C# -> System.String? DefaultDiffFmdUploadPrefix
            // GraphQL -> defaultDiffFmdUploadPrefix: String! (scalar)
            if (this.DefaultDiffFmdUploadPrefix != null)
            {
                 s += ind + "defaultDiffFmdUploadPrefix\n";

            }
            //      C# -> System.Boolean? EnableAutomaticFmdUpload
            // GraphQL -> enableAutomaticFmdUpload: Boolean! (scalar)
            if (this.EnableAutomaticFmdUpload != null)
            {
                 s += ind + "enableAutomaticFmdUpload\n";

            }
            //      C# -> System.Boolean? EnableFmdUploadForAllResources
            // GraphQL -> enableFmdUploadForAllResources: Boolean! (scalar)
            if (this.EnableFmdUploadForAllResources != null)
            {
                 s += ind + "enableFmdUploadForAllResources\n";

            }
            //      C# -> System.Int32? MaxSnapshotsToUploadAutomatically
            // GraphQL -> maxSnapshotsToUploadAutomatically: Int! (scalar)
            if (this.MaxSnapshotsToUploadAutomatically != null)
            {
                 s += ind + "maxSnapshotsToUploadAutomatically\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AccountId
            // GraphQL -> accountId: String! (scalar)
            if (this.AccountId == null && Exploration.Includes(parent + ".accountId$"))
            {
                this.AccountId = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterId
            // GraphQL -> clusterId: String! (scalar)
            if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId$"))
            {
                this.ClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? DefaultDiffFmdUploadPrefix
            // GraphQL -> defaultDiffFmdUploadPrefix: String! (scalar)
            if (this.DefaultDiffFmdUploadPrefix == null && Exploration.Includes(parent + ".defaultDiffFmdUploadPrefix$"))
            {
                this.DefaultDiffFmdUploadPrefix = new System.String("FETCH");
            }
            //      C# -> System.Boolean? EnableAutomaticFmdUpload
            // GraphQL -> enableAutomaticFmdUpload: Boolean! (scalar)
            if (this.EnableAutomaticFmdUpload == null && Exploration.Includes(parent + ".enableAutomaticFmdUpload$"))
            {
                this.EnableAutomaticFmdUpload = new System.Boolean();
            }
            //      C# -> System.Boolean? EnableFmdUploadForAllResources
            // GraphQL -> enableFmdUploadForAllResources: Boolean! (scalar)
            if (this.EnableFmdUploadForAllResources == null && Exploration.Includes(parent + ".enableFmdUploadForAllResources$"))
            {
                this.EnableFmdUploadForAllResources = new System.Boolean();
            }
            //      C# -> System.Int32? MaxSnapshotsToUploadAutomatically
            // GraphQL -> maxSnapshotsToUploadAutomatically: Int! (scalar)
            if (this.MaxSnapshotsToUploadAutomatically == null && Exploration.Includes(parent + ".maxSnapshotsToUploadAutomatically$"))
            {
                this.MaxSnapshotsToUploadAutomatically = new System.Int32();
            }
        }


    #endregion

    } // class GetLambdaConfigReply
    #endregion

    public static class ListGetLambdaConfigReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<GetLambdaConfigReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetLambdaConfigReply> list, 
            String parent = "")
        {
            var item = new GetLambdaConfigReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types