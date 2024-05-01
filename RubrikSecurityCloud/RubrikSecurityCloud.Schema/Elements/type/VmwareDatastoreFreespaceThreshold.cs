// VmwareDatastoreFreespaceThreshold.cs
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
    #region VmwareDatastoreFreespaceThreshold
    public class VmwareDatastoreFreespaceThreshold: BaseType
    {
        #region members

        //      C# -> System.Single? Threshold
        // GraphQL -> threshold: Float! (scalar)
        [JsonProperty("threshold")]
        public System.Single? Threshold { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareDatastoreFreespaceThreshold";
    }

    public VmwareDatastoreFreespaceThreshold Set(
        System.Single? Threshold = null,
        System.String? VmId = null
    ) 
    {
        if ( Threshold != null ) {
            this.Threshold = Threshold;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
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
        //      C# -> System.Single? Threshold
        // GraphQL -> threshold: Float! (scalar)
        if (this.Threshold != null) {
            if (conf.Flat) {
                s += conf.Prefix + "threshold\n" ;
            } else {
                s += ind + "threshold\n" ;
            }
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String (scalar)
        if (this.VmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmId\n" ;
            } else {
                s += ind + "vmId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Single? Threshold
        // GraphQL -> threshold: Float! (scalar)
        if (ec.Includes("threshold",true))
        {
            if(this.Threshold == null) {

                this.Threshold = new System.Single();

            } else {


            }
        }
        else if (this.Threshold != null && ec.Excludes("threshold",true))
        {
            this.Threshold = null;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: String (scalar)
        if (ec.Includes("vmId",true))
        {
            if(this.VmId == null) {

                this.VmId = "FETCH";

            } else {


            }
        }
        else if (this.VmId != null && ec.Excludes("vmId",true))
        {
            this.VmId = null;
        }
    }


    #endregion

    } // class VmwareDatastoreFreespaceThreshold
    
    #endregion

    public static class ListVmwareDatastoreFreespaceThresholdExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<VmwareDatastoreFreespaceThreshold> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareDatastoreFreespaceThreshold> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareDatastoreFreespaceThreshold> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareDatastoreFreespaceThreshold());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareDatastoreFreespaceThreshold> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types