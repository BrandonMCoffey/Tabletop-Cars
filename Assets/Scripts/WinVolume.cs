using System;
using UnityEngine;

namespace Assets.Scripts {
    public class WinVolume : MonoBehaviour {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Player")) {
                GameController.Instance.WinLevel();
            }
        }
    }
}