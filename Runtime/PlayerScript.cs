using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    #region Variables

    [SerializeField] private bool jump;
    [SerializeField] private float jumpPower;

    [Header("Health")] 
    [SerializeField] private float health;
    
    #endregion
}
