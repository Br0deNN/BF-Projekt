using UnityEngine;
using CodeMonkey.Utils;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

public class DrawMesh : MonoBehaviour
{
    [SerializeField] private Transform debugVisual1;
    [SerializeField] private Transform debugVisual2;
    
    private Mesh mesh;
    private Vector3 lastMousePosition;

    void Awake()
    {

    }   
        
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mesh = new Mesh();

            Vector3[] verticies = new Vector3[4];
            Vector2[] uv = new Vector2[4];
            int[] triangles = new int[6];

            verticies[0] = UtilsClass.GetMouseWorldPosition();
            verticies[1] = UtilsClass.GetMouseWorldPosition();
            verticies[2] = UtilsClass.GetMouseWorldPosition();
            verticies[3] = UtilsClass.GetMouseWorldPosition();

            uv[0] = Vector2.zero;
            uv[1] = Vector2.zero;
            uv[2] = Vector2.zero;
            uv[3] = Vector2.zero;

            triangles[0] = 0;
            triangles[1] = 3;
            triangles[2] = 1;

            triangles[3] = 1;
            triangles[4] = 3;
            triangles[5] = 2;

            mesh.vertices = verticies;
            mesh.uv = uv;
            mesh.triangles = triangles;
            mesh.MarkDynamic();

            MeshFilter meshFilter = GetComponent<MeshFilter>();
            if (meshFilter == null)
                meshFilter = gameObject.AddComponent<MeshFilter>();

            meshFilter.mesh = mesh;

            lastMousePosition = UtilsClass.GetMouseWorldPosition();
        }

        if (Input.GetMouseButton(0))
        {
            if (mesh == null) return;
            float minDistance = 0.1f;
            if (Vector3.Distance(UtilsClass.GetMouseWorldPosition(), lastMousePosition) > minDistance)
            {


                // Mouse held down
                Vector3[] verticies = new Vector3[mesh.vertices.Length + 2];
                Vector2[] uv = new Vector2[mesh.uv.Length + 2];
                int[] triangles = new int[mesh.triangles.Length + 6];

                mesh.vertices.CopyTo(verticies, 0);
                mesh.uv.CopyTo(uv, 0);
                mesh.triangles.CopyTo(triangles, 0);

                int vIndex = verticies.Length - 4;
                int vIndex0 = vIndex + 0;
                int vIndex1 = vIndex + 1;
                int vIndex2 = vIndex + 2;
                int vIndex3 = vIndex + 3;

                Vector3 mosueForwardVector = (UtilsClass.GetMouseWorldPosition() - lastMousePosition).normalized;
                Vector3 normal2D = new Vector3(0, 0, 1f);
                float lineThickness = 1f;
                Vector3 newVertexUp = UtilsClass.GetMouseWorldPosition() + Vector3.Cross(mosueForwardVector, normal2D)
                    * lineThickness;
                Vector3 newVertexDown = UtilsClass.GetMouseWorldPosition() + Vector3.Cross(mosueForwardVector, normal2D * -1f)
                    * lineThickness;

                verticies[vIndex2] = newVertexUp;
                verticies[vIndex3] = newVertexDown;

                uv[vIndex2] = Vector2.zero;
                uv[vIndex3] = Vector2.zero;

                int tIndex = triangles.Length - 6;

                triangles[tIndex + 0] = vIndex0;
                triangles[tIndex + 1] = vIndex2;
                triangles[tIndex + 2] = vIndex1;

                triangles[tIndex + 3] = vIndex1;
                triangles[tIndex + 4] = vIndex2;
                triangles[tIndex + 5] = vIndex3;

                mesh.vertices = verticies;
                mesh.uv = uv;
                mesh.triangles = triangles;

                lastMousePosition = UtilsClass.GetMouseWorldPosition();
            }
        }
            
    }

    
}
