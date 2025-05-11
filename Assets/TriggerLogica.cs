using UnityEngine;

public class TriggerLogica : MonoBehaviour
{
    public Logica logica;  // Refer�ncia ao script Logica

    void Start()
    {
        // Encontra o GameObject com a tag "Logica" e obt�m o componente Logica
        GameObject logicaObjeto = GameObject.FindWithTag("Logica");
        if (logicaObjeto != null)
        {
            logica = logicaObjeto.GetComponent<Logica>(); // Atribui o componente Logica
        }
    }

    // Detecta a colis�o entre o jogador e o tronco
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))  // Verifica se a colis�o foi com a ovelha (Player)
        {
            logica.AdicionarPontuacao();  // Incrementa a pontua��o
            Destroy(gameObject);  // Remove o tronco ap�s a colis�o
        }
    }
}
