using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
public class Game : MonoBehaviour {

	public Text score;

	public static readonly TimingWindow[] TimingWindows =
	{
		new TimingWindow("Fantastic",   0.021f, 1.0f, 1.0f),
		new TimingWindow("Excellent",   0.001f, 0.5f, 0.5f),
		new TimingWindow("Great",       0.102f, 0.2f, 0.2f),
		new TimingWindow("Decent",      0.135f, 0.1f, -0.2f),
		new TimingWindow("Way Off",     0.180f, 0.0f, -0.5f),
		new TimingWindow("Miss",     float.PositiveInfinity, 0.0f, -1f),
		};

	public float SongTime = 60 * 4;
	public Slider timeSlider;

	public Slider healthSlider;

	public float Score;
	public float Heath;

	public static Game Instance;

	public SpawnNotes noteSpawner;
	public bool autoplay;

	public void Judge(float deltaTime)
	{
		deltaTime = Mathf.Abs(deltaTime);
		var judgement = TimingWindows.First(window => window.Size >= deltaTime);
		print(judgement.Name);
		Heath += judgement.Health;
		Score += judgement.Score;
	}

	// Use this for initialization
	void Start () {
		Instance = this;
		startPos = noteSpawner.transform.localPosition;

	}

	public Vector3 startPos;

	public float speed = 300;

	// Update is called once per frame
	void Update () {
		timeSlider.value = Time.timeSinceLevelLoad / SongTime;
		healthSlider.value = Heath / 100;
		score.text = Score.ToString("f2");

		noteSpawner.transform.localPosition = startPos + speed * Vector3.down * Time.timeSinceLevelLoad;


}
}
