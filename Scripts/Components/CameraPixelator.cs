using UnityEngine;

namespace SimplePixels
{
    [ExecuteInEditMode]
    [AddComponentMenu("Image Effects/Camera Pixelator")]
    [RequireComponent(typeof(Camera))]
    public class CameraPixelator : MonoBehaviour
    {
        [SerializeField, Range(64.0f, 512.0f)] private float _blockCount = 128;

        private Material _material;
        private Material Material
        {
            get
            {
                if (_material == null)
                {
                    _material = new Material(Shader.Find("Hidden/CameraPixelator"));
                    _material.hideFlags = HideFlags.HideAndDontSave;
                }
                return _material;
            }
        }

        private void OnRenderImage(RenderTexture source, RenderTexture destination)
        {
            float camAspect = Camera.main.aspect;
            Vector2 count = new Vector2(_blockCount, _blockCount/camAspect);
            Vector2 size = new Vector2(1.0f/count.x, 1.0f/count.y);
            Material.SetVector("BlockCount", count);
            Material.SetVector("BlockSize", size);
            Graphics.Blit(source, destination, Material);
        }

        private void OnDisable()
        {
            if (_material)
                DestroyImmediate(_material);
        }
    }
}