using UnityEngine;

public class MoverChao : MonoBehaviour
{
    public Transform ovelha;           // Refer�ncia � ovelha
    public float comprimento = 20f;    // Comprimento total do ch�o (deve ser igual � escala em X)

    void Update()
    {
        // Se a ovelha estiver quase no fim do ch�o atual
        if (ovelha.position.x > transform.position.x + comprimento)
        {
            // Reposiciona o ch�o � frente
            transform.position = new Vector3(
                transform.position.x + comprimento * 2f,
                transform.position.y,
                transform.position.z
            );
        }
    }
}
