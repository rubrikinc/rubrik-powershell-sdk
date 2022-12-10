// LegalHoldSnapshotDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:02.
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
    #region LegalHoldSnapshotDetail
    public class LegalHoldSnapshotDetail: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LegalHoldTime
        // GraphQL -> legalHoldTime: DateTime (scalar)
        [JsonProperty("legalHoldTime")]
        public DateTime? LegalHoldTime { get; set; }

        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        [JsonProperty("snapshotTime")]
        public DateTime? SnapshotTime { get; set; }

        //      C# -> List<SnapshotCustomization>? Customizations
        // GraphQL -> customizations: [SnapshotCustomization!]! (enum)
        [JsonProperty("customizations")]
        public List<SnapshotCustomization>? Customizations { get; set; }

        //      C# -> SnapshotTypeEnum? Type
        // GraphQL -> type: SnapshotTypeEnum! (enum)
        [JsonProperty("type")]
        public SnapshotTypeEnum? Type { get; set; }

        #endregion

    #region methods

    public LegalHoldSnapshotDetail Set(
        System.String? Id = null,
        DateTime? LegalHoldTime = null,
        DateTime? SnapshotTime = null,
        List<SnapshotCustomization>? Customizations = null,
        SnapshotTypeEnum? Type = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LegalHoldTime != null ) {
            this.LegalHoldTime = LegalHoldTime;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
        }
        if ( Customizations != null ) {
            this.Customizations = Customizations;
        }
        if ( Type != null ) {
            this.Type = Type;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> DateTime? LegalHoldTime
            // GraphQL -> legalHoldTime: DateTime (scalar)
            if (this.LegalHoldTime != null)
            {
                 s += ind + "legalHoldTime\n";

            }
            //      C# -> DateTime? SnapshotTime
            // GraphQL -> snapshotTime: DateTime (scalar)
            if (this.SnapshotTime != null)
            {
                 s += ind + "snapshotTime\n";

            }
            //      C# -> List<SnapshotCustomization>? Customizations
            // GraphQL -> customizations: [SnapshotCustomization!]! (enum)
            if (this.Customizations != null)
            {
                 s += ind + "customizations\n";

            }
            //      C# -> SnapshotTypeEnum? Type
            // GraphQL -> type: SnapshotTypeEnum! (enum)
            if (this.Type != null)
            {
                 s += ind + "type\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> DateTime? LegalHoldTime
            // GraphQL -> legalHoldTime: DateTime (scalar)
            if (this.LegalHoldTime == null && Exploration.Includes(parent + ".legalHoldTime$"))
            {
                this.LegalHoldTime = new DateTime();
            }
            //      C# -> DateTime? SnapshotTime
            // GraphQL -> snapshotTime: DateTime (scalar)
            if (this.SnapshotTime == null && Exploration.Includes(parent + ".snapshotTime$"))
            {
                this.SnapshotTime = new DateTime();
            }
            //      C# -> List<SnapshotCustomization>? Customizations
            // GraphQL -> customizations: [SnapshotCustomization!]! (enum)
            if (this.Customizations == null && Exploration.Includes(parent + ".customizations$"))
            {
                this.Customizations = new List<SnapshotCustomization>();
            }
            //      C# -> SnapshotTypeEnum? Type
            // GraphQL -> type: SnapshotTypeEnum! (enum)
            if (this.Type == null && Exploration.Includes(parent + ".type$"))
            {
                this.Type = new SnapshotTypeEnum();
            }
        }


    #endregion

    } // class LegalHoldSnapshotDetail
    #endregion

    public static class ListLegalHoldSnapshotDetailExtensions
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
            this List<LegalHoldSnapshotDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LegalHoldSnapshotDetail> list, 
            String parent = "")
        {
            var item = new LegalHoldSnapshotDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types