using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    public GameObject troncoPrefab;  // Prefab do tronco
    public float intervaloGeracao = 2f;  // Intervalo entre gera��es
    public float distanciaEntreTroncos = 2f;  // Dist�ncia entre dois troncos quando aparecem juntos
    public float posicaoMinimaX = 15f;  // Posi��o m�nima onde o tronco pode aparecer
    public float posicaoMaximaX = 25f;  // Posi��o m�xima onde o tronco pode aparecer
    private float ultimoPosX = 0f; // Controla a posi��o X dos troncos gerados
    public GameObject ovelha;  // Refer�ncia � ovelha para pegar a posi��o dela

    void Start()
    {
        // Verifica se a ovelha foi atribu�da no Inspector
        if (ovelha == null)
        {
            Debug.LogError("A refer�ncia � ovelha n�o foi atribu�da!");
        }
        else
        {
            // Inicia a gera��o de troncos com o intervalo definido
            InvokeRepeating("GerarTronco", 1f, intervaloGeracao);
        }
    }

    void Update()
    {
        // Gera os troncos � frente da ovelha
        GerarTronco();
    }

    void GerarTronco()
    {
        // Verifica se a ovelha passou da posi��o onde um novo tronco deve aparecer
        if (ovelha.transform.position.x > ultimoPosX + posicaoMinimaX)
        {
            // Gera uma posi��o aleat�ria no eixo X para o tronco, sempre � frente da ovelha
            float posX = ovelha.transform.position.x + Random.Range(posicaoMinimaX, posicaoMaximaX);

            // Atualiza a posi��o do �ltimo tronco gerado
            ultimoPosX = posX;

            // A altura ser� fixa no ch�o (Y = -3.32)
            float altura = -3.32f;
            float posZ = -0.04f; // Posi��o Z fixa

            // Instancia o tronco
            GameObject novoTronco = Instantiate(troncoPrefab, new Vector3(posX, altura, posZ), Quaternion.identity);

            // Ajusta o Box Collider para o novo tronco
            BoxCollider2D boxCollider = novoTronco.GetComponent<BoxCollider2D>();
            if (boxCollider != null)
            {
                boxCollider.size = new Vector2(10f, 4f); // Ajusta o tamanho do collider
            }

            // Verifica se vai gerar um �nico tronco ou dois juntos
            if (Random.value > 0.8f)  // 20% de chance de gerar dois troncos juntos
            {
                // Gera o segundo tronco ao lado do primeiro
                Instantiate(troncoPrefab, new Vector3(posX + distanciaEntreTroncos, altura, posZ), Quaternion.identity);
            }
        }
    }
}
