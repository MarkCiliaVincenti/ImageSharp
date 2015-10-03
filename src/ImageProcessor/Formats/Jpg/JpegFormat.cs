﻿// <copyright file="JpegFormat.cs" company="James South">
// Copyright © James South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageProcessor.Formats
{
    /// <summary>
    /// Encapsulates the means to encode and decode jpeg images.
    /// </summary>
    public class JpegFormat : IImageFormat
    {
        /// <inheritdoc/>
        public IImageDecoder Decoder => new JpegDecoder();

        /// <inheritdoc/>
        public IImageEncoder Encoder => new JpegEncoder();
    }
}
