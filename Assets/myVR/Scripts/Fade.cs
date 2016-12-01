using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {

    private CanvasGroup canvasGroup;

    void Awake() {
        canvasGroup = GetComponent<CanvasGroup>();
        //canvasGroup.alpha = 100;
        //fadeMe();
    }

    public void fadeMe() {
        
        StartCoroutine(makeFade());
    }

    IEnumerator makeFade() {
        while (canvasGroup.alpha < 1) {
            canvasGroup.alpha += Time.deltaTime / 2;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }
}
