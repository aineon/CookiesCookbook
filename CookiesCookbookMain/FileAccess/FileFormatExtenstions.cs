namespace CookiesCookbookTutorSolution.FileAccess;

public static class FileFormatExtenstions
{
    public static string AsFileExtension(this FileFormat fileFormat) => fileFormat == FileFormat.Json ? "json" : "txt";

}
