﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel;
using Microsoft.Toolkit.Forms.UI.XamlHost;
using Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT;
using Windows.UI.Xaml;

namespace Microsoft.Toolkit.Forms.UI.Controls
{
    /// <summary>
    /// WinForms-enabled wrapper for <see cref="Windows.UI.Xaml.Controls.InkToolbarCustomToolButton"/>
    /// </summary>
    [Designer(typeof(InkToolbarToolButtonDesigner))]
    public class InkToolbarCustomToolButton : WindowsXamlHostBase
    {
        internal Windows.UI.Xaml.Controls.InkToolbarCustomToolButton UwpControl => ChildInternal as Windows.UI.Xaml.Controls.InkToolbarCustomToolButton;

#pragma warning disable SA1306 // Field names must begin with lower-case letter
#pragma warning disable CS0414 // Value is never used
        private bool _IsExtensionGlyphShown = false;
        private Windows.UI.Xaml.UIElement _ConfigurationContent = null;
#pragma warning restore SA1306 // Field names must begin with lower-case letter
#pragma warning restore CS0414 // Value is never used

        /// <summary>
        /// Initializes a new instance of the <see cref="InkToolbarCustomToolButton"/> class, a
        /// WinForms-enabled wrapper for <see cref="Windows.UI.Xaml.Controls.InkToolbarCustomToolButton"/>
        /// </summary>
        public InkToolbarCustomToolButton()
            : this(typeof(Windows.UI.Xaml.Controls.InkToolbarCustomToolButton).FullName)
        {
        }

        protected InkToolbarCustomToolButton(string name)
            : base(name)
        {
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }

        /// <inheritdoc />
        protected override void SetContent(UIElement newValue)
        {
            // intentionally empty
        }

        /// <summary>
        /// Gets or sets a value indicating whether the underlying Uwp control's IsExtensionGlyphShown property is set <see cref="Windows.UI.Xaml.Controls.InkToolbarToolButton.IsExtensionGlyphShown"/>
        /// </summary>
        public bool IsExtensionGlyphShown
        {
            get => (bool)this.GetUwpControlValue();
            set => this.SetUwpControlValue(value);
        }

        /// <summary>
        /// Gets the underlying Uwp control's Toolkind property <see cref="Windows.UI.Xaml.Controls.InkToolbarToolButton.ToolKind"/>
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public InkToolbarTool ToolKind { get => (InkToolbarTool)UwpControl?.ToolKind; }

        /// <summary>
        /// Gets or sets the underlying Uwp control's ConfigurationContent property <see cref="Windows.UI.Xaml.Controls.InkToolbarCustomToolButton.ConfigurationContent"/>
        /// </summary>
        public object ConfigurationContent
        {
            get => this.GetUwpControlValue();
            set => this.SetUwpControlValue(value as Windows.UI.Xaml.UIElement);
        }
    }
}