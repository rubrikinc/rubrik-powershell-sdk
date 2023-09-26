// SetDatastoreFreespaceThresholdsReply.cs
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
    #region SetDatastoreFreespaceThresholdsReply
    public class SetDatastoreFreespaceThresholdsReply: BaseType
    {
        #region members

        //      C# -> List<DatastoreFreespaceThresholdType>? Thresholds
        // GraphQL -> thresholds: [DatastoreFreespaceThresholdType!]! (type)
        [JsonProperty("thresholds")]
        public List<DatastoreFreespaceThresholdType>? Thresholds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SetDatastoreFreespaceThresholdsReply";
    }

    public SetDatastoreFreespaceThresholdsReply Set(
        List<DatastoreFreespaceThresholdType>? Thresholds = null
    ) 
    {
        if ( Thresholds != null ) {
            this.Thresholds = Thresholds;
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
        //      C# -> List<DatastoreFreespaceThresholdType>? Thresholds
        // GraphQL -> thresholds: [DatastoreFreespaceThresholdType!]! (type)
        if (this.Thresholds != null) {
            var fspec = this.Thresholds.AsFieldSpec(conf.Child("thresholds"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "thresholds {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<DatastoreFreespaceThresholdType>? Thresholds
        // GraphQL -> thresholds: [DatastoreFreespaceThresholdType!]! (type)
        if (ec.Includes("thresholds",false))
        {
            if(this.Thresholds == null) {

                this.Thresholds = new List<DatastoreFreespaceThresholdType>();
                this.Thresholds.ApplyExploratoryFieldSpec(ec.NewChild("thresholds"));

            } else {

                this.Thresholds.ApplyExploratoryFieldSpec(ec.NewChild("thresholds"));

            }
        }
        else if (this.Thresholds != null && ec.Excludes("thresholds",false))
        {
            this.Thresholds = null;
        }
    }


    #endregion

    } // class SetDatastoreFreespaceThresholdsReply
    
    #endregion

    public static class ListSetDatastoreFreespaceThresholdsReplyExtensions
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
            this List<SetDatastoreFreespaceThresholdsReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SetDatastoreFreespaceThresholdsReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SetDatastoreFreespaceThresholdsReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SetDatastoreFreespaceThresholdsReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types