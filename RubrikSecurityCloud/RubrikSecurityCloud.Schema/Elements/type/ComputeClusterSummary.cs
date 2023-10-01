// ComputeClusterSummary.cs
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
    #region ComputeClusterSummary
    public class ComputeClusterSummary: BaseType
    {
        #region members

        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        [JsonProperty("ioFilterStatus")]
        public IoFilterStatus? IoFilterStatus { get; set; }

        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
        [JsonProperty("datacenterId")]
        public System.String? DatacenterId { get; set; }

        //      C# -> System.Boolean? DrsStatus
        // GraphQL -> drsStatus: Boolean (scalar)
        [JsonProperty("drsStatus")]
        public System.Boolean? DrsStatus { get; set; }

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

        //      C# -> List<System.String>? HostVersions
        // GraphQL -> hostVersions: [String!]! (scalar)
        [JsonProperty("hostVersions")]
        public List<System.String>? HostVersions { get; set; }

        //      C# -> System.String? LastUsedFqdn
        // GraphQL -> lastUsedFqdn: String (scalar)
        [JsonProperty("lastUsedFqdn")]
        public System.String? LastUsedFqdn { get; set; }

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
        return "ComputeClusterSummary";
    }

    public ComputeClusterSummary Set(
        IoFilterStatus? IoFilterStatus = null,
        System.String? DatacenterId = null,
        System.Boolean? DrsStatus = null,
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainPolarisManagedId = null,
        System.String? EffectiveSlaSourceObjectId = null,
        System.String? EffectiveSlaSourceObjectName = null,
        List<System.String>? HostVersions = null,
        System.String? LastUsedFqdn = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( IoFilterStatus != null ) {
            this.IoFilterStatus = IoFilterStatus;
        }
        if ( DatacenterId != null ) {
            this.DatacenterId = DatacenterId;
        }
        if ( DrsStatus != null ) {
            this.DrsStatus = DrsStatus;
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
        if ( HostVersions != null ) {
            this.HostVersions = HostVersions;
        }
        if ( LastUsedFqdn != null ) {
            this.LastUsedFqdn = LastUsedFqdn;
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
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        if (this.IoFilterStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ioFilterStatus\n" ;
            } else {
                s += ind + "ioFilterStatus\n" ;
            }
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
        if (this.DatacenterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datacenterId\n" ;
            } else {
                s += ind + "datacenterId\n" ;
            }
        }
        //      C# -> System.Boolean? DrsStatus
        // GraphQL -> drsStatus: Boolean (scalar)
        if (this.DrsStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "drsStatus\n" ;
            } else {
                s += ind + "drsStatus\n" ;
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
        //      C# -> List<System.String>? HostVersions
        // GraphQL -> hostVersions: [String!]! (scalar)
        if (this.HostVersions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostVersions\n" ;
            } else {
                s += ind + "hostVersions\n" ;
            }
        }
        //      C# -> System.String? LastUsedFqdn
        // GraphQL -> lastUsedFqdn: String (scalar)
        if (this.LastUsedFqdn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUsedFqdn\n" ;
            } else {
                s += ind + "lastUsedFqdn\n" ;
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
                    s += ind + "effectiveSlaHolder {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "slaAssignable {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> IoFilterStatus? IoFilterStatus
        // GraphQL -> ioFilterStatus: IoFilterStatus (enum)
        if (ec.Includes("ioFilterStatus",true))
        {
            if(this.IoFilterStatus == null) {

                this.IoFilterStatus = new IoFilterStatus();

            } else {


            }
        }
        else if (this.IoFilterStatus != null && ec.Excludes("ioFilterStatus",true))
        {
            this.IoFilterStatus = null;
        }
        //      C# -> System.String? DatacenterId
        // GraphQL -> datacenterId: String! (scalar)
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
        //      C# -> System.Boolean? DrsStatus
        // GraphQL -> drsStatus: Boolean (scalar)
        if (ec.Includes("drsStatus",true))
        {
            if(this.DrsStatus == null) {

                this.DrsStatus = true;

            } else {


            }
        }
        else if (this.DrsStatus != null && ec.Excludes("drsStatus",true))
        {
            this.DrsStatus = null;
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
        //      C# -> List<System.String>? HostVersions
        // GraphQL -> hostVersions: [String!]! (scalar)
        if (ec.Includes("hostVersions",true))
        {
            if(this.HostVersions == null) {

                this.HostVersions = new List<System.String>();

            } else {


            }
        }
        else if (this.HostVersions != null && ec.Excludes("hostVersions",true))
        {
            this.HostVersions = null;
        }
        //      C# -> System.String? LastUsedFqdn
        // GraphQL -> lastUsedFqdn: String (scalar)
        if (ec.Includes("lastUsedFqdn",true))
        {
            if(this.LastUsedFqdn == null) {

                this.LastUsedFqdn = "FETCH";

            } else {


            }
        }
        else if (this.LastUsedFqdn != null && ec.Excludes("lastUsedFqdn",true))
        {
            this.LastUsedFqdn = null;
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

    } // class ComputeClusterSummary
    
    #endregion

    public static class ListComputeClusterSummaryExtensions
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
            this List<ComputeClusterSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ComputeClusterSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ComputeClusterSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ComputeClusterSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ComputeClusterSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types