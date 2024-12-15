using UnityEngine;
using UnityEngine.UI;

public class TabMenu : Menu
{
    [SerializeField] private Button soundButton, graphicsButton;
    [SerializeField] private GameObject soundMenu, graphicsMenu;

    private void Start()
    {
        soundButton.onClick.AddListener(() => OpenContextMenu(graphicsMenu, soundMenu));
        graphicsButton.onClick.AddListener(() => OpenContextMenu(soundMenu, graphicsMenu));
    }
}
