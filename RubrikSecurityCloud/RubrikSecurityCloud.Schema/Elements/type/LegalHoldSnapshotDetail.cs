// LegalHoldSnapshotDetail.cs
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
    #region LegalHoldSnapshotDetail
    public class LegalHoldSnapshotDetail: BaseType
    {
        #region members

        //      C# -> List<SnapshotCustomization>? Customizations
        // GraphQL -> customizations: [SnapshotCustomization!]! (enum)
        [JsonProperty("customizations")]
        public List<SnapshotCustomization>? Customizations { get; set; }

        //      C# -> SnapshotTypeEnum? Type
        // GraphQL -> type: SnapshotTypeEnum! (enum)
        [JsonProperty("type")]
        public SnapshotTypeEnum? Type { get; set; }

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


        #endregion

    #region methods

    public LegalHoldSnapshotDetail Set(
        List<SnapshotCustomization>? Customizations = null,
        SnapshotTypeEnum? Type = null,
        System.String? Id = null,
        DateTime? LegalHoldTime = null,
        DateTime? SnapshotTime = null
    ) 
    {
        if ( Customizations != null ) {
            this.Customizations = Customizations;
        }
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LegalHoldTime != null ) {
            this.LegalHoldTime = LegalHoldTime;
        }
        if ( SnapshotTime != null ) {
            this.SnapshotTime = SnapshotTime;
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
        //      C# -> List<SnapshotCustomization>? Customizations
        // GraphQL -> customizations: [SnapshotCustomization!]! (enum)
        if (this.Customizations != null) {
            s += ind + "customizations\n" ;
        }
        //      C# -> SnapshotTypeEnum? Type
        // GraphQL -> type: SnapshotTypeEnum! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? LegalHoldTime
        // GraphQL -> legalHoldTime: DateTime (scalar)
        if (this.LegalHoldTime != null) {
            s += ind + "legalHoldTime\n" ;
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime != null) {
            s += ind + "snapshotTime\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<SnapshotCustomization>? Customizations
        // GraphQL -> customizations: [SnapshotCustomization!]! (enum)
        if (this.Customizations == null && Exploration.Includes(parent + ".customizations", true))
        {
            this.Customizations = new List<SnapshotCustomization>();
        }
        //      C# -> SnapshotTypeEnum? Type
        // GraphQL -> type: SnapshotTypeEnum! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new SnapshotTypeEnum();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> DateTime? LegalHoldTime
        // GraphQL -> legalHoldTime: DateTime (scalar)
        if (this.LegalHoldTime == null && Exploration.Includes(parent + ".legalHoldTime", true))
        {
            this.LegalHoldTime = new DateTime();
        }
        //      C# -> DateTime? SnapshotTime
        // GraphQL -> snapshotTime: DateTime (scalar)
        if (this.SnapshotTime == null && Exploration.Includes(parent + ".snapshotTime", true))
        {
            this.SnapshotTime = new DateTime();
        }
    }


    #endregion

    } // class LegalHoldSnapshotDetail
    
    #endregion

    public static class ListLegalHoldSnapshotDetailExtensions
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
            this List<LegalHoldSnapshotDetail> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<LegalHoldSnapshotDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new LegalHoldSnapshotDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types