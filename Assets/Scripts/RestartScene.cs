using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour{
    
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
