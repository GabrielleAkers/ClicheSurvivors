namespace ClicheSurvivors.Utils
{
    using UnityEngine;

    public class Preload : MonoBehaviour
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void LoadManagers()
        {
            GameObject manager = GameObject.Instantiate(Resources.Load("Prefabs/GameManager")) as GameObject;
        }
    }
}
