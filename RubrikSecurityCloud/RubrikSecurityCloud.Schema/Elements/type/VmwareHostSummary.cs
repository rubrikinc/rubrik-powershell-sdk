// VmwareHostSummary.cs
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
    #region VmwareHostSummary
    public class VmwareHostSummary: BaseType
    {
        #region members

        //      C# -> HostFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: HostFilterStatus (enum)
        [JsonProperty("ioFilterStatus")]
        public HostFilterStatus? IoFilterStatus { get; set; }

        //      C# -> HostUiFilterStatus? IoFilterUiStatus
        // GraphQL -> ioFilterUiStatus: HostUiFilterStatus (enum)
        [JsonProperty("ioFilterUiStatus")]
        public HostUiFilterStatus? IoFilterUiStatus { get; set; }

        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        [JsonProperty("computeClusterId")]
        public System.String? ComputeClusterId { get; set; }

        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String (scalar)
        [JsonProperty("datacenterId")]
        public System.String? DatacenterId { get; set; }

        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        [JsonProperty("effectiveSlaDomainId")]
        public System.String? EffectiveSlaDomainId { get; set; }

        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        [JsonProperty("effectiveSlaDomainName")]
        public System.String? EffectiveSlaDomainName { get; set; }

        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        [JsonProperty("effectiveSlaDomainPolarisManagedId")]
        public System.String? EffectiveSlaDomainPolarisManagedId { get; set; }

        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        [JsonProperty("effectiveSlaSourceObjectId")]
        public System.String? EffectiveSlaSourceObjectId { get; set; }

        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        [JsonProperty("effectiveSlaSourceObjectName")]
        public System.String? EffectiveSlaSourceObjectName { get; set; }

        //      C# -> System.String? EsxiVersion
        // GraphQL -> esxiVersion: String (scalar)
        [JsonProperty("esxiVersion")]
        public System.String? EsxiVersion { get; set; }

        //      C# -> System.Boolean? IsInVmc
        // GraphQL -> isInVmc: Boolean (scalar)
        [JsonProperty("isInVmc")]
        public System.Boolean? IsInVmc { get; set; }

        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        [JsonProperty("datastores")]
        public List<DataStoreSummary>? Datastores { get; set; }

        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        [JsonProperty("effectiveSlaHolder")]
        public EffectiveSlaHolder? EffectiveSlaHolder { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareHostSummary";
    }

    public VmwareHostSummary Set(
        HostFilterStatus? IoFilterStatus = null,
        HostUiFilterStatus? IoFilterUiStatus = null,
        System.String? ComputeClusterId = null,
        System.String? DatacenterId = null,
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainPolarisManagedId = null,
        System.String? EffectiveSlaSourceObjectId = null,
        System.String? EffectiveSlaSourceObjectName = null,
        System.String? EsxiVersion = null,
        System.Boolean? IsInVmc = null,
        List<DataStoreSummary>? Datastores = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( IoFilterStatus != null ) {
            this.IoFilterStatus = IoFilterStatus;
        }
        if ( IoFilterUiStatus != null ) {
            this.IoFilterUiStatus = IoFilterUiStatus;
        }
        if ( ComputeClusterId != null ) {
            this.ComputeClusterId = ComputeClusterId;
        }
        if ( DatacenterId != null ) {
            this.DatacenterId = DatacenterId;
        }
        if ( EffectiveSlaDomainId != null ) {
            this.EffectiveSlaDomainId = EffectiveSlaDomainId;
        }
        if ( EffectiveSlaDomainName != null ) {
            this.EffectiveSlaDomainName = EffectiveSlaDomainName;
        }
        if ( EffectiveSlaDomainPolarisManagedId != null ) {
            this.EffectiveSlaDomainPolarisManagedId = EffectiveSlaDomainPolarisManagedId;
        }
        if ( EffectiveSlaSourceObjectId != null ) {
            this.EffectiveSlaSourceObjectId = EffectiveSlaSourceObjectId;
        }
        if ( EffectiveSlaSourceObjectName != null ) {
            this.EffectiveSlaSourceObjectName = EffectiveSlaSourceObjectName;
        }
        if ( EsxiVersion != null ) {
            this.EsxiVersion = EsxiVersion;
        }
        if ( IsInVmc != null ) {
            this.IsInVmc = IsInVmc;
        }
        if ( Datastores != null ) {
            this.Datastores = Datastores;
        }
        if ( EffectiveSlaHolder != null ) {
            this.EffectiveSlaHolder = EffectiveSlaHolder;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
        //      C# -> HostFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: HostFilterStatus (enum)
        if (this.IoFilterStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ioFilterStatus\n" ;
            } else {
                s += ind + "ioFilterStatus\n" ;
            }
        }
        //      C# -> HostUiFilterStatus? IoFilterUiStatus
        // GraphQL -> ioFilterUiStatus: HostUiFilterStatus (enum)
        if (this.IoFilterUiStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ioFilterUiStatus\n" ;
            } else {
                s += ind + "ioFilterUiStatus\n" ;
            }
        }
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        if (this.ComputeClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "computeClusterId\n" ;
            } else {
                s += ind + "computeClusterId\n" ;
            }
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String (scalar)
        if (this.DatacenterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datacenterId\n" ;
            } else {
                s += ind + "datacenterId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (this.EffectiveSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainId\n" ;
            } else {
                s += ind + "effectiveSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        if (this.EffectiveSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainName\n" ;
            } else {
                s += ind + "effectiveSlaDomainName\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (this.EffectiveSlaDomainPolarisManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainPolarisManagedId\n" ;
            } else {
                s += ind + "effectiveSlaDomainPolarisManagedId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        if (this.EffectiveSlaSourceObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaSourceObjectId\n" ;
            } else {
                s += ind + "effectiveSlaSourceObjectId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        if (this.EffectiveSlaSourceObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaSourceObjectName\n" ;
            } else {
                s += ind + "effectiveSlaSourceObjectName\n" ;
            }
        }
        //      C# -> System.String? EsxiVersion
        // GraphQL -> esxiVersion: String (scalar)
        if (this.EsxiVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "esxiVersion\n" ;
            } else {
                s += ind + "esxiVersion\n" ;
            }
        }
        //      C# -> System.Boolean? IsInVmc
        // GraphQL -> isInVmc: Boolean (scalar)
        if (this.IsInVmc != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isInVmc\n" ;
            } else {
                s += ind + "isInVmc\n" ;
            }
        }
        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        if (this.Datastores != null) {
            var fspec = this.Datastores.AsFieldSpec(conf.Child("datastores"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "datastores" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (this.EffectiveSlaHolder != null) {
            var fspec = this.EffectiveSlaHolder.AsFieldSpec(conf.Child("effectiveSlaHolder"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaHolder" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(conf.Child("slaAssignable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaAssignable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> HostFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: HostFilterStatus (enum)
        if (ec.Includes("ioFilterStatus",true))
        {
            if(this.IoFilterStatus == null) {

                this.IoFilterStatus = new HostFilterStatus();

            } else {


            }
        }
        else if (this.IoFilterStatus != null && ec.Excludes("ioFilterStatus",true))
        {
            this.IoFilterStatus = null;
        }
        //      C# -> HostUiFilterStatus? IoFilterUiStatus
        // GraphQL -> ioFilterUiStatus: HostUiFilterStatus (enum)
        if (ec.Includes("ioFilterUiStatus",true))
        {
            if(this.IoFilterUiStatus == null) {

                this.IoFilterUiStatus = new HostUiFilterStatus();

            } else {


            }
        }
        else if (this.IoFilterUiStatus != null && ec.Excludes("ioFilterUiStatus",true))
        {
            this.IoFilterUiStatus = null;
        }
        //      C# -> System.String? ComputeClusterId
        // GraphQL -> computeClusterId: String (scalar)
        if (ec.Includes("computeClusterId",true))
        {
            if(this.ComputeClusterId == null) {

                this.ComputeClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ComputeClusterId != null && ec.Excludes("computeClusterId",true))
        {
            this.ComputeClusterId = null;
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String (scalar)
        if (ec.Includes("datacenterId",true))
        {
            if(this.DatacenterId == null) {

                this.DatacenterId = "FETCH";

            } else {


            }
        }
        else if (this.DatacenterId != null && ec.Excludes("datacenterId",true))
        {
            this.DatacenterId = null;
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (ec.Includes("effectiveSlaDomainId",true))
        {
            if(this.EffectiveSlaDomainId == null) {

                this.EffectiveSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainId != null && ec.Excludes("effectiveSlaDomainId",true))
        {
            this.EffectiveSlaDomainId = null;
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        if (ec.Includes("effectiveSlaDomainName",true))
        {
            if(this.EffectiveSlaDomainName == null) {

                this.EffectiveSlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainName != null && ec.Excludes("effectiveSlaDomainName",true))
        {
            this.EffectiveSlaDomainName = null;
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (ec.Includes("effectiveSlaDomainPolarisManagedId",true))
        {
            if(this.EffectiveSlaDomainPolarisManagedId == null) {

                this.EffectiveSlaDomainPolarisManagedId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainPolarisManagedId != null && ec.Excludes("effectiveSlaDomainPolarisManagedId",true))
        {
            this.EffectiveSlaDomainPolarisManagedId = null;
        }
        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        if (ec.Includes("effectiveSlaSourceObjectId",true))
        {
            if(this.EffectiveSlaSourceObjectId == null) {

                this.EffectiveSlaSourceObjectId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaSourceObjectId != null && ec.Excludes("effectiveSlaSourceObjectId",true))
        {
            this.EffectiveSlaSourceObjectId = null;
        }
        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        if (ec.Includes("effectiveSlaSourceObjectName",true))
        {
            if(this.EffectiveSlaSourceObjectName == null) {

                this.EffectiveSlaSourceObjectName = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaSourceObjectName != null && ec.Excludes("effectiveSlaSourceObjectName",true))
        {
            this.EffectiveSlaSourceObjectName = null;
        }
        //      C# -> System.String? EsxiVersion
        // GraphQL -> esxiVersion: String (scalar)
        if (ec.Includes("esxiVersion",true))
        {
            if(this.EsxiVersion == null) {

                this.EsxiVersion = "FETCH";

            } else {


            }
        }
        else if (this.EsxiVersion != null && ec.Excludes("esxiVersion",true))
        {
            this.EsxiVersion = null;
        }
        //      C# -> System.Boolean? IsInVmc
        // GraphQL -> isInVmc: Boolean (scalar)
        if (ec.Includes("isInVmc",true))
        {
            if(this.IsInVmc == null) {

                this.IsInVmc = true;

            } else {


            }
        }
        else if (this.IsInVmc != null && ec.Excludes("isInVmc",true))
        {
            this.IsInVmc = null;
        }
        //      C# -> List<DataStoreSummary>? Datastores
        // GraphQL -> datastores: [DataStoreSummary!]! (type)
        if (ec.Includes("datastores",false))
        {
            if(this.Datastores == null) {

                this.Datastores = new List<DataStoreSummary>();
                this.Datastores.ApplyExploratoryFieldSpec(ec.NewChild("datastores"));

            } else {

                this.Datastores.ApplyExploratoryFieldSpec(ec.NewChild("datastores"));

            }
        }
        else if (this.Datastores != null && ec.Excludes("datastores",false))
        {
            this.Datastores = null;
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (ec.Includes("effectiveSlaHolder",false))
        {
            if(this.EffectiveSlaHolder == null) {

                this.EffectiveSlaHolder = new EffectiveSlaHolder();
                this.EffectiveSlaHolder.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaHolder"));

            } else {

                this.EffectiveSlaHolder.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaHolder"));

            }
        }
        else if (this.EffectiveSlaHolder != null && ec.Excludes("effectiveSlaHolder",false))
        {
            this.EffectiveSlaHolder = null;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (ec.Includes("slaAssignable",false))
        {
            if(this.SlaAssignable == null) {

                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            } else {

                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            }
        }
        else if (this.SlaAssignable != null && ec.Excludes("slaAssignable",false))
        {
            this.SlaAssignable = null;
        }
    }


    #endregion

    } // class VmwareHostSummary
    
    #endregion

    public static class ListVmwareHostSummaryExtensions
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
            this List<VmwareHostSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareHostSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareHostSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareHostSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareHostSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types