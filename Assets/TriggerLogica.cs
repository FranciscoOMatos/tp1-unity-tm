using UnityEngine;

public class TriggerLogica : MonoBehaviour
{
    public Logica logica;  // Referência ao script Logica

    void Start()
    {
        // Encontra o GameObject com a tag "Logica" e obtém o componente Logica
        GameObject logicaObjeto = GameObject.FindWithTag("Logica");
        if (logicaObjeto != null)
        {
            logica = logicaObjeto.GetComponent<Logica>(); // Atribui o componente Logica
        }
    }

    // Detecta a colisão entre o jogador e o tronco
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))  // Verifica se a colisão foi com a ovelha (Player)
        {
            logica.AdicionarPontuacao();  // Incrementa a pontuação
            Destroy(gameObject);  // Remove o tronco após a colisão
        }
    }
}
