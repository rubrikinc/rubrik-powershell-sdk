// HpeVmeResourceSpec.cs
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
    #region HpeVmeResourceSpec
    public class HpeVmeResourceSpec: BaseType
    {
        #region members

        //      C# -> System.Int64? CoresPerSocket
        // GraphQL -> coresPerSocket: Long (scalar)
        [JsonProperty("coresPerSocket")]
        public System.Int64? CoresPerSocket { get; set; }

        //      C# -> System.String? InstanceTypeCode
        // GraphQL -> instanceTypeCode: String (scalar)
        [JsonProperty("instanceTypeCode")]
        public System.String? InstanceTypeCode { get; set; }

        //      C# -> System.String? LayoutCode
        // GraphQL -> layoutCode: String (scalar)
        [JsonProperty("layoutCode")]
        public System.String? LayoutCode { get; set; }

        //      C# -> System.Int64? LayoutId
        // GraphQL -> layoutId: Long (scalar)
        [JsonProperty("layoutId")]
        public System.Int64? LayoutId { get; set; }

        //      C# -> System.Int64? MaxCores
        // GraphQL -> maxCores: Long (scalar)
        [JsonProperty("maxCores")]
        public System.Int64? MaxCores { get; set; }

        //      C# -> System.Int64? MaxMemoryBytes
        // GraphQL -> maxMemoryBytes: Long (scalar)
        [JsonProperty("maxMemoryBytes")]
        public System.Int64? MaxMemoryBytes { get; set; }

        //      C# -> List<System.Int64>? NetworkIds
        // GraphQL -> networkIds: [Long!] (scalar)
        [JsonProperty("networkIds")]
        public List<System.Int64>? NetworkIds { get; set; }

        //      C# -> System.Int64? OsId
        // GraphQL -> osId: Long (scalar)
        [JsonProperty("osId")]
        public System.Int64? OsId { get; set; }

        //      C# -> System.String? OsType
        // GraphQL -> osType: String (scalar)
        [JsonProperty("osType")]
        public System.String? OsType { get; set; }

        //      C# -> System.String? PlanCode
        // GraphQL -> planCode: String (scalar)
        [JsonProperty("planCode")]
        public System.String? PlanCode { get; set; }

        //      C# -> System.Int64? PlanId
        // GraphQL -> planId: Long (scalar)
        [JsonProperty("planId")]
        public System.Int64? PlanId { get; set; }

        //      C# -> System.String? Platform
        // GraphQL -> platform: String (scalar)
        [JsonProperty("platform")]
        public System.String? Platform { get; set; }

        //      C# -> System.Int64? SourceImageId
        // GraphQL -> sourceImageId: Long (scalar)
        [JsonProperty("sourceImageId")]
        public System.Int64? SourceImageId { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HpeVmeResourceSpec";
    }

    public HpeVmeResourceSpec Set(
        System.Int64? CoresPerSocket = null,
        System.String? InstanceTypeCode = null,
        System.String? LayoutCode = null,
        System.Int64? LayoutId = null,
        System.Int64? MaxCores = null,
        System.Int64? MaxMemoryBytes = null,
        List<System.Int64>? NetworkIds = null,
        System.Int64? OsId = null,
        System.String? OsType = null,
        System.String? PlanCode = null,
        System.Int64? PlanId = null,
        System.String? Platform = null,
        System.Int64? SourceImageId = null,
        System.String? Version = null
    ) 
    {
        if ( CoresPerSocket != null ) {
            this.CoresPerSocket = CoresPerSocket;
        }
        if ( InstanceTypeCode != null ) {
            this.InstanceTypeCode = InstanceTypeCode;
        }
        if ( LayoutCode != null ) {
            this.LayoutCode = LayoutCode;
        }
        if ( LayoutId != null ) {
            this.LayoutId = LayoutId;
        }
        if ( MaxCores != null ) {
            this.MaxCores = MaxCores;
        }
        if ( MaxMemoryBytes != null ) {
            this.MaxMemoryBytes = MaxMemoryBytes;
        }
        if ( NetworkIds != null ) {
            this.NetworkIds = NetworkIds;
        }
        if ( OsId != null ) {
            this.OsId = OsId;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( PlanCode != null ) {
            this.PlanCode = PlanCode;
        }
        if ( PlanId != null ) {
            this.PlanId = PlanId;
        }
        if ( Platform != null ) {
            this.Platform = Platform;
        }
        if ( SourceImageId != null ) {
            this.SourceImageId = SourceImageId;
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
        //      C# -> System.Int64? CoresPerSocket
        // GraphQL -> coresPerSocket: Long (scalar)
        if (this.CoresPerSocket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "coresPerSocket\n" ;
            } else {
                s += ind + "coresPerSocket\n" ;
            }
        }
        //      C# -> System.String? InstanceTypeCode
        // GraphQL -> instanceTypeCode: String (scalar)
        if (this.InstanceTypeCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceTypeCode\n" ;
            } else {
                s += ind + "instanceTypeCode\n" ;
            }
        }
        //      C# -> System.String? LayoutCode
        // GraphQL -> layoutCode: String (scalar)
        if (this.LayoutCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "layoutCode\n" ;
            } else {
                s += ind + "layoutCode\n" ;
            }
        }
        //      C# -> System.Int64? LayoutId
        // GraphQL -> layoutId: Long (scalar)
        if (this.LayoutId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "layoutId\n" ;
            } else {
                s += ind + "layoutId\n" ;
            }
        }
        //      C# -> System.Int64? MaxCores
        // GraphQL -> maxCores: Long (scalar)
        if (this.MaxCores != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxCores\n" ;
            } else {
                s += ind + "maxCores\n" ;
            }
        }
        //      C# -> System.Int64? MaxMemoryBytes
        // GraphQL -> maxMemoryBytes: Long (scalar)
        if (this.MaxMemoryBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxMemoryBytes\n" ;
            } else {
                s += ind + "maxMemoryBytes\n" ;
            }
        }
        //      C# -> List<System.Int64>? NetworkIds
        // GraphQL -> networkIds: [Long!] (scalar)
        if (this.NetworkIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "networkIds\n" ;
            } else {
                s += ind + "networkIds\n" ;
            }
        }
        //      C# -> System.Int64? OsId
        // GraphQL -> osId: Long (scalar)
        if (this.OsId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osId\n" ;
            } else {
                s += ind + "osId\n" ;
            }
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String (scalar)
        if (this.OsType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osType\n" ;
            } else {
                s += ind + "osType\n" ;
            }
        }
        //      C# -> System.String? PlanCode
        // GraphQL -> planCode: String (scalar)
        if (this.PlanCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "planCode\n" ;
            } else {
                s += ind + "planCode\n" ;
            }
        }
        //      C# -> System.Int64? PlanId
        // GraphQL -> planId: Long (scalar)
        if (this.PlanId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "planId\n" ;
            } else {
                s += ind + "planId\n" ;
            }
        }
        //      C# -> System.String? Platform
        // GraphQL -> platform: String (scalar)
        if (this.Platform != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platform\n" ;
            } else {
                s += ind + "platform\n" ;
            }
        }
        //      C# -> System.Int64? SourceImageId
        // GraphQL -> sourceImageId: Long (scalar)
        if (this.SourceImageId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceImageId\n" ;
            } else {
                s += ind + "sourceImageId\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
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
        //      C# -> System.Int64? CoresPerSocket
        // GraphQL -> coresPerSocket: Long (scalar)
        if (ec.Includes("coresPerSocket",true))
        {
            if(this.CoresPerSocket == null) {

                this.CoresPerSocket = new System.Int64();

            } else {


            }
        }
        else if (this.CoresPerSocket != null && ec.Excludes("coresPerSocket",true))
        {
            this.CoresPerSocket = null;
        }
        //      C# -> System.String? InstanceTypeCode
        // GraphQL -> instanceTypeCode: String (scalar)
        if (ec.Includes("instanceTypeCode",true))
        {
            if(this.InstanceTypeCode == null) {

                this.InstanceTypeCode = "FETCH";

            } else {


            }
        }
        else if (this.InstanceTypeCode != null && ec.Excludes("instanceTypeCode",true))
        {
            this.InstanceTypeCode = null;
        }
        //      C# -> System.String? LayoutCode
        // GraphQL -> layoutCode: String (scalar)
        if (ec.Includes("layoutCode",true))
        {
            if(this.LayoutCode == null) {

                this.LayoutCode = "FETCH";

            } else {


            }
        }
        else if (this.LayoutCode != null && ec.Excludes("layoutCode",true))
        {
            this.LayoutCode = null;
        }
        //      C# -> System.Int64? LayoutId
        // GraphQL -> layoutId: Long (scalar)
        if (ec.Includes("layoutId",true))
        {
            if(this.LayoutId == null) {

                this.LayoutId = new System.Int64();

            } else {


            }
        }
        else if (this.LayoutId != null && ec.Excludes("layoutId",true))
        {
            this.LayoutId = null;
        }
        //      C# -> System.Int64? MaxCores
        // GraphQL -> maxCores: Long (scalar)
        if (ec.Includes("maxCores",true))
        {
            if(this.MaxCores == null) {

                this.MaxCores = new System.Int64();

            } else {


            }
        }
        else if (this.MaxCores != null && ec.Excludes("maxCores",true))
        {
            this.MaxCores = null;
        }
        //      C# -> System.Int64? MaxMemoryBytes
        // GraphQL -> maxMemoryBytes: Long (scalar)
        if (ec.Includes("maxMemoryBytes",true))
        {
            if(this.MaxMemoryBytes == null) {

                this.MaxMemoryBytes = new System.Int64();

            } else {


            }
        }
        else if (this.MaxMemoryBytes != null && ec.Excludes("maxMemoryBytes",true))
        {
            this.MaxMemoryBytes = null;
        }
        //      C# -> List<System.Int64>? NetworkIds
        // GraphQL -> networkIds: [Long!] (scalar)
        if (ec.Includes("networkIds",true))
        {
            if(this.NetworkIds == null) {

                this.NetworkIds = new List<System.Int64>();

            } else {


            }
        }
        else if (this.NetworkIds != null && ec.Excludes("networkIds",true))
        {
            this.NetworkIds = null;
        }
        //      C# -> System.Int64? OsId
        // GraphQL -> osId: Long (scalar)
        if (ec.Includes("osId",true))
        {
            if(this.OsId == null) {

                this.OsId = new System.Int64();

            } else {


            }
        }
        else if (this.OsId != null && ec.Excludes("osId",true))
        {
            this.OsId = null;
        }
        //      C# -> System.String? OsType
        // GraphQL -> osType: String (scalar)
        if (ec.Includes("osType",true))
        {
            if(this.OsType == null) {

                this.OsType = "FETCH";

            } else {


            }
        }
        else if (this.OsType != null && ec.Excludes("osType",true))
        {
            this.OsType = null;
        }
        //      C# -> System.String? PlanCode
        // GraphQL -> planCode: String (scalar)
        if (ec.Includes("planCode",true))
        {
            if(this.PlanCode == null) {

                this.PlanCode = "FETCH";

            } else {


            }
        }
        else if (this.PlanCode != null && ec.Excludes("planCode",true))
        {
            this.PlanCode = null;
        }
        //      C# -> System.Int64? PlanId
        // GraphQL -> planId: Long (scalar)
        if (ec.Includes("planId",true))
        {
            if(this.PlanId == null) {

                this.PlanId = new System.Int64();

            } else {


            }
        }
        else if (this.PlanId != null && ec.Excludes("planId",true))
        {
            this.PlanId = null;
        }
        //      C# -> System.String? Platform
        // GraphQL -> platform: String (scalar)
        if (ec.Includes("platform",true))
        {
            if(this.Platform == null) {

                this.Platform = "FETCH";

            } else {


            }
        }
        else if (this.Platform != null && ec.Excludes("platform",true))
        {
            this.Platform = null;
        }
        //      C# -> System.Int64? SourceImageId
        // GraphQL -> sourceImageId: Long (scalar)
        if (ec.Includes("sourceImageId",true))
        {
            if(this.SourceImageId == null) {

                this.SourceImageId = new System.Int64();

            } else {


            }
        }
        else if (this.SourceImageId != null && ec.Excludes("sourceImageId",true))
        {
            this.SourceImageId = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
    }


    #endregion

    } // class HpeVmeResourceSpec
    
    #endregion

    public static class ListHpeVmeResourceSpecExtensions
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
            this List<HpeVmeResourceSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HpeVmeResourceSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HpeVmeResourceSpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HpeVmeResourceSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HpeVmeResourceSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types