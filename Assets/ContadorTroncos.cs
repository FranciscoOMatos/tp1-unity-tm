using UnityEngine;
using UnityEngine.UI;  // Para manipulação de UI

public class ContadorTroncos : MonoBehaviour
{
    public Text contadorText;  // Texto da UI para mostrar o contador
    private int troncosSaltados = 0;  // Contador de troncos saltados

    // Função chamada para incrementar o contador
    public void IncrementarContador()
    {
        troncosSaltados++;  // Aumenta o contador
        AtualizarUI();  // Atualiza a interface com o novo valor
    }

    // Função para atualizar o texto na tela
    void AtualizarUI()
    {
        contadorText.text = "Troncos Saltados: " + troncosSaltados.ToString();
    }
}
