// IdentityDataLocationEncryptionInfo.cs
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
    #region IdentityDataLocationEncryptionInfo
    public class IdentityDataLocationEncryptionInfo: BaseType
    {
        #region members

        //      C# -> EncryptionType? EncryptionType
        // GraphQL -> encryptionType: EncryptionType! (enum)
        [JsonProperty("encryptionType")]
        public EncryptionType? EncryptionType { get; set; }

        //      C# -> IdentityWorkloadType? WorkloadType
        // GraphQL -> workloadType: IdentityWorkloadType! (enum)
        [JsonProperty("workloadType")]
        public IdentityWorkloadType? WorkloadType { get; set; }

        //      C# -> System.String? Cipher
        // GraphQL -> cipher: String! (scalar)
        [JsonProperty("cipher")]
        public System.String? Cipher { get; set; }

        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        [JsonProperty("keyName")]
        public System.String? KeyName { get; set; }

        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String! (scalar)
        [JsonProperty("keyVaultName")]
        public System.String? KeyVaultName { get; set; }

        //      C# -> System.String? KeyVersion
        // GraphQL -> keyVersion: String! (scalar)
        [JsonProperty("keyVersion")]
        public System.String? KeyVersion { get; set; }

        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        [JsonProperty("locationName")]
        public System.String? LocationName { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "IdentityDataLocationEncryptionInfo";
    }

    public IdentityDataLocationEncryptionInfo Set(
        EncryptionType? EncryptionType = null,
        IdentityWorkloadType? WorkloadType = null,
        System.String? Cipher = null,
        System.String? KeyName = null,
        System.String? KeyVaultName = null,
        System.String? KeyVersion = null,
        System.String? LocationName = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( EncryptionType != null ) {
            this.EncryptionType = EncryptionType;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
        }
        if ( Cipher != null ) {
            this.Cipher = Cipher;
        }
        if ( KeyName != null ) {
            this.KeyName = KeyName;
        }
        if ( KeyVaultName != null ) {
            this.KeyVaultName = KeyVaultName;
        }
        if ( KeyVersion != null ) {
            this.KeyVersion = KeyVersion;
        }
        if ( LocationName != null ) {
            this.LocationName = LocationName;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
        //      C# -> EncryptionType? EncryptionType
        // GraphQL -> encryptionType: EncryptionType! (enum)
        if (this.EncryptionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptionType\n" ;
            } else {
                s += ind + "encryptionType\n" ;
            }
        }
        //      C# -> IdentityWorkloadType? WorkloadType
        // GraphQL -> workloadType: IdentityWorkloadType! (enum)
        if (this.WorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadType\n" ;
            } else {
                s += ind + "workloadType\n" ;
            }
        }
        //      C# -> System.String? Cipher
        // GraphQL -> cipher: String! (scalar)
        if (this.Cipher != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cipher\n" ;
            } else {
                s += ind + "cipher\n" ;
            }
        }
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (this.KeyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyName\n" ;
            } else {
                s += ind + "keyName\n" ;
            }
        }
        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String! (scalar)
        if (this.KeyVaultName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyVaultName\n" ;
            } else {
                s += ind + "keyVaultName\n" ;
            }
        }
        //      C# -> System.String? KeyVersion
        // GraphQL -> keyVersion: String! (scalar)
        if (this.KeyVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyVersion\n" ;
            } else {
                s += ind + "keyVersion\n" ;
            }
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (this.LocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationName\n" ;
            } else {
                s += ind + "locationName\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> EncryptionType? EncryptionType
        // GraphQL -> encryptionType: EncryptionType! (enum)
        if (ec.Includes("encryptionType",true))
        {
            if(this.EncryptionType == null) {

                this.EncryptionType = new EncryptionType();

            } else {


            }
        }
        else if (this.EncryptionType != null && ec.Excludes("encryptionType",true))
        {
            this.EncryptionType = null;
        }
        //      C# -> IdentityWorkloadType? WorkloadType
        // GraphQL -> workloadType: IdentityWorkloadType! (enum)
        if (ec.Includes("workloadType",true))
        {
            if(this.WorkloadType == null) {

                this.WorkloadType = new IdentityWorkloadType();

            } else {


            }
        }
        else if (this.WorkloadType != null && ec.Excludes("workloadType",true))
        {
            this.WorkloadType = null;
        }
        //      C# -> System.String? Cipher
        // GraphQL -> cipher: String! (scalar)
        if (ec.Includes("cipher",true))
        {
            if(this.Cipher == null) {

                this.Cipher = "FETCH";

            } else {


            }
        }
        else if (this.Cipher != null && ec.Excludes("cipher",true))
        {
            this.Cipher = null;
        }
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (ec.Includes("keyName",true))
        {
            if(this.KeyName == null) {

                this.KeyName = "FETCH";

            } else {


            }
        }
        else if (this.KeyName != null && ec.Excludes("keyName",true))
        {
            this.KeyName = null;
        }
        //      C# -> System.String? KeyVaultName
        // GraphQL -> keyVaultName: String! (scalar)
        if (ec.Includes("keyVaultName",true))
        {
            if(this.KeyVaultName == null) {

                this.KeyVaultName = "FETCH";

            } else {


            }
        }
        else if (this.KeyVaultName != null && ec.Excludes("keyVaultName",true))
        {
            this.KeyVaultName = null;
        }
        //      C# -> System.String? KeyVersion
        // GraphQL -> keyVersion: String! (scalar)
        if (ec.Includes("keyVersion",true))
        {
            if(this.KeyVersion == null) {

                this.KeyVersion = "FETCH";

            } else {


            }
        }
        else if (this.KeyVersion != null && ec.Excludes("keyVersion",true))
        {
            this.KeyVersion = null;
        }
        //      C# -> System.String? LocationName
        // GraphQL -> locationName: String! (scalar)
        if (ec.Includes("locationName",true))
        {
            if(this.LocationName == null) {

                this.LocationName = "FETCH";

            } else {


            }
        }
        else if (this.LocationName != null && ec.Excludes("locationName",true))
        {
            this.LocationName = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
        }
    }


    #endregion

    } // class IdentityDataLocationEncryptionInfo
    
    #endregion

    public static class ListIdentityDataLocationEncryptionInfoExtensions
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
            this List<IdentityDataLocationEncryptionInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<IdentityDataLocationEncryptionInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<IdentityDataLocationEncryptionInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new IdentityDataLocationEncryptionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<IdentityDataLocationEncryptionInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types