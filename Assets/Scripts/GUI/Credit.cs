using UnityEngine;
using System.Collections;

public class Credit : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine(CreditCoroutine());
    }


    IEnumerator CreditCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        yield return InputManager.Instance.Controller.Actions.Accept.WaitPerform();
        yield return UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(gameObject.scene);
        MainUI.Instance.ReStart();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
