// CloudNativeSnapshotTypeDetails.cs
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
    #region CloudNativeSnapshotTypeDetails
    public class CloudNativeSnapshotTypeDetails: BaseType
    {
        #region members

        //      C# -> CloudProviderType? CloudType
        // GraphQL -> cloudType: CloudProviderType! (enum)
        [JsonProperty("cloudType")]
        public CloudProviderType? CloudType { get; set; }

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
        [JsonProperty("cloudNativeAccountId")]
        public CloudNativeAccountIdWithName? CloudNativeAccountId { get; set; }

        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        [JsonProperty("snapshotRegion")]
        public CloudNativeRegion? SnapshotRegion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeSnapshotTypeDetails";
    }

    public CloudNativeSnapshotTypeDetails Set(
        CloudProviderType? CloudType = null,
        SnapshotType? SnapshotType = null,
        CloudNativeAccountIdWithName? CloudNativeAccountId = null,
        CloudNativeRegion? SnapshotRegion = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( CloudNativeAccountId != null ) {
            this.CloudNativeAccountId = CloudNativeAccountId;
        }
        if ( SnapshotRegion != null ) {
            this.SnapshotRegion = SnapshotRegion;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CloudProviderType? CloudType
        // GraphQL -> cloudType: CloudProviderType! (enum)
        if (this.CloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudType\n" ;
            } else {
                s += ind + "cloudType\n" ;
            }
        }
        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        if (this.SnapshotType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotType\n" ;
            } else {
                s += ind + "snapshotType\n" ;
            }
        }
        //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
        if (this.CloudNativeAccountId != null) {
            var fspec = this.CloudNativeAccountId.AsFieldSpec(conf.Child("cloudNativeAccountId"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cloudNativeAccountId {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        if (this.SnapshotRegion != null) {
            var fspec = this.SnapshotRegion.AsFieldSpec(conf.Child("snapshotRegion"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotRegion {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudProviderType? CloudType
        // GraphQL -> cloudType: CloudProviderType! (enum)
        if (ec.Includes("cloudType",true))
        {
            if(this.CloudType == null) {

                this.CloudType = new CloudProviderType();

            } else {


            }
        }
        else if (this.CloudType != null && ec.Excludes("cloudType",true))
        {
            this.CloudType = null;
        }
        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        if (ec.Includes("snapshotType",true))
        {
            if(this.SnapshotType == null) {

                this.SnapshotType = new SnapshotType();

            } else {


            }
        }
        else if (this.SnapshotType != null && ec.Excludes("snapshotType",true))
        {
            this.SnapshotType = null;
        }
        //      C# -> CloudNativeAccountIdWithName? CloudNativeAccountId
        // GraphQL -> cloudNativeAccountId: CloudNativeAccountIdWithName (type)
        if (ec.Includes("cloudNativeAccountId",false))
        {
            if(this.CloudNativeAccountId == null) {

                this.CloudNativeAccountId = new CloudNativeAccountIdWithName();
                this.CloudNativeAccountId.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeAccountId"));

            } else {

                this.CloudNativeAccountId.ApplyExploratoryFieldSpec(ec.NewChild("cloudNativeAccountId"));

            }
        }
        else if (this.CloudNativeAccountId != null && ec.Excludes("cloudNativeAccountId",false))
        {
            this.CloudNativeAccountId = null;
        }
        //      C# -> CloudNativeRegion? SnapshotRegion
        // GraphQL -> snapshotRegion: CloudNativeRegion! (type)
        if (ec.Includes("snapshotRegion",false))
        {
            if(this.SnapshotRegion == null) {

                this.SnapshotRegion = new CloudNativeRegion();
                this.SnapshotRegion.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRegion"));

            } else {

                this.SnapshotRegion.ApplyExploratoryFieldSpec(ec.NewChild("snapshotRegion"));

            }
        }
        else if (this.SnapshotRegion != null && ec.Excludes("snapshotRegion",false))
        {
            this.SnapshotRegion = null;
        }
    }


    #endregion

    } // class CloudNativeSnapshotTypeDetails
    
    #endregion

    public static class ListCloudNativeSnapshotTypeDetailsExtensions
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
            this List<CloudNativeSnapshotTypeDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeSnapshotTypeDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeSnapshotTypeDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeSnapshotTypeDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types