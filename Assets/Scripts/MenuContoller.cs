using UnityEngine;
using UnityEngine.UI;

public class MenuContoller : Menu
{
    [SerializeField] private GameObject settingsMenu, mainMenu;
    [SerializeField] private Button playButton, settingsButton, quitButton;

    private void Start()
    {
        playButton.onClick.AddListener(() => NextLevel(1));
        settingsButton.onClick.AddListener(() => OpenContextMenu(mainMenu, settingsMenu));
        quitButton.onClick.AddListener(QuitGame);
    }
}
