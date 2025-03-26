// M365ProductOperationMode.cs
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
    #region M365ProductOperationMode
    public class M365ProductOperationMode: BaseType
    {
        #region members

        //      C# -> M365DashboardOperationMode? OperationMode
        // GraphQL -> operationMode: M365DashboardOperationMode! (enum)
        [JsonProperty("operationMode")]
        public M365DashboardOperationMode? OperationMode { get; set; }

        //      C# -> M365DashboardWorkloadType? WorkloadType
        // GraphQL -> workloadType: M365DashboardWorkloadType! (enum)
        [JsonProperty("workloadType")]
        public M365DashboardWorkloadType? WorkloadType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365ProductOperationMode";
    }

    public M365ProductOperationMode Set(
        M365DashboardOperationMode? OperationMode = null,
        M365DashboardWorkloadType? WorkloadType = null
    ) 
    {
        if ( OperationMode != null ) {
            this.OperationMode = OperationMode;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
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
        //      C# -> M365DashboardOperationMode? OperationMode
        // GraphQL -> operationMode: M365DashboardOperationMode! (enum)
        if (this.OperationMode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operationMode\n" ;
            } else {
                s += ind + "operationMode\n" ;
            }
        }
        //      C# -> M365DashboardWorkloadType? WorkloadType
        // GraphQL -> workloadType: M365DashboardWorkloadType! (enum)
        if (this.WorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadType\n" ;
            } else {
                s += ind + "workloadType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> M365DashboardOperationMode? OperationMode
        // GraphQL -> operationMode: M365DashboardOperationMode! (enum)
        if (ec.Includes("operationMode",true))
        {
            if(this.OperationMode == null) {

                this.OperationMode = new M365DashboardOperationMode();

            } else {


            }
        }
        else if (this.OperationMode != null && ec.Excludes("operationMode",true))
        {
            this.OperationMode = null;
        }
        //      C# -> M365DashboardWorkloadType? WorkloadType
        // GraphQL -> workloadType: M365DashboardWorkloadType! (enum)
        if (ec.Includes("workloadType",true))
        {
            if(this.WorkloadType == null) {

                this.WorkloadType = new M365DashboardWorkloadType();

            } else {


            }
        }
        else if (this.WorkloadType != null && ec.Excludes("workloadType",true))
        {
            this.WorkloadType = null;
        }
    }


    #endregion

    } // class M365ProductOperationMode
    
    #endregion

    public static class ListM365ProductOperationModeExtensions
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
            this List<M365ProductOperationMode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365ProductOperationMode> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365ProductOperationMode> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365ProductOperationMode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365ProductOperationMode> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types