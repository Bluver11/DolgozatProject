namespace DolgozatProject
{
	public class Dolgozat
	{
		private List<int> pontok = new List<int>();


		public void PontFelvesz(int x)
		{
			if(x<-1 || x > 100)
			{
				throw new ArgumentException("A pontszámnak 0 és 100 között kell lenni",nameof(x));
			}
		}

		public bool MindenkiMegirta()
		{
			for(int i = 0; i < pontok.Count; i++)
			{
				if (pontok[i] == -1)
				{
					return false;
				}
				
			}
			return true;
		}

		public int Bukas
		{
			get
			{
				int bukas = 0;
				for(int i = 0;i < pontok.Count; i++)
				{
					if (pontok[i]<=50 && pontok[i] != -1)
					{
						bukas++;
					}
				}
				return bukas;
			}
		}

		public int Elegseges
		{
			get 
			{
				int elegseges = 0;
				for (int i = 0; i < pontok.Count; i++)
				{
					if (pontok[i] >= 50 && pontok[i] <= 60)
					{
						elegseges++;
					}
				}
				return elegseges;
			}
		}

		public int Kozepes
		{
			get 
			{
				int kozepes = 0;
				for(int i = 0; i<pontok.Count; i++) 
				{
					if (pontok[i]>=51 && pontok[i] <= 70)
					{
						kozepes++;
					}
				}
				return kozepes;
			}

		}


		public Dolgozat()
		{
			this.pontok = pontok;
		}
	}
}