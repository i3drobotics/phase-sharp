/*!
 * @authors Ben Knight (bknight@i3drobotics.com)
 * @date 2021-05-26
 * @copyright Copyright (c) I3D Robotics Ltd, 2021
 * 
 * @file cameradeviceinfo.cs
 * @brief Camera Device Info class
 * @details C# class for Camera Device Info class export.
 * DllImports for using C type exports. Pointer to class instance
 * is passed between functions.
 */

using System;
using System.Runtime.InteropServices;
using System.Runtime.ExceptionServices;

namespace I3DR.Phase
{
    public struct CameraDeviceInfo {
        public string left_camera_serial; // right camera serial
        public string right_camera_serial; // left camera serial
        public string unique_serial; // defined unique serial for stereo camera pair
        public CameraDeviceType device_type; // device type of camera
        public CameraInterfaceType interface_type; // interface type of camera
        public CameraDeviceInfo(
            string left_camera_serial, string right_camera_serial,
            string unique_serial, 
            CameraDeviceType device_type, CameraInterfaceType interface_type
            )
        {
            this.left_camera_serial = left_camera_serial;
            this.right_camera_serial = right_camera_serial;
            this.unique_serial = unique_serial;
            this.device_type = device_type;
            this.interface_type = interface_type;
        }
    };
}