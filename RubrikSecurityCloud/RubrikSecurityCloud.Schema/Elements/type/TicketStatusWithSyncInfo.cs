// TicketStatusWithSyncInfo.cs
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
    #region TicketStatusWithSyncInfo
    public class TicketStatusWithSyncInfo: BaseType
    {
        #region members

        //      C# -> TicketStatus? Status
        // GraphQL -> status: TicketStatus! (enum)
        [JsonProperty("status")]
        public TicketStatus? Status { get; set; }

        //      C# -> TicketStatusSyncInfo? SyncInfo
        // GraphQL -> syncInfo: TicketStatusSyncInfo! (enum)
        [JsonProperty("syncInfo")]
        public TicketStatusSyncInfo? SyncInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TicketStatusWithSyncInfo";
    }

    public TicketStatusWithSyncInfo Set(
        TicketStatus? Status = null,
        TicketStatusSyncInfo? SyncInfo = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( SyncInfo != null ) {
            this.SyncInfo = SyncInfo;
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
        //      C# -> TicketStatus? Status
        // GraphQL -> status: TicketStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> TicketStatusSyncInfo? SyncInfo
        // GraphQL -> syncInfo: TicketStatusSyncInfo! (enum)
        if (this.SyncInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "syncInfo\n" ;
            } else {
                s += ind + "syncInfo\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> TicketStatus? Status
        // GraphQL -> status: TicketStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new TicketStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> TicketStatusSyncInfo? SyncInfo
        // GraphQL -> syncInfo: TicketStatusSyncInfo! (enum)
        if (ec.Includes("syncInfo",true))
        {
            if(this.SyncInfo == null) {

                this.SyncInfo = new TicketStatusSyncInfo();

            } else {


            }
        }
        else if (this.SyncInfo != null && ec.Excludes("syncInfo",true))
        {
            this.SyncInfo = null;
        }
    }


    #endregion

    } // class TicketStatusWithSyncInfo
    
    #endregion

    public static class ListTicketStatusWithSyncInfoExtensions
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
            this List<TicketStatusWithSyncInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<TicketStatusWithSyncInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<TicketStatusWithSyncInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TicketStatusWithSyncInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<TicketStatusWithSyncInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types