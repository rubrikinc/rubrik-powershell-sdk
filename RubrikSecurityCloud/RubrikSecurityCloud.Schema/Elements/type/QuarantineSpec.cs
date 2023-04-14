// QuarantineSpec.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region QuarantineSpec
    public class QuarantineSpec: IFragment
    {
        #region members
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> List<FileDetails>? FilesDetails
        // GraphQL -> filesDetails: [FileDetails!]! (type)
        [JsonProperty("filesDetails")]
        public List<FileDetails>? FilesDetails { get; set; }

        #endregion

    #region methods

    public QuarantineSpec Set(
        System.String? SnapshotId = null,
        List<FileDetails>? FilesDetails = null
    ) 
    {
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( FilesDetails != null ) {
            this.FilesDetails = FilesDetails;
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
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> List<FileDetails>? FilesDetails
            // GraphQL -> filesDetails: [FileDetails!]! (type)
            if (this.FilesDetails != null)
            {
                 s += ind + "filesDetails\n";

                 s += ind + "{\n" + 
                 this.FilesDetails.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: String! (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> List<FileDetails>? FilesDetails
            // GraphQL -> filesDetails: [FileDetails!]! (type)
            if (this.FilesDetails == null && Exploration.Includes(parent + ".filesDetails"))
            {
                this.FilesDetails = new List<FileDetails>();
                this.FilesDetails.ApplyExploratoryFragment(parent + ".filesDetails");
            }
        }


    #endregion

    } // class QuarantineSpec
    #endregion

    public static class ListQuarantineSpecExtensions
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
            this List<QuarantineSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<QuarantineSpec> list, 
            String parent = "")
        {
            var item = new QuarantineSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types