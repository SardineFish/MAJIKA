using UnityEngine;
using System.Collections;
using System;

public class MeshBuilder
{
    public Vector3[] Vertices;
    public int[] Triangles;
    int VerticesCount = 0;
    int TriangleCount = 0;

    public MeshBuilder() : this(0, 0)
    {

    }

    public MeshBuilder(int vertCount, int triangleCount)
    {
        Vertices = new Vector3[vertCount];
        Triangles = new int[triangleCount * 3];
    }

    public void AddVertsAndTriangles(Vector3[] vertices, int[] triangles)
    {
        var offset = VerticesCount;
        for (var i = 0; i < vertices.Length; i++)
            Vertices[offset + i] = vertices[i];
        for (var i = 0; i < triangles.Length; i++)
            Triangles[TriangleCount + i] = triangles[i] + offset;
        VerticesCount += vertices.Length;
        TriangleCount += triangles.Length;
    }

    public void AddCopiedMesh(Mesh mesh)
    {
        var vertBase = Vertices.Length;
        var triangleBase = Triangles.Length;
        Array.Resize(ref Vertices, Vertices.Length + mesh.vertices.Length);
        Array.Resize(ref Triangles, Triangles.Length + mesh.triangles.Length);
        for(var i=0;i<mesh.vertices.Length;i++)
        {
            Vertices[vertBase + i] = mesh.vertices[i];
        }
        for(var i=0;i<mesh.triangles.Length;i++)
        {
            Triangles[triangleBase + i] = mesh.triangles[i] + vertBase;
        }
    }

    public Mesh ToMesh(Mesh mesh)
    {
        mesh.Clear();
        mesh.vertices = Vertices;
        mesh.triangles = Triangles;
        return mesh;
    }

    public Mesh ToMesh()
    {
        return ToMesh(new Mesh());
    }
}
