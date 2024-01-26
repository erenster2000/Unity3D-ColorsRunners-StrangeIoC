﻿using System.Collections.Generic;
using Rich.Base.Runtime.Abstract.View;
using Runtime.Data.ValueObject;
using Runtime.Signals;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Runtime.Views.Stack
{
    public class StackView : RichView
    {

        #region Private Variables

        internal StackData _data ;

        internal List<GameObject> _collectableStack = new List<GameObject>();

        #endregion

        public void SetStackData(StackData stackData)
        {
            _data = stackData;
        }

        internal void OnStackMove(Vector2 direction)
        {
            transform.position = new Vector3(0, gameObject.transform.position.y, direction.y -1f); // +2f -1f
            if (gameObject.transform.childCount > 0)
            {
                MoveStack(direction.x, _collectableStack);
            }
        }

        public void MoveStack(float directionX, List<GameObject> collectableStack)
        {
            float direct = Mathf.Lerp(collectableStack[0].transform.localPosition.x, directionX,
                _data.LerpDelay);
            collectableStack[0].transform.localPosition = new Vector3(direct, 1f, 0.335f);
            StackItemsLerpMove(collectableStack);
        }

        private void StackItemsLerpMove(List<GameObject> collectableStack)
        {
            for (int i = 1; i < collectableStack.Count; i++)
            {
                Vector3 pos = collectableStack[i].transform.localPosition;
                pos.x = collectableStack[i - 1].transform.localPosition.x;
                float direct = Mathf.Lerp(collectableStack[i].transform.localPosition.x, pos.x, _data.LerpDelay);
                collectableStack[i].transform.localPosition = new Vector3(direct, pos.y, pos.z);
            }
        }

        internal void OnStackCollectable(GameObject collectableGameObject)
        {
            AddStack(collectableGameObject);
        }

        private void AddStack(GameObject collectableGameObject)
        {
            if (_collectableStack.Count <= 0)
            {
                _collectableStack.Add(collectableGameObject);
                collectableGameObject.transform.SetParent(this.transform);
                collectableGameObject.transform.localPosition = new Vector3(0, 1f, 0.335f); // y: 1f
            }
            else
            {
                collectableGameObject.transform.SetParent(this.transform);
                Vector3 newPos = _collectableStack[^1].transform.localPosition;
                newPos.z += _data.StackOffset;
                collectableGameObject.transform.localPosition = newPos;
                _collectableStack.Add(collectableGameObject);
                

            }
        }
    }
}