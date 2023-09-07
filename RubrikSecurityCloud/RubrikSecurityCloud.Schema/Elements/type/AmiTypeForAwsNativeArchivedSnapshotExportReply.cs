// AmiTypeForAwsNativeArchivedSnapshotExportReply.cs
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
    #region AmiTypeForAwsNativeArchivedSnapshotExportReply
    public class AmiTypeForAwsNativeArchivedSnapshotExportReply: BaseType
    {
        #region members

        //      C# -> AmiType? AmiType
        // GraphQL -> amiType: AmiType! (enum)
        [JsonProperty("amiType")]
        public AmiType? AmiType { get; set; }

        //      C# -> AwsNativeRegion? RegionNativeId
        // GraphQL -> regionNativeId: AwsNativeRegion! (enum)
        [JsonProperty("regionNativeId")]
        public AwsNativeRegion? RegionNativeId { get; set; }

        //      C# -> System.String? AmiId
        // GraphQL -> amiId: String! (scalar)
        [JsonProperty("amiId")]
        public System.String? AmiId { get; set; }

        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: String! (scalar)
        [JsonProperty("awsAccountRubrikId")]
        public System.String? AwsAccountRubrikId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AmiTypeForAwsNativeArchivedSnapshotExportReply";
    }

    public AmiTypeForAwsNativeArchivedSnapshotExportReply Set(
        AmiType? AmiType = null,
        AwsNativeRegion? RegionNativeId = null,
        System.String? AmiId = null,
        System.String? AwsAccountRubrikId = null
    ) 
    {
        if ( AmiType != null ) {
            this.AmiType = AmiType;
        }
        if ( RegionNativeId != null ) {
            this.RegionNativeId = RegionNativeId;
        }
        if ( AmiId != null ) {
            this.AmiId = AmiId;
        }
        if ( AwsAccountRubrikId != null ) {
            this.AwsAccountRubrikId = AwsAccountRubrikId;
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
        //      C# -> AmiType? AmiType
        // GraphQL -> amiType: AmiType! (enum)
        if (this.AmiType != null) {
            s += ind + "amiType\n" ;
        }
        //      C# -> AwsNativeRegion? RegionNativeId
        // GraphQL -> regionNativeId: AwsNativeRegion! (enum)
        if (this.RegionNativeId != null) {
            s += ind + "regionNativeId\n" ;
        }
        //      C# -> System.String? AmiId
        // GraphQL -> amiId: String! (scalar)
        if (this.AmiId != null) {
            s += ind + "amiId\n" ;
        }
        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: String! (scalar)
        if (this.AwsAccountRubrikId != null) {
            s += ind + "awsAccountRubrikId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AmiType? AmiType
        // GraphQL -> amiType: AmiType! (enum)
        if (this.AmiType == null && ec.Includes("amiType",true))
        {
            this.AmiType = new AmiType();
        }
        //      C# -> AwsNativeRegion? RegionNativeId
        // GraphQL -> regionNativeId: AwsNativeRegion! (enum)
        if (this.RegionNativeId == null && ec.Includes("regionNativeId",true))
        {
            this.RegionNativeId = new AwsNativeRegion();
        }
        //      C# -> System.String? AmiId
        // GraphQL -> amiId: String! (scalar)
        if (this.AmiId == null && ec.Includes("amiId",true))
        {
            this.AmiId = "FETCH";
        }
        //      C# -> System.String? AwsAccountRubrikId
        // GraphQL -> awsAccountRubrikId: String! (scalar)
        if (this.AwsAccountRubrikId == null && ec.Includes("awsAccountRubrikId",true))
        {
            this.AwsAccountRubrikId = "FETCH";
        }
    }


    #endregion

    } // class AmiTypeForAwsNativeArchivedSnapshotExportReply
    
    #endregion

    public static class ListAmiTypeForAwsNativeArchivedSnapshotExportReplyExtensions
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
            this List<AmiTypeForAwsNativeArchivedSnapshotExportReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AmiTypeForAwsNativeArchivedSnapshotExportReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AmiTypeForAwsNativeArchivedSnapshotExportReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AmiTypeForAwsNativeArchivedSnapshotExportReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types