using UnityEngine.UI;
using UnityEngine;

public class ProgressBar : MonoBehaviour
{
   public Player Player;
    public Transform PlatformFinish;
    public Slider Slider;
    private float AcceptableFinihPlayerDistance = 1f;

    private float _startY;
    private float _minimumReachY;
    

    public void Start()
    {

        _startY = Player.transform.position.y;
    }

    private void Update()
    {
        _minimumReachY = Mathf.Min(_minimumReachY, Player.transform.position.y);
        float finishY = PlatformFinish.transform.position.y;
        float t = Mathf.InverseLerp(_startY, finishY + AcceptableFinihPlayerDistance, _minimumReachY);
        Slider.value = t;
    }
}
