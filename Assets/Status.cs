using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Status")]
public class Status : ScriptableObject
{
  [TextArea(12,10)] [SerializeField] string StoryText;

  [SerializeField] Status[] NextStatus;

  public string GetStatusText(){
      return StoryText;
  }
  
  public Status[] GetNextStatus(){
      return NextStatus;
  }
}
