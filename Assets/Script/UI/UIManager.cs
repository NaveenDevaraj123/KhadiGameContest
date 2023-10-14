using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
public Transform targetObject;
[SerializeField] Vector3 TargetPosition;
[SerializeField] int timeDuration;

    
void Start()
{
    targetObject.DOMove(TargetPosition, timeDuration).SetEase(Ease.Linear);
}
}
