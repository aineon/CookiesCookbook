﻿namespace CookiesCookbookTutorSolution.FileAccess;

public class FileMetaData
{
    public string Name { get; }
    public FileFormat Format { get; }
    public FileMetaData(string name, FileFormat format)
    {
        Name = name;
        Format = format;
    }

    public string ToPath() => $"{Name}.{Format.AsFileExtension()}";
}
