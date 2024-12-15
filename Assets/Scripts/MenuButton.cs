using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private Color newColor = Color.red, defaultColor = Color.white;
    [SerializeField] private Button[] buttons;
    
    public void NewColorButton()
    {
        foreach (var button in buttons)
        {
            button.image.color = newColor;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
