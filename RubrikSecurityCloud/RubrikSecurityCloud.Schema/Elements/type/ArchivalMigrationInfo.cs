// ArchivalMigrationInfo.cs
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
    #region ArchivalMigrationInfo
    public class ArchivalMigrationInfo: BaseType
    {
        #region members

        //      C# -> ArchivalMigrationStatus? Status
        // GraphQL -> status: ArchivalMigrationStatus! (enum)
        [JsonProperty("status")]
        public ArchivalMigrationStatus? Status { get; set; }

        //      C# -> ArchivalMigrationTargetType? TargetLocationType
        // GraphQL -> targetLocationType: ArchivalMigrationTargetType! (enum)
        [JsonProperty("targetLocationType")]
        public ArchivalMigrationTargetType? TargetLocationType { get; set; }

        //      C# -> ArchivalMigrationTargetLocation? TargetLocation
        // GraphQL -> targetLocation: ArchivalMigrationTargetLocation! (type)
        [JsonProperty("targetLocation")]
        public ArchivalMigrationTargetLocation? TargetLocation { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalMigrationInfo";
    }

    public ArchivalMigrationInfo Set(
        ArchivalMigrationStatus? Status = null,
        ArchivalMigrationTargetType? TargetLocationType = null,
        ArchivalMigrationTargetLocation? TargetLocation = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( TargetLocationType != null ) {
            this.TargetLocationType = TargetLocationType;
        }
        if ( TargetLocation != null ) {
            this.TargetLocation = TargetLocation;
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
        //      C# -> ArchivalMigrationStatus? Status
        // GraphQL -> status: ArchivalMigrationStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> ArchivalMigrationTargetType? TargetLocationType
        // GraphQL -> targetLocationType: ArchivalMigrationTargetType! (enum)
        if (this.TargetLocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetLocationType\n" ;
            } else {
                s += ind + "targetLocationType\n" ;
            }
        }
        //      C# -> ArchivalMigrationTargetLocation? TargetLocation
        // GraphQL -> targetLocation: ArchivalMigrationTargetLocation! (type)
        if (this.TargetLocation != null) {
            var fspec = this.TargetLocation.AsFieldSpec(conf.Child("targetLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetLocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ArchivalMigrationStatus? Status
        // GraphQL -> status: ArchivalMigrationStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ArchivalMigrationStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> ArchivalMigrationTargetType? TargetLocationType
        // GraphQL -> targetLocationType: ArchivalMigrationTargetType! (enum)
        if (ec.Includes("targetLocationType",true))
        {
            if(this.TargetLocationType == null) {

                this.TargetLocationType = new ArchivalMigrationTargetType();

            } else {


            }
        }
        else if (this.TargetLocationType != null && ec.Excludes("targetLocationType",true))
        {
            this.TargetLocationType = null;
        }
        //      C# -> ArchivalMigrationTargetLocation? TargetLocation
        // GraphQL -> targetLocation: ArchivalMigrationTargetLocation! (type)
        if (ec.Includes("targetLocation",false))
        {
            if(this.TargetLocation == null) {

                this.TargetLocation = new ArchivalMigrationTargetLocation();
                this.TargetLocation.ApplyExploratoryFieldSpec(ec.NewChild("targetLocation"));

            } else {

                this.TargetLocation.ApplyExploratoryFieldSpec(ec.NewChild("targetLocation"));

            }
        }
        else if (this.TargetLocation != null && ec.Excludes("targetLocation",false))
        {
            this.TargetLocation = null;
        }
    }


    #endregion

    } // class ArchivalMigrationInfo
    
    #endregion

    public static class ListArchivalMigrationInfoExtensions
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
            this List<ArchivalMigrationInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalMigrationInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalMigrationInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalMigrationInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalMigrationInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types