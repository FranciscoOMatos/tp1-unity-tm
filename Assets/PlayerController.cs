using UnityEngine;
using UnityEngine.SceneManagement; // Para gerenciar cenas

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private bool isGrounded = true;
    private bool isCollidingWithObstaculo = false;
    private float normalSpeed;

    // Referência para o script do MenuController
    public MenuController menuController;  // Se necessário

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        normalSpeed = moveSpeed;
    }

    void Update()
    {
        if (!isCollidingWithObstaculo)
        {
            rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);  // Aplica a velocidade constante no eixo X
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Chao"))
        {
            isGrounded = true;
        }

        // Verifica se a ovelha colidiu com o tronco
        if (col.gameObject.CompareTag("Obstaculo"))
        {
            // Se a ovelha colidir com o tronco, carrega a cena de "MenuPerder"
            SceneManager.LoadScene("MenuPerder");  // Certifique-se de que o nome da cena de perda é correto
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Obstaculo"))
        {
            isCollidingWithObstaculo = false;
            moveSpeed = normalSpeed;
        }
    }
}
