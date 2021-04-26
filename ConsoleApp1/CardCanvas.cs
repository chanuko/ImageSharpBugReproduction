using SixLabors.Fonts;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;

namespace ConsoleApp1
{
	internal class CardCanvas
	{
		public void CreateAndDraw(string filePath)
		{
			var txt = "　,　";
			var fontFamily = SystemFonts.Find("Yu Gothic");
			var font = new Font(fontFamily, 16);

			using (var image = new Image<Rgba32>(600, 300, Color.White))
			{
				try
				{
					image.Mutate(x => x
						.DrawText(txt, font, Color.Black, new PointF(0, 0))
					);
					image.SaveAsJpeg(filePath);
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
					throw;
				}
			}
		}

	}
}
