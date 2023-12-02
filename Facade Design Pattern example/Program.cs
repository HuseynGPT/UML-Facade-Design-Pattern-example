#region subsytems

class JPEGConvertor
{
    private string File;

    public JPEGConvertor(string file)
    {
        File = file;
    }
    public void ConvertToJpeg()
    {
        Console.WriteLine("jpeg coverter");
    }
}


class BMPConvertor
{
    private string File;

    public BMPConvertor(string file)
    {
        File = file;
    }
    public void ConvertToBMP()
    {
        Console.WriteLine("bmp coverter");
    }
}

class PNGConvertor
{
    private string File;

    public PNGConvertor(string file)
    {
        File = file;
    }

    public void ConvertToPNG()
    {
        Console.WriteLine("png coverter");
    }
}



#endregion



#region Facade

class ImageCovertorFacade
{
    private JPEGConvertor JPEGConvertor;
    private PNGConvertor PNGConvertor;
    private BMPConvertor BMPConvertor;

    private string file;
    public ImageCovertorFacade(string file)
    {
        JPEGConvertor = new(file);
        PNGConvertor = new(file);
        BMPConvertor = new(file);
        this.file = file;
    }


    public void ConvertTOJpeg()
    {
        if (file != null) {

            JPEGConvertor.ConvertToJpeg();
        }
    }


    public void ConvertTOPNG()
    {
        if (file != null)
        {

            PNGConvertor.ConvertToPNG();
        }
    }

    public void ConvertTOBMP()
    {
        if (file != null)
        {

            BMPConvertor.ConvertToBMP();
        }
    }

}

#endregion