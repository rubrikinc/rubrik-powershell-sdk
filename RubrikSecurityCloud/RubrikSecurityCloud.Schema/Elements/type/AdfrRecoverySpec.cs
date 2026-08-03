// AdfrRecoverySpec.cs
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
    #region AdfrRecoverySpec
    public class AdfrRecoverySpec: BaseType
    {
        #region members

        //      C# -> System.Int64? HostRecoveryPoint
        // GraphQL -> hostRecoveryPoint: Long! (scalar)
        [JsonProperty("hostRecoveryPoint")]
        public System.Int64? HostRecoveryPoint { get; set; }

        //      C# -> System.String? HostSnapshotFid
        // GraphQL -> hostSnapshotFid: UUID (scalar)
        [JsonProperty("hostSnapshotFid")]
        public System.String? HostSnapshotFid { get; set; }

        //      C# -> System.String? HostWorkloadFid
        // GraphQL -> hostWorkloadFid: UUID (scalar)
        [JsonProperty("hostWorkloadFid")]
        public System.String? HostWorkloadFid { get; set; }

        //      C# -> System.Int32? RecoveryVlanId
        // GraphQL -> recoveryVlanId: Int! (scalar)
        [JsonProperty("recoveryVlanId")]
        public System.Int32? RecoveryVlanId { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> AddcRecoverySpec? Addc
        // GraphQL -> addc: AddcRecoverySpec (type)
        [JsonProperty("addc")]
        public AddcRecoverySpec? Addc { get; set; }

        //      C# -> AdfrHostSpec? HostSpec
        // GraphQL -> hostSpec: AdfrHostSpec (type)
        [JsonProperty("hostSpec")]
        public AdfrHostSpec? HostSpec { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AdfrRecoverySpec";
    }

    public AdfrRecoverySpec Set(
        System.Int64? HostRecoveryPoint = null,
        System.String? HostSnapshotFid = null,
        System.String? HostWorkloadFid = null,
        System.Int32? RecoveryVlanId = null,
        System.Int64? Version = null,
        AddcRecoverySpec? Addc = null,
        AdfrHostSpec? HostSpec = null
    ) 
    {
        if ( HostRecoveryPoint != null ) {
            this.HostRecoveryPoint = HostRecoveryPoint;
        }
        if ( HostSnapshotFid != null ) {
            this.HostSnapshotFid = HostSnapshotFid;
        }
        if ( HostWorkloadFid != null ) {
            this.HostWorkloadFid = HostWorkloadFid;
        }
        if ( RecoveryVlanId != null ) {
            this.RecoveryVlanId = RecoveryVlanId;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Addc != null ) {
            this.Addc = Addc;
        }
        if ( HostSpec != null ) {
            this.HostSpec = HostSpec;
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
        //      C# -> System.Int64? HostRecoveryPoint
        // GraphQL -> hostRecoveryPoint: Long! (scalar)
        if (this.HostRecoveryPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostRecoveryPoint\n" ;
            } else {
                s += ind + "hostRecoveryPoint\n" ;
            }
        }
        //      C# -> System.String? HostSnapshotFid
        // GraphQL -> hostSnapshotFid: UUID (scalar)
        if (this.HostSnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostSnapshotFid\n" ;
            } else {
                s += ind + "hostSnapshotFid\n" ;
            }
        }
        //      C# -> System.String? HostWorkloadFid
        // GraphQL -> hostWorkloadFid: UUID (scalar)
        if (this.HostWorkloadFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostWorkloadFid\n" ;
            } else {
                s += ind + "hostWorkloadFid\n" ;
            }
        }
        //      C# -> System.Int32? RecoveryVlanId
        // GraphQL -> recoveryVlanId: Int! (scalar)
        if (this.RecoveryVlanId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryVlanId\n" ;
            } else {
                s += ind + "recoveryVlanId\n" ;
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
        //      C# -> AddcRecoverySpec? Addc
        // GraphQL -> addc: AddcRecoverySpec (type)
        if (this.Addc != null) {
            var fspec = this.Addc.AsFieldSpec(conf.Child("addc"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "addc" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AdfrHostSpec? HostSpec
        // GraphQL -> hostSpec: AdfrHostSpec (type)
        if (this.HostSpec != null) {
            var fspec = this.HostSpec.AsFieldSpec(conf.Child("hostSpec"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hostSpec" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? HostRecoveryPoint
        // GraphQL -> hostRecoveryPoint: Long! (scalar)
        if (ec.Includes("hostRecoveryPoint",true))
        {
            if(this.HostRecoveryPoint == null) {

                this.HostRecoveryPoint = new System.Int64();

            } else {


            }
        }
        else if (this.HostRecoveryPoint != null && ec.Excludes("hostRecoveryPoint",true))
        {
            this.HostRecoveryPoint = null;
        }
        //      C# -> System.String? HostSnapshotFid
        // GraphQL -> hostSnapshotFid: UUID (scalar)
        if (ec.Includes("hostSnapshotFid",true))
        {
            if(this.HostSnapshotFid == null) {

                this.HostSnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.HostSnapshotFid != null && ec.Excludes("hostSnapshotFid",true))
        {
            this.HostSnapshotFid = null;
        }
        //      C# -> System.String? HostWorkloadFid
        // GraphQL -> hostWorkloadFid: UUID (scalar)
        if (ec.Includes("hostWorkloadFid",true))
        {
            if(this.HostWorkloadFid == null) {

                this.HostWorkloadFid = "FETCH";

            } else {


            }
        }
        else if (this.HostWorkloadFid != null && ec.Excludes("hostWorkloadFid",true))
        {
            this.HostWorkloadFid = null;
        }
        //      C# -> System.Int32? RecoveryVlanId
        // GraphQL -> recoveryVlanId: Int! (scalar)
        if (ec.Includes("recoveryVlanId",true))
        {
            if(this.RecoveryVlanId == null) {

                this.RecoveryVlanId = Int32.MinValue;

            } else {


            }
        }
        else if (this.RecoveryVlanId != null && ec.Excludes("recoveryVlanId",true))
        {
            this.RecoveryVlanId = null;
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
        //      C# -> AddcRecoverySpec? Addc
        // GraphQL -> addc: AddcRecoverySpec (type)
        if (ec.Includes("addc",false))
        {
            if(this.Addc == null) {

                this.Addc = new AddcRecoverySpec();
                this.Addc.ApplyExploratoryFieldSpec(ec.NewChild("addc"));

            } else {

                this.Addc.ApplyExploratoryFieldSpec(ec.NewChild("addc"));

            }
        }
        else if (this.Addc != null && ec.Excludes("addc",false))
        {
            this.Addc = null;
        }
        //      C# -> AdfrHostSpec? HostSpec
        // GraphQL -> hostSpec: AdfrHostSpec (type)
        if (ec.Includes("hostSpec",false))
        {
            if(this.HostSpec == null) {

                this.HostSpec = new AdfrHostSpec();
                this.HostSpec.ApplyExploratoryFieldSpec(ec.NewChild("hostSpec"));

            } else {

                this.HostSpec.ApplyExploratoryFieldSpec(ec.NewChild("hostSpec"));

            }
        }
        else if (this.HostSpec != null && ec.Excludes("hostSpec",false))
        {
            this.HostSpec = null;
        }
    }


    #endregion

    } // class AdfrRecoverySpec
    
    #endregion

    public static class ListAdfrRecoverySpecExtensions
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
            this List<AdfrRecoverySpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AdfrRecoverySpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AdfrRecoverySpec> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AdfrRecoverySpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AdfrRecoverySpec> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types