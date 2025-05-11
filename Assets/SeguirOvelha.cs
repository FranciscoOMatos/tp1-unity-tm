using UnityEngine;

public class CameraSeguirOvelha : MonoBehaviour
{
    public Transform ovelha;

    void Update()
    {
        
        transform.position = new Vector3(ovelha.position.x, transform.position.y, transform.position.z);
    }
}
