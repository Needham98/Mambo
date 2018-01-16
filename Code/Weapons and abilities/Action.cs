using System;

namespace AssemblyCSharp
{
	public class Action
	{

		public List<Character> targets {get;set;}
		public int damage {get;set;}
		public int manaCost{get;set;}
		public string name{get;set;}
		public Character caster{get;set;}
		public int range {get;set;}


		public Action()
		{
		}


		public void doAction()
		{
			if(caster.CurrentMp > manaCost)
			{
				foreach (Character c in targets)
				{
					c.CurrentHp -= damage;
				}

				caster.CurrentMp -= manaCost;
			}
			else
			{
				
			}


		}


	}
}

