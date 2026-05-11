using UnityEngine;

public class Candy : MonoBehaviour
{
    [SerializeField] public CandyType type;
    [SerializeField] public int points;//points as different presidents bring a different amount of points
    [SerializeField] public float radius;
    [SerializeField] public bool isSettled;//true when candy has reached a static position, false when falling
    public enum CandyType//nachher aendern zu unterschiedlichen Presidents
    {
      Red,
      Green,
      Blue,
      Yellow,
      Purple
    }
}
