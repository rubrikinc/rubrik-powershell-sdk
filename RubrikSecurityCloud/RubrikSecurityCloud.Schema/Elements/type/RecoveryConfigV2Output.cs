// RecoveryConfigV2Output.cs
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
    #region RecoveryConfigV2Output
    public class RecoveryConfigV2Output: BaseType
    {
        #region members

        //      C# -> DataTransferType? DataTransferType
        // GraphQL -> dataTransferType: DataTransferType! (enum)
        [JsonProperty("dataTransferType")]
        public DataTransferType? DataTransferType { get; set; }

        //      C# -> SnapshotLocationType? PreferredLocationType
        // GraphQL -> preferredLocationType: SnapshotLocationType! (enum)
        [JsonProperty("preferredLocationType")]
        public SnapshotLocationType? PreferredLocationType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryConfigV2Output";
    }

    public RecoveryConfigV2Output Set(
        DataTransferType? DataTransferType = null,
        SnapshotLocationType? PreferredLocationType = null
    ) 
    {
        if ( DataTransferType != null ) {
            this.DataTransferType = DataTransferType;
        }
        if ( PreferredLocationType != null ) {
            this.PreferredLocationType = PreferredLocationType;
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
        //      C# -> DataTransferType? DataTransferType
        // GraphQL -> dataTransferType: DataTransferType! (enum)
        if (this.DataTransferType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dataTransferType\n" ;
            } else {
                s += ind + "dataTransferType\n" ;
            }
        }
        //      C# -> SnapshotLocationType? PreferredLocationType
        // GraphQL -> preferredLocationType: SnapshotLocationType! (enum)
        if (this.PreferredLocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "preferredLocationType\n" ;
            } else {
                s += ind + "preferredLocationType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DataTransferType? DataTransferType
        // GraphQL -> dataTransferType: DataTransferType! (enum)
        if (ec.Includes("dataTransferType",true))
        {
            if(this.DataTransferType == null) {

                this.DataTransferType = new DataTransferType();

            } else {


            }
        }
        else if (this.DataTransferType != null && ec.Excludes("dataTransferType",true))
        {
            this.DataTransferType = null;
        }
        //      C# -> SnapshotLocationType? PreferredLocationType
        // GraphQL -> preferredLocationType: SnapshotLocationType! (enum)
        if (ec.Includes("preferredLocationType",true))
        {
            if(this.PreferredLocationType == null) {

                this.PreferredLocationType = new SnapshotLocationType();

            } else {


            }
        }
        else if (this.PreferredLocationType != null && ec.Excludes("preferredLocationType",true))
        {
            this.PreferredLocationType = null;
        }
    }


    #endregion

    } // class RecoveryConfigV2Output
    
    #endregion

    public static class ListRecoveryConfigV2OutputExtensions
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
            this List<RecoveryConfigV2Output> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryConfigV2Output> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryConfigV2Output> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryConfigV2Output());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryConfigV2Output> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types