using System;
using System.Drawing;
using System.Windows.Forms;

public class Model
{
    private ImageList loadedTitleBanners = new ImageList();
    private ListView view;

    public Model(ListView view)
	{
        this.view = view;
        loadedTitleBanners.ImageSize = new Size(new Point(150, 185));
        loadedTitleBanners.ColorDepth = ColorDepth.Depth32Bit;
        view.LargeImageList = loadedTitleBanners;
	}

    //Adds a view element to the main ListView.
    public void addViewElement(string name, Image picture)
    {
        loadedTitleBanners.Images.Add(picture);
        view.Items.Add(name);
        view.Items[view.Items.Count - 1].ImageIndex = loadedTitleBanners.Images.Count - 1;
    }
}
