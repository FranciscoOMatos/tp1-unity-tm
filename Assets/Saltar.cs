using UnityEngine;

public class Saltar : MonoBehaviour
{
    public float forcaSalto = 12f;    // Força do salto
    public Rigidbody2D rb;            // Referência ao Rigidbody2D
    private bool isGrounded = false;  // Verifica se a ovelha está no chão
    private int saltosRestantes = 1;  // Permite double jump (dois saltos)

    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody2D>();  // Obtém automaticamente o Rigidbody2D
    }

    void Update()
    {
        // Verifica se a barra de espaço foi pressionada e se ainda há saltos disponíveis
        if (Input.GetKeyDown(KeyCode.Space) && saltosRestantes > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, forcaSalto);  // Aplica a força no eixo Y para saltar
            saltosRestantes--; // Decrementa os saltos restantes
        }
    }

    // Detecta quando a ovelha toca o chão
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Chao"))
        {
            isGrounded = true;
            saltosRestantes = 1;  // Reseta os saltos restantes para 2 quando a ovelha toca no chão
        }
    }

    // Verifica se a ovelha está no chão para permitir saltos
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Chao"))
        {
            isGrounded = true;
            saltosRestantes = 1;  // Reseta os saltos para 2 sempre que está no chão
        }
    }

    // Caso a ovelha não esteja no chão, define como não estar no chão
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Chao"))
        {
            isGrounded = false;
        }
    }
}
