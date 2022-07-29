using Godot;

namespace Com.LaytonCommunity.RavensCurse
{
	public enum Position { Left, Right }
	public enum Type { Base, ArmsCrossed, ArmsDown, ArmsUp, HoldingHat, PointsUp }
	public enum Emotion { None, Angry, Happy, VeryHappy, Pensive, Sad, Surpised, Thinking }

	public class Dialogue
	{
		string sceneName;
		string csvKey;
	}

	public class CharacterJson
	{
		string name;
		Type type;
		Emotion emotion;
		Position position;
		Dialogue dialogue;
	}
	
	public class CharacterManager : Node
	{
		public override void _Ready()
		{
			
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		public override void _Process(float delta)
		{

		}
	}
}
