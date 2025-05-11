using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    
    public GameObject MenuPerder;
    public Button jogarNovamenteButton;

    void Start()
    {
        
        MenuPerder.SetActive(false);

        
        jogarNovamenteButton.onClick.AddListener(JogarNovamente);
    }

    
    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    
    public void Instrucoes()
    {
        SceneManager.LoadScene("Instrucoes");
    }

    
    public void VoltarParaMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    
    public void MostrarMenuPerda()
    {
        
        MenuPerder.SetActive(true);
    }

    
    void JogarNovamente()
    {
        
        SceneManager.LoadScene("SampleScene");
    }
}
