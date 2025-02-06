using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    private int coins;

    [SerializeField] private TMP_Text coinDisplay;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Prevent duplicate managers
        }
    }

    private void Start()
    {
        UpdateCoinDisplay(); // Ensure initial display is correct
    }

    public void ChangeCoin(int amount)
    {
        coins += amount;
        UpdateCoinDisplay();
    }

    private void UpdateCoinDisplay()
    {
        coinDisplay.text = coins.ToString(); // Update the UI text with the current coin count
    }
}
