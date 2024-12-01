// Classe ProgressBarController pour gérer la progression de la barre
public class ProgressBarController : MonoBehaviour
{
    public Slider progressBar;
    public Button playButton;
    public Button pauseButton;
    private TimeManager _timeManager;
    private bool isPlaying = false;
//
    void Start()
    {
        
        playButton.onClick.AddListener(OnPlay);
        pauseButton.onClick.AddListener(OnPause);

        // Initialiser la barre de progression
        progressBar.value = 0; 

        // Récupérer le TimeManager de la scène
        _timeManager = FindObjectOfType<TimeManager>();
        if (_timeManager != null)
        {
            _timeManager.OnTimeChanged += UpdateProgressBar;
        }
    }

    void Update()
    {
        if (isPlaying && _timeManager != null)
        {
            progressBar.value = _timeManager.CurrentTime / _timeManager.MaxTime;
        }
    }

    private void UpdateProgressBar(float currentTime)
    {
        progressBar.value = currentTime / _timeManager.MaxTime;
    }

    // Fonction appelée lorsque le bouton "Play" est cliqué
    void OnPlay()
    {
        isPlaying = true;
        _timeManager.Play();
    }

    // Fonction appelée lorsque le bouton "Pause" est cliqué
    void OnPause()
    {
        isPlaying = false;
        _timeManager.Pause();
    }
}
