// ReplicationToCloudLocationSpec.cs
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
    #region ReplicationToCloudLocationSpec
    public class ReplicationToCloudLocationSpec: BaseType
    {
        #region members

        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        [JsonProperty("retentionDuration")]
        public Duration? RetentionDuration { get; set; }

        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        [JsonProperty("targetMapping")]
        public TargetMapping? TargetMapping { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ReplicationToCloudLocationSpec";
    }

    public ReplicationToCloudLocationSpec Set(
        Duration? RetentionDuration = null,
        TargetMapping? TargetMapping = null
    ) 
    {
        if ( RetentionDuration != null ) {
            this.RetentionDuration = RetentionDuration;
        }
        if ( TargetMapping != null ) {
            this.TargetMapping = TargetMapping;
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
        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        if (this.RetentionDuration != null) {
            var fspec = this.RetentionDuration.AsFieldSpec(conf.Child("retentionDuration"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "retentionDuration" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        if (this.TargetMapping != null) {
            var fspec = this.TargetMapping.AsFieldSpec(conf.Child("targetMapping"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetMapping" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Duration? RetentionDuration
        // GraphQL -> retentionDuration: Duration (type)
        if (ec.Includes("retentionDuration",false))
        {
            if(this.RetentionDuration == null) {

                this.RetentionDuration = new Duration();
                this.RetentionDuration.ApplyExploratoryFieldSpec(ec.NewChild("retentionDuration"));

            } else {

                this.RetentionDuration.ApplyExploratoryFieldSpec(ec.NewChild("retentionDuration"));

            }
        }
        else if (this.RetentionDuration != null && ec.Excludes("retentionDuration",false))
        {
            this.RetentionDuration = null;
        }
        //      C# -> TargetMapping? TargetMapping
        // GraphQL -> targetMapping: TargetMapping (type)
        if (ec.Includes("targetMapping",false))
        {
            if(this.TargetMapping == null) {

                this.TargetMapping = new TargetMapping();
                this.TargetMapping.ApplyExploratoryFieldSpec(ec.NewChild("targetMapping"));

            } else {

                this.TargetMapping.ApplyExploratoryFieldSpec(ec.NewChild("targetMapping"));

            }
        }
        else if (this.TargetMapping != null && ec.Excludes("targetMapping",false))
        {
            this.TargetMapping = null;
        }
    }


    #endregion

    } // class ReplicationToCloudLocationSpec
    
    #endregion

    public static class ListReplicationToCloudLocationSpecExtensions
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
            this List<ReplicationToCloudLocationSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ReplicationToCloudLocationSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ReplicationToCloudLocationSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ReplicationToCloudLocationSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ReplicationToCloudLocationSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types