using UnityEngine;

public class CloseCredits : MonoBehaviour
{
    public GameObject creditPanel; 
    public Behaviour controller; 

    public void ClosePanel()
    {
        Debug.Log("Closing Credits Panel");
        creditPanel.SetActive(false);
        controller.enabled = true; // Enables first person controller, causes conflict with UI mouse interaction when on
    }

}
