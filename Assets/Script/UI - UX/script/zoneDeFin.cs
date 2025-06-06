using UnityEngine;

public class ZoneDeFin : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    public static bool GameIsPaused = false;
    public GameObject finMenuUI;
    public PlayerRespawn Respawn;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player")) // V�rifie que c'est bien le joueur
        {
            Debug.Log("Le joueur a atteint la zone de fin.");
            Finish();
            ResetMort();
        }
    }

    void Finish()
    {
        finMenuUI.SetActive(true);
        Time.timeScale = 0f; // Met le jeu en pause
        GameIsPaused = true;

        if (musicSource != null) // V�rifie si la musique existe avant de la mettre en pause
        {
            musicSource.Pause();
        }
    }

    public void ResetMort()
    {
        Respawn.ResetIndicateurDeMort();
    }
}