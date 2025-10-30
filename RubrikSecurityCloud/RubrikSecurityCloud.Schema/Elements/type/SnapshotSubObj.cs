// SnapshotSubObj.cs
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
    #region SnapshotSubObj
    public class SnapshotSubObj: BaseType
    {
        #region members

        //      C# -> NutanixVmSubObject? NutanixVmSubObj
        // GraphQL -> nutanixVmSubObj: NutanixVmSubObject (type)
        [JsonProperty("nutanixVmSubObj")]
        public NutanixVmSubObject? NutanixVmSubObj { get; set; }

        //      C# -> OlvmVmSubObject? OlvmVmSubObj
        // GraphQL -> olvmVmSubObj: OlvmVmSubObject (type)
        [JsonProperty("olvmVmSubObj")]
        public OlvmVmSubObject? OlvmVmSubObj { get; set; }

        //      C# -> OpenstackVmSubObject? OpenstackVmSubObj
        // GraphQL -> openstackVmSubObj: OpenstackVmSubObject (type)
        [JsonProperty("openstackVmSubObj")]
        public OpenstackVmSubObject? OpenstackVmSubObj { get; set; }

        //      C# -> VmwareVmSubObject? VmwareVmSubObj
        // GraphQL -> vmwareVmSubObj: VmwareVmSubObject (type)
        [JsonProperty("vmwareVmSubObj")]
        public VmwareVmSubObject? VmwareVmSubObj { get; set; }

        //      C# -> VolumeGroupSubObject? VolumeGroupSubObj
        // GraphQL -> volumeGroupSubObj: VolumeGroupSubObject (type)
        [JsonProperty("volumeGroupSubObj")]
        public VolumeGroupSubObject? VolumeGroupSubObj { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotSubObj";
    }

    public SnapshotSubObj Set(
        NutanixVmSubObject? NutanixVmSubObj = null,
        OlvmVmSubObject? OlvmVmSubObj = null,
        OpenstackVmSubObject? OpenstackVmSubObj = null,
        VmwareVmSubObject? VmwareVmSubObj = null,
        VolumeGroupSubObject? VolumeGroupSubObj = null
    ) 
    {
        if ( NutanixVmSubObj != null ) {
            this.NutanixVmSubObj = NutanixVmSubObj;
        }
        if ( OlvmVmSubObj != null ) {
            this.OlvmVmSubObj = OlvmVmSubObj;
        }
        if ( OpenstackVmSubObj != null ) {
            this.OpenstackVmSubObj = OpenstackVmSubObj;
        }
        if ( VmwareVmSubObj != null ) {
            this.VmwareVmSubObj = VmwareVmSubObj;
        }
        if ( VolumeGroupSubObj != null ) {
            this.VolumeGroupSubObj = VolumeGroupSubObj;
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
        //      C# -> NutanixVmSubObject? NutanixVmSubObj
        // GraphQL -> nutanixVmSubObj: NutanixVmSubObject (type)
        if (this.NutanixVmSubObj != null) {
            var fspec = this.NutanixVmSubObj.AsFieldSpec(conf.Child("nutanixVmSubObj"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nutanixVmSubObj" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OlvmVmSubObject? OlvmVmSubObj
        // GraphQL -> olvmVmSubObj: OlvmVmSubObject (type)
        if (this.OlvmVmSubObj != null) {
            var fspec = this.OlvmVmSubObj.AsFieldSpec(conf.Child("olvmVmSubObj"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "olvmVmSubObj" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> OpenstackVmSubObject? OpenstackVmSubObj
        // GraphQL -> openstackVmSubObj: OpenstackVmSubObject (type)
        if (this.OpenstackVmSubObj != null) {
            var fspec = this.OpenstackVmSubObj.AsFieldSpec(conf.Child("openstackVmSubObj"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "openstackVmSubObj" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmwareVmSubObject? VmwareVmSubObj
        // GraphQL -> vmwareVmSubObj: VmwareVmSubObject (type)
        if (this.VmwareVmSubObj != null) {
            var fspec = this.VmwareVmSubObj.AsFieldSpec(conf.Child("vmwareVmSubObj"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "vmwareVmSubObj" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VolumeGroupSubObject? VolumeGroupSubObj
        // GraphQL -> volumeGroupSubObj: VolumeGroupSubObject (type)
        if (this.VolumeGroupSubObj != null) {
            var fspec = this.VolumeGroupSubObj.AsFieldSpec(conf.Child("volumeGroupSubObj"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "volumeGroupSubObj" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> NutanixVmSubObject? NutanixVmSubObj
        // GraphQL -> nutanixVmSubObj: NutanixVmSubObject (type)
        if (ec.Includes("nutanixVmSubObj",false))
        {
            if(this.NutanixVmSubObj == null) {

                this.NutanixVmSubObj = new NutanixVmSubObject();
                this.NutanixVmSubObj.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVmSubObj"));

            } else {

                this.NutanixVmSubObj.ApplyExploratoryFieldSpec(ec.NewChild("nutanixVmSubObj"));

            }
        }
        else if (this.NutanixVmSubObj != null && ec.Excludes("nutanixVmSubObj",false))
        {
            this.NutanixVmSubObj = null;
        }
        //      C# -> OlvmVmSubObject? OlvmVmSubObj
        // GraphQL -> olvmVmSubObj: OlvmVmSubObject (type)
        if (ec.Includes("olvmVmSubObj",false))
        {
            if(this.OlvmVmSubObj == null) {

                this.OlvmVmSubObj = new OlvmVmSubObject();
                this.OlvmVmSubObj.ApplyExploratoryFieldSpec(ec.NewChild("olvmVmSubObj"));

            } else {

                this.OlvmVmSubObj.ApplyExploratoryFieldSpec(ec.NewChild("olvmVmSubObj"));

            }
        }
        else if (this.OlvmVmSubObj != null && ec.Excludes("olvmVmSubObj",false))
        {
            this.OlvmVmSubObj = null;
        }
        //      C# -> OpenstackVmSubObject? OpenstackVmSubObj
        // GraphQL -> openstackVmSubObj: OpenstackVmSubObject (type)
        if (ec.Includes("openstackVmSubObj",false))
        {
            if(this.OpenstackVmSubObj == null) {

                this.OpenstackVmSubObj = new OpenstackVmSubObject();
                this.OpenstackVmSubObj.ApplyExploratoryFieldSpec(ec.NewChild("openstackVmSubObj"));

            } else {

                this.OpenstackVmSubObj.ApplyExploratoryFieldSpec(ec.NewChild("openstackVmSubObj"));

            }
        }
        else if (this.OpenstackVmSubObj != null && ec.Excludes("openstackVmSubObj",false))
        {
            this.OpenstackVmSubObj = null;
        }
        //      C# -> VmwareVmSubObject? VmwareVmSubObj
        // GraphQL -> vmwareVmSubObj: VmwareVmSubObject (type)
        if (ec.Includes("vmwareVmSubObj",false))
        {
            if(this.VmwareVmSubObj == null) {

                this.VmwareVmSubObj = new VmwareVmSubObject();
                this.VmwareVmSubObj.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVmSubObj"));

            } else {

                this.VmwareVmSubObj.ApplyExploratoryFieldSpec(ec.NewChild("vmwareVmSubObj"));

            }
        }
        else if (this.VmwareVmSubObj != null && ec.Excludes("vmwareVmSubObj",false))
        {
            this.VmwareVmSubObj = null;
        }
        //      C# -> VolumeGroupSubObject? VolumeGroupSubObj
        // GraphQL -> volumeGroupSubObj: VolumeGroupSubObject (type)
        if (ec.Includes("volumeGroupSubObj",false))
        {
            if(this.VolumeGroupSubObj == null) {

                this.VolumeGroupSubObj = new VolumeGroupSubObject();
                this.VolumeGroupSubObj.ApplyExploratoryFieldSpec(ec.NewChild("volumeGroupSubObj"));

            } else {

                this.VolumeGroupSubObj.ApplyExploratoryFieldSpec(ec.NewChild("volumeGroupSubObj"));

            }
        }
        else if (this.VolumeGroupSubObj != null && ec.Excludes("volumeGroupSubObj",false))
        {
            this.VolumeGroupSubObj = null;
        }
    }


    #endregion

    } // class SnapshotSubObj
    
    #endregion

    public static class ListSnapshotSubObjExtensions
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
            this List<SnapshotSubObj> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnapshotSubObj> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotSubObj> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotSubObj());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotSubObj> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types