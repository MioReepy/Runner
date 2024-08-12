using UnityEngine;

namespace GroundSpace
{
    public class GroundSpawner : MonoBehaviour
    {
        public static GroundSpawner Instance;
        
        [SerializeField] private GameObject _groundTilePrefab;
        [SerializeField] private int _tileVisiableInStart;
        
        private Vector3 _nextSpawnPoint;

        private void Awake() => Instance = this;

        private void Start()
        {
            for (int i = 0; i < _tileVisiableInStart; i++)
            {
                SpawnTile();
            }
        }

        internal void SpawnTile()
        {
            GameObject tempGround = Instantiate(_groundTilePrefab, _nextSpawnPoint, Quaternion.identity);
            _nextSpawnPoint = tempGround.transform.GetChild(0).transform.position;
        }
    }
}
  