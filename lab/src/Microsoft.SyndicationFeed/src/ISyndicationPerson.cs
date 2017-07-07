// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.SyndicationFeed
{
    public interface ISyndicationPerson
    {
        string Email { get; }

        string Name { get; }

        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "property", Justification = "The Uri represents a unique category and not a network location")]
        string Uri { get; }

        //
        // TODO:
        // Add support for Extensions
    }
}