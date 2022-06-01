using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Fps : MonoBehaviour
{
    [SerializeField] private Text _fps;
    public float updateInterval = 0.5F;
    private double lastInterval;
    private int frames;
    private float fps;
    void Start()
    {
        lastInterval = Time.realtimeSinceStartup;
        frames = 0;
    }

    
    void Update()
    {
        ++frames;
        float timeNow = Time.realtimeSinceStartup;
        if (timeNow > lastInterval + updateInterval)
        {
            _fps.text = ((int)(frames / (timeNow - lastInterval))).ToString();
            frames = 0;
            lastInterval = timeNow;
        }
    }
}
