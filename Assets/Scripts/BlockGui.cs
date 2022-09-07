using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Moonloop.Nodes {

    public class BlockGui : MonoBehaviour, IDragHandler
    {
        void Start()
        {
            
        }

        void Update()
        {
            
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.localPosition += (Vector3)eventData.delta;
        }
    }
}