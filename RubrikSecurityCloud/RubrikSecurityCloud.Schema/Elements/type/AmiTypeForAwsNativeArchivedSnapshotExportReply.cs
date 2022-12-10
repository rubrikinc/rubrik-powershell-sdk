// AmiTypeForAwsNativeArchivedSnapshotExportReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:11.
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
    #region AmiTypeForAwsNativeArchivedSnapshotExportReply
    public class AmiTypeForAwsNativeArchivedSnapshotExportReply: IFragment
    {
        #region members
        //      C# -> System.String? AmiId
        // GraphQL -> amiId: String! (scalar)
        [JsonProperty("amiId")]
        public System.String? AmiId { get; set; }

        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: String! (scalar)
        [JsonProperty("awsAccountRubrikId")]
        public System.String? AwsAccountRubrikId { get; set; }

        //      C# -> AmiType? AmiType
        // GraphQL -> amiType: AmiType! (enum)
        [JsonProperty("amiType")]
        public AmiType? AmiType { get; set; }

        //      C# -> AwsNativeRegion? RegionNativeId
        // GraphQL -> regionNativeId: AwsNativeRegion! (enum)
        [JsonProperty("regionNativeId")]
        public AwsNativeRegion? RegionNativeId { get; set; }

        #endregion

    #region methods

    public AmiTypeForAwsNativeArchivedSnapshotExportReply Set(
        System.String? AmiId = null,
        System.String? AwsAccountRubrikId = null,
        AmiType? AmiType = null,
        AwsNativeRegion? RegionNativeId = null
    ) 
    {
        if ( AmiId != null ) {
            this.AmiId = AmiId;
        }
        if ( AwsAccountRubrikId != null ) {
            this.AwsAccountRubrikId = AwsAccountRubrikId;
        }
        if ( AmiType != null ) {
            this.AmiType = AmiType;
        }
        if ( RegionNativeId != null ) {
            this.RegionNativeId = RegionNativeId;
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
            //      C# -> System.String? AmiId
            // GraphQL -> amiId: String! (scalar)
            if (this.AmiId != null)
            {
                 s += ind + "amiId\n";

            }
            //      C# -> System.String? AwsAccountRubrikId
            // GraphQL -> awsAccountRubrikId: String! (scalar)
            if (this.AwsAccountRubrikId != null)
            {
                 s += ind + "awsAccountRubrikId\n";

            }
            //      C# -> AmiType? AmiType
            // GraphQL -> amiType: AmiType! (enum)
            if (this.AmiType != null)
            {
                 s += ind + "amiType\n";

            }
            //      C# -> AwsNativeRegion? RegionNativeId
            // GraphQL -> regionNativeId: AwsNativeRegion! (enum)
            if (this.RegionNativeId != null)
            {
                 s += ind + "regionNativeId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AmiId
            // GraphQL -> amiId: String! (scalar)
            if (this.AmiId == null && Exploration.Includes(parent + ".amiId$"))
            {
                this.AmiId = new System.String("FETCH");
            }
            //      C# -> System.String? AwsAccountRubrikId
            // GraphQL -> awsAccountRubrikId: String! (scalar)
            if (this.AwsAccountRubrikId == null && Exploration.Includes(parent + ".awsAccountRubrikId$"))
            {
                this.AwsAccountRubrikId = new System.String("FETCH");
            }
            //      C# -> AmiType? AmiType
            // GraphQL -> amiType: AmiType! (enum)
            if (this.AmiType == null && Exploration.Includes(parent + ".amiType$"))
            {
                this.AmiType = new AmiType();
            }
            //      C# -> AwsNativeRegion? RegionNativeId
            // GraphQL -> regionNativeId: AwsNativeRegion! (enum)
            if (this.RegionNativeId == null && Exploration.Includes(parent + ".regionNativeId$"))
            {
                this.RegionNativeId = new AwsNativeRegion();
            }
        }


    #endregion

    } // class AmiTypeForAwsNativeArchivedSnapshotExportReply
    #endregion

    public static class ListAmiTypeForAwsNativeArchivedSnapshotExportReplyExtensions
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
            this List<AmiTypeForAwsNativeArchivedSnapshotExportReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AmiTypeForAwsNativeArchivedSnapshotExportReply> list, 
            String parent = "")
        {
            var item = new AmiTypeForAwsNativeArchivedSnapshotExportReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types