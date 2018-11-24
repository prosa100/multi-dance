using System;
using System.Collections.Generic;
using System.Text;

namespace MultiDance
{
	public enum Arrow
	{
		Up,Down,Left,Right,
		Up2, Down2, Left2, Right2
	}

	public enum NoteType
	{
		Tap,
		Hold,
		Fake,
		Bomb,
		Custom
	}
    public class Note
    {
		public Arrow arrow;
		public NoteType type;
		public double start;
		public double? end;

		public override string ToString()
		{
			return $"{type} {arrow} {start}";
		}
	}
}
