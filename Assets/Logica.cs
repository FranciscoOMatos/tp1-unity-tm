using UnityEngine;
using UnityEngine.UI;  // Para manipulação de UI
using UnityEngine.SceneManagement;

public class Logica : MonoBehaviour
{
    public int pontuacao = 0;  // Inicializa a pontuação
    public Text pontuacaoText;  // Para mostrar a pontuação na interface

    // Função que será chamada para adicionar pontuação
    public void AdicionarPontuacao()
    {
        pontuacao++;  // Incrementa a pontuação
        AtualizarPontuacaoUI();  // Atualiza o texto da interface
    }

    // Atualiza a interface com a nova pontuação
    void AtualizarPontuacaoUI()
    {
        pontuacaoText.text = "Troncos Saltados: " + pontuacao.ToString();  // Exibe a pontuação no UI
    }

    // Função para reiniciar o jogo
    public void recomecar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Reinicia a cena atual
    }
}
