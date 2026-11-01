// VsphereVmServiceInfo.cs
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
    #region VsphereVmServiceInfo
    public class VsphereVmServiceInfo: BaseType
    {
        #region members

        //      C# -> System.String? StorageClassName
        // GraphQL -> storageClassName: String (scalar)
        [JsonProperty("storageClassName")]
        public System.String? StorageClassName { get; set; }

        //      C# -> System.String? VmClassName
        // GraphQL -> vmClassName: String! (scalar)
        [JsonProperty("vmClassName")]
        public System.String? VmClassName { get; set; }

        //      C# -> System.String? ZoneName
        // GraphQL -> zoneName: String (scalar)
        [JsonProperty("zoneName")]
        public System.String? ZoneName { get; set; }

        //      C# -> PathNode? Namespace
        // GraphQL -> namespace: PathNode! (type)
        [JsonProperty("namespace")]
        public PathNode? Namespace { get; set; }

        //      C# -> PathNode? Supervisor
        // GraphQL -> supervisor: PathNode! (type)
        [JsonProperty("supervisor")]
        public PathNode? Supervisor { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VsphereVmServiceInfo";
    }

    public VsphereVmServiceInfo Set(
        System.String? StorageClassName = null,
        System.String? VmClassName = null,
        System.String? ZoneName = null,
        PathNode? Namespace = null,
        PathNode? Supervisor = null
    ) 
    {
        if ( StorageClassName != null ) {
            this.StorageClassName = StorageClassName;
        }
        if ( VmClassName != null ) {
            this.VmClassName = VmClassName;
        }
        if ( ZoneName != null ) {
            this.ZoneName = ZoneName;
        }
        if ( Namespace != null ) {
            this.Namespace = Namespace;
        }
        if ( Supervisor != null ) {
            this.Supervisor = Supervisor;
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
        //      C# -> System.String? StorageClassName
        // GraphQL -> storageClassName: String (scalar)
        if (this.StorageClassName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageClassName\n" ;
            } else {
                s += ind + "storageClassName\n" ;
            }
        }
        //      C# -> System.String? VmClassName
        // GraphQL -> vmClassName: String! (scalar)
        if (this.VmClassName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmClassName\n" ;
            } else {
                s += ind + "vmClassName\n" ;
            }
        }
        //      C# -> System.String? ZoneName
        // GraphQL -> zoneName: String (scalar)
        if (this.ZoneName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "zoneName\n" ;
            } else {
                s += ind + "zoneName\n" ;
            }
        }
        //      C# -> PathNode? Namespace
        // GraphQL -> namespace: PathNode! (type)
        if (this.Namespace != null) {
            var fspec = this.Namespace.AsFieldSpec(conf.Child("namespace"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "namespace" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PathNode? Supervisor
        // GraphQL -> supervisor: PathNode! (type)
        if (this.Supervisor != null) {
            var fspec = this.Supervisor.AsFieldSpec(conf.Child("supervisor"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "supervisor" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? StorageClassName
        // GraphQL -> storageClassName: String (scalar)
        if (ec.Includes("storageClassName",true))
        {
            if(this.StorageClassName == null) {

                this.StorageClassName = "FETCH";

            } else {


            }
        }
        else if (this.StorageClassName != null && ec.Excludes("storageClassName",true))
        {
            this.StorageClassName = null;
        }
        //      C# -> System.String? VmClassName
        // GraphQL -> vmClassName: String! (scalar)
        if (ec.Includes("vmClassName",true))
        {
            if(this.VmClassName == null) {

                this.VmClassName = "FETCH";

            } else {


            }
        }
        else if (this.VmClassName != null && ec.Excludes("vmClassName",true))
        {
            this.VmClassName = null;
        }
        //      C# -> System.String? ZoneName
        // GraphQL -> zoneName: String (scalar)
        if (ec.Includes("zoneName",true))
        {
            if(this.ZoneName == null) {

                this.ZoneName = "FETCH";

            } else {


            }
        }
        else if (this.ZoneName != null && ec.Excludes("zoneName",true))
        {
            this.ZoneName = null;
        }
        //      C# -> PathNode? Namespace
        // GraphQL -> namespace: PathNode! (type)
        if (ec.Includes("namespace",false))
        {
            if(this.Namespace == null) {

                this.Namespace = new PathNode();
                this.Namespace.ApplyExploratoryFieldSpec(ec.NewChild("namespace"));

            } else {

                this.Namespace.ApplyExploratoryFieldSpec(ec.NewChild("namespace"));

            }
        }
        else if (this.Namespace != null && ec.Excludes("namespace",false))
        {
            this.Namespace = null;
        }
        //      C# -> PathNode? Supervisor
        // GraphQL -> supervisor: PathNode! (type)
        if (ec.Includes("supervisor",false))
        {
            if(this.Supervisor == null) {

                this.Supervisor = new PathNode();
                this.Supervisor.ApplyExploratoryFieldSpec(ec.NewChild("supervisor"));

            } else {

                this.Supervisor.ApplyExploratoryFieldSpec(ec.NewChild("supervisor"));

            }
        }
        else if (this.Supervisor != null && ec.Excludes("supervisor",false))
        {
            this.Supervisor = null;
        }
    }


    #endregion

    } // class VsphereVmServiceInfo
    
    #endregion

    public static class ListVsphereVmServiceInfoExtensions
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
            this List<VsphereVmServiceInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VsphereVmServiceInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVmServiceInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVmServiceInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VsphereVmServiceInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types