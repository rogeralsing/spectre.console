﻿using System;
using System.ComponentModel;

namespace Spectre.Console
{
    /// <summary>
    /// Contains extension methods for <see cref="Style"/>.
    /// </summary>
    public static class ObsoleteStyleExtensions
    {
        /// <summary>
        /// Creates a new style from the specified one with
        /// the specified foreground color.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <param name="color">The foreground color.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        [Obsolete("Use Foreground(..) instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Style WithForeground(this Style style, Color color)
        {
            if (style is null)
            {
                throw new ArgumentNullException(nameof(style));
            }

            return new Style(
                foreground: color,
                background: style.Background,
                decoration: style.Decoration);
        }

        /// <summary>
        /// Creates a new style from the specified one with
        /// the specified background color.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <param name="color">The background color.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        [Obsolete("Use Background(..) instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Style WithBackground(this Style style, Color color)
        {
            if (style is null)
            {
                throw new ArgumentNullException(nameof(style));
            }

            return new Style(
                foreground: style.Foreground,
                background: color,
                decoration: style.Decoration);
        }

        /// <summary>
        /// Creates a new style from the specified one with
        /// the specified text decoration.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <param name="decoration">The text decoration.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        [Obsolete("Use Decoration(..) instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Style WithDecoration(this Style style, Decoration decoration)
        {
            if (style is null)
            {
                throw new ArgumentNullException(nameof(style));
            }

            return new Style(
                foreground: style.Foreground,
                background: style.Background,
                decoration: decoration);
        }

        /// <summary>
        /// Creates a new style from the specified one with
        /// the specified link.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <param name="link">The link.</param>
        /// <returns>The same instance so that multiple calls can be chained.</returns>
        [Obsolete("Use Link(..) instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Style WithLink(this Style style, string link)
        {
            if (style is null)
            {
                throw new ArgumentNullException(nameof(style));
            }

            return new Style(
                foreground: style.Foreground,
                background: style.Background,
                decoration: style.Decoration,
                link: link);
        }
    }
}
