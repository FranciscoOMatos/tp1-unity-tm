using UnityEngine;
using UnityEngine.UI;  // Para manipula��o de UI
using UnityEngine.SceneManagement;

public class Logica : MonoBehaviour
{
    public int pontuacao = 0;  // Inicializa a pontua��o
    public Text pontuacaoText;  // Para mostrar a pontua��o na interface

    // Fun��o que ser� chamada para adicionar pontua��o
    public void AdicionarPontuacao()
    {
        pontuacao++;  // Incrementa a pontua��o
        AtualizarPontuacaoUI();  // Atualiza o texto da interface
    }

    // Atualiza a interface com a nova pontua��o
    void AtualizarPontuacaoUI()
    {
        pontuacaoText.text = "Troncos Saltados: " + pontuacao.ToString();  // Exibe a pontua��o no UI
    }

    // Fun��o para reiniciar o jogo
    public void recomecar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Reinicia a cena atual
    }
}
