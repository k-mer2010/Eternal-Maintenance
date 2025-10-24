using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LazyCameraFollow : MonoBehaviour
{
    public Transform target;
    public float followSpeed = 5f;
    public float threshold = 2f;

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 cameraPos = transform.position;
        Vector3 targetPos = target.position;
        targetPos.z = cameraPos.z;

        float distance = Vector3.Distance(cameraPos, targetPos);
        if (distance > threshold)
        {
            transform.position = Vector3.Lerp(cameraPos, targetPos, followSpeed * Time.deltaTime);
        }
    }
}
