// VmwareThrottlingSettings.cs
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
    #region VmwareThrottlingSettings
    public class VmwareThrottlingSettings: BaseType
    {
        #region members

        //      C# -> System.Int32? CpuUtilizationThreshold
        // GraphQL -> cpuUtilizationThreshold: Int! (scalar)
        [JsonProperty("cpuUtilizationThreshold")]
        public System.Int32? CpuUtilizationThreshold { get; set; }

        //      C# -> System.Int32? DatastoreIoLatencyThreshold
        // GraphQL -> datastoreIoLatencyThreshold: Int! (scalar)
        [JsonProperty("datastoreIoLatencyThreshold")]
        public System.Int32? DatastoreIoLatencyThreshold { get; set; }

        //      C# -> System.Int32? IoLatencyThreshold
        // GraphQL -> ioLatencyThreshold: Int! (scalar)
        [JsonProperty("ioLatencyThreshold")]
        public System.Int32? IoLatencyThreshold { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareThrottlingSettings";
    }

    public VmwareThrottlingSettings Set(
        System.Int32? CpuUtilizationThreshold = null,
        System.Int32? DatastoreIoLatencyThreshold = null,
        System.Int32? IoLatencyThreshold = null
    ) 
    {
        if ( CpuUtilizationThreshold != null ) {
            this.CpuUtilizationThreshold = CpuUtilizationThreshold;
        }
        if ( DatastoreIoLatencyThreshold != null ) {
            this.DatastoreIoLatencyThreshold = DatastoreIoLatencyThreshold;
        }
        if ( IoLatencyThreshold != null ) {
            this.IoLatencyThreshold = IoLatencyThreshold;
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
        //      C# -> System.Int32? CpuUtilizationThreshold
        // GraphQL -> cpuUtilizationThreshold: Int! (scalar)
        if (this.CpuUtilizationThreshold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cpuUtilizationThreshold\n" ;
            } else {
                s += ind + "cpuUtilizationThreshold\n" ;
            }
        }
        //      C# -> System.Int32? DatastoreIoLatencyThreshold
        // GraphQL -> datastoreIoLatencyThreshold: Int! (scalar)
        if (this.DatastoreIoLatencyThreshold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "datastoreIoLatencyThreshold\n" ;
            } else {
                s += ind + "datastoreIoLatencyThreshold\n" ;
            }
        }
        //      C# -> System.Int32? IoLatencyThreshold
        // GraphQL -> ioLatencyThreshold: Int! (scalar)
        if (this.IoLatencyThreshold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ioLatencyThreshold\n" ;
            } else {
                s += ind + "ioLatencyThreshold\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? CpuUtilizationThreshold
        // GraphQL -> cpuUtilizationThreshold: Int! (scalar)
        if (ec.Includes("cpuUtilizationThreshold",true))
        {
            if(this.CpuUtilizationThreshold == null) {

                this.CpuUtilizationThreshold = Int32.MinValue;

            } else {


            }
        }
        else if (this.CpuUtilizationThreshold != null && ec.Excludes("cpuUtilizationThreshold",true))
        {
            this.CpuUtilizationThreshold = null;
        }
        //      C# -> System.Int32? DatastoreIoLatencyThreshold
        // GraphQL -> datastoreIoLatencyThreshold: Int! (scalar)
        if (ec.Includes("datastoreIoLatencyThreshold",true))
        {
            if(this.DatastoreIoLatencyThreshold == null) {

                this.DatastoreIoLatencyThreshold = Int32.MinValue;

            } else {


            }
        }
        else if (this.DatastoreIoLatencyThreshold != null && ec.Excludes("datastoreIoLatencyThreshold",true))
        {
            this.DatastoreIoLatencyThreshold = null;
        }
        //      C# -> System.Int32? IoLatencyThreshold
        // GraphQL -> ioLatencyThreshold: Int! (scalar)
        if (ec.Includes("ioLatencyThreshold",true))
        {
            if(this.IoLatencyThreshold == null) {

                this.IoLatencyThreshold = Int32.MinValue;

            } else {


            }
        }
        else if (this.IoLatencyThreshold != null && ec.Excludes("ioLatencyThreshold",true))
        {
            this.IoLatencyThreshold = null;
        }
    }


    #endregion

    } // class VmwareThrottlingSettings
    
    #endregion

    public static class ListVmwareThrottlingSettingsExtensions
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
            this List<VmwareThrottlingSettings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareThrottlingSettings> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareThrottlingSettings> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareThrottlingSettings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareThrottlingSettings> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types