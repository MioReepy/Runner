using UnityEngine;

namespace GroundSpace
{
    public class GroundTile : MonoBehaviour
    {
        [SerializeField] private float _timeDestroy = 5f;

        private GroundSpawner _groundSpawner;
        private void OnTriggerEnter(Collider other)
        {
            GroundSpawner.Instance.SpawnTile();
            Destroy(gameObject, _timeDestroy);
        }
    }
}
