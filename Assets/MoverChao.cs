using UnityEngine;

public class MoverChao : MonoBehaviour
{
    public Transform ovelha;           // Referência à ovelha
    public float comprimento = 20f;    // Comprimento total do chão (deve ser igual à escala em X)

    void Update()
    {
        // Se a ovelha estiver quase no fim do chão atual
        if (ovelha.position.x > transform.position.x + comprimento)
        {
            // Reposiciona o chão à frente
            transform.position = new Vector3(
                transform.position.x + comprimento * 2f,
                transform.position.y,
                transform.position.z
            );
        }
    }
}
