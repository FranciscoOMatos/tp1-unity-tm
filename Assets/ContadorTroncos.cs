using UnityEngine;
using UnityEngine.UI;  // Para manipula��o de UI

public class ContadorTroncos : MonoBehaviour
{
    public Text contadorText;  // Texto da UI para mostrar o contador
    private int troncosSaltados = 0;  // Contador de troncos saltados

    // Fun��o chamada para incrementar o contador
    public void IncrementarContador()
    {
        troncosSaltados++;  // Aumenta o contador
        AtualizarUI();  // Atualiza a interface com o novo valor
    }

    // Fun��o para atualizar o texto na tela
    void AtualizarUI()
    {
        contadorText.text = "Troncos Saltados: " + troncosSaltados.ToString();
    }
}
