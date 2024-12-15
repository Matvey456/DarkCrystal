using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OpenContextMenu(GameObject oldMenu, GameObject newMenu)
    {
        oldMenu.SetActive(false);
        newMenu.SetActive(true);
    }

    public void NextLevel(int level) => SceneManager.LoadScene(level);
    
    public void QuitGame() => Application.Quit();
}
