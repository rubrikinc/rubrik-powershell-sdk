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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> AzureCommonRegion? Region
        // GraphQL -> region: AzureCommonRegion! (enum)
        if (this.Region != null) {
            s += ind + "region\n" ;
        }
        //      C# -> List<AzureDiskDetails>? DiskDetails
        // GraphQL -> diskDetails: [AzureDiskDetails!]! (type)
        if (this.DiskDetails != null) {
            var fspec = this.DiskDetails.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "diskDetails {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ResourceGroupDetails? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroupDetails (type)
        if (this.ResourceGroup != null) {
            var fspec = this.ResourceGroup.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "resourceGroup {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VirtualMachineDetails? SourceVm
        // GraphQL -> sourceVm: VirtualMachineDetails (type)
        if (this.SourceVm != null) {
            var fspec = this.SourceVm.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceVm {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SubscriptionDetails? TargetSubscription
        // GraphQL -> targetSubscription: SubscriptionDetails (type)
        if (this.TargetSubscription != null) {
            var fspec = this.TargetSubscription.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetSubscription {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VirtualMachineDetails? TargetVm
        // GraphQL -> targetVm: VirtualMachineDetails (type)
        if (this.TargetVm != null) {
            var fspec = this.TargetVm.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetVm {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureCommonRegion? Region
        // GraphQL -> region: AzureCommonRegion! (enum)
        if (this.Region == null && Exploration.Includes(parent + ".region", true))
        {
            this.Region = new AzureCommonRegion();
        }
        //      C# -> List<AzureDiskDetails>? DiskDetails
        // GraphQL -> diskDetails: [AzureDiskDetails!]! (type)
        if (this.DiskDetails == null && Exploration.Includes(parent + ".diskDetails"))
        {
            this.DiskDetails = new List<AzureDiskDetails>();
            this.DiskDetails.ApplyExploratoryFieldSpec(parent + ".diskDetails");
        }
        //      C# -> ResourceGroupDetails? ResourceGroup
        // GraphQL -> resourceGroup: ResourceGroupDetails (type)
        if (this.ResourceGroup == null && Exploration.Includes(parent + ".resourceGroup"))
        {
            this.ResourceGroup = new ResourceGroupDetails();
            this.ResourceGroup.ApplyExploratoryFieldSpec(parent + ".resourceGroup");
        }
        //      C# -> VirtualMachineDetails? SourceVm
        // GraphQL -> sourceVm: VirtualMachineDetails (type)
        if (this.SourceVm == null && Exploration.Includes(parent + ".sourceVm"))
        {
            this.SourceVm = new VirtualMachineDetails();
            this.SourceVm.ApplyExploratoryFieldSpec(parent + ".sourceVm");
        }
        //      C# -> SubscriptionDetails? TargetSubscription
        // GraphQL -> targetSubscription: SubscriptionDetails (type)
        if (this.TargetSubscription == null && Exploration.Includes(parent + ".targetSubscription"))
        {
            this.TargetSubscription = new SubscriptionDetails();
            this.TargetSubscription.ApplyExploratoryFieldSpec(parent + ".targetSubscription");
        }
        //      C# -> VirtualMachineDetails? TargetVm
        // GraphQL -> targetVm: VirtualMachineDetails (type)
        if (this.TargetVm == null && Exploration.Includes(parent + ".targetVm"))
        {
            this.TargetVm = new VirtualMachineDetails();
            this.TargetVm.ApplyExploratoryFieldSpec(parent + ".targetVm");
        }
    }


    #endregion

    } // class AzureLiveMountDetails
    
    #endregion

    public static class ListAzureLiveMountDetailsExtensions
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
            this List<AzureLiveMountDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureLiveMountDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureLiveMountDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types