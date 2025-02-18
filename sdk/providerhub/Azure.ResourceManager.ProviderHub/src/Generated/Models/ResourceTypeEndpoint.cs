// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeEndpoint. </summary>
    public partial class ResourceTypeEndpoint
    {
        /// <summary> Initializes a new instance of ResourceTypeEndpoint. </summary>
        public ResourceTypeEndpoint()
        {
            ApiVersions = new ChangeTrackingList<string>();
            Locations = new ChangeTrackingList<AzureLocation>();
            RequiredFeatures = new ChangeTrackingList<string>();
            Extensions = new ChangeTrackingList<ResourceTypeExtension>();
        }

        /// <summary> Initializes a new instance of ResourceTypeEndpoint. </summary>
        /// <param name="isEnabled"></param>
        /// <param name="apiVersions"></param>
        /// <param name="locations"></param>
        /// <param name="requiredFeatures"></param>
        /// <param name="featuresRule"></param>
        /// <param name="extensions"></param>
        /// <param name="timeout"></param>
        internal ResourceTypeEndpoint(bool? isEnabled, IList<string> apiVersions, IList<AzureLocation> locations, IList<string> requiredFeatures, FeaturesRule featuresRule, IList<ResourceTypeExtension> extensions, TimeSpan? timeout)
        {
            IsEnabled = isEnabled;
            ApiVersions = apiVersions;
            Locations = locations;
            RequiredFeatures = requiredFeatures;
            FeaturesRule = featuresRule;
            Extensions = extensions;
            Timeout = timeout;
        }

        /// <summary> Gets or sets the is enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Gets the api versions. </summary>
        public IList<string> ApiVersions { get; }
        /// <summary> Gets the locations. </summary>
        public IList<AzureLocation> Locations { get; }
        /// <summary> Gets the required features. </summary>
        public IList<string> RequiredFeatures { get; }
        /// <summary> Gets or sets the features rule. </summary>
        internal FeaturesRule FeaturesRule { get; set; }
        /// <summary> Gets or sets the required features policy. </summary>
        public FeaturesPolicy? RequiredFeaturesPolicy
        {
            get => FeaturesRule is null ? default(FeaturesPolicy?) : FeaturesRule.RequiredFeaturesPolicy;
            set
            {
                FeaturesRule = value.HasValue ? new FeaturesRule(value.Value) : null;
            }
        }

        /// <summary> Gets the extensions. </summary>
        public IList<ResourceTypeExtension> Extensions { get; }
        /// <summary> Gets or sets the timeout. </summary>
        public TimeSpan? Timeout { get; set; }
    }
}
