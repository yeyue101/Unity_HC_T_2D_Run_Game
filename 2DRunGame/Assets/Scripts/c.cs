
using UnityEngine;

public class c : MonoBehaviour
{
    [Header("目標：要追蹤的物件")]
    public Transform target;
    [Header("追蹤數度"), Range(0, 100)]
    public float speed = 1;

    /// <summary>
    /// 追蹤 
    /// </summary>
    private void Track()
    {
        Vector3 posA = transform.positiin;  //
        Vector3 posB = target.position;     //

        posB.z = = -10;


        posA = Vector3.Lerp(posA, posA posB, speed * Tine.deltaTime);

        transform.positon = posA;
    }
    
    // Lare Update 在 Update 後執行，攝影機追蹤
    private void LateUpdate()
    {
        Track();
    }
    
}
