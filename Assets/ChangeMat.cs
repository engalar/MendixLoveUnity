using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat : MonoBehaviour
{
  public Material redMat;
  public Material blueMat;
  // Start is called before the first frame update
  void Start()
  {
    RedMe();
  }

  // Update is called once per frame
  void Update()
  {

  }


  public void RedMe()
  {
    GetComponent<MeshRenderer>().material = redMat;
  }

  public void BlueMe()
  {
    GetComponent<MeshRenderer>().material = blueMat;
  }
}
