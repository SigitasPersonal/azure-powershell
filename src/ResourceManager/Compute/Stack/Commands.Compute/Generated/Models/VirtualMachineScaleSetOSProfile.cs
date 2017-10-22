// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes a virtual machine scale set OS profile.
    /// </summary>
    public partial class VirtualMachineScaleSetOSProfile
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetOSProfile
        /// class.
        /// </summary>
        public VirtualMachineScaleSetOSProfile() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetOSProfile
        /// class.
        /// </summary>
        public VirtualMachineScaleSetOSProfile(string computerNamePrefix = default(string), string adminUsername = default(string), string adminPassword = default(string), string customData = default(string), WindowsConfiguration windowsConfiguration = default(WindowsConfiguration), LinuxConfiguration linuxConfiguration = default(LinuxConfiguration), IList<VaultSecretGroup> secrets = default(IList<VaultSecretGroup>))
        {
            ComputerNamePrefix = computerNamePrefix;
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
            CustomData = customData;
            WindowsConfiguration = windowsConfiguration;
            LinuxConfiguration = linuxConfiguration;
            Secrets = secrets;
        }

        /// <summary>
        /// Gets or sets the computer name prefix.
        /// </summary>
        [JsonProperty(PropertyName = "computerNamePrefix")]
        public string ComputerNamePrefix { get; set; }

        /// <summary>
        /// Gets or sets the admin user name.
        /// </summary>
        [JsonProperty(PropertyName = "adminUsername")]
        public string AdminUsername { get; set; }

        /// <summary>
        /// Gets or sets the admin user password.
        /// </summary>
        [JsonProperty(PropertyName = "adminPassword")]
        public string AdminPassword { get; set; }

        /// <summary>
        /// Gets or sets a base-64 encoded string of custom data.
        /// </summary>
        [JsonProperty(PropertyName = "customData")]
        public string CustomData { get; set; }

        /// <summary>
        /// Gets or sets the Windows Configuration of the OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "windowsConfiguration")]
        public WindowsConfiguration WindowsConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the Linux Configuration of the OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "linuxConfiguration")]
        public LinuxConfiguration LinuxConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the List of certificates for addition to the VM.
        /// </summary>
        [JsonProperty(PropertyName = "secrets")]
        public IList<VaultSecretGroup> Secrets { get; set; }

    }
}
