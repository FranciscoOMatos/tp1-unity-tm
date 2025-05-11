using UnityEngine;

public class Andar : MonoBehaviour
{
    public float velocidade = 2f;

    void Update()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
    }
}
