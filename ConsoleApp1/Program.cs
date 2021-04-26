using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var cardCanvas = new CardCanvas();

			//// case 1.
			//cardCanvas.CreateAndDraw($"case1_{1:D3}.jpg");

			// case 2.
			var options = new ParallelOptions
			{
				MaxDegreeOfParallelism = 4
			};
			Parallel.ForEach(Enumerable.Range(1, 10), options, item =>
			{
				cardCanvas.CreateAndDraw($"case2_{item:D3}.jpg");
			});
		}
	}
}
