// AzureNativeVmRecoverySpec.cs
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
    #region AzureNativeVmRecoverySpec
    public class AzureNativeVmRecoverySpec: BaseType
    {
        #region members

        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        [JsonProperty("snapshotType")]
        public SnapshotType? SnapshotType { get; set; }

        //      C# -> System.String? AvailabilitySetNativeId
        // GraphQL -> availabilitySetNativeId: String (scalar)
        [JsonProperty("availabilitySetNativeId")]
        public System.String? AvailabilitySetNativeId { get; set; }

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> System.String? DiskEncryptionSetNativeId
        // GraphQL -> diskEncryptionSetNativeId: String (scalar)
        [JsonProperty("diskEncryptionSetNativeId")]
        public System.String? DiskEncryptionSetNativeId { get; set; }

        //      C# -> System.String? NetworkSecurityGroupNativeId
        // GraphQL -> networkSecurityGroupNativeId: String (scalar)
        [JsonProperty("networkSecurityGroupNativeId")]
        public System.String? NetworkSecurityGroupNativeId { get; set; }

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }

        //      C# -> System.Boolean? ShouldEnableAcceleratedNetworking
        // GraphQL -> shouldEnableAcceleratedNetworking: Boolean! (scalar)
        [JsonProperty("shouldEnableAcceleratedNetworking")]
        public System.Boolean? ShouldEnableAcceleratedNetworking { get; set; }

        //      C# -> System.String? SizeType
        // GraphQL -> sizeType: String! (scalar)
        [JsonProperty("sizeType")]
        public System.String? SizeType { get; set; }

        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        [JsonProperty("subnetNativeId")]
        public System.String? SubnetNativeId { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNativeVmRecoverySpec";
    }

    public AzureNativeVmRecoverySpec Set(
        SnapshotType? SnapshotType = null,
        System.String? AvailabilitySetNativeId = null,
        System.String? AvailabilityZone = null,
        System.String? DiskEncryptionSetNativeId = null,
        System.String? NetworkSecurityGroupNativeId = null,
        System.String? ResourceGroup = null,
        System.Boolean? ShouldEnableAcceleratedNetworking = null,
        System.String? SizeType = null,
        System.String? SubnetNativeId = null,
        System.Int64? Version = null
    ) 
    {
        if ( SnapshotType != null ) {
            this.SnapshotType = SnapshotType;
        }
        if ( AvailabilitySetNativeId != null ) {
            this.AvailabilitySetNativeId = AvailabilitySetNativeId;
        }
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
        }
        if ( DiskEncryptionSetNativeId != null ) {
            this.DiskEncryptionSetNativeId = DiskEncryptionSetNativeId;
        }
        if ( NetworkSecurityGroupNativeId != null ) {
            this.NetworkSecurityGroupNativeId = NetworkSecurityGroupNativeId;
        }
        if ( ResourceGroup != null ) {
            this.ResourceGroup = ResourceGroup;
        }
        if ( ShouldEnableAcceleratedNetworking != null ) {
            this.ShouldEnableAcceleratedNetworking = ShouldEnableAcceleratedNetworking;
        }
        if ( SizeType != null ) {
            this.SizeType = SizeType;
        }
        if ( SubnetNativeId != null ) {
            this.SubnetNativeId = SubnetNativeId;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SnapshotType? SnapshotType
        // GraphQL -> snapshotType: SnapshotType! (enum)
        if (this.SnapshotType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotType\n" ;
            } else {
                s += ind + "snapshotType\n" ;
            }
        }
        //      C# -> System.String? AvailabilitySetNativeId
        // GraphQL -> availabilitySetNativeId: String (scalar)
        if (this.AvailabilitySetNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "availabilitySetNativeId\n" ;
            } else {
                s += ind + "availabilitySetNativeId\n" ;
            }
        }
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "availabilityZone\n" ;
            } else {
                s += ind + "availabilityZone\n" ;
            }
        }
        //      C# -> System.String? DiskEncryptionSetNativeId
        // GraphQL -> diskEncryptionSetNativeId: String (scalar)
        if (this.DiskEncryptionSetNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskEncryptionSetNativeId\n" ;
            } else {
                s += ind + "diskEncryptionSetNativeId\n" ;
            }
        }
        //      C# -> System.String? NetworkSecurityGroupNativeId
        // GraphQL -> networkSecurityGroupNativeId: String (scalar)
        if (this.NetworkSecurityGroupNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkSecurityGroupNativeId\n" ;
            } else {
                s += ind + "networkSecurityGroupNativeId\n" ;
            }
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (this.ResourceGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceGroup\n" ;
            } else {
                s += ind + "resourceGroup\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldEnableAcceleratedNetworking
        // GraphQL -> shouldEnableAcceleratedNetworking: Boolean! (scalar)
        if (this.ShouldEnableAcceleratedNetworking != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldEnableAcceleratedNetworking\n" ;
            } else {
                s += ind + "shouldEnableAcceleratedNetworking\n" ;
            }
        }
        //      C# -> System.String? SizeType
        // GraphQL -> sizeType: String! (scalar)
        if (this.SizeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sizeType\n" ;
            } else {
                s += ind + "sizeType\n" ;
            }
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (this.SubnetNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subnetNativeId\n" ;
            } else {
                s += ind + "subnetNativeId\n" ;
            }
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.String? AvailabilitySetNativeId
        // GraphQL -> availabilitySetNativeId: String (scalar)
        if (ec.Includes("availabilitySetNativeId",true))
        {
            if(this.AvailabilitySetNativeId == null) {

                this.AvailabilitySetNativeId = "FETCH";

            } else {


            }
        }
        else if (this.AvailabilitySetNativeId != null && ec.Excludes("availabilitySetNativeId",true))
        {
            this.AvailabilitySetNativeId = null;
        }
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (ec.Includes("availabilityZone",true))
        {
            if(this.AvailabilityZone == null) {

                this.AvailabilityZone = "FETCH";

            } else {


            }
        }
        else if (this.AvailabilityZone != null && ec.Excludes("availabilityZone",true))
        {
            this.AvailabilityZone = null;
        }
        //      C# -> System.String? DiskEncryptionSetNativeId
        // GraphQL -> diskEncryptionSetNativeId: String (scalar)
        if (ec.Includes("diskEncryptionSetNativeId",true))
        {
            if(this.DiskEncryptionSetNativeId == null) {

                this.DiskEncryptionSetNativeId = "FETCH";

            } else {


            }
        }
        else if (this.DiskEncryptionSetNativeId != null && ec.Excludes("diskEncryptionSetNativeId",true))
        {
            this.DiskEncryptionSetNativeId = null;
        }
        //      C# -> System.String? NetworkSecurityGroupNativeId
        // GraphQL -> networkSecurityGroupNativeId: String (scalar)
        if (ec.Includes("networkSecurityGroupNativeId",true))
        {
            if(this.NetworkSecurityGroupNativeId == null) {

                this.NetworkSecurityGroupNativeId = "FETCH";

            } else {


            }
        }
        else if (this.NetworkSecurityGroupNativeId != null && ec.Excludes("networkSecurityGroupNativeId",true))
        {
            this.NetworkSecurityGroupNativeId = null;
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (ec.Includes("resourceGroup",true))
        {
            if(this.ResourceGroup == null) {

                this.ResourceGroup = "FETCH";

            } else {


            }
        }
        else if (this.ResourceGroup != null && ec.Excludes("resourceGroup",true))
        {
            this.ResourceGroup = null;
        }
        //      C# -> System.Boolean? ShouldEnableAcceleratedNetworking
        // GraphQL -> shouldEnableAcceleratedNetworking: Boolean! (scalar)
        if (ec.Includes("shouldEnableAcceleratedNetworking",true))
        {
            if(this.ShouldEnableAcceleratedNetworking == null) {

                this.ShouldEnableAcceleratedNetworking = true;

            } else {


            }
        }
        else if (this.ShouldEnableAcceleratedNetworking != null && ec.Excludes("shouldEnableAcceleratedNetworking",true))
        {
            this.ShouldEnableAcceleratedNetworking = null;
        }
        //      C# -> System.String? SizeType
        // GraphQL -> sizeType: String! (scalar)
        if (ec.Includes("sizeType",true))
        {
            if(this.SizeType == null) {

                this.SizeType = "FETCH";

            } else {


            }
        }
        else if (this.SizeType != null && ec.Excludes("sizeType",true))
        {
            this.SizeType = null;
        }
        //      C# -> System.String? SubnetNativeId
        // GraphQL -> subnetNativeId: String! (scalar)
        if (ec.Includes("subnetNativeId",true))
        {
            if(this.SubnetNativeId == null) {

                this.SubnetNativeId = "FETCH";

            } else {


            }
        }
        else if (this.SubnetNativeId != null && ec.Excludes("subnetNativeId",true))
        {
            this.SubnetNativeId = null;
        }
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = new System.Int64();

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
    }


    #endregion

    } // class AzureNativeVmRecoverySpec
    
    #endregion

    public static class ListAzureNativeVmRecoverySpecExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureNativeVmRecoverySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureNativeVmRecoverySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeVmRecoverySpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeVmRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeVmRecoverySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types