using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneSwitch : MonoBehaviour
{
    private VideoPlayer _player;
    public delegate void Callback();

    // Use this for initialization
    void Start ()
    {
        _player = GetComponent<VideoPlayer>();
        _player.Play();
        PlayThenSwitchToMenu(() =>
        {
            SceneManager.LoadSceneAsync("StartScene");
        });
    }

    public void PlayThenSwitchToMenu(Callback callback)
    {
        StartCoroutine(FindEnd(callback));
    }

    private IEnumerator FindEnd(Callback callback)
    {
        Debug.Log(_player.isPlaying);
        while (_player.isPlaying)
        {
            yield return 0;
        }
        callback();
        yield break;
    }
}
