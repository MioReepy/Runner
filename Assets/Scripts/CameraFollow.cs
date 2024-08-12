using System;
using UnityEngine;

namespace CameraSpace
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform Player;
        private Vector3 _offset;

        private void Start()
        {
            _offset = transform.position - Player.position;
        }

        private void Update()
        {
            Vector3 targetPosition = Player.position + _offset;
            targetPosition.x = 0f;
            transform.position = targetPosition;
        }
    }
}
