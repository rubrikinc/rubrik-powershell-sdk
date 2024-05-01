// EndManagedVolumeSnapshotReply.cs
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
    #region EndManagedVolumeSnapshotReply
    public class EndManagedVolumeSnapshotReply: BaseType
    {
        #region members

        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        [JsonProperty("asyncRequestStatus")]
        public AsyncRequestStatus? AsyncRequestStatus { get; set; }

        //      C# -> ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary
        // GraphQL -> managedVolumeSnapshotSummary: ManagedVolumeSnapshotSummary (type)
        [JsonProperty("managedVolumeSnapshotSummary")]
        public ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EndManagedVolumeSnapshotReply";
    }

    public EndManagedVolumeSnapshotReply Set(
        AsyncRequestStatus? AsyncRequestStatus = null,
        ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary = null
    ) 
    {
        if ( AsyncRequestStatus != null ) {
            this.AsyncRequestStatus = AsyncRequestStatus;
        }
        if ( ManagedVolumeSnapshotSummary != null ) {
            this.ManagedVolumeSnapshotSummary = ManagedVolumeSnapshotSummary;
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
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (this.AsyncRequestStatus != null) {
            var fspec = this.AsyncRequestStatus.AsFieldSpec(conf.Child("asyncRequestStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "asyncRequestStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary
        // GraphQL -> managedVolumeSnapshotSummary: ManagedVolumeSnapshotSummary (type)
        if (this.ManagedVolumeSnapshotSummary != null) {
            var fspec = this.ManagedVolumeSnapshotSummary.AsFieldSpec(conf.Child("managedVolumeSnapshotSummary"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "managedVolumeSnapshotSummary" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AsyncRequestStatus? AsyncRequestStatus
        // GraphQL -> asyncRequestStatus: AsyncRequestStatus (type)
        if (ec.Includes("asyncRequestStatus",false))
        {
            if(this.AsyncRequestStatus == null) {

                this.AsyncRequestStatus = new AsyncRequestStatus();
                this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));

            } else {

                this.AsyncRequestStatus.ApplyExploratoryFieldSpec(ec.NewChild("asyncRequestStatus"));

            }
        }
        else if (this.AsyncRequestStatus != null && ec.Excludes("asyncRequestStatus",false))
        {
            this.AsyncRequestStatus = null;
        }
        //      C# -> ManagedVolumeSnapshotSummary? ManagedVolumeSnapshotSummary
        // GraphQL -> managedVolumeSnapshotSummary: ManagedVolumeSnapshotSummary (type)
        if (ec.Includes("managedVolumeSnapshotSummary",false))
        {
            if(this.ManagedVolumeSnapshotSummary == null) {

                this.ManagedVolumeSnapshotSummary = new ManagedVolumeSnapshotSummary();
                this.ManagedVolumeSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeSnapshotSummary"));

            } else {

                this.ManagedVolumeSnapshotSummary.ApplyExploratoryFieldSpec(ec.NewChild("managedVolumeSnapshotSummary"));

            }
        }
        else if (this.ManagedVolumeSnapshotSummary != null && ec.Excludes("managedVolumeSnapshotSummary",false))
        {
            this.ManagedVolumeSnapshotSummary = null;
        }
    }


    #endregion

    } // class EndManagedVolumeSnapshotReply
    
    #endregion

    public static class ListEndManagedVolumeSnapshotReplyExtensions
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
            this List<EndManagedVolumeSnapshotReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EndManagedVolumeSnapshotReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EndManagedVolumeSnapshotReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EndManagedVolumeSnapshotReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EndManagedVolumeSnapshotReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types