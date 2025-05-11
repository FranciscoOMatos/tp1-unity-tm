using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    public GameObject troncoPrefab;  // Prefab do tronco
    public float intervaloGeracao = 2f;  // Intervalo entre gerações
    public float distanciaEntreTroncos = 2f;  // Distância entre dois troncos quando aparecem juntos
    public float posicaoMinimaX = 15f;  // Posição mínima onde o tronco pode aparecer
    public float posicaoMaximaX = 25f;  // Posição máxima onde o tronco pode aparecer
    private float ultimoPosX = 0f; // Controla a posição X dos troncos gerados
    public GameObject ovelha;  // Referência à ovelha para pegar a posição dela

    void Start()
    {
        // Verifica se a ovelha foi atribuída no Inspector
        if (ovelha == null)
        {
            Debug.LogError("A referência à ovelha não foi atribuída!");
        }
        else
        {
            // Inicia a geração de troncos com o intervalo definido
            InvokeRepeating("GerarTronco", 1f, intervaloGeracao);
        }
    }

    void Update()
    {
        // Gera os troncos à frente da ovelha
        GerarTronco();
    }

    void GerarTronco()
    {
        // Verifica se a ovelha passou da posição onde um novo tronco deve aparecer
        if (ovelha.transform.position.x > ultimoPosX + posicaoMinimaX)
        {
            // Gera uma posição aleatória no eixo X para o tronco, sempre à frente da ovelha
            float posX = ovelha.transform.position.x + Random.Range(posicaoMinimaX, posicaoMaximaX);

            // Atualiza a posição do último tronco gerado
            ultimoPosX = posX;

            // A altura será fixa no chão (Y = -3.32)
            float altura = -3.32f;
            float posZ = -0.04f; // Posição Z fixa

            // Instancia o tronco
            GameObject novoTronco = Instantiate(troncoPrefab, new Vector3(posX, altura, posZ), Quaternion.identity);

            // Ajusta o Box Collider para o novo tronco
            BoxCollider2D boxCollider = novoTronco.GetComponent<BoxCollider2D>();
            if (boxCollider != null)
            {
                boxCollider.size = new Vector2(10f, 4f); // Ajusta o tamanho do collider
            }

            // Verifica se vai gerar um único tronco ou dois juntos
            if (Random.value > 0.8f)  // 20% de chance de gerar dois troncos juntos
            {
                // Gera o segundo tronco ao lado do primeiro
                Instantiate(troncoPrefab, new Vector3(posX + distanciaEntreTroncos, altura, posZ), Quaternion.identity);
            }
        }
    }
}
