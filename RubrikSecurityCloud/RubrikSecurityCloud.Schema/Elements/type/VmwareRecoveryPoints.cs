// VmwareRecoveryPoints.cs
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
    #region VmwareRecoveryPoints
    public class VmwareRecoveryPoints: BaseType
    {
        #region members

        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        [JsonProperty("localRecoveryPoint")]
        public DateTime? LocalRecoveryPoint { get; set; }

        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        [JsonProperty("remoteRecoveryPoint")]
        public DateTime? RemoteRecoveryPoint { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VmwareRecoveryPoints";
    }

    public VmwareRecoveryPoints Set(
        DateTime? LocalRecoveryPoint = null,
        DateTime? RemoteRecoveryPoint = null
    ) 
    {
        if ( LocalRecoveryPoint != null ) {
            this.LocalRecoveryPoint = LocalRecoveryPoint;
        }
        if ( RemoteRecoveryPoint != null ) {
            this.RemoteRecoveryPoint = RemoteRecoveryPoint;
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
        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        if (this.LocalRecoveryPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localRecoveryPoint\n" ;
            } else {
                s += ind + "localRecoveryPoint\n" ;
            }
        }
        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        if (this.RemoteRecoveryPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remoteRecoveryPoint\n" ;
            } else {
                s += ind + "remoteRecoveryPoint\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? LocalRecoveryPoint
        // GraphQL -> localRecoveryPoint: DateTime (scalar)
        if (ec.Includes("localRecoveryPoint",true))
        {
            if(this.LocalRecoveryPoint == null) {

                this.LocalRecoveryPoint = new DateTime();

            } else {


            }
        }
        else if (this.LocalRecoveryPoint != null && ec.Excludes("localRecoveryPoint",true))
        {
            this.LocalRecoveryPoint = null;
        }
        //      C# -> DateTime? RemoteRecoveryPoint
        // GraphQL -> remoteRecoveryPoint: DateTime (scalar)
        if (ec.Includes("remoteRecoveryPoint",true))
        {
            if(this.RemoteRecoveryPoint == null) {

                this.RemoteRecoveryPoint = new DateTime();

            } else {


            }
        }
        else if (this.RemoteRecoveryPoint != null && ec.Excludes("remoteRecoveryPoint",true))
        {
            this.RemoteRecoveryPoint = null;
        }
    }


    #endregion

    } // class VmwareRecoveryPoints
    
    #endregion

    public static class ListVmwareRecoveryPointsExtensions
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
            this List<VmwareRecoveryPoints> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<VmwareRecoveryPoints> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<VmwareRecoveryPoints> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VmwareRecoveryPoints());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<VmwareRecoveryPoints> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types