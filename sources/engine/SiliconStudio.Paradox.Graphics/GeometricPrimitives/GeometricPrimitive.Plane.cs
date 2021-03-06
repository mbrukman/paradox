﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
//
// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using SiliconStudio.Core.Mathematics;

namespace SiliconStudio.Paradox.Graphics.GeometricPrimitives
{
    public partial class GeometricPrimitive
    {
        /// <summary>
        /// A plane primitive.
        /// </summary>
        public static class Plane
        {
            /// <summary>
            /// Creates a Plane primitive on the X/Y plane with a normal equal to -<see cref="Vector3.UnitZ"/>.
            /// </summary>
            /// <param name="device">The device.</param>
            /// <param name="sizeX">The size X.</param>
            /// <param name="sizeY">The size Y.</param>
            /// <param name="tessellationX">The tessellation, as the number of quads per X axis.</param>
            /// <param name="tessellationY">The tessellation, as the number of quads per Y axis.</param>
            /// <param name="toLeftHanded">if set to <c>true</c> vertices and indices will be transformed to left handed. Default is false.</param>
            /// <param name="uFactor">Scale U coordinates between 0 and the values of this parameter.</param>
            /// <param name="vFactor">Scale V coordinates 0 and the values of this parameter.</param>
            /// <param name="generateBackFace">Add a back face to the plane</param>
            /// <returns>A Plane primitive.</returns>
            /// <exception cref="System.ArgumentOutOfRangeException">tessellation;tessellation must be > 0</exception>
            public static GeometricPrimitive New(GraphicsDevice device, float sizeX = 1.0f, float sizeY = 1.0f, int tessellationX = 1, int tessellationY = 1, float uFactor = 1f, float vFactor = 1f, bool generateBackFace = false, bool toLeftHanded = false)
            {
                return new GeometricPrimitive(device, New(sizeX, sizeY, tessellationX, tessellationY, uFactor, vFactor, generateBackFace, toLeftHanded));
            }

            /// <summary>
            /// Creates a Plane primitive on the X/Y plane with a normal equal to -<see cref="Vector3.UnitZ"/>.
            /// </summary>
            /// <param name="sizeX">The size X.</param>
            /// <param name="sizeY">The size Y.</param>
            /// <param name="tessellationX">The tessellation, as the number of quads per X axis.</param>
            /// <param name="tessellationY">The tessellation, as the number of quads per Y axis.</param>
            /// <param name="toLeftHanded">if set to <c>true</c> vertices and indices will be transformed to left handed. Default is false.</param>
            /// <param name="uFactor">Scale U coordinates between 0 and the values of this parameter.</param>
            /// <param name="vFactor">Scale V coordinates 0 and the values of this parameter.</param>
            /// <param name="generateBackFace">Add a back face to the plane</param>
            /// <returns>A Plane primitive.</returns>
            /// <exception cref="System.ArgumentOutOfRangeException">tessellation;tessellation must be > 0</exception>
            public static GeometricMeshData<VertexPositionNormalTexture> New(float sizeX = 1.0f, float sizeY = 1.0f, int tessellationX = 1, int tessellationY = 1, float uFactor = 1f, float vFactor = 1f, bool generateBackFace = false, bool toLeftHanded = false)
            {
                if (tessellationX < 1)
                    tessellationX = 1;
                if (tessellationY < 1)
                    tessellationY = 1;

                var lineWidth = tessellationX + 1;
                var lineHeight = tessellationY + 1;
                var vertices = new VertexPositionNormalTexture[lineWidth * lineHeight * (generateBackFace? 2: 1)];
                var indices = new int[tessellationX * tessellationY * 6 * (generateBackFace? 2: 1)];

                var deltaX = sizeX / tessellationX;
                var deltaY = sizeY / tessellationY;

                sizeX /= 2.0f;
                sizeY /= 2.0f;

                int vertexCount = 0;
                int indexCount = 0;
                var normal = Vector3.UnitZ;

                var uv = new Vector2(uFactor, vFactor);

                // Create vertices
                for (int y = 0; y < (tessellationY + 1); y++)
                {
                    for (int x = 0; x < (tessellationX + 1); x++)
                    {
                        var position = new Vector3(-sizeX + deltaX * x, sizeY - deltaY * y, 0);
                        var texCoord = new Vector2(uv.X * x / tessellationX, uv.Y * y / tessellationY);
                        vertices[vertexCount++] = new VertexPositionNormalTexture(position, normal, texCoord);
                    }
                }

                // Create indices
                for (int y = 0; y < tessellationY; y++)
                {
                    for (int x = 0; x < tessellationX; x++)
                    {
                        // Six indices (two triangles) per face.
                        int vbase = lineWidth * y + x;
                        indices[indexCount++] = (vbase + 1);
                        indices[indexCount++] = (vbase + 1 + lineWidth);
                        indices[indexCount++] = (vbase + lineWidth);

                        indices[indexCount++] = (vbase + 1);
                        indices[indexCount++] = (vbase + lineWidth);
                        indices[indexCount++] = (vbase);
                    }
                }
                if(generateBackFace)
                {
                    normal = -Vector3.UnitZ;
                    for (int y = 0; y < (tessellationY + 1); y++)
                    {
                        for (int x = 0; x < (tessellationX + 1); x++)
                        {
                            var position = new Vector3(-sizeX + deltaX * x, sizeY - deltaY * y, 0);
                            var texCoord = new Vector2(uv.X * x / tessellationX, uv.Y * y / tessellationY);
                            vertices[vertexCount++] = new VertexPositionNormalTexture(position, normal, texCoord);
                        }
                    }
                    // Create indices
                    for (int y = 0; y < tessellationY; y++)
                    {
                        for (int x = 0; x < tessellationX; x++)
                        {
                            // Six indices (two triangles) per face.
                            int vbase = lineWidth * (y + tessellationY + 1) + x;
                            indices[indexCount++] = (vbase + 1);
                            indices[indexCount++] = (vbase + lineWidth);
                            indices[indexCount++] = (vbase + 1 + lineWidth);

                            indices[indexCount++] = (vbase + 1);
                            indices[indexCount++] = (vbase);
                            indices[indexCount++] = (vbase + lineWidth);
                        }
                    }
                }

                // Create the primitive object.
                return new GeometricMeshData<VertexPositionNormalTexture>(vertices, indices, toLeftHanded) { Name = "Plane" };
            }
        }
    }
}