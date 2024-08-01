// AzureLiveMountDetails.cs
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
    #region AzureLiveMountDetails
    public class AzureLiveMountDetails: BaseType
    {
        #region members

        //      C# -> AzureCommonRegion? Region
        // GraphQL -> region: AzureCommonRegion! (enum)
        [JsonProperty("region")]
        public AzureCommonRegion? Region { get; set; }

        //      C# -> List<AzureDiskDetails>? DiskDetails
        // GraphQL -> diskDetails: [AzureDiskDetails!]! (type)
        [JsonProperty("diskDetails")]
        public List<AzureDiskDetails>? DiskDetails { get; set; }

        //      C# -> ResourceGroupDetails? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroupDetails (type)
        [JsonProperty("resourceGroup")]
        public ResourceGroupDetails? ResourceGroup { get; set; }

        //      C# -> VirtualMachineDetails? SourceVm
        // GraphQL -> sourceVm: VirtualMachineDetails (type)
        [JsonProperty("sourceVm")]
        public VirtualMachineDetails? SourceVm { get; set; }

        //      C# -> SubscriptionDetails? TargetSubscription
        // GraphQL -> targetSubscription: SubscriptionDetails (type)
        [JsonProperty("targetSubscription")]
        public SubscriptionDetails? TargetSubscription { get; set; }

        //      C# -> VirtualMachineDetails? TargetVm
        // GraphQL -> targetVm: VirtualMachineDetails (type)
        [JsonProperty("targetVm")]
        public VirtualMachineDetails? TargetVm { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureLiveMountDetails";
    }

    public AzureLiveMountDetails Set(
        AzureCommonRegion? Region = null,
        List<AzureDiskDetails>? DiskDetails = null,
        ResourceGroupDetails? ResourceGroup = null,
        VirtualMachineDetails? SourceVm = null,
        SubscriptionDetails? TargetSubscription = null,
        VirtualMachineDetails? TargetVm = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( DiskDetails != null ) {
            this.DiskDetails = DiskDetails;
        }
        if ( ResourceGroup != null ) {
            this.ResourceGroup = ResourceGroup;
        }
        if ( SourceVm != null ) {
            this.SourceVm = SourceVm;
        }
        if ( TargetSubscription != null ) {
            this.TargetSubscription = TargetSubscription;
        }
        if ( TargetVm != null ) {
            this.TargetVm = TargetVm;
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
        //      C# -> AzureCommonRegion? Region
        // GraphQL -> region: AzureCommonRegion! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
            }
        }
        //      C# -> List<AzureDiskDetails>? DiskDetails
        // GraphQL -> diskDetails: [AzureDiskDetails!]! (type)
        if (this.DiskDetails != null) {
            var fspec = this.DiskDetails.AsFieldSpec(conf.Child("diskDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "diskDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ResourceGroupDetails? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroupDetails (type)
        if (this.ResourceGroup != null) {
            var fspec = this.ResourceGroup.AsFieldSpec(conf.Child("resourceGroup"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resourceGroup" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VirtualMachineDetails? SourceVm
        // GraphQL -> sourceVm: VirtualMachineDetails (type)
        if (this.SourceVm != null) {
            var fspec = this.SourceVm.AsFieldSpec(conf.Child("sourceVm"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceVm" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SubscriptionDetails? TargetSubscription
        // GraphQL -> targetSubscription: SubscriptionDetails (type)
        if (this.TargetSubscription != null) {
            var fspec = this.TargetSubscription.AsFieldSpec(conf.Child("targetSubscription"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetSubscription" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VirtualMachineDetails? TargetVm
        // GraphQL -> targetVm: VirtualMachineDetails (type)
        if (this.TargetVm != null) {
            var fspec = this.TargetVm.AsFieldSpec(conf.Child("targetVm"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetVm" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureCommonRegion? Region
        // GraphQL -> region: AzureCommonRegion! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AzureCommonRegion();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
        }
        //      C# -> List<AzureDiskDetails>? DiskDetails
        // GraphQL -> diskDetails: [AzureDiskDetails!]! (type)
        if (ec.Includes("diskDetails",false))
        {
            if(this.DiskDetails == null) {

                this.DiskDetails = new List<AzureDiskDetails>();
                this.DiskDetails.ApplyExploratoryFieldSpec(ec.NewChild("diskDetails"));

            } else {

                this.DiskDetails.ApplyExploratoryFieldSpec(ec.NewChild("diskDetails"));

            }
        }
        else if (this.DiskDetails != null && ec.Excludes("diskDetails",false))
        {
            this.DiskDetails = null;
        }
        //      C# -> ResourceGroupDetails? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroupDetails (type)
        if (ec.Includes("resourceGroup",false))
        {
            if(this.ResourceGroup == null) {

                this.ResourceGroup = new ResourceGroupDetails();
                this.ResourceGroup.ApplyExploratoryFieldSpec(ec.NewChild("resourceGroup"));

            } else {

                this.ResourceGroup.ApplyExploratoryFieldSpec(ec.NewChild("resourceGroup"));

            }
        }
        else if (this.ResourceGroup != null && ec.Excludes("resourceGroup",false))
        {
            this.ResourceGroup = null;
        }
        //      C# -> VirtualMachineDetails? SourceVm
        // GraphQL -> sourceVm: VirtualMachineDetails (type)
        if (ec.Includes("sourceVm",false))
        {
            if(this.SourceVm == null) {

                this.SourceVm = new VirtualMachineDetails();
                this.SourceVm.ApplyExploratoryFieldSpec(ec.NewChild("sourceVm"));

            } else {

                this.SourceVm.ApplyExploratoryFieldSpec(ec.NewChild("sourceVm"));

            }
        }
        else if (this.SourceVm != null && ec.Excludes("sourceVm",false))
        {
            this.SourceVm = null;
        }
        //      C# -> SubscriptionDetails? TargetSubscription
        // GraphQL -> targetSubscription: SubscriptionDetails (type)
        if (ec.Includes("targetSubscription",false))
        {
            if(this.TargetSubscription == null) {

                this.TargetSubscription = new SubscriptionDetails();
                this.TargetSubscription.ApplyExploratoryFieldSpec(ec.NewChild("targetSubscription"));

            } else {

                this.TargetSubscription.ApplyExploratoryFieldSpec(ec.NewChild("targetSubscription"));

            }
        }
        else if (this.TargetSubscription != null && ec.Excludes("targetSubscription",false))
        {
            this.TargetSubscription = null;
        }
        //      C# -> VirtualMachineDetails? TargetVm
        // GraphQL -> targetVm: VirtualMachineDetails (type)
        if (ec.Includes("targetVm",false))
        {
            if(this.TargetVm == null) {

                this.TargetVm = new VirtualMachineDetails();
                this.TargetVm.ApplyExploratoryFieldSpec(ec.NewChild("targetVm"));

            } else {

                this.TargetVm.ApplyExploratoryFieldSpec(ec.NewChild("targetVm"));

            }
        }
        else if (this.TargetVm != null && ec.Excludes("targetVm",false))
        {
            this.TargetVm = null;
        }
    }


    #endregion

    } // class AzureLiveMountDetails
    
    #endregion

    public static class ListAzureLiveMountDetailsExtensions
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
            this List<AzureLiveMountDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureLiveMountDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureLiveMountDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureLiveMountDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureLiveMountDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types