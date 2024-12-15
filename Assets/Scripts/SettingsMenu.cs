using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : Menu
{
    [SerializeField] private GameObject settingsMenu, mainMenu;
    [SerializeField] private Button backButton;
    
    private void Start()
    {
        backButton.onClick.AddListener(() => OpenContextMenu(settingsMenu, mainMenu));
    }
}
