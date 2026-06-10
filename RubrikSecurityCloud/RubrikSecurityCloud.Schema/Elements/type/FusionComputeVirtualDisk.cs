// FusionComputeVirtualDisk.cs
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
    #region FusionComputeVirtualDisk
    public class FusionComputeVirtualDisk: BaseType
    {
        #region members

        //      C# -> System.String? DatastoreUrn
        // GraphQL -> datastoreUrn: String! (scalar)
        [JsonProperty("datastoreUrn")]
        public System.String? DatastoreUrn { get; set; }

        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        [JsonProperty("diskName")]
        public System.String? DiskName { get; set; }

        //      C# -> System.Boolean? IndepDisk
        // GraphQL -> indepDisk: Boolean! (scalar)
        [JsonProperty("indepDisk")]
        public System.Boolean? IndepDisk { get; set; }

        //      C# -> System.Boolean? IsThin
        // GraphQL -> isThin: Boolean! (scalar)
        [JsonProperty("isThin")]
        public System.Boolean? IsThin { get; set; }

        //      C# -> System.Int64? QuantityGb
        // GraphQL -> quantityGb: Long! (scalar)
        [JsonProperty("quantityGb")]
        public System.Int64? QuantityGb { get; set; }

        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        [JsonProperty("sequenceNum")]
        public System.Int32? SequenceNum { get; set; }

        //      C# -> System.String? VolumeUrl
        // GraphQL -> volumeUrl: String! (scalar)
        [JsonProperty("volumeUrl")]
        public System.String? VolumeUrl { get; set; }

        //      C# -> System.String? VolumeUrn
        // GraphQL -> volumeUrn: String! (scalar)
        [JsonProperty("volumeUrn")]
        public System.String? VolumeUrn { get; set; }

        //      C# -> System.String? VolumeUuid
        // GraphQL -> volumeUuid: String! (scalar)
        [JsonProperty("volumeUuid")]
        public System.String? VolumeUuid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FusionComputeVirtualDisk";
    }

    public FusionComputeVirtualDisk Set(
        System.String? DatastoreUrn = null,
        System.String? DiskName = null,
        System.Boolean? IndepDisk = null,
        System.Boolean? IsThin = null,
        System.Int64? QuantityGb = null,
        System.Int32? SequenceNum = null,
        System.String? VolumeUrl = null,
        System.String? VolumeUrn = null,
        System.String? VolumeUuid = null
    ) 
    {
        if ( DatastoreUrn != null ) {
            this.DatastoreUrn = DatastoreUrn;
        }
        if ( DiskName != null ) {
            this.DiskName = DiskName;
        }
        if ( IndepDisk != null ) {
            this.IndepDisk = IndepDisk;
        }
        if ( IsThin != null ) {
            this.IsThin = IsThin;
        }
        if ( QuantityGb != null ) {
            this.QuantityGb = QuantityGb;
        }
        if ( SequenceNum != null ) {
            this.SequenceNum = SequenceNum;
        }
        if ( VolumeUrl != null ) {
            this.VolumeUrl = VolumeUrl;
        }
        if ( VolumeUrn != null ) {
            this.VolumeUrn = VolumeUrn;
        }
        if ( VolumeUuid != null ) {
            this.VolumeUuid = VolumeUuid;
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
        //      C# -> System.String? DatastoreUrn
        // GraphQL -> datastoreUrn: String! (scalar)
        if (this.DatastoreUrn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datastoreUrn\n" ;
            } else {
                s += ind + "datastoreUrn\n" ;
            }
        }
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (this.DiskName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskName\n" ;
            } else {
                s += ind + "diskName\n" ;
            }
        }
        //      C# -> System.Boolean? IndepDisk
        // GraphQL -> indepDisk: Boolean! (scalar)
        if (this.IndepDisk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "indepDisk\n" ;
            } else {
                s += ind + "indepDisk\n" ;
            }
        }
        //      C# -> System.Boolean? IsThin
        // GraphQL -> isThin: Boolean! (scalar)
        if (this.IsThin != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isThin\n" ;
            } else {
                s += ind + "isThin\n" ;
            }
        }
        //      C# -> System.Int64? QuantityGb
        // GraphQL -> quantityGb: Long! (scalar)
        if (this.QuantityGb != null) {
            if (conf.Flat) {
                s += conf.Prefix + "quantityGb\n" ;
            } else {
                s += ind + "quantityGb\n" ;
            }
        }
        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        if (this.SequenceNum != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sequenceNum\n" ;
            } else {
                s += ind + "sequenceNum\n" ;
            }
        }
        //      C# -> System.String? VolumeUrl
        // GraphQL -> volumeUrl: String! (scalar)
        if (this.VolumeUrl != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeUrl\n" ;
            } else {
                s += ind + "volumeUrl\n" ;
            }
        }
        //      C# -> System.String? VolumeUrn
        // GraphQL -> volumeUrn: String! (scalar)
        if (this.VolumeUrn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeUrn\n" ;
            } else {
                s += ind + "volumeUrn\n" ;
            }
        }
        //      C# -> System.String? VolumeUuid
        // GraphQL -> volumeUuid: String! (scalar)
        if (this.VolumeUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "volumeUuid\n" ;
            } else {
                s += ind + "volumeUuid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DatastoreUrn
        // GraphQL -> datastoreUrn: String! (scalar)
        if (ec.Includes("datastoreUrn",true))
        {
            if(this.DatastoreUrn == null) {

                this.DatastoreUrn = "FETCH";

            } else {


            }
        }
        else if (this.DatastoreUrn != null && ec.Excludes("datastoreUrn",true))
        {
            this.DatastoreUrn = null;
        }
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (ec.Includes("diskName",true))
        {
            if(this.DiskName == null) {

                this.DiskName = "FETCH";

            } else {


            }
        }
        else if (this.DiskName != null && ec.Excludes("diskName",true))
        {
            this.DiskName = null;
        }
        //      C# -> System.Boolean? IndepDisk
        // GraphQL -> indepDisk: Boolean! (scalar)
        if (ec.Includes("indepDisk",true))
        {
            if(this.IndepDisk == null) {

                this.IndepDisk = true;

            } else {


            }
        }
        else if (this.IndepDisk != null && ec.Excludes("indepDisk",true))
        {
            this.IndepDisk = null;
        }
        //      C# -> System.Boolean? IsThin
        // GraphQL -> isThin: Boolean! (scalar)
        if (ec.Includes("isThin",true))
        {
            if(this.IsThin == null) {

                this.IsThin = true;

            } else {


            }
        }
        else if (this.IsThin != null && ec.Excludes("isThin",true))
        {
            this.IsThin = null;
        }
        //      C# -> System.Int64? QuantityGb
        // GraphQL -> quantityGb: Long! (scalar)
        if (ec.Includes("quantityGb",true))
        {
            if(this.QuantityGb == null) {

                this.QuantityGb = new System.Int64();

            } else {


            }
        }
        else if (this.QuantityGb != null && ec.Excludes("quantityGb",true))
        {
            this.QuantityGb = null;
        }
        //      C# -> System.Int32? SequenceNum
        // GraphQL -> sequenceNum: Int! (scalar)
        if (ec.Includes("sequenceNum",true))
        {
            if(this.SequenceNum == null) {

                this.SequenceNum = Int32.MinValue;

            } else {


            }
        }
        else if (this.SequenceNum != null && ec.Excludes("sequenceNum",true))
        {
            this.SequenceNum = null;
        }
        //      C# -> System.String? VolumeUrl
        // GraphQL -> volumeUrl: String! (scalar)
        if (ec.Includes("volumeUrl",true))
        {
            if(this.VolumeUrl == null) {

                this.VolumeUrl = "FETCH";

            } else {


            }
        }
        else if (this.VolumeUrl != null && ec.Excludes("volumeUrl",true))
        {
            this.VolumeUrl = null;
        }
        //      C# -> System.String? VolumeUrn
        // GraphQL -> volumeUrn: String! (scalar)
        if (ec.Includes("volumeUrn",true))
        {
            if(this.VolumeUrn == null) {

                this.VolumeUrn = "FETCH";

            } else {


            }
        }
        else if (this.VolumeUrn != null && ec.Excludes("volumeUrn",true))
        {
            this.VolumeUrn = null;
        }
        //      C# -> System.String? VolumeUuid
        // GraphQL -> volumeUuid: String! (scalar)
        if (ec.Includes("volumeUuid",true))
        {
            if(this.VolumeUuid == null) {

                this.VolumeUuid = "FETCH";

            } else {


            }
        }
        else if (this.VolumeUuid != null && ec.Excludes("volumeUuid",true))
        {
            this.VolumeUuid = null;
        }
    }


    #endregion

    } // class FusionComputeVirtualDisk
    
    #endregion

    public static class ListFusionComputeVirtualDiskExtensions
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
            this List<FusionComputeVirtualDisk> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<FusionComputeVirtualDisk> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FusionComputeVirtualDisk> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FusionComputeVirtualDisk());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FusionComputeVirtualDisk> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types