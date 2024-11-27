using UnityEngine;
using TMPro;
using Unity.VisualScripting;

[RequireComponent(typeof(TextMeshProUGUI))]
public class AutoDestroyText : MonoBehaviour
{
    public float AutoDestroyTime = 5f;
    private TextMeshProUGUI Text;
    private float SpawnTime;
    // Update is called once per frame
    private void Awake()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        SpawnTime = Time.time;
    }

    private void Update()
    {
        float remtime = (SpawnTime + AutoDestroyTime) - Time.time;
        Text.SetText($"{remtime:N2}");

        if (remtime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
