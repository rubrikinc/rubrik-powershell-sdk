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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
            this List<M365ProductOperationMode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<M365ProductOperationMode> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365ProductOperationMode> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365ProductOperationMode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365ProductOperationMode> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types