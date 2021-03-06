/*!
 * @authors Ben Knight (bknight@i3drobotics.com)
 * @date 2021-05-26
 * @copyright Copyright (c) I3D Robotics Ltd, 2021
 * 
 * @file mat.cs
 * @brief Matrix class
 * @details C# class for Matrix class export.
 * DllImports for using C type exports. Pointer to class instance
 * is passed between functions.
 */

using System;
using System.Runtime.InteropServices;
using System.Runtime.ExceptionServices;

namespace I3DR.Phase
{
    public class MatrixFloat
    {
        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_create", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr MatrixFloat_create(int rows, int columns, int layers);

        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_createData", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr MatrixFloat_createData(int rows, int columns, int layers, [In] float[] data, bool copy);

        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_dispose", CallingConvention = CallingConvention.Cdecl)]
        private static extern void MatrixFloat_dispose(IntPtr MatrixFloat_ptr);

        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_getRows", CallingConvention = CallingConvention.Cdecl)]
        private static extern int MatrixFloat_getRows(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_getColumns", CallingConvention = CallingConvention.Cdecl)]
        private static extern int MatrixFloat_getColumns(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_getLayers", CallingConvention = CallingConvention.Cdecl)]
        private static extern int MatrixFloat_getLayers(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_isEmpty", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool MatrixFloat_isEmpty(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_getLength", CallingConvention = CallingConvention.Cdecl)]
        private static extern int MatrixFloat_getLength(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_getSize", CallingConvention = CallingConvention.Cdecl)]
        private static extern int MatrixFloat_getSize(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_getAt", CallingConvention = CallingConvention.Cdecl)]
        private static extern float MatrixFloat_getAt(IntPtr mat, int row, int column, int layer);

        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_setAt", CallingConvention = CallingConvention.Cdecl)]
        private static extern void MatrixFloat_setAt(IntPtr mat, int row, int column, int layer, float value);

        [DllImport("phase", EntryPoint = "I3DR_MatrixFloat_getData", CallingConvention = CallingConvention.Cdecl)]
        private static extern void MatrixFloat_getData(IntPtr mat, [Out] float[] data);

        private float[] m_data;

        private IntPtr m_MatrixFloat_ptr;

        public MatrixFloat(IntPtr MatrixFloat_ptr){
            m_MatrixFloat_ptr = MatrixFloat_ptr;
        }

        public MatrixFloat(int rows, int cols, int channels){
            m_MatrixFloat_ptr = MatrixFloat_create(rows, cols, channels);
        }

        public MatrixFloat(int rows, int cols, int channels, float[] data, bool copy){
            m_MatrixFloat_ptr = MatrixFloat_createData(rows, cols, channels, data, copy);
        }

        public IntPtr getInstancePtr(){
            return m_MatrixFloat_ptr;
        }

        public int getRows()
        {
            return MatrixFloat_getRows(m_MatrixFloat_ptr);
        }

        public int getColumns()
        {
            return MatrixFloat_getColumns(m_MatrixFloat_ptr);
        }

        public int getLayers()
        {
            return MatrixFloat_getLayers(m_MatrixFloat_ptr);
        }

        public bool isEmpty()
        {
            return MatrixFloat_isEmpty(m_MatrixFloat_ptr);
        }

        public int getLength()
        {
            return MatrixFloat_getLength(m_MatrixFloat_ptr);
        }

        public int getSize()
        {
            return MatrixFloat_getSize(m_MatrixFloat_ptr);
        }

        public void setAt(int row, int column, int layer, float value){
            MatrixFloat_setAt(m_MatrixFloat_ptr, row, column, layer, value);
        }

        public float getAt(int row, int column, int layer){
            return MatrixFloat_getAt(m_MatrixFloat_ptr, row, column, layer);
        }

        public float[] getData(){
            m_data = new float[getLength()];
            MatrixFloat_getData(m_MatrixFloat_ptr, m_data);
            return m_data;
        }

        [HandleProcessCorruptedStateExceptions]
        public void dispose(){
            if (m_MatrixFloat_ptr != IntPtr.Zero){
                try {
                    MatrixFloat_dispose(m_MatrixFloat_ptr);
                }
                catch (AccessViolationException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Please call 'dispose()' to make sure library memory is freed.");
                }
                m_MatrixFloat_ptr = IntPtr.Zero;
            }
        }

        ~MatrixFloat()
        {
            dispose();
        }
    }

    public class MatrixUInt8
    {
        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_create", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr MatrixUInt8_create(int rows, int columns, int layers);

        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_createData", CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr MatrixUInt8_createData(int rows, int columns, int layers, [In] byte[] data, bool copy);

        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_dispose", CallingConvention = CallingConvention.Cdecl)]
        private static extern void MatrixUInt8_dispose(IntPtr MatrixUInt8_ptr);

        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_getRows", CallingConvention = CallingConvention.Cdecl)]
        private static extern int MatrixUInt8_getRows(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_getColumns", CallingConvention = CallingConvention.Cdecl)]
        private static extern int MatrixUInt8_getColumns(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_getLayers", CallingConvention = CallingConvention.Cdecl)]
        private static extern int MatrixUInt8_getLayers(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_isEmpty", CallingConvention = CallingConvention.Cdecl)]
        private static extern bool MatrixUInt8_isEmpty(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_getLength", CallingConvention = CallingConvention.Cdecl)]
        private static extern int MatrixUInt8_getLength(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_getSize", CallingConvention = CallingConvention.Cdecl)]
        private static extern int MatrixUInt8_getSize(IntPtr mat);

        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_getAt", CallingConvention = CallingConvention.Cdecl)]
        private static extern byte MatrixUInt8_getAt(IntPtr mat, int row, int column, int layer);

        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_setAt", CallingConvention = CallingConvention.Cdecl)]
        private static extern void MatrixUInt8_setAt(IntPtr mat, int row, int column, int layer, byte value);

        [DllImport("phase", EntryPoint = "I3DR_MatrixUInt8_getData", CallingConvention = CallingConvention.Cdecl)]
        private static extern void MatrixUInt8_getData(IntPtr mat, [Out] byte[] data);

        private byte[] m_data;

        private IntPtr m_MatrixUInt8_ptr;

        public MatrixUInt8(IntPtr MatrixUInt8_ptr){
            m_MatrixUInt8_ptr = MatrixUInt8_ptr;
        }

        public MatrixUInt8(int rows, int cols, int channels){
            m_MatrixUInt8_ptr = MatrixUInt8_create(rows, cols, channels);
        }

        public MatrixUInt8(int rows, int cols, int channels, byte[] data, bool copy){
            m_MatrixUInt8_ptr = MatrixUInt8_createData(rows, cols, channels, data, copy);
        }

        public IntPtr getInstancePtr(){
            return m_MatrixUInt8_ptr;
        }

        public int getRows()
        {
            return MatrixUInt8_getRows(m_MatrixUInt8_ptr);
        }

        public int getColumns()
        {
            return MatrixUInt8_getColumns(m_MatrixUInt8_ptr);
        }

        public int getLayers()
        {
            return MatrixUInt8_getLayers(m_MatrixUInt8_ptr);
        }

        public bool isEmpty()
        {
            return MatrixUInt8_isEmpty(m_MatrixUInt8_ptr);
        }

        public int getLength()
        {
            return MatrixUInt8_getLength(m_MatrixUInt8_ptr);
        }

        public int getSize()
        {
            return MatrixUInt8_getSize(m_MatrixUInt8_ptr);
        }

        public void setAt(int row, int column, int layer, byte value){
            MatrixUInt8_setAt(m_MatrixUInt8_ptr, row, column, layer, value);
        }

        public byte getAt(int row, int column, int layer){
            return MatrixUInt8_getAt(m_MatrixUInt8_ptr, row, column, layer);
        }

        public byte[] getData(){
            m_data = new byte[getLength()];
            MatrixUInt8_getData(m_MatrixUInt8_ptr, m_data);
            return m_data;
        }

        [HandleProcessCorruptedStateExceptions]
        public void dispose(){
            if (m_MatrixUInt8_ptr != IntPtr.Zero){
                try {
                    MatrixUInt8_dispose(m_MatrixUInt8_ptr);
                }
                catch (AccessViolationException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Please call 'dispose()' to make sure library memory is freed.");
                }
                m_MatrixUInt8_ptr = IntPtr.Zero;
            }
        }

        ~MatrixUInt8()
        {
            dispose();
        }
    }
}