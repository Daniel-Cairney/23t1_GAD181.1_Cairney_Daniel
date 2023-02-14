using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Cairney_Daniel
{



    public class MainMenu : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene("Samurai_RPC");
        }
        public void QuitGame()
        {
            Application.Quit();
        }
        
            
        
    }
}