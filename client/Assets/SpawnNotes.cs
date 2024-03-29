﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnNotes : MonoBehaviour
{
	public FallingNote notePrefab;
	// Use this for initialization

	List<FallingNote> noteObjects = new List<FallingNote>();
	void Start()
	{

		var rotations = new[]
		{
			 Quaternion.Euler(0, 0, 0),
			 Quaternion.Euler(0, 0, 90),
			 Quaternion.Euler(0, 0, -90),
			 Quaternion.Euler(0, 0, 180)
		};
		var names = new[] { "Left", "Down", "Up", "Right" };
		foreach (var noteData in notes)
		{
			var direction = (int)noteData.x;

			var pos = new Vector3(direction * 60, 500 * noteData.y);
			var note = Instantiate(notePrefab, transform.TransformPoint(pos), rotations[direction], transform);
			note.name = names[direction];

			noteObjects.Add(note);

			

		}
	}

	// Update is called once per frame
	void Update()
	{
	}

	public Vector3[] notes = {
		new Vector3(0, 8f, 0),
		new Vector3(1, 8.125f, 0),
new Vector3(2, 8.25f, 0),
new Vector3(1, 8.375f, 0),
new Vector3(0, 8.5f, 0),
new Vector3(3, 8.625f, 0),
new Vector3(1, 8.75f, 0),
new Vector3(2, 8.875f, 0),
new Vector3(1, 9f, 0),
new Vector3(3, 9.125f, 0),
new Vector3(0, 9.25f, 0),
new Vector3(2, 9.375f, 0),
new Vector3(1, 9.5f, 0),
new Vector3(3, 9.625f, 0),
new Vector3(0, 9.75f, 0),
new Vector3(3, 10f, 0),
new Vector3(2, 10.125f, 0),
new Vector3(1, 10.25f, 0),
new Vector3(2, 10.375f, 0),
new Vector3(3, 10.5f, 0),
new Vector3(0, 10.625f, 0),
new Vector3(2, 10.75f, 0),
new Vector3(1, 10.875f, 0),
new Vector3(2, 11f, 0),
new Vector3(0, 11.125f, 0),
new Vector3(3, 11.25f, 0),
new Vector3(1, 11.375f, 0),
new Vector3(2, 11.5f, 0),
new Vector3(0, 11.625f, 0),
new Vector3(3, 11.75f, 0),
new Vector3(2, 12f, 0),
new Vector3(1, 12.125f, 0),
new Vector3(0, 12.25f, 0),
new Vector3(3, 12.375f, 0),
new Vector3(2, 12.5f, 0),
new Vector3(3, 12.625f, 0),
new Vector3(0, 12.75f, 0),
new Vector3(2, 12.875f, 0),
new Vector3(1, 13f, 0),
new Vector3(3, 13.125f, 0),
new Vector3(1, 13.25f, 0),
new Vector3(2, 13.375f, 0),
new Vector3(0, 13.5f, 0),
new Vector3(3, 13.625f, 0),
new Vector3(1, 13.75f, 0),
new Vector3(3, 14f, 0),
new Vector3(2, 14.125f, 0),
new Vector3(1, 14.25f, 0),
new Vector3(2, 14.375f, 0),
new Vector3(3, 14.5f, 0),
new Vector3(0, 14.625f, 0),
new Vector3(2, 14.75f, 0),
new Vector3(1, 14.875f, 0),
new Vector3(3, 15f, 0),
new Vector3(1, 15.125f, 0),
new Vector3(2, 15.25f, 0),
new Vector3(0, 15.375f, 0),
new Vector3(1, 15.5f, 0),
new Vector3(0, 15.625f, 0),
new Vector3(2, 15.75f, 0),
new Vector3(0, 15.875f, 0),
new Vector3(3, 16f, 0),
new Vector3(1, 16.125f, 0),
new Vector3(2, 16.25f, 0),
new Vector3(1, 16.375f, 0),
new Vector3(3, 16.5f, 0),
new Vector3(0, 16.625f, 0),
new Vector3(1, 16.75f, 0),
new Vector3(2, 16.875f, 0),
new Vector3(3, 17f, 0),
new Vector3(0, 17.125f, 0),
new Vector3(3, 17.25f, 0),
new Vector3(2, 17.375f, 0),
new Vector3(1, 17.5f, 0),
new Vector3(0, 17.625f, 0),
new Vector3(3, 17.75f, 0),
new Vector3(1, 18f, 0),
new Vector3(2, 18.125f, 0),
new Vector3(0, 18.25f, 0),
new Vector3(2, 18.375f, 0),
new Vector3(1, 18.5f, 0),
new Vector3(3, 18.625f, 0),
new Vector3(0, 18.75f, 0),
new Vector3(1, 18.875f, 0),
new Vector3(0, 19f, 0),
new Vector3(3, 19.125f, 0),
new Vector3(2, 19.25f, 0),
new Vector3(1, 19.375f, 0),
new Vector3(0, 19.5f, 0),
new Vector3(3, 19.625f, 0),
new Vector3(0, 19.75f, 0),
new Vector3(2, 20f, 0),
new Vector3(1, 20.125f, 0),
new Vector3(2, 20.25f, 0),
new Vector3(0, 20.375f, 0),
new Vector3(3, 20.5f, 0),
new Vector3(1, 20.625f, 0),
new Vector3(3, 20.75f, 0),
new Vector3(2, 20.875f, 0),
new Vector3(3, 21f, 0),
new Vector3(0, 21.125f, 0),
new Vector3(1, 21.25f, 0),
new Vector3(0, 21.375f, 0),
new Vector3(3, 21.5f, 0),
new Vector3(2, 21.625f, 0),
new Vector3(1, 21.75f, 0),
new Vector3(0, 22f, 0),
new Vector3(2, 22.125f, 0),
new Vector3(1, 22.25f, 0),
new Vector3(3, 22.375f, 0),
new Vector3(1, 22.5f, 0),
new Vector3(2, 22.625f, 0),
new Vector3(0, 22.75f, 0),
new Vector3(1, 22.875f, 0),
new Vector3(2, 23f, 0),
new Vector3(3, 23.125f, 0),
new Vector3(1, 23.25f, 0),
new Vector3(3, 23.375f, 0),
new Vector3(2, 23.5f, 0),
new Vector3(3, 23.625f, 0),
new Vector3(1, 23.75f, 0),
new Vector3(3, 23.875f, 0),
new Vector3(0, 24f, 0),
new Vector3(3, 24f, 0),
new Vector3(0, 24.25f, 0),
new Vector3(1, 24.375f, 0),
new Vector3(2, 24.5f, 0),
new Vector3(1, 24.75f, 0),
new Vector3(0, 25f, 0),
new Vector3(2, 25.25f, 0),
new Vector3(1, 25.375f, 0),
new Vector3(3, 25.5f, 0),
new Vector3(2, 25.75f, 0),
new Vector3(1, 25.8333333333333f, 0),
new Vector3(2, 25.9166666666667f, 0),
new Vector3(1, 26f, 0),
new Vector3(0, 26.25f, 0),
new Vector3(3, 26.375f, 0),
new Vector3(1, 26.5f, 0),
new Vector3(2, 26.75f, 0),
new Vector3(0, 27f, 0),
new Vector3(1, 27.25f, 0),
new Vector3(2, 27.375f, 0),
new Vector3(3, 27.5f, 0),
new Vector3(2, 27.75f, 0),
new Vector3(1, 28f, 0),
new Vector3(0, 28.25f, 0),
new Vector3(3, 28.375f, 0),
new Vector3(1, 28.5f, 0),
new Vector3(2, 28.75f, 0),
new Vector3(0, 28.8333333333333f, 0),
new Vector3(3, 28.9166666666667f, 0),
new Vector3(2, 29f, 0),
new Vector3(1, 29.25f, 0),
new Vector3(0, 29.375f, 0),
new Vector3(3, 29.5f, 0),
new Vector3(0, 29.75f, 0),
new Vector3(1, 30f, 0),
new Vector3(2, 30.25f, 0),
new Vector3(3, 30.375f, 0),
new Vector3(1, 30.5f, 0),
new Vector3(2, 30.75f, 0),
new Vector3(1, 31f, 0),
new Vector3(3, 31.25f, 0),
new Vector3(2, 31.375f, 0),
new Vector3(1, 31.5f, 0),
new Vector3(2, 31.75f, 0),
new Vector3(3, 32f, 0),
new Vector3(0, 32.25f, 0),
new Vector3(2, 32.375f, 0),
new Vector3(1, 32.5f, 0),
new Vector3(3, 32.75f, 0),
new Vector3(0, 33f, 0),
new Vector3(1, 33.25f, 0),
new Vector3(2, 33.375f, 0),
new Vector3(1, 33.5f, 0),
new Vector3(0, 33.75f, 0),
new Vector3(3, 33.8333333333333f, 0),
new Vector3(0, 33.9166666666667f, 0),
new Vector3(3, 34f, 0),
new Vector3(1, 34.25f, 0),
new Vector3(2, 34.375f, 0),
new Vector3(0, 34.5f, 0),
new Vector3(1, 34.75f, 0),
new Vector3(2, 35f, 0),
new Vector3(1, 35.25f, 0),
new Vector3(0, 35.375f, 0),
new Vector3(3, 35.5f, 0),
new Vector3(1, 35.75f, 0),
new Vector3(2, 36f, 0),
new Vector3(1, 36.25f, 0),
new Vector3(3, 36.375f, 0),
new Vector3(0, 36.5f, 0),
new Vector3(1, 36.75f, 0),
new Vector3(0, 36.8333333333333f, 0),
new Vector3(3, 36.9166666666667f, 0),
new Vector3(1, 37f, 0),
new Vector3(2, 37.25f, 0),
new Vector3(0, 37.375f, 0),
new Vector3(3, 37.5f, 0),
new Vector3(0, 37.75f, 0),
new Vector3(2, 38f, 0),
new Vector3(2, 38.125f, 0),
new Vector3(1, 38.25f, 0),
new Vector3(1, 38.375f, 0),
new Vector3(3, 38.5f, 0),
new Vector3(3, 38.625f, 0),
new Vector3(0, 38.75f, 0),
new Vector3(0, 38.875f, 0),
new Vector3(1, 39f, 0),
new Vector3(1, 39.125f, 0),
new Vector3(2, 39.25f, 0),
new Vector3(2, 39.375f, 0),
new Vector3(3, 39.5f, 0),
new Vector3(3, 39.625f, 0),
new Vector3(0, 39.75f, 0),
new Vector3(0, 39.875f, 0),
new Vector3(2, 40f, 0),
new Vector3(1, 40.125f, 0),
new Vector3(3, 40.25f, 0),
new Vector3(2, 40.375f, 0),
new Vector3(1, 40.5f, 0),
new Vector3(2, 40.625f, 0),
new Vector3(3, 40.75f, 0),
new Vector3(1, 40.875f, 0),
new Vector3(2, 41f, 0),
new Vector3(0, 41.125f, 0),
new Vector3(1, 41.25f, 0),
new Vector3(2, 41.375f, 0),
new Vector3(1, 41.5f, 0),
new Vector3(0, 41.625f, 0),
new Vector3(2, 41.75f, 0),
new Vector3(1, 41.875f, 0),
new Vector3(2, 41.9375f, 0),
new Vector3(1, 42f, 0),
new Vector3(3, 42.125f, 0),
new Vector3(2, 42.25f, 0),
new Vector3(3, 42.375f, 0),
new Vector3(1, 42.5f, 0),
new Vector3(2, 42.625f, 0),
new Vector3(0, 42.75f, 0),
new Vector3(1, 42.875f, 0),
new Vector3(0, 43f, 0),
new Vector3(2, 43.125f, 0),
new Vector3(1, 43.25f, 0),
new Vector3(3, 43.375f, 0),
new Vector3(0, 43.5f, 0),
new Vector3(1, 43.625f, 0),
new Vector3(2, 43.75f, 0),
new Vector3(3, 43.875f, 0),
new Vector3(0, 43.9375f, 0),
new Vector3(3, 44f, 0),
new Vector3(2, 44.125f, 0),
new Vector3(1, 44.25f, 0),
new Vector3(2, 44.375f, 0),
new Vector3(3, 44.5f, 0),
new Vector3(1, 44.625f, 0),
new Vector3(2, 44.75f, 0),
new Vector3(1, 44.875f, 0),
new Vector3(3, 45f, 0),
new Vector3(2, 45.125f, 0),
new Vector3(1, 45.25f, 0),
new Vector3(0, 45.375f, 0),
new Vector3(3, 45.5f, 0),
new Vector3(1, 45.625f, 0),
new Vector3(2, 45.75f, 0),
new Vector3(0, 45.875f, 0),
new Vector3(2, 45.9375f, 0),
new Vector3(0, 46f, 0),
new Vector3(1, 46.125f, 0),
new Vector3(0, 46.25f, 0),
new Vector3(3, 46.375f, 0),
new Vector3(1, 46.5f, 0),
new Vector3(2, 46.625f, 0),
new Vector3(0, 46.75f, 0),
new Vector3(2, 46.875f, 0),
new Vector3(1, 47f, 0),
new Vector3(3, 47.125f, 0),
new Vector3(2, 47.25f, 0),
new Vector3(3, 47.375f, 0),
new Vector3(1, 47.5f, 0),
new Vector3(3, 47.625f, 0),
new Vector3(2, 47.75f, 0),
new Vector3(1, 47.875f, 0),
new Vector3(0, 48f, 0),
new Vector3(2, 48.125f, 0),
new Vector3(3, 48.25f, 0),
new Vector3(2, 48.375f, 0),
new Vector3(1, 48.5f, 0),
new Vector3(0, 48.625f, 0),
new Vector3(1, 48.75f, 0),
new Vector3(3, 48.875f, 0),
new Vector3(2, 49f, 0),
new Vector3(1, 49.125f, 0),
new Vector3(0, 49.25f, 0),
new Vector3(2, 49.375f, 0),
new Vector3(1, 49.5f, 0),
new Vector3(3, 49.625f, 0),
new Vector3(2, 49.75f, 0),
new Vector3(1, 49.875f, 0),
new Vector3(2, 50f, 0),
new Vector3(0, 50.125f, 0),
new Vector3(2, 50.25f, 0),
new Vector3(1, 50.375f, 0),
new Vector3(3, 50.5f, 0),
new Vector3(1, 50.625f, 0),
new Vector3(2, 50.75f, 0),
new Vector3(3, 50.875f, 0),
new Vector3(1, 51f, 0),
new Vector3(2, 51.125f, 0),
new Vector3(0, 51.25f, 0),
new Vector3(1, 51.375f, 0),
new Vector3(2, 51.5f, 0),
new Vector3(3, 51.625f, 0),
new Vector3(1, 51.75f, 0),
new Vector3(3, 51.875f, 0),
new Vector3(1, 52f, 0),
new Vector3(2, 52.125f, 0),
new Vector3(3, 52.25f, 0),
new Vector3(2, 52.375f, 0),
new Vector3(1, 52.5f, 0),
new Vector3(0, 52.625f, 0),
new Vector3(1, 52.75f, 0),
new Vector3(2, 52.875f, 0),
new Vector3(0, 53f, 0),
new Vector3(1, 53.125f, 0),
new Vector3(2, 53.25f, 0),
new Vector3(3, 53.375f, 0),
new Vector3(1, 53.5f, 0),
new Vector3(2, 53.625f, 0),
new Vector3(0, 53.75f, 0),
new Vector3(1, 53.875f, 0),
new Vector3(2, 54f, 0),
new Vector3(0, 54.125f, 0),
new Vector3(2, 54.25f, 0),
new Vector3(1, 54.375f, 0),
new Vector3(3, 54.5f, 0),
new Vector3(1, 54.625f, 0),
new Vector3(2, 54.75f, 0),
new Vector3(3, 54.875f, 0),
new Vector3(1, 55f, 0),
new Vector3(2, 55.125f, 0),
new Vector3(0, 55.25f, 0),
new Vector3(1, 55.375f, 0),
new Vector3(2, 55.5f, 0),
new Vector3(3, 55.625f, 0),
new Vector3(1, 55.75f, 0),
new Vector3(3, 55.875f, 0),
new Vector3(1, 56f, 0),
new Vector3(3, 56f, 0),
new Vector3(0, 57f, 0),
new Vector3(1, 57.5f, 0),
new Vector3(0, 57.75f, 0),
new Vector3(2, 57.8333333333333f, 0),
new Vector3(1, 57.9166666666667f, 0),
new Vector3(3, 58f, 0),
new Vector3(2, 58.75f, 0),
new Vector3(1, 59f, 0),
new Vector3(2, 60f, 0),
new Vector3(3, 60.75f, 0),
new Vector3(1, 60.8333333333333f, 0),
new Vector3(2, 60.9166666666667f, 0),
new Vector3(0, 61f, 0),
new Vector3(1, 61.5f, 0),
new Vector3(2, 62f, 0),
new Vector3(3, 64f, 0),
new Vector3(0, 64.125f, 0),
new Vector3(2, 64.25f, 0),
new Vector3(0, 64.375f, 0),
new Vector3(3, 64.5f, 0),
new Vector3(2, 64.625f, 0),
new Vector3(3, 64.75f, 0),
new Vector3(0, 64.875f, 0),
new Vector3(3, 65f, 0),
new Vector3(0, 65.125f, 0),
new Vector3(1, 65.25f, 0),
new Vector3(0, 65.375f, 0),
new Vector3(3, 65.5f, 0),
new Vector3(1, 65.625f, 0),
new Vector3(3, 65.75f, 0),
new Vector3(0, 65.875f, 0),
new Vector3(3, 66f, 0),
new Vector3(0, 66.125f, 0),
new Vector3(2, 66.25f, 0),
new Vector3(0, 66.375f, 0),
new Vector3(3, 66.5f, 0),
new Vector3(1, 66.625f, 0),
new Vector3(3, 66.75f, 0),
new Vector3(0, 66.875f, 0),
new Vector3(3, 67f, 0),
new Vector3(0, 67.125f, 0),
new Vector3(1, 67.25f, 0),
new Vector3(0, 67.375f, 0),
new Vector3(3, 67.5f, 0),
new Vector3(2, 67.625f, 0),
new Vector3(3, 67.75f, 0),
new Vector3(0, 67.875f, 0),
new Vector3(2, 68f, 0),
new Vector3(1, 68.125f, 0),
new Vector3(3, 68.25f, 0),
new Vector3(1, 68.375f, 0),
new Vector3(2, 68.5f, 0),
new Vector3(0, 68.625f, 0),
new Vector3(2, 68.75f, 0),
new Vector3(1, 68.875f, 0),
new Vector3(3, 69f, 0),
new Vector3(2, 69.125f, 0),
new Vector3(1, 69.25f, 0),
new Vector3(2, 69.375f, 0),
new Vector3(3, 69.5f, 0),
new Vector3(1, 69.625f, 0),
new Vector3(2, 69.75f, 0),
new Vector3(0, 69.875f, 0),
new Vector3(3, 70f, 0),
new Vector3(0, 70.125f, 0),
new Vector3(2, 70.25f, 0),
new Vector3(1, 70.375f, 0),
new Vector3(3, 70.5f, 0),
new Vector3(2, 70.625f, 0),
new Vector3(1, 70.75f, 0),
new Vector3(0, 70.875f, 0),
new Vector3(3, 71f, 0),
new Vector3(0, 71.125f, 0),
new Vector3(2, 71.25f, 0),
new Vector3(0, 71.375f, 0),
new Vector3(1, 71.5f, 0),
new Vector3(0, 71.625f, 0),
new Vector3(2, 71.75f, 0),
new Vector3(1, 71.875f, 0),
new Vector3(1, 72f, 0),
new Vector3(3, 72f, 0),
new Vector3(3, 72.25f, 0),
new Vector3(1, 72.375f, 0),
new Vector3(2, 72.5f, 0),
new Vector3(2, 72.875f, 0),
new Vector3(3, 72.875f, 0),
new Vector3(1, 73f, 0),
new Vector3(2, 73.125f, 0),
new Vector3(2, 73.5f, 0),
new Vector3(2, 73.875f, 0),
new Vector3(0, 74f, 0),
new Vector3(3, 74.25f, 0),
new Vector3(2, 74.375f, 0),
new Vector3(1, 74.5f, 0),
new Vector3(1, 74.875f, 0),
new Vector3(3, 74.875f, 0),
new Vector3(0, 75f, 0),
new Vector3(2, 75.125f, 0),
new Vector3(2, 75.5f, 0),
new Vector3(1, 75.875f, 0),
new Vector3(3, 76f, 0),
new Vector3(0, 76.25f, 0),
new Vector3(2, 76.375f, 0),
new Vector3(1, 76.5f, 0),
new Vector3(0, 76.875f, 0),
new Vector3(1, 76.875f, 0),
new Vector3(2, 77f, 0),
new Vector3(1, 77.125f, 0),
new Vector3(1, 77.5f, 0),
new Vector3(1, 77.875f, 0),
new Vector3(3, 78f, 0),
new Vector3(0, 78.25f, 0),
new Vector3(1, 78.375f, 0),
new Vector3(2, 78.5f, 0),
new Vector3(0, 78.875f, 0),
new Vector3(2, 78.875f, 0),
new Vector3(3, 79f, 0),
new Vector3(1, 79.125f, 0),
new Vector3(1, 79.5f, 0),
new Vector3(1, 79.875f, 0),
new Vector3(2, 80f, 0),
new Vector3(0, 80.25f, 0),
new Vector3(3, 80.375f, 0),
new Vector3(1, 80.5f, 0),
new Vector3(0, 80.875f, 0),
new Vector3(1, 80.875f, 0),
new Vector3(3, 81f, 0),
new Vector3(1, 81.125f, 0),
new Vector3(1, 81.5f, 0),
new Vector3(1, 81.875f, 0),
new Vector3(2, 82f, 0),
new Vector3(0, 82.25f, 0),
new Vector3(3, 82.375f, 0),
new Vector3(2, 82.5f, 0),
new Vector3(0, 82.875f, 0),
new Vector3(2, 82.875f, 0),
new Vector3(2, 83f, 0),
new Vector3(1, 83.125f, 0),
new Vector3(1, 83.5f, 0),
new Vector3(2, 83.875f, 0),
new Vector3(0, 84f, 0),
new Vector3(3, 84.25f, 0),
new Vector3(0, 84.375f, 0),
new Vector3(2, 84.5f, 0),
new Vector3(2, 84.875f, 0),
new Vector3(3, 84.875f, 0),
new Vector3(0, 85f, 0),
new Vector3(2, 85.125f, 0),
new Vector3(2, 85.5f, 0),
new Vector3(2, 85.875f, 0),
new Vector3(1, 86f, 0),
new Vector3(3, 86.25f, 0),
new Vector3(0, 86.375f, 0),
new Vector3(1, 86.5f, 0),
new Vector3(1, 86.875f, 0),
new Vector3(3, 86.875f, 0),
new Vector3(1, 87f, 0),
new Vector3(2, 87.125f, 0),
new Vector3(1, 87.5f, 0),
new Vector3(2, 87.5f, 0),
new Vector3(0, 87.75f, 0),
new Vector3(3, 87.75f, 0),
new Vector3(0, 88f, 0),
new Vector3(1, 88.125f, 0),
new Vector3(2, 88.25f, 0),
new Vector3(1, 88.375f, 0),
new Vector3(0, 88.5f, 0),
new Vector3(3, 88.625f, 0),
new Vector3(2, 88.75f, 0),
new Vector3(3, 88.875f, 0),
new Vector3(0, 89f, 0),
new Vector3(2, 89.125f, 0),
new Vector3(1, 89.25f, 0),
new Vector3(3, 89.375f, 0),
new Vector3(0, 89.5f, 0),
new Vector3(3, 89.625f, 0),
new Vector3(1, 89.75f, 0),
new Vector3(2, 89.875f, 0),
new Vector3(0, 90f, 0),
new Vector3(1, 90.125f, 0),
new Vector3(2, 90.25f, 0),
new Vector3(1, 90.375f, 0),
new Vector3(0, 90.5f, 0),
new Vector3(2, 90.625f, 0),
new Vector3(1, 90.75f, 0),
new Vector3(2, 90.875f, 0),
new Vector3(0, 91f, 0),
new Vector3(3, 91.125f, 0),
new Vector3(2, 91.25f, 0),
new Vector3(1, 91.375f, 0),
new Vector3(0, 91.5f, 0),
new Vector3(3, 91.625f, 0),
new Vector3(1, 91.75f, 0),
new Vector3(2, 91.875f, 0),
new Vector3(1, 92f, 0),
new Vector3(3, 92.125f, 0),
new Vector3(2, 92.25f, 0),
new Vector3(1, 92.375f, 0),
new Vector3(0, 92.5f, 0),
new Vector3(3, 92.625f, 0),
new Vector3(1, 92.75f, 0),
new Vector3(3, 92.875f, 0),
new Vector3(0, 93f, 0),
new Vector3(1, 93.125f, 0),
new Vector3(2, 93.25f, 0),
new Vector3(3, 93.375f, 0),
new Vector3(0, 93.5f, 0),
new Vector3(3, 93.625f, 0),
new Vector3(1, 93.75f, 0),
new Vector3(2, 93.875f, 0),
new Vector3(0, 94f, 0),
new Vector3(1, 94.125f, 0),
new Vector3(0, 94.25f, 0),
new Vector3(3, 94.375f, 0),
new Vector3(1, 94.5f, 0),
new Vector3(3, 94.625f, 0),
new Vector3(0, 94.75f, 0),
new Vector3(2, 94.875f, 0),
new Vector3(1, 95f, 0),
new Vector3(3, 95.125f, 0),
new Vector3(2, 95.25f, 0),
new Vector3(1, 95.375f, 0),
new Vector3(0, 95.5f, 0),
new Vector3(2, 95.625f, 0),
new Vector3(1, 95.75f, 0),
new Vector3(2, 95.875f, 0),
new Vector3(0, 96f, 0),
new Vector3(1, 96.125f, 0),
new Vector3(2, 96.25f, 0),
new Vector3(1, 96.375f, 0),
new Vector3(0, 96.5f, 0),
new Vector3(3, 96.625f, 0),
new Vector3(2, 96.75f, 0),
new Vector3(3, 96.875f, 0),
new Vector3(0, 97f, 0),
new Vector3(2, 97.125f, 0),
new Vector3(1, 97.25f, 0),
new Vector3(3, 97.375f, 0),
new Vector3(0, 97.5f, 0),
new Vector3(3, 97.625f, 0),
new Vector3(1, 97.75f, 0),
new Vector3(2, 97.875f, 0),
new Vector3(0, 98f, 0),
new Vector3(1, 98.125f, 0),
new Vector3(2, 98.25f, 0),
new Vector3(1, 98.375f, 0),
new Vector3(0, 98.5f, 0),
new Vector3(2, 98.625f, 0),
new Vector3(1, 98.75f, 0),
new Vector3(2, 98.875f, 0),
new Vector3(0, 99f, 0),
new Vector3(3, 99.125f, 0),
new Vector3(2, 99.25f, 0),
new Vector3(1, 99.375f, 0),
new Vector3(0, 99.5f, 0),
new Vector3(3, 99.625f, 0),
new Vector3(1, 99.75f, 0),
new Vector3(2, 99.875f, 0),
new Vector3(1, 100f, 0),
new Vector3(3, 100.125f, 0),
new Vector3(2, 100.25f, 0),
new Vector3(1, 100.375f, 0),
new Vector3(0, 100.5f, 0),
new Vector3(3, 100.625f, 0),
new Vector3(1, 100.75f, 0),
new Vector3(3, 100.875f, 0),
new Vector3(0, 101f, 0),
new Vector3(1, 101.125f, 0),
new Vector3(2, 101.25f, 0),
new Vector3(3, 101.375f, 0),
new Vector3(0, 101.5f, 0),
new Vector3(3, 101.625f, 0),
new Vector3(1, 101.75f, 0),
new Vector3(2, 101.875f, 0),
new Vector3(0, 102f, 0),
new Vector3(0, 102.125f, 0),
new Vector3(2, 102.25f, 0),
new Vector3(2, 102.375f, 0),
new Vector3(1, 102.5f, 0),
new Vector3(1, 102.625f, 0),
new Vector3(3, 102.75f, 0),
new Vector3(3, 102.875f, 0),
new Vector3(2, 103f, 0),
new Vector3(2, 103.125f, 0),
new Vector3(1, 103.25f, 0),
new Vector3(1, 103.375f, 0),
new Vector3(0, 103.5f, 0),
new Vector3(0, 103.625f, 0),
new Vector3(3, 103.75f, 0),
new Vector3(3, 103.875f, 0),
new Vector3(1, 104f, 0),
new Vector3(3, 104f, 0)};
}
