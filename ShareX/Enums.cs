﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (C) 2008-2013 ShareX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using System;
using System.ComponentModel;

namespace ShareX
{
    public enum EImageFormat
    {
        [Description("png")]
        PNG,
        [Description("jpg")]
        JPEG,
        [Description("gif")]
        GIF,
        [Description("bmp")]
        BMP,
        [Description("tif")]
        TIFF
    }

    public enum TaskJob
    {
        DataUpload,
        FileUpload,
        ImageJob,
        TextUpload,
        ShortenURL
    }

    [Flags]
    public enum AfterCaptureTasks
    {
        None = 0,
        [Description("Add image effects")]
        AddImageEffects = 1,
        [Description("Add watermark")]
        AddWatermark = 1 << 1,
        [Description("Annotate image")]
        AnnotateImage = 1 << 2,
        [Description("Copy image to clipboard")]
        CopyImageToClipboard = 1 << 3,
        [Description("Print image")]
        SendImageToPrinter = 1 << 4,
        [Description("Save image to file")]
        SaveImageToFile = 1 << 5,
        [Description("Save image to file as...")]
        SaveImageToFileWithDialog = 1 << 6,
        [Description("Copy file to clipboard")]
        CopyFileToClipboard = 1 << 7,
        [Description("Copy file path to clipboard")]
        CopyFilePathToClipboard = 1 << 8,
        [Description("Perform actions")]
        PerformActions = 1 << 9,
        [Description("Upload image to host")]
        UploadImageToHost = 1 << 10
    }

    [Flags]
    public enum AfterUploadTasks
    {
        None = 0,
        [Description("Use URL Shortener")]
        UseURLShortener = 1,
        [Description("Post URL to social networking service")]
        ShareURLToSocialNetworkingService = 1 << 1,
        [Description("Send URL with Email")]
        SendURLWithEmail = 1 << 2,
        [Description("Copy URL to clipboard")]
        CopyURLToClipboard = 1 << 3
    }

    public enum AfterCaptureFormResult
    {
        Continue,
        Cancel,
        Copy
    }

    public enum CaptureType
    {
        Screen,
        Monitor,
        ActiveMonitor,
        Window,
        ActiveWindow,
        RectangleWindow,
        Rectangle,
        RoundedRectangle,
        Ellipse,
        Triangle,
        Diamond,
        Polygon,
        Freehand,
        LastRegion
    }

    public enum HotkeyType
    {
        [Description("None")]
        None,
        [Description("Stop all active uploads")]
        StopUploads,
        [Description("Clipboard upload")]
        ClipboardUpload,
        [Description("Clipboard upload with content viewer")]
        ClipboardUploadWithContentViewer,
        [Description("File upload")]
        FileUpload,
        [Description("Capture entire screen")]
        PrintScreen,
        [Description("Capture active window")]
        ActiveWindow,
        [Description("Capture active monitor")]
        ActiveMonitor,
        [Description("Capture rectangle region")]
        RectangleRegion,
        [Description("Capture rectangle region with window")]
        WindowRectangle,
        [Description("Capture rounded rectangle region")]
        RoundedRectangleRegion,
        [Description("Capture ellipse region")]
        EllipseRegion,
        [Description("Capture triangle region")]
        TriangleRegion,
        [Description("Capture diamond region")]
        DiamondRegion,
        [Description("Capture polygon region")]
        PolygonRegion,
        [Description("Capture freehand region")]
        FreeHandRegion,
        [Description("Capture last region")]
        LastRegion,
        [Description("Screen recorder")]
        ScreenRecorder,
        [Description("Auto capture")]
        AutoCapture,
        [Description("Screen color picker")]
        ScreenColorPicker,
        [Description("Hash check")]
        HashCheck,
        [Description("Index folder")]
        IndexFolder
    }

    public enum HotkeyStatus
    {
        Registered,
        Failed,
        NotConfigured
    }
}