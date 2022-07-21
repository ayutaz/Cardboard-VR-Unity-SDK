using UnityEngine;
using MobfishCardboard;

namespace MobfishCardboardDemo.SceneTest
{
    public class MeshTestScript: MonoBehaviour
    {
        public TextAsset meshDataRaw;
        public MeshFilter meshFilter;

        private void Awake()
        {
            var cMeshData = JsonUtility.FromJson<CardboardMesh>(meshDataRaw.text);
            // CardboardMesh cMeshData = GetEditorTestMesh();
            var unityMesh = CardboardUtility.ConvertCardboardMesh_Triangle(cMeshData);
            meshFilter.mesh = unityMesh;
        }

        private CardboardMesh GetEditorTestMesh()
        {
            return new CardboardMesh()
            {
                vertices = new[] {-0.5f, -0.25f, -0.5f, 0.25f, -0.125f, -0.25f, -0.125f, 0.25f},
                n_vertices = 4,
                indices = new[] {0, 1, 2, 3},
                n_indices = 4,
                uvs = new[] {0f, 0f, 0f, 1f, 1f, 0f, 1f, 1f}
            };
        }

        // Start is called before the first frame update
        private void Start()
        {

        }

        // Update is called once per frame
        private void Update()
        {

        }
    }
}