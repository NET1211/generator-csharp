﻿using gax = Google.Api.Gax;
using sys = System;
using ts = Testing.Serverstreaming;

// This file isn't being tested; the following line disables testing.
// TEST_DISABLE

namespace Testing.Serverstreaming
{
    /// <summary>Resource name for the <c>Resource</c> resource</summary>
    public sealed partial class ResourceName : gax::IResourceName, sys::IEquatable<ResourceName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("items/{item_id}");

        /// <summary>
        /// Parses the given <c>Resource</c> resource name in string form into a new <see cref="ResourceName"/>
        /// instance.
        /// </summary>
        /// <param name="resource">The <c>Resource</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ResourceName"/> if successful.</returns>
        public static ResourceName Parse(string resource)
        {
            gax::GaxPreconditions.CheckNotNull(resource, nameof(resource));
            gax::TemplatedResourceName resourceName = s_template.ParseName(resource);
            return new ResourceName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="ResourceName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="resource"/> is <c>null</c>
        /// , as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="resource">The <c>Resource</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ResourceName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string resource, out ResourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(resource, nameof(resource));
            if (s_template.TryParseName(resource, out gax::TemplatedResourceName resourceName))
            {
                result = new ResourceName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ResourceName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="itemId">The itemId ID. Must not be <c>null</c>.</param>
        public ResourceName(string itemId) => ItemId = gax::GaxPreconditions.CheckNotNull(itemId, nameof(itemId));

        /// <summary>The ItemId ID. Never <c>null</c>.</summary>
        public string ItemId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ItemId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ResourceName);

        /// <inheritdoc/>
        public bool Equals(ResourceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ResourceName a, ResourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ResourceName a, ResourceName b) => !(a == b);
    }

    public partial class ResourceRequest
    {
        /// <summary>
        /// <see cref="ts::ResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public ResourceName ResourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : ResourceName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
