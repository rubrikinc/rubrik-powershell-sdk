// PendingActionType.cs
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
    #region PendingActionType
    public class PendingActionType: BaseType
    {
        #region members

        //      C# -> PendingActionGroupTypeEnum? PendingActionGroupType
        // GraphQL -> pendingActionGroupType: PendingActionGroupTypeEnum! (enum)
        [JsonProperty("pendingActionGroupType")]
        public PendingActionGroupTypeEnum? PendingActionGroupType { get; set; }

        //      C# -> PendingActionSubGroupTypeEnum? PendingActionSubGroupType
        // GraphQL -> pendingActionSubGroupType: PendingActionSubGroupTypeEnum! (enum)
        [JsonProperty("pendingActionSubGroupType")]
        public PendingActionSubGroupTypeEnum? PendingActionSubGroupType { get; set; }

        //      C# -> PendingActionSyncType? PendingActionSyncType
        // GraphQL -> pendingActionSyncType: PendingActionSyncType! (enum)
        [JsonProperty("pendingActionSyncType")]
        public PendingActionSyncType? PendingActionSyncType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PendingActionType";
    }

    public PendingActionType Set(
        PendingActionGroupTypeEnum? PendingActionGroupType = null,
        PendingActionSubGroupTypeEnum? PendingActionSubGroupType = null,
        PendingActionSyncType? PendingActionSyncType = null
    ) 
    {
        if ( PendingActionGroupType != null ) {
            this.PendingActionGroupType = PendingActionGroupType;
        }
        if ( PendingActionSubGroupType != null ) {
            this.PendingActionSubGroupType = PendingActionSubGroupType;
        }
        if ( PendingActionSyncType != null ) {
            this.PendingActionSyncType = PendingActionSyncType;
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
        //      C# -> PendingActionGroupTypeEnum? PendingActionGroupType
        // GraphQL -> pendingActionGroupType: PendingActionGroupTypeEnum! (enum)
        if (this.PendingActionGroupType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingActionGroupType\n" ;
            } else {
                s += ind + "pendingActionGroupType\n" ;
            }
        }
        //      C# -> PendingActionSubGroupTypeEnum? PendingActionSubGroupType
        // GraphQL -> pendingActionSubGroupType: PendingActionSubGroupTypeEnum! (enum)
        if (this.PendingActionSubGroupType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingActionSubGroupType\n" ;
            } else {
                s += ind + "pendingActionSubGroupType\n" ;
            }
        }
        //      C# -> PendingActionSyncType? PendingActionSyncType
        // GraphQL -> pendingActionSyncType: PendingActionSyncType! (enum)
        if (this.PendingActionSyncType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingActionSyncType\n" ;
            } else {
                s += ind + "pendingActionSyncType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PendingActionGroupTypeEnum? PendingActionGroupType
        // GraphQL -> pendingActionGroupType: PendingActionGroupTypeEnum! (enum)
        if (ec.Includes("pendingActionGroupType",true))
        {
            if(this.PendingActionGroupType == null) {

                this.PendingActionGroupType = new PendingActionGroupTypeEnum();

            } else {


            }
        }
        else if (this.PendingActionGroupType != null && ec.Excludes("pendingActionGroupType",true))
        {
            this.PendingActionGroupType = null;
        }
        //      C# -> PendingActionSubGroupTypeEnum? PendingActionSubGroupType
        // GraphQL -> pendingActionSubGroupType: PendingActionSubGroupTypeEnum! (enum)
        if (ec.Includes("pendingActionSubGroupType",true))
        {
            if(this.PendingActionSubGroupType == null) {

                this.PendingActionSubGroupType = new PendingActionSubGroupTypeEnum();

            } else {


            }
        }
        else if (this.PendingActionSubGroupType != null && ec.Excludes("pendingActionSubGroupType",true))
        {
            this.PendingActionSubGroupType = null;
        }
        //      C# -> PendingActionSyncType? PendingActionSyncType
        // GraphQL -> pendingActionSyncType: PendingActionSyncType! (enum)
        if (ec.Includes("pendingActionSyncType",true))
        {
            if(this.PendingActionSyncType == null) {

                this.PendingActionSyncType = new PendingActionSyncType();

            } else {


            }
        }
        else if (this.PendingActionSyncType != null && ec.Excludes("pendingActionSyncType",true))
        {
            this.PendingActionSyncType = null;
        }
    }


    #endregion

    } // class PendingActionType
    
    #endregion

    public static class ListPendingActionTypeExtensions
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
            this List<PendingActionType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<PendingActionType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PendingActionType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PendingActionType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PendingActionType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types