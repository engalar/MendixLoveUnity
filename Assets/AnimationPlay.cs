using UnityEngine;

public class AnimationPlay : MonoBehaviour
{
  public void StopShake()
  {
    GetComponent<Animation>().Stop("a" + name[4]);
  }
  public void StartShake()
  {
    GetComponent<Animation>().Play("a" + name[4]);
  }
}