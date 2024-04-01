// ConnectionStatusDetails.cs
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
    #region ConnectionStatusDetails
    public class ConnectionStatusDetails: BaseType
    {
        #region members

        //      C# -> ClusterConnectionStatus? SourceAndRubrik
        // GraphQL -> sourceAndRubrik: ClusterConnectionStatus! (enum)
        [JsonProperty("sourceAndRubrik")]
        public ClusterConnectionStatus? SourceAndRubrik { get; set; }

        //      C# -> ConnectionStatusType? SourceAndTarget
        // GraphQL -> sourceAndTarget: ConnectionStatusType! (enum)
        [JsonProperty("sourceAndTarget")]
        public ConnectionStatusType? SourceAndTarget { get; set; }

        //      C# -> ClusterConnectionStatus? TargetAndRubrik
        // GraphQL -> targetAndRubrik: ClusterConnectionStatus! (enum)
        [JsonProperty("targetAndRubrik")]
        public ClusterConnectionStatus? TargetAndRubrik { get; set; }

        //      C# -> ConnectionStatusType? TargetAndSource
        // GraphQL -> targetAndSource: ConnectionStatusType! (enum)
        [JsonProperty("targetAndSource")]
        public ConnectionStatusType? TargetAndSource { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConnectionStatusDetails";
    }

    public ConnectionStatusDetails Set(
        ClusterConnectionStatus? SourceAndRubrik = null,
        ConnectionStatusType? SourceAndTarget = null,
        ClusterConnectionStatus? TargetAndRubrik = null,
        ConnectionStatusType? TargetAndSource = null
    ) 
    {
        if ( SourceAndRubrik != null ) {
            this.SourceAndRubrik = SourceAndRubrik;
        }
        if ( SourceAndTarget != null ) {
            this.SourceAndTarget = SourceAndTarget;
        }
        if ( TargetAndRubrik != null ) {
            this.TargetAndRubrik = TargetAndRubrik;
        }
        if ( TargetAndSource != null ) {
            this.TargetAndSource = TargetAndSource;
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
        //      C# -> ClusterConnectionStatus? SourceAndRubrik
        // GraphQL -> sourceAndRubrik: ClusterConnectionStatus! (enum)
        if (this.SourceAndRubrik != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceAndRubrik\n" ;
            } else {
                s += ind + "sourceAndRubrik\n" ;
            }
        }
        //      C# -> ConnectionStatusType? SourceAndTarget
        // GraphQL -> sourceAndTarget: ConnectionStatusType! (enum)
        if (this.SourceAndTarget != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceAndTarget\n" ;
            } else {
                s += ind + "sourceAndTarget\n" ;
            }
        }
        //      C# -> ClusterConnectionStatus? TargetAndRubrik
        // GraphQL -> targetAndRubrik: ClusterConnectionStatus! (enum)
        if (this.TargetAndRubrik != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetAndRubrik\n" ;
            } else {
                s += ind + "targetAndRubrik\n" ;
            }
        }
        //      C# -> ConnectionStatusType? TargetAndSource
        // GraphQL -> targetAndSource: ConnectionStatusType! (enum)
        if (this.TargetAndSource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetAndSource\n" ;
            } else {
                s += ind + "targetAndSource\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ClusterConnectionStatus? SourceAndRubrik
        // GraphQL -> sourceAndRubrik: ClusterConnectionStatus! (enum)
        if (ec.Includes("sourceAndRubrik",true))
        {
            if(this.SourceAndRubrik == null) {

                this.SourceAndRubrik = new ClusterConnectionStatus();

            } else {


            }
        }
        else if (this.SourceAndRubrik != null && ec.Excludes("sourceAndRubrik",true))
        {
            this.SourceAndRubrik = null;
        }
        //      C# -> ConnectionStatusType? SourceAndTarget
        // GraphQL -> sourceAndTarget: ConnectionStatusType! (enum)
        if (ec.Includes("sourceAndTarget",true))
        {
            if(this.SourceAndTarget == null) {

                this.SourceAndTarget = new ConnectionStatusType();

            } else {


            }
        }
        else if (this.SourceAndTarget != null && ec.Excludes("sourceAndTarget",true))
        {
            this.SourceAndTarget = null;
        }
        //      C# -> ClusterConnectionStatus? TargetAndRubrik
        // GraphQL -> targetAndRubrik: ClusterConnectionStatus! (enum)
        if (ec.Includes("targetAndRubrik",true))
        {
            if(this.TargetAndRubrik == null) {

                this.TargetAndRubrik = new ClusterConnectionStatus();

            } else {


            }
        }
        else if (this.TargetAndRubrik != null && ec.Excludes("targetAndRubrik",true))
        {
            this.TargetAndRubrik = null;
        }
        //      C# -> ConnectionStatusType? TargetAndSource
        // GraphQL -> targetAndSource: ConnectionStatusType! (enum)
        if (ec.Includes("targetAndSource",true))
        {
            if(this.TargetAndSource == null) {

                this.TargetAndSource = new ConnectionStatusType();

            } else {


            }
        }
        else if (this.TargetAndSource != null && ec.Excludes("targetAndSource",true))
        {
            this.TargetAndSource = null;
        }
    }


    #endregion

    } // class ConnectionStatusDetails
    
    #endregion

    public static class ListConnectionStatusDetailsExtensions
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
            this List<ConnectionStatusDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConnectionStatusDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConnectionStatusDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConnectionStatusDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConnectionStatusDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types