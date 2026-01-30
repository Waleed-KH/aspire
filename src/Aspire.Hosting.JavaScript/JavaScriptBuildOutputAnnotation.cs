// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Aspire.Hosting.ApplicationModel;

namespace Aspire.Hosting.JavaScript;

/// <summary>
/// Represents an annotation that specifies the build output directory path.
/// </summary>
public sealed class JavaScriptBuildOutputAnnotation : IResourceAnnotation
{
    /// <summary>
    /// Gets the output path produced by the build process.
    /// </summary>
    public string Path { get; }

    /// <param name="path">The path produced by the build process.</param>
    public JavaScriptBuildOutputAnnotation(string path)
    {
        ArgumentException.ThrowIfNullOrEmpty(path);

        if (path.StartsWith('/'))
        {
            throw new ArgumentException("Build output path should not be absolute.", nameof(path));
        }

        Path = path;
    }
}
