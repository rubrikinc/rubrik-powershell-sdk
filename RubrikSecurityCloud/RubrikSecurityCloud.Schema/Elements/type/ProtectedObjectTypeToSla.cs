// ProtectedObjectTypeToSla.cs
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
    #region ProtectedObjectTypeToSla
    public class ProtectedObjectTypeToSla: BaseType
    {
        #region members

        //      C# -> WorkloadLevelHierarchy? ProtectedObjectType
        // GraphQL -> protectedObjectType: WorkloadLevelHierarchy! (enum)
        [JsonProperty("protectedObjectType")]
        public WorkloadLevelHierarchy? ProtectedObjectType { get; set; }

        //      C# -> AzureNativeResourceGroupSlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: AzureNativeResourceGroupSlaAssignment! (type)
        [JsonProperty("slaAssignment")]
        public AzureNativeResourceGroupSlaAssignment? SlaAssignment { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ProtectedObjectTypeToSla";
    }

    public ProtectedObjectTypeToSla Set(
        WorkloadLevelHierarchy? ProtectedObjectType = null,
        AzureNativeResourceGroupSlaAssignment? SlaAssignment = null
    ) 
    {
        if ( ProtectedObjectType != null ) {
            this.ProtectedObjectType = ProtectedObjectType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
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
        //      C# -> WorkloadLevelHierarchy? ProtectedObjectType
        // GraphQL -> protectedObjectType: WorkloadLevelHierarchy! (enum)
        if (this.ProtectedObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectedObjectType\n" ;
            } else {
                s += ind + "protectedObjectType\n" ;
            }
        }
        //      C# -> AzureNativeResourceGroupSlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: AzureNativeResourceGroupSlaAssignment! (type)
        if (this.SlaAssignment != null) {
            var fspec = this.SlaAssignment.AsFieldSpec(conf.Child("slaAssignment"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaAssignment" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WorkloadLevelHierarchy? ProtectedObjectType
        // GraphQL -> protectedObjectType: WorkloadLevelHierarchy! (enum)
        if (ec.Includes("protectedObjectType",true))
        {
            if(this.ProtectedObjectType == null) {

                this.ProtectedObjectType = new WorkloadLevelHierarchy();

            } else {


            }
        }
        else if (this.ProtectedObjectType != null && ec.Excludes("protectedObjectType",true))
        {
            this.ProtectedObjectType = null;
        }
        //      C# -> AzureNativeResourceGroupSlaAssignment? SlaAssignment
        // GraphQL -> slaAssignment: AzureNativeResourceGroupSlaAssignment! (type)
        if (ec.Includes("slaAssignment",false))
        {
            if(this.SlaAssignment == null) {

                this.SlaAssignment = new AzureNativeResourceGroupSlaAssignment();
                this.SlaAssignment.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignment"));

            } else {

                this.SlaAssignment.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignment"));

            }
        }
        else if (this.SlaAssignment != null && ec.Excludes("slaAssignment",false))
        {
            this.SlaAssignment = null;
        }
    }


    #endregion

    } // class ProtectedObjectTypeToSla
    
    #endregion

    public static class ListProtectedObjectTypeToSlaExtensions
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
            this List<ProtectedObjectTypeToSla> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ProtectedObjectTypeToSla> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ProtectedObjectTypeToSla> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ProtectedObjectTypeToSla());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ProtectedObjectTypeToSla> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types