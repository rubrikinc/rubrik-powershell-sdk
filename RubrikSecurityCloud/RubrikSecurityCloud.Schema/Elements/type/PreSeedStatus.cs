// PreSeedStatus.cs
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
    #region PreSeedStatus
    public class PreSeedStatus: BaseType
    {
        #region members

        //      C# -> PreSeedState? State
        // GraphQL -> state: PreSeedState! (enum)
        [JsonProperty("state")]
        public PreSeedState? State { get; set; }

        //      C# -> System.String? LastPreSeededSnapshotId
        // GraphQL -> lastPreSeededSnapshotId: String (scalar)
        [JsonProperty("lastPreSeededSnapshotId")]
        public System.String? LastPreSeededSnapshotId { get; set; }

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PreSeedStatus";
    }

    public PreSeedStatus Set(
        PreSeedState? State = null,
        System.String? LastPreSeededSnapshotId = null,
        System.Single? Progress = null,
        System.String? SnapshotId = null
    ) 
    {
        if ( State != null ) {
            this.State = State;
        }
        if ( LastPreSeededSnapshotId != null ) {
            this.LastPreSeededSnapshotId = LastPreSeededSnapshotId;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
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
        //      C# -> PreSeedState? State
        // GraphQL -> state: PreSeedState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> System.String? LastPreSeededSnapshotId
        // GraphQL -> lastPreSeededSnapshotId: String (scalar)
        if (this.LastPreSeededSnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastPreSeededSnapshotId\n" ;
            } else {
                s += ind + "lastPreSeededSnapshotId\n" ;
            }
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float (scalar)
        if (this.Progress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "progress\n" ;
            } else {
                s += ind + "progress\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PreSeedState? State
        // GraphQL -> state: PreSeedState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new PreSeedState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> System.String? LastPreSeededSnapshotId
        // GraphQL -> lastPreSeededSnapshotId: String (scalar)
        if (ec.Includes("lastPreSeededSnapshotId",true))
        {
            if(this.LastPreSeededSnapshotId == null) {

                this.LastPreSeededSnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.LastPreSeededSnapshotId != null && ec.Excludes("lastPreSeededSnapshotId",true))
        {
            this.LastPreSeededSnapshotId = null;
        }
        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float (scalar)
        if (ec.Includes("progress",true))
        {
            if(this.Progress == null) {

                this.Progress = new System.Single();

            } else {


            }
        }
        else if (this.Progress != null && ec.Excludes("progress",true))
        {
            this.Progress = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
    }


    #endregion

    } // class PreSeedStatus
    
    #endregion

    public static class ListPreSeedStatusExtensions
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
            this List<PreSeedStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PreSeedStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PreSeedStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PreSeedStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PreSeedStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types