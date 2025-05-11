using UnityEngine;

public class Trigger : MonoBehaviour
{
    public ContadorTroncos contador;  // Referência ao script ContadorTroncos

    void OnTriggerEnter2D(Collider2D col)
    {
        // Verifica se a ovelha tocou o tronco
        if (col.CompareTag("Player"))
        {
            // Incrementa o contador
            contador.IncrementarContador();
        }
    }
}
