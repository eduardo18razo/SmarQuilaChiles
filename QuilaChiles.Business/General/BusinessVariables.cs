namespace QuilaChiles.Business.General
{
    public class BusinessVariables
    {
        public static class ComboBox
        {
            public static int Index = 0;
            public static int ValueMember = 0;
            public static string DisplayMember = "SELECCIONE";
        }

        public static class OpenDialog
        {
            public static string FilterImages = @"Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|JGP files (*.jpg)|*.jpg|PNG (*.png)|*.png";
            public static string FileNameImages = string.Empty;
            public static string TitleImages = "Seleccionar imagen";
            public static string InitialDirectory = @"C:\";

        }
    }
}
